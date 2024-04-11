using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace La_Zarzuela_WEB
{
    public partial class Login : System.Web.UI.Page
    {
        Usuarios obj_usuarios = new Usuarios();
        LoginWeb obj_loginweb = new LoginWeb();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            //////boton de inicio de secion
            //////cookies
            FormsAuthenticationTicket authTicket;
            String eticket;
            HttpCookie authCookie;


            obj_usuarios.Usuario = LoginUsuario.UserName;
            obj_usuarios.Contrasena = LoginUsuario.Password;


            ////aca valida
            //try
            //{
            //    obj_usuarios.ValidarUsuario();
            //    e.Authenticated = true;
            //    authTicket = new FormsAuthenticationTicket(1, LoginUsuario.UserName, DateTime.Now,
            //        DateTime.Now.AddMinutes(10), true, "1");
            //    eticket = FormsAuthentication.Encrypt(authTicket);
            //    authCookie = new HttpCookie(FormsAuthentication.FormsCookieName, eticket);
            //    authCookie.Path = FormsAuthentication.FormsCookiePath;


            //}
            //catch (Exception ex)
            //{

            //    LoginUsuario.FailureText = ex.Message;

            //}


            try
            {
                obj_loginweb.Usuario = LoginUsuario.UserName;
                obj_loginweb.Contrasena = LoginUsuario.Password;
                obj_loginweb.AutenticarUsuario();
                
                // En el código detrás de tu página ASPX (archivo .aspx.cs)
                if (obj_loginweb.Esusuario)
                {
                    
                    Session["Usuario"] = "usuario";

                }
                if (obj_loginweb.Esproveedor)
                {

                    Session["Usuario"] = "proveedor";

                }

                e.Authenticated = true;
                authTicket = new FormsAuthenticationTicket(1, LoginUsuario.UserName, DateTime.Now,
                DateTime.Now.AddMinutes(1), true, "1");
                eticket = FormsAuthentication.Encrypt(authTicket);
                authCookie = new HttpCookie(FormsAuthentication.FormsCookieName, eticket);
                authCookie.Path = FormsAuthentication.FormsCookiePath;
                    
            }
            catch (Exception ex)
            {
                LoginUsuario.FailureText = ex.Message;
            }



        }
    }
}