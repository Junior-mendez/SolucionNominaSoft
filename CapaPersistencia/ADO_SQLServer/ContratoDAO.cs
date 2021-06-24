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
            string crearContrato = "insert into contrato(asignacionFamiliar, cargo, fechaInicio, fechaFin, horasSemana, pagoPorHora, estado, dniEmpleado, codigoAfp)" +
                "values(@asignacionFamiliar, @cargo, @fechaInicio, @fechaFin, @horasSemana, @pagoPorHora, @estado, @empleado,@afp)";
            try
            {
                SqlCommand comando;

                comando = gestorSQL.obtenerComandoSQL(crearContrato);
                comando.Parameters.AddWithValue("@asignacionFamiliar", contrato.AsignacionFamiliar);
                comando.Parameters.AddWithValue("@cargo", contrato.Cargo);
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

        public List<Contrato> listarContrato(string estado,DateTime fechaInicio, DateTime fechaFin)
        {
            List<Contrato> listaDeContratos = new List<Contrato>();
            Contrato contrato;
            
            string storeProcedureSql = "sp_getContrato";
            
            try
            {
                SqlCommand command;
                command = gestorSQL.obtenerComandoDeProcedimiento(storeProcedureSql);
                command.Parameters.AddWithValue("@estado", estado);
                command.Parameters.AddWithValue("@fechaIni", fechaInicio);
                command.Parameters.AddWithValue("@fechaFin", fechaFin);
                SqlDataReader resultSql = command.ExecuteReader();
                while (resultSql.Read()) 
                {
                    contrato = obtenerContrato(resultSql);
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
            Afp afp = new Afp();
            Contrato contrato = new Contrato(afp);
            string storeProcedureSQL = "sp_getContratoUltimo";
            try
            {
                SqlCommand command;
                command = gestorSQL.obtenerComandoDeProcedimiento(storeProcedureSQL);
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
            catch (Exception )
            {
                throw ;
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
            Afp afp = new Afp();
            Empleado empleado = new Empleado();
            Contrato contrato = new Contrato( afp, empleado);

            contrato.Codigo = resultadoSQL.GetColumnValue<int>("codigoContrato");
            contrato.Cargo = resultadoSQL.GetColumnValue<String>("cargo");
            contrato.PagoPorHora = resultadoSQL.GetColumnValue<double>("pagoPorHora");
            contrato.HorasSemana = resultadoSQL.GetColumnValue<int>("horasSemana");
            contrato.Estado = resultadoSQL.GetColumnValue<Boolean>("estado");
            contrato.FechaInicio = resultadoSQL.GetColumnValue<DateTime>("fechaInicio");
            contrato.FechaFin = resultadoSQL.GetColumnValue<DateTime>("fechaFin");
            contrato.AsignacionFamiliar = resultadoSQL.GetColumnValue<Boolean>("asignacionFamiliar");
            afp.CodigoAfp = resultadoSQL.GetColumnValue<int>("codigoafp");
            afp.NombreAfp = resultadoSQL.GetColumnValue<String>("nombreAfp");
            afp.PorcentajeAfp = resultadoSQL.GetColumnValue<float>("porcentajeAfp");
            empleado.Dni = resultadoSQL.GetColumnValue<String>("dniEmpleado");
            empleado.Nombre = resultadoSQL.GetColumnValue<String>("nombre");
            return contrato;
        }

        public void editarContrato(Contrato contrato)
        {
            int codigo = contrato.Codigo;
            string cargo = contrato.Cargo;
            double pago = contrato.PagoPorHora;
            int horas = contrato.HorasSemana;
            DateTime fechaIni = contrato.FechaInicio;
            DateTime fechaFin = contrato.FechaFin;
            int codigoAfp = contrato.Afp.CodigoAfp;
            Boolean asigFam = contrato.AsignacionFamiliar;
            //**********************************************************************************
            SqlCommand comando;
            string consultaSQL = "update Contrato  set cargo= @cargo, pagoPorHora=@pagoPorHora, horasSemana=@horasSemana, codigoafp=@codigoAfp," +
                "fechaInicio=@fechaInicio, fechaFin=@fechaFin, asignacionFamiliar=@asignacionFamiliar where codigoContrato='" + codigo + "'";

            try
            {
                comando = gestorSQL.obtenerComandoSQL(consultaSQL);
                comando.Parameters.AddWithValue("@cargo", cargo);
                comando.Parameters.AddWithValue("@pagoPorHora", pago);
                comando.Parameters.AddWithValue("@horasSemana", horas);
                comando.Parameters.AddWithValue("@fechaInicio", fechaIni);
                comando.Parameters.AddWithValue("@fechaFin", fechaFin);
                comando.Parameters.AddWithValue("@codigoAfp", codigoAfp);
                comando.Parameters.AddWithValue("@asignacionFamiliar", asigFam);

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
          
            string consultaSQL = "update Contrato  set estado= @estad where codigoContrato='" + contrato.Codigo + "'";

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

