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
            dgvProductos.RowsAdded += dgvProductos_RowsAdded;

        }
        private void dgvProductos_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            // Índice de la fila recién agregada
            int newRowIdx = e.RowIndex;

            // Obtener el valor de la celda en la columna "Codigo" de la fila recién agregada
            var newValue = dgvProductos.Rows[newRowIdx].Cells["colCodigo"].Value;

            // Verificar si el valor ya está presente en otra fila
            foreach (DataGridViewRow row in dgvProductos.Rows)
            {
                if (row.Index != newRowIdx) // Saltar la fila recién agregada
                {
                    var existingValue = row.Cells["colCodigo"].Value;

                    // Si el valor ya existe, mostrar un mensaje de error y eliminar la fila recién agregada
                    if (newValue != null && existingValue != null && newValue.ToString() == existingValue.ToString())
                    {
                        MessageBox.Show("El número de código ya existe en otra fila.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dgvProductos.Rows.RemoveAt(newRowIdx);
                        return;
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmAgregarProducto_Load(object sender, EventArgs e)
        {
            


        }
        public void RecibirDatos(string codigo, string nombre, string cantidad, string cedula)
        {
            Console.WriteLine("Nombre: " + nombre + " Codigo: " + codigo);

            txtCodigoProveedor.Text = codigo;
            txtProveedor.Text = nombre;
            txtTipo.Text = cantidad;
            txtCedula.Text = cedula;

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
                
                
                
                obj_productos.EscribeProductoBD();
                obj_productos.LeeTablaProducto();
                dgvProductos.DataSource = obj_productos.Tabla_Productos;
                
            }//fin try
            catch (Exception ex)
            {
                 MessageBox.Show("Error: " + ex.Message);

            }// fin catch
            txtCodigoProducto.Text = "";
            txtNombre.Text = "";
            txtCantidad.Text = "";
            txtPrecio.Text = "";
            //btnAgregar.Enabled = false;
            

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
                obj_productos.CodigoProveedor = int.Parse(txtCodigoProveedor.Text);
                obj_productos.Cantidad = int.Parse(txtCantidad.Text);
                obj_productos.Precio = int.Parse(txtPrecio.Text);
                obj_productos.Nombre = txtNombre.Text;
                obj_productos.Codigo = int.Parse(txtCodigoProducto.Text);
                
                obj_productos.ValidarProducto();
                
                obj_productos.ValidarCodigoRepetido(); // Verifica si el código del producto ya existe en la base de datos


                obj_productos.Precio = int.Parse(txtPrecio.Text);
                obj_productos.Cantidad = int.Parse(txtCantidad.Text);
                obj_productos.CalcularTotal();



                dgvProductos.Rows.Add(txtCodigoProducto.Text, txtNombre.Text, txtCantidad.Text, txtPrecio.Text, obj_productos.Impuesto.ToString(), obj_productos.Total.ToString(), obj_productos.TotalImpuesto.ToString());
                txtCantidad.Text = "";
                
                txtNombre.Text = "";
                txtCodigoProducto.Text = "";
                txtPrecio.Text = "";
                lblImpuestoMostrar.Text = "";
                lblTotalMostrar.Text = "";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
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

               


                
                obj_facturacompra.NombreProveedor = txtProveedor.Text;
                obj_facturacompra.ValidarProveedor();


                //Obtener los datos de la factura desde el DataGridView
                int clienteID = int.Parse(txtCodigoProveedor.Text); // Por ejemplo, aquí obtienes el ID del cliente desde el DataGridView
                DateTime fecha = DateTime.Parse(dtpFechaCompra.Text); // Por ejemplo, aquí obtienes la fecha desde el DataGridView
                decimal total = ObtenerTotalDesdeDataGridView(); // Por ejemplo, aquí obtienes el total desde el DataGridView
                string nombre = txtProveedor.Text;
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

                obj_productos.InsertarProducto(productoIDs, cantidades, precios, impuestos, totalesProductos, NombreProductos);

                // Llamar al método de la capa de negocio para registrar la factura
                int facturaID = obj_facturacompra.RegistrarFactura(clienteID, nombre, cedula, tipo, fecha, total, productoIDs, cantidades, precios, impuestos, subtotales, totalesProductos, NombreProductos);


                

                dgvProductos.Rows.Clear();
                txtCodigoProveedor.Text = "";
                txtNombre.Text = "";
                txtCedula.Text = "";
                txtTipo.Text = "";
                txtProveedor.Text = "";


                MessageBox.Show("La factura se registró con éxito con el ID: " + facturaID);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la factura: " + ex.Message);
            }


        }
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
        



        //private void dgvProductos_SelectionChanged(object sender, EventArgs e)
        //{
        //    // Verifica si se ha seleccionado al menos una fila en dgvProductos
        //    productos = dgvProductos.SelectedRows.Count > 0;

        //    // Verifica si ambos productos y proveedores están seleccionados para habilitar el botón Agregar
        //    btnAgregar.Enabled = productos && proveedor;
        //}



    }

}
