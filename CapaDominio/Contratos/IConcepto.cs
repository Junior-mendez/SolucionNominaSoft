using CapaDominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominio.Contratos
{
    public interface IConcepto
    {
        ConceptoDeIngresoDescuento buscarConcepto(Contrato contrato, PeriodoDePago periodoDePago);// DUDA
        // ConceptoDeIngresoDescuento buscarConcepto(int codigo);// DUDA
    }
}
