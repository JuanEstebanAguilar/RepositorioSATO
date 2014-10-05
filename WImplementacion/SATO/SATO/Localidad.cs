using System;
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
    public partial class frmLocalidad : Form
    {
        private Provincia provinciaSeleccionada;
        private Departamento departamentoSeleccionado;
        public frmLocalidad()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            frmProvincia vtProvincia = new frmProvincia();
            vtProvincia.ShowDialog();
        }
        
        private void frmLocalidad_Load(object sender, EventArgs e)
        {
            mostrarProvincias();
            cargarGrilla((int)cmbDepartamentos.SelectedValue);
            cmbProvincias.Text = provinciaSeleccionada.Nombre;
            cmbDepartamentos.Text = departamentoSeleccionado.Nombre;
        }

        internal void mostrarProvinciaYDepartamento(Provincia provincia, Departamento departamento)
        {
            provinciaSeleccionada = provincia;
            departamentoSeleccionado = departamento;
        }

        private void mostrarProvincias()
        {
            GestorDePersonas gestorDePersonas = new GestorDePersonas();
            cmbProvincias.ValueMember = "idProvincia";
            cmbProvincias.DisplayMember = "nombre";
            cmbProvincias.DataSource = gestorDePersonas.obtenerProvincias();
        }

        private void cmbProvincias_SelectedIndexChanged(object sender, EventArgs e)
        {
            mostrarDepartamentosPorProvincia((int)cmbProvincias.SelectedValue);
        }

        private void mostrarDepartamentosPorProvincia(int idProvincia)
        {
            GestorDePersonas gestorDePersonas = new GestorDePersonas();
            cmbDepartamentos.ValueMember = "idDepartamento";
            cmbDepartamentos.DisplayMember = "nombre";
            cmbDepartamentos.DataSource = gestorDePersonas.obtenerDepartamentosPorProvincia(idProvincia);
        }

        private void cargarGrilla(int idDepartamento)
        {
            GestorDePersonas gestorDePersonas = new GestorDePersonas();
            List<Localidad> lsLocalidades = gestorDePersonas.obtenerTodasLocalidades(idDepartamento);
            dgvLocalidades.Rows.Clear();
            foreach (Localidad localidad in lsLocalidades)
            {
                int fila = dgvLocalidades.Rows.Add();
                dgvLocalidades.Rows[fila].Cells["localidad"].Value = localidad.Nombre;
                dgvLocalidades.Rows[fila].Cells["comentario"].Value = localidad.Comentario;
            }
        }

        private void cmbDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarGrilla((int)cmbDepartamentos.SelectedValue);
        }
    }
}
