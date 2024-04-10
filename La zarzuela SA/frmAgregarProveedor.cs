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
                

                obj_proveedor.ValidarProveedor();
                obj_proveedor.EscribeProveedorBD();

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
                    if (filaSeleccionada >= 0)
                    {

                        dgvProveedor.Rows.Remove(selectedRow);
                        
                    }//fin if
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
            if (e.RowIndex >= 0)
            {
                filaSeleccionada = e.RowIndex;
            }
        }

        private void dgvProveedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProveedor.Rows[e.RowIndex];

                txtCodigo.Text = row.Cells[0].Value.ToString(); // Asignar el valor de la primera columna al 
                txtNombre.Text = row.Cells[1].Value.ToString(); // Asignar el valor de la segunda columna al 
                txtCedula.Text = row.Cells[2].Value.ToString(); // Asignar el valor de la tercera columna al
                cbProvincia.Text = row.Cells[3].Value.ToString(); // Asignar el valor de la cuarta columna al   
                txtTelefono.Text = row.Cells[4].Value.ToString(); // Asignar el valor de la quinta columna al
                txtCorreo.Text = row.Cells[5].Value.ToString(); // Asignar el valor de la sexta columna al
                txtDireccion.Text = row.Cells[6].Value.ToString(); // Asignar el valor de la septima columna al

                
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = dgvProveedor.CurrentRow;

                if (selectedRow != null)
                {
                    obj_proveedor.Codigo = int.Parse(txtCodigo.Text);
                    obj_proveedor.Nombre = txtNombre.Text;
                    obj_proveedor.Cedula = txtCedula.Text;
                    obj_proveedor.Telefono = txtTelefono.Text;
                    obj_proveedor.Correo = txtCorreo.Text;
                    obj_proveedor.Direccion = txtDireccion.Text;
                    obj_proveedor.Provincia = cbProvincia.Text;
                    

                    

                    obj_proveedor.ValidarProveedor();
                    

                    


                    if (txtCodigo.Text != selectedRow.Cells[0].Value.ToString())
                    {
                       
                    }
                    // Actualizar los valores de las celdas con los valores de los TextBox
                    selectedRow.Cells[0].Value = txtCodigo.Text;
                    selectedRow.Cells[1].Value = txtNombre.Text;
                    selectedRow.Cells[2].Value = txtCedula.Text;
                    selectedRow.Cells[3].Value = cbProvincia.Text;
                    selectedRow.Cells[4].Value = txtTelefono.Text;
                    selectedRow.Cells[5].Value = txtCorreo.Text;
                    selectedRow.Cells[6].Value = txtDireccion.Text;


                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
