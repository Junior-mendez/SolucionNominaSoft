using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominio.Entidades
{
    public class PeriodoDePago
    {
        private int codigoPeriodo;
        private Boolean estado;
        private DateTime fechaInicio;
        private DateTime fechaFin;
        private float semanasDelPeriodo;

        public bool Estado { get => estado; set => estado = value; }
        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public DateTime FechaFin { get => fechaFin; set => fechaFin = value; }
        public float SemanasDelPeriodo { get => semanasDelPeriodo; set => semanasDelPeriodo = value; }
        public int CodigoPeriodo { get => codigoPeriodo; set => codigoPeriodo = value; }

        public Boolean VerificarPeriodoDePago()
        {
            if ( DateTime.Now >= FechaFin)
            {
                return true;
            }
            else
            {
                return false;

            }
        }

        public int CalcularSemanasPeriodo()
        {
            TimeSpan difFechas = FechaFin - FechaInicio;
            int day = difFechas.Days;
            return day / 7;
        }
    }
}
