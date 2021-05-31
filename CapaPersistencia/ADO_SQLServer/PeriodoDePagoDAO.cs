using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDominio.Entidades;
using CapaDominio.Contratos;
using CapaDominio.Libreria;

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
            PeriodoDePago periodoDePago = new PeriodoDePago {
                CodigoPeriodo = resultadoSQL.GetColumnValue<int>("codigoPeriodo"),
                Estado = resultadoSQL.GetColumnValue<Boolean>("estado"),
                FechaFin = resultadoSQL.GetColumnValue<DateTime>("fechaFin"),
                FechaInicio = resultadoSQL.GetColumnValue<DateTime>("fechaInicio")
            };
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
        public PeriodoDePago buscarPeriodoActivo(Boolean estado)
        {
            PeriodoDePago periodoDePago;

            String consultaSQL = "select codigoPeriodo,estado,fechaFin,fechaInicio from PeriodoPago where estado='" + estado + "';";//preguntar semanas del periodo
            try
            {
                SqlDataReader resultadoSQL = gestorSQL.ejecutarConsulta(consultaSQL);
                if (resultadoSQL.Read())
                {
                    periodoDePago = obtenerPeriodo(resultadoSQL);
                }
                else
                {
                    throw new Exception("No existe Periodo Activo");
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

