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

        private String String_Conexion = "Data Source=SebasDAC_PC;Initial Catalog=\"Proyecto II\";Integrated Security=True;";

        //string String_Conexion = "Data Source=LAPTOP-M50THNEO;Initial Catalog=\"Proyecto II\";Integrated Security=True;";

        public void AutenticarUsuario(string usuario, string contrasena)
        { 
            string username = usuario;
            string password = contrasena;

            // Realizar la autenticación en la tabla de Usuarios
            
               


            string userQuery = "SELECT * FROM Usuarios WHERE Usuario = @Username AND Contrasena = @Password";

            // Realizar la autenticación en la tabla de Proveedores
            //string providerConnectionString = "Data Source=SebasDAC_PC;Initial Catalog=\"Proyecto II\";Integrated Security=True;";
           
            string providerQuery = "SELECT * FROM Proveedores WHERE Correo = @Username AND Contrasena = @Password";

            using (SqlConnection userConnection = new SqlConnection(String_Conexion))
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

            using (SqlConnection providerConnection = new SqlConnection(String_Conexion))
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

        public void CambioContrasenaa(string usuario, string contrasena)
        {
            string username = usuario;
            string password = contrasena;

            // Realizar la autenticación en la tabla de Usuarios




            string userQuery = "SELECT * FROM Usuarios WHERE Usuario = @Username";

            // Realizar la autenticación en la tabla de Proveedores
            //string providerConnectionString = "Data Source=SebasDAC_PC;Initial Catalog=\"Proyecto II\";Integrated Security=True;";

            string providerQuery = "SELECT * FROM Proveedores WHERE Correo = @Username";

            using (SqlConnection userConnection = new SqlConnection(String_Conexion))
            {
                SqlCommand userCommand = new SqlCommand(userQuery, userConnection);
                userCommand.Parameters.AddWithValue("@Username", username);
                userCommand.Parameters.AddWithValue("@Password", password);

                userConnection.Open();
                SqlDataReader userReader = userCommand.ExecuteReader();

                if (userReader.Read())
                {
                    // Close the reader before updating the password
                    userReader.Close();

                    // Update the password in the Usuarios table
                    string updateQuery = "UPDATE Usuarios SET Contrasena = @NewPassword WHERE Usuario = @Username";
                    SqlCommand updateCommand = new SqlCommand(updateQuery, userConnection);
                    updateCommand.Parameters.AddWithValue("@NewPassword", password); // Assuming you have a variable `newPassword` with the new password
                    updateCommand.Parameters.AddWithValue("@Username", username);
                    updateCommand.ExecuteNonQuery();

                    // Set the flag to indicate the user exists
                    Esusuario1 = true;

                    // Return or perform any necessary actions
                    
                    return; // Terminar la función para evitar procesar la consulta de Proveedores
                }
            }

            using (SqlConnection providerConnection = new SqlConnection(String_Conexion))
            {
                SqlCommand providerCommand = new SqlCommand(providerQuery, providerConnection);
                providerCommand.Parameters.AddWithValue("@Username", username);
                providerCommand.Parameters.AddWithValue("@Password", password);

                providerConnection.Open();
                SqlDataReader providerReader = providerCommand.ExecuteReader();

                if (providerReader.Read())
                {
                    providerReader.Close();

                    // Update the password in the Proveedores table
                    string updateQuery = "UPDATE Proveedores SET Contrasena = @NewPassword WHERE Correo = @Username";
                    SqlCommand updateCommand = new SqlCommand(updateQuery, providerConnection);
                    updateCommand.Parameters.AddWithValue("@NewPassword", password); // Assuming you have a variable `newPassword` with the new password
                    updateCommand.Parameters.AddWithValue("@Username", username);
                    updateCommand.ExecuteNonQuery();

                    // Set the flag to indicate the user is a provider
                    Esproveedor1 = true;

                    // Return or perform any necessary actions
                    return;
                }
            }

            // Usuario no encontrado en ninguna tabla o contraseña incorrecta
            throw new Exception("Usuario no encontrado o contraseña incorrecta");
        }






    }
}
