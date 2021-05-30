using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominio.Entidades
{
    public class BoletaDePago
    {
        private double asignacionFamiliar;
        private String fechaDeEmision;
        private double sueldoBasico;
        private double sueldoNeto;
        private double totalDeDescuentos;
        private double totalDeHoras;
        private double totalDeIngresos;
        private Contrato contrato;
        private PeriodoDePago periodoDePago;
        private ConceptoDeIngresoDescuento conceptoDeIngresoDescuento;

        public BoletaDePago()
        {

        }
        public BoletaDePago(Contrato contrato, PeriodoDePago periodoDePago)
        {
            this.contrato = contrato;
            this.PeriodoDePago = periodoDePago;
        }
        public BoletaDePago(Contrato contrato)
        {
            this.contrato = contrato;
        }
        public BoletaDePago(Contrato contrato, ConceptoDeIngresoDescuento conceptoDeIngresoDescuento)
        {
            this.contrato = contrato;
            this.ConceptoDeIngresoDescuento = conceptoDeIngresoDescuento;
        }

        public double AsignacionFamiliar { get => asignacionFamiliar; set => asignacionFamiliar = value; }
        public string FechaDeEmision { get => fechaDeEmision; set => fechaDeEmision = value; }
        public double SueldoBasico { get => sueldoBasico; set => sueldoBasico = value; }
        public double SueldoNeto { get => sueldoNeto; set => sueldoNeto = value; }
        public double TotalDeDescuentos { get => totalDeDescuentos; set => totalDeDescuentos = value; }
        public double TotalDeHoras { get => totalDeHoras; set => totalDeHoras = value; }
        public double TotalDeIngresos { get => totalDeIngresos; set => totalDeIngresos = value; }
        public Contrato Contrato { get => contrato; set => contrato = value; }
        public PeriodoDePago PeriodoDePago { get => periodoDePago; set => periodoDePago = value; }
        public ConceptoDeIngresoDescuento ConceptoDeIngresoDescuento { get => conceptoDeIngresoDescuento; set => conceptoDeIngresoDescuento = value; }

        //public double SueldoMinimo { get => sueldoMinimo; set => sueldoMinimo = value; }

        //reglas

      

        public Double CalcularDescuentosAfp(Double sueldoBasico)
        {
            Double descuentoAFp;
            descuentoAFp = sueldoBasico * (Contrato.Afp.PorcentajeAfp / 100);
            return descuentoAFp;
        }
        public double CalcularSueldoBasico()//r7
        {
            return totalDeHoras * Contrato.PagoPorHora  ;
        }


        public double CalcularSueldoNeto()//r12
        {
            return totalDeIngresos - totalDeDescuentos;//llamar a los métodos
        }


        public double CalcularTotalDescuento()//r11
        {
            return CalcularDescuentosAfp (CalcularSueldoBasico())/*r10*/ + ConceptoDeIngresoDescuento.CalcularConceptoDescuento();//r15
        }


        public double CalcularTotalDeHoras()//r13
        {
            return PeriodoDePago.CalcularSemanasPeriodo() * contrato.HorasSemana;
        }

        public double CalcularTotalDeIngresos()//r9
        {
            return CalcularSueldoBasico() + contrato.CalcularAsignacionFamiliar() + ConceptoDeIngresoDescuento.CalcularConceptoIngreso();//r14
        }
        /*
        public override bool Equals(object obj)
        {
            return obj is BoletaDePago pago &&
                   SueldoMinimo == pago.SueldoMinimo;
        }*/
    }
}
