using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class Productos
    {
        #region "Variables de trabajo
        int _codigo;
        string _nombre;
        int _cantidad;
        int _precio;
        double _impuesto;
        double _total;
        double _totalImpuesto;
        string _correo;
        int _codigoProveedor;
        string _nombreProveedor;
        bool _clickboton;
        DateTime _fechacompra;
        int _indice;
        int _cantidadDeseada;

        #endregion

      


        //base de datos 
        ClaseProductos_BD obj_productosBD = new ClaseProductos_BD();
        public DataTable Tabla_Productos { get => obj_productosBD.TablaProductos; }




        #region "Propiedades"
        public int Codigo { get => _codigo; set => _codigo = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public int Cantidad { get => _cantidad; set => _cantidad = value; }
        public int Precio { get => _precio; set => _precio = value; }
        public double Impuesto { get => _impuesto; set => _impuesto = value; }
        public double Total { get => _total; set => _total = value; }
        public double TotalImpuesto { get => _totalImpuesto; set => _totalImpuesto = value; }
        public string Correo { get => _correo; set => _correo = value; }
        public int CodigoProveedor { get => _codigoProveedor; set => _codigoProveedor = value; }
        public string NombreProveedor { get => _nombreProveedor; set => _nombreProveedor = value; }
        public DateTime Fechacompra { get => _fechacompra; set => _fechacompra = value; }
        public bool Clickboton { get => _clickboton; set => _clickboton = value; }
        public int CantidadDeseada { get => _cantidadDeseada; set => _cantidadDeseada = value; }

        #endregion

        #region "Metodos"
        public void ValidarProducto()
        {
            int i;
            if (_codigo <= 0)
            {
                throw new ArgumentException("El codigo de producto no es valido");
            }
            if (int.TryParse(_nombre, out i)) // verifica si hay numeros en nombre
            {
                throw new ArgumentException("El nombre debe contener letras");
            }
            if (_cantidad <= 0)
            {
                throw new ArgumentException("La cantidad no puede ser 0");
            }
            if (_precio <= 0)
            {
                throw new ArgumentException("El precio no puede ser 0");
            }
            if (string.IsNullOrEmpty(_nombre))
            {
                throw new ArgumentException("Escriba el nombre");
            }
        }//fin ValidarProducto
        public void CalcularTotal()
        {
            _total = _precio * _cantidad;
            _impuesto = _total * 0.13;
            _totalImpuesto = _total + _impuesto;
        }//fin CalcularTotal

      
        public void EscribeProductoDT()
        {
            //Datos_Productos.AgregarProducto(_codigo, _nombre, _cantidad, _precio, _impuesto, _totalImpuesto);


        }//fin EscribeProdutoDT


        public void EscribeTablaalXML()
        {

            //Datos_Productos.EscribeTabla_en_XML();
        }//fin EscribeTablaXML

        public void LeeTablaProducto()
        {
            // Datos_Productos.LeeXML_a_TablaProductos();
            obj_productosBD.LeerProducto();




        }//fin LeeTablaProducto

        public void ValidarStock()
        {
            if(_cantidad<_cantidadDeseada)
            {
                throw new ArgumentException("No hay suficiente stock");
            }
        }



       
       

        public void ValidarCantidad()
        {

            if (_cantidad <= 0)
            {
                throw new ArgumentException("La cantidad no puede ser 0");
            }//fin if
            
            
        }//fin validar cantidad

        public void ValidarBoton()
        {
            if (!string.IsNullOrEmpty(_nombre)) //verifica que se haya seleccionado un usuario
            {
                Clickboton = true;
            }//fin if
        }//fin validar boton


        public void EscribeProductoBD()
        {
            ClaseProductos_BD Bd_productos = new ClaseProductos_BD();

            Bd_productos.InsertaProductoBD(_codigo, _nombre, _precio,
                                    _cantidad, _impuesto, _totalImpuesto);
        } //fin EscribeProductoDT

        #endregion
    }
}
