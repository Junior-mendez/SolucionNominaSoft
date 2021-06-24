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
        private IGestorAccesoADatos gestorAccesoDatos;

        private IContrato contratoDAO;


        private IBoleta boletaDAO;


        private IConcepto conceptoDAO;

        private IPeriodo periodoDePagoDAO;
        private IEmpleado empleadoDAO;
        private IAfp afpDAO;


        public ProcesarPagoServicio()
        {
            FabricaAbstracta fabricaAbstracta = FabricaAbstracta.crearInstancia();//devuelve una instancia de una fabrica concreta 
            
            gestorAccesoDatos = fabricaAbstracta.crearGestorAccesoDatos();

            contratoDAO = fabricaAbstracta.crearContrato(gestorAccesoDatos,empleadoDAO,afpDAO);
            boletaDAO = fabricaAbstracta.crearBoleta(gestorAccesoDatos);

            conceptoDAO = fabricaAbstracta.crearConcepto(gestorAccesoDatos, periodoDePagoDAO,contratoDAO);

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
