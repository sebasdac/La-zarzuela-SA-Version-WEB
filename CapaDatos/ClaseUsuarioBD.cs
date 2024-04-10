﻿using System;
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

        #region "Propiedades"
        public DataTable TablaProductos { get => ds_resultados.Tables[0]; }
        public object PIN1 { get => PIN; set => PIN = value; }

        #endregion


        //objeto connection
        private SqlConnection conexion;
        object PIN = null;



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

            instruccionSQL = new SqlCommand("select*from productos", conexion);
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

            instruccionSQL = new SqlCommand("SELECT TOP 1 Nombre FROM productos", conexion);

            try
            {
                PIN1 = instruccionSQL.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new SystemException("Error obteniendo el dato único: " + ex.Message);
            }
            finally
            {
                CerrarConexion();
            }

            return valorUnico;
        }





        #endregion

    }
}

