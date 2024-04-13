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
        int filaSeleccionadaClientes;
        int filaSeleccionadaProductos;
        int totalProductos;
        int filaSeleccionada;

        FacturaVenta obj_facturaventa = new FacturaVenta();
        //objetos

        Clientes obj_cliente = new Clientes();
        Productos obj_productos = new Productos();
        VentaProducto obj_ventaproducto = new VentaProducto();
        ImpuestoMensual obj_impuestos = new ImpuestoMensual();

        public frmVentaProducto()
        {
            InitializeComponent();



        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                DataGridViewRow selectedRow = dgvProductos.CurrentRow;

                if (selectedRow != null)
                {


                    // Actualizar los valores de las celdas con los valores de los TextBox
                    selectedRow.Cells[2].Value = p.Text;

                    //cliente
                    obj_ventaproducto.CodigoCliente = int.Parse(txtCodigoCliente.Text);
                    obj_ventaproducto.NombreUsuario = txtNombreCliente.Text;
                    obj_ventaproducto.Cedula = txtCedula.Text;
                    obj_ventaproducto.Tipo = txtTipo.Text;

                    obj_ventaproducto.FechaCompra = DateTime.Parse(dtpFechaCompra.Text);
                    //producto
                    obj_ventaproducto.CodigoProducto = int.Parse(txtCodigoProducto.Text);
                    obj_ventaproducto.NombreProdcuto = txtNombreProducto.Text;
                    obj_ventaproducto.CantidadDeseada = double.Parse(txtCantidadDeseada.Text);
                    obj_ventaproducto.Disponible = int.Parse(txtDisponible.Text);
                    obj_ventaproducto.Impuesto = double.Parse(txtImpuesto.Text);
                    obj_ventaproducto.Total = double.Parse(txtTotal.Text);


                    obj_impuestos.Impuestofavor = double.Parse(txtImpuesto.Text);//manda impuesto a favor
                    obj_impuestos.Mes = DateTime.Parse(dtpFechaCompra.Text).Month;



                    //venta

                    obj_facturaventa.Codigocliente = int.Parse(txtCodigoCliente.Text);
                    obj_facturaventa.Nombrecliente = txtNombreCliente.Text;
                    obj_facturaventa.Cedula = txtCedula.Text;
                    obj_facturaventa.Tipo = txtTipo.Text;

                    obj_facturaventa.Codigoproducto = int.Parse(txtCodigoProducto.Text);
                    obj_facturaventa.Nombreprodcuto = txtNombreProducto.Text;
                    obj_facturaventa.Cantidad = int.Parse(txtCantidadDeseada.Text);
                    obj_facturaventa.Precio = int.Parse(txtPrecio.Text);
                    obj_facturaventa.Impuesto = double.Parse(txtImpuesto.Text);
                    ;
                    obj_facturaventa.TotalImpuesto = double.Parse(txtTotal.Text);








                    obj_productos.EscribeTablaalXML();
                    MessageBox.Show("Compra realizada", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //btnCalcular.Enabled = true;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtCodigoProducto.Text = "";
            txtNombreProducto.Text = "";
            txtDisponible.Text = "";
            txtPrecio.Text = "";
            txtCantidadDeseada.Text = "";
            txtImpuesto.Text = "";
            txtTotal.Text = "";
            p.Text = "";
            btnCompra.Enabled = false;




        }//fin btnComprar

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

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                obj_ventaproducto.NombreUsuario = txtNombreCliente.Text;
                obj_ventaproducto.CantidadDeseada = int.Parse(txtCantidadDeseada.Text);
                obj_ventaproducto.Disponible = int.Parse(txtDisponible.Text);
                obj_ventaproducto.Precio = int.Parse(txtPrecio.Text);
                obj_ventaproducto.ValidarDisponiblidad();
                obj_ventaproducto.CalcularPrecio();
                p.Text = obj_ventaproducto.TotalProductos.ToString();
                txtImpuesto.Text = obj_ventaproducto.Impuesto.ToString();
                txtTotal.Text = obj_ventaproducto.Totalimpuesto.ToString();





                obj_ventaproducto.ValidarBoton();



                if (obj_ventaproducto.Clickboton)
                {
                    btnCompra.Enabled = true;

                }
                //btnCalcular.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);

            }


        }//fin btnCalcular



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
                obj_productos.Cantidad = int.Parse(txtDisponible.Text);
                obj_productos.CantidadDeseada = int.Parse(txtCantidadDeseada.Text);
                obj_productos.ValidarStock();

                obj_productos.Precio = int.Parse(txtPrecio.Text);
                obj_productos.Cantidad = int.Parse(txtCantidadDeseada.Text);
                obj_productos.CalcularTotal();

                dgvProductos.Rows.Add(txtCodigoProducto.Text, txtNombreProducto.Text, txtCantidadDeseada.Text, txtPrecio.Text, obj_productos.Impuesto.ToString(), obj_productos.Total.ToString(), obj_productos.TotalImpuesto.ToString());
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
            }
        }
        
        private void iconButton3_Click(object sender, EventArgs e)
        {
            //Obtener los datos de la factura desde el DataGridView
            int clienteID = int.Parse(txtCodigoCliente.Text); // Por ejemplo, aquí obtienes el ID del cliente desde el DataGridView
            DateTime fecha = DateTime.Parse(dtpFechaCompra.Text); // Por ejemplo, aquí obtienes la fecha desde el DataGridView
            decimal total = ObtenerTotalDesdeDataGridView(); // Por ejemplo, aquí obtienes el total desde el DataGridView
            string nombre = txtNombreCliente.Text;
            string cedula = txtCedula.Text;
            string tipo = txtTipo.Text;

            // Obtener los detalles de la factura desde el DataGridView
            string[] NombreProductos = ObtenerProductoNombreIDsDesdeDataGridView();
            int[] productoIDs = ObtenerProductoIDsDesdeDataGridView();
            int[] cantidades = ObtenerCantidadesDesdeDataGridView();
            decimal[] precios = ObtenerPreciosDesdeDataGridView();
            decimal[] impuestos = ObtenerImpuestosDesdeDataGridView();
            decimal[] subtotales = ObtenerSubtotalesDesdeDataGridView();
            decimal[] totalesProductos = ObtenerTotalesProductosDesdeDataGridView();

            // Llamar al método de la capa de negocio para registrar la factura
            int facturaID = obj_facturaventa.RegistrarFactura(clienteID,nombre,cedula,tipo, fecha, total, productoIDs, cantidades, precios,impuestos,subtotales, totalesProductos, NombreProductos);

            MessageBox.Show("La factura se registró con éxito con el ID: " + facturaID);
        }
        // Métodos para obtener los datos de la factura desde el DataGridView
        private int[] ObtenerProductoIDsDesdeDataGridView()
        {
            List<int> productoIDs = new List<int>();

            // Recorre todas las filas del DataGridView
            foreach (DataGridViewRow fila in dgvProductos.Rows)
            {
                // Obtén el ID del producto de la columna correspondiente
                int productoID = Convert.ToInt32(fila.Cells["colCodigo"].Value);
                // Agrega el ID del producto a la lista
                productoIDs.Add(productoID);
            }

            // Convierte la lista de IDs de productos a un array y retórnala
            return productoIDs.ToArray();
        }

        private string[] ObtenerProductoNombreIDsDesdeDataGridView()
        {
            List<string> productoNombres = new List<string>();

            // Recorre todas las filas del DataGridView
            foreach (DataGridViewRow fila in dgvProductos.Rows)
            {
                // Obtén el ID del producto de la columna correspondiente
                string productonombre = fila.Cells["colProducto"].Value.ToString();
                // Agrega el ID del producto a la lista
                productoNombres.Add(productonombre);
            }

            // Convierte la lista de IDs de productos a un array y retórnala
            return productoNombres.ToArray();
        }

        private int[] ObtenerCantidadesDesdeDataGridView()
        {
            List<int> cantidades = new List<int>();

            // Recorre todas las filas del DataGridView
            foreach (DataGridViewRow fila in dgvProductos.Rows)
            {
                // Obtén la cantidad del producto de la columna correspondiente
                int cantidad = Convert.ToInt32(fila.Cells["colCantidad"].Value);
                // Agrega la cantidad a la lista
                cantidades.Add(cantidad);
            }

            // Convierte la lista de cantidades a un array y retórnala
            return cantidades.ToArray();
        }

        private decimal[] ObtenerPreciosDesdeDataGridView()
        {
            List<decimal> precios = new List<decimal>();

            // Recorre todas las filas del DataGridView
            foreach (DataGridViewRow fila in dgvProductos.Rows)
            {
                // Obtén el precio del producto de la columna correspondiente
                decimal precio = Convert.ToDecimal(fila.Cells["colPrecio"].Value);
                // Agrega el precio a la lista
                precios.Add(precio);
            }

            // Convierte la lista de precios a un array y retórnala
            return precios.ToArray();
        }

        private decimal[] ObtenerImpuestosDesdeDataGridView()
        {
            List<decimal> impuestos = new List<decimal>();

            // Recorre todas las filas del DataGridView
            foreach (DataGridViewRow fila in dgvProductos.Rows)
            {
                // Obtén el impuesto del producto de la columna correspondiente
                decimal impuesto = Convert.ToDecimal(fila.Cells["colImpuesto"].Value);
                // Agrega el impuesto a la lista
                impuestos.Add(impuesto);
            }

            // Convierte la lista de impuestos a un array y retórnala
            return impuestos.ToArray();
        }

        private decimal[] ObtenerSubtotalesDesdeDataGridView()
        {
            List<decimal> subtotales = new List<decimal>();

            // Recorre todas las filas del DataGridView
            foreach (DataGridViewRow fila in dgvProductos.Rows)
            {
                // Obtén el subtotal del producto de la columna correspondiente
                decimal subtotal = Convert.ToDecimal(fila.Cells["colSubtotal"].Value);
                // Agrega el subtotal a la lista
                subtotales.Add(subtotal);
            }

            // Convierte la lista de subtotales a un array y retórnala
            return subtotales.ToArray();
        }

        private decimal[] ObtenerTotalesProductosDesdeDataGridView()
        {
            List<decimal> totalesProductos = new List<decimal>();

            // Recorre todas las filas del DataGridView
            foreach (DataGridViewRow fila in dgvProductos.Rows)
            {
                // Obtén el total del producto de la columna correspondiente
                decimal totalProducto = Convert.ToDecimal(fila.Cells["colTotal"].Value);
                // Agrega el total del producto a la lista
                totalesProductos.Add(totalProducto);
            }

            // Convierte la lista de totales de productos a un array y retórnala
            return totalesProductos.ToArray();
        }
        private decimal ObtenerTotalDesdeDataGridView()
        {
            decimal total = 0;

            // Recorre todas las filas del DataGridView
            foreach (DataGridViewRow fila in dgvProductos.Rows)
            {
                // Obtén el total de la fila actual
                decimal totalFila = Convert.ToDecimal(fila.Cells["colTotal"].Value);
                // Suma el total de la fila al total general
                total += totalFila;
            }

            return total;
        }



    }
}
