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
    public partial class BuscarEmpleado : Form
    {
        public delegate void pasarEmpleado(String legajoEmpleado);
        public event pasarEmpleado empleadoAPasar;

        public BuscarEmpleado(List<Empleado> empleados)
        {
            InitializeComponent();
            cargarGrilla(empleados);
        }
        public BuscarEmpleado()
        {
            InitializeComponent();
        }
        private void cargarGrilla(List<Empleado> empleados)
        {
            dgvEmpleados.Rows.Clear();
            if(empleados.Count>0)
            {
                foreach (Empleado empleado in empleados)
                {
                    int fila = dgvEmpleados.Rows.Add();
                    dgvEmpleados.Rows[fila].Cells["idempleado"].Value = empleado.IdEmpleado;
                    dgvEmpleados.Rows[fila].Cells["idpersona"].Value = empleado.Idpersona;
                    dgvEmpleados.Rows[fila].Cells["legajo"].Value = empleado.Legajo;
                    dgvEmpleados.Rows[fila].Cells["apellido"].Value = empleado.Apellido;
                    dgvEmpleados.Rows[fila].Cells["nombre"].Value = empleado.Nombre;
                    dgvEmpleados.Rows[fila].Cells["tipodocumento"].Value = empleado.TipoDocumento.Sigla;
                    dgvEmpleados.Rows[fila].Cells["documento"].Value = empleado.NumeroDocumento;
                    dgvEmpleados.Rows[fila].Cells["calle"].Value = empleado.Domicilio.Calle;
                    dgvEmpleados.Rows[fila].Cells["numerocalle"].Value = empleado.Domicilio.Numero;
                    dgvEmpleados.Rows[fila].Cells["piso"].Value = empleado.Domicilio.Piso;
                    dgvEmpleados.Rows[fila].Cells["depto"].Value = empleado.Domicilio.Departamento;
                    dgvEmpleados.Rows[fila].Cells["torre"].Value = empleado.Domicilio.Torre;
                    dgvEmpleados.Rows[fila].Cells["barrio"].Value = empleado.Domicilio.Barrio.Nombre;
                    dgvEmpleados.Rows[fila].Cells["localidad"].Value = empleado.Domicilio.Barrio.Localidad.Nombre;
                    dgvEmpleados.Rows[fila].Cells["departamento"].Value = empleado.Domicilio.Barrio.Localidad.Departamento.Nombre;
                    dgvEmpleados.Rows[fila].Cells["provincia"].Value = empleado.Domicilio.Barrio.Localidad.Departamento.Provincia.Nombre;
                }
            }
        }

        private void btnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            String parametro = txtBuscarEmpleado.Text.Trim();

            GestorDePersonas gestorDePersonas = new GestorDePersonas();
            List<Empleado> lsEmpleados = gestorDePersonas.obtenerEmpleadosPorBusqueda(parametro);
            cargarGrilla(lsEmpleados);
        }

        private void dgvEmpleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                Empleado empleado = new Empleado();
                empleado.Legajo = dgvEmpleados[0, e.RowIndex].Value.ToString();
                
                empleadoAPasar(empleado.Legajo);
                this.Close();
            }
        }

        private void BuscarEmpleado_Load(object sender, EventArgs e)
        {

        }
    }
}
