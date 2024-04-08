using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CapaDatos
{
    public class EscribeXMFacturaCompra
    {
        string consecutivo;

        public string Consecutivo { get => consecutivo; set => consecutivo = value; }
        #region "Metodos"
        public void EscribeXMLFacturaCompra(int codigoProducto, string nombreProducto, int cantidad, int precio, double impuesto, double totalimpuesto, int codigoProveedor, string nombreProveedor, DateTime fechacompra)
        {
            // Crear una instancia de Random
            Random rnd = new Random();

            // Generar un número aleatorio de 8 dígitos
            int numero = rnd.Next(10000000, 99999999); // Rango de 10000000 a 99999999

            // Convertir el número a una cadena de caracteres
            consecutivo = numero.ToString();

            // Crear un nuevo documento XML
            XmlDocument doc = new XmlDocument();

            // Declaración XML
            XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            doc.AppendChild(xmlDeclaration);

            // Elemento raíz "Facturas"
            XmlElement facturasElement = doc.CreateElement(string.Empty, "Facturas", string.Empty);
            doc.AppendChild(facturasElement);

            // Crear un nuevo elemento Factura
            XmlElement facturaElement = doc.CreateElement("Factura");

            // Función auxiliar para crear elementos XML
            void AgregarElemento(string nombre, string valor)
            {
                XmlElement elemento = doc.CreateElement(nombre);
                elemento.InnerText = valor;
                facturaElement.AppendChild(elemento);
            }

            // Agregar elementos a la factura
            AgregarElemento("CodigoProducto", codigoProducto.ToString());
            AgregarElemento("NombreProducto", nombreProducto);
            AgregarElemento("Cantidad", cantidad.ToString());
            AgregarElemento("Precio", precio.ToString());
            AgregarElemento("Impuesto",impuesto.ToString());
            AgregarElemento("Total", totalimpuesto.ToString());
            AgregarElemento("CodigoProveedor", codigoProveedor.ToString());
            AgregarElemento("NombreProveedor", nombreProveedor);
            AgregarElemento("FechaCompra", fechacompra.ToString());
            AgregarElemento("Consecutivo", consecutivo.ToString());


            // Agregar la factura al elemento Facturas
            facturasElement.AppendChild(facturaElement);

            // Guardar los cambios en el archivo XML
            string rutaNombre = "FC-" + consecutivo + ".xml"; // Nombre del archivo
            doc.Save(rutaNombre);
            //

        }//fin EscribeXMLFacturaCompra
        #endregion
    }
}
