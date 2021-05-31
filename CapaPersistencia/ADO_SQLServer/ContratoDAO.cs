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
    public class ContratoDAO :IContrato
    {


        private GestorSQL gestorSQL;
        private EmpleadoDAO empleadoDAO;
        private AfpDAO afpDAO;

        public ContratoDAO(IGestorAccesoADatos gestorSQL,IEmpleado empleadoDAO, IAfp afpDAO)// debe ser del tipo interfaz para hacerlo de tipo generico
        {
            this.gestorSQL = (GestorSQL)gestorSQL;// (GestorSQL) el objeto de tipo interfaz se hace un moldeo al tipo original
            this.empleadoDAO = (EmpleadoDAO)empleadoDAO;
            this.afpDAO = (AfpDAO)afpDAO;
        }

        public void crearContrato(Contrato contrato,Empleado empleado,Afp afp)
        {
            string crearContrato = "insert into contrato(asignacionFamiliar, cargo, codigoContrato, fechaInicio, fechaFin, horasSemana, pagoPorHora, estado, dniEmpleado, codigoAfp)" +
                "values(@asignacionFamiliar, @cargo, @codigoContrato, @fechaInicio, @fechaFin, @horasSemana, @pagoPorHora, @estado, @empleado,@afp)";
            try
            {
                SqlCommand comando;

                comando = gestorSQL.obtenerComandoSQL(crearContrato);
                comando.Parameters.AddWithValue("@asignacionFamiliar", contrato.AsignacionFamiliar);
                comando.Parameters.AddWithValue("@cargo", contrato.Cargo);
                comando.Parameters.AddWithValue("@codigoContrato", contrato.Codigo);
                comando.Parameters.AddWithValue("@fechaInicio", contrato.FechaInicio);
                comando.Parameters.AddWithValue("@fechaFin", contrato.FechaFin);
                comando.Parameters.AddWithValue("@horasSemana", contrato.HorasSemana);
                comando.Parameters.AddWithValue("@pagoPorHora", contrato.PagoPorHora);
                comando.Parameters.AddWithValue("@Estado", contrato.Estado);
                comando.Parameters.AddWithValue("@empleado", empleado.Dni);
                comando.Parameters.AddWithValue("@afp", afp.CodigoAfp);

                comando.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public List<Contrato> listarContrato(string estado)
        {
            List<Contrato> listaDeContratos = new List<Contrato>();
            Contrato contrato;
            string consultaSQL;
            consultaSQL = "select codigoContrato, cargo,pagoPorHora,horasSemana,estado,fechaInicio,fechaFin,asignacionFamiliar, codigoafp, dniEmpleado from Contrato where estado like '%" + estado + "%' order by cargo";
            try
            {
                SqlDataReader resultadoSQL = gestorSQL.ejecutarConsulta(consultaSQL);
                while (resultadoSQL.Read())
                {
                    contrato = obtenerContrato(resultadoSQL);
                    listaDeContratos.Add(contrato);
                }
            }
            catch (Exception err)
            {
                throw err;
            }
            return listaDeContratos;
        }

        public Contrato buscarUltimoContrato(string dni)
        {
            Contrato contrato = null;
            string consultaSQL = "select TOP 1 codigoContrato, cargo,pagoPorHora,horasSemana,estado,fechaInicio,fechaFin,asignacionFamiliar, codigoafp, dniEmpleado from Contrato where dniEmpleado = '" + dni + "'";
            try
            {
                SqlDataReader resultadoSQL = gestorSQL.ejecutarConsulta(consultaSQL);
                if (resultadoSQL.Read())
                {
                    contrato = obtenerContrato(resultadoSQL);
                }
                else
                {
                    throw new Exception("No existe el Contrato.");

                }
            }
            catch (Exception err)
            {
                throw err;
            }
            return contrato;
        }

        public Contrato buscarContrato(int dni)
        {
            Contrato contrato;
            string storeProcedureSql = "sp_contrato_getdni";
            try
            {
                SqlCommand command;
                command = gestorSQL.obtenerComandoDeProcedimiento(storeProcedureSql);
                command.Parameters.AddWithValue("@dni", dni);
                SqlDataReader resultSql = command.ExecuteReader();
                if (resultSql.Read())
                {
                    contrato = obtenerContrato(resultSql);
                }
                else
                {
                    throw new Exception("No existe el Contrato.");
                }
            }
            catch (Exception err)
            {
                throw err;
            }
            return contrato;
        }

        private Contrato obtenerContrato(SqlDataReader resultadoSQL)
        {
            //revisar el orden en sql como manda las consultas
            Contrato contrato = new Contrato
            {
                Codigo = resultadoSQL.GetColumnValue<int>("codigoContrato"),
                Cargo = resultadoSQL.GetColumnValue<String>("cargo"),
                PagoPorHora = resultadoSQL.GetColumnValue<double>("pagoPorHora"),
                HorasSemana = resultadoSQL.GetColumnValue<int>("horasSemana"),
                Estado = resultadoSQL.GetColumnValue<Boolean>("estado"),
                FechaInicio = resultadoSQL.GetColumnValue<DateTime>("fechaInicio"),
                FechaFin = resultadoSQL.GetColumnValue<DateTime>("fechaFin"),
                AsignacionFamiliar = resultadoSQL.GetColumnValue<Boolean>("asignacionFamiliar")
            };
            
            return contrato;
        }

        public void editarContrato(Contrato contrato)
        {
            //**********************************************************************************
            SqlCommand comando;
            string consultaSQL = "update Contrato  set cargo= @cargo, pagoPorHora=@pagoPorHora, horasSemana=@horasSemana, codigoafp=@codigoafp" +
                "fechaInicio=@fechaInicio, fechaFin=@fechaFin, asignacionFamiliar=@asignacionFamiliar where codigoContrato='" + contrato.Codigo + "'";

            try
            {
                comando = gestorSQL.obtenerComandoSQL(consultaSQL);
                comando.Parameters.AddWithValue("@cargo", contrato.Cargo);
                comando.Parameters.AddWithValue("@pagoPorHora", contrato.PagoPorHora);
                comando.Parameters.AddWithValue("@horasSemana", contrato.HorasSemana);
                comando.Parameters.AddWithValue("@fechaInicio", contrato.FechaInicio);
                comando.Parameters.AddWithValue("@fechaFin", contrato.FechaFin);
                comando.Parameters.AddWithValue("@codigoafp", contrato.Afp.CodigoAfp);
                comando.Parameters.AddWithValue("@asignacionFamiliar", Convert.ToInt32(contrato.AsignacionFamiliar));

                comando.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw err;
            }

        }

        public void anularContrato(Contrato contrato)
        {
            //**********************************************************************************
            SqlCommand comando;
            string consultaSQL = "update Contrato  set estado= @estado where codigoContrato='" + contrato.Codigo + "'";

            try
            {
                comando = gestorSQL.obtenerComandoSQL(consultaSQL);
                comando.Parameters.AddWithValue("@estado", Convert.ToInt32(contrato.Estado));

                comando.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw err;
            }

        }
    }
}

