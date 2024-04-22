using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ClaseProveedorBD
    {
        DataSet ds_resultados = new DataSet();
        private String String_Conexion = "Data Source=LAPTOP-M50THNEO;Initial Catalog=\"Proyecto II\";Integrated Security=True;";
        //private String String_Conexion = "Data Source=SebasDAC_PC;Initial Catalog=\"Proyecto II\";Integrated Security=True;";

        #region "Propiedades"
        public DataTable TablaProveedor { get => ds_resultados.Tables[0]; }
        public string Cedula { get => cedula; set => cedula = value; }
        public string Tipo { get => tipo; set => tipo = value; }

        #endregion

        string cedula;
        string tipo;
        //objeto connection
        private SqlConnection conexion;



        #region "Metodos"
        private void AbrirConexion()
        {
            try
            {
                conexion = new SqlConnection(String_Conexion);
                conexion.Open();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error al abrir conexion: " + ex.Message);
            }



        }//fin abrir conexion

        private void CerrarConexion()
        {
            conexion.Close();
        }//fin cerrar conexion

        public void InsertaProveedorBD(int codigo, string proveedor, string tipo, string cedula, string direccion, string provincia, string telefono, string correo, string contrasena)
        {
            SqlCommand instruccionSQL;
            AbrirConexion();
            instruccionSQL = new SqlCommand("insert into Proveedores (Codigo, Proveedor, Tipo, Cedula, Direccion, Provincia, Telefono, Correo, Contrasena)values(@Codigo,@Proveedor,@Tipo,@Cedula,@Direccion,@Provincia, @Telefono, @Correo, @Contrasena)", conexion);
            instruccionSQL.Parameters.AddWithValue("@Codigo", codigo);
            instruccionSQL.Parameters.AddWithValue("@Proveedor", proveedor);
            instruccionSQL.Parameters.AddWithValue("@Tipo", tipo);

            instruccionSQL.Parameters.AddWithValue("@Cedula", cedula);
            instruccionSQL.Parameters.AddWithValue("@Direccion", direccion);
            instruccionSQL.Parameters.AddWithValue("@Provincia", provincia);
            instruccionSQL.Parameters.AddWithValue("@Telefono", telefono);
            instruccionSQL.Parameters.AddWithValue("@Correo", correo);
            instruccionSQL.Parameters.AddWithValue("@Contrasena", contrasena);

            instruccionSQL.ExecuteNonQuery();

            CerrarConexion();
        }//fin InsertaProducto

        public void LeerProveedor()
        {
            SqlDataAdapter sqlDA;

            SqlCommand instruccionSQL;

            AbrirConexion();

            instruccionSQL = new SqlCommand("select*from proveedores", conexion);
            ds_resultados.Clear();//limpia el dataset
            try
            {
                sqlDA = new SqlDataAdapter(instruccionSQL);
                sqlDA.Fill(ds_resultados);
            }
            catch (Exception ex)
            {
                throw new SystemException("Error cargando los datos: " + ex.Message);
            }
            CerrarConexion();
        }

        public void ActualizarProveedor(int codigo, string proveedor, string tipo, string cedula, string direccion, string provincia, string telefono, string correo, string contrasena)
        {
            SqlCommand instruccionSQL;
            AbrirConexion();

            instruccionSQL = new SqlCommand("UPDATE Proveedores SET Proveedor = @Proveedor, Tipo = @Tipo, Cedula = @Cedula, Direccion = @Direccion, Provincia = @Provincia, Telefono = @Telefono, Correo = @Correo, Contrasena = @Contrasena WHERE Codigo = @Codigo", conexion);

            instruccionSQL.Parameters.AddWithValue("@Codigo", codigo);
            instruccionSQL.Parameters.AddWithValue("@Proveedor", proveedor);
            instruccionSQL.Parameters.AddWithValue("@Tipo", tipo);
            instruccionSQL.Parameters.AddWithValue("@Cedula", cedula);
            instruccionSQL.Parameters.AddWithValue("@Direccion", direccion);
            instruccionSQL.Parameters.AddWithValue("@Provincia", provincia);
            instruccionSQL.Parameters.AddWithValue("@Telefono", telefono);
            instruccionSQL.Parameters.AddWithValue("@Correo", correo);
            instruccionSQL.Parameters.AddWithValue("@Contrasena", contrasena);


            instruccionSQL.ExecuteNonQuery();

            CerrarConexion();
        }
        public void EliminarProveedor(int codigo)
        {

            SqlCommand instruccionSQL;
            AbrirConexion();
            instruccionSQL = new SqlCommand("Delete from Proveedores WHERE Codigo = @codigo", conexion);
            instruccionSQL.Parameters.AddWithValue("@Codigo", codigo);

            instruccionSQL.ExecuteNonQuery();
            CerrarConexion();

        }

        public void LeerProveedorWEB(int codigo)
        {
            // Conexión a la base de datos
            using (SqlConnection connection = new SqlConnection(String_Conexion))
            {
                connection.Open();
                // Consulta SQL para obtener el precio y la cantidad del producto
                string query = "SELECT Cedula, Tipo FROM Proveedores WHERE Codigo = @Codigo";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Codigo", codigo);

                // Usar un DataReader para leer los resultados de la consulta
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    // Verificar si hay filas devueltas por la consulta
                    if (reader.Read())
                    {
                        // Asignar los valores de las columnas a las variables cantidad y precio
                        cedula = reader["Cedula"].ToString();
                        tipo = reader["Tipo"].ToString();


                   
                    }
                    else
                    {
                        // Manejar el caso en el que no se encuentre ningún producto con el código dado
                        Console.WriteLine("No se encontró ningún producto con el código proporcionado.");
                    }
                }
            }
        }

        public void LeerDetallesPorCorreo(string correo)
        {
            SqlDataAdapter sqlDA;
            SqlCommand instruccionSQL;

            AbrirConexion();

            instruccionSQL = new SqlCommand("SELECT * FROM Proveedores WHERE Correo = @Correo", conexion);
            instruccionSQL.Parameters.AddWithValue("@Correo", correo);

            ds_resultados.Clear(); // limpia el dataset

            try
            {
                sqlDA = new SqlDataAdapter(instruccionSQL);
                sqlDA.Fill(ds_resultados);
            }
            catch (Exception ex)
            {
                throw new SystemException("Error cargando los datos: " + ex.Message);
            }

            CerrarConexion();
        }


    }
    #endregion
}
