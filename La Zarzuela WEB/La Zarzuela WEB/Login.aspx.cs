using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace La_Zarzuela_WEB
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            ////boton de inicio de secion
            ////cookies
            FormsAuthenticationTicket authTicket;
            String eticket;
            HttpCookie authCookie;

            ////aca valida
            if (LoginUsuario.UserName == "SebasDAC" && LoginUsuario.Password == "1212")
            {
                e.Authenticated = true;
                authTicket = new FormsAuthenticationTicket(1, LoginUsuario.UserName, DateTime.Now,
                    DateTime.Now.AddMinutes(10), true, "1");
                eticket = FormsAuthentication.Encrypt(authTicket);
                authCookie = new HttpCookie(FormsAuthentication.FormsCookieName, eticket);
                authCookie.Path = FormsAuthentication.FormsCookiePath;


            }
            else
            {
                e.Authenticated = false;
            }



        }
    }
}