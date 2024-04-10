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
    public partial class frmCambiarPin : Form
    {
        //objeto
        Usuarios obj_usuario = new Usuarios();
        public frmCambiarPin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            try
            { 
              //obj_usuario.Pin = int.Parse(txtActual.Text);
              
              //obj_usuario.Pin = int.Parse(txtNuevo.Text);

                
                MessageBox.Show("Cambio de PIN realizado satisfactoriamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error: "+ex.Message);
            
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
