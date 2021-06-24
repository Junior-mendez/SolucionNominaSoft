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
    public class BoletaDePagoDAO :IBoleta
    {
        private GestorSQL gestorSQL;
        //private ContratoDAO _contratoDao;
        //private PeriodoDePagoDAO _periodoDePagoDAO;
        //private ConceptoDeIngresoDescuentoDAO conceptoDeIngresoDescuentoDAO;
        //private EmpleadoDAO empleadoDAO;

        public BoletaDePagoDAO(IGestorAccesoADatos gestorSQL)// debe ser del tipo interfaz para hacerlo de tipo generico
        {
            this.gestorSQL = (GestorSQL)gestorSQL; // (GestorSQL) el objeto de tipo interfaz se hace un moldeo al tipo original
            
        }
       

        public void guardarBoleta(BoletaDePago boleta)
        {
            string sqlProcedure = "sp_guardar_boletapago";
            try
            {
                SqlCommand comando = gestorSQL.obtenerComandoDeProcedimiento(sqlProcedure);
                comando.Parameters.AddWithValue("@asignacionFamiliar", boleta.AsignacionFamiliar);
                comando.Parameters.AddWithValue("@fechaDeEmision", boleta.FechaDeEmision);
                comando.Parameters.AddWithValue("@sueldoBasico", boleta.SueldoBasico);
                comando.Parameters.AddWithValue("@sueldoNeto", boleta.SueldoNeto);
                comando.Parameters.AddWithValue("@afp", boleta.DescuentoAfp);
                comando.Parameters.AddWithValue("@totalDeHoras", boleta.TotalDeHoras);
                comando.Parameters.AddWithValue("@totalDeDescuentos", boleta.TotalDeDescuentos);
                comando.Parameters.AddWithValue("@totalDeIngresos", boleta.TotalDeIngresos);
                comando.Parameters.AddWithValue("@codigoContrato", boleta.Contrato.Codigo);
                comando.Parameters.AddWithValue("@idConceptoDeIngresoDescuento", boleta.ConceptoDeIngresoDescuento.CodigoConcepto);//no tiene codigo
                comando.Parameters.AddWithValue("@idPeriodoDePago", boleta.PeriodoDePago.CodigoPeriodo);//no tiene codigo
              
                comando.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw err;
            }

        }
       

    }
}

