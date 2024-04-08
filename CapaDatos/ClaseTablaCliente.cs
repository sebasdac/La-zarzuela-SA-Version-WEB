using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CapaDatos
{
    public class ClaseTablaCliente
    {
        //Variables de trabajo

        DataTable tabla_clientes = new DataTable("Clientes");

        public DataTable Tabla_clientes { get => tabla_clientes; set => tabla_clientes = value; }

        #region "Metodos"

        public void EstructuraClientes()
        {
            DataColumn columna;

            columna = new DataColumn(); //pide memoria
            columna.DataType = System.Type.GetType("System.Int32"); //int porque el codigo es Int
            columna.ColumnName = "Codigo";//nombre e la columna
            columna.AllowDBNull = false; //no permite que este vacia

            Tabla_clientes.Columns.Add(columna); //agrega columna

            columna = new DataColumn(); //pide memoria
            columna.DataType = System.Type.GetType("System.String"); 
            columna.ColumnName = "Nombre";//nombre e la columna
            columna.AllowDBNull = false; //no permite que este vacia

            Tabla_clientes.Columns.Add(columna); //agrega columna

            columna = new DataColumn(); //pide memoria
            columna.DataType = System.Type.GetType("System.String");
            columna.ColumnName = "Cedula";//nombre e la columna
            columna.AllowDBNull = false; //no permite que este vacia

            Tabla_clientes.Columns.Add(columna); //agrega columna

            columna = new DataColumn(); //pide memoria
            columna.DataType = System.Type.GetType("System.String");
            columna.ColumnName = "Tipo";//nombre e la columna
            columna.AllowDBNull = false; //no permite que este vacia

            Tabla_clientes.Columns.Add(columna); //agrega columna

            columna = new DataColumn(); //pide memoria
            columna.DataType = System.Type.GetType("System.String");
            columna.ColumnName = "Provincia";//nombre e la columna
            columna.AllowDBNull = false; //no permite que este vacia

            Tabla_clientes.Columns.Add(columna); //agrega columna

            columna = new DataColumn(); //pide memoria
            columna.DataType = System.Type.GetType("System.String");
            columna.ColumnName = "Correo";//nombre e la columna
            columna.AllowDBNull = false; //no permite que este vacia

            Tabla_clientes.Columns.Add(columna); //agrega columna

            columna = new DataColumn(); //pide memoria
            columna.DataType = System.Type.GetType("System.String");
            columna.ColumnName = "Telefono";//nombre e la columna
            columna.AllowDBNull = false; //no permite que este vacia

            Tabla_clientes.Columns.Add(columna); //agrega columna

            columna = new DataColumn(); //pide memoria
            columna.DataType = System.Type.GetType("System.String");
            columna.ColumnName = "Direccion";//nombre e la columna
            columna.AllowDBNull = false; //no permite que este vacia

            Tabla_clientes.Columns.Add(columna); //agrega columna

        }//fin estructura

        public void AgregarClientes(int codigo, string nombre, string cedula, string tipo, string provincia, string correo, string telefono, string direccion)
        {

            DataRow fila;

            fila = Tabla_clientes.NewRow();


            fila["Codigo"] = codigo;  //parentesis cuadrados
            fila["Nombre"] = nombre;
            fila["Cedula"] = cedula;
            fila["Tipo"] = tipo;

            fila["Provincia"] = provincia;
            fila["Correo"] = correo;
            fila["Telefono"] = telefono;
            fila["Direccion"] = direccion;

            //agrega a la tabla

            Tabla_clientes.Rows.Add(fila);

        }//fin agregar

        public ClaseTablaCliente()
        {
            EstructuraClientes(); //crea la tabla una vez que se abrio 

        }//fin constructor

        public void Clientes_en_XML()
        {
           EscribeXMLCliente _Archivo = new EscribeXMLCliente();

            _Archivo.AbrirXML();

            _Archivo.CrearEncabezado();

            foreach (DataRow fila in Tabla_clientes.Rows)
            {
                _Archivo.EscribeCliente(int.Parse(fila["Codigo"].ToString()), fila["Nombre"].ToString(), fila["Cedula"].ToString(), fila["Tipo"].ToString(), fila["Provincia"].ToString(), fila["Correo"].ToString(), fila["Telefono"].ToString(), fila["Direccion"].ToString());
            }//fin foreach

            _Archivo.Cerrar();
        }//fin clientes en XML

        public void LeeXMLaTablaClientes()
        {
            ClaseLeeClienteXML _archivo = new ClaseLeeClienteXML();

            _archivo.Tabla = tabla_clientes;

            _archivo.LeerCliente();

        }//fin lee XML a tabla clientes
        #endregion
    }
}
