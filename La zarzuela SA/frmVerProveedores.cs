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
    public partial class frmVerProveedores : Form
    {
        Proveedor obj_proveedor = new Proveedor();
        public frmVerProveedores()
        {
            InitializeComponent();
            dgvProveedores.SelectionChanged += dgvProveedores_SelectionChanged;
        }

        private void frmVerProveedores_Load(object sender, EventArgs e)
        {
            obj_proveedor.LeerProveedoresBD();
            dgvProveedores.DataSource = obj_proveedor.TablaProveedor;
        }
        private void dgvProveedores_SelectionChanged(object sender, EventArgs e)
        {
            // Verifica si hay una fila seleccionada
            if (dgvProveedores.SelectedRows.Count > 0)
            {
                // Obtiene la fila seleccionada
                DataGridViewRow row = dgvProveedores.SelectedRows[0];

                // Obtiene los valores de las celdas
                string valorColumna1 = row.Cells["Codigo"].Value.ToString();
                string valorColumna2 = row.Cells["Proveedor"].Value.ToString();
                string valorColumna3 = row.Cells["Tipo"].Value.ToString();
                string valorColumna4 = row.Cells["Cedula"].Value.ToString();

                // Continúa obteniendo valores para todas las columnas necesarias

                // Abre Form2 y pasa los valores al constructor

                // Obtener referencia a la instancia existente de frmVentaProducto
                frmAgregarProducto proveedor = (frmAgregarProducto)Application.OpenForms["frmAgregarProducto"];
                Agregar_inventario inventario = (Agregar_inventario)Application.OpenForms["Agregar_inventario"];

                // Verificar si la instancia existe
                if (proveedor != null)
                {
                    // Actualizar los datos en frmVentaProducto
                    proveedor.RecibirDatos(valorColumna1, valorColumna2, valorColumna3, valorColumna4);
                    this.Close();
                }
                if(inventario!= null)
                {
                    inventario.RecibirDatos(valorColumna1, valorColumna2, valorColumna3, valorColumna4);
                    this.Close();
                }




            }

        }
    }
}
