using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ClaseTablaUsuario
    {
        //variables de trabajo
        DataTable tabla_usuarios = new DataTable("Usuarios");//Tabla vacia, se llama Productos

        public DataTable Tabla_Usuarios { get => tabla_usuarios; set => tabla_usuarios = value; }

        #region "Metodos"

        private void EstructuraUsuarios() //Se ejecuta solo 1 vez , porque si no crea varias clases
        {



            //codigo
            DataColumn columna;

            columna = new DataColumn(); //pide memoria
            columna.DataType = System.Type.GetType("System.String"); //int porque el codigo es Int
            columna.ColumnName = "NombreUsuario";//nombre e la columna
            columna.AllowDBNull = false; //no permite que este vacia

            tabla_usuarios.Columns.Add(columna); //agrega columna


            //Producto
            columna = new DataColumn(); //pide memoria
            columna.DataType = System.Type.GetType("System.String"); //String porque el nombre es String
            columna.ColumnName = "Contrasena";//nombre e la columna
            columna.AllowDBNull = false; //no permite que este vacia

            tabla_usuarios.Columns.Add(columna); //agrega columna

            //Producto
            columna = new DataColumn(); //pide memoria
            columna.DataType = System.Type.GetType("System.String"); //String porque el nombre es String
            columna.ColumnName = "Estado";//nombre e la columna
            columna.AllowDBNull = false; //no permite que este vacia

            tabla_usuarios.Columns.Add(columna);

            //Producto
            columna = new DataColumn(); //pide memoria
            columna.DataType = System.Type.GetType("System.String"); //String porque el nombre es String
            columna.ColumnName = "Cedula";//nombre e la columna
            columna.AllowDBNull = false; //no permite que este vacia

            tabla_usuarios.Columns.Add(columna);


            columna = new DataColumn(); //pide memoria
            columna.DataType = System.Type.GetType("System.String"); //String porque el nombre es String
            columna.ColumnName = "Nombre";//nombre e la columna
            columna.AllowDBNull = false; //no permite que este vacia

            tabla_usuarios.Columns.Add(columna); //agrega columna




        }//fin estructuraProductos

        public void AgregarUsuario(string usuario, string contrasena, string estado, string cedula, string nombre)
        {

            DataRow fila;

            fila = tabla_usuarios.NewRow();

            fila["NombreUsuario"] = usuario;  //parentesis cuadrados
            fila["Contrasena"] = contrasena;
            fila["Estado"] = estado;
            fila["Cedula"] = cedula;
            fila["Nombre"] = nombre;


            //agrega a la tabla

            tabla_usuarios.Rows.Add(fila);

        }//fin agregarUsuario


        //constructor
        //solo lo abre 1 vez
        public ClaseTablaUsuario()
        {
            EstructuraUsuarios();
        }//fin constructor

        public void EscribeTabla_en_XML()
        {
            EscribeXMLUsuario _ArchivoXMl = new EscribeXMLUsuario();

            _ArchivoXMl.AbrirXML();
            _ArchivoXMl.CrearEncabezado();

            //ciclo que recorre la tabla

            foreach (DataRow fila in tabla_usuarios.Rows)
            {
                _ArchivoXMl.EscribeProductoXMLTabla(fila["NombreUsuario"].ToString(), fila["Contrasena"].ToString(), fila["Estado"].ToString(), fila["Cedula"].ToString(), fila["Nombre"].ToString()); //

            }//fin foreach


            _ArchivoXMl.Cerrar();


        }//fin EscribeTabla

        public void LeeXML_a_TablaUsuario()
        {
            ClaseLeeUsuarioXML _archivo = new ClaseLeeUsuarioXML();

            _archivo.Tabla = tabla_usuarios;

            _archivo.LeeUsuario();

        }//fin LeeXML_a_TablaUsuario
    }
    #endregion
}
