using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ClaseClienteBD
    {
        DataSet ds_resultados = new DataSet();
        private String String_Conexion = "Data Source=LAPTOP-M50THNEO;Initial Catalog=\"Proyecto II\";Integrated Security=True;";
        //private String String_Conexion = "Data Source=SebasDAC_PC;Initial Catalog=\"Proyecto II\";Integrated Security=True;";

        #region "Propiedades"
        public DataTable TablaClientes { get => ds_resultados.Tables[0]; }

        #endregion


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

        public void InsertaClienteBD(int codigo, string nombre, string tipo, string cedula, string direccion, string provincia, string telefono, string correo)
        {
            SqlCommand instruccionSQL;
            AbrirConexion();
            instruccionSQL = new SqlCommand("insert into Clientes (Codigo, Nombre, Tipo, Cedula, Direccion, Provincia, Telefono, Correo)values(@Codigo,@Nombre,@Tipo,@Cedula,@Direccion,@Provincia, @Telefono, @Correo)", conexion);
            instruccionSQL.Parameters.AddWithValue("@Codigo", codigo);
            instruccionSQL.Parameters.AddWithValue("@Nombre", nombre);
            instruccionSQL.Parameters.AddWithValue("@Tipo", tipo);

            instruccionSQL.Parameters.AddWithValue("@Cedula", cedula);
            instruccionSQL.Parameters.AddWithValue("@Direccion", direccion);
            instruccionSQL.Parameters.AddWithValue("@Provincia", provincia);
            instruccionSQL.Parameters.AddWithValue("@Telefono", telefono);
            instruccionSQL.Parameters.AddWithValue("@Correo", correo);
            

            instruccionSQL.ExecuteNonQuery();

            CerrarConexion();
        }//fin InsertaProducto

        public void LeerCliente()
        {
            SqlDataAdapter sqlDA;

            SqlCommand instruccionSQL;

            AbrirConexion();

            instruccionSQL = new SqlCommand("select*from clientes", conexion);
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




        #endregion

    }


}

