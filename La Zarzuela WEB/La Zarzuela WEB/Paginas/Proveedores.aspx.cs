using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace La_Zarzuela_WEB.Paginas
{
    public partial class Formulario_web16 : System.Web.UI.Page
    {
        Proveedor obj_proveedor = new Proveedor();
        protected void Page_Load(object sender, EventArgs e)
        {
            obj_proveedor.LeerProveedoresBD();
            dgvProveedores.DataSource = obj_proveedor.TablaProveedor;
            dgvProveedores.DataBind();



        }

        protected void dgvProveedores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}