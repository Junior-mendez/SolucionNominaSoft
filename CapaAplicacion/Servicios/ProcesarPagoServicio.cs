using CapaDominio.Contratos;
using CapaDominio.Entidades;
using CapaDominio.Servicios;
using CapaPersistencia.FabricaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAplicacion.Servicios
{
    public class ProcesarPagoServicio
    {
        // private GestorSQL gestorDatos;
        private IGestorAccesoADatos gestorAccesoDatos;

        //private ContratoDAO contratoDAO;
        private IContrato contratoDAO;

        //  private Contrato contrato;//porque lo pusieron ? XD 

        //private BoletaDePagoDAO boletaDAO;
        private IBoleta boletaDAO;


        //private ConceptoDeIngresoDescuentoDAO conceptoDAO;
        private IConcepto conceptoDAO;


        //private PeriodoDePagoDAO periodoDePagoDAO;
        private IPeriodo periodoDePagoDAO;
        private IEmpleado empleadoDAO;
        private IAfp afpDAO;

        // private RegistroDePago registroDePago; //porque lo pusieron ? XD   

        public ProcesarPagoServicio()
        {
            FabricaAbstracta fabricaAbstracta = FabricaAbstracta.crearInstancia();//devuelve una instancia de una fabrica concreta 
            //gestorAccesoDatos = new GestorSQL();
            gestorAccesoDatos = fabricaAbstracta.crearGestorAccesoDatos();

            //contratoDAO= new ContratoDAO(gestorDatos);

            contratoDAO = fabricaAbstracta.crearContrato(gestorAccesoDatos,empleadoDAO,afpDAO);
            //boletaDAO = new BoletaDePagoDAO(gestorDatos);

            boletaDAO = fabricaAbstracta.crearBoleta(gestorAccesoDatos);
            //conceptoDAO = new ConceptoDeIngresoDescuentoDAO (gestorDatos);

            conceptoDAO = fabricaAbstracta.crearConcepto(gestorAccesoDatos, periodoDePagoDAO,contratoDAO);

            //periodoDePagoDAO = new PeriodoDePagoDAO(gestorDatos);

            periodoDePagoDAO = fabricaAbstracta.crearPeriodo(gestorAccesoDatos);

        }

        private List<Contrato> buscarContratosActivos(PeriodoDePago periodo)
        {
            gestorAccesoDatos.abrirConexion();
            List<Contrato> contratos = contratoDAO.listarContrato("1",periodo.FechaInicio,periodo.FechaFin);
            gestorAccesoDatos.cerrarConexion();
            return contratos;
        }


        private BoletaDePago generarBoleta(Contrato contrato, ConceptoDeIngresoDescuento concepto, PeriodoDePago periodo)
        {
            RegistroDePago registroDePago = new RegistroDePago();
            BoletaDePago boleta = new BoletaDePago(contrato, periodo,concepto);

            boleta = registroDePago.registrarPago(contrato, periodo,concepto);
            boleta.Contrato = contrato;
            boleta.ConceptoDeIngresoDescuento = concepto;
            return boleta;
        }
        /*
        private ConceptoDeIngresoDescuento buscarConcepto(Contrato contrato, PeriodoDePago periodoDePago, List<ConceptoDeIngresoDescuento> conceptos)
        {
            foreach (ConceptoDeIngresoDescuento concepto in conceptos)
            {
                if (concepto.Contrato.Equals(contrato) == true && concepto.PeriodoDePago.Equals(periodoDePago))
                {
                    return concepto;
                }
            }
            return null;
        }*/
        public List<BoletaDePago> generarBoletas(PeriodoDePago periodoDePago)
        {
            List<Contrato> contratosVigentes = buscarContratosActivos(periodoDePago);//busca todos los contratos activos contrato DAO lsitarcontrato
            List<BoletaDePago> listaDeBoletas = new List<BoletaDePago>();
            ConceptoDeIngresoDescuento concepto = new ConceptoDeIngresoDescuento(periodoDePago);
            BoletaDePago boleta = new BoletaDePago();
            gestorAccesoDatos.abrirConexion();
            foreach (Contrato contratoVigente in contratosVigentes)
            {
                concepto = conceptoDAO.buscarConcepto(contratoVigente, periodoDePago);
                boleta = generarBoleta(contratoVigente, concepto, periodoDePago);
                boletaDAO.guardarBoleta(boleta);//llama a registro de pago
                listaDeBoletas.Add(boleta);
            }
            periodoDePagoDAO.actualizarPeriodo(periodoDePago);
            gestorAccesoDatos.cerrarConexion();
            return listaDeBoletas;
        }

        public PeriodoDePago buscarPeriodo(DateTime fechaInicio, DateTime fechaFin)
        {
            gestorAccesoDatos.abrirConexion();
            PeriodoDePago periodo = periodoDePagoDAO.buscarPeriodoFecha(fechaInicio, fechaFin);
            gestorAccesoDatos.cerrarConexion();
            return periodo;

        }
        public PeriodoDePago buscarPeriodoActivo(Boolean estado)
        {
            gestorAccesoDatos.abrirConexion();
            PeriodoDePago periodo = periodoDePagoDAO.buscarPeriodoActivo(estado);
            gestorAccesoDatos.cerrarConexion();
            return periodo;

        }




    }
}
