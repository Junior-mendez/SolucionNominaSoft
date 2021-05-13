using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CapaDominio.Entidades;

namespace ProyectoNominaSoftTest
{
    [TestClass]
    public class ContratoTest
    {
        [TestMethod]
        public void ValidarValorPorHoraTest()
        {
            Contrato contrato = new Contrato();
            contrato.PagoPorHora = 11;
            Boolean validezPago = contrato.ValidarValorPorHora();
            Boolean validezPago_esperado = true;
            Assert.AreEqual(validezPago, validezPago_esperado);
        }
        [TestMethod]
        public void CalcularDescuentosAfpTest()
        {
            Afp afp = new Afp();
            Contrato contrato = new Contrato(afp);
            Double sueldoBasico = 850;
            contrato.Afp.PorcentajeAfp = 13;
            Double descuentoAfp = contrato.CalcularDescuentosAfp(sueldoBasico);
            Double descuentoAfp_esperado = 110.5;
            Assert.AreEqual(descuentoAfp, descuentoAfp_esperado);
        }
        [TestMethod]
        public void ValidarHorasSemanalesTest()
        {
            Contrato contrato = new Contrato();
            contrato.HorasSemana = 12;
            Boolean validezHoraSemanal = contrato.ValidarHorasSemanales();
            Boolean validezHoraSemanal_esperado = true;
            Assert.AreEqual(validezHoraSemanal, validezHoraSemanal_esperado);
        }
        [TestMethod]
        public void ValidarVigenciaDeContratoTest()
        {
            Contrato contrato = new Contrato();
            //contrato.FechaFin = Convert.ToDateTime("23/05/2021");
            contrato.FechaFin = new  DateTime(2021,05,14);
            contrato.Estado = true;
            Boolean validezVigencia = contrato.ValidarVigenciaDeContrato();
            Boolean validezVigencia_esperado = true;
            Assert.AreEqual(validezVigencia, validezVigencia_esperado);
        }
        [TestMethod]
        public void VerificarContratoAnteriorTest()
        {
            Contrato anterior = new Contrato();
            Contrato contrato = new Contrato();
            contrato.FechaInicio= new DateTime(2021, 05, 14);
            anterior.FechaFin= new DateTime(2021, 05, 13);
            Boolean verificaContratoAnterior = contrato.VerificarContratoAnterior(anterior);
            Boolean verificaContratoAnterior_esperdo = true;
            Assert.AreEqual(verificaContratoAnterior, verificaContratoAnterior_esperdo);
        }
        [TestMethod]
        public void VerfificarFechaFinTest()
        {
            Contrato contrato = new Contrato();
            contrato.FechaFin= new DateTime(2021, 12, 14);
            contrato.FechaInicio = new DateTime(2021, 05, 14);
            Boolean verificaFechaFin = contrato.VerfificarFechaFin();
            Boolean verificaFechaFin_esperado = true;
            Assert.AreEqual(verificaFechaFin, verificaFechaFin_esperado);
        }
    }
}
