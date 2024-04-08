using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ClaseTablaProveedor
    {

        //variables de trabajo
        DataTable tabla_proveedores = new DataTable("Proveedores");//Tabla vacia, se llama Productos

        public DataTable Tabla_proveedor { get => tabla_proveedores; set => tabla_proveedores = value; }

        #region "Metodos"

        private void EstructuraProveedores() //Se ejecuta solo 1 vez , porque si no crea varias clases
        {



            //codigo
            DataColumn columna;

            columna = new DataColumn(); //pide memoria
            columna.DataType = System.Type.GetType("System.Int32"); //int porque el codigo es Int
            columna.ColumnName = "Codigo";//nombre e la columna
            columna.AllowDBNull = false; //no permite que este vacia

            tabla_proveedores.Columns.Add(columna); //agrega columna


            //Producto
            columna = new DataColumn(); //pide memoria
            columna.DataType = System.Type.GetType("System.String"); //String porque el nombre es String
            columna.ColumnName = "Nombre";//nombre e la columna
            columna.AllowDBNull = false; //no permite que este vacia

            tabla_proveedores.Columns.Add(columna); //agrega columna

            //Producto
            columna = new DataColumn(); //pide memoria
            columna.DataType = System.Type.GetType("System.String"); //String porque el nombre es String
            columna.ColumnName = "Cedula";//nombre e la columna
            columna.AllowDBNull = false; //no permite que este vacia

            tabla_proveedores.Columns.Add(columna); //agrega columna

            //Producto
            columna = new DataColumn(); //pide memoria
            columna.DataType = System.Type.GetType("System.String"); //String porque el nombre es String
            columna.ColumnName = "Provincia";//nombre e la columna
            columna.AllowDBNull = false; //no permite que este vacia

            tabla_proveedores.Columns.Add(columna); //agrega columna

            //Producto
            columna = new DataColumn(); //pide memoria
            columna.DataType = System.Type.GetType("System.String"); //String porque el nombre es String
            columna.ColumnName = "Telefono";//nombre e la columna
            columna.AllowDBNull = false; //no permite que este vacia

            tabla_proveedores.Columns.Add(columna); //agrega columna

            //Producto
            columna = new DataColumn(); //pide memoria
            columna.DataType = System.Type.GetType("System.String"); //String porque el nombre es String
            columna.ColumnName = "Correo";//nombre e la columna
            columna.AllowDBNull = false; //no permite que este vacia

            tabla_proveedores.Columns.Add(columna); //agrega columna

            //Producto
            columna = new DataColumn(); //pide memoria
            columna.DataType = System.Type.GetType("System.String"); //String porque el nombre es String
            columna.ColumnName = "Direccion";//nombre e la columna
            columna.AllowDBNull = false; //no permite que este vacia

            tabla_proveedores.Columns.Add(columna); //agrega columna



        }//fin estructuraProductos

        public void AgregarProveedor(int codigo, string nombre, string cedula, string provincia, string telefono, string correo, string direccion)
        {

            DataRow fila;

            fila = tabla_proveedores.NewRow();

            fila["Codigo"] = codigo;  //parentesis cuadrados
            fila["Nombre"] = nombre;
            fila["Cedula"] = cedula;
            fila["Provincia"] = provincia;
            fila["Telefono"] = telefono;
            fila["Correo"] = correo;
            fila["Direccion"] = direccion;
                


            //agrega a la tabla

            tabla_proveedores.Rows.Add(fila);

        }//fin AgregarProducto


        //constructor
        //solo lo abre 1 vez
        public ClaseTablaProveedor()
        {
            EstructuraProveedores();
        }//fin constructor

        public void EscribeTabla_en_XML()
        {
            EscribeXMLProveedor _ArchivoXMl = new EscribeXMLProveedor();

            _ArchivoXMl.AbrirXML();

            _ArchivoXMl.CrearEncabezado();

            //ciclo que recorre la tabla

            foreach (DataRow fila in tabla_proveedores.Rows)
            {
                _ArchivoXMl.EscribeProveedor(int.Parse(fila["Codigo"].ToString()), fila["Nombre"].ToString(), fila["Cedula"].ToString(), fila["Provincia"].ToString(), fila["Telefono"].ToString(), fila["Correo"].ToString(), fila["Direccion"].ToString());

            }//fin foreach


            _ArchivoXMl.Cerrar();


        }//fin EscribeTabla

        public void LeeXML_a_TablaProveedor()
        {
            ClaseLeeProveedorXML _archivo = new ClaseLeeProveedorXML();

            _archivo.Tabla = tabla_proveedores;

            _archivo.LeeProveedor();

        }//fin LeeXML_a_TablaProductos
    }
    #endregion
}
