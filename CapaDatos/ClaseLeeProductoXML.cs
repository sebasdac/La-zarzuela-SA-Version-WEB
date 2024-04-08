using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Xml;

namespace CapaDatos
{
     public class ClaseLeeProductoXML
    {
        //variaable trabajo

        private DataTable _tabla;

        #region "propiedades"
        public DataTable Tabla { get => _tabla; set => _tabla = value; }
        public bool CodigoRepetido1 { get => CodigoRepetido; set => CodigoRepetido = value; }
        #endregion

        bool CodigoRepetido;

        #region "Metodos"

        public void LeeProductos()
        {
            XmlDocument _archivoXML;
            XmlNodeList _listaNodo;
            DataRow fila;
            
            try
            {
                _archivoXML = new XmlDocument();
                _archivoXML.Load("Productos.xml");
                _listaNodo = _archivoXML.SelectNodes("/Productos/Producto");
                
                foreach (XmlNode _nodo in _listaNodo)
                {
                    fila = _tabla.NewRow(); // ya doy por sentado que ya me pasaron la tabla
                    fila["Codigo"] = _nodo.ChildNodes[0].InnerText;
                    fila["Nombre"] = _nodo.ChildNodes[1].InnerText;
                    fila["Cantidad"] = _nodo.ChildNodes[2].InnerText;
                    fila["Precio"] = _nodo.ChildNodes[3].InnerText;
                    fila["Impuesto"] = _nodo.ChildNodes[4].InnerText;
                    fila["Total"] = _nodo.ChildNodes[5].InnerText;

                    _tabla.Rows.Add(fila);
                }//foreach
            }//fin try
            catch (Exception ex)
            {
                
            }//fin exeption

        }//fin leeProductos

        public void LeerCodigo(int codigo)
        {
            XmlDocument _archivoXML;
            XmlNodeList _listaNodo;
            string CodigoXML = "";

            try
            {
                _archivoXML = new XmlDocument();
                _archivoXML.Load("Productos.xml");
                _listaNodo = _archivoXML.SelectNodes("/Productos/Producto");

                foreach (XmlNode _nodo in _listaNodo)
                {

                    XmlNode correoNode = _nodo.SelectSingleNode("Codigo");

                    if (correoNode != null)
                    {
                        CodigoXML = correoNode.InnerText;

                        Console.WriteLine("Valor de codigo de xml: " + CodigoXML + "codigo de la interfaz: " + codigo);
                        if (CodigoXML == codigo.ToString())
                        {
                            Console.WriteLine("Pasep por aqui");
                            CodigoRepetido = true;
                            break;
                        }
                        if (CodigoXML != codigo.ToString())
                        {
                            Console.WriteLine("Pasep por aqui");
                            CodigoRepetido = false;

                        }


                    }//fin if


                }//fin foreach
            }//fin try
          
            catch (System.IO.FileNotFoundException)
            {
                // Maneja la excepción si el archivo no se encuentra
                Console.WriteLine("El archivo XML no se encuentra.");
            }//fin catch
        }
    }
        #endregion
}





