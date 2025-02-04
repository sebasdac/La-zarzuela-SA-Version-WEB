﻿using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace La_zarzuela_SA
{
    public partial class frmAgregarUsuario : Form
    {
        //objeto
        Usuarios obj_usuario = new Usuarios();

        public frmAgregarUsuario()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {

                obj_usuario.Usuario = txtUsuario.Text;
                obj_usuario.Contrasena = txtContrasena.Text;
                obj_usuario.PinIngresado = int.Parse(txtPin.Text);
                obj_usuario.Estado = cbEstado.Text;
                obj_usuario.Cedula = txtCedula.Text;
                obj_usuario.Nombre = txtNombre.Text;


                obj_usuario.ValidarPIN();

               
                obj_usuario.ValidarUsuarioRegistro();

                obj_usuario.EscribeUsuarioBD();

                //agregar usuario

              

                MessageBox.Show("Registro exitoso", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void txtPin_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmAgregarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            obj_usuario.ValidarPIN();
            
        }
    }
}
