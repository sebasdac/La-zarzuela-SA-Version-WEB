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
    public partial class frmVerFacturaVenta : Form
    {
        FacturaVenta obj_factura = new FacturaVenta();
        //indice
        int filaSeleccionada;
        public frmVerFacturaVenta()
        {
            InitializeComponent();
        }

        private void frmVerFacturaVenta_Load(object sender, EventArgs e)
        {
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgvFacturasVenta.CurrentRow;
            DialogResult result = MessageBox.Show("¿Seguro que quieres eliminar esta fila?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    if (filaSeleccionada >= 0)
                    {

                        dgvFacturasVenta.Rows.Remove(selectedRow);
                        

                    }//fin if
                }//fin try
                catch
                {
                    MessageBox.Show("No se ha seleccionado ninguna fila");
                }//fin catch
            }
        }
    }
}
