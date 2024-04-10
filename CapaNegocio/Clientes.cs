using Microsoft.Win32;
using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;


namespace CapaNegocio
{
    public class Clientes
    {
        // variables
        int _codigo;
        string _nombre;
        string _cedula;
        string _tipo;
        string _provincia;
        string _correo;
        string _telefono;
        string _direccion;



        #region "Propiedades"
        public int Codigo { get => _codigo; set => _codigo = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Cedula { get => _cedula; set => _cedula = value; }
        public string Tipo { get => _tipo; set => _tipo = value; }
        public string Provincia { get => _provincia; set => _provincia = value; }
        public string Correo { get => _correo; set => _correo = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        

       


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
            if (!_correo.Contains("@"))
            {
                throw new ArgumentException("EL correo debe de contener un @");

            }
            if (string.IsNullOrEmpty(_nombre))
            {
                throw new ArgumentException("Escriba el nombre");
                
            }

        }//fin ValidarCliente
       

        

      

        

        
       
        #endregion
    }
}
