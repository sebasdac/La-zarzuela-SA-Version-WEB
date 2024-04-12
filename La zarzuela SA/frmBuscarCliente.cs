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
    public partial class frmBuscarCliente : Form
    {
        Clientes obj_clientes = new Clientes();
        public frmBuscarCliente()
        {
            InitializeComponent();
            dgvClientes.SelectionChanged += dgvClientes_SelectionChanged;
        }

        private void frmBuscarCliente_Load(object sender, EventArgs e)
        {
            obj_clientes.LeerClientes();
            dgvClientes.DataSource = obj_clientes.TablaClientes;
        }
        private void dgvClientes_SelectionChanged(object sender, EventArgs e)
        {
            // Verifica si hay una fila seleccionada
            if (dgvClientes.SelectedRows.Count > 0)
            {
                // Obtiene la fila seleccionada
                DataGridViewRow row = dgvClientes.SelectedRows[0];

                // Obtiene los valores de las celdas
                string valorColumna1 = row.Cells["Codigo"].Value.ToString();
                string valorColumna2 = row.Cells["Nombre"].Value.ToString();
                string valorColumna3 = row.Cells["Tipo"].Value.ToString();
                string valorColumna4 = row.Cells["Cedula"].Value.ToString();

                // Continúa obteniendo valores para todas las columnas necesarias

                // Abre Form2 y pasa los valores al constructor

                // Obtener referencia a la instancia existente de frmVentaProducto
                frmVentaProducto ventaProducto = (frmVentaProducto)Application.OpenForms["frmVentaProducto"];

                // Verificar si la instancia existe
                if (ventaProducto != null)
                {
                    // Actualizar los datos en frmVentaProducto
                    ventaProducto.RecibirDatosClientes(valorColumna1, valorColumna2, valorColumna3, valorColumna4);
                    this.Close();
                }




            }

        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
