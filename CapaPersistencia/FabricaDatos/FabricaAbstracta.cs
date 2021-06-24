using CapaDominio.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPersistencia.FabricaDatos
{
    public abstract class FabricaAbstracta
    {
        public static FabricaAbstracta crearInstancia()
        {

            return new FabricaSQLServer();// Aca pasa que la clase FabricaAbstracta con su metodo crear instancia lo que va a 
            //devolver va ser una instancia de una fabrica concreta
        }
        public abstract IGestorAccesoADatos crearGestorAccesoDatos();// este metodo define que es lo que quiero hacer en la fabrica
                                                                     // internamente cuando ya exista la clase fabrica completa implementara este metodo 
        public abstract IEmpleado crearEmpleado(IGestorAccesoADatos gestorAccesoADatos);
        public abstract IContrato crearContrato(IGestorAccesoADatos gestorSQL, IEmpleado empleadoDAO, IAfp afpDAO);

        public abstract IBoleta crearBoleta(IGestorAccesoADatos gestorAccesoADatos);

        public abstract IConcepto crearConcepto(IGestorAccesoADatos gestorSQL, IPeriodo periodoDePagoDAO, IContrato contratoDAO);

        public abstract IPeriodo crearPeriodo(IGestorAccesoADatos gestorAccesoADatos);

        public abstract IAfp creaAfp(IGestorAccesoADatos gestorAccesoADatos);




    }
}
