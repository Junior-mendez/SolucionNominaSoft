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
        public AfpDAO(IGestorAccesoADatos gestorSQL)
        {
            this.gestorSQL = (GestorSQL)gestorSQL; 
        }

       

        public Afp buscarPorCodigo(string nombre)
        {
            Afp afp;
            string storeProcedureSql = "sp_contrato_getafp";
            try
            {
                SqlCommand command;
                command = gestorSQL.obtenerComandoDeProcedimiento(storeProcedureSql);
                command.Parameters.AddWithValue("@nombre", nombre);
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

