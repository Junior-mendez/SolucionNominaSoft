using CapaDominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominio.Contratos
{
    public interface IContrato
    {

        List<Contrato> listarContrato(string estado,DateTime fechaInicio,DateTime fechaFin);
        Contrato buscarContrato(int codigo);
        void crearContrato(Contrato contrato,Empleado empleado, Afp afp);
        Contrato buscarUltimoContrato(string codigo);
        void anularContrato(Contrato contrato);
        void editarContrato(Contrato contrato);
    }
}
