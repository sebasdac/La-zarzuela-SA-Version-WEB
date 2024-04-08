using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class ImpuestosMensuales
    {
        double impuestofavor;
        double impuestocontra;

        EscribeXMLImpuestosMensuales obj_impuestos = new EscribeXMLImpuestosMensuales();

        public double Impuestofavor { get => impuestofavor; set => impuestofavor = value; }
        public double Impuestocontra { get => impuestocontra; set => impuestocontra = value; }

        public void ImpuestosMensualesXML()
        {
            obj_impuestos.ActualizaImpuesto(impuestofavor, impuestocontra);

        }


    }
}
