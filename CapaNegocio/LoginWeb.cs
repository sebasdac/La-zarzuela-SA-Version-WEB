using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class LoginWeb
    {
        string usuario;
        string contrasena;
        bool esproveedorweb;
        bool esusuarioweb;




        ClaseLoginWEB obj_login = new ClaseLoginWEB();
        public bool Esproveedor { get => obj_login.Esproveedor1; }
        public bool Esusuario{ get => obj_login.Esusuario1; }
        public string Contrasena { get => contrasena; set => contrasena = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public bool Esproveedorweb { get => esproveedorweb; set => esproveedorweb = value; }
        public bool Esusuarioweb { get => esusuarioweb; set => esusuarioweb = value; }

        public void AutenticarUsuario()
        {
            obj_login.AutenticarUsuario(Usuario, Contrasena);
            if(!obj_login.Esproveedor1&&!obj_login.Esusuario1)
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


        }
        



    }
}
