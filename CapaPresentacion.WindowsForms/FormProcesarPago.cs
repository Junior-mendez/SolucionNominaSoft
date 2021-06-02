using CapaAplicacion.Servicios;
using CapaDominio.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.WindowsForms
{
    public partial class FormProcesarPago : Form
    {
        ProcesarPagoServicio procesarPago = new ProcesarPagoServicio();
        PeriodoDePago periodo = new PeriodoDePago();
        public FormProcesarPago()
        {
            InitializeComponent();
            
                obtenerPeriodo();
           
            
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            procesarPeriodo();
        }
        public void obtenerPeriodo() 
        {
         try
            {
            periodo = procesarPago.buscarPeriodoActivo(true);
            textCodigo.Text = periodo.CodigoPeriodo.ToString();
            dateFechaInicio.Value = periodo.FechaInicio;
            dateFechaFin.Value = periodo.FechaFin;
            }
            catch (Exception exception)
            {
                MessageBox.Show("No existe preiodo Activo");
            }
        }
        public void procesarPeriodo()
        {
            List<BoletaDePago> boletas;
            obtenerPeriodo();
            if (periodo != null)
            {
               
                    boletas = procesarPago.generarBoletas(periodo);
                    MessageBox.Show("Se proceso");
             
               
                //FormPlanillaPagos formPlanillaPagos = new FormPlanillaPagos(boletas);
            }
            else
            {
                //mostrar error *******************************************
                MessageBox.Show("no hay");

            }
        }
    }
}
