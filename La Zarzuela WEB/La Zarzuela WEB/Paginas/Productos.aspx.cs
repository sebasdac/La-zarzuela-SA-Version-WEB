using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace La_Zarzuela_WEB.Paginas
{
    public partial class Formulario_web1 : System.Web.UI.Page
    {
        Productos obj_productos = new Productos();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Usuario"] != null && Session["Usuario"].ToString() == "proveedor")
            {
                // Restringir acceso a la página para los proveedores
                Response.Redirect("Accesodenegado.aspx");
            }
            else
            {
                // Redirigir a una página de acceso denegado o cualquier otra acción
                
            }




            obj_productos.LeeTablaProducto();
            dgvProductos.DataSource = obj_productos.Tabla_Productos;
            dgvProductos.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                obj_productos.Codigo = Convert.ToInt32(txtCodigo.Text);
                obj_productos.Nombre = txtNombre.Text;
                obj_productos.Cantidad = Convert.ToInt32(txtCantidad.Text);
                obj_productos.Precio = Convert.ToInt32(txtPrecio.Text);
                obj_productos.ValidarProducto();
                obj_productos.CalcularTotal();
                lblImpuestoMostrar.Text = Convert.ToString(obj_productos.Impuesto);
                lblTotalMostrar.Text = Convert.ToString(obj_productos.TotalImpuesto);
                obj_productos.EscribeProductoBD();
                lblError.Text = "";

            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
                lblError.Visible = true;
            }
            obj_productos.LeeTablaProducto();
            dgvProductos.DataSource = obj_productos.Tabla_Productos;
            dgvProductos.DataBind();
        }
    }
}