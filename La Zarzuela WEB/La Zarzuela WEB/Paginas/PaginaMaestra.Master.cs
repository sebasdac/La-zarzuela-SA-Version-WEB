using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace La_Zarzuela_WEB
{
    public partial class PaginaMaestra : System.Web.UI.MasterPage
    {
        LoginWeb obj_login = new LoginWeb();
        protected void Page_Load(object sender, EventArgs e)
        {
            Console.WriteLine("estado proveedor" + obj_login.Esproveedorweb);
            Console.WriteLine("estado usuario: " + obj_login.Esusuarioweb);
            if (Session["Usuario"] != null && Session["Usuario"].ToString() == "proveedor")
            {
                MenuProveedor.Visible = true;
            }
            if (Session["Usuario"] != null && Session["Usuario"].ToString() == "usuario")
            {
                MenuUsuario.Visible = true;
            }
            if (Session["Usuario"] != null && Session["Usuario"].ToString() == "cliente")
            {
                menuCliente.Visible = true;
            }


        }

        protected void Menu_MenuItemClick(object sender, MenuEventArgs e)
        {

        }

        protected void MenuUsuario_MenuItemClick(object sender, MenuEventArgs e)
        {

        }

        protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
        {

        }
    }
}