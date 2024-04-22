using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace La_Zarzuela_WEB.Paginas
{
    public partial class Formulario_web15 : System.Web.UI.Page
    {
        ImpuestoMensual obj_impuesto = new ImpuestoMensual();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                obj_impuesto.Mes = int.Parse(txtMes.Text);
                obj_impuesto.VerificarMes();
                obj_impuesto.ImpuestoVentas();
                obj_impuesto.ImpuestoCompras();
                obj_impuesto.CalculoImpuestos();

                txtImpuesto.Text = obj_impuesto.Impuestosmensuales.ToString();
                lblError.Visible = false;
            }
            catch (Exception ex)
            {
                lblError.Text = "Error: " + ex.Message;
                lblError.Visible = true;
            }
        }
    }
}