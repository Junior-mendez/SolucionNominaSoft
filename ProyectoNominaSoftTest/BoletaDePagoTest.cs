using CapaDominio.Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ProyectoNominaSoftTest
{
    [TestClass]
    public class BoletaDePagoTest
    {
        [TestMethod]
        public void CalcularDescuentosAfpTest()
        {
            Afp afp = new Afp();
            Contrato contrato = new Contrato(afp);
            BoletaDePago boleta = new BoletaDePago(contrato);
            Double sueldoBasico = 930;
            contrato.Afp.PorcentajeAfp = 0.1F;
            int descuentoAfp = Convert.ToInt32(boleta.CalcularDescuentosAfp(sueldoBasico, contrato.Afp.PorcentajeAfp));
            int descuentoAfp_esperado = 93;
            Assert.AreEqual(descuentoAfp, descuentoAfp_esperado);
        }
        [TestMethod]
        public void CalcularSueldoBasicoTest()
        {
            Contrato contrato = new Contrato();
            //PeriodoDePago periodo = new PeriodoDePago();
            BoletaDePago boleta = new BoletaDePago(contrato);
            boleta.TotalDeHoras = 160;
            boleta.Contrato.PagoPorHora = 12;
            Double sueldo = boleta.CalcularSueldoBasico();
            Double sueldo_esperado = 1920;
            Assert.AreEqual(sueldo, sueldo_esperado);
        }
        [TestMethod]
        public void CalcularSueldoNetoTest()
        {
            
            BoletaDePago boleta = new BoletaDePago();
            boleta.TotalDeIngresos = 930;
            boleta.TotalDeDescuentos = 30;
            Double sueldoNeto = boleta.CalcularSueldoNeto();
            Double sueldoNeto_esperado = 900;
            Assert.AreEqual(sueldoNeto, sueldoNeto_esperado);
        }
        [TestMethod]
        public void CalcularTotalDescuentoTest()
        {
            Afp afp = new Afp();
            Contrato contrato = new Contrato(afp);
            ConceptoDeIngresoDescuento concepto = new ConceptoDeIngresoDescuento();
            BoletaDePago boleta = new BoletaDePago(contrato, concepto);
            boleta.TotalDeHoras = 160;
            boleta.Contrato.PagoPorHora = 12;
            boleta.ConceptoDeIngresoDescuento.MontoPorHorasAusentes = 20;
            boleta.ConceptoDeIngresoDescuento.MontoDeOtrosDescuentos = 5;
            boleta.ConceptoDeIngresoDescuento.MontoPorAdelantos = 50;
            boleta.Contrato.Afp.PorcentajeAfp = 0.1F;
            int totalDescuento = Convert.ToInt32(boleta.CalcularTotalDescuento( boleta,  concepto));
            int totalDescuentoEsperado = 75;
            Assert.AreEqual(totalDescuento, totalDescuentoEsperado);
        }
        [TestMethod]
        public void CalcularTotalDeHorasTest()
        {
            Contrato contrato = new Contrato();
            PeriodoDePago periodo = new PeriodoDePago();
            BoletaDePago boleta = new BoletaDePago(contrato, periodo);
            boleta.PeriodoDePago.FechaFin =new DateTime(2021,05,31);
            boleta.PeriodoDePago.FechaInicio =new DateTime(2021,05,01);
            boleta.Contrato.HorasSemana = 4;
            Double totaldeHoras = boleta.CalcularTotalDeHoras();
            Double totaldeHorasEsperado = 16;
            Assert.AreEqual(totaldeHoras, totaldeHorasEsperado);
        }
        [TestMethod]
        public void CalcularTotalDeIngresosTest()
        {
            Contrato contrato = new Contrato();
            ConceptoDeIngresoDescuento concepto = new ConceptoDeIngresoDescuento();
            BoletaDePago boleta = new BoletaDePago(contrato, concepto);
            boleta.Contrato.PagoPorHora = 12;
            boleta.TotalDeHoras = 160;
            boleta.Contrato.AsignacionFamiliar = true;
            boleta.ConceptoDeIngresoDescuento.MontoDeOtrosIngresos = 30;
            boleta.ConceptoDeIngresoDescuento.MontoPorHorasExtras = 20;
            boleta.ConceptoDeIngresoDescuento.MontoPorReintegros = 0.1F;
            int totalIngreso = Convert.ToInt32(boleta.CalcularTotalDeIngresos( concepto,  contrato));
            int totalIngresoEsperado = 143;
            Assert.AreEqual(totalIngreso, totalIngresoEsperado);
        }
    }
}
