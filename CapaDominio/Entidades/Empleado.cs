using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominio.Entidades
{
    public class Empleado
    {
        private String direccion;
        private String dni;
        private String estadoCivil;
        private String gradoAcademico;
        private DateTime fechaNacimiento;
        private String nombre;
        private String telefono;

        public string Direccion { get => direccion; set => direccion = value; }
        public String Dni { get => dni; set => dni = value; }
        public String EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
        public string GradoAcademico { get => gradoAcademico; set => gradoAcademico = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public String Telefono { get => telefono; set => telefono = value; }
    }
}
