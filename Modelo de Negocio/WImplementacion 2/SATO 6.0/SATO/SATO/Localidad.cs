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

        private void button7_Click(object sender, EventArgs e)
        {
            frmDepartamento vtDepartamento=new frmDepartamento();
            vtDepartamento.ShowDialog();
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
            LogicaNegocio logicaNegocio = new LogicaNegocio();
            cmbProvincias.ValueMember = "idProvincia";
            cmbProvincias.DisplayMember = "nombre";
            cmbProvincias.DataSource = logicaNegocio.obtenerProvincias();
        }

        private void cmbProvincias_SelectedIndexChanged(object sender, EventArgs e)
        {
            mostrarDepartamentosPorProvincia((int)cmbProvincias.SelectedValue);
        }

        private void mostrarDepartamentosPorProvincia(int idProvincia)
        {
            LogicaNegocio logicaNegocio = new LogicaNegocio();
            cmbDepartamentos.ValueMember = "idDepartamento";
            cmbDepartamentos.DisplayMember = "nombre";
            cmbDepartamentos.DataSource = logicaNegocio.obtenerDepartamentosPorProvincia(idProvincia);
        }

        private void cargarGrilla(int idDepartamento)
        {
            LogicaNegocio logicaNegocio = new LogicaNegocio();
            List<Localidad> lsLocalidades = logicaNegocio.obtenerTodasLocalidades(idDepartamento);
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
