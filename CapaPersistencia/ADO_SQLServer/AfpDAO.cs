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
    public class AfpDAO :IAfp
    {
        private GestorSQL gestorSQL;
        public AfpDAO(IGestorAccesoADatos gestorSQL)// debe ser del tipo interfaz para hacerlo de tipo generico
        {
            this.gestorSQL = (GestorSQL)gestorSQL; // (GestorSQL) el objeto de tipo interfaz se hace un moldeo al tipo original
        }

        /*public List<Afp> buscar(string nombreAfp)
        {
            List<Afp> listaDeAfp = new List<Afp>();
            Afp afp;
            string consultaSQL = "select codigoAfp, nombreAfp, porcentajeAfp from Afp where  nombreAfp like '%" + nombreAfp + "%' order by  nombreAfp";
            try
            {
                SqlDataReader resultadoSQL = gestorSQL.ejecutarConsulta(consultaSQL);
                while (resultadoSQL.Read())
                {
                    afp = obtenerAfp(resultadoSQL);
                    listaDeAfp.Add(afp);
                }
            }
            catch (Exception err)
            {
                throw err;
            }
            return listaDeAfp;
        }*/

        public Afp buscarPorCodigo(int codigoAfp)
        {
            Afp afp;
            string storeProcedureSql = "sp_contrato_getafp";
            try
            {
                SqlCommand command;
                command = gestorSQL.obtenerComandoDeProcedimiento(storeProcedureSql);
                command.Parameters.AddWithValue("@codigoAfp", codigoAfp);
                SqlDataReader resultSql = command.ExecuteReader();
                if (resultSql.Read())
                {
                    afp = obtenerAfp(resultSql);
                }
                else
                {
                    throw new Exception("No esta registrada esta Afp.");
                }
            }
            catch (Exception err)
            {
                throw err;
            }
            return afp;
        }

        private Afp obtenerAfp(SqlDataReader resultadoSQL)
        {
            Afp afp = new Afp()
            {
                CodigoAfp = resultadoSQL.GetColumnValue<int>("codigoAfp"),
                NombreAfp = resultadoSQL.GetColumnValue<String>("nombreAfp"),
                PorcentajeAfp = resultadoSQL.GetColumnValue<float>("porcentajeAfp")
            };
            return afp;
        }




    }
}

