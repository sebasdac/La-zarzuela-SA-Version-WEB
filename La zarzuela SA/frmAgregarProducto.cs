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
        public void RecibirDatos(string codigo, string nombre, string tipo, string cedula)
        {
            Console.WriteLine("Nombre: " + nombre + " Codigo: " + codigo);

            txtCodigoProveedor.Text = codigo;
            txtProveedor.Text = nombre;
            txtTipo.Text = tipo;
            txtCedula.Text = cedula;

            obj_facturacompra.CodigoProveedor = int.Parse(codigo);
            obj_facturacompra.NombreProveedor = nombre;
            obj_facturacompra.Cedulaproveedor = cedula;
            obj_facturacompra.Tipo = tipo;
            obj_facturacompra.Fecha1 = dtpFechaCompra.Value;
            obj_facturacompra.InsertarFactura();

        }







        private void btnAgregar_Click(object sender, EventArgs e)
        {
           
           
            

        }

        private void frmAgregarProducto_FormClosing(object sender, FormClosingEventArgs e)
        {
           
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
              
            }
        }

        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }
       

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

        private void gbProveedor_Enter(object sender, EventArgs e)
        {

        }

        private void btnBuscarporFactura_Click(object sender, EventArgs e)
        {
            frmVerProveedores frm = new frmVerProveedores();
            frm.Show();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            try
            {
                obj_productos.Codigo = int.Parse(txtCodigoProducto.Text);
                obj_productos.Nombre = txtNombre.Text;
                obj_productos.Cantidad = int.Parse(txtCantidad.Text);
                obj_productos.Precio = int.Parse(txtPrecio.Text);
                obj_productos.Cantidad = int.Parse(txtCantidad.Text);
                obj_productos.Precio = int.Parse(txtPrecio.Text);
                obj_productos.CalcularTotal();
                obj_productos.ValidarProducto();
                obj_productos.EscribeProductoBD();


                obj_facturacompra.CodigoProducto = int.Parse(txtCodigoProducto.Text);
                obj_facturacompra.NombreProducto = txtNombre.Text;
                obj_facturacompra.Cantidad = int.Parse(txtCantidad.Text);
                obj_facturacompra.Precio = double.Parse(txtPrecio.Text);
                obj_facturacompra.Cantidad = int.Parse(txtCantidad.Text);
                obj_facturacompra.Precio = double.Parse(txtPrecio.Text);
                obj_facturacompra.CalcularTotal();
                obj_facturacompra.InsertarDetalleFactura();
                obj_facturacompra.LeerFacturaDGV();
                dgvProductos.DataSource = obj_facturacompra.Tabla_Detalles;


               





                txtCantidad.Text = "";
                txtNombre.Text = "";
                txtCodigoProducto.Text = "";
                txtPrecio.Text = "";
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }

       
       

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgvProductos.CurrentRow;
            DialogResult result = MessageBox.Show("¿Seguro que quieres eliminar esta fila?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    if (filaSeleccionada >= 0)
                    {

                        obj_productos.Codigo = int.Parse(txtCodigoProducto.Text);
                        obj_productos.EliminarProducto();

                        obj_facturacompra.CodigoProducto = int.Parse(txtCodigoProducto.Text);
                        obj_facturacompra.EliminarProductoFactura();
                        obj_facturacompra.LeerFacturaDGV();
                        dgvProductos.DataSource = obj_facturacompra.Tabla_Detalles;
                        
                        txtCantidad.Text = "";
                        
                        txtNombre.Text = "";
                        txtCodigoProducto.Text = "";
                        txtPrecio.Text = "";

                    }//fin if
                }//fin try
                catch
                {
                    MessageBox.Show("No se ha seleccionado ninguna fila");
                }//fin catch
            }
        }

        private void dgvProductos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvProductos_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProductos.Rows[e.RowIndex];

                txtCodigoProducto.Text = row.Cells[2].Value.ToString(); // Asignar el valor de la primera columna al 
                txtNombre.Text = row.Cells[3].Value.ToString(); // Asignar el valor de la segunda columna al 
                txtCantidad.Text = row.Cells[4].Value.ToString(); // Asignar el valor de la tercera columna al
                txtPrecio.Text = row.Cells[5].Value.ToString(); // Asignar el valor de la cuarta columna al   
                


            }
        }

        private void btnBorrarFactura_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que quieres borrar la factura?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {


                    obj_facturacompra.EliminarFactura();
                    MessageBox.Show("Factura eliminada", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCodigoProveedor.Text = "";
                    txtNombre.Text = "";
                    txtTipo.Text = "";
                    txtCedula.Text = "";
                    txtCodigoProducto.Text = "";
                    txtProveedor.Text = "";
                    txtCantidad.Text = "";
                    txtPrecio.Text = "";
                    txtTipo.Text = "";
                    

                    dgvProductos.DataSource = null;



                }
                catch (Exception ex)
                {
                    MessageBox.Show("La factura contiene productos, eliminelos y vuelvalo a intentar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnCompraRealizada_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProductos.Rows.Count == 0)
                {
                    // El DataGridView está vacío
                    throw new Exception("No se han agregado productos a la factura");
                }




                txtTipo.Text = "";
                txtCodigoProducto.Text = "";
                txtProveedor.Text = "";
                txtCantidad.Text = "";
                txtPrecio.Text = "";
                txtNombre.Text = "";
                txtCodigoProveedor.Text = "";
                txtCedula.Text = "";
                txtTipo.Text = "";
                txtProveedor.Text = "";
                txtCantidad.Text = "";
                dgvProductos.DataSource = null;
                MessageBox.Show("La factura se registró con éxito");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la factura: " + ex.Message);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }

}
