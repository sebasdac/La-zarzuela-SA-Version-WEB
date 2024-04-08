using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class FacturaCompra
    {

        int _CodigoProveedor;
        string _NombreProveedor;
        string _Fecha;
        string _NumeroFactura;
        int _CodigoProducto;
        string _NombreProducto;
        int _Cantidad;
        double _Precio;
        double _Total;

        TablaFacturaCompra obj_facturacompra = new TablaFacturaCompra();
        EscribeFacturaCompraXML obj_facturacompraXML = new EscribeFacturaCompraXML();
        public DataTable facturas { get => obj_facturacompra.Tabla_facturacompra; }








        #region "Propiedades"
        public int CodigoProveedor { get => _CodigoProveedor; set => _CodigoProveedor = value; }
        public string NombreProveedor { get => _NombreProveedor; set => _NombreProveedor = value; }
        public string Fecha { get => _Fecha; set => _Fecha = value; }
        public string NumeroFactura { get => _NumeroFactura; set => _NumeroFactura = value; }
        public int CodigoProducto { get => _CodigoProducto; set => _CodigoProducto = value; }
        public string NombreProducto { get => _NombreProducto; set => _NombreProducto = value; }
        public int Cantidad { get => _Cantidad; set => _Cantidad = value; }
        public double Precio { get => _Precio; set => _Precio = value; }
        public double Total { get => _Total; set => _Total = value; }
        #endregion

        #region "Metodos"


        public void EscribeFacturaDT()
        {
            obj_facturacompra.AgregarFactura(_CodigoProveedor, _NombreProveedor, _Fecha, _NumeroFactura, _CodigoProducto, _NombreProducto, _Cantidad, _Precio, _Total);


        }//fin EscribeProdutoDT

        public void EscribeFacturaXML()
        {
            obj_facturacompra.EscribeTabla_en_XML();

        }
        public void LeeTablaFactura()
        {

            obj_facturacompra.LeeXML_a_TablaFactura();
        }//fin LeeTablaUsuario

        public void EscribeFactura2()
        {
            obj_facturacompraXML.EscribeFacturaAppend(_CodigoProveedor, _NombreProveedor, _Fecha,  _CodigoProducto,_NombreProducto, _Cantidad, _Precio, _Total);

        }




        #endregion
    }
}
