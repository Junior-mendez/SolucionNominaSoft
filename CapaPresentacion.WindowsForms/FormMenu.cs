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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void registrarContratoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRegistrarContrato formRegistrarContrato = new FormRegistrarContrato();
            formRegistrarContrato.Show();
        }

        private void registrarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRegistroEmpleado formEmpleado = new FormRegistroEmpleado();
            formEmpleado.Show();
        }

        private void procesarPagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProcesarPago formProcesar =new FormProcesarPago();
            formProcesar.Show();
        }
    }
}
