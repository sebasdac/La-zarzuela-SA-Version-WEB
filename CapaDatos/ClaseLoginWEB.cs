using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ClaseLoginWEB
    {
        bool Esproveedor;
        bool Esusuario;

        public bool Esproveedor1 { get => Esproveedor; set => Esproveedor = value; }
        public bool Esusuario1 { get => Esusuario; set => Esusuario = value; }

        public void AutenticarUsuario(string usuario, string contrasena)
        { 
            string username = usuario;
            string password = contrasena;

            // Realizar la autenticación en la tabla de Usuarios
            string userConnectionString = "Data Source=SebasDAC_PC;Initial Catalog=\"Proyecto II\";Integrated Security=True;";
            string userQuery = "SELECT * FROM Usuarios WHERE Usuario = @Username AND Contrasena = @Password";

            // Realizar la autenticación en la tabla de Proveedores
            string providerConnectionString = "Data Source=SebasDAC_PC;Initial Catalog=\"Proyecto II\";Integrated Security=True;";
            string providerQuery = "SELECT * FROM Proveedores WHERE Correo = @Username AND Codigo = @Password";

            using (SqlConnection userConnection = new SqlConnection(userConnectionString))
            {
                SqlCommand userCommand = new SqlCommand(userQuery, userConnection);
                userCommand.Parameters.AddWithValue("@Username", username);
                userCommand.Parameters.AddWithValue("@Password", password);

                userConnection.Open();
                SqlDataReader userReader = userCommand.ExecuteReader();

                if (userReader.Read())
                {
                    // Usuario encontrado en la tabla de Usuarios
                    Esusuario1 = true;
                    return; // Terminar la función para evitar procesar la consulta de Proveedores
                }
            }

            using (SqlConnection providerConnection = new SqlConnection(providerConnectionString))
            {
                SqlCommand providerCommand = new SqlCommand(providerQuery, providerConnection);
                providerCommand.Parameters.AddWithValue("@Username", username);
                providerCommand.Parameters.AddWithValue("@Password", password);

                providerConnection.Open();
                SqlDataReader providerReader = providerCommand.ExecuteReader();

                if (providerReader.Read())
                {
                    // Usuario encontrado en la tabla de Proveedores
                    Esproveedor1 = true;
                    return; // Terminar la función
                }
            }

            // Usuario no encontrado en ninguna tabla o contraseña incorrecta
            throw new Exception("Usuario no encontrado o contraseña incorrecta");
        }








    }
}
