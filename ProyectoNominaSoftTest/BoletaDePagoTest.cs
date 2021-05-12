using CapaDominio.Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ProyectoNominaSoftTest
{
    [TestClass]
    public class BoletaDePagoTest
    {
        [TestMethod]
        public void CalcularAsignacionFamiliarTest()
        {
            Contrato contrato = new Contrato();
            PeriodoDePago periodo = new PeriodoDePago();
            BoletaDePago boleta = new BoletaDePago(contrato, periodo);
            boleta.Contrato.AsignacionFamiliar = true;
            Double asignacionFam = boleta.CalcularAsignacionFamiliar();
            Double asignacionFamiliar_esperado = 93;
            Assert.AreEqual(asignacionFam, asignacionFamiliar_esperado);
        }
        [TestMethod]
        public void CalcularSueldoBasicoTest()
        {
            Contrato contrato = new Contrato();
            //PeriodoDePago periodo = new PeriodoDePago();
            BoletaDePago boleta = new BoletaDePago(contrato);
            boleta.TotalDeHoras = 40;
            boleta.Contrato.PagoPorHora = 5;
            Double sueldo = boleta.CalcularSueldoBasico();
            Double sueldo_esperado = 200;
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
            boleta.TotalDeHoras = 48;
            boleta.Contrato.PagoPorHora = 10;
            boleta.ConceptoDeIngresoDescuento.MontoPorHorasAusentes = 3;
            boleta.ConceptoDeIngresoDescuento.MontoDeOtrosDescuentos = 1;
            boleta.ConceptoDeIngresoDescuento.MontoPorAdelantos = 1;
            boleta.Contrato.Afp.PorcentajeAfp = 10;
            Double totalDescuento = boleta.CalcularTotalDescuento();
            Double totalDescuentoEsperado = 53;
            Assert.AreEqual(totalDescuento, totalDescuentoEsperado);
        }
        [TestMethod]
        public void CalcularTotalDeHorasTest()
        {
            Contrato contrato = new Contrato();
            PeriodoDePago periodo = new PeriodoDePago();
            BoletaDePago boleta = new BoletaDePago(contrato, periodo);
            boleta.PeriodoDePago.SemanasDelPeriodo = 5;
            boleta.Contrato.HorasSemana = 4;
            Double totaldeHoras = boleta.CalcularTotalDeHoras();
            Double totaldeHorasEsperado = 20;
            Assert.AreEqual(totaldeHoras, totaldeHorasEsperado);
        }
        [TestMethod]
        public void CalcularTotalDeIngresosTest()
        {
            Contrato contrato = new Contrato();
            ConceptoDeIngresoDescuento concepto = new ConceptoDeIngresoDescuento();
            BoletaDePago boleta = new BoletaDePago(contrato, concepto);
            boleta.Contrato.PagoPorHora = 10;
            boleta.TotalDeHoras = 48;
            boleta.AsignacionFamiliar = 85;
            boleta.ConceptoDeIngresoDescuento.MontoDeOtrosIngresos = 10;
            boleta.ConceptoDeIngresoDescuento.MontoPorHorasExtras = 10;
            boleta.ConceptoDeIngresoDescuento.MontoPorReintegros = 10;
            Double totalIngreso = boleta.CalcularTotalDeIngresos();
            Double totalIngresoEsperado = 595;
            Assert.AreEqual(totalIngreso, totalIngresoEsperado);
        }
    }
}
