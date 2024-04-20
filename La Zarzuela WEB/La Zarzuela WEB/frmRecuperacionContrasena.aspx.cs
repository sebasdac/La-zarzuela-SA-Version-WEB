using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace La_Zarzuela_WEB.Paginas
{
    public partial class frmRecuperacionContrasena : System.Web.UI.Page
    {
        LoginWeb obj_loginweb = new LoginWeb();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void PasswordRecovery1_SendingMail(object sender, MailMessageEventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                obj_loginweb.Usuario = txtUsuario.Text;
                obj_loginweb.Contrasena = txtNuevaContrasena.Text;
                obj_loginweb.ValidarContrasena();
                obj_loginweb.CambioContrasena();
                lblMensaje.Text = "Contraseña actualizada correctamente";
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