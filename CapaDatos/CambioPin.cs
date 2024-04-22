using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CambioPin
    {
        int pin;


        string String_Conexion = "Data Source=LAPTOP-M50THNEO;Initial Catalog=\"Proyecto II\";Integrated Security=True;";

        public int Pin { get => pin; set => pin = value; }

        //private String String_Conexion = "Data Source=SebasDAC_PC;Initial Catalog=\"Proyecto II\";Integrated Security=True;";
        public void ActualizarPIN(int pin)
        {
            using (SqlConnection connection = new SqlConnection(String_Conexion))
            {
                connection.Open();
                string query = "UPDATE Pin SET Pin = @pin";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@pin", pin);
                command.ExecuteNonQuery();

            }

        }

        public void VerificarPin(int piningreso)
        {
            using (SqlConnection connection = new SqlConnection(String_Conexion))
            {
              connection.Open();
                string query = "SELECT * FROM Pin WHERE Pin = @pin";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@pin", piningreso);
                pin = Convert.ToInt32(command.ExecuteScalar());

            }
            Console.WriteLine(pin);

        }

    }
}
