using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CapaDatos
{
    public class EscribeXMLProveedor
    {
        // variables
        String rutaNombre = "Proveedores.xml";
        XmlTextWriter _archivo;//puntero

        #region "Metodos"
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
            _archivo.WriteStartElement("Proveedores");


        }//fin 


        //Escirbir linea

        public void EscribeProveedor(int codigo, string nombre, string cedula, string provincia, string telefono, string correo, string direccion)//recibe datos
        {
            // agregar encabezado del producto
            _archivo.WriteStartElement("Proveedor"); //<Producto>

            _archivo.WriteStartElement("Codigo");
            _archivo.WriteString(codigo.ToString());// escribe el codigo
            _archivo.WriteEndElement(); //cerrar etiqueta

            _archivo.WriteStartElement("Nombre");
            _archivo.WriteString(nombre);//escribe nombre
            _archivo.WriteEndElement();//cerrar

            _archivo.WriteStartElement("Cedula");
            _archivo.WriteString(cedula);//escribe nombre
            _archivo.WriteEndElement();//cerrar


            _archivo.WriteStartElement("Provincia");
            _archivo.WriteString(provincia);//escribe nombre
            _archivo.WriteEndElement();//cerrar

            _archivo.WriteStartElement("Telefono");
            _archivo.WriteString(telefono);//escribe nombre
            _archivo.WriteEndElement();//cerrar

            _archivo.WriteStartElement("Correo");
            _archivo.WriteString(correo);//escribe nombre
            _archivo.WriteEndElement();//cerrar

            _archivo.WriteStartElement("Direccion");
            _archivo.WriteString(direccion);//escribe nombre
            _archivo.WriteEndElement();//cerrar




            _archivo.WriteEndElement();// cierra Producto   </Producto>

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
