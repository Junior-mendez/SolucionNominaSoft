using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominio.Entidades
{
    public class PeriodoDePago
    {
        private int codigoPeriodo;//codigo
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
                //throw new Exception("No se encuentra dentro del periodo de pago");
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
            //Double day = difFechas.TotalDays;
            return day / 7;
        }
        //verificar periodo de pago se implementara en la capa persistencia
    }
}
