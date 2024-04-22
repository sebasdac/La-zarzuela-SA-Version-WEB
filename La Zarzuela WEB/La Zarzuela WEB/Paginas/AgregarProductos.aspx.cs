using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace La_Zarzuela_WEB.Paginas
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        Proveedor obj_proveedor = new Proveedor();
        FacturaCompra obj_facturacompra = new FacturaCompra();
        Productos obj_productos = new Productos();
        int facturaid;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSeleccionarProveedor_Click(object sender, EventArgs e)
        {
            lblCodigoMostrarCliente.Text = DropDownList1.SelectedValue;
            lblNombreMostrarCliente.Text = DropDownList1.SelectedItem.Text;
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
            obj_facturacompra.Fecha1 = diaSeleccionado;
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

        protected void btnAgregar_Click(object sender, EventArgs e)
        {


            try
            {
                obj_productos.Codigo = int.Parse(txtCodigo.Text);
                obj_productos.Nombre = txtNombre.Text;
                obj_productos.Cantidad = int.Parse(txtCantidad.Text);
                obj_productos.Precio = int.Parse(txtPrecio.Text);
                obj_productos.Cantidad = int.Parse(txtCantidad.Text);
                obj_productos.Precio = int.Parse(txtPrecio.Text);
                obj_productos.CalcularTotal();
                obj_productos.ValidarProducto();
                obj_productos.EscribeProductoBD();





                obj_facturacompra.CodigoProducto = int.Parse(txtCodigo.Text);
                obj_facturacompra.NombreProducto = txtNombre.Text;
                obj_facturacompra.Cantidad = int.Parse(txtCantidad.Text);
                obj_facturacompra.Precio = double.Parse(txtPrecio.Text);
                obj_facturacompra.Cantidad = int.Parse(txtCantidad.Text);
                obj_facturacompra.Precio = double.Parse(txtPrecio.Text);
                obj_facturacompra.CalcularTotal();
                int facturaid = (int)Session["FacturaID"];
                obj_facturacompra.InsertarDetalleFacturaWEB(facturaid);

                obj_facturacompra.LeerDetallesWEB(facturaid);
                dgvProductos.DataSource = obj_facturacompra.Tabla_Detalles;
                dgvProductos.DataBind();
                txtPrecio.Text = "";
                txtNombre.Text = "";
                txtCodigo.Text = "";
                txtCantidad.Text = "";
                lblError.Text = "";
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
                lblError.Visible = true;
            }

        }

        protected void dgvProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedIndex >= 0)
            {
                GridViewRow row = dgvProductos.SelectedRow;
                txtCodigo.Text = row.Cells[3].Text;
                txtNombre.Text = row.Cells[4].Text;
                txtCantidad.Text = row.Cells[5].Text;
                txtPrecio.Text = row.Cells[6].Text;
            }
            
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {


                obj_productos.Codigo = int.Parse(txtCodigo.Text);
                obj_productos.EliminarProducto();


                obj_facturacompra.CodigoProducto = int.Parse(txtCodigo.Text);
                obj_facturacompra.EliminarProductoFactura();
                obj_facturacompra.LeerDetallesWEB((int)Session["FacturaID"]);
                dgvProductos.DataSource = obj_facturacompra.Tabla_Detalles;
                dgvProductos.DataBind();
                txtPrecio.Text = "";
                txtNombre.Text = "";
                txtCodigo.Text = "";
                txtCantidad.Text = "";
                lblError.Text = "";
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
                lblError.Visible = true;
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
                txtNombre.Text = "";
                txtCodigo.Text = "";
                txtCantidad.Text = "";
                dgvProductos.DataSource = null;
                dgvProductos.DataBind();
                lblMostrarCedula.Text = "";
                lblMostrarTipo.Text = "";
                lblNombreMostrarCliente.Text = "";
                lblCodigoMostrarCliente.Text = "";
                lblError.Text = "";
                lblMensaje.Text = "Compra realizada";
                lblMensaje.Visible = true;

             }
            catch (Exception ex)
             {
                   lblError.Text = ex.Message;
                lblError.Visible = true;
             }
                

        }
    }
}