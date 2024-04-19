using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace La_zarzuela_SA
{
    public partial class frmVerUsuarios : Form
    {
        //indice
        int filaSeleccionada;
        //objeto
        Usuarios obj_usuario = new Usuarios();

        public frmVerUsuarios()
        {
            InitializeComponent();
        }

        private void frmVerUsuarios_Load(object sender, EventArgs e)
        {
            obj_usuario.LeerUsuarios();
            dgvUsuarios.DataSource = obj_usuario.TablaUsuarios;
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUsuarios.Rows[e.RowIndex];

                txtUsuario.Text = row.Cells[0].Value.ToString(); // Asignar el valor de la primera columna al 
                txtContrasena.Text = row.Cells[1].Value.ToString(); // Asignar el valor de la segunda columna al
                txtCedula.Text = row.Cells[2].Value.ToString();
                txtNombre.Text = row.Cells[3].Value.ToString();
                cbEstado.Text = row.Cells[4].Value.ToString();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgvUsuarios.CurrentRow;
            DialogResult result = MessageBox.Show("¿Seguro que quieres eliminar el usuario "+txtUsuario.Text+" ?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    if (filaSeleccionada >= 0)
                    {
                        obj_usuario.Usuario = txtUsuario.Text;
                        obj_usuario.EliminarUsuario();
                        obj_usuario.LeerUsuarios();
                        dgvUsuarios.DataSource = obj_usuario.TablaUsuarios;
                        
                        
                    }
                }
                catch
                {
                    MessageBox.Show("No se ha seleccionado ninguna fila");
                }
                txtUsuario.Text = "";
                txtContrasena.Text = "";
                cbEstado.Text = "";

            }
            //obj_usuario.EscribeUsuarioXML();
        }

        private void frmVerUsuarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                obj_usuario.Usuario = txtUsuario.Text;
                obj_usuario.Contrasena = txtContrasena.Text;
                obj_usuario.Cedula = txtCedula.Text;
                obj_usuario.Nombre = txtNombre.Text;
                obj_usuario.Estado = cbEstado.Text;
                obj_usuario.ValidarUsuarioRegistro();
                obj_usuario.ActualizarEstado();
                obj_usuario.LeerUsuarios();
                dgvUsuarios.DataSource = obj_usuario.TablaUsuarios;



                MessageBox.Show("Cambio realizado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtCedula.Text = "";
            txtContrasena.Text = "";
            txtNombre.Text = "";
            txtUsuario.Text = "";
            cbEstado.Text = "";


           
        }

        private void txtContrasena_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
