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
            // Crear una instancia del formulario que deseas mostrar
            frmAgregarProducto formularioSecundario = new frmAgregarProducto();

            //// Establecer el formulario como no principal
            //formularioSecundario.TopLevel = false;

            //// Establecer el padre del formulario como el panel
            //panelContenedor.Controls.Add(formularioSecundario);

            //// Ajustar el tamaño del formulario para que se ajuste al tamaño del panel
            //formularioSecundario.Size = panelContenedor.Size;

            //// Mostrar el formulario
            formularioSecundario.Show();
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
            frmCambiarPin frmCambiarPin = new frmCambiarPin();
            frmCambiarPin.Show();
        }

        private void compraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVentaProducto frm = new frmVentaProducto();
            frm.Show();
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
    }
}
