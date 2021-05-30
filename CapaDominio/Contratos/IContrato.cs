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

        List<Contrato> listarContrato(string estado);//llama a metodo de la clase contrato dao, mostrara todos los contratos guardados
        Contrato buscarContrato(int codigo);//busca contrato por codigo
        void crearContrato(Contrato contrato,Empleado empleado, Afp afp);
        Contrato buscarUltimoContrato(string codigo);
        void anularContrato(Contrato contrato);
        void editarContrato(Contrato contrato);
    }
}
