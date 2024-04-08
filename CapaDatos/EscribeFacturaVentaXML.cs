using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CapaDatos
{
   public class EscribeFacturaVentaXML
    {

        //varible
        String rutaNombre = "FacturasVenta.xml";
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
            _archivo.WriteStartElement("Facturas");
        }// fin CrearEncabezado


        public void EscribeFactura2(int CodigoCliente, string NombreCliente, string Cedula, string Tipo, string Provincia, string Correo, string Telefono, string Direccion, int codigoproducto, string nombreproducto, int cantidad, int precio, double impuesto, double totalimpuesto)
        {
            XmlDocument doc = new XmlDocument();
            //consecutivo needs to be a random number but i need thath number doesnt repeat again
            Random rnd = new Random();
            int numero = rnd.Next(10000000, 99999999); // Rango de 10000000 a 99999999
            string consecutivo = "FC - " + numero.ToString();

            try
            {
                doc.Load(rutaNombre);
            }
            catch (FileNotFoundException)
            {
                // Si el archivo no existe, crear uno nuevo con la estructura requerida
                XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
                doc.AppendChild(xmlDeclaration);

                XmlElement facturasElement = doc.CreateElement(string.Empty, "Facturas", string.Empty);
                doc.AppendChild(facturasElement);
            }

            // Crear un nuevo elemento Factura
            XmlElement facturaElement = doc.CreateElement("Factura");

            // Crear elementos para la factura
            XmlElement codigoClienteElement = doc.CreateElement("CodigoCliente");
            codigoClienteElement.InnerText = CodigoCliente.ToString();
            XmlElement nombreClienteElement = doc.CreateElement("NombreCliente");
            nombreClienteElement.InnerText = NombreCliente;
            XmlElement cedulaElement = doc.CreateElement("Cedula");
            cedulaElement.InnerText = Cedula;
            XmlElement tipoElement = doc.CreateElement("Tipo");
            tipoElement.InnerText = Tipo;
            XmlElement provinciaElement = doc.CreateElement("Provincia");
            provinciaElement.InnerText = Provincia;
            XmlElement correoElement = doc.CreateElement("Correo");
            correoElement.InnerText = Correo;
            XmlElement telefonoElement = doc.CreateElement("Telefono");
            telefonoElement.InnerText = Telefono;
            XmlElement direccionElement = doc.CreateElement("Direccion");
            direccionElement.InnerText = Direccion;
            XmlElement codigoProductoElement = doc.CreateElement("CodigoProducto");
            codigoProductoElement.InnerText = codigoproducto.ToString();
            XmlElement nombreProductoElement = doc.CreateElement("NombreProducto");
            nombreProductoElement.InnerText = nombreproducto;
            XmlElement cantidadElement = doc.CreateElement("Cantidad");
            cantidadElement.InnerText = cantidad.ToString();
            XmlElement precioElement = doc.CreateElement("Precio");
            precioElement.InnerText = precio.ToString();
            XmlElement impuestoElement = doc.CreateElement("Impuesto");
            impuestoElement.InnerText = impuesto.ToString();
            XmlElement totalImpuestoElement = doc.CreateElement("TotalImpuesto");
            totalImpuestoElement.InnerText = totalimpuesto.ToString();
            XmlElement consecutivoElement = doc.CreateElement("Consecutivo");
            consecutivoElement.InnerText = consecutivo;

            // Agregar los elementos a la factura
            facturaElement.AppendChild(codigoClienteElement);
            facturaElement.AppendChild(nombreClienteElement);
            facturaElement.AppendChild(cedulaElement);
            facturaElement.AppendChild(tipoElement);
            facturaElement.AppendChild(provinciaElement);
            facturaElement.AppendChild(correoElement);
            facturaElement.AppendChild(telefonoElement);
            facturaElement.AppendChild(direccionElement);
            facturaElement.AppendChild(codigoProductoElement);
            facturaElement.AppendChild(nombreProductoElement);
            facturaElement.AppendChild(cantidadElement);
            facturaElement.AppendChild(precioElement);
            facturaElement.AppendChild(impuestoElement);
            facturaElement.AppendChild(totalImpuestoElement);
            facturaElement.AppendChild(consecutivoElement);

            // Obtener el elemento Facturas o crear uno nuevo si no existe
            XmlNode facturasNode = doc.SelectSingleNode("Facturas");
            if (facturasNode == null)
            {
                facturasNode = doc.CreateElement("Facturas");
                doc.DocumentElement.AppendChild(facturasNode);
            }

            // Agregar el elemento Factura al elemento Facturas
            facturasNode.AppendChild(facturaElement);

            // Guardar los cambios en el archivo XML
            doc.Save(rutaNombre);
        }






        //escribir producto
        public void EscribeFactura(int CodigoCliente, string NombreCliente, string Cedula, string Tipo, string Provincia, string Correo, string Telefono, string Direccion, int codigoproducto, string nombreproducto, int cantidad, int precio, double impuesto, double totalimpuesto)
        {

            _archivo.WriteStartElement("Cliente");

            _archivo.WriteStartElement("CodigoCliente");
            _archivo.WriteString(CodigoCliente.ToString());
            _archivo.WriteEndElement();


            _archivo.WriteStartElement("NombreCliente");
            _archivo.WriteString(NombreCliente);
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
           //recibe datos
        
                

                _archivo.WriteStartElement("CodigoProducto");
                _archivo.WriteString(codigoproducto.ToString());// escribe el codigo
                _archivo.WriteEndElement(); //cerrar etiqueta

                _archivo.WriteStartElement("NombreProducto");
                _archivo.WriteString(nombreproducto);//escribe nombre
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
