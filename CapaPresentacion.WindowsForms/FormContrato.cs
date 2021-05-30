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
    public partial class FormContrato : Form
    {
        Empleado empleado = new Empleado();
        ProcesarContratoServicio gestionarContrato = new ProcesarContratoServicio();
        public FormContrato()
        {
            InitializeComponent();

        }

        private void FormContrato_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
