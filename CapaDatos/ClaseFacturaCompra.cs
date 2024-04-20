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
        public int FacturaID { get => facturaID; set => facturaID = value; }

        int facturaID;

        public void InsertarFactura(int ProveedorID, string nombre, string cedula, string tipo, string fecha)
        {


            using (SqlConnection connection = new SqlConnection(String_Conexion))
            {
                connection.Open();

                string query = "INSERT INTO FacturaCompra (ProveedorID, NombreProveedor, CedulaProveedor, Tipo, Fecha) VALUES " +
                    "(@ProveedorID, @Nombre, @Cedula,@Tipo, @Fecha); SELECT SCOPE_IDENTITY();";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProveedorID", ProveedorID);
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Cedula", cedula);
                    command.Parameters.AddWithValue("@Tipo", tipo);
                    command.Parameters.AddWithValue("@Fecha", fecha);


                    FacturaID = Convert.ToInt32(command.ExecuteScalar());
                }
            }


        }

        public void InsertarDetalleFactura(int productoID, string nombreproducto, int cantidad, double precio, double subtotal, double impuesto, double totalProducto)
        {
            using (SqlConnection connection = new SqlConnection(String_Conexion))
            {
                connection.Open();

                string query = "INSERT INTO DetallesFacturaCompra (FacturaID, ProductoID, ProductoNombre, Cantidad, Precio, Subtotal, Impuesto, TotalProducto) VALUES" +
                    " (@FacturaID, @ProductoID,@NombreProducto, @Cantidad, @Precio, @Subtotal, @Impuesto, @TotalProducto);";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FacturaID", FacturaID);
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
        public void LeerDetallesWEB(int codigo)
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

        public void LeerDetallesalDataGridView()
        {
            using (SqlConnection conexion = new SqlConnection(String_Conexion))
            {
                SqlCommand instruccionSQL = new SqlCommand("select*from DetallesFacturaCompra WHERE FacturaID=@FacturaID", conexion);
                instruccionSQL.Parameters.AddWithValue("@FacturaID", FacturaID);

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

        public void EliminarProducto(int productoID)
        {
            using (SqlConnection connection = new SqlConnection(String_Conexion))
            {
                connection.Open();

                string query = "DELETE FROM DetallesFacturaCompra WHERE ProductoID = @ProductoID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProductoID", productoID);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void EliminarFactura()
        {
            using (SqlConnection connection = new SqlConnection(String_Conexion))
            {
                connection.Open();

                string query = "DELETE FROM FacturaCompra WHERE FacturaID = @FacturaID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FacturaID", FacturaID);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void EliminarFacturaWEB(int codigo)
        {
            using (SqlConnection connection = new SqlConnection(String_Conexion))
            {
                connection.Open();

                string query = "DELETE FROM FacturaCompra WHERE FacturaID = @FacturaID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FacturaID", codigo);
                    command.ExecuteNonQuery();
                }
            }
        }
         public void InsertarDetalleFacturaWEB(int facturaid,int productoID, string nombreproducto, int cantidad, double precio, double subtotal, double impuesto, double totalProducto)
        {
            using (SqlConnection connection = new SqlConnection(String_Conexion))
            {
                connection.Open();

                string query = "INSERT INTO DetallesFacturaCompra (FacturaID, ProductoID, ProductoNombre, Cantidad, Precio, Subtotal, Impuesto, TotalProducto) VALUES" +
                    " (@FacturaID, @ProductoID,@NombreProducto, @Cantidad, @Precio, @Subtotal, @Impuesto, @TotalProducto);";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FacturaID", facturaid);
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
