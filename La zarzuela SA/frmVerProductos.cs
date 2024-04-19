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
    public partial class frmVerProductos : Form
    {
        Productos obj_productos = new Productos();
        public frmVerProductos()
        {
            InitializeComponent();
        }

        private void frmVerProductos_Load(object sender, EventArgs e)
        {
            obj_productos.LeeTablaProducto();
            dgvProductos.DataSource = obj_productos.Tabla_Productos;

        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProductos.Rows[e.RowIndex];

                txtCodigoProducto.Text = row.Cells[0].Value.ToString(); // Asignar el valor de la primera columna al 
                txtNombre.Text = row.Cells[1].Value.ToString(); // Asignar el valor de la segunda columna al 
                txtCantidad.Text = row.Cells[2].Value.ToString(); // Asignar el valor de la tercera columna al
                txtPrecio.Text = row.Cells[3].Value.ToString(); // Asignar el valor de la cuarta columna al   



            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("¿Seguro que quieres eliminar el producto " + txtNombre.Text + " ?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {

                    obj_productos.Codigo = int.Parse(txtCodigoProducto.Text);
                    obj_productos.EliminarProducto();
                    obj_productos.LeeTablaProducto();
                    dgvProductos.DataSource = obj_productos.Tabla_Productos;
                    txtNombre.Text = "";
                    txtCantidad.Text = "";
                    txtPrecio.Text = "";
                    txtCodigoProducto.Text = "";




                }
            }
            catch
            {
                MessageBox.Show("No se ha seleccionado ningun producto");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("¿Seguro que quieres editar este producto?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {

                    obj_productos.Codigo = int.Parse(txtCodigoProducto.Text);
                    obj_productos.Nombre = txtNombre.Text;
                    obj_productos.Cantidad = int.Parse(txtCantidad.Text);
                    obj_productos.Precio = int.Parse(txtPrecio.Text);
                    obj_productos.ValidarProducto();
                    obj_productos.ActualizarInventario();
                    obj_productos.LeeTablaProducto();
                    dgvProductos.DataSource = obj_productos.Tabla_Productos;
                    txtNombre.Text = "";
                    txtCantidad.Text = "";
                    txtPrecio.Text = "";
                    txtCodigoProducto.Text = "";

                }
            }
            catch
            {
                MessageBox.Show("No se ha seleccionado ningun producto");
            }
           
           
        }
    }
}
