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

       

        private void btnBuscarporFactura_Click(object sender, EventArgs e)
        {
            
            obj_factura.FacturaID1 = Convert.ToInt32(txtNumeroFactura.Text);
            obj_factura.LeerFactura();
            dgvFacturaCompra.DataSource = obj_factura.Tabla_Facturas;
            obj_factura.FacturaID1 = Convert.ToInt32(txtNumeroFactura.Text);
            obj_factura.LeerDetalles();
            
            dgvDetalles.DataSource = obj_factura.Tabla_Detalles;
            txtNumeroFactura.Text = "";
            
             



        }
    }
}
