using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CapaDominio.Entidades;

namespace ProyectoNominaSoftTest
{
    [TestClass]
    public class PeriodoDePagoTest
    {

        [TestMethod]
        public void VerificarPeriodoDePago()
        {
            PeriodoDePago periodo = new PeriodoDePago();
            periodo.FechaFin = new DateTime(2021, 05, 15);
            Boolean verificaPeriodo = periodo.VerificarPeriodoDePago();
            Boolean verificaPeriodo_esperado = true;
            Assert.AreEqual(verificaPeriodo, verificaPeriodo_esperado);
        }
        [TestMethod]
        public void CalcularSemanasPeriodoTest()
        {
            PeriodoDePago periodo = new PeriodoDePago();
            periodo.FechaFin = new DateTime(2021, 05, 15);
            periodo.FechaInicio = new DateTime(2021, 05, 01);
            Double semanasPeriodo = periodo.CalcularSemanasPeriodo();
            Double semanasPeriodo_esperado = 2;
            Assert.AreEqual(semanasPeriodo, semanasPeriodo_esperado);
        }
    }
}
