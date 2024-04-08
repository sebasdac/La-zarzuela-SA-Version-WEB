using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CapaDatos
{
    public class EscribirXMLProductos
    {
        // variables
        String rutaNombre = "Productos.xml";
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
            _archivo.WriteStartElement("Productos");


        }//fin 


        //Escirbir linea

        public void EscribeProducto(int codigo, string nombre, int cantidad, int precio, double impuesto, double totalimpuesto)//recibe datos
        {
            // agregar encabezado del producto
            _archivo.WriteStartElement("Producto"); //<Producto>

            _archivo.WriteStartElement("Codigo");
            _archivo.WriteString(codigo.ToString());// escribe el codigo
            _archivo.WriteEndElement(); //cerrar etiqueta

            _archivo.WriteStartElement("Nombre");
            _archivo.WriteString(nombre);//escribe nombre
            _archivo.WriteEndElement();//cerrar

            _archivo.WriteStartElement("Precio");
            _archivo.WriteString(precio.ToString());//escribe precio
            _archivo.WriteEndElement();//cerrar

            _archivo.WriteStartElement("Cantidad");
            _archivo.WriteString(cantidad.ToString());
            _archivo.WriteEndElement();//cerrar

            _archivo.WriteStartElement("Impuesto");
            _archivo.WriteString(impuesto.ToString());
            _archivo.WriteEndElement();//cerrar

            _archivo.WriteStartElement("Total");
            _archivo.WriteString(totalimpuesto.ToString());
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
