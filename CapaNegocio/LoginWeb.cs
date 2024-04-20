using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class LoginWeb
    {
        string usuario;
        string contrasena;
        bool esproveedorweb;
        bool esusuarioweb;
        bool esclienteweb;




        ClaseLoginWEB obj_login = new ClaseLoginWEB();
        public bool Esproveedor { get => obj_login.Esproveedor1; }
        public bool Esusuario{ get => obj_login.Esusuario1; }
        public string Contrasena { get => contrasena; set => contrasena = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public bool Esproveedorweb { get => esproveedorweb; set => esproveedorweb = value; }
        public bool Esusuarioweb { get => esusuarioweb; set => esusuarioweb = value; }

        public bool Escliente { get => obj_login.Escliente1; }
      

        public void AutenticarUsuario()
        {
            obj_login.AutenticarUsuario(Usuario, Contrasena);
            if(!obj_login.Esproveedor1&&!obj_login.Esusuario1 &&!obj_login.Escliente1)
            {
                throw new ArgumentException("Usuario no encontrado");
            }
            if(obj_login.Esproveedor1)
            {
                esproveedorweb = true;
            }
            if (obj_login.Esusuario1)
            {
                esusuarioweb = true;
            }
            if (obj_login.Escliente1)
            {
                esclienteweb = true;
            }


        }

        public void CambioContrasena()
        {
            obj_login.CambioContrasenaa(Usuario, Contrasena);
        }
        public void ValidarContrasena()
        {
            string pattern = @"(?=.*\d)(?=.*[\u0021-\u002b\u003c-\u0040])(?=.*[A-Z])(?=.*[a-z])\S{8,16}$";
            if (!Regex.IsMatch(Contrasena, pattern))
            {
                throw new ArgumentException("La contraseña debe de contener al menos una letra mayuscula, una minuscula, un numero y un caracter especial, no puede contener espacion en blanco y debe tener una longitud de 8-16 caracteres");
            }
        }
        



    }
}
