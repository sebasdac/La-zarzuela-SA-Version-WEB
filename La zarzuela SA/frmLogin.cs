using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace La_zarzuela_SA
{
    public partial class frmLogin : Form
    {
        //objeto
        Usuarios obj_usuario = new Usuarios();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            try
            {
                obj_usuario.Usuario = txtUsuario.Text;
                obj_usuario.Contrasena = txtContrasena.Text;
                

               
                obj_usuario.UsuarioIncorrecto();

                Form1 frm = new Form1();
                frm.Show();
                this.Hide();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }//fin del metodo

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAgregarUsuario frm = new frmAgregarUsuario();
            frm.Show();
        }//fin del metodo

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);//cerrar la aplicacion

        }
    }
}
