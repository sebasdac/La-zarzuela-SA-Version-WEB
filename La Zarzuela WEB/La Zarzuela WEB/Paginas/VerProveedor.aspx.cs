using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace La_Zarzuela_WEB.Paginas
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        Proveedor obj_proveedor = new Proveedor();
        protected void Page_Load(object sender, EventArgs e)
        {
            obj_proveedor.Correo = Session["Correo"].ToString();
            obj_proveedor.LeerProveedorPorCorreo();
            dgvProveedores.DataSource = obj_proveedor.TablaProveedor;
            dgvProveedores.DataBind();
        }

        protected void txtDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnEditar_Click(object sender, EventArgs e)
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
                obj_proveedor.EditarProveedor();
                obj_proveedor.LeerProveedorPorCorreo();
                dgvProveedores.DataSource = obj_proveedor.TablaProveedor;
                dgvProveedores.DataBind();


                txtCedula.Text = "";
                txtCodigo.Text = "";
                txtNombre.Text = "";
                txtTelefono.Text = "";
                txtCorreo.Text = "";
                txtDireccion.Text = "";
                cbProvincia.Text = "";
                cbTipo.Text = "";
                txtContrasena.Text = "";
                lblError.Text = "";
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
                lblError.Visible = true;
            }
        }

        protected void dgvProveedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dgvProveedores.SelectedIndex >= 0) // Verifica si se ha seleccionado alguna fila
            {
                GridViewRow row = dgvProveedores.Rows[dgvProveedores.SelectedIndex];

                // Asigna los valores de las celdas a los controles
                txtCodigo.Text = row.Cells[1].Text; // Asignar el texto de la primera celda al TextBox txtUsuario

                txtNombre.Text = row.Cells[2].Text; // Asignar el texto de la primera celda al TextBox txtUsuario
                cbTipo.Text = row.Cells[3].Text; // Asignar el texto de la segunda celda al TextBox txtContrasena
                txtCedula.Text = row.Cells[4].Text; // Asignar el texto de la primera celda al TextBox txtUsuario

                txtDireccion.Text = row.Cells[5].Text;
                cbProvincia.Text = row.Cells[6].Text;// Asignar el texto de la quinta celda al ComboBox cbEstado
                txtTelefono.Text = row.Cells[7].Text;
                txtCorreo.Text = row.Cells[8].Text;
                txtContrasena.Text = row.Cells[9].Text;
            }
        }
    }
    
}