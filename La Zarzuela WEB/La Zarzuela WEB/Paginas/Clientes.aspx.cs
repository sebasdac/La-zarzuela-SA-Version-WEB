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
            try 
            {
                obj_clientes.Codigo = Convert.ToInt16(txtCodigo.Text);
                obj_clientes.Cedula = txtCedula.Text;
                obj_clientes.Nombre = txtNombre.Text;
                obj_clientes.Telefono = txtTelefono.Text;
                obj_clientes.Direccion = txtDireccion.Text;
                obj_clientes.Correo = txtCorreo.Text;
                obj_clientes.Tipo = cbTipo.Text;
                obj_clientes.Provincia = cbProvincia.Text;
                obj_clientes.Contrasena = txtContrasena.Text;
                obj_clientes.VerificarCliente();
                obj_clientes.EscribeClienteBD();
                obj_clientes.LeerClientes();
                dgvClientes.DataSource = obj_clientes.TablaClientes;
                dgvClientes.DataBind();
                lblError.Text = "";


            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
                lblError.Visible = true;
            }
            

        }

        protected void txtCorreo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}