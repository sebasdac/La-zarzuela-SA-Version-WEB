﻿using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Proveedor
    {
        #region "Variables"
        int _codigo;
        string _nombre;
        string _cedula;
        string _telefono;
        string _direccion;
        string _correo;
        string _provincia;
        string _tipo;
        string _estado;
        string _contrasena;
        
        ClaseProveedorBD obj_proveedor = new ClaseProveedorBD();
        #endregion



        #region "Propiedades"
        public string CedulaWEB { get => obj_proveedor.Cedula; }
        public string TipoWEB { get => obj_proveedor.Tipo; }
        public int Codigo { get => _codigo; set => _codigo = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Cedula { get => _cedula; set => _cedula = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public string Correo { get => _correo; set => _correo = value; }
        public string Provincia { get => _provincia; set => _provincia = value; }
        public string Tipo { get => _tipo; set => _tipo = value; }
        public string Estado { get => _estado; set => _estado = value; }

        public DataTable TablaProveedor { get => obj_proveedor.TablaProveedor; }
        public string Contrasena { get => _contrasena; set => _contrasena = value; }
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


            string pattern = @"^(([^<>()\[\]\\.,;:\s@”]+(\.[^<>()\[\]\\.,;:\s@”]+)*)|(“.+”))@((\[[0–9]{1,3}\.[0–9]{1,3}\.[0–9]{1,3}\.[0–
                9]{1,3}])|(([a-zA-Z\-0–9]+\.)+[a-zA-Z]{2,}))$";
            if (!Regex.IsMatch(_correo, pattern))
            {
                throw new ArgumentException("Por favor, asegúrate de que tu dirección de correo electrónico tenga un formato válido. Debe contener un nombre de usuario seguido de '@' y un dominio válido, como 'ejemplo@dominio.com'.");
            }
            if (string.IsNullOrEmpty(_nombre))
            {
                throw new ArgumentException("Escriba el nombre");

            }
            if (string.IsNullOrEmpty(_tipo))
            {
                throw new ArgumentException("Escoja el tipo");
            }//fin if
            string pattern2 = @"(?=.*\d)(?=.*[\u0021-\u002b\u003c-\u0040])(?=.*[A-Z])(?=.*[a-z])\S{8,16}$";
            if (!Regex.IsMatch(_contrasena, pattern2))
            {
                throw new ArgumentException("La contraseña debe de contener al menos una letra mayuscula, una minuscula, un numero y un caracter especial, no puede contener espacion en blanco y debe tener una longitud de 8-16 caracteres");
            }


        }//fin ValidarProducto
       public void LeerProveedoresBD()
        {
            obj_proveedor.LeerProveedor();

        }//fin LeerProductoBD
        public void EscribeProveedorBD()
        {
           

           obj_proveedor.InsertaProveedorBD(_codigo, _nombre, _tipo, _cedula, _direccion, Provincia, _telefono, _correo, _contrasena);
        } //fin EscribeProductoDT

        public void EditarProveedor()
        {
            obj_proveedor.ActualizarProveedor(_codigo, _nombre, _tipo, _cedula, _direccion, _provincia, _telefono, _correo, _contrasena);

        }//fin EditarProveedor
        public void EliminarProveedor()
        {
            obj_proveedor.EliminarProveedor(_codigo);
        }//fin EliminarProveedor
        public void LeerProveedorWEB()
        {
            obj_proveedor.LeerProveedorWEB(_codigo);
        }//fin LeerClienteWEB
        public void LeerProveedorPorCorreo()
        {
            obj_proveedor.LeerDetallesPorCorreo(_correo);
        }//fin LeerClienteWEB







        #endregion
    }
}
