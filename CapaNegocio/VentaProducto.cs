using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class VentaProducto
    {
        //objetos
       
        #region"Variables de trabajo
        //variaables trabajo
        int _disponible;// no lo ocupo para XML
        double _cantidadDeseada;
        double _totalProductos;//no lo ocupo para XML
        double _impuesto;
        double _total;
        double _precio;
        double _totalimpuesto;
        bool _clickboton = false;
        string _nombreUsuario; //verificar si seleciono ya un usuariopara generar factura
        int _codigoCliente;
        int _codigoProducto;
        string _cedula;
        string _tipo;
        string _provincia;
        string _correo;
        string _telefono;
        string _direccion;
        DateTime _fechaCompra;
        string _nombreProdcuto;
        #endregion


        #region "Propiedades"
        public int Disponible { get => _disponible; set => _disponible = value; }
        public double CantidadDeseada { get => _cantidadDeseada; set => _cantidadDeseada = value; }
        public double TotalProductos { get => _totalProductos; set => _totalProductos = value; }
        public double Impuesto { get => _impuesto; set => _impuesto = value; }
        public double Total { get => _total; set => _total = value; }
        public double Precio { get => _precio; set => _precio = value; }
        public double Totalimpuesto { get => _totalimpuesto; set => _totalimpuesto = value; }
        public bool Clickboton { get => _clickboton; set => _clickboton = value; }
        public string NombreUsuario { get => _nombreUsuario; set => _nombreUsuario = value; }
        public DateTime FechaCompra { get => _fechaCompra; set => _fechaCompra = value; }
        public string NombreProdcuto { get => _nombreProdcuto; set => _nombreProdcuto = value; }
        public int CodigoCliente { get => _codigoCliente; set => _codigoCliente = value; }
        public int CodigoProducto { get => _codigoProducto; set => _codigoProducto = value; }
        public string Cedula { get => _cedula; set => _cedula = value; }
        public string Tipo { get => _tipo; set => _tipo = value; }
        public string Provincia { get => _provincia; set => _provincia = value; }
        public string Correo { get => _correo; set => _correo = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        #endregion

        #region "Metodos"
        //metodos

      

       
        #endregion
    }//fin clase
}//fin namespace
