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




        ClaseLoginWEB obj_login = new ClaseLoginWEB();
        public bool Esproveedor { get => obj_login.Esproveedor1; }
        public bool Esusuario{ get => obj_login.Esusuario1; }
        public string Contrasena { get => contrasena; set => contrasena = value; }
        public string Usuario { get => usuario; set => usuario = value; }

        public void AutenticarUsuario()
        {
            obj_login.AutenticarUsuario(Usuario, Contrasena);
        }



    }
}
