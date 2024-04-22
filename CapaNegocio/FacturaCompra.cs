using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class FacturaCompra
    {
        #region "Variables"
        int _CodigoProveedor;
        string _NombreProveedor;
        string _Fecha;
        string _NumeroFactura;
        int _CodigoProducto;
        string _NombreProducto;
        int _Cantidad;
        double _Precio;
        double _Total;
        int facturaID;
        string _tipo;
        string _cedulaproveedor;
        DateTime _fecha;


        double _subtotal;
        double _impuesto;
        double _totalImpuesto;


        
        ClaseFacturaCompra facturaDAL = new ClaseFacturaCompra(); // Instancia de la capa de datos

        #endregion







        #region "Propiedades"
        public DataTable Tabla_Facturas { get => facturaDAL.TablaFacturas; }
        public DataTable Tabla_Detalles { get => facturaDAL.TablaDetalles; }
        public int FacturaIDWEB { get => facturaDAL.FacturaID; }
        public int CodigoProveedor { get => _CodigoProveedor; set => _CodigoProveedor = value; }
        public string NombreProveedor { get => _NombreProveedor; set => _NombreProveedor = value; }
        public string Fecha { get => _Fecha; set => _Fecha = value; }
        public string NumeroFactura { get => _NumeroFactura; set => _NumeroFactura = value; }
        public int CodigoProducto { get => _CodigoProducto; set => _CodigoProducto = value; }
        public string NombreProducto { get => _NombreProducto; set => _NombreProducto = value; }
        public int Cantidad { get => _Cantidad; set => _Cantidad = value; }
        public double Precio { get => _Precio; set => _Precio = value; }
        public double Total { get => _Total; set => _Total = value; }
        public int FacturaID { get => facturaID; set => facturaID = value; }
        public string Cedulaproveedor { get => _cedulaproveedor; set => _cedulaproveedor = value; }
        public string Tipo { get => _tipo; set => _tipo = value; }
        public DateTime Fecha1 { get => _fecha; set => _fecha = value; }
        public double SubTotal { get => SubTotal; set => SubTotal = value; }
        public double Impuesto { get => _impuesto; set => _impuesto = value; }
        public double TotalImpuesto { get => _totalImpuesto; set => _totalImpuesto = value; }
        #endregion

        #region "Metodos"


        public void CalcularTotal()
        {
            _subtotal = _Precio * _Cantidad;
            Impuesto = _subtotal * 0.13;
            TotalImpuesto = _subtotal + Impuesto;
        }//fin CalcularTotal

        public void InsertarFactura()
        {
           
            facturaDAL.InsertarFactura(_CodigoProveedor, _NombreProveedor,
                _cedulaproveedor, _tipo, Fecha1);
        }//fin InsertarFactura

        public void InsertarDetalleFactura()
        {
            facturaDAL.InsertarDetalleFactura(_CodigoProducto,_NombreProducto,
                _Cantidad,_Precio,_subtotal,Impuesto,TotalImpuesto);
        }//fin InsertarDetalleFactura
        public void InsertarDetalleFacturaWEB(int facturaid)
        {
            facturaDAL.InsertarDetalleFacturaWEB(facturaid,_CodigoProducto, _NombreProducto,
                _Cantidad, _Precio, _subtotal, Impuesto, TotalImpuesto);
        }//fin InsertarDetalleFacturaWEB




      


        public void LeerFactura()
        {
            facturaDAL.LeerFactura(facturaID.ToString());

        }//fin LeerFactura
        public void LeerDetallesWEB(int facturaid)
        {
            facturaDAL.LeerDetallesWEB(facturaid);

        }//fin LeerFactura

        public void LeerDetalles()
        {
            facturaDAL.LeerDetalles(facturaID.ToString());
        }//fin LeerDetalles

        public void LeerFacturaDGV()
        {
            facturaDAL.LeerDetallesalDataGridView();
        }//fin LeerFacturaDGV

        public void EliminarProductoFactura()
        {
            facturaDAL.EliminarProducto(_CodigoProducto);
        }// fin EliminarProductoFactura


        public void EliminarFactura()
        {
               try
               {

                  facturaDAL.EliminarFactura();
                }
            
               catch(SqlException ex)
               {

                    if (ex.Number == 547)
                    {
                        throw new ArgumentException("No se puede eliminar la factura porque tiene detalles asociados");
                    }
                    else
                    {
                        throw new ArgumentException(ex.Message);
                    }
               }
        }//fin EliminarFactura

        public void EliminarFacturaWEB()
        {
            try
            {
                facturaDAL.EliminarFacturaWEB(FacturaID);
            }
                
             catch(SqlException ex)
            {

                if (ex.Number == 547)
                {
                    throw new ArgumentException("No se puede eliminar la factura porque tiene detalles asociados");
                }
                else
                {
                    throw new ArgumentException(ex.Message);
                }
            }
        }//fin EliminarFacturaWEB



        public void RestaInventario (string codigoProducto, int cantidad)
        {
            ClaseProductos_BD obj_productos = new ClaseProductos_BD();

            obj_productos.ActualizarInventarioResta(codigoProducto, cantidad);
        }//fin RestaInventario





        #endregion
    }
}
