using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace La_Zarzuela_WEB.Paginas
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        FacturaVenta obj_factura = new FacturaVenta();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            obj_factura.FacturaID1 = Convert.ToInt32(txtNumeroFactura.Text);
            obj_factura.LeerFactura();
            dgvFacturaCompra.DataSource = obj_factura.Tabla_Facturas;
            dgvFacturaCompra.DataBind();


            obj_factura.FacturaID1 = Convert.ToInt32(txtNumeroFactura.Text);
            obj_factura.LeerDetalles();
            dgvDetalles.DataSource = obj_factura.Tabla_Detalles;
            dgvDetalles.DataBind();
            txtNumeroFactura.Text = "";
        }
    }
}