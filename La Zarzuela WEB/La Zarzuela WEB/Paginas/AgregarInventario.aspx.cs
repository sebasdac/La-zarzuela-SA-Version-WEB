using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace La_Zarzuela_WEB.Paginas
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        Proveedor obj_proveedor = new Proveedor();
        FacturaCompra obj_facturacompra = new FacturaCompra();
        Productos obj_productos = new Productos();
        int facturaid;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            lblCodigoMostrarCliente.Text = DropDownList2.SelectedValue;
            lblNombreMostrarCliente.Text = DropDownList2.SelectedItem.Text;
            obj_proveedor.Codigo = Convert.ToInt32(lblCodigoMostrarCliente.Text);
            obj_proveedor.LeerProveedorWEB();
            lblMostrarCedula.Text = obj_proveedor.CedulaWEB;
            lblMostrarTipo.Text = obj_proveedor.TipoWEB;

            DateTime diaSeleccionado;
            diaSeleccionado = calFecha.SelectedDate;

            Console.WriteLine("Fecha seleccionada: " + diaSeleccionado.ToString());

            //_CodigoProveedor, _NombreProveedor,
            //    _cedulaproveedor, _tipo, Fecha1

            obj_facturacompra.CodigoProveedor = int.Parse(lblCodigoMostrarCliente.Text);
            obj_facturacompra.NombreProveedor = lblNombreMostrarCliente.Text;
            obj_facturacompra.Cedulaproveedor = lblMostrarCedula.Text;
            obj_facturacompra.Tipo = lblMostrarTipo.Text;
            obj_facturacompra.Fecha1 = diaSeleccionado.ToString();
            obj_facturacompra.InsertarFactura();

            Session["FacturaID"] = obj_facturacompra.FacturaIDWEB;
        }

        protected void btnEliminarFactura_Click(object sender, EventArgs e)
        {
            try
            {
                facturaid = (int)Session["FacturaID"];
                obj_facturacompra.FacturaID = facturaid;
                obj_facturacompra.EliminarFacturaWEB();
                lblMensaje.Text = "Factura eliminada";
                lblMensaje.Visible = true;
                lblMostrarTipo.Text = "";
                lblMostrarCedula.Text = "";
                lblNombreMostrarCliente.Text = "";
                lblCodigoMostrarCliente.Text = "";

            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
                lblMensaje.Visible = true;
            }
        }

        protected void btnSeleccionarProducto_Click(object sender, EventArgs e)
        {
            lblCodigoMostrar.Text = DropDownList3.SelectedValue;
            lblNombreMostrar.Text = DropDownList3.SelectedItem.Text;

            obj_productos.Codigo = Convert.ToInt32(lblCodigoMostrar.Text);
            obj_productos.LeerProductoWEB();
            lblCantidadMostrar.Text = obj_productos.CantidadWEB.ToString();
            
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                facturaid = (int)Session["FacturaID"];
                obj_productos.Codigo = int.Parse(lblCodigoMostrar.Text);
                obj_productos.Nombre = lblNombreMostrar.Text;
                obj_productos.Cantidad = int.Parse(txtCantidadDeseada.Text);
                obj_productos.Precio = int.Parse(txtPrecio.Text);
                obj_productos.ValidarProducto();
                obj_productos.ActualizarInventarioSuma(int.Parse(lblCodigoMostrar.Text), int.Parse(txtCantidadDeseada.Text));

                obj_facturacompra.CodigoProducto = int.Parse(lblCodigoMostrar.Text);
                obj_facturacompra.NombreProducto = lblNombreMostrar.Text;
                obj_facturacompra.Cantidad = int.Parse(txtCantidadDeseada.Text);
                obj_facturacompra.Precio = double.Parse(txtPrecio.Text);
                obj_facturacompra.CalcularTotal();
                obj_facturacompra.InsertarDetalleFacturaWEB(facturaid);


                obj_facturacompra.LeerDetallesWEB(facturaid);
                dgvProductos.DataSource = obj_facturacompra.Tabla_Detalles;
                dgvProductos.DataBind();




                dgvProductos.DataSource = obj_facturacompra.Tabla_Detalles;
                lblMensaje.Text = "";
                lblCodigoMostrar.Text = "";
                lblNombreMostrar.Text = "";
                lblCantidadMostrar.Text = "";
                txtPrecio.Text = "";
                txtCantidadDeseada.Text = "";

            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
                lblMensaje.Visible = true;
            }
        }

        protected void dgvProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedIndex >= 0)
            {
                GridViewRow row = dgvProductos.SelectedRow;
                lblCodigoMostrar.Text = row.Cells[3].Text;
                lblNombreMostrar.Text = row.Cells[4].Text;
                txtCantidadDeseada.Text = row.Cells[5].Text;
                txtPrecio.Text = row.Cells[6].Text;
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {

                obj_facturacompra.RestaInventario(lblCodigoMostrar.Text, int.Parse(txtCantidadDeseada.Text));
                
          



                obj_facturacompra.CodigoProducto = int.Parse(lblCodigoMostrar.Text);
                obj_facturacompra.EliminarProductoFactura();
                obj_facturacompra.LeerDetallesWEB((int)Session["FacturaID"]);
                dgvProductos.DataSource = obj_facturacompra.Tabla_Detalles;
                dgvProductos.DataBind();
                txtPrecio.Text = "";
                txtCantidadDeseada.Text = "";   
                lblCodigoMostrar.Text = "";
                lblNombreMostrar.Text = "";
                lblCantidadMostrar.Text = "";

            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
                lblMensaje.Visible = true;
            }

        }

        protected void btnRealizarCompra_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProductos.Rows.Count == 0)
                {
                    // El DataGridView está vacío
                    throw new Exception("No se han agregado productos a la factura");
                }
                txtPrecio.Text = "";
                lblNombreMostrar.Text = "";
                lblCodigoMostrar.Text = "";
                txtCantidadDeseada.Text = "";
                dgvProductos.DataSource = null;
                dgvProductos.DataBind();
                lblMostrarCedula.Text = "";
                lblMostrarTipo.Text = "";
                lblNombreMostrarCliente.Text = "";
                lblCodigoMostrarCliente.Text = "";
                
                lblMensaje.Text = "Compra realizada";
                lblMensaje.Visible = true;

            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
                lblMensaje.Visible = true;
            }
        }

        protected void btnEliminar_Click1(object sender, EventArgs e)
        {
            try
            {
                obj_facturacompra.RestaInventario(lblCodigoMostrar.Text, int.Parse(txtCantidadDeseada.Text));
                obj_facturacompra.CodigoProducto = int.Parse(lblCodigoMostrar.Text);
                obj_facturacompra.EliminarProductoFactura();
                obj_facturacompra.LeerDetallesWEB((int)Session["FacturaID"]);
                dgvProductos.DataSource = obj_facturacompra.Tabla_Detalles;
                dgvProductos.DataBind();
                txtPrecio.Text = "";
                txtCantidadDeseada.Text = "";
                lblCodigoMostrar.Text = "";
                lblNombreMostrar.Text = "";
                lblCantidadMostrar.Text = "";
                lblMensaje.Text = "";
            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
                lblMensaje.Visible = true;
            }
        }

        protected void btnRealizarCompra_Click1(object sender, EventArgs e)
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
                txtPrecio.Text = "";
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
    }
}