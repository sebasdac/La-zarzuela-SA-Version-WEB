using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CapaDatos
{

    public class EscribeXMLImpuestosMensuales
    {
        double _impuestomensual;

        #region "Propiedades"
        public double Impuestomensual { get => _impuestomensual; set => _impuestomensual = value; }
        #endregion

        #region "Metodos"
        public void ActualizaImpuesto(double impuestofavor, double impuestocontra, int mes)
        {
            string rutaNombre = "Impuestos.xml";

            XmlDocument doc = new XmlDocument();

            try
            {
                if (File.Exists(rutaNombre))
                {
                    doc.Load(rutaNombre);
                }
                else
                {
                    // El archivo no existe, crear uno nuevo
                    XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
                    XmlElement root = doc.DocumentElement;
                    doc.InsertBefore(xmlDeclaration, root);

                    XmlElement impuestosElement = doc.CreateElement(string.Empty, "Impuestos", string.Empty);
                    doc.AppendChild(impuestosElement);
                }
            }
            catch (XmlException ex)
            {
                Console.WriteLine("Error al cargar el archivo XML: " + ex.Message);
                return;
            }

            XmlNode impuestosNode = doc.DocumentElement;

            // Buscar el mes correspondiente en el archivo XML
            XmlNode mesNode = impuestosNode.SelectSingleNode($"Mes[@numero='{mes}']");

            if (mesNode == null)
            {
                // Si no existe el mes, lo creamos
                mesNode = doc.CreateElement("Mes");
                XmlAttribute mesAttribute = doc.CreateAttribute("numero");
                mesAttribute.Value = mes.ToString();
                mesNode.Attributes.Append(mesAttribute);
                impuestosNode.AppendChild(mesNode);
            }

            double impuestoFavor = impuestofavor;
            double impuestoContra = impuestocontra;

            // Agregar el nuevo impuesto dentro del mes correspondiente
            XmlElement impuestoElement = doc.CreateElement("Impuesto");//crea el nodo impuesto
            XmlElement impuestoMensualElement = doc.CreateElement("impuestomensual");//crea el nodo impuestomensual
            impuestoMensualElement.InnerText = (impuestoContra - impuestoFavor).ToString();//asigna el valor del impuesto mensual
            impuestoElement.AppendChild(impuestoMensualElement);
            mesNode.AppendChild(impuestoElement);

            doc.Save(rutaNombre);
        }//fin ActualizaImpuesto
       public double LeerImpuesto(int mes)
        {
            string rutaNombre = "Impuestos.xml";
            double impuestoMensual = 0;

            try
            {
                if (File.Exists(rutaNombre))
                {
                    XmlDocument doc = new XmlDocument();
                    doc.Load(rutaNombre);
                    XmlNode mesNode = doc.SelectSingleNode($"//Mes[@numero='{mes}']");

                    if (mesNode != null)
                    {
                        XmlNodeList impuestosNodeList = mesNode.SelectNodes("Impuesto");

                        foreach (XmlNode impuestoNode in impuestosNodeList)
                        {
                            impuestoMensual += double.Parse(impuestoNode.SelectSingleNode("impuestomensual").InnerText);
                        }
                    }
                    else
                    {
                        throw new ArgumentException($"No hay impuestos para el mes {mes}.");
                    }
                }
                else
                {
                    Console.WriteLine("El archivo XML de impuestos no existe.");
                }
            }
            catch (XmlException ex)
            {
                Console.WriteLine("Error al cargar el archivo XML: " + ex.Message);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("El archivo XML de impuestos no se encuentra.");
            }

            return impuestoMensual;
        }//fin leerimpuesto


        #endregion




    }
}
    







