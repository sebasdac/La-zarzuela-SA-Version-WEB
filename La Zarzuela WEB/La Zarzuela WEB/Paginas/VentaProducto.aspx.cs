using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace La_Zarzuela_WEB.Paginas
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        Productos obj_productos = new Productos();
        Clientes obj_clientes = new Clientes();
        FacturaVenta obj_facturaventa = new FacturaVenta();
        int facturaid;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }

        protected void btnSeleccionar_Click(object sender, EventArgs e)
        {
            lblCodigoMostrar.Text = DropDownList1.SelectedValue;
            lblNombreMostrar.Text = DropDownList1.SelectedItem.Text;
           
            obj_productos.Codigo = Convert.ToInt32(lblCodigoMostrar.Text);
            obj_productos.LeerProductoWEB();
            lblCantidadMostrar.Text = obj_productos.CantidadWEB.ToString();
            lblPrecioMostrar.Text = obj_productos.PrecioWEB.ToString();
            
        }

        protected void btnSeleccionarCliente_Click(object sender, EventArgs e)
        {
            lblCodigoMostrarCliente.Text = DropDownList2.SelectedValue;
            lblNombreMostrarCliente.Text = DropDownList2.SelectedItem.Text;
            obj_clientes.Codigo = Convert.ToInt32(lblCodigoMostrarCliente.Text);
            obj_clientes.LeerClienteWEB();
            lblMostrarCedula.Text = obj_clientes.CedulaWEB;
            lblMostrarTipo.Text = obj_clientes.TipoWEB;
            DateTime diaSeleccionado;
            diaSeleccionado = calFecha.SelectedDate;

            Console.WriteLine("Fecha seleccionada: " + diaSeleccionado.ToString());



            obj_facturaventa.RegistrarFactura(int.Parse(lblCodigoMostrarCliente.Text), lblNombreMostrarCliente.Text.ToString(), lblMostrarTipo.Text.ToString(), lblMostrarCedula.Text.ToString(), diaSeleccionado.ToString());
            Session["FacturaID"] = obj_facturaventa.FacturaIDWEB;

            
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {

            try
            {
                obj_productos.Codigo = int.Parse(lblCodigoMostrar.Text);
                obj_productos.Precio = int.Parse(lblPrecioMostrar.Text);
                obj_productos.Nombre = lblNombreMostrar.Text;
                obj_productos.Cantidad = int.Parse(lblCantidadMostrar.Text);
                obj_productos.CantidadDeseada = int.Parse(txtCantidadDeseada.Text);
                obj_productos.ValidarStock();

                obj_productos.Cantidad = int.Parse(txtCantidadDeseada.Text);
                obj_productos.ValidarProducto();



                obj_facturaventa.Codigoproducto = int.Parse(lblCodigoMostrar.Text);
                obj_facturaventa.Cantidad = int.Parse(txtCantidadDeseada.Text);
                obj_facturaventa.Precio = int.Parse(lblPrecioMostrar.Text);
                obj_facturaventa.Nombreprodcuto = lblNombreMostrar.Text;

                obj_productos.CalcularTotal();
                obj_facturaventa.Subtotal = obj_productos.Total;
                obj_facturaventa.Impuesto = obj_productos.Impuesto;
                obj_facturaventa.Total = obj_productos.TotalImpuesto;

                facturaid = (int)Session["FacturaID"];
                obj_facturaventa.InsertarDetallesFacturaWEB(facturaid);

                obj_facturaventa.LeerDetallesGridViewWEb(facturaid);
                dgvProductos.DataSource = obj_facturaventa.Tabla_Detalles;
                dgvProductos.DataBind();

                
                obj_facturaventa.ActualizarInventario(lblCodigoMostrar.Text, int.Parse(txtCantidadDeseada.Text));






                lblCodigoMostrar.Text = "";
               lblCedula.Text = "";
                lblNombreMostrar.Text = "";
                lblCantidadMostrar.Text = "";
                lblPrecioMostrar.Text = "";
                txtCantidadDeseada.Text = "";
                lblMensaje.Visible = true;
                lblMensaje.Text = "Producto agregado";
            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
                lblMensaje.Visible = true;
            }

        }

        protected void calFecha_SelectionChanged(object sender, EventArgs e)
        {

        }

        protected void dgvProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedIndex >= 0)
            {
                GridViewRow row = dgvProductos.SelectedRow;

                lblCodigoMostrar.Text = row.Cells[3].Text; // Asignar el valor de la primera columna al textBoxNombre
                lblNombreMostrar.Text = row.Cells[9].Text; // Asignar el valor de la segunda columna al textBoxEdad
                txtCantidadDeseada.Text = row.Cells[4].Text; // Asignar el valor de la tercera columna al textBoxCorreo
                lblPrecioMostrar.Text = row.Cells[5].Text;
                lblFacturaIDMostrar.Text = row.Cells[2].Text;


                // Puedes añadir más acciones aquí si lo necesitas
            }
        }
      

        protected void btnGenerarFactura_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProductos.Rows.Count == 0)
                {
                    // El DataGridView está vacío
                    throw new Exception("No se han agregado productos a la factura");
                }


                lblCodigoMostrar.Text = "";
                lblNombreMostrar.Text = "";
                lblCantidadMostrar.Text = "";
                lblPrecioMostrar.Text = "";
                txtCantidadDeseada.Text = "";

                lblMensaje.Text = "Compra realizada exitosamente";
                lblMensaje.Visible = true;
                lblCodigoMostrarCliente.Text = "";
                lblNombreMostrarCliente.Text = "";
                lblMostrarCedula.Text = "";
                lblMostrarTipo.Text = "";
                dgvProductos.DataSource = null;
                dgvProductos.DataBind();
            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
                lblMensaje.Visible = true;
            }

        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                
                obj_facturaventa.Codigoproducto = int.Parse(lblCodigoMostrar.Text);
                obj_facturaventa.EliminarProducto();
                int facturaid = (int)Session["FacturaID"];
                obj_facturaventa.LeerDetallesGridViewWEb(facturaid);
                dgvProductos.DataSource = obj_facturaventa.Tabla_Detalles;
                dgvProductos.DataBind();
                obj_productos.ActualizarInventarioSuma(int.Parse(lblCodigoMostrar.Text), int.Parse(txtCantidadDeseada.Text));



                lblCantidadMostrar.Text = "";
                lblPrecioMostrar.Text = "";
                lblNombreMostrar.Text = "";
                lblCodigoMostrar.Text = "";
                txtCantidadDeseada.Text = "";
                lblMensaje.Text = "";
            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
                lblMensaje.Visible = true;
            }



        }

        protected void btnEliminarFactura_Click(object sender, EventArgs e)
        {

            try
            {
                facturaid = (int)Session["FacturaID"];
                obj_facturaventa.FacturaID1 = facturaid;
                obj_facturaventa.EliminarFacturaWEB();
                lblMensaje.Text = "Factura eliminada";
                lblMensaje.Visible = true;
            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
                lblMensaje.Visible = true;
            }
        }
    }
}