using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Usuarios
    {
        string _cedula;
        string _nombre;
        string _usuario;
        string _contrasena;
        string _estado;
        int _pin;
        int piningresado;
        ClaseUsuarioBD obj_usuarios = new ClaseUsuarioBD();


        #region "Constructores"
        //objeto
       

        
        
        #endregion



        #region "Propiedades




        public string Usuario { get => _usuario; set => _usuario = value; }
        public string Contrasena { get => _contrasena; set => _contrasena = value; }
        public object Pin { get => obj_usuarios.PIN1; }
        public string Estado { get => _estado; set => _estado = value; }
        public string Cedula { get => _cedula; set => _cedula = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public int PinIngresado { get => piningresado; set => piningresado = value; }

        #endregion

        #region "Metodos"


        public void ValidarEstado()
        {
 
            if (string.IsNullOrEmpty(_estado))
            {
                throw new ArgumentException("Escoja el estado");
            }//fin if

        }//fin validar estado

        public void UsuarioIncorrecto()
        {

        }

        public void EscribeUsuarioBD()
        {
            ClaseUsuarioBD Bd_productos = new ClaseUsuarioBD();

            Bd_productos.InsertaUsuarioBD(_usuario, _nombre, _estado, _cedula, _contrasena);
        } //fin EscribeProductoDT













        public void ValidarUsuarioRegistro()
        {
            int i;

            if (_cedula.Trim().Length != 9)
            {
                throw new ArgumentException("La cedula debe de contener 9 digitos");
            }
            if (!int.TryParse(_cedula, out i))   //"!" es si no es numerico
            {
                throw new System.Exception("La cedula debe de ser numerico");
            }
            if (string.IsNullOrEmpty(_nombre))
            {
                throw new ArgumentException("Escriba el nombre");

            }
        }//fin validar usuario registro


        public void ValidarPIN()
        {
            obj_usuarios.ObtenerPIN();
            if (piningresado!=int.Parse(Pin.ToString()))
            {
                throw new ArgumentException("Pin incorrecto");

            }

        }


        #endregion
    }
}
