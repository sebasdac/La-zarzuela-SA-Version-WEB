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
    public partial class frmBuscarProducto : Form
    {
        Productos obj_productos = new Productos();
        frmVentaProducto form2 = new frmVentaProducto();
        public frmBuscarProducto()
        {
            InitializeComponent();
            dgvProductos.SelectionChanged += dgvProductos_SelectionChanged;
        }

        private void frmBuscarProducto_Load(object sender, EventArgs e)
        {
            obj_productos.LeeTablaProducto();
            dgvProductos.DataSource = obj_productos.Tabla_Productos;
        }
        string valorColumna1;
        string valorColumna2;
        private void dgvProductos_SelectionChanged(object sender, EventArgs e)
        {
            // Verifica si hay una fila seleccionada
            if (dgvProductos.SelectedRows.Count > 0)
            {
                // Obtiene la fila seleccionada
                DataGridViewRow row = dgvProductos.SelectedRows[0];

                // Obtiene los valores de las celdas
                valorColumna1 = row.Cells["Codigo"].Value.ToString();
                valorColumna2 = row.Cells["Nombre"].Value.ToString();
                string valorColumna3 = row.Cells["Cantidad"].Value.ToString();
                string valorColumna4 = row.Cells["Precio"].Value.ToString();
                
                // Continúa obteniendo valores para todas las columnas necesarias

                // Abre Form2 y pasa los valores al constructor

                // Obtener referencia a la instancia existente de frmVentaProducto
                frmVentaProducto ventaProducto = (frmVentaProducto)Application.OpenForms["frmVentaProducto"];

                // Verificar si la instancia existe
                if (ventaProducto != null)
                {
                    // Actualizar los datos en frmVentaProducto
                    ventaProducto.RecibirDatos(valorColumna1, valorColumna2, valorColumna3, valorColumna4);
                    this.Close();
                }


                

            }

        }

        

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvProductos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
