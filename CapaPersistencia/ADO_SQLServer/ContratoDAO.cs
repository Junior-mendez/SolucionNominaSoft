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
            string consultaSQL;
            consultaSQL = "SELECT codigoContrato,cargo,pagoPorHora,horasSemana,estado,fechaInicio,fechaFin,asignacionFamiliar,c.codigoafp,dniEmpleado,a.porcentajeAfp,a.nombreAfp FROM Contrato c inner join Afp a on c.codigoAfp=a.codigoAfp WHERE estado like '%" + estado + "%' and c.fechaInicio<='"+fechaInicio+ "' and c.fechaFin>='"+fechaFin+"'  order by cargo";
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
            Afp afp = new Afp();
            Contrato contrato = new Contrato(afp);
            string consultaSQL = "select TOP 1 codigoContrato, cargo,pagoPorHora,horasSemana,estado,fechaInicio,fechaFin,asignacionFamiliar, c.codigoafp, dniEmpleado,a.nombreAfp,a.porcentajeAfp from Contrato c inner join Afp a on a.codigoAfp=c.codigoAfp where dniEmpleado= '" + dni + "'";
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
            Afp afp = new Afp();
            Contrato contrato = new Contrato( afp);

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

            return contrato;
        }

        public void editarContrato(int codigo,string cargo, double pago, int horas, DateTime fechaIni, DateTime fechaFin,int codigoAfp,Boolean asigFam)
        {
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

