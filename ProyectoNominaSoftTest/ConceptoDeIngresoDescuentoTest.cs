using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CapaDominio.Entidades;

namespace ProyectoNominaSoftTest
{

    [TestClass]
    public class ConceptoDeIngresoDescuentoTest
    {
        [TestMethod]
        public void CalcularConceptoIngresoTest()
        {
            ConceptoDeIngresoDescuento concepto = new ConceptoDeIngresoDescuento();
            concepto.MontoPorHorasExtras =50;
            concepto.MontoPorReintegros = 10;
            concepto.MontoDeOtrosIngresos = 5;
            Double conceptoIngreso = concepto.CalcularConceptoIngreso();
            Double conceptoIngreso_esperado = 65;
            Assert.AreEqual(conceptoIngreso, conceptoIngreso_esperado);
        }
        [TestMethod]
        public void CalcularConceptoDescuentoTest()
        {
            ConceptoDeIngresoDescuento concepto = new ConceptoDeIngresoDescuento();
            concepto.MontoDeOtrosDescuentos = 30;
            concepto.MontoPorHorasAusentes = 10;
            concepto.MontoPorAdelantos = 5;
            Double conceptoDescuento = concepto.CalcularConceptoDescuento();
            Double conceptoDescuento_esperado = 45;
            Assert.AreEqual(conceptoDescuento, conceptoDescuento_esperado);
        }
    }
}
