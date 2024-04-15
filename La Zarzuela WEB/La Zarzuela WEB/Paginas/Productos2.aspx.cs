using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace La_Zarzuela_WEB.Paginas
{
    public partial class Formulario_web15 : System.Web.UI.Page
    {
        Productos obj_productos = new Productos();
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            dgvProductos.DataSource = new DataTable(); // Inicializas con un DataTable vacío
            dgvProductos.DataBind();
            obj_productos.Precio = Convert.ToInt32(txtPrecio.Text);
            obj_productos.Cantidad = Convert.ToInt32(txtCantidad.Text);
            obj_productos.CalcularTotal();
            dgvProductos.DataSource = obj_productos.Tabla_Productos;

            ((DataTable)dgvProductos.DataSource).Rows.Add(txtCodigo.Text,txtNombre.Text,txtCantidad.Text, txtPrecio.Text, obj_productos.Impuesto.ToString(), obj_productos.TotalImpuesto.ToString());
            dgvProductos.DataBind();
        }

        protected void dgvProductos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}