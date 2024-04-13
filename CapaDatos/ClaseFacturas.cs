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
        private string connectionString = "Data Source=LAPTOP-M50THNEO;Initial Catalog=\"Proyecto II\";Integrated Security=True;";

       

        public int InsertarFactura(int clienteID, string nombre, string cedula, string tipo, DateTime fecha, decimal total)
        {
            int facturaID = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO Factura (ClienteID, NombreCliente, CedulaCliente, TipoCliente, Fecha, Total) VALUES (@ClienteID, @Nombre, @Cedula,@Tipo, @Fecha, @Total); SELECT SCOPE_IDENTITY();";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ClienteID", clienteID);
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Cedula", cedula);
                    command.Parameters.AddWithValue("@Tipo", tipo);
                    command.Parameters.AddWithValue("@Fecha", fecha);
                    command.Parameters.AddWithValue("@Total", total);
                    
                    facturaID = Convert.ToInt32(command.ExecuteScalar());
                }
            }

            return facturaID;
        }

        public void InsertarDetalleFactura(int facturaID, int productoID, int cantidad, decimal precio, decimal impuesto, decimal subtotal, decimal totalProducto,string nombreproducto)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO DetallesFactura (FacturaID, ProductoID, Cantidad, Precio, Impuesto, Subtotal, TotalProducto, ProductoNombre) VALUES (@FacturaID, @ProductoID, @Cantidad, @Precio, @Impuesto, @Subtotal, @TotalProducto,@NombreProducto);";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FacturaID", facturaID);
                    command.Parameters.AddWithValue("@ProductoID", productoID);
                    command.Parameters.AddWithValue("@Cantidad", cantidad);
                    command.Parameters.AddWithValue("@Precio", precio);
                    command.Parameters.AddWithValue("@Impuesto", impuesto);
                    command.Parameters.AddWithValue("@Subtotal", subtotal);
                    command.Parameters.AddWithValue("@TotalProducto", totalProducto);
                    command.Parameters.AddWithValue("@NombreProducto", nombreproducto);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
    

