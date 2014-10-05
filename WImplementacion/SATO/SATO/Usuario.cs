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
    public partial class frmUsuario : Form
    {
        private List<Correo> correos;
        public frmUsuario(List<Correo> correos)
        {
            this.correos = correos;
            InitializeComponent();
        }

        private void Usuario_Load(object sender, EventArgs e)
        {
            cargarNombresUsuario();
            cargarCuentas();
            cargarEstadosUsuario();
            
        }

        private void cargarNombresUsuario()
        {
            /*foreach (Correo correo in correos)
            {
                cmbUsuario.Items.Add(correo.Direccion);
            }
            cmbUsuario*/
            cmbUsuario.DataSource = correos;

        }

        private void cargarCuentas()
        {
            GestorDePersonas gestorDePersonas = new GestorDePersonas();
            cmbCuenta.DisplayMember = "nombre";
            cmbCuenta.ValueMember = "idCuenta";
            cmbCuenta.DataSource = gestorDePersonas.obtenerCuentas();
        }

        private void cargarEstadosUsuario()
        {
            GestorDePersonas gestorDePersonas = new GestorDePersonas();
            cmbEstado.DisplayMember="nombre";
            cmbEstado.ValueMember="idEstado";
            cmbEstado.DataSource = gestorDePersonas.obtenerEstadosUsuarios();
        }

        
    }
}
