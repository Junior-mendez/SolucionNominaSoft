﻿using CapaAplicacion.Servicios;
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
    public partial class FormRegistrarContrato : Form
    {
        Empleado emp = new Empleado();
        ProcesarContratoServicio gestionarContrato = new ProcesarContratoServicio();
        Contrato contrato = new Contrato();
        Afp afp = new Afp();
        public FormRegistrarContrato()
        {
            InitializeComponent();
            List<string> lista = new List<string>();
            lista.Add("Prima AFP");
            lista.Add("AFPIntegra");
            lista.Add("ProfuturoAFP");
            comboBoxAfp.DataSource = lista;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            registrar();
            limpiar();
        }
        public void registrar()
        {
            contrato.Estado = true;
            contrato.FechaInicio = dateFechaInicio.Value;
            contrato.FechaFin = dateFechaFin.Value;
            contrato.PagoPorHora = Double.Parse(textValorHora.Text);
            contrato.HorasSemana = int.Parse(textHoraSemana.Text);
            contrato.AsignacionFamiliar = checkAsignacion.Checked;
            contrato.Cargo = textCargo.Text;
            afp = gestionarContrato.buscarAfp(comboBoxAfp.Text);
    
            if(gestionarContrato.guardarContrato(contrato, emp, afp))
            {
                MessageBox.Show("Contrato Guardado");
            }
            else
            {
                MessageBox.Show("Los Datos Son incorrectos");
            }
                
           
        }
        public void Buscar()
        {
            String dni = textDni.Text;
            if (string.IsNullOrEmpty(dni))
            {
                MessageBox.Show("El Dni no puede estar en blanco");
            }
            else
            {
                try
                {
                    emp = gestionarContrato.buscarEmpleado(dni);
                    textNombre.Text = emp.Nombre;
                    textTelefono.Text = emp.Telefono;
                    textDireccion.Text = emp.Direccion;
                    textEstadoCivil.Text = emp.EstadoCivil;
                    dateFechaNacimiento.Value =emp.FechaNacimiento;
                    textGrado.Text = emp.GradoAcademico;
                    Boolean op = gestionarContrato.buscarUltimoContratoVigente(dni);
                    if (op)
                    {
                        MessageBox.Show("El Empleado cuenta con Contrato Vigente");
                        contrato = gestionarContrato.buscarUltimoContrato(dni);
                        dateFechaInicio.Value = contrato.FechaInicio;
                        dateFechaFin.Value = contrato.FechaFin;
                        dateFechaFin.Value = contrato.FechaFin;
                        comboBoxAfp.Text = contrato.Afp.NombreAfp;
                        textValorHora.Text = contrato.PagoPorHora.ToString();
                        textHoraSemana.Text = contrato.HorasSemana.ToString();
                        checkAsignacion.Checked = contrato.AsignacionFamiliar;
                        textCargo.Text = contrato.Cargo;
                        btnEditar.Enabled = true;
                        btnAnular.Enabled = true;
                        btnRegistrar.Enabled = false;
                    }
                    else
                    {
                        groupBoxContrato.Enabled = true;
                    }
                }
                catch (Exception )
                {
                    MessageBox.Show("Empleado No Registrado");
                }
            }
        }
        public String Dni()
        {
            return textDni.Text;
        }
        public void editar()
        {

            groupBoxContrato.Enabled = true;
            btnGuardar.Visible = true;
        }
        public void guardar()
        {
            Afp afpUpdate = new Afp();
            afpUpdate = gestionarContrato.buscarAfp(comboBoxAfp.Text);
            Contrato contratoUpdate = new Contrato(afpUpdate);
            contratoUpdate.Codigo = contrato.Codigo;
            contratoUpdate.Cargo = textCargo.Text;
            contratoUpdate.PagoPorHora= double.Parse(textValorHora.Text);
            contratoUpdate.HorasSemana = int.Parse(textHoraSemana.Text);
            contratoUpdate.FechaInicio = dateFechaInicio.Value;
            contratoUpdate.FechaFin= dateFechaFin.Value;
            contratoUpdate.AsignacionFamiliar= checkAsignacion.Checked;
            try
            {
                gestionarContrato.editarContrato(contratoUpdate);
                MessageBox.Show("Contrato  Actualizado");
                this.Close();
            }
            catch(Exception )
            {
                MessageBox.Show("Contrato no fue Actualizado");
            }
            
        }
        public void limpiar()
        {
            textNombre.Text = "";
            textDni.Text = "";
            textTelefono.Text = "";
            textDireccion.Text = "";
            textEstadoCivil.Text = "";
            textGrado.Text = "";
            dateFechaNacimiento.Value = DateTime.Now;
            textCargo.Text = "";
            comboBoxAfp.Text = "";
            textHoraSemana.Text = "";
            textValorHora.Text = "";
            checkAsignacion.Checked = false;
            groupBoxContrato.Enabled = false;
        }

        private void textValorHora_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void FormRegistrarContrato_Load(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            editar();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            anularContrato();
            limpiar();
            btnEditar.Enabled = false;
            btnAnular.Enabled = false;
        }
        private void anularContrato()
        {
            try
            {
                gestionarContrato.anularContrato(contrato);
                MessageBox.Show("Contrato Anulado");
            }
            catch (Exception )
            {
                MessageBox.Show("Error");

            }
        }
    }
}
