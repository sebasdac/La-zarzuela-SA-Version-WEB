using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class ImpuestoMensual
    {
        double _impuestofavor;
        double _impuestocontra;
        double _impuestosmensuales;
        int _mes;
        EscribeXMLImpuestosMensuales obj_impuestos = new EscribeXMLImpuestosMensuales();
        #region "Propiedades"
        public double Impuestofavor { get => _impuestofavor; set => _impuestofavor = value; }
        public double Impuestocontra { get => _impuestocontra; set => _impuestocontra = value; }
        public double Impuestosmensuales { get => _impuestosmensuales; set => _impuestosmensuales = value; }
        public int Mes { get => _mes; set => _mes = value; }
        #endregion

        #region "Metodos"
        public void CalcularImpuestoMensual()
        {

            obj_impuestos.ActualizaImpuesto(_impuestofavor, _impuestocontra, _mes );
        }//Fin CalcularImpuestoMensual

        public void ImpuestosMensualesMostar()
        {
            _impuestosmensuales = obj_impuestos.LeerImpuesto(_mes);
            

        }//        public void PagarImpuesto()

        #endregion


    }
}
