using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace La_Zarzuela_WEB.Paginas
{
    public partial class Formulario_web14 : System.Web.UI.Page
    {
        Usuarios obj_usuarios = new Usuarios();
        protected void Page_Load(object sender, EventArgs e)
        {
            obj_usuarios.LeerUsuarios();
            dgvUsuarios.DataSource = obj_usuarios.TablaUsuarios;
            dgvUsuarios.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                obj_usuarios.Usuario = txtUsuario.Text;
                obj_usuarios.Contrasena = txtContrasena.Text;
                obj_usuarios.Cedula = txtCedula.Text;
                obj_usuarios.Nombre = txtNombre.Text;
                obj_usuarios.Estado = cbEstado.Text;
                obj_usuarios.PinIngresado = Convert.ToInt32(txtPin.Text);
            
                obj_usuarios.ValidarPIN();
                obj_usuarios.ValidarEstado();
                obj_usuarios.EscribeUsuarioBD();
                mensaje.Text = "Usuario ingresado correctamente";
                mensaje.Visible = true;
                obj_usuarios.LeerUsuarios();
                dgvUsuarios.DataSource = obj_usuarios.TablaUsuarios;
                dgvUsuarios.DataBind();
                lblError.Text = "";
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
                lblError.Visible = true;
            }
            
        }
       
        protected void dgvUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedIndex >= 0) // Verifica si se ha seleccionado alguna fila
            {
                GridViewRow row = dgvUsuarios.Rows[dgvUsuarios.SelectedIndex];

                // Asigna los valores de las celdas a los controles
                txtUsuario.Text = row.Cells[1].Text; // Asignar el texto de la primera celda al TextBox txtUsuario
                txtContrasena.Text = row.Cells[2].Text; // Asignar el texto de la segunda celda al TextBox txtContrasena
                txtCedula.Text = row.Cells[3].Text;
                txtNombre.Text = row.Cells[4].Text;
                cbEstado.Text = row.Cells[5].Text;// Asignar el texto de la quinta celda al ComboBox cbEstado
            }
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                obj_usuarios.Usuario = txtUsuario.Text;
                obj_usuarios.Estado = cbEstado.Text;
                obj_usuarios.Cedula = txtCedula.Text;
                obj_usuarios.Nombre = txtNombre.Text;
                obj_usuarios.Contrasena = txtContrasena.Text;

                obj_usuarios.ActualizarEstado();
                obj_usuarios.LeerUsuarios();
                dgvUsuarios.DataSource = obj_usuarios.TablaUsuarios;
                dgvUsuarios.DataBind();
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
                lblError.Visible = true;
            }

        }
    }
}