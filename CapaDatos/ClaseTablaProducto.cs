using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ClaseTablaProducto
    {
        //variables de trabajo
        DataTable tabla_productos = new DataTable("Productos");//Tabla vacia, se llama Productos

        public DataTable Tabla_productos { get => tabla_productos; set => tabla_productos = value; }

        #region "Metodos"

        private void EstructuraProductos() //Se ejecuta solo 1 vez , porque si no crea varias clases
        {



            //codigo
            DataColumn columna;

            columna = new DataColumn(); //pide memoria
            columna.DataType = System.Type.GetType("System.Int32"); //int porque el codigo es Int
            columna.ColumnName = "Codigo";//nombre e la columna
            columna.AllowDBNull = false; //no permite que este vacia

            tabla_productos.Columns.Add(columna); //agrega columna


            //Producto
            columna = new DataColumn(); //pide memoria
            columna.DataType = System.Type.GetType("System.String"); //String porque el nombre es String
            columna.ColumnName = "Nombre";//nombre e la columna
            columna.AllowDBNull = false; //no permite que este vacia

            tabla_productos.Columns.Add(columna); //agrega columna

            //Precio
            columna = new DataColumn(); //pide memoria
            columna.DataType = System.Type.GetType("System.Int32"); //int porque el codigo es Int
            columna.ColumnName = "Cantidad";//nombre e la columna
            columna.AllowDBNull = false; //no permite que este vacia

            tabla_productos.Columns.Add(columna); //agrega columna

            //Cantidad
            columna = new DataColumn(); //pide memoria
            columna.DataType = System.Type.GetType("System.Int32"); //int porque el codigo es Int
            columna.ColumnName = "Precio";//nombre e la columna
            columna.AllowDBNull = false; //no permite que este vacia

            tabla_productos.Columns.Add(columna); //agrega columna

            //Impuestos
            columna = new DataColumn(); //pide memoria
            columna.DataType = System.Type.GetType("System.Double");
            columna.ColumnName = "Impuesto";//nombre e la columna
            columna.AllowDBNull = false; //no permite que este vacia

            tabla_productos.Columns.Add(columna); //agrega columna

            //Total
            columna = new DataColumn(); //pide memoria
            columna.DataType = System.Type.GetType("System.Double");
            columna.ColumnName = "Total";//nombre e la columna
            columna.AllowDBNull = false; //no permite que este vacia

            tabla_productos.Columns.Add(columna); //agrega columna


        }//fin estructuraProductos

        public void AgregarProducto(int codigo, string nombre, int cantidad, int precio, double impuesto, double totalimpuesto)
        {

            DataRow fila;

            fila = tabla_productos.NewRow();

            fila["Codigo"] = codigo;  //parentesis cuadrados
            fila["Nombre"] = nombre;
            fila["Cantidad"] = cantidad;
            fila["Precio"] = precio;

            fila["Impuesto"] = impuesto;
            fila["Total"] = totalimpuesto;

            //agrega a la tabla

            tabla_productos.Rows.Add(fila);

        }//fin AgregarProducto


        //constructor
        //solo lo abre 1 vez
        public ClaseTablaProducto()
        {
            EstructuraProductos();
        }//fin constructor

        public void EscribeTabla_en_XML()
        {
            EscribirXMLProductos _ArchivoXMl = new EscribirXMLProductos();

            _ArchivoXMl.AbrirXML();

            _ArchivoXMl.CrearEncabezado();

            //ciclo que recorre la tabla

            foreach (DataRow fila in tabla_productos.Rows)
            {
                _ArchivoXMl.EscribeProducto(int.Parse(fila["Codigo"].ToString()), fila["Nombre"].ToString(),int.Parse(fila["Precio"].ToString()), int.Parse(fila["Cantidad"].ToString()), double.Parse(fila["Impuesto"].ToString()), double.Parse(fila["Total"].ToString()));

            }//fin foreach


            _ArchivoXMl.Cerrar();


        }//fin EscribeTabla

        public void LeeXML_a_TablaProductos()
        {
            ClaseLeeProductoXML _archivo = new ClaseLeeProductoXML();
             
            _archivo.Tabla = tabla_productos;

            _archivo.LeeProductos();

        }//fin LeeXML_a_TablaProductos


        #endregion
    }
}
