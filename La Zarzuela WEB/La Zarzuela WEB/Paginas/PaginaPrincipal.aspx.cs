using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace La_Zarzuela_WEB.Paginas
{
    public partial class Formulario_web11 : System.Web.UI.Page
    {
        LoginWeb obj_login = new LoginWeb();
        protected void Page_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Estado usuario: " + obj_login.Esusuarioweb);
            Console.WriteLine("Estado proveedor: " + obj_login.Esproveedorweb);
        }
    }
}