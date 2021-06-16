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
    public partial class FormBoletasPago : Form
    {
        public FormBoletasPago(List<BoletaDePago> boletas)
        {
            InitializeComponent();
            //dataGridBoletas.DataSource = boletas;
            
            foreach(BoletaDePago boleta in boletas)
            {
                Double totalHora = boleta.TotalDeHoras;
                Double sueldoBasico = boleta.SueldoBasico;
                Double totalIngresos = boleta.TotalDeIngresos;
                Double totalDescuentos = boleta.TotalDeDescuentos;
                Double sueldoNeto = boleta.SueldoNeto;
                dataGridBoletas.Rows.Add(totalHora, sueldoBasico, totalIngresos, totalDescuentos, sueldoNeto);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormBoletasPago_Load(object sender, EventArgs e)
        {
            //this.boletasTableAdapter.Fill(this.baseNominaSoftDataSet.BoletaDePago);
        }
    }
}
