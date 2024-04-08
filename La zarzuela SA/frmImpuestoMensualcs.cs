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
    public partial class frmImpuestoMensualcs : Form
    {
        //objeto
        ImpuestoMensual obj_impuesto = new ImpuestoMensual();
        public frmImpuestoMensualcs()
        {
            InitializeComponent();
        }

        private void txtImpuestos_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmImpuestoMensualcs_Load(object sender, EventArgs e)
        {
            
        }

        

        private void btnVer_Click(object sender, EventArgs e)
        {
            try
            {
                obj_impuesto.Mes = int.Parse(txtNumeroMes.Text);
                obj_impuesto.ImpuestosMensualesMostar();
                txtImpuestos.Text = obj_impuesto.Impuestosmensuales.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: "+ ex.Message);
            }
        }
    }
}
