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
            obj_usuario.LeeTablaUsuario();
            dgvUsuarios.DataSource = obj_usuario.Tabla_Usuario;
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                filaSeleccionada = e.RowIndex;
            }
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUsuarios.Rows[e.RowIndex];

                txtUsuario.Text = row.Cells[0].Value.ToString(); // Asignar el valor de la primera columna al 
                txtContrasena.Text = row.Cells[1].Value.ToString(); // Asignar el valor de la segunda columna al 
                cbEstado.Text = row.Cells[2].Value.ToString();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgvUsuarios.CurrentRow;
            DialogResult result = MessageBox.Show("¿Seguro que quieres eliminar esta fila?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    if (filaSeleccionada >= 0)
                    {

                        dgvUsuarios.Rows.Remove(selectedRow);
                        
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
            obj_usuario.EscribeUsuarioXML();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = dgvUsuarios.CurrentRow;

                if (selectedRow != null)
                {
                    
                    obj_usuario.Estado = cbEstado.Text;


                    obj_usuario.ValidarEstado();





                    
                    // Actualizar los valores de las celdas con los valores de los TextBox
                    selectedRow.Cells[2].Value = cbEstado.Text;
                    


                    obj_usuario.EscribeUsuarioXML(); ;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtContrasena_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
