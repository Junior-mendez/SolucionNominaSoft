using CapaDominio.Contratos;
using CapaPersistencia.ADO_SQLServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPersistencia.FabricaDatos
{
    public class FabricaSQLServer : FabricaAbstracta  //FabricaSQLServer  debe implementar o heredar de la clase FabricaAbstracta 
    {

        public override IBoleta crearBoleta(IGestorAccesoADatos gestorAccesoADatos)
        {
            return new BoletaDePagoDAO(gestorAccesoADatos);//instancia y el retorno de este sera de tipo generico IBoleta
        }

        public override IContrato crearContrato(IGestorAccesoADatos gestorAccesoADatos, IEmpleado empleadoDAO, IAfp afpDAO)
        {
            return new ContratoDAO(gestorAccesoADatos,empleadoDAO,afpDAO);
        }

        public override IEmpleado crearEmpleado(IGestorAccesoADatos gestorAccesoADatos)
        {
            return new EmpleadoDAO(gestorAccesoADatos); //instancia y el retorno de este sera de tipo generico IEmpleado 
        }

        public override IGestorAccesoADatos crearGestorAccesoDatos()
        {
            return new GestorSQL();// instancia gestorSQL pero retorna un tipo generico IgestorAccesoADatos
        }

        public override IPeriodo crearPeriodo(IGestorAccesoADatos gestorAccesoADatos)
        {
            return new PeriodoDePagoDAO(gestorAccesoADatos);//instancia y el retorno de este sera de tipo generico IBoleta
        }
        public override IConcepto crearConcepto(IGestorAccesoADatos gestorSQL, IPeriodo periodoDePagoDAO, IContrato contratoDAO)
        {
            return new ConceptoDeIngresoDescuentoDAO( gestorSQL,  periodoDePagoDAO,  contratoDAO);//instancia y el retorno de este sera de tipo generico IBoleta
        }

        public override IAfp creaAfp(IGestorAccesoADatos gestorAccesoADatos)
        {
            return new AfpDAO(gestorAccesoADatos);
        }
    }
}
