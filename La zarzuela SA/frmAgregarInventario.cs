using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace La_zarzuela_SA
{
    public partial class Agregar_inventario : Form
    {
        //objeto
        Productos obj_productos = new Productos();
        Proveedor obj_proveedor = new Proveedor();
        FacturaCompra obj_facturacompra = new FacturaCompra();
        //verificar click boton
        bool proveedor;
        bool productos;
        ImpuestoMensual obj_impuestos = new ImpuestoMensual();
        public Agregar_inventario()
        {
            InitializeComponent();
        }

        private void Agregar_inventario_Load(object sender, EventArgs e)
        {
            


        }

        private void dgvProveedor_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Verifica si se hizo clic en la fila del proveedor
            if (e.RowIndex >= 0 && dgvProveedor.Rows[e.RowIndex].Cells["Codigo"].Value != null)
            {
                // Aquí puedes agregar lógica específica para cuando se hace clic en la fila del proveedor
                proveedor = true;
            }

            // Verifica si ambos productos y proveedores están seleccionados para habilitar el botón Agregar
            btnVerificar.Enabled =  proveedor;
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        

       

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProductos.Rows[e.RowIndex];

                txtCodigoProducto.Text = row.Cells[0].Value.ToString(); // Asignar el valor de la primera columna al textBoxNombre
                txtNombre.Text = row.Cells[1].Value.ToString(); // Asignar el valor de la segunda columna al textBoxEdad
                 // Asignar el valor de la tercera columna al textBoxCorreo
                txtPrecio.Text = row.Cells[3].Value.ToString();
                
            }
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            try
            {
                int CantidadTotal = 0;
                int CantidadActual;
                int CantidadAgregada = 0;

                double ImpuestoActual = 0;
                double ImpuestoAgregado = 0;
                double ImpuestoNuevo = 0;

                double TotalActual = 0;
                double TotalAgregado = 0;
                double TotalNuevo = 0;


                obj_productos.Cantidad = int.Parse(txtCantidadAgregada.Text);

                obj_productos.ValidarCantidad();
                if (dgvProductos.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgvProductos.SelectedRows[0];
                    // Obtener el valor de la primera celda de la fila seleccionada
                    CantidadActual = int.Parse(selectedRow.Cells[2].Value.ToString());


                    Console.WriteLine("Cantidad actual: " + CantidadActual);
                    CantidadAgregada = int.Parse(txtCantidadAgregada.Text);
                    CantidadTotal = CantidadAgregada + CantidadActual;
                    // Hacer algo con el valor obtenido
                    selectedRow.Cells[2].Value = CantidadTotal.ToString();
                    obj_productos.Precio = int.Parse(txtPrecio.Text);
                    obj_productos.Cantidad = int.Parse(txtCantidadAgregada.Text);

                    obj_productos.CalcularTotal();

                    obj_productos.Nombre = txtNombre.Text; //para validar boton

                    lblImpuestoMostrar.Text = obj_productos.Impuesto.ToString();//  mostrar impuesto
                    lblTotalMostrar.Text = obj_productos.TotalImpuesto.ToString();//mostrar total
                    //impuesto despues que se ponga en el lbl
                    ImpuestoActual = double.Parse(selectedRow.Cells[4].Value.ToString());//impuesto actual
                    ImpuestoAgregado = double.Parse(lblImpuestoMostrar.Text);//impuesto agregado
                    ImpuestoNuevo = ImpuestoActual + ImpuestoAgregado;//impuesto nuevo
                    selectedRow.Cells[4].Value = ImpuestoNuevo.ToString();//asignar el impuesto nuevo

                    //total

                    TotalActual = double.Parse(selectedRow.Cells[5].Value.ToString());//total actual
                    TotalAgregado = double.Parse(lblTotalMostrar.Text);//total agregado
                    TotalNuevo = TotalActual + TotalAgregado;//total nuevo
                    selectedRow.Cells[5].Value = TotalNuevo.ToString();//asignar el total nuevo
                    obj_productos.ValidarBoton();//validar boton
                    if (obj_productos.Clickboton)
                    {
                        btnAgregar.Enabled = true;

                    }//fin if


                }//fin if
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: la cantidad no puede estar vacia o seleccione el proveedor"+ex.Message  , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvProveedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProveedor.Rows[e.RowIndex];

                txtCodigoProveedor.Text = row.Cells[0].Value.ToString(); // Asignar el valor de la primera columna al 
                txtProveedor.Text = row.Cells[1].Value.ToString(); // Asignar el valor de la segunda columna al 

            }
            
        }

        private void dgvProveedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                obj_productos.Codigo = int.Parse(txtCodigoProducto.Text);
                obj_productos.Nombre = txtNombre.Text;
                obj_productos.Cantidad = int.Parse(txtCantidadAgregada.Text);
                obj_productos.Precio = int.Parse(txtPrecio.Text);
                obj_productos.CodigoProveedor = int.Parse(txtCodigoProveedor.Text);
                obj_productos.NombreProveedor = txtProveedor.Text;
                obj_productos.Fechacompra = DateTime.Parse(dtpFechaCompra.Text);
                
              
                
                lblImpuestoMostrar.Text = obj_productos.Impuesto.ToString();
                lblTotalMostrar.Text = obj_productos.TotalImpuesto.ToString();
                
                
                
                obj_productos.EscribeTablaalXML();

                obj_impuestos.Impuestocontra = double.Parse(lblImpuestoMostrar.Text);
                obj_impuestos.Mes = DateTime.Parse(dtpFechaCompra.Text).Month;
               
                MessageBox.Show("Compra realizada", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //factura

                obj_facturacompra.CodigoProducto = int.Parse(txtCodigoProducto.Text);
                obj_facturacompra.NombreProducto = txtNombre.Text;
                obj_facturacompra.Cantidad = int.Parse(txtCantidadAgregada.Text);
                obj_facturacompra.Precio = double.Parse(txtPrecio.Text);
                obj_facturacompra.Total = obj_productos.TotalImpuesto;
                obj_facturacompra.CodigoProveedor = int.Parse(txtCodigoProveedor.Text);
                obj_facturacompra.NombreProveedor = txtProveedor.Text;
                obj_facturacompra.Fecha = dtpFechaCompra.Text;
             








            }//fin try
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);

            }// fin catch
            txtCodigoProducto.Text = "";
            txtNombre.Text = "";
            
            txtPrecio.Text = "";
            btnAgregar.Enabled = false;

        }
    }
}
