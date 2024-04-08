using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class TablaFacturaCompra
    {

        //variables de trabajo
        DataTable tabla_facturacompra = new DataTable("FacturasCompra");//Tabla vacia, se llama Productos

        public DataTable Tabla_facturacompra { get => tabla_facturacompra; set => tabla_facturacompra = value; }



        #region "Metodos"

        private void EstructuraFacturas() //Se ejecuta solo 1 vez , porque si no crea varias clases
        {



            //codigo
            DataColumn columna;

            columna = new DataColumn(); //pide memoria
            columna.DataType = System.Type.GetType("System.Int32"); //int porque el codigo es Int
            columna.ColumnName = "CodigoProveedor";//nombre e la columna
            columna.AllowDBNull = false; //no permite que este vacia

            tabla_facturacompra.Columns.Add(columna); //agrega columna


            //Producto
            columna = new DataColumn(); //pide memoria
            columna.DataType = System.Type.GetType("System.String"); //String porque el nombre es String
            columna.ColumnName = "NombreProveedor";//nombre e la columna
            columna.AllowDBNull = false; //no permite que este vacia

            tabla_facturacompra.Columns.Add(columna); //agrega columna

            //Producto
            columna = new DataColumn(); //pide memoria
            columna.DataType = System.Type.GetType("System.String"); //String porque el nombre es String
            columna.ColumnName = "Fecha";//nombre e la columna
            columna.AllowDBNull = false; //no permite que este vacia

            tabla_facturacompra.Columns.Add(columna);

            //Producto
            columna = new DataColumn(); //pide memoria
            columna.DataType = System.Type.GetType("System.String"); //String porque el nombre es String
            columna.ColumnName = "NumeroFactura";//nombre e la columna
            columna.AllowDBNull = false; //no permite que este vacia

            tabla_facturacompra.Columns.Add(columna);


            columna = new DataColumn(); //pide memoria
            columna.DataType = System.Type.GetType("System.Int32"); //String porque el nombre es String
            columna.ColumnName = "CodigoProducto";//nombre e la columna
            columna.AllowDBNull = false; //no permite que este vacia

            tabla_facturacompra.Columns.Add(columna); //agrega columna

            columna = new DataColumn(); //pide memoria
            columna.DataType = System.Type.GetType("System.String"); //String porque el nombre es String
            columna.ColumnName = "NombreProducto";//nombre e la columna
            columna.AllowDBNull = false; //no permite que este vacia

            tabla_facturacompra.Columns.Add(columna); //agrega columna

            columna = new DataColumn(); //pide memoria
            columna.DataType = System.Type.GetType("System.String"); //String porque el nombre es String
            columna.ColumnName = "Cantidad";//nombre e la columna
            columna.AllowDBNull = false; //no permite que este vacia

            tabla_facturacompra.Columns.Add(columna); //agrega columna

            columna = new DataColumn(); //pide memoria
            columna.DataType = System.Type.GetType("System.Double"); //String porque el nombre es String
            columna.ColumnName = "Precio";//nombre e la columna
            columna.AllowDBNull = false; //no permite que este vacia

            tabla_facturacompra.Columns.Add(columna); //agrega columna

            columna = new DataColumn(); //pide memoria
            columna.DataType = System.Type.GetType("System.Double"); //String porque el nombre es String
            columna.ColumnName = "Total";//nombre e la columna
            columna.AllowDBNull = false; //no permite que este vacia

            tabla_facturacompra.Columns.Add(columna); //agrega columna




        }//fin estructuraProductos



        public void AgregarFactura(int CodigoProveedor,string NombreProveedor, string fecha, string numerofactura, int CodigoProducto, string NombreProducto, int cantidad, double precio, double total)
        {

            DataRow fila;

            fila = tabla_facturacompra.NewRow();

            fila["CodigoProveedor"] = CodigoProveedor;  //parentesis cuadrados
            fila["NombreProveedor"] = NombreProveedor;
            fila["Fecha"] = fecha;
            fila["NumeroFactura"] = numerofactura;
            fila["CodigoProducto"] = CodigoProducto;
            fila["NombreProducto"] = NombreProducto;
            fila["Cantidad"] = cantidad;
            fila["Precio"] = precio;
            fila["Total"] = total;



            //agrega a la tabla

            tabla_facturacompra.Rows.Add(fila);

        }//fin agregarUsuario

        public TablaFacturaCompra()
        {
            EstructuraFacturas();
        }

        public void EscribeTabla_en_XML()
        {
            EscribeFacturaCompraXML _ArchivoXMl = new EscribeFacturaCompraXML();

            _ArchivoXMl.AbrirXML();
            _ArchivoXMl.CrearEncabezado();

            //ciclo que recorre la tabla

            foreach (DataRow fila in tabla_facturacompra.Rows)
            {
                _ArchivoXMl.EscribeFacturaXMLTabla(int.Parse(fila["CodigoProveedor"].ToString()), fila["NombreProveedor"].ToString(), fila["Fecha"].ToString(), fila["NumeroFactura"].ToString(), int.Parse(fila["CodigoProducto"].ToString()), fila["NombreProducto"].ToString(), int.Parse(fila["Cantidad"].ToString()), double.Parse(fila["Precio"].ToString()), double.Parse(fila["Total"].ToString())); //

            }//fin foreach


            _ArchivoXMl.Cerrar();


        }//fin EscribeTabla

        public void LeeXML_a_TablaFactura()
        {
            LeeFacturaCompra _archivo = new LeeFacturaCompra();

            _archivo.Tabla = tabla_facturacompra;

            _archivo.LeeFactura();

        }//fin LeeXML_a_TablaUsuario

        #endregion
    }
}
