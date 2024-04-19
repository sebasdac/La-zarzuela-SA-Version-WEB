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
     
        FacturaCompra obj_facturacompra = new FacturaCompra();
        Productos obj_productos = new Productos();
        public Agregar_inventario()
        {
            InitializeComponent();
        }

        private void Agregar_inventario_Load(object sender, EventArgs e)
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
            obj_facturacompra.Fecha1 = dtpFechaCompra.Value.ToString("yyyy-MM-dd HH:mm:ss");
            obj_facturacompra.InsertarFactura();

        }
        public void RecibirDatosProductos(string codigo, string nombre)
        {
            txtNombre.Text = nombre;
            txtCodigoProducto.Text = codigo;
            
            

        }





        private void btnBuscarporFactura_Click(object sender, EventArgs e)
        {
            frmVerProveedores frmVerProveedores = new frmVerProveedores();
            frmVerProveedores.Show();
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

        private void gbProveedor_Enter(object sender, EventArgs e)
        {

        }

        private void btnCompraRealizada_Click(object sender, EventArgs e)
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

        private void iconButton1_Click(object sender, EventArgs e)
        {
            frmBuscarProducto frm = new frmBuscarProducto();
            frm.Show();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

            obj_productos.Codigo = int.Parse(txtCodigoProducto.Text);
            obj_productos.Nombre = txtNombre.Text;
            obj_productos.Cantidad = int.Parse(txtCantidad.Text);
            obj_productos.Precio = int.Parse(txtPrecio.Text);
            obj_productos.ValidarProducto();
            obj_productos.ActualizarInventarioSuma(int.Parse(txtCodigoProducto.Text), int.Parse(txtCantidad.Text));
            




            obj_facturacompra.CodigoProducto = int.Parse(txtCodigoProducto.Text);
            obj_facturacompra.NombreProducto = txtNombre.Text;
            obj_facturacompra.Cantidad = int.Parse(txtCantidad.Text);
            obj_facturacompra.Precio = double.Parse(txtPrecio.Text);
            obj_facturacompra.CalcularTotal();
            obj_facturacompra.InsertarDetalleFactura();
            obj_facturacompra.LeerFacturaDGV();




            dgvProductos.DataSource = obj_facturacompra.Tabla_Detalles;
            txtCantidad.Text = "";
            txtPrecio.Text = "";
            txtCodigoProducto.Text = "";
            txtNombre.Text = "";
        }
        int filaSeleccionada;
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

                        obj_facturacompra.RestaInventario(txtCodigoProducto.Text, int.Parse(txtCantidad.Text));
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

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
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
    }
}
