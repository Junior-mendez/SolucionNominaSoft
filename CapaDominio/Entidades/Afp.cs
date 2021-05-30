using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominio.Entidades
{
    public class Afp
    {
        private int codigoAfp;
        private String nombreAfp;
        private float porcentajeAfp;

        public int CodigoAfp { get => codigoAfp; set => codigoAfp = value; }
        public string NombreAfp { get => nombreAfp; set => nombreAfp = value; }
        public float PorcentajeAfp { get => porcentajeAfp; set => porcentajeAfp = value; }

        public Afp()
        {

        }
    }

}
