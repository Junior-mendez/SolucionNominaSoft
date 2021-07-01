using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDominio.Entidades;

namespace CapaDominio.Servicios
{
    public class RegistroDeContrato
    {
        public Boolean validarContratoTotal(Contrato contrato, Empleado empleado, Afp afp, Contrato anteriorContrato)
        {
            if (!contrato.ValidarVigenciaDeContrato())//r1
            {
                return false;
            }
            if (!contrato.VerificarContratoAnterior(anteriorContrato))//r2
            {
                
                return false;
            }
            
            if (!contrato.VerfificarFechaFin())//r3
            {
               
                return false;
            }
            if (!contrato.ValidarHorasSemanales())//r4
            {
               
                return false;
            }
            if (!contrato.ValidarValorPorHora())//r5
            {
                
                return false;
            }


            return true;
        }
        public Boolean validarContrato(Contrato contrato, Empleado empleado, Afp afp)
        {
            if (!contrato.ValidarVigenciaDeContrato())//r1
            {
                return false;
            }
            if (!contrato.VerfificarFechaFin())//r3
            {
                return false;
            }
            if (!contrato.ValidarHorasSemanales())//r4
            {
                return false;
            }
            if (!contrato.ValidarValorPorHora())//r5
            {
                return false;
            }
            return true;
        }

        public Contrato editarContrato(Contrato contrato, Contrato contratoEditado)
        {
            contrato = contratoEditado;
            return contrato;
        }
         public void anularContrato(Contrato contrato)
        {
            contrato.Estado = false;
            throw new Exception("Contrato Anulado.");

        }
    }
}
