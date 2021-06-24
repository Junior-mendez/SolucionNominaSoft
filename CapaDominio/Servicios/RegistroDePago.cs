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
        public void RegistrarBoletas(PeriodoDePago periodo,List<Contrato> contratos,ConceptoDeIngresoDescuento concepto)//r6 
        {
            if(periodo.VerificarPeriodoDePago())
            {
                List<BoletaDePago> Boletas = new List<BoletaDePago>();
                foreach (Contrato contrato in contratos)
                {
                    if(contrato.Estado && contrato.FechaFin>periodo.FechaInicio)
                    {
                        Boletas.Add(registrarPago(contrato, periodo,concepto));
                        
                    }
                }
            }
        }
        public BoletaDePago registrarPago(Contrato contrato, PeriodoDePago periodo,ConceptoDeIngresoDescuento concepto)
        {
            BoletaDePago boleta = new BoletaDePago(contrato,periodo);
            boleta.TotalDeHoras= boleta.CalcularTotalDeHoras();//r13
            boleta.SueldoBasico = boleta.CalcularSueldoBasico();//r7
            boleta.AsignacionFamiliar = boleta.Contrato.CalcularAsignacionFamiliar();//r8
            boleta.DescuentoAfp = boleta.CalcularDescuentosAfp(boleta.SueldoBasico, contrato.Afp.PorcentajeAfp);
            boleta.TotalDeDescuentos = boleta.CalcularTotalDescuento(boleta, concepto);//r11
            boleta.TotalDeIngresos = boleta.CalcularTotalDeIngresos( concepto,  contrato);//r9
            boleta.FechaDeEmision = DateTime.Now;
            boleta.SueldoNeto = boleta.CalcularSueldoNeto();//r12


            return boleta;
        }
    }
}
