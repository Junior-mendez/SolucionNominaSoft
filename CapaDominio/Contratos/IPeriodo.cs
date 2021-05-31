using CapaDominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominio.Contratos
{
    public interface IPeriodo
    {
        PeriodoDePago buscarPeriodo(int codigoPeriodo); // DUDA
        PeriodoDePago buscarPeriodoActivo(Boolean estado); // DUDA
        void actualizarPeriodo(PeriodoDePago periodoDePago);
        PeriodoDePago buscarPeriodoFecha(DateTime fechaInicio, DateTime fechaFin);
    }
}
