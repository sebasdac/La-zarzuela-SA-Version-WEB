﻿using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class FacturaVenta
    {
        #region "Variables"
        int _codigocliente;
        string _nombrecliente;
        string _cedula;
        string _tipo;
        string _provincia;
        string _correo;
        string _telefono;
        string _direccion;
        int FacturaID;

        int _codigoproducto;
        string _nombreprodcuto;
        int _cantidad;
        int _precio;
        double _impuesto;
        double _total;
        double _totalImpuesto;
        double _subtotal;


        ClaseFacturas obj_facturas = new ClaseFacturas();
        #endregion



        #region "Propiedades"
        private ClaseFacturas facturaDAL = new ClaseFacturas(); // Instancia de la capa de datos
        public DataTable Tabla_Facturas { get => obj_facturas.TablaFacturas; }
        public DataTable Tabla_Detalles { get => obj_facturas.TablaDetalles; }

        public int FacturaIDWEB { get => obj_facturas.FacturaID; }
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
        public int FacturaID1 { get => FacturaID; set => FacturaID = value; }
        public double Subtotal { get => _subtotal; set => _subtotal = value; }
        #endregion

        #region "Metodos"
        

        public void RegistrarFactura(int clienteID, string nombre, string cedula, string tipo, DateTime fecha)
        {
            
            obj_facturas.InsertarFactura(clienteID, nombre, cedula, tipo, fecha);
            
        }//fin RegistrarFactura


        public void InsertarDetallesFactura()
        {
            obj_facturas.InsertarDetalleFactura(_codigoproducto,_cantidad, _precio,_impuesto,_subtotal,_total, _nombreprodcuto);
        }//fin InsertarDetallesFactura

        public void InsertarDetallesFacturaWEB(int facturaid)
        {
            obj_facturas.InsertarDetalleFacturaWEB(facturaid,_codigoproducto, _cantidad, _precio, _impuesto, _subtotal, _total, _nombreprodcuto);
        }//fin InsertarDetallesFacturaWEB





        public void ActualizarInventario(string codigoProducto, int cantidad)
        {
            ClaseProductos_BD productoDAL = new ClaseProductos_BD(); // Instancia de la capa de datos
            // Llama al método de la capa de datos para actualizar el inventario
            productoDAL.ActualizarInventarioResta(codigoProducto, cantidad);
        }//fin ActualizarInventario

        public void ValidarCliente()
        {
            if (string.IsNullOrEmpty(_nombrecliente))
            {
                throw new ArgumentException("El nombre del cliente es requerido");
            }
            
        }//fin ValidarCliente
       
      
        public void LeerFactura()
        {
            obj_facturas.LeerFactura(FacturaID.ToString());
            
        }//fin LeerFactura

        public void LeerDetalles()
        {
            obj_facturas.LeerDetalles(FacturaID.ToString());
        }//fin LeerDetalles

        public void LeerDetallesGridView()
        {
            obj_facturas.LeerDetallesalDataGridView();
        }//fin LeerDetallesGridView
        public void EliminarProducto()
        {
            obj_facturas.EliminarProducto(_codigoproducto);
        }//fin EliminarProducto
        public void EliminarFactura()
        {
            try
            {
                obj_facturas.EliminarFactura();
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
        public void LeerDetallesGridViewWEb(int codigo)
        {
            obj_facturas.LeerDetallesalDataGridViewWEB(codigo);
        }//fin LeerDetallesGridViewWEb
        public void EliminarFacturaWEB()
        {
            try
            {
                obj_facturas.EliminarFacturaWEB(FacturaID1);
            }
            catch (SqlException ex)
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


        #endregion
    }
}
