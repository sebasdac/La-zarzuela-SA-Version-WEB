using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CapaDatos
{
    public class EscribeFacturaCompraXML
    {

        // Variable para almacenar la ruta del archivo XML
        private string rutaNombre = "FacturasCompra.xml";
        

        #region "Metodos"




        public void EscribeFacturaXMLTabla(int codigoproveedor, string nombreproveedor, string fecha, string numerofactura, int codigoproducto, string nombreproducto, int cantidad, double precio, double total)//recibe datos    
        {
            // agregar encabezado del producto
            _archivo.WriteStartElement("Factura"); //<Producto>

            _archivo.WriteStartElement("CodigoProveedor");
            _archivo.WriteString(codigoproveedor.ToString());
            _archivo.WriteEndElement(); //cerrar etiqueta

            _archivo.WriteStartElement("NombreProveedor");
            _archivo.WriteString(nombreproveedor);
            _archivo.WriteEndElement();//cerrar

            _archivo.WriteStartElement("Fecha");
            _archivo.WriteString(fecha);
            _archivo.WriteEndElement();//cerrar

            _archivo.WriteStartElement("NumeroFactura");
            _archivo.WriteString(numerofactura);
            _archivo.WriteEndElement();//cerrar

            _archivo.WriteStartElement("CodigoProducto");
            _archivo.WriteString(codigoproducto.ToString());
            _archivo.WriteEndElement();//cerrar

            _archivo.WriteStartElement("NombreProducto");
            _archivo.WriteString(nombreproducto);
            _archivo.WriteEndElement();//cerrar

            _archivo.WriteStartElement("Cantidad");
            _archivo.WriteString(cantidad.ToString());
            _archivo.WriteEndElement();//cerrar

            _archivo.WriteStartElement("Precio");
            _archivo.WriteString(precio.ToString());
            _archivo.WriteEndElement();//cerrar

            _archivo.WriteStartElement("Total");
            _archivo.WriteString(total.ToString());
            _archivo.WriteEndElement();//cerrar




            _archivo.WriteEndElement();// cierra 

        }//Fin EscribeProducto()









        // Método para escribir un usuario en el archivo XML
        public void EscribeFacturaAppend(int codigoproveedor, string nombreproveedor, string fecha, int codigoproducto, string nombreproducto, int cantidad, double precio, double total)
        {
            XmlDocument doc = new XmlDocument();
            //consecutivo needs to be a random number but i need thath number doesnt repeat again
            Random rnd = new Random();
            int numero = rnd.Next(10000000, 99999999); // Rango de 10000000 a 99999999
            string consecutivo = "FC - "+numero.ToString();
            

            
                

            try
            {
                doc.Load(rutaNombre);
            }//  fin try
            catch (FileNotFoundException)
            {
                // Si el archivo no existe, crear uno nuevo con la estructura requerida
                XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
                doc.AppendChild(xmlDeclaration);

                XmlElement usuariosElement = doc.CreateElement(string.Empty, "Facturas", string.Empty);
                doc.AppendChild(usuariosElement);
            }// fin catch

            // Crear un nuevo elemento Usuario
            XmlElement facturaElement = doc.CreateElement("Factura");

            // Crear elementos para el nombre de usuario y contraseña
            XmlElement codigoProveedorElement = doc.CreateElement("CodigoProveedor");
            codigoProveedorElement.InnerText = codigoproveedor.ToString() ;
            XmlElement NombreProveedorElement = doc.CreateElement("NombreProveedor");
            NombreProveedorElement.InnerText = nombreproveedor;
            XmlElement FechaElement = doc.CreateElement("Fecha");
            FechaElement.InnerText = fecha;
            XmlElement NumeroFacturaElement = doc.CreateElement("NumeroFactura");
            NumeroFacturaElement.InnerText = consecutivo;
            XmlElement CodigoProductoElement = doc.CreateElement("CodigoProducto");
            CodigoProductoElement.InnerText = codigoproducto.ToString();
            XmlElement NombreProductoElement = doc.CreateElement("NombreProducto");
            NombreProductoElement.InnerText = nombreproducto;
            XmlElement CantidadElement = doc.CreateElement("Cantidad");
            CantidadElement.InnerText = cantidad.ToString();
            XmlElement PrecioElement = doc.CreateElement("Precio");
            PrecioElement.InnerText = precio.ToString();
            XmlElement TotalElement = doc.CreateElement("Total");
            TotalElement.InnerText = total.ToString();

            // Agregar los elementos al elemento Usuario
            facturaElement.AppendChild(codigoProveedorElement);
            facturaElement.AppendChild(NombreProveedorElement);
            facturaElement.AppendChild(FechaElement);
            facturaElement.AppendChild(NumeroFacturaElement);
            facturaElement.AppendChild(CodigoProductoElement);
            facturaElement.AppendChild(NombreProductoElement);
            facturaElement.AppendChild(CantidadElement);
            facturaElement.AppendChild(PrecioElement);
            facturaElement.AppendChild(TotalElement);


            // Obtener el elemento Usuarios o crear uno nuevo si no existe
            XmlNode usuariosNode = doc.SelectSingleNode("Facturas");
            if (usuariosNode == null)
            {
                usuariosNode = doc.CreateElement("Factura");
                doc.DocumentElement.AppendChild(usuariosNode);
            }

            // Agregar el elemento Usuario al elemento Usuarios
            usuariosNode.AppendChild(facturaElement);

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
            _archivo.WriteStartElement("Facturas");


        }//fin 

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
