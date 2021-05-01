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
        public Boolean validarContrato(Contrato contrato, Contrato anteriorContrato)
        {
            if (contrato.ValidarVigenciaDeContrato() == false)//r1
            {
                //throw new Exception("No se puede guardar, el pago por hora no es el correcto para su grado academico.");
                return false;
            }
            if (contrato.VerificarContratoAnterior(anteriorContrato) == false)//r2
            {
                //throw new Exception("No se puede guardar, el pago por hora no es el correcto para su grado academico.");
                return false;
            }
            //validar la fecha de mi contrato anterior (base de datos) y compararla con mi nuevo contrato
            if (contrato.VerfificarFechaFin() == false)//r3
            {
                //throw new Exception("No se puede guardar, la fecha de inicio y fin son incorrectas.");
                return false;
            }
            if (contrato.ValidarHorasSemanales() == false)//r4
            {
                //throw new Exception("No se puede guardar, las horas semanales son incorrectas.");
                return false;
            }
            if (contrato.ValidarValorPorHora() == false)//r5
            {
                //throw new Exception("No se puede guardar, el pago por hora no es el correcto para su grado academico.");
                return false;
            }


            return true;
        }

        public Contrato editarContrato(Contrato contrato, Contrato contratoEditado)
        {
            contrato = contratoEditado;
            //throw new Exception("Contrato Editado.");
            return contrato;
        }
         public void anularContrato(Contrato contrato)
        {
            contrato.Estado = false;
            throw new Exception("Contrato Anulado.");

        }
    }
}
