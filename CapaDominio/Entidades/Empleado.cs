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
        private int dni;
        private char estadoCivil;
        private String gradoAcademico;
        private DateTime fechaNacimiento;
        private String nombre;
        private int telefono;

        public string Direccion { get => direccion; set => direccion = value; }
        public int Dni { get => dni; set => dni = value; }
        public char EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
        public string GradoAcademico { get => gradoAcademico; set => gradoAcademico = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Telefono { get => telefono; set => telefono = value; }
    }
}
