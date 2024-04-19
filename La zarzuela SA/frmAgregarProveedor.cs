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
    public partial class frmAgregarProveedor : Form
    {
        //objeto
        Proveedor obj_proveedor = new Proveedor();
        //indice
        int filaSeleccionada;
        public frmAgregarProveedor()
        {
            InitializeComponent();
        }

        private void frmAgregarProveedor_Load(object sender, EventArgs e)
        {
            obj_proveedor.LeerProveedoresBD();
            dgvProveedor.DataSource = obj_proveedor.TablaProveedor;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
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
                dgvProveedor.DataSource = obj_proveedor.TablaProveedor;

                //obj_proveedor.CodigoRepetido();


                
            }//fin del try
            catch (Exception ex) 
            {
                MessageBox.Show("Error: " + ex.Message);
            }//fin del catch
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtCedula.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
            txtDireccion.Text = "";
            cbProvincia.Text = "";
            txtContrasena.Text = "";
            cbTipo.Text = "";


        }

        private void frmAgregarProveedor_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgvProveedor.CurrentRow;
            DialogResult result = MessageBox.Show("¿Seguro que quieres eliminar esta fila?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                   
                    obj_proveedor.Codigo = int.Parse(txtCodigo.Text);
                    obj_proveedor.EliminarProveedor();
                    obj_proveedor.LeerProveedoresBD();
                    dgvProveedor.DataSource = obj_proveedor.TablaProveedor;


                }//fin try
                catch
                {
                    MessageBox.Show("No se ha seleccionado ninguna fila");
                }//fin catch
                
                txtCodigo.Text = "";
                txtNombre.Text = "";
                txtCedula.Text = "";
                txtTelefono.Text = "";
                txtCorreo.Text = "";
                txtDireccion.Text = "";
                cbProvincia.Text = "";
            }
        }

        private void dgvProveedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgvProveedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProveedor.Rows[e.RowIndex];

                txtCodigo.Text = row.Cells[0].Value.ToString(); // Asignar el valor de la primera columna al 
                txtNombre.Text = row.Cells[1].Value.ToString();
                cbTipo.Text = row.Cells[2].Value.ToString();// Asignar el valor de la segunda columna al 
                txtCedula.Text = row.Cells[3].Value.ToString();
                txtDireccion.Text = row.Cells[4].Value.ToString();
                cbProvincia.Text = row.Cells[5].Value.ToString();
                txtTelefono.Text = row.Cells[6].Value.ToString();
                txtCorreo.Text = row.Cells[7].Value.ToString();
                txtContrasena.Text = row.Cells[8].Value.ToString();
                


            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
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
                obj_proveedor.LeerProveedoresBD();
                dgvProveedor.DataSource = obj_proveedor.TablaProveedor;



                MessageBox.Show("El proveedor se actualizo con exito");
                txtCedula.Text = "";
                txtCodigo.Text = "";
                txtNombre.Text = "";
                txtTelefono.Text = "";
                txtCorreo.Text = "";
                txtDireccion.Text = "";
                cbProvincia.Text = "";
                cbTipo.Text = "";
                txtContrasena.Text = "";


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
