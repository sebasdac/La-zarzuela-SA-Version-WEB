using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class FacturaVenta
    {
        int _codigocliente;
        string _nombrecliente;
        string _cedula;
        string _tipo;
        string _provincia;
        string _correo;
        string _telefono;
        string _direccion;

        int _codigoproducto;
        string _nombreprodcuto;
        int _cantidad;
        int _precio;
        double _impuesto;
        double _total;
        double _totalImpuesto;


      

        #region "Propiedades"

        public string Cedula { get => _cedula; set => _cedula = value; }
        public string Tipo { get => _tipo; set => _tipo = value; }
        public string Provincia { get => _provincia; set => _provincia = value; }
        public string Correo { get => _correo; set => _correo = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public int Codigocliente { get => _codigocliente; set => _codigocliente = value; }
        public string Nombrecliente { get => _nombrecliente; set => _nombrecliente = value; }
        public int Codigoproducto { get => _codigoproducto; set => _codigoproducto = value; }
        public string Nombreprodcuto { get => _nombreprodcuto; set => _nombreprodcuto = value; }
        public int Cantidad { get => _cantidad; set => _cantidad = value; }
        public int Precio { get => _precio; set => _precio = value; }
        public double Impuesto { get => _impuesto; set => _impuesto = value; }
        public double Total { get => _total; set => _total = value; }
        public double TotalImpuesto { get => _totalImpuesto; set => _totalImpuesto = value; }
        #endregion

        #region "Metodos"
        
       
        
       
        #endregion
    }
}
