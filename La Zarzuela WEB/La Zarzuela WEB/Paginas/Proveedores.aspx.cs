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

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                obj_proveedor.Codigo = int.Parse(txtCodigo.Text);
                obj_proveedor.Nombre = txtNombre.Text;
                obj_proveedor.Cedula = txtCedula.Text;
                obj_proveedor.Telefono = txtTelefono.Text;
                obj_proveedor.Correo = txtCorreo.Text;
                obj_proveedor.Direccion = txtDireccion.Text;
                obj_proveedor.Provincia = cbProvincia.Text;
                obj_proveedor.Tipo = cbTipo.Text;
                obj_proveedor.Contrasena = txtContrasena.Text;


                obj_proveedor.ValidarProveedor();
                obj_proveedor.EscribeProveedorBD();
                obj_proveedor.LeerProveedoresBD();
                dgvProveedores.DataSource = obj_proveedor.TablaProveedor;
                dgvProveedores.DataBind();
                lblError.Text = "";
            }
            catch (Exception ex)
            {
                lblError.Text = "Error: " + ex.Message;
                lblError.Visible = true;
            }
        }
    }
}