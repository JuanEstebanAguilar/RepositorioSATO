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
    public partial class BuscarProfesionalTurno : Form
    {
        public delegate void pasarProfesional(String parametro);
        public event pasarProfesional profesionalAPasar;

        public BuscarProfesionalTurno(List<Profesional> profesionales)
        {
            InitializeComponent();
            cargarGrilla(profesionales);
        }
        public BuscarProfesionalTurno()
        {
            InitializeComponent();
        }
        private void cargarGrilla(List<Profesional> profesionales)
        {
            dgvProfesionales.Rows.Clear();
            if (profesionales.Count > 0)
            {
                foreach (Profesional profesional in profesionales)
                {
                    int fila = dgvProfesionales.Rows.Add();
                    dgvProfesionales.Rows[fila].Cells["idprofesional"].Value = profesional.Idprofesional;
                    dgvProfesionales.Rows[fila].Cells["idpersona"].Value = profesional.Idpersona;
                    dgvProfesionales.Rows[fila].Cells["matricula"].Value = profesional.Matricula;
                    dgvProfesionales.Rows[fila].Cells["apellido"].Value = profesional.Apellido;
                    dgvProfesionales.Rows[fila].Cells["nombre"].Value = profesional.Nombre;
                    dgvProfesionales.Rows[fila].Cells["tipoDocumento"].Value = profesional.TipoDocumento.Sigla;
                    dgvProfesionales.Rows[fila].Cells["nroDocumento"].Value = profesional.NumeroDocumento;
                    dgvProfesionales.Rows[fila].Cells["calle"].Value = profesional.Domicilio.Calle;
                    dgvProfesionales.Rows[fila].Cells["numeroCalle"].Value = profesional.Domicilio.Numero;
                    dgvProfesionales.Rows[fila].Cells["piso"].Value = profesional.Domicilio.Piso;
                    dgvProfesionales.Rows[fila].Cells["depto"].Value = profesional.Domicilio.Departamento;
                    dgvProfesionales.Rows[fila].Cells["torre"].Value = profesional.Domicilio.Torre;
                    dgvProfesionales.Rows[fila].Cells["barrio"].Value = profesional.Domicilio.Barrio.Nombre;
                    dgvProfesionales.Rows[fila].Cells["localidad"].Value = profesional.Domicilio.Barrio.Localidad.Nombre;
                    dgvProfesionales.Rows[fila].Cells["departamento"].Value = profesional.Domicilio.Barrio.Localidad.Departamento.Nombre;
                    dgvProfesionales.Rows[fila].Cells["provincia"].Value = profesional.Domicilio.Barrio.Localidad.Departamento.Provincia.Nombre;
                }
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            String parametro = txtbuscarprof.Text.Trim();

            LogicaNegocio logicaNegocio = new LogicaNegocio();
            List<Profesional> lsProfesional = logicaNegocio.obtenerProfesionalPorBusqueda(parametro);
            cargarGrilla(lsProfesional);
        }

        private void dgvProfesionales_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Presentacion.frmProfesional frm = new Presentacion.frmProfesional();
            //((Button)frm.Controls["button1"].Enabled) = false;

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                Profesional profesional = new Profesional();
                string param = dgvProfesionales[0, e.RowIndex].Value.ToString();
                profesionalAPasar(param);
                this.Close();
            }
        }

    }
}
