using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace La_zarzuela_SA
{
    public partial class frmAgregarCliente : Form
    {
        //objeto
        Clientes obj_clientes = new Clientes();

        //indice de la tabla
        int filaSeleccionada;
        
        public frmAgregarCliente()
        {
            InitializeComponent();
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblDireccion_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try 
            {
              obj_clientes.Codigo = int.Parse(txtCodigo.Text);
              obj_clientes.Nombre = txtNombre.Text;
              if (cbTipoCliente.SelectedIndex != -1) 
              {
                   obj_clientes.Tipo = cbTipoCliente.Text;
              }
               
              obj_clientes.Telefono = txtTelefono.Text;
              obj_clientes.Correo = txtCorreo.Text;
                if (cbProvincia.SelectedIndex != -1)
                {
                    obj_clientes.Provincia = cbProvincia.Text;
                }
                obj_clientes.Cedula = txtCedula.Text;
                obj_clientes.Direccion = txtDireccion.Text;

                
                obj_clientes.VerificarCliente();

                obj_clientes.EscribeClienteBD();

                




                //dgvClientes.Rows.Add(obj_clientes.Codigo,obj_clientes.Tipo, obj_clientes.Nombre, obj_clientes.Cedula, obj_clientes.Provincia, obj_clientes.Telefono, obj_clientes.Correo, obj_clientes.Direccion);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message, " Error de datos ", MessageBoxButtons.OK);
            }
            txtCedula.Text = "";
            txtCodigo.Text = "";
            txtCorreo.Text = "";
            txtDireccion.Text = "";
            txtNombre.Text = "";
            cbProvincia.SelectedIndex = -1;
            cbTipoCliente.SelectedIndex = -1;
            cbTipoCliente.Text = "";
            txtTelefono.Text = "";

        }

        private void cbProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmAgregarCliente_Load(object sender, EventArgs e)
        {
            obj_clientes.LeerClientes();
            dgvClientes.DataSource = obj_clientes.TablaClientes;
        }

        private void frmAgregarCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgvClientes.CurrentRow;
            DialogResult result = MessageBox.Show("¿Seguro que quieres eliminar esta fila?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    if (filaSeleccionada >= 0)
                    {

                        dgvClientes.Rows.Remove(selectedRow);
                        
                    }
                }
                catch
                {
                    MessageBox.Show("No se ha seleccionado ninguna fila");
                }
            }
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                filaSeleccionada = e.RowIndex;
            }
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)//si se selecciona una fila
            {
                DataGridViewRow row = dgvClientes.Rows[e.RowIndex];

                txtCodigo.Text = row.Cells[0].Value.ToString(); // Asignar el valor de la primera columna al textBoxNombre
                txtNombre.Text = row.Cells[1].Value.ToString(); // Asignar el valor de la segunda columna al textBoxEdad
                txtCedula.Text = row.Cells[2].Value.ToString(); // Asignar el valor de la tercera columna al textBoxCorreo
                cbTipoCliente.Text = row.Cells[3].Value.ToString();
                cbProvincia.Text = row.Cells[4].Value.ToString();
                txtCorreo.Text = row.Cells[5].Value.ToString();
                txtTelefono.Text = row.Cells[6].Value.ToString();
                txtDireccion.Text = row.Cells[7].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = dgvClientes.CurrentRow;

                if (selectedRow != null)
                {
                    obj_clientes.Codigo = int.Parse(txtCodigo.Text);
                    obj_clientes.Nombre = txtNombre.Text;
                    if (cbTipoCliente.SelectedIndex != -1)
                    {
                        obj_clientes.Tipo = cbTipoCliente.Text;
                    }

                    obj_clientes.Telefono = txtTelefono.Text;
                    obj_clientes.Correo = txtCorreo.Text;
                    if (cbProvincia.SelectedIndex != -1)
                    {
                        obj_clientes.Provincia = cbProvincia.Text;
                    }
                    obj_clientes.Cedula = txtCedula.Text;
                    obj_clientes.Direccion = txtDireccion.Text;


                    obj_clientes.VerificarCliente();
                    if (txtCodigo.Text != selectedRow.Cells[0].Value.ToString())
                    {
                        
                    }
                    // Actualizar los valores de las celdas con los valores de los TextBox
                    selectedRow.Cells[0].Value = txtCodigo.Text;
                    selectedRow.Cells[1].Value = txtNombre.Text;
                    selectedRow.Cells[2].Value = txtCedula.Text;
                    selectedRow.Cells[3].Value = cbTipoCliente.Text;
                    selectedRow.Cells[4].Value = cbProvincia.Text;
                    selectedRow.Cells[5].Value = txtCorreo.Text;
                    selectedRow.Cells[6].Value = txtTelefono.Text;
                    selectedRow.Cells[7].Value = txtDireccion.Text;
                    
                }
            }//fin del try
            catch (Exception ex) 
            {
                MessageBox.Show("Error: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }//fin del catch
        }

        private void cbTipoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
