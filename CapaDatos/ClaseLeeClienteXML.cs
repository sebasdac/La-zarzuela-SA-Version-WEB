using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Xml;


namespace CapaDatos
{
     public class ClaseLeeClienteXML
    {
        //variables de trabajo

        private DataTable _tabla;


        #region "Propiedades"
        public DataTable Tabla { get => _tabla; set => _tabla = value; }
        public bool CodigoRepetido1 { get => CodigoRepetido; set => CodigoRepetido = value; }
        #endregion

        bool CodigoRepetido;

        #region "Metodos"

        public void LeerCliente()
        {

            XmlDocument _archivoXML;
            XmlNodeList _listaNodo;
            DataRow fila;

            try
            {
              _archivoXML = new XmlDocument();
              _archivoXML.Load("Clientes.xml");
              _listaNodo = _archivoXML.SelectNodes("/Clientes/Cliente");

                foreach(XmlNode _nodo in _listaNodo) 
                {
                  fila = Tabla.NewRow();
                    fila["Codigo"] = _nodo.ChildNodes[0].InnerText;
                    fila["Nombre"] = _nodo.ChildNodes[1].InnerText;
                    fila["Cedula"] = _nodo.ChildNodes[2].InnerText;
                    fila["Tipo"] = _nodo.ChildNodes[3].InnerText;
                    fila["Provincia"] = _nodo.ChildNodes[4].InnerText;
                    fila["Correo"] = _nodo.ChildNodes[5].InnerText;
                    fila["Telefono"] = _nodo.ChildNodes[6].InnerText;
                    fila["Direccion"] = _nodo.ChildNodes[7].InnerText;
                  _tabla.Rows.Add(fila);

                }//fin foreach

            }//fin try
           
            catch (System.IO.FileNotFoundException)
            {
                // Maneja la excepción si el archivo no se encuentra
                Console.WriteLine("El archivo XML no se encuentra.");
            }//fin catch
        }//fin LeerCliente
        public void LeerCodigo(int codigo)
        {
            XmlDocument _archivoXML;
            XmlNodeList _listaNodo;
            string CodigoXML = "";

            try
            {
                _archivoXML = new XmlDocument();
                _archivoXML.Load("Clientes.xml");
                _listaNodo = _archivoXML.SelectNodes("/Clientes/Cliente");

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
        }//fin LeerCodigo
        #endregion
    }
}
