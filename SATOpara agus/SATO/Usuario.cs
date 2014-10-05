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
            LogicaNegocio logicaNegocio = new LogicaNegocio();
            cmbCuenta.DisplayMember = "nombre";
            cmbCuenta.ValueMember = "idCuenta";
            cmbCuenta.DataSource = logicaNegocio.obtenerCuentas();
        }

        private void cargarEstadosUsuario()
        {
            LogicaNegocio logicaNegocio = new LogicaNegocio();
            cmbEstado.DisplayMember="nombre";
            cmbEstado.ValueMember="idEstado";
            cmbEstado.DataSource = logicaNegocio.obtenerEstadosUsuarios();
        }

        
    }
}
