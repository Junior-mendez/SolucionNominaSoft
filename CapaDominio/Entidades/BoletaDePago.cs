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
        private DateTime fechaDeEmision;
        private double sueldoBasico;
        private double sueldoNeto;
        private double totalDeDescuentos;
        private double totalDeHoras;
        private double totalDeIngresos;
        private double descuentoAfp;
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
        public BoletaDePago(Contrato contrato, PeriodoDePago periodoDePago, ConceptoDeIngresoDescuento conceptoDeIngresoDescuento)
        {
            this.contrato = contrato;
            this.PeriodoDePago = periodoDePago;
            this.ConceptoDeIngresoDescuento = conceptoDeIngresoDescuento;
        }

        public double AsignacionFamiliar { get => asignacionFamiliar; set => asignacionFamiliar = value; }
        public DateTime FechaDeEmision { get => fechaDeEmision; set => fechaDeEmision = value; }
        public double SueldoBasico { get => sueldoBasico; set => sueldoBasico = value; }
        public double SueldoNeto { get => sueldoNeto; set => sueldoNeto = value; }
        public double TotalDeDescuentos { get => totalDeDescuentos; set => totalDeDescuentos = value; }
        public double TotalDeHoras { get => totalDeHoras; set => totalDeHoras = value; }
        public double DescuentoAfp { get => descuentoAfp; set => descuentoAfp = value; }
        public double TotalDeIngresos { get => totalDeIngresos; set => totalDeIngresos = value; }
        public Contrato Contrato { get => contrato; set => contrato = value; }
        public PeriodoDePago PeriodoDePago { get => periodoDePago; set => periodoDePago = value; }
        public ConceptoDeIngresoDescuento ConceptoDeIngresoDescuento { get => conceptoDeIngresoDescuento; set => conceptoDeIngresoDescuento = value; }


      

        public Double CalcularDescuentosAfp(Double sueldoBasico,float porcentajeAfp)
        {
            Double descuentoAFp;
            descuentoAFp = sueldoBasico * (porcentajeAfp);
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


        public double CalcularTotalDescuento(BoletaDePago boleta, ConceptoDeIngresoDescuento concepto)//r11
        {
            return boleta.descuentoAfp/*r10*/ + concepto.CalcularConceptoDescuento();//r15
        }


        public double CalcularTotalDeHoras()//r13
        {
            return PeriodoDePago.CalcularSemanasPeriodo() * contrato.HorasSemana;
        }

        public double CalcularTotalDeIngresos(ConceptoDeIngresoDescuento concepto,Contrato contrato)//r9
        {
            return sueldoBasico + contrato.CalcularAsignacionFamiliar() + concepto.CalcularConceptoIngreso();//r14
        }
       
    }
}
