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
            PeriodoDePago periodo = new PeriodoDePago();
            BoletaDePago boleta = new BoletaDePago( contrato,periodo);
            boleta.TotalDeHoras = 40;
            boleta.Contrato.PagoPorHora = 5;
            Double sueldo = boleta.CalcularSueldoBasico();
            Double sueldo_esperado = 200;
            Assert.AreEqual(sueldo, sueldo_esperado);
        }
        [TestMethod]
        public void CalcularSueldoNetoTest()
        {
            Contrato contrato = new Contrato();
            PeriodoDePago periodo = new PeriodoDePago();
            BoletaDePago boleta = new BoletaDePago(contrato, periodo);
            boleta.TotalDeIngresos = 930;
            boleta.TotalDeDescuentos = 30;
            Double sueldoNeto = boleta.CalcularSueldoNeto();
            Double sueldoNeto_esperado = 900;
            Assert.AreEqual(sueldoNeto, sueldoNeto_esperado);
        }
    }
}
