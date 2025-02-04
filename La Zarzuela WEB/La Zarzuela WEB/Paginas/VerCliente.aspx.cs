﻿using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace La_Zarzuela_WEB.Paginas
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        Clientes obj_clientes = new Clientes();
        protected void Page_Load(object sender, EventArgs e)
        {
            obj_clientes.Correo = Session["Correo"].ToString();
            obj_clientes.LeerUNSoloCliente();
            dgvClientes.DataSource = obj_clientes.TablaClientes;
            dgvClientes.DataBind();



        }

        protected void dgvClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedIndex >= 0) // Verifica si se ha seleccionado alguna fila
            {
                GridViewRow row = dgvClientes.Rows[dgvClientes.SelectedIndex];

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

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                obj_clientes.Codigo = int.Parse(txtCodigo.Text);
                obj_clientes.Nombre = txtNombre.Text;
                if (cbTipo.SelectedIndex != -1)
                {
                    obj_clientes.Tipo = cbTipo.Text;
                }

                obj_clientes.Telefono = txtTelefono.Text;
                obj_clientes.Correo = txtCorreo.Text;
                if (cbProvincia.SelectedIndex != -1)
                {
                    obj_clientes.Provincia = cbProvincia.Text;
                }
                obj_clientes.Cedula = txtCedula.Text;
                obj_clientes.Direccion = txtDireccion.Text;
                obj_clientes.Contrasena = txtContrasena.Text;
                obj_clientes.ValidarContrasena();
                obj_clientes.VerificarCliente();
                obj_clientes.ActualizarCliente();
                
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
    }
}