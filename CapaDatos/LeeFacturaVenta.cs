using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CapaDatos
{
    public class LeeFacturaVenta
    {
        private DataTable _tabla;


        #region "Propiedades"
        public DataTable Tabla { get => _tabla; set => _tabla = value; }
        
        #endregion

        

        #region "Metodos"

        public void LeerFacturaVenta()
        {

            XmlDocument _archivoXML;
            XmlNodeList _listaNodo;
            DataRow fila;

            try
            {
                _archivoXML = new XmlDocument();
                _archivoXML.Load("FacturasVenta.xml");
                _listaNodo = _archivoXML.SelectNodes("/Facturas/Factura");

                foreach (XmlNode _nodo in _listaNodo)
                {
                    fila = Tabla.NewRow();
                    fila["Codigo cliente"] = _nodo.ChildNodes[0].InnerText;
                    fila["Nombre cliente"] = _nodo.ChildNodes[1].InnerText;
                    fila["Cedula"] = _nodo.ChildNodes[2].InnerText;
                    fila["Tipo"] = _nodo.ChildNodes[3].InnerText;
                    fila["Provincia"] = _nodo.ChildNodes[4].InnerText;
                    fila["Correo"] = _nodo.ChildNodes[5].InnerText;
                    fila["Telefono"] = _nodo.ChildNodes[6].InnerText;
                    fila["Direccion"] = _nodo.ChildNodes[7].InnerText;
                    fila["Codigo producto"] = _nodo.ChildNodes[8].InnerText;
                    fila["Nombre producto"] = _nodo.ChildNodes[9].InnerText;
                    fila["Cantidad"] = _nodo.ChildNodes[10].InnerText;
                    fila["Precio"] = _nodo.ChildNodes[11].InnerText;
                    fila["Impuesto"] = _nodo.ChildNodes[12].InnerText;
                    fila["Total"] = _nodo.ChildNodes[13].InnerText;
                    _tabla.Rows.Add(fila);

                }//fin foreach

            }//fin try

            catch (System.IO.FileNotFoundException)
            {
                // Maneja la excepción si el archivo no se encuentra
                Console.WriteLine("El archivo XML no se encuentra.");
            }//fin catch
        }//fin LeerCliente
        #endregion

    }
}
