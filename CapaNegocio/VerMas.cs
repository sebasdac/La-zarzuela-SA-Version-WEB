using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class VerMas
    {

        string _VerMas;
        // objeto
        ClaseLeeVerMas obj_VerMas = new ClaseLeeVerMas();

        public string VerMas2 { get => _VerMas; set => _VerMas = value; }

        public void LeerMasTXT()
        { 
           
           obj_VerMas.LeerMas();

           _VerMas = obj_VerMas.LeerMas1;
        
        }
    }
}
