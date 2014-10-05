using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();

        }

        public frmPrincipal(String usuario)
        {
            InitializeComponent();
            tscUsuario.Text = usuario;
        }

        private void gestiónToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrarVentanaPacientes();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            salirDeSistema();
        }

        private void turnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrarVentanaTurnos();
        }

        private void mostrarVentanaTurnos()
        {
            frmTurnos vtTurno = new frmTurnos();
            vtTurno.ShowDialog();
        }

        private void mensajesDialogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCuadrosDialogo vtCuadroDialogo = new frmCuadrosDialogo();
            vtCuadroDialogo.ShowDialog();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            //frmLogin vtLogin = new frmLogin();
            //vtLogin.ShowDialog();

        }

        private void cargarItemsGrills()
        {

        }

        private void centrarImagen()
        {

        }

        private void tmrReloj_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToShortTimeString();
            lblFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            cerrarSesion();
        }

        private void salirDeSistema()
        {
            if (MessageBox.Show("Desea salir del sistema?", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                this.Close();
            }
        }
        private void cerrarSesion()
        {
            if (MessageBox.Show("Desea cerrar Sesión?", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                frmLogin vtLogin = new frmLogin();
                vtLogin.ShowDialog();
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            mostrarVentanaPacientes();
        }

        private void mostrarVentanaPacientes()
        {
            frmPaciente vtPaciente = new frmPaciente();
            vtPaciente.ShowDialog();

        }

        private void tsbTurnos_Click(object sender, EventArgs e)
        {
            mostrarVentanaTurnos();
        }

        private void profesionalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrarVentanaProfesionales();
        }

        private void mostrarVentanaProfesionales()
        {
            frmProfesional vtProfesional = new frmProfesional();
            vtProfesional.ShowDialog();
        }

        private void trabajadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrarVentanaTrabajadores();
        }

        private void mostrarVentanaTrabajadores()
        {
            frmEmpleado vtEmpleados = new frmEmpleado();
            vtEmpleados.ShowDialog();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrarVentanaUsuarios();
        }

        private void mostrarVentanaUsuarios()
        {
            /*frmUsuario vtUsuarios = new frmUsuario();
            vtUsuarios.ShowDialog();*/
        }

        private void stpNotificaciones_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnTurnos_Click(object sender, EventArgs e)
        {
            frmTurnos vtTurnos = new frmTurnos();
            vtTurnos.ShowDialog();
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            frmPaciente vtPacientes = new frmPaciente();
            vtPacientes.ShowDialog();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmDiagramacion vtDiagramacion = new frmDiagramacion();
            vtDiagramacion.ShowDialog();
        }

        private void btnPacientes_Click_1(object sender, EventArgs e)
        {
            frmPaciente vtpaciente = new frmPaciente();
            vtpaciente.ShowDialog();
        }

        private void btnTurnos_Click_1(object sender, EventArgs e)
        {
            frmTurnos vtturnos = new frmTurnos();
            vtturnos.ShowDialog();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmDiagramacion vtdiagramacion = new frmDiagramacion();
            vtdiagramacion.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmAtencion vtAtencion = new frmAtencion();
            vtAtencion.ShowDialog();
        }
    }
}
