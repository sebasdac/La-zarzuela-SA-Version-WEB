using FontAwesome.Sharp;
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
    public partial class Form1 : Form
    {
        frmAgregarProducto frmAgregarProducto = new frmAgregarProducto();
        private static  IconMenuItem MenuActivo=null;
        private static Form FormularioActivo = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void verMasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void agregarProductoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panelContenedor.Controls.Clear();
            frmAgregarProducto frm = new frmAgregarProducto();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.BackColor = Color.DarkSlateBlue;
            panelContenedor.Controls.Add(frm);


            frm.Show();
        }

        private void agregarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarCliente frmagregarcliente = new frmAgregarCliente();
            frmagregarcliente.Show();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarProveedor frm = new frmAgregarProveedor();
            frm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVerUsuarios frm = new frmVerUsuarios();
            frm.Show();
        }

        private void agregarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarUsuario frm = new frmAgregarUsuario();
            frm.Show();
        }

        private void cambiarPinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelContenedor.Controls.Clear();
            frmCambiarPin frm = new frmCambiarPin();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.BackColor = Color.DarkSlateBlue;
            panelContenedor.Controls.Add(frm);


            frm.Show();
        }

        private void AbrirFormulario(IconMenuItem menuItem, Form formulario)
        {
            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }
            //MenuActivo = menu;
            if (MenuActivo != null)
            {
                //MenuActivo.BackColor = Color.FromArgb(31, 30, 68);
            }
            FormularioActivo = formulario;
            MenuActivo = menuItem;
            //MenuActivo.BackColor = Color.FromArgb(37, 36, 81);
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(formulario);
            panelContenedor.Tag = formulario;
            formulario.Show();
        }



        private void compraToolStripMenuItem_Click(object sender, EventArgs e)
        {

           AbrirFormulario((IconMenuItem)sender, new frmVentaProducto());


     
        }

        private void impuestosMensualesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmImpuestoMensualcs frm = new frmImpuestoMensualcs();
            frm.Show();
        }

        private void agregarInvetarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agregar_inventario agregar_Inventario = new Agregar_inventario();
            agregar_Inventario.Show();
        }

        private void verMasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmVerMas frm = new frmVerMas();
            frm.Show();
        }

        private void facturasCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVerFacturasCompra frmVerFacturasCompra = new frmVerFacturasCompra();
            frmVerFacturasCompra.Show();
        }

        private void agregarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmAgregarProducto());
        }

        private void facturasVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVerFacturaVenta frm = new frmVerFacturaVenta();
            frm.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Contenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVentaProducto_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmVentaProducto());
        }

        private void iconMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmAgregarProducto());
        }

        private void iconMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmAgregarProveedor());
        }

        private void btnCambiarPin_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmCambiarPin());
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmAgregarCliente());
        }

        private void iconMenuItem2_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new Agregar_inventario());
        }

        private void btnFacutras_Click(object sender, EventArgs e)
        {

        }

        private void bbtnReciboVenta_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmVerFacturaVenta());
        }

        private void btnImpuestos_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmImpuestoMensualcs());
        }

        private void iconMenuItem3_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmVerUsuarios());
        }

        private void iconMenuItem4_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmAgregarUsuario());
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReciboCOmpra_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmVerFacturasCompra());
        }
    }
}
