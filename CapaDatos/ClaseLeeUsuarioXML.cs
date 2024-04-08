using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CapaDatos
{
    public class ClaseLeeUsuarioXML
    {

        private DataTable _tabla;

        #region "Propiedades"
        public DataTable Tabla { get => _tabla; set => _tabla = value; }
        public bool UsuarioRepetido1 { get => UsuarioRepetido; set => UsuarioRepetido = value; }
        public bool UsuarioCorrecto1 { get => UsuarioCorrecto; set => UsuarioCorrecto = value; }
        public bool Pincorrecto { get => _pincorrecto; set => _pincorrecto = value; }
        #endregion
        
        bool UsuarioRepetido;
        bool UsuarioCorrecto;
        bool _pincorrecto;
        
        #region "Metodos"

        public void LeeUsuario()
        {
            XmlDocument _archivoXML;
            XmlNodeList _listaNodo;
            DataRow fila;

            try
            {
                _archivoXML = new XmlDocument();
                _archivoXML.Load("Usuarios.xml");
                _listaNodo = _archivoXML.SelectNodes("/Usuarios/Usuario");

                foreach (XmlNode _nodo in _listaNodo)
                {
                    fila = _tabla.NewRow(); // ya doy por sentado que ya me pasaron la tabla
                    fila["NombreUsuario"] = _nodo.ChildNodes[0].InnerText;
                    fila["Contrasena"] = _nodo.ChildNodes[1].InnerText;
                    fila["Estado"] = _nodo.ChildNodes[2].InnerText;
                    fila["Cedula"] = _nodo.ChildNodes[3].InnerText;
                    fila["Nombre"] = _nodo.ChildNodes[4].InnerText;

                    _tabla.Rows.Add(fila);
                }//foreach
            }//fin try
            catch (Exception ex)
            {
                throw new Exception("Error al leer el archivo XML", ex);
            }//fin exeption

        }//fin LeeUsuario

        public void LeerUsuarioRepetido(string usuario)
        {
            XmlDocument _archivoXML;
            XmlNodeList _listaNodo;
            string CodigoXML = "";

            try
            {
                _archivoXML = new XmlDocument();
                _archivoXML.Load("Usuarios.xml");
                _listaNodo = _archivoXML.SelectNodes("/Usuarios/Usuario");

                foreach (XmlNode _nodo in _listaNodo)
                {

                    XmlNode correoNode = _nodo.SelectSingleNode("NombreUsuario");

                    if (correoNode != null)
                    {
                        CodigoXML = correoNode.InnerText;

                        Console.WriteLine("Valor de codigo de xml: " + CodigoXML + "codigo de la interfaz: " + usuario);
                        if (CodigoXML == usuario.ToString())
                        {
                            //Console.WriteLine("Pasep por aqui");
                            UsuarioRepetido = true;
                            break;
                        }//fin
                        if (CodigoXML != usuario.ToString())
                        {
                            //Console.WriteLine("Pasep por aqui");
                            UsuarioRepetido = false;

                        }//fin if


                    }  //fin if


                }//fin foreach
            }
            catch (System.IO.FileNotFoundException)
            {
                // Maneja la excepción si el archivo no se encuentra
                Console.WriteLine("El archivo XML no se encuentra.");
            }//fin catch
        }//fin LeerUsuarioRepetido

        public void VerificarLogin(string usuario, string contrasena)
        {
            XmlDocument _archivoXML;
            XmlNodeList _listaNodo;
            string UsuarioXML= "";
            string ContrasenaXML = "";
            string EstadoXML = " ";
            string Estado = "Activo";

            try
            {
                _archivoXML = new XmlDocument();
                _archivoXML.Load("Usuarios.xml");
                _listaNodo = _archivoXML.SelectNodes("/Usuarios/Usuario");

                foreach (XmlNode _nodo in _listaNodo)
                {

                    XmlNode usuarioNode = _nodo.SelectSingleNode("NombreUsuario");
                    XmlNode contrasenaNode = _nodo.SelectSingleNode("Contrasena");
                    XmlNode estadoNode = _nodo.SelectSingleNode("Estado");

                    if (usuarioNode != null && contrasenaNode != null)
                    {
                        UsuarioXML = usuarioNode.InnerText;
                        ContrasenaXML = contrasenaNode.InnerText;
                        EstadoXML = estadoNode.InnerText;


                        if (UsuarioXML == usuario && ContrasenaXML == contrasena && EstadoXML==Estado )
                        {
                            
                            UsuarioCorrecto1 = true;
                            break;
                        }
                        if (UsuarioXML != usuario && ContrasenaXML != contrasena)
                        {
                           
                            UsuarioCorrecto1 = false;

                        }
                        if (UsuarioXML == usuario && ContrasenaXML != contrasena)
                        {
                            
                            UsuarioCorrecto1 = false;

                        }
                        if (UsuarioXML != usuario && ContrasenaXML == contrasena)
                        {
                            
                            UsuarioCorrecto1 = false;

                        }


                    }//fin if
                }//fin foreach
            }//fin try
            catch (System.IO.FileNotFoundException)
            {
                // Maneja la excepción si el archivo no se encuentra
                Console.WriteLine("El archivo XML no se encuentra.");
            }//fin catch


        }//fin VerificarLogin
        public void PinCorrecto(int pin)
        {
            XmlDocument _archivoXML;
            XmlNodeList _listaNodo;
            string CodigoXML = "";

            try
            {
                _archivoXML = new XmlDocument();
                _archivoXML.Load("Pin.xml");
                _listaNodo = _archivoXML.SelectNodes("/MiPin/Pin");

                foreach (XmlNode _nodo in _listaNodo)
                {

                    XmlNode correoNode = _nodo.SelectSingleNode("pin");

                    if (correoNode != null)
                    {
                        CodigoXML = correoNode.InnerText;

                        Console.WriteLine("Valor de codigo de xml: " + CodigoXML + " codigo de la interfaz: " + pin);
                        if (int.Parse(CodigoXML) == pin)
                        {
                            Console.WriteLine("Pasep por aqui");
                            _pincorrecto = true;
                            break;
                        }
                        if (int.Parse(CodigoXML) != pin)
                        {
                            //Console.WriteLine("Pasep por aqui");
                            UsuarioRepetido = false;

                        }



                    }//fin if


                }//fin foreach
            }//fin try
            catch (System.IO.FileNotFoundException)
            {
                // Maneja la excepción si el archivo no se encuentra
                Console.WriteLine("El archivo XML no se encuentra.");
            }//fin catch

        }//fin PinCorrecto

        public void CambiaPIN(int nuevoPIN)
        {
            XmlDocument _archivoXML;
            XmlNodeList _listaNodo;
            string CodigoXML = "";

            try
            {
                _archivoXML = new XmlDocument();
                _archivoXML.Load("Pin.xml");
                _listaNodo = _archivoXML.SelectNodes("/MiPin/Pin");

                foreach (XmlNode _nodo in _listaNodo)
                {
                    XmlNode pinNode = _nodo.SelectSingleNode("pin");

                    if (pinNode != null)
                    {
                        CodigoXML = pinNode.InnerText;

                        if (int.Parse(CodigoXML) == nuevoPIN)
                        {
                            Console.WriteLine("El nuevo PIN coincide con uno existente.");
                            return;
                        }
                        else
                        {
                            pinNode.InnerText = nuevoPIN.ToString();
                            _archivoXML.Save("Pin.xml");
                            Console.WriteLine("PIN cambiado exitosamente.");
                            return;
                        }
                    }//fin if
                }//fin foreach

                Console.WriteLine("No se encontró el PIN en el archivo XML.");
            }//fin try
            
            
            catch (System.IO.FileNotFoundException)
            {
                Console.WriteLine("El archivo XML no se encuentra.");
            }//fin catch
        }//fin CambiaPIN


        #endregion

    }
}
