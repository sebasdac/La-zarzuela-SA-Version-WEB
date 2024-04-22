using Microsoft.Win32;
using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
using System.Text.RegularExpressions;
using System.Data.SqlClient;


namespace CapaNegocio
{
    public class Clientes
    {
        #region "Variables"
        // variables
        int _codigo;
        string _nombre;
        string _cedula;
        string _tipo;
        string _provincia;
        string _correo;
        string _telefono;
        string _direccion;
        string _contrasena;
        ClaseClienteBD obj_clientes = new ClaseClienteBD();
        #endregion


        #region "Propiedades"
        public int Codigo { get => _codigo; set => _codigo = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Cedula { get => _cedula; set => _cedula = value; }
        public string Tipo { get => _tipo; set => _tipo = value; }
        public string Provincia { get => _provincia; set => _provincia = value; }
        public string Correo { get => _correo; set => _correo = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }

        public DataTable TablaClientes { get => obj_clientes.TablaClientes; }
        public string Contrasena { get => _contrasena; set => _contrasena = value; }

        public string CedulaWEB { get => obj_clientes.Cedula; }
        public string TipoWEB { get => obj_clientes.Tipo; }




        #endregion

        #region"Metodos"
        public void VerificarCliente()
        {
            double i;
            
            if (String.IsNullOrEmpty(_tipo))
            {
                throw new ArgumentException("Debe seleccionar tipo");
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
            if (_cedula.Trim().Length < 8 || _cedula.Trim().Length > 12)
            {
                throw new ArgumentException("Revise la cedula");
            }
            if (!double.TryParse(_cedula, out i))   //"!" es si no es numerico
            {
                throw new System.Exception("La cedula debe de ser numerico");
            }
            
            if (_telefono.Length!=8)
            {
                throw new ArgumentException("El telefono debe de contener 8 digitos");
            }
            
            if (string.IsNullOrEmpty(_nombre))
            {
                throw new ArgumentException("Escriba el nombre");
                
            }
            string pattern = @"(?=.*\d)(?=.*[\u0021-\u002b\u003c-\u0040])(?=.*[A-Z])(?=.*[a-z])\S{8,16}$";
            if (!Regex.IsMatch(_contrasena, pattern))
            { 
              throw new ArgumentException("La contraseña debe de contener al menos una letra mayuscula, una minuscula, un numero y un caracter especial, no puede contener espacion en blanco y debe tener una longitud de 8-16 caracteres");
            }
            string pattern2 = @"^(([^<>()\[\]\\.,;:\s@”]+(\.[^<>()\[\]\\.,;:\s@”]+)*)|(“.+”))@((\[[0–9]{1,3}\.[0–9]{1,3}\.[0–9]{1,3}\.[0–
                9]{1,3}])|(([a-zA-Z\-0–9]+\.)+[a-zA-Z]{2,}))$";
            if (!Regex.IsMatch(_correo, pattern2))
            {
                throw new ArgumentException("Por favor, asegúrate de que tu dirección de correo electrónico tenga un formato válido. Debe contener un nombre de usuario seguido de '@' y un dominio válido, como 'ejemplo@dominio.com'.");
            }

        }//fin ValidarCliente

        public void LeerClientes()
        {
            obj_clientes.LeerCliente();


        }//fin LeerClientes
        public void EscribeClienteBD()
        {
            try
            {
                ClaseClienteBD Bd_productos = new ClaseClienteBD();

                Bd_productos.InsertaClienteBD(_codigo, _nombre, _tipo, _cedula, _direccion, Provincia, _telefono, _correo, _contrasena);
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    throw new ArgumentException("El codigo de cliente ya existe");
                }
                else
                {
                    throw new ArgumentException("Error al insertar cliente: " + ex.Message);
                }
            }
        } //fin EscribeProductoDT
        public void ActualizarCliente()
        {

          obj_clientes.ActualizarPersona(_codigo, _nombre, _tipo, _cedula, _direccion, Provincia, _telefono, _correo, _contrasena);
        }//fin ActualizarCliente

        public void EliminarCliente()
        {
            obj_clientes.EliminarPersona(_codigo);
        }//fin EliminarCliente

        public void LeerClienteWEB()
        {
            obj_clientes.LeerClienteWEB(_codigo);
        }//fin LeerClienteWEB

        public void LeerUNSoloCliente()
        {

            obj_clientes.LeerDetallesPorCorreo(_correo);
        }//fin LeerUNSoloCliente
        public void ValidarContrasena()
        {
            string pattern = @"(?=.*\d)(?=.*[\u0021-\u002b\u003c-\u0040])(?=.*[A-Z])(?=.*[a-z])\S{8,16}$";
            if (!Regex.IsMatch(_contrasena, pattern))
            {
                throw new ArgumentException("La contraseña debe de contener al menos una letra mayuscula, una minuscula, un numero y un caracter especial, no puede contener espacion en blanco y debe tener una longitud de 8-16 caracteres");
            }
        }//fin ValidarContrasena





        #endregion
    }
}
