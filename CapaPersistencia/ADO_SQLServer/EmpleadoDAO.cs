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
    public class EmpleadoDAO :IEmpleado
    {
        private GestorSQL gestorSQL;

        public EmpleadoDAO(IGestorAccesoADatos gestorSQL) // debe ser del tipo interfaz para hacerlo de tipo generico
        {
            this.gestorSQL = (GestorSQL)gestorSQL;// (GestorSQL) el objeto de tipo interfaz se hace un moldeo al tipo original
        }

        public Empleado buscarPorDni(string dni)
        {
            Empleado empleado;
            string storeProcedureSql = "sp_empleado_getdni";
            try
            {
                SqlCommand command;
                if (!string.IsNullOrEmpty(dni))
                {
                    command = gestorSQL.obtenerComandoDeProcedimiento(storeProcedureSql);
                    command.Parameters.AddWithValue("@dni", dni);
                    SqlDataReader resultSql = command.ExecuteReader();
                    if (resultSql.Read())
                    {
                        empleado = obtenerEmpleado(resultSql);
                    }
                    else
                    {
                        throw new Exception("No existe empleado.");
                    }
                }
                else
                {
                    throw new Exception("El Dni no puede estar en blanco");
                }
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return empleado;
        }

        private Empleado obtenerEmpleado(SqlDataReader resultadoSQL)
        {
            Empleado empleado = new Empleado {
            Direccion = resultadoSQL.GetColumnValue<String>("direccion"),
            Dni = resultadoSQL.GetColumnValue<String>("dni"),
            EstadoCivil = resultadoSQL.GetColumnValue<String>("estadoCivil"),
            GradoAcademico = resultadoSQL.GetColumnValue<String>("gradoAcademico"),
            FechaNacimiento = resultadoSQL.GetColumnValue<DateTime>("fechaNacimiento"),
            Nombre = resultadoSQL.GetColumnValue<String>("nombre"),
            Telefono = resultadoSQL.GetColumnValue<String>("telefono")
            };
            return empleado;
        }


    }
}
