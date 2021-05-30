using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDominio.Entidades;
using CapaDominio.Contratos;

namespace CapaPersistencia.ADO_SQLServer
{
    public class PeriodoDePagoDAO:IPeriodo
    {
        private GestorSQL gestorSQL;

        public PeriodoDePagoDAO(IGestorAccesoADatos gestorSQL)// debe ser del tipo interfaz para hacerlo de tipo generico
        {
            this.gestorSQL = (GestorSQL)gestorSQL; // (GestorSQL) el objeto de tipo interfaz se hace un moldeo al tipo original
        }

        public void actualizarPeriodo(PeriodoDePago periodoDePago)
        {
            String consultaSQL = "update PeriodoDePago set estado = 'false' where PeriodoPago.codigoPeriodo = '" + periodoDePago.CodigoPeriodo + "';";
            try
            {
                SqlDataReader resultadoSQL = gestorSQL.ejecutarConsulta(consultaSQL);
                if (resultadoSQL.Read())
                {
                    periodoDePago = obtenerPeriodo(resultadoSQL);
                }
                else
                {
                    throw new Exception("No existe el Periodo de Pago");
                }
            }
            catch (Exception err)
            {
                throw err;
            }
        }
        private PeriodoDePago obtenerPeriodo(SqlDataReader resultadoSQL)
        {
            PeriodoDePago periodoDePago = new PeriodoDePago();
            periodoDePago.CodigoPeriodo = int.Parse(resultadoSQL.GetString(0));
            periodoDePago.Estado = resultadoSQL.GetBoolean(1);
            periodoDePago.FechaFin = resultadoSQL.GetDateTime(2);
            periodoDePago.FechaInicio = resultadoSQL.GetDateTime(3);
            periodoDePago.SemanasDelPeriodo = resultadoSQL.GetInt32(3);
            return periodoDePago;
        }


        public PeriodoDePago buscarPeriodo(int codigoPeriodo)
        {
            PeriodoDePago periodoDePago;

            String consultaSQL = "select codigoPeriodo,estado,fechaFin,fechaInicio,semanasDelPeriodo from PeriodoDePago where PeriodoDePago.codigoPeriodo = '" + codigoPeriodo + "';";//preguntar semanas del periodo
            try
            {
                SqlDataReader resultadoSQL = gestorSQL.ejecutarConsulta(consultaSQL);
                if (resultadoSQL.Read())
                {
                    periodoDePago = obtenerPeriodo(resultadoSQL);
                }
                else
                {
                    throw new Exception("No existe el Periodo");
                }
            }
            catch (Exception err)
            {
                throw err;
            }
            return periodoDePago;
        }



        public PeriodoDePago buscarPeriodoFecha(DateTime fechaInicio, DateTime fechaFin)
        {
            PeriodoDePago periodoDePago;

            String consultaSQL = "select fechaFin,fechaInicio,estado,codigoPeriodo from PeriodoDePago where PeriodoDePago.fechaInicio = '" + fechaInicio + "'and PeridoDePago.fechaFin = '" + fechaFin + "';";//preguntar semanas del periodo
            try
            {
                SqlDataReader resultadoSQL = gestorSQL.ejecutarConsulta(consultaSQL);
                if (resultadoSQL.Read())
                {
                    periodoDePago = obtenerPeriodo(resultadoSQL);
                }
                else
                {
                    throw new Exception("No existe el Periodo");
                }
            }
            catch (Exception err)
            {
                return null;
            }
            return periodoDePago;
        }







    }
}

