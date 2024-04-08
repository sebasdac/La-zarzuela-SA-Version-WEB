using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CapaDatos
{
    public class EscribeXMLUsuario
    {
        
        // Variable para almacenar la ruta del archivo XML
        private string rutaNombre = "Usuarios.xml";

        #region "Metodos"

        // Método para escribir un usuario en el archivo XML
        public void EscribeUsuario(string usuario, string contrasena, string estado, string cedula, string nombre)
        {
            XmlDocument doc = new XmlDocument();

            try
            {
                doc.Load(rutaNombre);
            }//  fin try
            catch (FileNotFoundException)
            {
                // Si el archivo no existe, crear uno nuevo con la estructura requerida
                XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
                doc.AppendChild(xmlDeclaration);

                XmlElement usuariosElement = doc.CreateElement(string.Empty, "Usuarios", string.Empty);
                doc.AppendChild(usuariosElement);
            }// fin catch

            // Crear un nuevo elemento Usuario
            XmlElement usuarioElement = doc.CreateElement("Usuario");

            // Crear elementos para el nombre de usuario y contraseña
            XmlElement nombreUsuarioElement = doc.CreateElement("NombreUsuario");
            nombreUsuarioElement.InnerText = usuario;
            XmlElement contrasenaElement = doc.CreateElement("Contrasena");
            contrasenaElement.InnerText = contrasena;
            XmlElement estadoElement = doc.CreateElement("Estado");
            estadoElement.InnerText = estado;
            XmlElement cedulaElement = doc.CreateElement("Cedula");
            cedulaElement.InnerText = cedula;
            XmlElement nombreElement = doc.CreateElement("Nombre");
            nombreElement.InnerText = nombre;

            // Agregar los elementos al elemento Usuario
            usuarioElement.AppendChild(nombreUsuarioElement);
            usuarioElement.AppendChild(contrasenaElement);
            usuarioElement.AppendChild(estadoElement);
            usuarioElement.AppendChild(cedulaElement);
            usuarioElement.AppendChild(nombreElement);


            // Obtener el elemento Usuarios o crear uno nuevo si no existe
            XmlNode usuariosNode = doc.SelectSingleNode("Usuarios");
            if (usuariosNode == null)
            {
                usuariosNode = doc.CreateElement("Usuarios");
                doc.DocumentElement.AppendChild(usuariosNode);
            }

            // Agregar el elemento Usuario al elemento Usuarios
            usuariosNode.AppendChild(usuarioElement);

            // Guardar los cambios en el archivo XML
            doc.Save(rutaNombre);
        }//fin EscribeUsuario

        // variables

        XmlTextWriter _archivo;//puntero

       
        //Abrir archivo
        public void AbrirXML()
        {
            _archivo = new XmlTextWriter(rutaNombre, System.Text.Encoding.UTF8);// puntero

        }//fin AbrirXML

        //Crear encabezado
        public void CrearEncabezado()
        {
            // crear el documento xml
            _archivo.WriteStartDocument();
            _archivo.WriteStartElement("Usuarios");


        }//fin 


        //Escirbir linea

        public void EscribeProductoXMLTabla(string usuario,string contrasena, string estado, string cedula, string nombre)//recibe datos    
        {
            // agregar encabezado del producto
            _archivo.WriteStartElement("Usuario"); //<Producto>

            _archivo.WriteStartElement("NombreUsuario");
            _archivo.WriteString(usuario);
            _archivo.WriteEndElement(); //cerrar etiqueta

            _archivo.WriteStartElement("Contrasena");
            _archivo.WriteString(contrasena);
            _archivo.WriteEndElement();//cerrar

            _archivo.WriteStartElement("Estado");
            _archivo.WriteString(estado);
            _archivo.WriteEndElement();//cerrar

            _archivo.WriteStartElement("Cedula");
            _archivo.WriteString(cedula);
            _archivo.WriteEndElement();//cerrar

            _archivo.WriteStartElement("Nombre");
            _archivo.WriteString(nombre);
            _archivo.WriteEndElement();//cerrar



            _archivo.WriteEndElement();// cierra 

        }//Fin EscribeProducto()

        //Cerrar archivo

        public void Cerrar()
        {
            _archivo.WriteEndElement();//cierra </productos> 
            _archivo.WriteEndDocument();
            _archivo.Flush();//guarda el buffer 
            _archivo.Close();//libera
        }//fin Cerrar

        #endregion

    }



}

