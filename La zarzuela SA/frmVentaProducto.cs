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
    public partial class frmVentaProducto : Form
    {
      

        FacturaVenta obj_facturaventa = new FacturaVenta();
    

        Productos obj_productos = new Productos();
        
        

        public frmVentaProducto()
        {
            InitializeComponent();

            dgvProductos.RowsAdded += dgvProductos_RowsAdded;

        }
        private void dgvProductos_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            try
            {
                // Índice de la fila recién agregada
                int newRowIdx = e.RowIndex;

                // Obtener el valor de la celda en la columna "Codigo" de la fila recién agregada
                var newValue = dgvProductos.Rows[newRowIdx].Cells["ProductoID"].Value;

                // Verificar si el valor ya está presente en otra fila
                foreach (DataGridViewRow row in dgvProductos.Rows)
                {
                    if (row.Index != newRowIdx) // Saltar la fila recién agregada
                    {
                        var existingValue = row.Cells["ProductoID"].Value;

                        // Si el valor ya existe, mostrar un mensaje de error y eliminar la fila recién agregada
                        if (newValue != null && existingValue != null && newValue.ToString() == existingValue.ToString())
                        {
                            obj_facturaventa.FacturaID1 = int.Parse(txtCodigoProducto.Text);
                            obj_facturaventa.EliminarProducto();
                            obj_facturaventa.LeerDetallesGridView();
                            dgvProductos.DataSource = obj_facturaventa.Tabla_Detalles;
                            throw new ArgumentException("El número de código ya existe en otra fila.");
                            

                            
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      

        private void frmVentaProducto_Load(object sender, EventArgs e)
        {



        }//fin frmVentaProducto_Load



        

        public void RecibirDatos(string codigo, string nombre, string cantidad, string precio)
        {
            Console.WriteLine("Nombre: " + nombre + " Codigo: " + codigo);

            txtNombreProducto.Text = nombre;
            txtCodigoProducto.Text = codigo;
            txtDisponible.Text = cantidad;
            txtPrecio.Text = precio;





        }
        public void RecibirDatosClientes(string codigo, string nombre, string tipo, string cedula)
        {


            txtNombreCliente.Text = nombre;
            txtCodigoCliente.Text = codigo;
            txtTipo.Text = tipo;
            txtCedula.Text = cedula;
            obj_facturaventa.RegistrarFactura(int.Parse(codigo), nombre,tipo,cedula, dtpFechaCompra.Value);




        }


        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

                txtCodigoProducto.Text = row.Cells[0].Value.ToString(); // Asignar el valor de la primera columna al textBoxNombre
                txtNombreProducto.Text = row.Cells[1].Value.ToString(); // Asignar el valor de la segunda columna al textBoxEdad
                txtDisponible.Text = row.Cells[2].Value.ToString(); // Asignar el valor de la tercera columna al textBoxCorreo
                txtPrecio.Text = row.Cells[3].Value.ToString();

            }
        }//fin dgvProductos_CellClick

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }//fin dgvClientes_CellClick

        



        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombreCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCantidadDeseada_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNuevoDisponible_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpFechaCompra_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            frmBuscarProducto frm = new frmBuscarProducto();
            frm.Show();


        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarProducto frm = new frmBuscarProducto();
            frm.Show();
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            txtNombreProducto.Text = "Porque nu funicona";
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            try
            {
                obj_productos.Codigo = int.Parse(txtCodigoProducto.Text);
                obj_productos.Precio = int.Parse(txtPrecio.Text);
                obj_productos.Nombre = txtNombreProducto.Text;
                obj_productos.Cantidad = int.Parse(txtDisponible.Text);
                obj_productos.CantidadDeseada = int.Parse(txtCantidadDeseada.Text);
                obj_productos.ValidarStock();

                obj_productos.Cantidad = int.Parse(txtCantidadDeseada.Text);
                obj_productos.ValidarProducto();
                
               

                obj_facturaventa.Codigoproducto = int.Parse(txtCodigoProducto.Text);
                obj_facturaventa.Cantidad = int.Parse(txtCantidadDeseada.Text);
                obj_facturaventa.Precio = int.Parse(txtPrecio.Text);
                obj_facturaventa.Nombreprodcuto = txtNombreProducto.Text;
                
                obj_productos.CalcularTotal();
                obj_facturaventa.Subtotal = obj_productos.Total;
                obj_facturaventa.Impuesto=obj_productos.Impuesto;
                obj_facturaventa.Total = obj_productos.TotalImpuesto;
                

               obj_facturaventa.InsertarDetallesFactura();

                obj_facturaventa.LeerDetallesGridView();
                dgvProductos.DataSource = obj_facturaventa.Tabla_Detalles;


                txtDisponible.Text = "";
                txtCantidadDeseada.Text = "";
                txtNombreProducto.Text = "";
                txtCodigoProducto.Text = "";
                txtPrecio.Text = "";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            frmBuscarCliente frm = new frmBuscarCliente();
            frm.Show();





        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            
            DialogResult result = MessageBox.Show("¿Seguro que quieres eliminar esta fila?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Verificar si hay una fila seleccionada
                if (dgvProductos.SelectedRows.Count > 0)
                {
                    // Obtener la primera fila seleccionada
                    DataGridViewRow selectedRow = dgvProductos.SelectedRows[0];

                    // Obtener el valor de una celda específica por índice de columna
                    int codigproducto = int.Parse(selectedRow.Cells["ProductoID"].Value.ToString());
                    obj_facturaventa.Codigoproducto = codigproducto;
                    
                    obj_facturaventa.EliminarProducto();
                    obj_facturaventa.LeerDetallesGridView();
                    dgvProductos.DataSource = obj_facturaventa.Tabla_Detalles;

                    // O alternativamente, puedes usar el índice de columna
                    // string cellValue = selectedRow.Cells[0].Value.ToString();


                }
                else
                {
                    MessageBox.Show("Por favor, seleccione una fila en el DataGridView.");
                }

            }
        }
        public void ActualizarInventarioDesdeUI()
        {
            // Itera sobre cada fila del DataGridView
            foreach (DataGridViewRow row in dgvProductos.Rows)
            {
                if (!row.IsNewRow)
                {
                    // Obtiene el código y la cantidad de la fila actual
                    string codigoProducto = row.Cells["ProductoID"].Value.ToString();
                    int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);

                    // Llama al método de la capa de negocio para actualizar el inventario
                    obj_facturaventa.ActualizarInventario(codigoProducto, cantidad);
                }
            }
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProductos.Rows.Count == 0)
                {
                    // El DataGridView está vacío
                    throw new Exception("No se han agregado productos a la factura");
                }
                ActualizarInventarioDesdeUI();
                txtCodigoProducto.Text = "";
                txtNombreProducto.Text = "";
                txtDisponible.Text = "";
                txtPrecio.Text = "";
                txtCantidadDeseada.Text = "";
                txtCodigoCliente.Text = "";
                txtNombreCliente.Text = "";
                txtTipo.Text = "";
                txtCedula.Text = "";

                dgvProductos.DataSource = null;
                MessageBox.Show("Venta realizada con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
       
        

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnBorrarFactura_Click(object sender, EventArgs e)
        {

        }

        private void lblBorrarFactura_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que quieres borrar la factura?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {


                    obj_facturaventa.EliminarFactura();
                    MessageBox.Show("Factura eliminada", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCodigoCliente.Text = "";
                    txtNombreCliente.Text = "";
                    txtTipo.Text = "";
                    txtCedula.Text = "";
                    txtCodigoProducto.Text = "";
                    txtNombreProducto.Text = "";
                    txtDisponible.Text = "";
                    txtPrecio.Text = "";
                    txtCantidadDeseada.Text = "";
                    dgvProductos.DataSource = null;



                }
                catch (Exception ex)
                {
                    MessageBox.Show("La factura contiene productos, eliminelos y vuelvalo a intentar: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
