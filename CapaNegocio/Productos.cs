﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
using System.Data.SqlClient;

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
        FacturaVenta facturaDAL = new FacturaVenta(); // Instancia de la capa de datos

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


        public int CantidadWEB { get => obj_productosBD.Cantidad; }
        public double PrecioWEB { get => obj_productosBD.Precio; }


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

        public void ActualizarInventarioSuma(int _codigo, int cantidad)
        {
            obj_productosBD.ActualizarInventarioSuma(_codigo.ToString(), cantidad);
        }// fin ActualizarInventarioSuma
        public void ActualizarInventario()
        {
            obj_productosBD.ActualizarInventario(_codigo, _nombre, _precio);
        }//fin ActualizarInventario

        public void LeeTablaProducto()
        {
            // Datos_Productos.LeeXML_a_TablaProductos();
            obj_productosBD.LeerProducto();
        }//fin LeeTablaProducto

        public void ValidarStock()
        {
            if (_cantidad < _cantidadDeseada)
            {
                throw new ArgumentException("No hay suficiente stock");
            }
        }//fin ValidarStock


        public void EscribeProductoBD()
        {
            try
            {
                ClaseProductos_BD Bd_productos = new ClaseProductos_BD();

                Bd_productos.EscribeProductoBD(_codigo, _nombre, _precio,
                                        _cantidad, _impuesto, _totalImpuesto);
            }//fin try
            catch(SqlException ex)
            {
                if(ex.Number== 2627)
                {
                    throw new ArgumentException("El codigo de producto ya existe");
                }
                else
                {
                    throw new ArgumentException(ex.Message);
                }

            }//fin catch
        } //fin EscribeProductoDT
        public void EliminarProducto()
        {
            obj_productosBD.EliminarProducto(_codigo);
        }//fin EliminarProducto

        public void LeerProductoWEB()
        {
            obj_productosBD.LeerProductoWEB(_codigo);
        }//fin LeerProductoWEB


        #endregion

    }
}
