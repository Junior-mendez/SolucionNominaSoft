using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominio.Entidades
{
    public class PeriodoDePago
    {
        private Boolean Estado;
        private DateTime fechaInicio;
        private DateTime fechaFin;
        //private float semanasDelPeriodo;

        public bool Estado1 { get => Estado; set => Estado = value; }
        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public DateTime FechaFin { get => fechaFin; set => fechaFin = value; }
        //public float SemanasDelPeriodo { get => semanasDelPeriodo; set => semanasDelPeriodo = value; }

        public Boolean VerificarPeriodoDePago()
        {
            if ( DateTime.Now >= FechaFin)
            {
                //throw new Exception("No se encuentra dentro del periodo de pago");
                return false;
            }
            else
            {
                return true;

            }
        }

        public int CalcularSemanasPeriodo()
        {
            TimeSpan difFechas = FechaFin - FechaInicio;
            int day = difFechas.Days;
            //Double day = difFechas.TotalDays;
            return day / 7;
        }
        //verificar periodo de pago se implementara en la capa persistencia
    }
}
