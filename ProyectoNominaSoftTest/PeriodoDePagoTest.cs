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
            periodo.FechaFin = new DateTime(2021, 05, 13);
            Boolean verificaPeriodo = periodo.VerificarPeriodoDePago();
            Boolean verificaPeriodo_esperado = true;
            Assert.AreEqual(verificaPeriodo, verificaPeriodo_esperado);
        }
    }
}
