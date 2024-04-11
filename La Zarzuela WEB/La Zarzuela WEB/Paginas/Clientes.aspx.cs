using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace La_Zarzuela_WEB.Paginas
{
    public partial class Formulario_web12 : System.Web.UI.Page
    {
        Clientes obj_clientes = new Clientes();
        protected void Page_Load(object sender, EventArgs e)
        {
            obj_clientes.LeerClientes();
            dgvClientes.DataSource = obj_clientes.TablaClientes;
            dgvClientes.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            obj_clientes.Codigo = Convert.ToInt16(txtCodigo.Text);
            obj_clientes.Cedula = txtCedula.Text;
            


        }

        protected void txtCorreo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}