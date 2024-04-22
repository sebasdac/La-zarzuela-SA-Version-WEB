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
    public partial class frmVerFacturasCompra : Form
    {
        //objeto
        int filaSeleccionada;// indice de la fila seleccionada
        FacturaCompra obj_factura = new FacturaCompra();
        public frmVerFacturasCompra()
        {
            InitializeComponent();
        }

        private void frmVerFacturasCompra_Load(object sender, EventArgs e)
        {
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgvFacturaCompra.CurrentRow;
            DialogResult result = MessageBox.Show("¿Seguro que quieres eliminar esta fila?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    if (filaSeleccionada >= 0)
                    {

                        dgvFacturaCompra.Rows.Remove(selectedRow);
                        

                    }//fin if
                }//fin try
                catch
                {
                    MessageBox.Show("No se ha seleccionado ninguna fila");
                }//fin catch
            }
        }

        private void btnBuscarporFactura_Click(object sender, EventArgs e)
        {
            try
            {
                obj_factura.FacturaID = Convert.ToInt32(txtNumeroFactura.Text);
                obj_factura.LeerFactura();
                dgvFacturaCompra.DataSource = obj_factura.Tabla_Facturas;
                obj_factura.FacturaID = Convert.ToInt32(txtNumeroFactura.Text);
                obj_factura.LeerDetalles();

                dgvDetalles.DataSource = obj_factura.Tabla_Detalles;
                txtNumeroFactura.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dgvFacturaCompra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
