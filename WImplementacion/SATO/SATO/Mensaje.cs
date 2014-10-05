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
    public partial class frmMensaje : Form
    {
        private Boolean buscarMensajes = true;
        private static int ID_MENSAJE_LEIDO=1;
        private static int ID_MENSAJE_NO_LEIDO=2;
        private static int ID_MENSAJE_ENVIADO=1;
        private static int ID_MENSAJE_RECIBIDO=2;
        private static int ID_PERSONA=100;
        private static String NOMBRE_USUARIO;
        
        public frmMensaje()
        {
            InitializeComponent();
            inicializarTareas();
            bgwBuscadorDeHistorialDeMensajes.RunWorkerAsync();
            //bgwBuscadorDeParametros.RunWorkerAsync();
        }
        
        public void inicializarTareas()
        {
            bgwBuscadorDeHistorialDeMensajes.DoWork += new DoWorkEventHandler(bgwBuscadorDeHistorialDeMensajes_DoWork);
            bgwBuscadorDeHistorialDeMensajes.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgwBuscadorDeHistorialDeMensajes_RunWorkerCompleted);
            bgwBuscadorDeHistorialDeMensajes.ProgressChanged += new ProgressChangedEventHandler(bgwBuscadorDeHistorialDeMensajes_ProgressChanged);

            bgwEnviadorDeMensajes.DoWork += new DoWorkEventHandler(bgwEnviadorDeMensajes_DoWork);
            bgwEnviadorDeMensajes.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgwEnviadorDeMensajes_RunWorkerCompleted);
            bgwEnviadorDeMensajes.ProgressChanged += new ProgressChangedEventHandler(bgwEnviadorDeMensajes_ProgressChanged);

            bgwBuscadorDeNuevosMensajes.DoWork += new DoWorkEventHandler(bgwBuscadorDeNuevosMensajes_DoWork);
            bgwBuscadorDeNuevosMensajes.ProgressChanged += new ProgressChangedEventHandler(bgwBuscadorDeNuevosMensajes_ProgressChanged);
            bgwBuscadorDeNuevosMensajes.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgwBuscadorDeNuevosMensajes_RunWorkerCompleted);

            bgwBuscadorDeParametros.DoWork += new DoWorkEventHandler(bgwBuscadorDeParametros_DoWork);
            bgwBuscadorDeParametros.ProgressChanged += new ProgressChangedEventHandler(bgwBuscadorDeParametros_ProgressChanged);
            bgwBuscadorDeParametros.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgwBuscadorDeParametros_RunWorkerCompleted);
        }

        void bgwBuscadorDeParametros_DoWork(object sender, DoWorkEventArgs e)
        {
            
        }

        void bgwBuscadorDeParametros_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        void bgwBuscadorDeParametros_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            throw new NotImplementedException();
        }

        void bgwBuscadorDeNuevosMensajes_DoWork(object sender, DoWorkEventArgs e)
        {
            GestorDeMensajes negocio = new GestorDeMensajes();

            while (buscarMensajes)
            {
                System.Threading.Thread.Sleep(10000);
                List<Mensaje> mensajes = negocio.obtenerNuevosMensajes(100);
                if (mensajes != null)
                {
                    foreach (Mensaje mensaje in mensajes)
                    {
                        bgwBuscadorDeNuevosMensajes.ReportProgress(1, mensaje);
                    }
                }
            }
        }

        void bgwBuscadorDeNuevosMensajes_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Mensaje mensaje = (Mensaje)e.UserState;
            dibujarMensaje(mensaje);
        }

        void bgwBuscadorDeNuevosMensajes_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            
        }


        void bgwBuscadorDeHistorialDeMensajes_DoWork(object sender, DoWorkEventArgs e)
        {
            GestorDeMensajes negocio = new GestorDeMensajes();
            List<Mensaje> mensajes = negocio.obtenerHistorialDeMensajes(100,103);
            if (mensajes != null)
            {
                foreach (Mensaje mensaje in mensajes)
                {
                    bgwBuscadorDeHistorialDeMensajes.ReportProgress(1, mensaje);
                }
            }
        }

        void bgwBuscadorDeHistorialDeMensajes_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Mensaje mensaje = (Mensaje)e.UserState;
            dibujarMensaje(mensaje);
            
        }

        void bgwBuscadorDeHistorialDeMensajes_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            bgwBuscadorDeNuevosMensajes.RunWorkerAsync();
        }

        private void dibujarMensaje(Mensaje mensaje)
        {
            TextBox txtContenido = new TextBox();
            txtContenido.Text = mensaje.Contenido;

            int alto;

            if ((mensaje.Contenido.Length) /20 <= 1)
                alto = 1*20;
            else
                alto = ((mensaje.Contenido.Length) / 20)*20;

            txtContenido.Font = new Font("Arial", 10);
            txtContenido.Size = new Size(197, alto);
            txtContenido.Multiline = true;
            txtContenido.BorderStyle = BorderStyle.None;
            
            TextBox txtHoraFecha = new TextBox();
            txtHoraFecha.Text = mensaje.FechaHora.ToString();
            txtHoraFecha.Font = new Font("Arial", 7);
            txtHoraFecha.Size = new Size(130, 60);
            txtHoraFecha.Multiline = false;
            txtHoraFecha.BorderStyle = BorderStyle.None;

            FlowLayoutPanel flpMensaje = new FlowLayoutPanel();
            flpMensaje.AutoSize = true;
            flpMensaje.Size = new Size(130, alto + 10);

            if (mensaje.TipoMensaje.getIdTipoMensaje().Equals(1))
            {
                flpMensaje.BackColor = Color.PapayaWhip;
                txtContenido.BackColor = Color.PapayaWhip;
                txtHoraFecha.BackColor = Color.PapayaWhip;
            }
            else
            {
                flpMensaje.BackColor = Color.LightSteelBlue;
                txtContenido.BackColor = Color.LightSteelBlue;
                txtHoraFecha.BackColor = Color.LightSteelBlue;
            }
            flpMensaje.Controls.Add(txtHoraFecha);
            flpMensaje.Controls.Add(txtContenido);
            flpHistorial.Controls.Add(flpMensaje);
            flpHistorial.VerticalScroll.Value = flpHistorial.VerticalScroll.Minimum;
        }

        private void btnEnviarMensaje_Click(object sender, EventArgs e)
        {
            String contenido=txtMensaje.Text.Trim().ToString();
            Persona persona = new Persona(100, "", "");
            Mensaje mensaje = new Mensaje(contenido, persona);

            bgwEnviadorDeMensajes.RunWorkerAsync(mensaje);
        }

        void bgwEnviadorDeMensajes_DoWork(object sender, DoWorkEventArgs e)
        {
            Mensaje mensaje=(Mensaje)e.Argument;

            GestorDeMensajes negocio = new GestorDeMensajes();
            if (negocio.tomarMensaje(mensaje))
                bgwEnviadorDeMensajes.ReportProgress(1,mensaje);
            else
                MessageBox.Show("Mensaje no enviado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        void bgwEnviadorDeMensajes_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            dibujarMensaje((Mensaje)e.UserState);
            txtMensaje.Text = "";
            txtMensaje.Focus();
        }

        void bgwEnviadorDeMensajes_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            
        }

        private void frmMensaje_Load(object sender, EventArgs e)
        {

        }
    }
}
