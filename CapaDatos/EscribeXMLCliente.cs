using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CapaDatos
{
    public class EscribeXMLCliente
    {
        //varible
        String rutaNombre = "Clientes.xml";
        XmlTextWriter _archivo;

        #region "Metodos"
        public void AbrirXML()
        {

            _archivo = new XmlTextWriter(rutaNombre, System.Text.Encoding.UTF8);
        }//fin AbrirXML()

        //escribir linea
        public void CrearEncabezado()
        {
            _archivo.WriteStartDocument();
            _archivo.WriteStartElement("Clientes");
        }// fin CrearEncabezado

        //escribir producto
        public void EscribeCliente(int Codigo, string Nombre, string Cedula, string Tipo, string Provincia, string Correo, string Telefono, string Direccion)
        {

            _archivo.WriteStartElement("Cliente");

            _archivo.WriteStartElement("Codigo");
            _archivo.WriteString(Codigo.ToString());
            _archivo.WriteEndElement();


            _archivo.WriteStartElement("Nombre");
            _archivo.WriteString(Nombre);
            _archivo.WriteEndElement();

            _archivo.WriteStartElement("Cedula");
            _archivo.WriteString(Cedula);
            _archivo.WriteEndElement();

            _archivo.WriteStartElement("Tipo");
            _archivo.WriteString(Tipo);
            _archivo.WriteEndElement();

            _archivo.WriteStartElement("Provincia");
            _archivo.WriteString(Provincia);
            _archivo.WriteEndElement();

            _archivo.WriteStartElement("Correo");
            _archivo.WriteString(Correo);
            _archivo.WriteEndElement();

            _archivo.WriteStartElement("Telefono");
            _archivo.WriteString(Telefono);
            _archivo.WriteEndElement();

            _archivo.WriteStartElement("Direccion");
            _archivo.WriteString(Direccion);
            _archivo.WriteEndElement();

            _archivo.WriteEndElement();

        }//fin EscribeProducto()

        //cierra
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
