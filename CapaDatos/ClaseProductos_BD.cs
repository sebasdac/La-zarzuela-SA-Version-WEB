using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ClaseProductos_BD
    {
        //formar string de conexion



        private String String_Conexion = "Data Source=LAPTOP-M50THNEO;Initial Catalog=\"Proyecto II\";Integrated Security=True;";
        //private String String_Conexion = "Data Source= tiusr19pl.cuc-carrera-ti.ac.cr\\MSSQLSERVER2019;" +
        //                          "User ID=EstudiantesIIC2023; Password=Estudi@ntes2023;" +  // seguridad
        //                           "Initial Catalog=tiusr19pl_Progra2;"; // bd
        //dataset


        //string conexion base datos de la computadora
        //private String String_Conexion = "Data Source=SebasDAC_PC;Initial Catalog=\"Proyecto II\";Integrated Security=True;Encrypt=True;";


        DataSet ds_resultados = new DataSet();

        #region "Propiedades"
        public DataTable TablaProductos { get => ds_resultados.Tables[0]; }

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

        public void InsertaProductoBD(int codigo, string nombre, int precio, int cantidad, double impuesto, double total)
        {
            SqlCommand instruccionSQL;
            AbrirConexion();
            instruccionSQL = new SqlCommand("insert into Productos (Codigo, Nombre, Precio, Cantidad, Impuesto, Total)values(@Codigo,@Nombre,@Precio,@Cantidad,@Impuesto,@Total)", conexion);
            instruccionSQL.Parameters.AddWithValue("@Codigo", codigo);
            instruccionSQL.Parameters.AddWithValue("@Nombre", nombre);
            instruccionSQL.Parameters.AddWithValue("@Precio", precio);

            instruccionSQL.Parameters.AddWithValue("@Cantidad", cantidad);
            instruccionSQL.Parameters.AddWithValue("@Impuesto", impuesto);
            instruccionSQL.Parameters.AddWithValue("@Total", total);

            instruccionSQL.ExecuteNonQuery();

            CerrarConexion();
        }//fin InsertaProducto

       public void LeerProducto()
        {
            SqlDataAdapter sqlDA;

            SqlCommand instruccionSQL;

            AbrirConexion();

            instruccionSQL = new SqlCommand("select*from productos" , conexion);
            ds_resultados.Clear();//limpia el dataset
            try
            {
                sqlDA = new SqlDataAdapter(instruccionSQL);
                sqlDA.Fill(ds_resultados);
            }
            catch (Exception ex) 
            {
                throw new SystemException("Error cargando los datos: "+ ex.Message);
            }
            CerrarConexion();
        }




        #endregion

    }


}

