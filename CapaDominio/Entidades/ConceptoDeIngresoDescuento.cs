using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominio.Entidades
{
    public class ConceptoDeIngresoDescuento
    {
        private int codigoConcepto;//codigo
        private double montoDeOtrosDescuentos;
        private double montoDeOtrosIngresos;
        private double montoPorAdelantos;
        private double montoPorHorasAusentes;
        private double montoPorHorasExtras;
        private double montoPorReintegros;
        private PeriodoDePago periodoDePago;
        private Contrato contrato;

        public int CodigoConcepto { get => codigoConcepto; set => codigoConcepto = value; }
        public double MontoDeOtrosDescuentos { get => montoDeOtrosDescuentos; set => montoDeOtrosDescuentos = value; }
        public double MontoDeOtrosIngresos { get => montoDeOtrosIngresos; set => montoDeOtrosIngresos = value; }
        public double MontoPorAdelantos { get => montoPorAdelantos; set => montoPorAdelantos = value; }
        public double MontoPorHorasAusentes { get => montoPorHorasAusentes; set => montoPorHorasAusentes = value; }
        public double MontoPorHorasExtras { get => montoPorHorasExtras; set => montoPorHorasExtras = value; }
        public double MontoPorReintegros { get => montoPorReintegros; set => montoPorReintegros = value; }
        public PeriodoDePago PeriodoDePago { get => periodoDePago; set => periodoDePago = value; }
        public Contrato Contrato { get => contrato; set => contrato = value; }


        //reglas

        public double CalcularConceptoIngreso()
        {
            return montoPorHorasExtras + montoPorReintegros + montoDeOtrosIngresos;

        }


        public double CalcularConceptoDescuento()
        {

            return montoPorHorasAusentes + montoPorAdelantos + montoDeOtrosDescuentos;

        }
    }
}
