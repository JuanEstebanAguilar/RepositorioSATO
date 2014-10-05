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
    public partial class frmDepartamento : Form
    {
        private Provincia provincia;
        public frmDepartamento()
        {
            InitializeComponent();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            frmProvincia vtProvincia = new frmProvincia();
            vtProvincia.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDepartamento_Load(object sender, EventArgs e)
        {
            cargarProvincias();
            cargarDepartamentosPorProvincia((int)cmbProvincias.SelectedValue);
            cmbProvincias.Text = provincia.Nombre;
        }

        internal void mostrarProvincia(Provincia provincia)
        {
            this.provincia = provincia;
        }

        private void cargarDepartamentosPorProvincia(int idProvincia)
        {
            LogicaNegocio logicaNegocio = new LogicaNegocio();
        }

        private void cargarProvincias()
        {
            LogicaNegocio logicaNegocio = new LogicaNegocio();
            cmbProvincias.Items.Clear();
            cmbProvincias.ValueMember = "idProvincia";
            cmbProvincias.DisplayMember = "nombre";
            cmbProvincias.DataSource = logicaNegocio.obtenerProvincias();
        }

        private void cmbProvincias_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarGrilla((int)cmbProvincias.SelectedValue);
        }

        private void cargarGrilla(int idProvincia)
        {
            LogicaNegocio logicaNegocio = new LogicaNegocio();
            List<Departamento> lsDepartamentos=logicaNegocio.obtenerTodosDepartamentos(idProvincia);

            dgvDepartamentos.Rows.Clear();
            foreach(Departamento depto in lsDepartamentos)
            {
                int fila=dgvDepartamentos.Rows.Add();
                dgvDepartamentos.Rows[fila].Cells["departamento"].Value=lsDepartamentos[fila].Nombre;
                dgvDepartamentos.Rows[fila].Cells["comentario"].Value=lsDepartamentos[fila].Comentario;
            }
        }
    }
}
