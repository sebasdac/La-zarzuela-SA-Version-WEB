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
    public partial class frmVerMas : Form
    {

        //objeto
        VerMas obj_vermas = new VerMas();
        public frmVerMas()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmVerMas_Load(object sender, EventArgs e)
        {
            obj_vermas.LeerMasTXT();
            txtVermas.Text = obj_vermas.VerMas2;
        }
    }
}
