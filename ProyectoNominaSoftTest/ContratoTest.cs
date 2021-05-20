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
            contrato.PagoPorHora = 12;
            Boolean validezPago = contrato.ValidarValorPorHora();
            Boolean validezPago_esperado = true;
            Assert.AreEqual(validezPago, validezPago_esperado);
        }
        [TestMethod]
        public void CalcularAsignacionFamiliarTest()
        {
            Contrato contrato = new Contrato();
            contrato.AsignacionFamiliar = true;
            Double asignacionFam = contrato.CalcularAsignacionFamiliar();
            Double asignacionFamiliar_esperado = 93;
            Assert.AreEqual(asignacionFam, asignacionFamiliar_esperado);
        }
        [TestMethod]
        public void ValidarHorasSemanalesTest()
        {
            Contrato contrato = new Contrato();
            contrato.HorasSemana = 40;
            Boolean validezHoraSemanal = contrato.ValidarHorasSemanales();
            Boolean validezHoraSemanal_esperado = true;
            Assert.AreEqual(validezHoraSemanal, validezHoraSemanal_esperado);
        }
        [TestMethod]
        public void ValidarVigenciaDeContratoTest()
        {
            Contrato contrato = new Contrato();
            //contrato.FechaFin = Convert.ToDateTime("23/05/2021");
            contrato.FechaFin = new  DateTime(2021,07,31);
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
            contrato.FechaInicio= new DateTime(2021, 05, 01);
            anterior.FechaFin= new DateTime(2021, 03, 31);
            Boolean verificaContratoAnterior = contrato.VerificarContratoAnterior(anterior);
            Boolean verificaContratoAnterior_esperdo = true;
            Assert.AreEqual(verificaContratoAnterior, verificaContratoAnterior_esperdo);
        }
        [TestMethod]
        public void VerfificarFechaFinTest()
        {
            Contrato contrato = new Contrato();
            contrato.FechaFin= new DateTime(2021, 08, 01);
            contrato.FechaInicio = new DateTime(2021, 05, 01);
            Boolean verificaFechaFin = contrato.VerfificarFechaFin();
            Boolean verificaFechaFin_esperado = true;
            Assert.AreEqual(verificaFechaFin, verificaFechaFin_esperado);
        }
    }
}
