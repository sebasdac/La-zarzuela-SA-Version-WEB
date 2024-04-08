using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class TablaFacturaVenta
    {
        DataTable tabla_facturaventa = new DataTable("FacturaVenta");

        public DataTable Tabla_facturaventa { get => tabla_facturaventa; set => tabla_facturaventa = value; }





        #region "Metodos"

        public void EstructuraFacturaCompra()
        {
            DataColumn columna;

            columna = new DataColumn(); //pide memoria
            columna.DataType = System.Type.GetType("System.Int32"); //int porque el codigo es Int
            columna.ColumnName = "Codigo cliente";//nombre e la columna
            columna.AllowDBNull = false; //no permite que este vacia

            tabla_facturaventa.Columns.Add(columna); //agrega columna

            columna = new DataColumn(); //pide memoria
            columna.DataType = System.Type.GetType("System.String");
            columna.ColumnName = "Nombre cliente";//nombre e la columna
            columna.AllowDBNull = false; //no permite que este vacia

            tabla_facturaventa.Columns.Add(columna); //agrega columna

            columna = new DataColumn(); //pide memoria
            columna.DataType = System.Type.GetType("System.String");
            columna.ColumnName = "Cedula";//nombre e la columna
            columna.AllowDBNull = false; //no permite que este vacia

            tabla_facturaventa.Columns.Add(columna); //agrega columna

            columna = new DataColumn(); //pide memoria
            columna.DataType = System.Type.GetType("System.String");
            columna.ColumnName = "Tipo";//nombre e la columna
            columna.AllowDBNull = false; //no permite que este vacia

            tabla_facturaventa.Columns.Add(columna); //agrega columna

            columna = new DataColumn(); //pide memoria
            columna.DataType = System.Type.GetType("System.String");
            columna.ColumnName = "Provincia";//nombre e la columna
            columna.AllowDBNull = false; //no permite que este vacia

            tabla_facturaventa.Columns.Add(columna); //agrega columna

            columna = new DataColumn(); //pide memoria
            columna.DataType = System.Type.GetType("System.String");
            columna.ColumnName = "Correo";//nombre e la columna
            columna.AllowDBNull = false; //no permite que este vacia

            tabla_facturaventa.Columns.Add(columna); //agrega columna

            columna = new DataColumn(); //pide memoria
            columna.DataType = System.Type.GetType("System.String");
            columna.ColumnName = "Telefono";//nombre e la columna
            columna.AllowDBNull = false; //no permite que este vacia

            tabla_facturaventa.Columns.Add(columna); //agrega columna

            columna = new DataColumn(); //pide memoria
            columna.DataType = System.Type.GetType("System.String");
            columna.ColumnName = "Direccion";//nombre e la columna
            columna.AllowDBNull = false; //no permite que este vacia

            tabla_facturaventa.Columns.Add(columna); //agrega columna

            columna = new DataColumn(); //pide memoria
            columna.DataType = System.Type.GetType("System.Int32"); //int porque el codigo es Int
            columna.ColumnName = "Codigo producto";//nombre e la columna
            columna.AllowDBNull = false; //no permite que este vacia

            tabla_facturaventa.Columns.Add(columna); //agrega columna


            //Producto
            columna = new DataColumn(); //pide memoria
            columna.DataType = System.Type.GetType("System.String"); //String porque el nombre es String
            columna.ColumnName = "Nombre producto";//nombre e la columna
            columna.AllowDBNull = false; //no permite que este vacia

            tabla_facturaventa.Columns.Add(columna); //agrega columna

            //Precio
            columna = new DataColumn(); //pide memoria
            columna.DataType = System.Type.GetType("System.Int32"); //int porque el codigo es Int
            columna.ColumnName = "Cantidad";//nombre e la columna
            columna.AllowDBNull = false; //no permite que este vacia

            tabla_facturaventa.Columns.Add(columna); //agrega columna

            //Cantidad
            columna = new DataColumn(); //pide memoria
            columna.DataType = System.Type.GetType("System.Int32"); //int porque el codigo es Int
            columna.ColumnName = "Precio";//nombre e la columna
            columna.AllowDBNull = false; //no permite que este vacia

            tabla_facturaventa.Columns.Add(columna); //agrega columna

            //Impuestos
            columna = new DataColumn(); //pide memoria
            columna.DataType = System.Type.GetType("System.Double");
            columna.ColumnName = "Impuesto";//nombre e la columna
            columna.AllowDBNull = false; //no permite que este vacia

            tabla_facturaventa.Columns.Add(columna); //agrega columna

            //Total
            columna = new DataColumn(); //pide memoria
            columna.DataType = System.Type.GetType("System.Double");
            columna.ColumnName = "Total";//nombre e la columna
            columna.AllowDBNull = false; //no permite que este vacia

            tabla_facturaventa.Columns.Add(columna); //agrega columna

        }//fin estructura

        public void AgregarFacturaVenta(int codigocliente, string nombrecliente, string cedula, string tipo, string provincia, string correo, string telefono, string direccion, int codigoproducto, string nombreproducto, int cantidad, int precio, double impuesto, double totalimpuesto)
        {

            DataRow fila;

            fila = tabla_facturaventa.NewRow();


            fila["Codigo cliente"] = codigocliente;  //parentesis cuadrados
            fila["Nombre cliente"] = nombreproducto;
            fila["Cedula"] = cedula;
            fila["Tipo"] = tipo;

            fila["Provincia"] = provincia;
            fila["Correo"] = correo;
            fila["Telefono"] = telefono;
            fila["Direccion"] = direccion;


            fila["Codigo producto"] = codigoproducto;  
            fila["Nombre producto"] = nombreproducto;
            fila["Cantidad"] = cantidad;
            fila["Precio"] = precio;

            fila["Impuesto"] = impuesto;
            fila["Total"] = totalimpuesto;

            //agrega a la tabla

            tabla_facturaventa.Rows.Add(fila);

        }//fin agregar

        public TablaFacturaVenta()
        {
            EstructuraFacturaCompra();
        }

        public void Facturas_en_XML()
        {
            EscribeFacturaVentaXML _Archivo = new EscribeFacturaVentaXML();

            _Archivo.AbrirXML();

            _Archivo.CrearEncabezado();

            foreach (DataRow fila in tabla_facturaventa.Rows)
            {
                _Archivo.EscribeFactura(int.Parse(fila["CodigoCliente"].ToString()), fila["NombreCliente"].ToString(), fila["Cedula"].ToString(), fila["Tipo"].ToString(), fila["Provincia"].ToString(), fila["Correo"].ToString(), fila["Telefono"].ToString(), fila["Direccion"].ToString(), int.Parse(fila["CodigoProducto"].ToString()), fila["NombreProducto"].ToString(), int.Parse(fila["Precio"].ToString()), int.Parse(fila["Cantidad"].ToString()), double.Parse(fila["Impuesto"].ToString()), double.Parse(fila["Total"].ToString()));
            }//fin foreach

            _Archivo.Cerrar();
        }//fin clientes en XML

        public void LeeXMLaTablaFactura()
        {
            LeeFacturaVenta _archivo = new LeeFacturaVenta();

            _archivo.Tabla = tabla_facturaventa;

            _archivo.LeerFacturaVenta();

        }//fin lee XML a tabla clientes


        #endregion

    }
}
