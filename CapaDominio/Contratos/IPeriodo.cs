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
        PeriodoDePago buscarPeriodo(int codigoPeriodo);
        PeriodoDePago buscarPeriodoActivo(Boolean estado);
        void actualizarPeriodo(PeriodoDePago periodoDePago);
        PeriodoDePago buscarPeriodoFecha(DateTime fechaInicio, DateTime fechaFin);
    }
}
