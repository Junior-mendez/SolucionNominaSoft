using CapaDominio.Contratos;
using CapaDominio.Entidades;
using CapaDominio.Libreria;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPersistencia.ADO_SQLServer
{
    public class ConceptoDeIngresoDescuentoDAO :IConcepto
    {
        private PeriodoDePagoDAO periodoDePagoDAO;
        private ContratoDAO contratoDAO;
        private GestorSQL gestorSQL;

        public ConceptoDeIngresoDescuentoDAO(IGestorAccesoADatos gestorSQL, IPeriodo periodoDePagoDAO, IContrato contratoDAO)// debe ser del tipo interfaz para hacerlo de tipo generico
        {
            this.gestorSQL = (GestorSQL)gestorSQL; // (GestorSQL) el objeto de tipo interfaz se hace un moldeo al tipo original
            this.contratoDAO = (ContratoDAO)contratoDAO;
            this.periodoDePagoDAO = (PeriodoDePagoDAO)periodoDePagoDAO;
        }
        

        private ConceptoDeIngresoDescuento obtenerConceptos(SqlDataReader resultadoSQL,PeriodoDePago periodo)
        {
            ConceptoDeIngresoDescuento conceptoDeIngresosDescuentos = new ConceptoDeIngresoDescuento(periodo);

            conceptoDeIngresosDescuentos.MontoDeOtrosDescuentos = resultadoSQL.GetColumnValue<Double>("montoDeOtrosDescuentos");
            conceptoDeIngresosDescuentos.MontoDeOtrosIngresos = resultadoSQL.GetColumnValue<Double>("montoDeOtrosIngresos");
            conceptoDeIngresosDescuentos.MontoPorAdelantos = resultadoSQL.GetColumnValue<Double>("montoPorAdelantos");
            conceptoDeIngresosDescuentos.MontoPorHorasAusentes = resultadoSQL.GetColumnValue<Double>("montoPorHorasAusentes");
            conceptoDeIngresosDescuentos.MontoPorHorasExtras = resultadoSQL.GetColumnValue<Double>("montoPorHorasExtra");
            conceptoDeIngresosDescuentos.MontoPorReintegros = resultadoSQL.GetColumnValue<Double>("montoPorReintegros");
            conceptoDeIngresosDescuentos.CodigoConcepto = resultadoSQL.GetColumnValue<int>("codigoConcepto");
            periodo.CodigoPeriodo = resultadoSQL.GetColumnValue<int>("codigoPeriodo");
            return conceptoDeIngresosDescuentos;
        }

        public ConceptoDeIngresoDescuento buscarConcepto(Contrato contrato, PeriodoDePago periodoDePago)
        {
            ConceptoDeIngresoDescuento concepto = new ConceptoDeIngresoDescuento(periodoDePago);
            String consultaSQL = "select montoDeOtrosDescuentos,montoDeOtrosIngresos,montoPorAdelantos,montoPorHorasAusentes,montoPorHorasExtra, montoPorReintegros, codigoConcepto, codigoPeriodo,codigoContrato from ConceptoDeIngresoYDescuento  where codigoContrato = '" + contrato.Codigo + "' AND codigoPeriodo = '" + periodoDePago.CodigoPeriodo + "';";
            try
            {
                SqlDataReader resultadoSQL = gestorSQL.ejecutarConsulta(consultaSQL);
                if (resultadoSQL.Read())
                {
                    concepto = obtenerConceptos(resultadoSQL,periodoDePago);
                }
                else
                {
                    throw new Exception("No existe el Empleado");
                }
            }
            catch (Exception err)
            {
                throw err;
            }
            return concepto;
        }
    }
}

