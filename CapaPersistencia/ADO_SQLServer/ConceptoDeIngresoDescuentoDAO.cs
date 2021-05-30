using CapaDominio.Contratos;
using CapaDominio.Entidades;
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
            this.contratoDAO = (ContratoDAO)gestorSQL;
            this.periodoDePagoDAO = (PeriodoDePagoDAO)periodoDePagoDAO;
        }
        /*
        public List<ConceptoDeIngresoDescuento> listarConceptosDeIngresoDescuento()
        {
            List<ConceptoDeIngresoDescuento> listaDeConceptosIngresoDescuento = new List<ConceptoDeIngresoDescuento>();
            ConceptoDeIngresoDescuento aux;
            string listaDeConceptos = "select montoDeOtrosDescuentos,montoDeOtrosIngresos,montoPorAdelantos,montoPorHorasAusentes,montoPorHorasExtras, montoPorReintegros, codigoConcepto, codigoPeriodo, codigoContrato from conceptodeingresosdescuentos ";//preguntar codigo periodo porque en el sql esta como FK_Codigo
            try
            {
                SqlDataReader resultadoSQL = gestorSQL.ejecutarConsulta(listaDeConceptos);
                while (resultadoSQL.Read())
                {
                    aux = obtenerConceptos(resultadoSQL);
                    listaDeConceptosIngresoDescuento.Add(aux);
                }
            }
            catch(Exception err)
            {
                throw err;
            }
            return listaDeConceptosIngresoDescuento;
        }*/

        private ConceptoDeIngresoDescuento obtenerConceptos(SqlDataReader resultadoSQL)
        {
            ConceptoDeIngresoDescuento conceptoDeIngresosDescuentos = new ConceptoDeIngresoDescuento();

            conceptoDeIngresosDescuentos.MontoDeOtrosDescuentos = float.Parse(resultadoSQL.GetString(0));
            conceptoDeIngresosDescuentos.MontoDeOtrosIngresos = float.Parse(resultadoSQL.GetString(1));
            conceptoDeIngresosDescuentos.MontoPorAdelantos = float.Parse(resultadoSQL.GetString(2));
            conceptoDeIngresosDescuentos.MontoPorHorasAusentes = float.Parse(resultadoSQL.GetString(3));
            conceptoDeIngresosDescuentos.MontoPorHorasExtras = float.Parse(resultadoSQL.GetString(4));
            conceptoDeIngresosDescuentos.MontoPorReintegros = float.Parse(resultadoSQL.GetString(5));
            conceptoDeIngresosDescuentos.CodigoConcepto = int.Parse(resultadoSQL.GetString(6));
            conceptoDeIngresosDescuentos.PeriodoDePago = periodoDePagoDAO.buscarPeriodo(int.Parse(resultadoSQL.GetString(7)));
            conceptoDeIngresosDescuentos.Contrato = contratoDAO.buscarContrato(int.Parse(resultadoSQL.GetString(8)));


            return conceptoDeIngresosDescuentos;

        }

        public ConceptoDeIngresoDescuento buscarConcepto(Contrato contrato, PeriodoDePago periodoDePago)
        {
            ConceptoDeIngresoDescuento concepto = new ConceptoDeIngresoDescuento();
            String consultaSQL = "select montoDeOtrosDescuentos,montoDeOtrosIngresos,montoPorAdelantos,montoPorHorasAusentes,montoPorHorasExtras, montoPorReintegros, codigoConcepto, codigoPeriodo, codigoContrato from conceptodeingresosdescuentos  where conceptodeingresosdescuentos.codigoContrato = '" + contrato.Codigo + "' AND conceptodeingresosdescuentos.codigoPeriodo = '" + periodoDePago.CodigoPeriodo + "';";
            try
            {
                SqlDataReader resultadoSQL = gestorSQL.ejecutarConsulta(consultaSQL);
                if (resultadoSQL.Read())
                {
                    concepto = obtenerConceptos(resultadoSQL);
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

