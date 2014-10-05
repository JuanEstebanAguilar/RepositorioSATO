﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Negocio;
using Entidades;

namespace Presentacion
{
    public partial class BuscarPacienteTurno : Form
    {
        public delegate void pasarPaciente(String numPaciente);
        public event pasarPaciente pacienteAPasar;
        
        public BuscarPacienteTurno(List<Paciente> pacientes)
        {
            InitializeComponent();
            cargarGrilla(pacientes);
        }
        public BuscarPacienteTurno()
        {
            InitializeComponent();
        }
        private void cargarGrilla(List<Paciente> pacientes)
        {
            dgvPacientes.Rows.Clear();
            if (pacientes.Count > 0)
            {
                foreach (Paciente paciente in pacientes)
                {
                    int fila = dgvPacientes.Rows.Add();
                    dgvPacientes.Rows[fila].Cells["idpersona"].Value = paciente.Idpersona;
                    dgvPacientes.Rows[fila].Cells["idpaciente"].Value = paciente.IdPaciente;
                    dgvPacientes.Rows[fila].Cells["numero"].Value = paciente.Numero;
                    dgvPacientes.Rows[fila].Cells["apellido"].Value = paciente.Apellido;
                    dgvPacientes.Rows[fila].Cells["nombre"].Value = paciente.Nombre;
                    dgvPacientes.Rows[fila].Cells["tipodocumento"].Value = paciente.TipoDocumento.Sigla;
                    dgvPacientes.Rows[fila].Cells["documento"].Value = paciente.NumeroDocumento;
                    dgvPacientes.Rows[fila].Cells["calle"].Value = paciente.Domicilio.Calle;
                    dgvPacientes.Rows[fila].Cells["numerocalle"].Value = paciente.Domicilio.Numero;
                    dgvPacientes.Rows[fila].Cells["piso"].Value = paciente.Domicilio.Piso;
                    dgvPacientes.Rows[fila].Cells["depto"].Value = paciente.Domicilio.Departamento;
                    dgvPacientes.Rows[fila].Cells["torre"].Value = paciente.Domicilio.Torre;
                    dgvPacientes.Rows[fila].Cells["barrio"].Value = paciente.Domicilio.Barrio.Nombre;
                    dgvPacientes.Rows[fila].Cells["localidad"].Value = paciente.Domicilio.Barrio.Localidad.Nombre;
                    dgvPacientes.Rows[fila].Cells["departamento"].Value = paciente.Domicilio.Barrio.Localidad.Departamento.Nombre;
                    dgvPacientes.Rows[fila].Cells["provincia"].Value = paciente.Domicilio.Barrio.Localidad.Departamento.Provincia.Nombre;
                }
            }
        }

        private void Pacientes_Enter(object sender, EventArgs e)
        {

        }

        private void btnBuscarPaciente_Click_1(object sender, EventArgs e)
        {
            String parametro = txtBuscarPaciente.Text.Trim();

            LogicaNegocio logicaNegocio = new LogicaNegocio();
            List<Paciente> lsPacientes = logicaNegocio.obtenerPacientesPorBusqueda(parametro);
            cargarGrilla(lsPacientes);
        }

        private void dgvPacientes_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                Paciente paciente = new Paciente();
                paciente.Numero = dgvPacientes[0, e.RowIndex].Value.ToString();

                pacienteAPasar(paciente.Numero);
                this.Close();
            }
        }
    }
}
