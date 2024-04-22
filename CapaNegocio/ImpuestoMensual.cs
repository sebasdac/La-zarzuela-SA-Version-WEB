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
        decimal _impuestofavor;
        decimal _impuestocontra;
        double _impuestosmensuales;
        int _mes;

        ClaseImpuestosContra obj_impuestoscontrarios = new ClaseImpuestosContra();
        ClaseImpuestos obj_impuestos  = new ClaseImpuestos();

        #region "Propiedades"
        public decimal Impuestofavor { get => obj_impuestos.TotalImpuestos; }

        public decimal Impuestocontra { get => obj_impuestoscontrarios.TotalImpuestoscontra; }


     
        public double Impuestosmensuales { get => _impuestosmensuales; set => _impuestosmensuales = value; }
        public int Mes { get => _mes; set => _mes = value; }
        #endregion

        #region "Metodos"
            
        public void ImpuestoVentas()
        {
            obj_impuestos.CalcularImpuestosVenta(_mes);

        }

        public void ImpuestoCompras()
        {
            obj_impuestoscontrarios.CalcularImpuestosCompra(_mes);
        }

        public void CalculoImpuestos()
        {
            _impuestocontra = Impuestocontra;
            _impuestofavor = Impuestofavor;

            _impuestosmensuales = (double)(_impuestofavor - _impuestocontra);

        }
        public void VerificarMes()
        {
            if(_mes < 1 || _mes > 12)
            {
                throw new ArgumentException("Mes no valido");
            }

        }
        #endregion


    }
}
