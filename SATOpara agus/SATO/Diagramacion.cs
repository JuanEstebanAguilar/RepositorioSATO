using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;
using Negocio;

namespace Presentacion
{
    public partial class frmDiagramacion : Form
    {
        private String[] dias = new String[] { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes" };
        private Color[] colores = new Color[] { Color.DarkSeaGreen, Color.Gray, Color.Gold };
        private Color[] coloresAleatorios = new Color[] { Color.AliceBlue, Color.Bisque, Color.CadetBlue };
        
        private List<DiaDiagramacion> lstDiasDiagramacion = new List<DiaDiagramacion>();
        private List<DetalleDia> lstDetallesDiaLunes = new List<DetalleDia>();
        private List<DetalleDia> lstDetallesDiaMartes = new List<DetalleDia>();
        private List<DetalleDia> lstDetallesDiaMiercoles = new List<DetalleDia>();
        private List<DetalleDia> lstDetallesDiaJueves = new List<DetalleDia>();
        private List<DetalleDia> lstDetallesDiaViernes = new List<DetalleDia>();

        public frmDiagramacion()
        {
            InitializeComponent();
        }
              
        private void dibujarGrilla()
        {
            //Carga los días
            tlpDiagramacion.RowCount = 79;
            for (int i = 0; i <= 4; i++)
            {
                Label lblDia = new Label();
                lblDia.TextAlign = ContentAlignment.MiddleCenter;
                lblDia.Name = dias[i].ToString();
                lblDia.Text = dias[i].ToString();
                lblDia.Font = new Font("Arial", 12);

                tlpDiagramacion.Controls.Add(lblDia, i + 2, 0);
            }

            //Carga las horas
            DateTime horas = new DateTime(2013, 03, 03, 08, 00, 00);

            int fila;
            for (int i = 0; i <= 12; i++)
            {
                Label lblHora = new Label();
                lblHora.TextAlign = ContentAlignment.TopRight;
                lblHora.Name = String.Format("{0:HH}", horas).ToString();
                lblHora.Text = String.Format("{0:HH}", horas).ToString();
                lblHora.Font = new Font("Arial", 20);
                lblHora.Width = 60;
                lblHora.Height = 160;
                fila = 1 + i * 4;
                tlpDiagramacion.Controls.Add(lblHora, 0, fila);
                tlpDiagramacion.SetRowSpan(lblHora, 4);

                tlpDiagramacion.RowStyles.Add(new RowStyle());

                DateTime minutos = new DateTime(2013, 03, 03, 08, 00, 00);
                //Carga los minutos
                for (int j = fila; j <= fila + 3; j++)
                {
                    Label lblMinuto = new Label();
                    lblMinuto.TextAlign = ContentAlignment.TopRight;
                    lblMinuto.Name = String.Format("{0:HH}", horas).ToString() + ":" + String.Format("{0:mm}", minutos).ToString();
                    lblMinuto.Text = String.Format("{0:mm}", minutos).ToString();
                    lblMinuto.Font = new Font("Arial", 7);
                    lblMinuto.Width = 40;
                    lblMinuto.Height = 40;
                    tlpDiagramacion.Controls.Add(lblMinuto, 1, j);
                    minutos = minutos.AddMinutes(15);
                }
                horas = horas.AddHours(1);
            }
        }

        private void frmDiagramacion_Load(object sender, EventArgs e)
        {
            dibujarGrilla();
            cargarProfesionales();
            cargarEstadosDetalleDia();
            cargarDias();
            cargarEstadosDiagramacion();
            cargarMotivosExcepcion();

            tttComentario.SetToolTip(btnNuevo, btnNuevo.Tag.ToString());
            tttComentario.SetToolTip(btnCancelar, btnCancelar.Tag.ToString());
        }

        private void cargarEstadosDiagramacion()
        {
            LogicaNegocio logica = new LogicaNegocio();
            List<EstadoDiagramacion> estados = logica.obtenerEstadosDiagramacion();
            if (estados != null)
            {
                foreach (EstadoDiagramacion estado in estados)
                {
                    cmbEstadoDiagramacion.Items.Add(estado);
                }
                cmbEstadoDiagramacion.SelectedIndex = 0;
            }
        }

        private void cargarDias()
        {
            LogicaNegocio logica = new LogicaNegocio();
            List<DiaSemana> dias = logica.obtenerDiasSemana();
            if (dias != null)
            {
                foreach (DiaSemana dia in dias)
                {
                    clsDias.Items.Add(dia);
                }
                
            }
        }

        private void cargarEstadosDetalleDia()
        {
            LogicaNegocio logica = new LogicaNegocio();
            List<EstadoDetalleDia> estados = logica.obtenerEstadosDetalleDia();
            if (estados != null)
            {
                foreach (EstadoDetalleDia estado in estados)
                {
                    cmbEstadoDetalle.Items.Add(estado);
                }
                cmbEstadoDetalle.SelectedIndex = 0;
            }
        }

        private void cargarProfesionales()
        {

            Negocio.LogicaNegocio negocio = new Negocio.LogicaNegocio();
            List<Entidades.Profesional> lsProfesionales = negocio.obtenerProfesionalesParaDiagramacion();
            if (lsProfesionales != null)
            {
                foreach (Entidades.Profesional profesional in lsProfesionales)
                {
                    cmbProfesionales.Items.Add(profesional);
                }
                cmbProfesionales.SelectedIndex = 0;
            }
        }

        private void dibujarDiagramacion(DetalleDia detalle, int dia)
        {
            Color colorAUsar = colores[detalle.Estado.IdEstadoDetalleDia - 1];
            
            int duracion = ((int)(detalle.HoraFin - detalle.HoraInicio).TotalMinutes);
            FlowLayoutPanel flpDiagramacion = new FlowLayoutPanel();
            flpDiagramacion.Name = detalle.IdDetalleDia.ToString();
            flpDiagramacion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            flpDiagramacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            flpDiagramacion.BackColor = colorAUsar;
            flpDiagramacion.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flpDiagramacion.Location = new System.Drawing.Point(470, 74);
            flpDiagramacion.Size = new System.Drawing.Size(130, duracion * 40 / 15);
            flpDiagramacion.TabIndex = 0;
            flpDiagramacion.Click += new EventHandler(flpDiagramacion_Click);
            flpDiagramacion.WrapContents = false;

            /*Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tag = detalle.IdDetalleDia.ToString();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();*/

            Label lblEstado = new Label();
            lblEstado.Font = new Font("Arial", 8, FontStyle.Bold);
            lblEstado.AutoSize = true;
            flpDiagramacion.Controls.Add(lblEstado);

            Label lblHorario = new Label();
            lblHorario.Font = new Font("Arial", 8, FontStyle.Italic);
            lblHorario.Text = String.Format("{0:HH:mm}", detalle.HoraInicio) + " - " + String.Format("{0:HH:mm}", detalle.HoraFin);
            flpDiagramacion.Controls.Add(lblHorario);

            //calcula la ubicación del turno
            Control[] controles = tlpDiagramacion.Controls.Find(String.Format("{0:HH:mm}", detalle.HoraInicio), false);
            TableLayoutPanelCellPosition coordenadas = tlpDiagramacion.GetCellPosition(controles[0]);
            int fila = coordenadas.Row;
            int columna = dia+1;
            tlpDiagramacion.SetRowSpan(flpDiagramacion, duracion / 15);
            tlpDiagramacion.Controls.Add(flpDiagramacion, columna, fila);
            flpDiagramacion = null;
   
        }

        void timer_Tick(object sender, EventArgs e)
        {
            Timer timer = (Timer)sender;
            Object[] objetos = tlpDiagramacion.Controls.Find(timer.Tag.ToString(), false);
            FlowLayoutPanel flow = (FlowLayoutPanel)objetos[0];
            Random rnd=new Random();
            int idColor=rnd.Next(0,3);
            flow.BackColor = coloresAleatorios[idColor];
        }

        void flpDiagramacion_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Diagramacion diagramacion = new Diagramacion();
            diagramacion.Profesional = (Profesional)cmbProfesionales.SelectedItem;
            diagramacion.Estado = (EstadoDiagramacion)cmbEstadoDiagramacion.SelectedItem;
            diagramacion.FechaAlta = DateTime.Now;
            diagramacion.FechaDesde = dtpFechaInicio.Value;
            diagramacion.FechaHasta = dtpFechaFin.Value;
            diagramacion.DiasDiagramacion = new List<DiaDiagramacion>();


            foreach (DiaSemana dia in clsDias.Items)
            {
                DiaSemana diaSemana = (DiaSemana)dia;
                int idDiaSemana = diaSemana.IdDiaSemana;
                switch (diaSemana.Nombre.ToString())
                {
                    case "Lunes":
                        {
                            if (lstDetallesDiaLunes.Count > 0)
                            {
                                List<DiaDiagramacion> diasDiagramacion = calcularFechasSegunDia(diagramacion.FechaDesde, diagramacion.FechaHasta, idDiaSemana);
                                foreach (DiaDiagramacion diaDiagramacion in diasDiagramacion)
                                {
                                    diaDiagramacion.DetallesDia = lstDetallesDiaLunes;
                                    diagramacion.DiasDiagramacion.Add(diaDiagramacion);
                                }
                            }
                            break;
                        }
                    case "Martes":
                        {
                            if (lstDetallesDiaMartes.Count > 0)
                            {
                                List<DiaDiagramacion> diasDiagramacion = calcularFechasSegunDia(diagramacion.FechaDesde, diagramacion.FechaHasta, idDiaSemana);
                                foreach (DiaDiagramacion diaDiagramacion in diasDiagramacion)
                                {
                                    diaDiagramacion.DetallesDia = lstDetallesDiaMartes;
                                    diagramacion.DiasDiagramacion.Add(diaDiagramacion);
                                }
                            }
                            break;
                        }
                    case "Miércoles":
                        {
                            if (lstDetallesDiaMiercoles.Count > 0)
                            {
                                List<DiaDiagramacion> diasDiagramacion = calcularFechasSegunDia(diagramacion.FechaDesde, diagramacion.FechaHasta, idDiaSemana);
                                foreach (DiaDiagramacion diaDiagramacion in diasDiagramacion)
                                {
                                    diaDiagramacion.DetallesDia = lstDetallesDiaMiercoles;
                                    diagramacion.DiasDiagramacion.Add(diaDiagramacion);
                                }
                        }
                            break;
                        }
                    case "Jueves":
                        {
                            if (lstDetallesDiaJueves.Count > 0)
                            {
                                List<DiaDiagramacion> diasDiagramacion = calcularFechasSegunDia(diagramacion.FechaDesde, diagramacion.FechaHasta, idDiaSemana);
                                foreach (DiaDiagramacion diaDiagramacion in diasDiagramacion)
                                {
                                    diaDiagramacion.DetallesDia = lstDetallesDiaJueves;
                                    diagramacion.DiasDiagramacion.Add(diaDiagramacion);
                                }
                            }
                            break;
                        }
                    case "Viernes":
                        {
                            if (lstDetallesDiaViernes.Count > 0)
                            {
                                List<DiaDiagramacion> diasDiagramacion = calcularFechasSegunDia(diagramacion.FechaDesde, diagramacion.FechaHasta, idDiaSemana);
                                foreach (DiaDiagramacion diaDiagramacion in diasDiagramacion)
                                {
                                    diaDiagramacion.DetallesDia = lstDetallesDiaViernes;
                                    diagramacion.DiasDiagramacion.Add(diaDiagramacion);
                                }
                            }
                            break;
                        }
                }
            }

            LogicaNegocio logica = new LogicaNegocio();
            if(logica.tomarDiagramacion(diagramacion))
                MessageBox.Show("Diagramación registrada","Atención",MessageBoxButtons.OK,MessageBoxIcon.Information);
            else
                MessageBox.Show("Diagramación no registrada", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private List<DiaDiagramacion> calcularFechasSegunDia(DateTime fechaDesde, DateTime fechaHasta, int idDiaSemana)
        {
            List<DiaDiagramacion> diasDiagramacion = new List<DiaDiagramacion>();
            DiaDiagramacion diaDiagramacion=new DiaDiagramacion();
            for (DateTime fecha = fechaDesde; fecha <= fechaHasta; fecha = fecha.AddDays(1))
            {
                if (fecha.DayOfWeek != DayOfWeek.Saturday && fecha.DayOfWeek != DayOfWeek.Sunday && idDiaSemana==(int)fecha.DayOfWeek)
                {
                    diaDiagramacion.Fecha = fecha;
                    break;
                }
            }

            for (DateTime fecha = diaDiagramacion.Fecha; fecha <= fechaHasta;fecha=fecha.AddDays(7))
            {
                DiaDiagramacion diaDiagrama = new DiaDiagramacion();
                diaDiagrama.Fecha = fecha;
                EstadoDiaDiagramacion estado = new EstadoDiaDiagramacion();
                estado.IdEstadoDiaDiagramacion = 1;
                diaDiagrama.Estado = estado;
                diasDiagramacion.Add(diaDiagrama);
            }
            return diasDiagramacion;
        }

        private void cargarGrilla()
        {
            Negocio.LogicaNegocio negocio = new Negocio.LogicaNegocio();

            //calcula los extremos de la semana
            DateTime fechaSeleccionada = dtpFecha.Value;
            DateTime fechaDesde = DateTime.MinValue;
            DateTime fechaHasta = DateTime.MinValue;
            fechaDesde = fechaSeleccionada.AddDays(1 - Convert.ToDouble(fechaSeleccionada.DayOfWeek));
            fechaHasta = fechaSeleccionada.AddDays(5 - Convert.ToDouble(fechaSeleccionada.DayOfWeek));
    
            int idProfesional = ((Entidades.Profesional)cmbProfesionales.SelectedItem).Idprofesional;

            Diagramacion diagramacion = negocio.obtenerDiagramacionPorSemana(fechaDesde, fechaHasta, idProfesional);

            cmbProfesionales.SelectedItem = diagramacion.Profesional.Idprofesional;
            dtpFechaInicio.Value = diagramacion.FechaDesde;
            dtpFechaFin.Value = diagramacion.FechaHasta;
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            limpiarGrilla();
            cargarDiagramacion();
        }

        private void cargarDiagramacion()
        { 
            LogicaNegocio logica = new LogicaNegocio();
            DateTime fecha = dtpFecha.Value;
            int idProfesional=((Profesional)cmbProfesionales.SelectedItem).Idprofesional;
            Diagramacion diagramacion = logica.obtenerDiagramacionPorFechaYProfesional(fecha, idProfesional);
            if (diagramacion != null)
            {
                foreach (DiaDiagramacion diaDiagramacion in diagramacion.DiasDiagramacion)
                { 
                    int numeroDia=(int)diaDiagramacion.Fecha.DayOfWeek;
                    foreach(DetalleDia detalleDia in diaDiagramacion.DetallesDia)
                    {
                        dibujarDiagramacion(detalleDia, numeroDia);
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarGrilla();
        }

        private void limpiarGrilla()
        {
            foreach (Control control in tlpDiagramacion.Controls)
            {
                if (control is FlowLayoutPanel)
                {
                    tlpDiagramacion.Controls.Remove(control);
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            dtpHoraDesde.Value = Convert.ToDateTime("08:00".ToString());
            dtpHoraHasta.Value = Convert.ToDateTime("08:00".ToString());
            limpiarGrilla();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarDetalle_Click(object sender, EventArgs e)
        {
            DetalleDia detalleDia = new DetalleDia();
            detalleDia.HoraInicio = dtpHoraDesde.Value;
            detalleDia.HoraFin = dtpHoraHasta.Value;
            detalleDia.Estado = (EstadoDetalleDia)cmbEstadoDetalle.SelectedItem;

            foreach (Object item in clsDias.CheckedItems)
            {
                DiaSemana diaSemana = (DiaSemana)item;
                int idDiaSemana = diaSemana.IdDiaSemana;
                switch (diaSemana.Nombre.ToString())
                {
                    case "Lunes":
                        {
                            lstDetallesDiaLunes.Add(detalleDia);
                            break;
                        }
                    case "Martes":
                        {
                            lstDetallesDiaMartes.Add(detalleDia);
                            break;
                        }
                    case "Miércoles":
                        {
                            lstDetallesDiaMiercoles.Add(detalleDia);
                            break;
                        }
                    case "Jueves":
                        {
                            lstDetallesDiaJueves.Add(detalleDia);
                            break;
                        }
                    case "Viernes":
                        {
                            lstDetallesDiaViernes.Add(detalleDia);
                            break;
                        }
                }
                dibujarDiagramacion(detalleDia, idDiaSemana);
            }
        }
        private void cargarMotivosExcepcion()
        {
            Negocio.LogicaNegocio negocio = new Negocio.LogicaNegocio();
            List<MotivoExcepcion> lsMotivos = negocio.obtenerMotivosExcepcion();
            if (lsMotivos != null)
            {
                foreach (MotivoExcepcion motivo in lsMotivos)
                {
                    cmbMotivoExcepcion.Items.Add(motivo);
                }
                cmbMotivoExcepcion.SelectedIndex = 0;
            }
        }

        private void cmbMotivoExcepcion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private List<DateTime> calcularFechas(DateTime fechaDesde,DateTime fechaHasta)
        {
            List<DateTime> fechas = new List<DateTime>();

            for(DateTime fecha=fechaDesde;fecha<=fechaHasta;fecha=fecha.AddDays(1))
            {
                if (fecha.DayOfWeek != DayOfWeek.Saturday && fecha.DayOfWeek != DayOfWeek.Sunday)
                {
                    fechas.Add(fecha);
                }
            }
            return fechas;
        }

        private void dtpHoraDesde_ValueChanged(object sender, EventArgs e)
        {

        }
        
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dtpFechaFin_ValueChanged(object sender, EventArgs e)
        {

        }
    }
} 
