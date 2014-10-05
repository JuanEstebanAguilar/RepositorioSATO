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
    public partial class frmPrincipal : Form
    {
        private Boolean verificarNuevosMensajes = true;
        private BackgroundWorker bgwControladorDeChat=new BackgroundWorker();
        private BackgroundWorker bgwCargadorAccesosDirectos = new BackgroundWorker();

        public frmPrincipal()
        {
            InitializeComponent();
            
            bgwControladorDeChat.DoWork += new DoWorkEventHandler(bgwControladorDeChat_DoWork);
            bgwControladorDeChat.ProgressChanged += new ProgressChangedEventHandler(bgwControladorDeChat_ProgressChanged);
            bgwControladorDeChat.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgwControladorDeChat_RunWorkerCompleted);
            bgwControladorDeChat.RunWorkerAsync();

            bgwCargadorAccesosDirectos.WorkerReportsProgress = true;
            bgwCargadorAccesosDirectos.DoWork += new DoWorkEventHandler(bgwCargadorAccesosDirectos_DoWork);
            bgwCargadorAccesosDirectos.ProgressChanged += new ProgressChangedEventHandler(bgwCargadorAccesosDirectos_ProgressChanged);
            bgwCargadorAccesosDirectos.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgwCargadorAccesosDirectos_RunWorkerCompleted);
        }

        void bgwCargadorAccesosDirectos_DoWork(object sender, DoWorkEventArgs e)
        {
            Color colorBoton = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            Button btnImprimir = new Button();
            btnImprimir.BackColor = colorBoton;
            btnImprimir.Image = (System.Drawing.Image)Presentacion.Properties.Resources.icono_atencion_grande;
            btnImprimir.FlatStyle = FlatStyle.Flat;
            btnImprimir.FlatAppearance.BorderColor = colorBoton;
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new System.Drawing.Size(186, 143);
            btnImprimir.TabIndex = 13;
            btnImprimir.UseVisualStyleBackColor = false;
            btnImprimir.Click+=new EventHandler(btnImprimir_Click);
            bgwCargadorAccesosDirectos.ReportProgress(0, btnImprimir);
            System.Threading.Thread.Sleep(100);

            colorBoton = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            Button btnInvestigacion = new Button();
            btnInvestigacion.BackColor = colorBoton;
            btnInvestigacion.Image = (System.Drawing.Image)Presentacion.Properties.Resources.acceso_investigaciones;
            btnInvestigacion.FlatStyle = FlatStyle.Flat;
            btnInvestigacion.FlatAppearance.BorderColor = colorBoton;
            btnInvestigacion.Name = "btnInvestigacion";
            btnInvestigacion.Size = new System.Drawing.Size(186, 143);
            btnInvestigacion.TabIndex = 15;
            btnInvestigacion.UseVisualStyleBackColor = false;
            btnInvestigacion.Click += new EventHandler(btnInvestigacion_Click);
            bgwCargadorAccesosDirectos.ReportProgress(0, btnInvestigacion);
            System.Threading.Thread.Sleep(100);

            colorBoton = Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            Button btnTurnos = new Button();
            btnTurnos.BackColor = colorBoton;
            btnTurnos.Image = (System.Drawing.Image)Presentacion.Properties.Resources.acceso_turnos;
            btnTurnos.FlatStyle = FlatStyle.Flat;
            btnTurnos.FlatAppearance.BorderColor = colorBoton;
            btnTurnos.Name = "btnTurnos";
            btnTurnos.Size = new System.Drawing.Size(186, 143);
            btnTurnos.TabIndex = 14;
            btnTurnos.UseVisualStyleBackColor = false;
            btnTurnos.Click +=new EventHandler(btnTurnos_Click);
            bgwCargadorAccesosDirectos.ReportProgress(0, btnTurnos);
            System.Threading.Thread.Sleep(100);
            
            colorBoton=Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            Button btnPacientes = new Button();
            btnPacientes.BackColor = colorBoton;
            btnPacientes.Image = (System.Drawing.Image)Presentacion.Properties.Resources.acceso_pacientes;
            btnPacientes.FlatStyle = FlatStyle.Flat;
            btnPacientes.FlatAppearance.BorderColor=colorBoton;
            btnPacientes.Name = "btnPacientes";
            btnPacientes.Size = new System.Drawing.Size(186, 143);
            btnPacientes.TabIndex = 16;
            btnPacientes.UseVisualStyleBackColor = false;
            btnPacientes.Click+=new EventHandler(btnPacientes_Click);
            bgwCargadorAccesosDirectos.ReportProgress(0, btnPacientes);
            System.Threading.Thread.Sleep(100);

            colorBoton = Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            Button btnAtencion = new Button();
            btnAtencion.BackColor = colorBoton;
            btnAtencion.Image = (System.Drawing.Image)Presentacion.Properties.Resources.icono_atencion_grande;
            btnAtencion.FlatStyle = FlatStyle.Flat;
            btnAtencion.FlatAppearance.BorderColor = colorBoton;
            btnAtencion.Name = "btnAtencion";
            btnAtencion.Size = new System.Drawing.Size(186, 143);
            btnAtencion.TabIndex = 18;
            btnAtencion.UseVisualStyleBackColor = false;
            btnAtencion.Click += new EventHandler(btnAtencion_Click);
            bgwCargadorAccesosDirectos.ReportProgress(0, btnAtencion);

        }

        void btnAtencion_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void btnInvestigacion_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void bgwCargadorAccesosDirectos_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Button boton = (Button)e.UserState;
            flpAccesosDirectos.Controls.Add(boton);
        }

        void bgwCargadorAccesosDirectos_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            
        }

        private void inicializarControladorDeChat()
        {
            
        }

        void bgwControladorDeChat_DoWork(object sender, DoWorkEventArgs e)
        {
            frmMensaje vtMensajes=new frmMensaje();
            GestorDeMensajes gestorDeMensajes = new GestorDeMensajes();
            while (verificarNuevosMensajes)
            {
                System.Threading.Thread.Sleep(2000);
                if (gestorDeMensajes.verificarNuevosMensajes(103))
                    vtMensajes.ShowDialog();
            }
        }

        void bgwControladorDeChat_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        void bgwControladorDeChat_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            throw new NotImplementedException();
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
            //Negocio.SingletonPersonaLogueada personaLogueada = Negocio.SingletonPersonaLogueada.getInstancia(null);
            //this.Text = "SATO - "+personaLogueada.getPersona().Apellido + ", " + personaLogueada.getPersona().Nombre;
            bgwCargadorAccesosDirectos.RunWorkerAsync();
        }

        private void cargarItemsGrills()
        {

        }

        private void centrarImagen()
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            salirDeSistema();
        }

        private void salirDeSistema()
        {
            if (MessageBox.Show("Desea salir del sistema?", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                this.Close();
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
        
        private void ntfNotificadorVTNPrincipal_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Maximized;
            ntfNotificadorVTNPrincipal.Visible = false;
        }

        private void frmPrincipal_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                ntfNotificadorVTNPrincipal.Visible = true;
            }
        }

        private void diagramaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDiagramacion vtDiagramacion = new frmDiagramacion();
            vtDiagramacion.ShowDialog();
        }
    }
}
