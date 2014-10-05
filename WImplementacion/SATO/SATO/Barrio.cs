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
    public partial class frmBarrio : Form
    {
        private Validador validador = new Validador();
        private Localidad localidad;
        private Boolean esNuevo;

        public frmBarrio()
        {
            InitializeComponent();
        }

        public frmBarrio(Localidad localidad)
        {
            InitializeComponent();
            this.localidad = localidad;
        }
        private void frmBarrio_Load(object sender, EventArgs e)
        {
            mostrarProvincias();
            mostrarDepartamentosPorProvincia((int)cmbProvincias.SelectedValue);
            mostrarLocalidadesPorDepartamento((int)cmbDepartamentos.SelectedValue);
            cmbProvincias.SelectedValue = localidad.Departamento.Provincia.IdProvincia;
            cmbDepartamentos.SelectedValue = localidad.Departamento.IdDepartamento;
            cmbLocalidades.SelectedValue = localidad.Idlocalidad;
            txtBarrio.Focus();
            validador.habilitarTodo(this, "deshabilitar");
            btnAgregar.Enabled = true;
            btnSalir.Enabled = true;
            gbxBarrios.Enabled = true;
            
        }

        private void mostrarProvincias()
        {
            GestorDePersonas gestorPersonas = new GestorDePersonas();
            cmbProvincias.ValueMember = "idProvincia";
            cmbProvincias.DisplayMember = "nombre";
            cmbProvincias.DataSource = gestorPersonas.obtenerProvincias();
        }

        private void mostrarDepartamentosPorProvincia(int idProvincia)
        {
            GestorDePersonas gestorPersona = new GestorDePersonas();
            cmbDepartamentos.ValueMember = "idDepartamento";
            cmbDepartamentos.DisplayMember = "nombre";
            cmbDepartamentos.DataSource = gestorPersona.obtenerDepartamentosPorProvincia(idProvincia);
        }

        private void mostrarLocalidadesPorDepartamento(int idDepartamento)
        {
            GestorDePersonas gestorPersona = new GestorDePersonas();
            cmbLocalidades.ValueMember = "idLocalidad";
            cmbLocalidades.DisplayMember = "nombre";
            cmbLocalidades.DataSource = gestorPersona.obtenerLocalidadesPorDepartamento(idDepartamento);
        }

        private void cmbProvincias_SelectedIndexChanged(object sender, EventArgs e)
        {
            mostrarDepartamentosPorProvincia((int)cmbProvincias.SelectedValue);
        }

        private void cmbDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            mostrarLocalidadesPorDepartamento((int)cmbDepartamentos.SelectedValue);
        }

        private void cmbLocalidades_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbLocalidades_DropDownClosed(object sender, EventArgs e)
        {
            cargarGrilla((int)cmbLocalidades.SelectedValue);
        }

        private void cargarGrilla(int idLocalidad)
        {
            GestorDePersonas gestorPersonas=new GestorDePersonas();
            List<Barrio> barrios = gestorPersonas.obtenerBarriosPorLocalidad(idLocalidad);
            dgvBarrios.Rows.Clear();
            if (barrios != null)
            {
                foreach (Barrio barrio in barrios)
                {
                    int fila = dgvBarrios.Rows.Add();
                    dgvBarrios.Rows[fila].Cells["idbarrio"].Value = barrio.IdBarrio;
                    dgvBarrios.Rows[fila].Cells["nombre"].Value = barrio.Nombre;
                    dgvBarrios.Rows[fila].Cells["comentario"].Value = barrio.Comentario;
                }
            }
            else
            {
                MessageBox.Show("No hay barrio en esta localidad", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            validador.habilitarControles(this, true);
            validador.manejarBotonesABM(btnModificar, btnAgregar, btnCancelar, btnModificar, btnEliminar, btnGuardar, btnSalir);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            validador.habilitarControles(this, false);
            validador.manejarBotonesABM(btnEliminar, btnAgregar, btnCancelar, btnModificar, btnEliminar, btnGuardar, btnSalir);
        }

        private Boolean guardarBarrio()
        {
            String nombreBarrio;
            if (validador.validarString(txtBarrio, "Ingrese el nombre del barrio", "Atención"))
            { nombreBarrio = txtBarrio.Text.Trim(); }
            else { return false; }

            String comentario;
            comentario = txtComentario.Text.Trim();
            Provincia provincia = (Provincia)cmbProvincias.SelectedItem;
            Departamento departamento = (Departamento)cmbDepartamentos.SelectedItem;
            Localidad localidad = (Localidad)cmbLocalidades.SelectedItem;

            Barrio barrio = new Barrio();
            barrio.Nombre = nombreBarrio;
            barrio.Comentario = comentario;
            barrio.Localidad = localidad;

            GestorDePersonas gestorPersonas=new GestorDePersonas();
            if (gestorPersonas.tomarBarrio(barrio))
            {
                return true;
            }
            else
            {
                MessageBox.Show("El barrio ya se encuentra registrado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            

            
            
            
            
        }
        private void dgvBarrios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                Barrio barrio=new Barrio();
                barrio.IdBarrio=Convert.ToInt32(dgvBarrios[0, e.RowIndex].Value.ToString());
                GestorDePersonas gestorPersonas=new GestorDePersonas();
                barrio = gestorPersonas.obtenerBarrioPorId(barrio.IdBarrio);
                cmbProvincias.SelectedValue = barrio.Localidad.Departamento.Provincia.IdProvincia;
                cmbDepartamentos.SelectedValue = barrio.Localidad.Departamento.IdDepartamento;
                cmbLocalidades.SelectedValue = barrio.localidad.Idlocalidad;
                txtBarrio.Text = barrio.Nombre;
                txtComentario.Text = barrio.Comentario;
            }
        }

        private void dgvBarrios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvBarrios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            validador.limpiarTexBox(this);
            validador.habilitarTodo(this, "habilitar");
            btnAgregar.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;

            esNuevo = true;
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            validador.limpiarTexBox(this);
            validador.habilitarTodo(this, "deshabilitar");
            btnAgregar.Enabled = true;
            gbxBarrios.Enabled = true;
            btnSalir.Enabled = true;
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (esNuevo == true)
            {
                if (guardarBarrio())
                {
                    validador.limpiarTexBox(this);
                    dgvBarrios.Rows.Clear();
                    cargarGrilla((int)cmbLocalidades.SelectedValue);
                    validador.habilitarTodo(this, "deshabilitar");
                    btnAgregar.Enabled = true;
                    btnSalir.Enabled = true;
                    gbxBarrios.Enabled = true;
                    MessageBox.Show("El barrio se registro exitosamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
