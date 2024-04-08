using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Proveedor
    {

        int _codigo;
        string _nombre;
        string _cedula;
        string _telefono;
        string _direccion;
        string _correo;
        string _provincia;


        private ClaseTablaProveedor Datos_Proveedor = new ClaseTablaProveedor();//linea nueva

        public DataTable Tabla_Prooveedor { get => Datos_Proveedor.Tabla_proveedor; }
        ClaseLeeProveedorXML obj_codigo = new ClaseLeeProveedorXML();

        #region "Propiedades"
        public int Codigo { get => _codigo; set => _codigo = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Cedula { get => _cedula; set => _cedula = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public string Correo { get => _correo; set => _correo = value; }
        public string Provincia { get => _provincia; set => _provincia = value; }
        #endregion

        #region "Metodos"
        public void ValidarProveedor()
        {
            double i;
            if (_codigo <= 0)
            {
                throw new ArgumentException("El codigo de producto no es valido");
            }
            if (double.TryParse(_nombre, out i)) // verifica si hay numeros en nombre
            {
                throw new ArgumentException("El nombre debe contener letras");
            }
            if (string.IsNullOrEmpty(_nombre))
            {
                throw new ArgumentException("Escriba el nombre");
            }
            
            
            if (String.IsNullOrEmpty(_provincia))
            {
                throw new ArgumentException("Debe seleccionar la provincia");
            }
            if (String.IsNullOrEmpty(_direccion))
            {
                throw new ArgumentException("Debe escribir la direccion");
            }
            if (_codigo <= 0)
            {
                throw new ArgumentException("El codigo de producto no es valido");
            }
            if (_cedula.Trim().Length < 8 || _cedula.Trim().Length > 10)
            {
                throw new ArgumentException("Revise la cedula");
            }
            if (!double.TryParse(_cedula, out i))   //"!" es si no es numerico
            {
                throw new System.Exception("La cedula debe de ser numerico");
            }

            if (_telefono.Length != 8)
            {
                throw new ArgumentException("El telefono debe de contener 8 digitos");
            }
            if (!_correo.Contains("@"))
            {
                throw new ArgumentException("EL correo debe de contener un @");

            }
            if (string.IsNullOrEmpty(_nombre))
            {
                throw new ArgumentException("Escriba el nombre");

            }





        }//fin ValidarProducto
        public void EscribeProveedorDT()
        {
            Datos_Proveedor.AgregarProveedor(_codigo, _nombre, _cedula, _provincia, _telefono, _correo, _direccion);


        }//fin EscribeProdutoDT


        public void EscribeProveedorXML()
        {

            Datos_Proveedor.EscribeTabla_en_XML();
        }//fin EscribeProductoXML

        public void LeeTablaProveedor()
        {

            Datos_Proveedor.LeeXML_a_TablaProveedor();
        }//fin LeeTablaProveedor
        public void CodigoRepetido()
        {
            obj_codigo.LeerCodigo(_codigo);

            if (obj_codigo.CodigoRepetido1)
            {
                throw new ArgumentException("El codigo esta repetido");

            }

        }//fin codigo repetido

        #endregion
    }
}
