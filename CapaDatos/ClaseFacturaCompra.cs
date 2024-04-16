using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ClaseFacturaCompra
    {


        //private string String_Conexion = "Data Source=LAPTOP-M50THNEO;Initial Catalog=\"Proyecto II\";Integrated Security=True;";
        private String String_Conexion = "Data Source=SebasDAC_PC;Initial Catalog=\"Proyecto II\";Integrated Security=True;";


        private SqlConnection conexion;
        DataSet ds_resultados = new DataSet();
        public DataTable TablaFacturas { get => ds_resultados.Tables[0]; }
        DataSet ds_detalles = new DataSet();
        public DataTable TablaDetalles { get => ds_detalles.Tables[0]; }


        public int InsertarFactura(int clienteID, string nombre, string cedula, string tipo, DateTime fecha, decimal total)
        {
            int facturaID = 0;

            using (SqlConnection connection = new SqlConnection(String_Conexion))
            {
                connection.Open();

                string query = "INSERT INTO FacturaCompra (ProveedorID, NombreProveedor, CedulaProveedor, Tipo, Fecha, Total) VALUES (@ProveedorID," +
                    " @NombreProveedor, @CedulaProveedor,@Tipo, @Fecha, @Total); SELECT SCOPE_IDENTITY();";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProveedorID", clienteID);
                    command.Parameters.AddWithValue("@NombreProveedor", nombre);
                    command.Parameters.AddWithValue("@CedulaProveedor", cedula);
                    command.Parameters.AddWithValue("@Tipo", tipo);
                    command.Parameters.AddWithValue("@Fecha", fecha);
                    command.Parameters.AddWithValue("@Total", total);

                    facturaID = Convert.ToInt32(command.ExecuteScalar());
                }
            }

            return facturaID;
        }

        public void InsertarDetalleFactura(int facturaID, int productoID, int cantidad, decimal precio, decimal impuesto, decimal subtotal, decimal totalProducto, string nombreproducto)
        {
            using (SqlConnection connection = new SqlConnection(String_Conexion))
            {
                connection.Open();

                string query = "INSERT INTO DetallesFacturaCompra (FacturaID, ProductoID, Cantidad, Precio, Impuesto, Subtotal, TotalProducto, ProductoNombre) VALUES (@FacturaID, @ProductoID, @Cantidad, @Precio, @Impuesto, @Subtotal, @TotalProducto,@NombreProducto);";
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
        public void LeerDetalles(string codigo)
        {
            using (SqlConnection conexion = new SqlConnection(String_Conexion))
            {
                SqlCommand instruccionSQL = new SqlCommand("select*from DetallesFacturaCompra WHERE FacturaID=@FacturaID", conexion);
                instruccionSQL.Parameters.AddWithValue("@FacturaID", codigo);

                ds_detalles.Clear(); // Limpia el dataset antes de llenarlo.

                try
                {
                    conexion.Open();
                    using (SqlDataAdapter sqlDA = new SqlDataAdapter(instruccionSQL))
                    {
                        sqlDA.Fill(ds_detalles);
                    }
                }
                catch (SqlException ex)
                {
                    throw new SystemException("Error de SQL al cargar los datos: " + ex.Message);
                }
            }

        }
       









        public void LeerFactura(string codigo)
        {
            using (SqlConnection conexion = new SqlConnection(String_Conexion))
            {
                SqlCommand instruccionSQL = new SqlCommand("select*from FacturaCompra WHERE FacturaID=@FacturaID", conexion);
                instruccionSQL.Parameters.AddWithValue("@FacturaID", codigo);

                ds_resultados.Clear(); // Limpia el dataset antes de llenarlo.

                try
                {
                    conexion.Open();
                    using (SqlDataAdapter sqlDA = new SqlDataAdapter(instruccionSQL))
                    {
                        sqlDA.Fill(ds_resultados);
                    }
                }
                catch (SqlException ex)
                {
                    throw new SystemException("Error de SQL al cargar los datos: " + ex.Message);
                }
            } // La conexión se cerrará automáticamente al salir del bloque using.
        }

    }
}
