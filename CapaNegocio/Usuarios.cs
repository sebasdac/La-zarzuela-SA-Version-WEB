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


        #region "Constructores"
        //objeto
        ClaseLeeUsuarioXML obj_usuario = new ClaseLeeUsuarioXML();

        EscribeXMLUsuario obj_usuarioXML = new EscribeXMLUsuario();

        private ClaseTablaUsuario Datos_Usuario = new ClaseTablaUsuario();//linea nueva

        
        public DataTable Tabla_Usuario { get => Datos_Usuario.Tabla_Usuarios; }
        #endregion



        #region "Propiedades




        public string Usuario { get => _usuario; set => _usuario = value; }
        public string Contrasena { get => _contrasena; set => _contrasena = value; }
        public int Pin { get => _pin; set => _pin = value; }
        public string Estado { get => _estado; set => _estado = value; }
        public string Cedula { get => _cedula; set => _cedula = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }

        #endregion

        #region "Metodos"
        public void ValidarUsuario()
        {
            int i;

            if (string.IsNullOrEmpty(Contrasena))
            {
                throw new ArgumentException("Escriba la contraseña");
            }

            if (string.IsNullOrEmpty(Usuario))
            {
                throw new ArgumentException("Escriba el usuario");
            }

            if (string.IsNullOrEmpty(_usuario))
            {
                throw new ArgumentException("Escriba el usuario");

            }
        }//fin validar usuario

        public void ValidarEstado()
        {
 
            if (string.IsNullOrEmpty(_estado))
            {
                throw new ArgumentException("Escoja el estado");
            }//fin if

        }//fin validar estado

        

        public void UsuarioRepetido()
        {
            obj_usuario.LeerUsuarioRepetido(Usuario);

            if (obj_usuario.UsuarioRepetido1)
            {
                throw new ArgumentException("El usuario esta repetido");

            }//fin if

        }//fin usuario repetido

        public void UsuarioIncorrecto()
        {
            obj_usuario.VerificarLogin(Usuario,Contrasena);

            if (!obj_usuario.UsuarioCorrecto1)
            {
                throw new ArgumentException("Usuario incorrecto o usuario inactivo");

            }//fin if

        }//fin usuario incorrecto

        public void EscribeUsuarioDT()
        {
            Datos_Usuario.AgregarUsuario(Usuario, Contrasena,Estado, Cedula, Nombre);


        }//fin EscribeProdutoDT


        public void EscribeUsuarioXML()
        {

            Datos_Usuario.EscribeTabla_en_XML();
        }//fin EscribeProductoXML

        public void LeeTablaUsuario()
        {

            Datos_Usuario.LeeXML_a_TablaUsuario();
        }//fin LeeTablaUsuario

        public void ValidarPin()
        {
            obj_usuario.PinCorrecto(_pin);

            if (!obj_usuario.Pincorrecto)
            {
                throw new ArgumentException("Pin incorrecto");

            }

        }//fin validar pin
        public void EscribeUsuario2()
        {
            //llama a escibe usuarioXML
            
            
            obj_usuarioXML.EscribeUsuario(_usuario, _contrasena, _estado, _cedula, _nombre);
            

        }//fin escribe usuario2

        public void CambiarPINXML()
        {

            obj_usuario.CambiaPIN(_pin);



        }//fin cambiar pinXMl

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





        #endregion
    }
}
