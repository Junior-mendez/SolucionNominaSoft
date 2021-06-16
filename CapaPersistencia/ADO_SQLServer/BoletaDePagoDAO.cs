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
            //_contratoDao = contratoDao;
            //_periodoDePagoDAO
        }
        /*
        public void guardarListaBoletas(List<BoletaDePago> boletas)
        {
            foreach(BoletaDePago boleta in boletas)
            {
                guardarBoleta(boleta);
            }
        }*/


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
        /*
        public List<BoletaDePago> listarBoleta()
        {
            List<BoletaDePago> listaDeBoletas = new List<BoletaDePago>();
            BoletaDePago aux;
            string listarBoleta = "select codigoBoleta, asignacionFamiliar, fechaDeEmision, sueldoNeto,totalDeDescuentos ,totalDeHoras,totalDeIngresos,codigoContrato,codigoPeriodo,codigoConcepto from boleta;";
            try
            {
                SqlDataReader resultadoSQL = gestorSQL.ejecutarConsulta(listarBoleta);
                while (resultadoSQL.Read())
                {
                    aux = obtenerBoleta(resultadoSQL);
                    listaDeBoletas.Add(aux);
                }
            }
            catch (Exception err)
            {
                throw err;
            }
            return listaDeBoletas;
        }
        
        public BoletaDePago obtenerBoleta(SqlDataReader resultadoSQL)
        {
            Empleado emp = new Empleado();
            Contrato cont = new Contrato();
            BoletaDePago boleta = new BoletaDePago();

            boleta.CodigoBoleta= int.Parse(resultadoSQL.GetString(0));
            boleta.AsignacionFamiliar = double.Parse(resultadoSQL.GetString(1));
            boleta.FechaDeEmision = resultadoSQL.GetString(2);
            boleta.SueldoNeto = double.Parse(resultadoSQL.GetString(3));
            boleta.TotalDeDescuentos = double.Parse(resultadoSQL.GetString(4));
            boleta.TotalDeHoras = double.Parse(resultadoSQL.GetString(5));
            boleta.TotalDeIngresos = double.Parse(resultadoSQL.GetString(6)); 
            cont = contratoDao.buscarContrato(resultadoSQL.GetInt32(7));//si el atributo numero 7 es de contrato lo busca y guarda en cont(contrato)
            boleta.Contrato = cont;//se le asigana el contrato
            boleta.PeriodoDePago = periodoDePagoDAO.buscarPeriodo(int.Parse( resultadoSQL.GetString(8)));
            boleta.ConceptoDeIngresoDescuento = conceptoDeIngresoDescuentoDAO.buscarConcepto(int.Parse(resultadoSQL.GetString(9)));

            return boleta;
        }*/

    }
}

