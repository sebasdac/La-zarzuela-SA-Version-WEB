using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class FacturaCompra
    {

        int _CodigoProveedor;
        string _NombreProveedor;
        string _Fecha;
        string _NumeroFactura;
        int _CodigoProducto;
        string _NombreProducto;
        int _Cantidad;
        double _Precio;
        double _Total;
        ClaseFacturaCompra facturaDAL = new ClaseFacturaCompra(); // Instancia de la capa de datos
        
       








        #region "Propiedades"
        public int CodigoProveedor { get => _CodigoProveedor; set => _CodigoProveedor = value; }
        public string NombreProveedor { get => _NombreProveedor; set => _NombreProveedor = value; }
        public string Fecha { get => _Fecha; set => _Fecha = value; }
        public string NumeroFactura { get => _NumeroFactura; set => _NumeroFactura = value; }
        public int CodigoProducto { get => _CodigoProducto; set => _CodigoProducto = value; }
        public string NombreProducto { get => _NombreProducto; set => _NombreProducto = value; }
        public int Cantidad { get => _Cantidad; set => _Cantidad = value; }
        public double Precio { get => _Precio; set => _Precio = value; }
        public double Total { get => _Total; set => _Total = value; }
        #endregion

        #region "Metodos"

        public int RegistrarFactura(int clienteID, string nombre, string cedula, string tipo, DateTime fecha, decimal total, int[] productoIDs, int[] cantidades, decimal[] precios, decimal[] impuestos, decimal[] subtotales, decimal[] totalesProductos, string[] nombreproducto)
        {
            // Insertar la factura
            int facturaID = facturaDAL.InsertarFactura(clienteID, nombre, cedula, tipo, fecha, total);

            // Insertar los detalles de la factura
            for (int i = 0; i < productoIDs.Length; i++)
            {
                facturaDAL.InsertarDetalleFactura(facturaID, productoIDs[i], cantidades[i], precios[i], impuestos[i], subtotales[i], totalesProductos[i], nombreproducto[i]);
            }

            return facturaID;
        }

        public void ValidarProveedor()
        {

            if(string.IsNullOrEmpty(_NombreProveedor))
            {
                throw new ArgumentException("El nombre del proveedor no puede estar vacio");
            }
        }









        #endregion
    }
}
