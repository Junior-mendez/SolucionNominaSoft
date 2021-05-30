using CapaDominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominio.Contratos
{
    public interface IBoleta //debe ser de modo publico para poder hacer la implementacion desde boletadao
    {
        //void guardarListaBoletas(List<BoletaDePago> boletas);
        void guardarBoleta(BoletaDePago boleta);
    }
}
