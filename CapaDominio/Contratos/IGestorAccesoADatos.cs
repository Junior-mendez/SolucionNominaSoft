using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominio.Contratos
{
    public interface IGestorAccesoADatos
    {
        void abrirConexion();
        void cerrarConexion();
        void iniciarTransaccion();

        void terminarTransaccion();
        void cancelarTransaccion();
    }
}
