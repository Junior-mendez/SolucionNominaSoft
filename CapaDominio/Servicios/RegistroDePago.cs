using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using CapaDominio.Entidades;

namespace CapaDominio.Servicios
{
    public class RegistroDePago
    {
        public void RegistrarBoletas(PeriodoDePago periodo,List<Contrato> contratos)//r6 
        {
            if(periodo.VerificarPeriodoDePago())
            {
                List<BoletaDePago> Boletas = new List<BoletaDePago>();
                foreach (Contrato contrato in contratos)
                {
                    if(contrato.Estado == true && contrato.FechaFin>periodo.FechaInicio)
                    {
                        Boletas.Add(registrarPago(contrato, periodo));
                        
                    }
                }
            }
        }
        private BoletaDePago registrarPago(Contrato contrato, PeriodoDePago periodo)
        {
            BoletaDePago boleta = new BoletaDePago(contrato,periodo);
            boleta.TotalDeHoras= boleta.CalcularTotalDeHoras();//r13
            //boleta.SueldoBasico = boleta.CalcularSueldoBasico();//r7
            boleta.AsignacionFamiliar = boleta.Contrato.CalcularAsignacionFamiliar();//r8
            boleta.TotalDeDescuentos = boleta.CalcularTotalDescuento();//r11
            boleta.TotalDeIngresos = boleta.CalcularTotalDeIngresos();//r9
            //boleta.SueldoNeto = boleta.CalcularSueldoNeto();//r12

            return boleta;
        }
    }
}
