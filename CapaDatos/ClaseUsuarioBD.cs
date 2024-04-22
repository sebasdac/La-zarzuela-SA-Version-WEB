using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ClaseUsuarioBD
    {
        private String String_Conexion = "Data Source=LAPTOP-M50THNEO;Initial Catalog=\"Proyecto II\";Integrated Security=True;";
        //private String String_Conexion = "Data Source=SebasDAC_PC;Initial Catalog=\"Proyecto II\";Integrated Security=True;";

        DataSet ds_resultados = new DataSet();
        bool credencialesValidas = false;
        #region "Propiedades"
        public DataTable TablaProductos { get => ds_resultados.Tables[0]; }
        public int PIN1 { get => PIN; set => PIN = value; }
        public bool CredencialesValidas { get => credencialesValidas; set => credencialesValidas = value; }


        #endregion

        object pinobjeto = null;
        //objeto connection
        private SqlConnection conexion;
        int PIN;



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

        public void InsertaUsuarioBD(string usuario, string nombre, string estado, string cedula, string contrasena)
        {
            SqlCommand instruccionSQL;
            AbrirConexion();
            instruccionSQL = new SqlCommand("insert into Usuarios (Usuario, Nombre, Estado, Cedula, Contrasena)values(@Usuario,@Nombre,@Estado,@Cedula,@Contrasena)", conexion);
            instruccionSQL.Parameters.AddWithValue("@Usuario", usuario);
            instruccionSQL.Parameters.AddWithValue("@Nombre", nombre);
            instruccionSQL.Parameters.AddWithValue("@Estado", estado);

            instruccionSQL.Parameters.AddWithValue("@Cedula", cedula);
            instruccionSQL.Parameters.AddWithValue("@Contrasena", contrasena);
           

            instruccionSQL.ExecuteNonQuery();

            CerrarConexion();
        }//fin InsertaProducto

        public void LeerUsuario()
        {
            SqlDataAdapter sqlDA;

            SqlCommand instruccionSQL;

            AbrirConexion();

            instruccionSQL = new SqlCommand("select*from usuarios", conexion);
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

        public void ObtenerPIN()
        {
            SqlCommand instruccionSQL;
           

            AbrirConexion();

            instruccionSQL = new SqlCommand("SELECT TOP 1 Pin FROM Pin", conexion);

            try
            {
                pinobjeto = instruccionSQL.ExecuteScalar();
                PIN = Convert.ToInt32(pinobjeto.ToString());
            }
            catch (Exception ex)
            {
                throw new SystemException("Error obteniendo el dato único: " + ex.Message);
            }
            finally
            {
                CerrarConexion();
            }
            

            
        }

        public bool ValidarUsuario(string nombreUsuario, string contrasena)
        {
            
            AbrirConexion();
            // Consulta SQL para verificar las credenciales del usuario
            string consultaSQL = "SELECT COUNT(*) FROM usuarios WHERE Usuario = @Usuario AND contrasena = @Contrasena AND estado = 'Activo'";

            SqlCommand instruccionSQL = new SqlCommand(consultaSQL, conexion);
            instruccionSQL.Parameters.AddWithValue("@Usuario", nombreUsuario);
            instruccionSQL.Parameters.AddWithValue("@Contrasena", contrasena);

            
            try
            {
                int count = (int)instruccionSQL.ExecuteScalar();
                // Si el conteo es mayor que cero, significa que las credenciales son válidas
                CredencialesValidas = count > 0;
            }
            catch (Exception ex)
            {
                throw new SystemException("Error al verificar las credenciales del usuario: " + ex.Message);
            }
            finally
            {
                CerrarConexion();
            }

            return CredencialesValidas;
        }

      
        public void ActualizarUsuario(string cedula, string nombre, string usuario, string ccontrasena, string estado)
        {
            SqlCommand instruccionSQL;
            AbrirConexion();

            instruccionSQL = new SqlCommand("UPDATE Usuarios SET Cedula = @Cedula, Nombre = @Nombre, Usuario = @Usuario, Contrasena = @Contrasena, Estado = @Estado WHERE Usuario = @Usuario", conexion);
            instruccionSQL.Parameters.AddWithValue("@Cedula", cedula);
            instruccionSQL.Parameters.AddWithValue("@Nombre", nombre);
            instruccionSQL.Parameters.AddWithValue("@Usuario", usuario);
            instruccionSQL.Parameters.AddWithValue("@Contrasena", ccontrasena);
            instruccionSQL.Parameters.AddWithValue("@Estado", estado);
            

            instruccionSQL.ExecuteNonQuery();

            CerrarConexion();
        }
        public void EliminarUsuario(string usuario)
        {
            SqlCommand instruccionSQL;
            AbrirConexion();

            instruccionSQL = new SqlCommand("DELETE FROM Usuarios WHERE Usuario = @Usuario", conexion);
            instruccionSQL.Parameters.AddWithValue("@Usuario", usuario);

            instruccionSQL.ExecuteNonQuery();

            CerrarConexion();
        }







        #endregion

    }
}

