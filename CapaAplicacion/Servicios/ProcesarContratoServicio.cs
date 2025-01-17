﻿using CapaDominio.Contratos;
using CapaDominio.Entidades;
using CapaDominio.Servicios;
using CapaPersistencia.ADO_SQLServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAplicacion.Servicios
{
    public class ProcesarContratoServicio
    {
        private GestorSQL gestorAccesoDatos;


        private ContratoDAO contratoDAO;

        private EmpleadoDAO empleadoDAO;
        private AfpDAO afpDAO;


        public ProcesarContratoServicio()
        {
            gestorAccesoDatos = new GestorSQL();
            afpDAO = new AfpDAO(gestorAccesoDatos);
            contratoDAO = new ContratoDAO(gestorAccesoDatos,empleadoDAO, afpDAO);
            empleadoDAO = new EmpleadoDAO(gestorAccesoDatos);
            
        }
        public Empleado buscarEmpleado(String Dni)
        {
             gestorAccesoDatos.abrirConexion();
            Empleado empleado = empleadoDAO.buscarPorDni(Dni);
            gestorAccesoDatos.cerrarConexion();
            return empleado;

        }

        public Boolean buscarUltimoContratoVigente(String Dni)
        {
            
            try
            {
                gestorAccesoDatos.abrirConexion();
                Contrato contrato = contratoDAO.buscarUltimoContrato(Dni);
                gestorAccesoDatos.cerrarConexion();
                if (contrato.ValidarVigenciaDeContrato())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception )
            {
                return false;
            }
        }

        public Contrato buscarUltimoContrato(String Dni)
        {
            gestorAccesoDatos.abrirConexion();
            Contrato contrato = contratoDAO.buscarUltimoContrato(Dni);
            gestorAccesoDatos.cerrarConexion();

            return contrato;
        }

        //CREAR UN CONTRATO
        public Boolean guardarContrato(Contrato contrato, Empleado empleado, Afp afp)
        {
            RegistroDeContrato registroDeContrato = new RegistroDeContrato();

            try{
                if (registroDeContrato.validarContrato(contrato, empleado, afp))
                {

                    gestorAccesoDatos.abrirConexion();
                    contratoDAO.crearContrato(contrato, empleado, afp);
                    gestorAccesoDatos.cerrarConexion();
                    return true;
                }
            }
            catch(Exception )
            {
                throw new Exception("Datos Incorrectos");
            }
            return false;
        }

        public void editarContrato(Contrato contrato)
        {
            gestorAccesoDatos.abrirConexion();
            contratoDAO.editarContrato( contrato);
            gestorAccesoDatos.cerrarConexion();

        }

        public void anularContrato(Contrato contrato)
        {
            gestorAccesoDatos.abrirConexion();
            contratoDAO.anularContrato(contrato);
            gestorAccesoDatos.cerrarConexion();

        }
        public Afp buscarAfp(string nombre)
        {
            gestorAccesoDatos.abrirConexion();
            Afp afp = afpDAO.buscarPorCodigo(nombre);
            gestorAccesoDatos.cerrarConexion();

            return afp;
        }
    }
}
