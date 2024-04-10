using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace La_zarzuela_SA
{
    public partial class frmAgregarProducto : Form
    {
        int filaSeleccionada; //guarda indice
        Productos obj_productos = new Productos(); // objeto productos
        Proveedor obj_proveedor = new Proveedor();
        ImpuestoMensual obj_impuestos = new ImpuestoMensual();
       
        FacturaCompra obj_facturacompra = new FacturaCompra();
        

        //vericiar seleccion en dgv
        bool productos;
        bool proveedor;
        public frmAgregarProducto()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmAgregarProducto_Load(object sender, EventArgs e)
        {
           


        }
       
       





        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                obj_productos.Codigo = int.Parse(txtCodigoProducto.Text);
                obj_productos.Nombre = txtNombre.Text;
                obj_productos.Cantidad = int.Parse(txtCantidad.Text);
                obj_productos.Precio = int.Parse(txtPrecio.Text);
                obj_productos.CodigoProveedor = int.Parse(txtCodigoProveedor.Text);
                obj_productos.NombreProveedor = txtProveedor.Text;
                obj_productos.Fechacompra = DateTime.Parse(dtpFechaCompra.Text);
                obj_productos.ValidarProducto();
                obj_productos.CalcularTotal();
               
                lblImpuestoMostrar.Text = obj_productos.Impuesto.ToString();
                lblTotalMostrar.Text =  obj_productos.TotalImpuesto.ToString();
                
                obj_impuestos.Mes = DateTime.Parse(dtpFechaCompra.Text).Month;//le pasamos el mes
                obj_impuestos.Impuestocontra = double.Parse(lblImpuestoMostrar.Text);//pasa el impuesto a favor

                //factura compra
                
                obj_facturacompra.CodigoProveedor = int.Parse(txtCodigoProveedor.Text);
                obj_facturacompra.NombreProveedor = txtProveedor.Text;
                obj_facturacompra.Fecha = dtpFechaCompra.Text;
                
                obj_facturacompra.CodigoProducto = int.Parse(txtCodigoProducto.Text);
                obj_facturacompra.NombreProducto = txtNombre.Text;
                obj_facturacompra.Cantidad = int.Parse(txtCantidad.Text);
                obj_facturacompra.Precio = double.Parse(txtPrecio.Text);
                obj_facturacompra.Total = obj_productos.TotalImpuesto;
                
                obj_productos.EscribeProductoDT();




                
                
                obj_productos.EscribeProductoBD();
                obj_productos.EscribeTablaalXML();
            }//fin try
            catch (Exception ex)
            {
                 MessageBox.Show("Error: " + ex.Message);

            }// fin catch
            txtCodigoProducto.Text = "";
            txtNombre.Text = "";
            txtCantidad.Text = "";
            txtPrecio.Text = "";
            btnAgregar.Enabled = false;
            

        }

        private void frmAgregarProducto_FormClosing(object sender, FormClosingEventArgs e)
        {
            obj_productos.EscribeTablaalXML();//guarda los datos en el xml
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProductos.Rows[e.RowIndex];
                txtCantidad.Enabled = false;
                txtCodigoProducto.Text = row.Cells[0].Value.ToString(); // Asignar el valor de la primera columna al textBoxNombre
                txtNombre.Text = row.Cells[1].Value.ToString(); // Asignar el valor de la segunda columna al textBoxEdad
                txtCantidad.Text = row.Cells[2].Value.ToString(); // Asignar el valor de la tercera columna al textBoxCorreo
                txtPrecio.Text = row.Cells[3].Value.ToString();
                lblImpuestoMostrar.Text = row.Cells[4].Value.ToString();
                lblTotalMostrar.Text = row.Cells[5].Value.ToString();
            }//fin if
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgvProductos.CurrentRow;
            DialogResult result = MessageBox.Show("¿Seguro que quieres eliminar esta fila?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    if (filaSeleccionada >= 0)
                    {

                        dgvProductos.Rows.Remove(selectedRow);
                        obj_productos.EscribeTablaalXML();
                    }//fin if
                }//fin try
                catch
                {
                    MessageBox.Show("No se ha seleccionado ninguna fila");
                }//fin catch
                txtCodigoProducto.Text = "";
                txtNombre.Text = "";
                txtCantidad.Text = "";
                txtPrecio.Text = "";
                lblImpuestoMostrar.Text = "";
                lblTotalMostrar.Text = "";
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = dgvProductos.CurrentRow;

                if (selectedRow != null)
                {
                    obj_productos.Codigo = int.Parse(txtCodigoProducto.Text);
                    obj_productos.Nombre = txtNombre.Text;
                    obj_productos.Cantidad = int.Parse(txtCantidad.Text);
                    obj_productos.Precio = int.Parse(txtPrecio.Text);

                    obj_productos.ValidarProducto();
                    //obj_productos.CalcularTotal();
                    
                    //lblImpuestoMostrar.Text = obj_productos.Impuesto.ToString();
                    //lblTotalMostrar.Text = obj_productos.TotalImpuesto.ToString();


                    
                    selectedRow.Cells[0].Value = txtCodigoProducto.Text;
                    selectedRow.Cells[1].Value = txtNombre.Text;
                    selectedRow.Cells[2].Value = txtCantidad.Text;
                    selectedRow.Cells[3].Value = txtPrecio.Text;
                    selectedRow.Cells[4].Value = lblImpuestoMostrar.Text ;
                    selectedRow.Cells[5].Value = lblTotalMostrar.Text; 
                    
                    obj_productos.EscribeTablaalXML();
                }//fin if
            }//fin try
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }//fin catch
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProveedor.Rows[e.RowIndex];

                txtCodigoProveedor.Text = row.Cells[0].Value.ToString(); // Asignar el valor de la primera columna al 
                txtProveedor.Text = row.Cells[1].Value.ToString(); // Asignar el valor de la segunda columna al 

            }//fin if
            // Verifica si se ha hecho clic en una fila válida
            if (e.RowIndex >= 0 && e.RowIndex < dgvProveedor.Rows.Count)
            {
                DataGridViewRow row = dgvProveedor.Rows[e.RowIndex];

                // Verifica si la fila seleccionada está llena
                if (!EsFilaVacia(row))
                {
                    btnAgregar.Enabled = true; // Habilita el botón
                }// fin if
                else
                {
                    btnAgregar.Enabled = false; // Deshabilita el botón
                }//fin else
            }//fin if
        }
        private bool EsFilaVacia(DataGridViewRow row)
        {
            foreach (DataGridViewCell cell in row.Cells)
            {
                if (cell.Value != null && !string.IsNullOrWhiteSpace(cell.Value.ToString()))
                {
                    return false;
                }
            }
            return true;
        }//fin del metodo

        private void dgvProveedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dtpFechaCompra_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblTotalMostrar_Click(object sender, EventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void lblImpuestoMostrar_Click(object sender, EventArgs e)
        {

        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodigoProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblImpuesto_Click(object sender, EventArgs e)
        {

        }

        private void lblPrecio_Click(object sender, EventArgs e)
        {

        }

        private void lblCantidad_Click(object sender, EventArgs e)
        {

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        //private void dgvProductos_SelectionChanged(object sender, EventArgs e)
        //{
        //    // Verifica si se ha seleccionado al menos una fila en dgvProductos
        //    productos = dgvProductos.SelectedRows.Count > 0;

        //    // Verifica si ambos productos y proveedores están seleccionados para habilitar el botón Agregar
        //    btnAgregar.Enabled = productos && proveedor;
        //}



    }

}
