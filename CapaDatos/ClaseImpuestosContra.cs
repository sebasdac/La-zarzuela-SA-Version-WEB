using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public  class ClaseImpuestosContra
    {
        private String String_Conexion = "Data Source=LAPTOP-M50THNEO;Initial Catalog=\"Proyecto II\";Integrated Security=True;";
        //private String String_Conexion = "Data Source=SebasDAC_PC;Initial Catalog=\"Proyecto II\";Integrated Security=True;";
        decimal totalImpuestosContra = 0;

        string consultaDetalles = "SELECT FacturaID FROM FacturaCompra WHERE MONTH(Fecha) = @Mes";

        // Consulta para obtener los impuestos de las facturas
        string consultaImpuestos = "SELECT Impuesto FROM DetallesFacturaCompra WHERE FacturaID = @FacturaID";

        public decimal TotalImpuestoscontra { get => totalImpuestosContra; set => totalImpuestosContra = value; }

        public void CalcularImpuestosCompra(int mes)
        {
            using (SqlConnection conexion = new SqlConnection(String_Conexion))
            {
                // Abrir la conexión
                conexion.Open();

                // Crear el comando para filtrar las facturas del mes especificado
                using (SqlCommand comandoDetalles = new SqlCommand(consultaDetalles, conexion))
                {
                    // Establecer el parámetro del mes
                    comandoDetalles.Parameters.AddWithValue("@Mes", mes);

                    // Lista para almacenar los FacturaID
                    List<int> facturaIDs = new List<int>();

                    // Ejecutar la consulta y almacenar los resultados en la lista
                    using (SqlDataReader readerDetalles = comandoDetalles.ExecuteReader())
                    {
                        while (readerDetalles.Read())
                        {
                            facturaIDs.Add(readerDetalles.GetInt32(0));
                        }
                    }

                    // Iterar sobre los FacturaID y obtener los impuestos
                    foreach (int facturaID in facturaIDs)
                    {
                        // Crear el comando para obtener los impuestos de la factura
                        using (SqlCommand comandoImpuestos = new SqlCommand(consultaImpuestos, conexion))
                        {
                            // Establecer el parámetro del FacturaID
                            comandoImpuestos.Parameters.AddWithValue("@FacturaID", facturaID);

                            // Obtener los impuestos de la factura y sumarlos
                            using (SqlDataReader readerImpuestos = comandoImpuestos.ExecuteReader())
                            {
                                // Sumar los impuestos
                                while (readerImpuestos.Read())
                                {
                                    TotalImpuestoscontra += readerImpuestos.GetDecimal(0);
                                }
                            }
                        }
                    }
                }
            }

            // Mostrar el total de impuestos
            Console.WriteLine($"El total de impuestos para el mes {mes} es: {TotalImpuestoscontra}");
        }
    }
}
