using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ClaseFacturas
    {
        private string connectionString = "tu_cadena_de_conexión";

        public int InsertarFactura(int clienteID, string nombrecliente, string cedula,string tipocliente,
            DateTime fecha, decimal total)
        {
            int facturaID = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Insertar la factura
                string insertFacturaQuery = "INSERT INTO Facturas (FacturaID, ClienteID, NombreCliente, CedulaCliente," +
                    "TipoCliente, Fecha, Total) VALUES (@ClienteID, @Fecha, @Total); SELECT SCOPE_IDENTITY();";
                using (SqlCommand command = new SqlCommand(insertFacturaQuery, connection))
                {
                    command.Parameters.AddWithValue("@FacturaID", facturaID);
                    command.Parameters.AddWithValue("@ClienteID", clienteID);
                    command.Parameters.AddWithValue("@NombreCliente", nombrecliente);
                    command.Parameters.AddWithValue("@CedulaCliente", cedula);
                    command.Parameters.AddWithValue("@TipoCliente", tipocliente);

                    command.Parameters.AddWithValue("@Fecha", fecha);
                    command.Parameters.AddWithValue("@Total", total);
                    facturaID = Convert.ToInt32(command.ExecuteScalar());
                }
            }

            return facturaID;
        }

        public void InsertarDetalleFactura(int facturaID, int productoID, int cantidad, decimal precio, decimal subtotal, decimal totalProducto)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Insertar el detalle de la factura
                string insertDetalleQuery = "INSERT INTO DetallesFactura (FacturaID, ProductoID, Cantidad, Precio, SubTotal, TotalProducto) VALUES (@FacturaID, @ProductoID, @Cantidad, @Precio,@SubTotal, @TotalProducto);";
                using (SqlCommand command = new SqlCommand(insertDetalleQuery, connection))
                {
                    command.Parameters.AddWithValue("@FacturaID", facturaID);
                    command.Parameters.AddWithValue("@ProductoID", productoID);
                    command.Parameters.AddWithValue("@Cantidad", cantidad);
                    command.Parameters.AddWithValue("@Precio", precio);
                    command.Parameters.AddWithValue("@SubTotal", subtotal);

                    command.Parameters.AddWithValue("@TotalProducto", totalProducto);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
