using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CapaDatos
{
    public class LeeFacturaCompra
    {
        private DataTable _tabla;

        public DataTable Tabla { get => _tabla; set => _tabla = value; }

        public void LeeFactura()
        {
            XmlDocument _archivoXML;
            XmlNodeList _listaNodo;
            DataRow fila;

            try
            {
                _archivoXML = new XmlDocument();
                _archivoXML.Load("FacturasCompra.xml");
                _listaNodo = _archivoXML.SelectNodes("/Facturas/Factura");

                foreach (XmlNode _nodo in _listaNodo)
                {
                    fila = Tabla.NewRow(); // ya doy por sentado que ya me pasaron la tabla
                    fila["CodigoProveedor"] = _nodo.ChildNodes[0].InnerText;
                    fila["NombreProveedor"] = _nodo.ChildNodes[1].InnerText;
                    fila["Fecha"] = _nodo.ChildNodes[2].InnerText;
                    fila["NumeroFactura"] = _nodo.ChildNodes[3].InnerText;
                    fila["CodigoProducto"] = _nodo.ChildNodes[4].InnerText;
                    fila["NombreProducto"] = _nodo.ChildNodes[5].InnerText;
                    fila["Cantidad"] = _nodo.ChildNodes[6].InnerText;
                    fila["Precio"] = _nodo.ChildNodes[7].InnerText;
                    fila["Total"] = _nodo.ChildNodes[8].InnerText;

                    Tabla.Rows.Add(fila);
                }//foreach
            }//fin try
            catch (Exception ex)
            {
                throw new Exception("Error al leer el archivo XML", ex);
            }//fin exeption

        }//fin LeeUsuario
        
    }
}
