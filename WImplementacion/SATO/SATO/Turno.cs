using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Negocio;
using System.Collections;
using Entidades;

namespace Presentacion
{
    public partial class frmTurnos : Form
    {
        private Color COLORTURNOCANCELADO = Color.CadetBlue;
        private Color COLORTURNOCONFIRMADO = Color.Moccasin;
        private Color COLORTURNOELIMINADO = Color.BurlyWood;
        private Color COLORTURNOGENERADO = Color.Coral;
        private Color COLORTURNOENESPERA=Color.MediumSpringGreen;
        private Color COLORTURNOCUMPLIDO=Color.LightSteelBlue;

        private int IDTURNOCANCELADO = 1;
        private int IDTURNOCONFIRMADO = 2;
        private int IDTURNOELIMINADO = 3;
        private int IDTURNOGENERADO = 4;
        private int IDTURNOENESPERA = 5;
        private int IDTURNOCUMPLIDO = 6;
        
        private List<int> lsIdTurnos = new List<int>(); //Mantiene una lista de los IDs de turnos para
                                                        //poder borrar los FlowLayout con LimpiarGrilla
        private DateTime fechaSemanaDesde;
        private DateTime fechaSemanaHasta;
        private int idProfesionalSeleccionado;
        private DateTime fechaSeleccionada;
        
        protected FlowLayoutPanel flpControles;
        protected FlowLayoutPanel flpTurno;
        
        protected Panel panelPrueba;
        protected Button botonPrueba;

        BackgroundWorker bgwPintadorDeTurno;
        BackgroundWorker bgwBuscadorDeTurnosSemanales;
        BackgroundWorker bgwDibujadorDeNuevoTurno;

        private Rectangle rectanguloFlpTurno;

        private Validador validador = new Validador();

        public frmTurnos()
        {
            InitializeComponent();

            cmbProfesional.SelectionChangeCommitted += new EventHandler(cargarTurnos);
            dtpFecha.ValueChanged += new EventHandler(cargarTurnos);

            bgwBuscadorDeTurnosSemanales = new BackgroundWorker();
            bgwBuscadorDeTurnosSemanales.WorkerReportsProgress = true;
            bgwBuscadorDeTurnosSemanales.DoWork += new DoWorkEventHandler(bgwBuscadorDeTurnosSemanales_DoWork);
            bgwBuscadorDeTurnosSemanales.ProgressChanged += new ProgressChangedEventHandler(bgwBuscadorDeTurnosSemanales_ProgressChanged);
            bgwBuscadorDeTurnosSemanales.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgwBuscadorDeTurnosSemanales_RunWorkerCompleted);

            bgwDibujadorDeNuevoTurno = new BackgroundWorker();
            bgwDibujadorDeNuevoTurno.WorkerReportsProgress = true;
            bgwDibujadorDeNuevoTurno.DoWork += new DoWorkEventHandler(bgwDibujadorDeTurnoNuevo_DoWork);
            bgwDibujadorDeNuevoTurno.ProgressChanged += new ProgressChangedEventHandler(bgwDibujadorDeTurnoNuevo_ProgressChanged);
            bgwDibujadorDeNuevoTurno.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgwDibujadorDeTurnoNuevo_RunWorkerCompleted);
        }

        private void Turno_Load(object sender, EventArgs e)
        {
            dibujarGrilla(dtpFecha.Value);
            cargarCabeceraGrilla();
            cargarProfesionales();
            if (cmbProfesional.Items.Count > 0)
            {
                setParametrosDeBusquedaSemanal(dtpFecha.Value, (Profesional)cmbProfesional.SelectedItem);
                cargarHoraPrueba();
                
                cargarPacientes();
                cargarPracticas();
                bgwBuscadorDeTurnosSemanales.RunWorkerAsync(getParametrosDeBusquedaSemanal());
            }
        }

        private void setParametrosDeBusquedaSemanal(DateTime fecha,Profesional profesional)
        {
            DateTime[] fechas = calcularSemana(fecha);
            fechaSemanaDesde=fechas[0];
            fechaSemanaHasta=fechas[1];
            idProfesionalSeleccionado = profesional.Idprofesional;
        }

        private ArrayList getParametrosDeBusquedaSemanal()
        {

            return new ArrayList() { fechaSemanaDesde,fechaSemanaHasta,idProfesionalSeleccionado};
        }

        //Solo actualizar cuando cambia el profesional o la fecha seleccionada está fuera de la semana actual
        private void cargarTurnos(object sender, EventArgs e)
        {
            try
            {
                ArrayList parametrosBusqueda = getParametrosDeBusquedaSemanal();
                int idProfesional = ((Profesional)cmbProfesional.SelectedItem).Idprofesional;
                fechaSeleccionada = dtpFecha.Value;
                if (idProfesional != (int)parametrosBusqueda[2] || fechaSeleccionada < (DateTime)parametrosBusqueda[0] || fechaSeleccionada > (DateTime)parametrosBusqueda[1])
                {
                    setParametrosDeBusquedaSemanal(fechaSeleccionada, (Profesional)cmbProfesional.SelectedItem);
                    cargarCabeceraGrilla();
                    limpiarGrilla();
                    bgwBuscadorDeTurnosSemanales.RunWorkerAsync(getParametrosDeBusquedaSemanal());
                }
            }
            catch (InvalidOperationException ex)
            { }
        }
        
        private void cargarHoraPrueba()
        {
            dtpHoraDesde.Value = Convert.ToDateTime("08:00");
            dtpHoraHasta.Value = Convert.ToDateTime("08:00");
        }

        private void cargarProfesionales()
        {
            GestorDePersonas gestorDePersonas = new GestorDePersonas();

            List<Profesional> lsProfesionales = gestorDePersonas.obtenerTodosProfesionales();
            if (lsProfesionales != null)
            {
                foreach (Profesional profesional in lsProfesionales)
                {
                    cmbProfesional.Items.Add(profesional);
                }
                cmbProfesional.SelectedIndex = 0;
                cmbProfesional.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cmbProfesional.AutoCompleteSource = AutoCompleteSource.ListItems;
                
            }
        }

        private void cargarPacientes()
        {
            GestorDePersonas gestorDePersonas = new GestorDePersonas();

            List<Paciente> lsPacientes = gestorDePersonas.obtenerTodosPacientes();

            if (lsPacientes != null)
            {
                foreach (Persona persona in lsPacientes)
                {
                    cmbPaciente.Items.Add(persona);
                }
                cmbPaciente.SelectedIndex = 0;
                cmbPaciente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cmbPaciente.AutoCompleteSource = AutoCompleteSource.ListItems;

            }
        }

        private void cargarPracticas()
        {
            GestorDePersonas gestorDePersonas = new GestorDePersonas();

            List<Practica> lsPracticas = gestorDePersonas.obtenerPracticas();

            if (lsPracticas!=null)
            {
                foreach (Practica practica in lsPracticas)
                {
                    cmbPracticas.Items.Add(practica);
                }
                cmbPracticas.SelectedIndex = 0;
                cmbPracticas.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cmbPracticas.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
        }

        void bgwBuscadorDeTurnosSemanales_DoWork(object sender, DoWorkEventArgs e)
        {
            ArrayList parametros = e.Argument as ArrayList;
            DateTime fechaDesde = (DateTime)parametros[0];
            DateTime fechaHasta = (DateTime)parametros[1];
            int idProfesional=(int)parametros[2];
            
            GestorDeTurnos gestorDeTurnos = new GestorDeTurnos();
            List<Turno> lsTurnos = gestorDeTurnos.obtenerTurnosPorSemana(fechaDesde,fechaHasta, idProfesional);
            if (lsTurnos != null)
            {
                //lsFlowLayout es un listado con todos los turnos que luegon se dibujarán
                List<FlowLayoutPanel> lsFlowLayoutTurnos = new List<FlowLayoutPanel>();
                foreach (Turno turno in lsTurnos)
                {
                    //configurarDibujoDeTurno devuelve el FlowLayout turno listo para agregar
                    lsFlowLayoutTurnos.Add(configurarDibujoDeTurno(turno));
                }
                e.Result = lsFlowLayoutTurnos;
            }
        }

        void bgwBuscadorDeTurnosSemanales_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            
        }

        void bgwBuscadorDeTurnosSemanales_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            List<FlowLayoutPanel> lsFlowLayoutTurnos = e.Result as List<FlowLayoutPanel>;
            if (lsFlowLayoutTurnos != null)
            {
                foreach(FlowLayoutPanel flpTurno in lsFlowLayoutTurnos)
                {
                    ubicarTurno(flpTurno);
                    //Configura un BackgroundWorker para cada turno y lo ejecuta
                    bgwPintadorDeTurno = new BackgroundWorker();
                    bgwPintadorDeTurno.WorkerReportsProgress = true;
                    bgwPintadorDeTurno.DoWork += new DoWorkEventHandler(bgwPintadorDeTurnos_DoWork);
                    bgwPintadorDeTurno.ProgressChanged += new ProgressChangedEventHandler(bgwPintadorDeTurnos_ProgressChanged);
                    bgwPintadorDeTurno.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgwPintadorDeTurnos_RunWorkerCompleted);
                    bgwPintadorDeTurno.RunWorkerAsync(flpTurno);
                }
            }
        }

        private FlowLayoutPanel configurarDibujoDeTurno(Turno turno)
        {
            lsIdTurnos.Add(turno.IdTurno);
            int duracion = ((int)(turno.HoraFin - turno.HoraInicio).TotalMinutes);
            FlowLayoutPanel flpTurno = new FlowLayoutPanel();
            flpTurno.Name = turno.IdTurno.ToString();
            flpTurno.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            flpTurno.BackColor = Color.Transparent;
            flpTurno.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flpTurno.Location = new System.Drawing.Point(470, 74);
            flpTurno.Tag = turno;
            flpTurno.Size = new System.Drawing.Size(130, duracion * 40 / 15);
            flpTurno.TabIndex = 0;
            flpTurno.Visible = false;
            flpTurno.WrapContents = false;
            flpTurno.Padding = new Padding(0);
            String textoToolTip="Id: "+turno.IdTurno+Environment.NewLine+
                                "Paciente: "+turno.Paciente.ToString()+
                                "Fecha: "+turno.FechaTurno.ToShortDateString()+Environment.NewLine+
                                "Hora desde: " + turno.HoraInicio.ToShortTimeString() + " a " + turno.HoraFin.ToShortTimeString() + Environment.NewLine;
            tltTurnos.SetToolTip(flpTurno, textoToolTip);
            flpTurno.Click += new EventHandler(mostrarDatosTurno);
            flpTurno.MouseEnter += new EventHandler(mostrarControlesTurno);
            flpTurno.MouseLeave+=new EventHandler(ocultarControlesTurno);

            Label lblIdTurno = new Label();
            lblIdTurno.Name = turno.IdTurno.ToString();
            lblIdTurno.Font = new Font("Arial", 6, FontStyle.Regular);
            lblIdTurno.Text=turno.IdTurno.ToString();
            lblIdTurno.AutoSize=true;
            lblIdTurno.Parent=flpTurno;
            lblIdTurno.BackColor=Color.Beige;
            lblIdTurno.SendToBack();
            flpTurno.Controls.Add(lblIdTurno);

            Label lblPaciente = new Label();
            lblPaciente.Name = turno.IdTurno.ToString();
            lblPaciente.Tag = turno;
            lblPaciente.Font = new Font("Arial", 8, FontStyle.Regular);
            lblPaciente.Text = turno.Paciente.Apellido + ", " + turno.Paciente.Nombre;
            lblPaciente.AutoSize = true;
            lblPaciente.Parent = flpTurno;
            lblPaciente.BackColor = Color.Transparent;
            lblPaciente.SendToBack();
            lblPaciente.Click += new EventHandler(mostrarDatosTurno);
            flpTurno.Controls.Add(lblPaciente);

            Label lblHorario = new Label();
            lblHorario.Name = turno.IdTurno.ToString();
            lblHorario.Tag = turno;
            lblHorario.Font = new Font("Arial", 8, FontStyle.Italic);
            lblHorario.Text = String.Format("{0:HH:mm}", turno.HoraInicio) + " - " + String.Format("{0:HH:mm}", turno.HoraFin);
            lblHorario.Parent = flpTurno;
            lblHorario.BackColor = Color.Transparent;
            lblHorario.SendToBack();
            lblHorario.Click += new EventHandler(mostrarDatosTurno);
            flpTurno.Controls.Add(lblHorario);

            FlowLayoutPanel flpControles = new FlowLayoutPanel();
            flpControles.Location = new System.Drawing.Point(491, 74);
            flpControles.Name = "flpControlesTurno";
            flpControles.Tag = turno;
            flpControles.AutoSize = true;
            flpControles.Visible = false;
            flpControles.Parent = flpTurno;
            flpControles.BackColor = Color.Transparent;
            flpControles.SendToBack();
            flpControles.Dock = DockStyle.Bottom;
            flpControles.Click += new EventHandler(mostrarDatosTurno);

            Button btnConfirmarTurno = new Button();
            btnConfirmarTurno.Size = new System.Drawing.Size(30, 23);
            btnConfirmarTurno.FlatStyle = FlatStyle.Flat;
            btnConfirmarTurno.FlatAppearance.BorderSize = 0;
            
            btnConfirmarTurno.Margin = new System.Windows.Forms.Padding(0);
            btnConfirmarTurno.Name = turno.IdTurno.ToString();
            btnConfirmarTurno.Tag = turno;
            btnConfirmarTurno.TabIndex = 0;
            btnConfirmarTurno.UseVisualStyleBackColor = true;
            btnConfirmarTurno.Parent = flpControles;


            if (turno.EstadoTurno.IdEstado == IDTURNOCONFIRMADO)
            {
                //Si está confirmado=>mostrar icono "desconfirmar"
                btnConfirmarTurno.Image = global::Presentacion.Properties.Resources.nonaccept;
            }
            if (turno.EstadoTurno.IdEstado == IDTURNOGENERADO)
            {
                btnConfirmarTurno.Image = global::Presentacion.Properties.Resources.accept;
            }
            btnConfirmarTurno.BackColor = Color.Transparent;
            tltTurnos.SetToolTip(btnConfirmarTurno, "Confirma el turno generado");
            
            
            btnConfirmarTurno.Click += new EventHandler(confirmarTurno);
            flpControles.Controls.Add(btnConfirmarTurno);

            Button btnModificarTurno = new Button();
            btnModificarTurno.Size = new System.Drawing.Size(30, 23);
            btnModificarTurno.FlatStyle = FlatStyle.Flat;
            btnModificarTurno.FlatAppearance.BorderSize = 0;
            btnModificarTurno.Image = global::Presentacion.Properties.Resources.time;
            btnModificarTurno.Margin = new System.Windows.Forms.Padding(0);
            btnModificarTurno.Name = turno.IdTurno.ToString();
            btnModificar.Tag = turno;
            btnModificarTurno.TabIndex = 1;
            btnModificarTurno.UseVisualStyleBackColor = true;
            btnModificarTurno.Parent = flpControles;
            btnModificarTurno.BackColor = Color.Transparent;
            btnModificarTurno.SendToBack();
            tltTurnos.SetToolTip(btnModificarTurno, "Habilita la modificación del turno");
            flpControles.Controls.Add(btnModificarTurno);

            Button btnCancelarTurno = new Button();
            btnCancelarTurno.Size = new System.Drawing.Size(30, 23);
            btnCancelarTurno.FlatStyle = FlatStyle.Flat;
            btnCancelarTurno.FlatAppearance.BorderSize = 0;
            btnCancelarTurno.Image = global::Presentacion.Properties.Resources.cross;
            btnCancelarTurno.Margin = new System.Windows.Forms.Padding(0);
            btnCancelarTurno.Name = turno.IdTurno.ToString();
            btnCancelarTurno.Tag = turno;
            btnCancelarTurno.TabIndex = 2;
            btnCancelarTurno.UseVisualStyleBackColor = true;
            btnCancelarTurno.Parent = flpControles;
            btnCancelarTurno.BackColor = Color.Transparent;
            btnCancelarTurno.SendToBack();
            tltTurnos.SetToolTip(btnCancelarTurno, "Cancela el turno");
            btnCancelarTurno.Click += new EventHandler(cancelarTurno);
            
            flpControles.Controls.Add(btnCancelarTurno);

            flpTurno.Controls.Add(flpControles);
            return flpTurno;
        }

        private void cargarCabeceraGrilla()
        {
            DateTime fechaAuxiliar = fechaSemanaDesde;
            lblLunes.Text=fechaAuxiliar.ToString("ddd d MMM");
            lblMartes.Text = fechaAuxiliar.AddDays(1).ToString("ddd d MMM");
            lblMiercoles.Text = fechaAuxiliar.AddDays(2).ToString("ddd d MMM");
            lblJueves.Text = fechaAuxiliar.AddDays(3).ToString("ddd d MMM");
            lblViernes.Text = fechaAuxiliar.AddDays(4).ToString("ddd d MMM");
        }
        
        private void dibujarGrilla(DateTime fecha)
        {
            tlpTurnos.RowCount = 79;

            cargarCabeceraGrilla();
            
            //Carga las horas
            DateTime horas = new DateTime(2013, 03, 03, 08, 00, 00);
            
            int fila;
            for (int i = 0; i <= 12; i++)
            {
                Label lblHora = new Label();
                lblHora.TextAlign = ContentAlignment.TopRight;
                lblHora.Name = String.Format("{0:HH}",horas).ToString();
                lblHora.Text = String.Format("{0:HH}", horas).ToString();
                lblHora.Font = new Font("Arial", 20);
                lblHora.Width = 60;
                lblHora.Height = 160;
                fila = 1 + i * 4;
                tlpTurnos.Controls.Add(lblHora, 0,fila);
                tlpTurnos.SetRowSpan(lblHora, 4);

                tlpTurnos.RowStyles.Add(new RowStyle());

                DateTime minutos = new DateTime(2013, 03, 03, 08, 00, 00);
                //Carga los minutos
                for (int j = fila; j <= fila+3; j++)
                { 
                    Label lblMinuto=new Label();
                    lblMinuto.TextAlign = ContentAlignment.TopRight;
                    lblMinuto.Name = String.Format("{0:HH}", horas).ToString() + ":" + String.Format("{0:mm}", minutos).ToString();
                    lblMinuto.Text = String.Format("{0:mm}", minutos).ToString();
                    lblMinuto.Font = new Font("Arial", 7);
                    lblMinuto.Width = 40;
                    lblMinuto.Height = 40;
                    tlpTurnos.Controls.Add(lblMinuto, 1, j);
                    minutos=minutos.AddMinutes(15);
                }
                horas = horas.AddHours(1);
            }
        }
        
        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void dgvTurnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscarPaciente_Click(object sender, EventArgs e)
        {
            frmPaciente vtPaciente = new frmPaciente();
            vtPaciente.ShowDialog();
            cmbPaciente.Items.Clear();
            cargarPacientes();
        }

        private void btnBuscarConsultorio_Click(object sender, EventArgs e)
        {
            frmConsultorio vtConsultorio = new frmConsultorio();
            vtConsultorio.ShowDialog();
        }

        private void btnBuscarPractica_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBuscarProfesional_Click(object sender, EventArgs e)
        {
            frmProfesional vtProfesional = new frmProfesional();
            vtProfesional.ShowDialog();
        }

        private void btnAgregarPractica_Click(object sender, EventArgs e)
        {
            if (cmbPracticas.Items.Count > 0 && cmbPracticas.SelectedIndex>=0)
            {
                Practica practica = (Practica)cmbPracticas.SelectedItem;
                lstPracticas.Items.Add(practica);
                lstPracticas.SelectedIndex = 0;

                dtpHoraHasta.Value= dtpHoraHasta.Value.AddMinutes((double)practica.Duracion);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            lstPracticas.Items.Clear();
            txtComentario.Text = "";
            dtpHoraDesde.Value = Convert.ToDateTime("08:00:00");
            dtpHoraHasta.Value = Convert.ToDateTime("08:00:00");
        }

        private void ubicarTurno(FlowLayoutPanel flpTurno)
        {
            Turno turno = (Turno)flpTurno.Tag;
            int duracion = ((int)(turno.HoraFin - turno.HoraInicio).TotalMinutes);
            Control[] controles = tlpTurnos.Controls.Find(String.Format("{0:HH:mm}", turno.HoraInicio), false);
            TableLayoutPanelCellPosition coordenadas = tlpTurnos.GetCellPosition(controles[0]);
            int fila = coordenadas.Row;
            int columna = (int)turno.FechaTurno.DayOfWeek + 1;
            tlpTurnos.SetRowSpan(flpTurno, duracion / 15);
            tlpTurnos.Controls.Add(flpTurno, columna, fila);
            flpTurno.Visible = true;
        }
        
        void lblHorario_MouseEnter(object sender, EventArgs e)
        {
            
        }
        
        protected void mostrarControlesTurno(object sender, EventArgs e)
        {
            flpTurno = sender as FlowLayoutPanel;
            Object[] controles = flpTurno.Controls.Find("flpControlesTurno", true);
            flpControles = (FlowLayoutPanel)controles[0];
            flpControles.Visible = true;
            rectanguloFlpTurno = flpTurno.ClientRectangle;

            txtComentario.Text = Control.MousePosition.X.ToString() + " " + Control.MousePosition.Y.ToString();
        }

        protected void ocultarControlesTurno(object sender, EventArgs e)
        {
            flpTurno = sender as FlowLayoutPanel;
            Object[] controles = flpTurno.Controls.Find("flpControlesTurno", true);
            flpControles = (FlowLayoutPanel)controles[0];
            
            //punto respecto a la pantalla
            Point xy = new Point(Cursor.Position.X, Cursor.Position.Y);
            //punto respecto al cliente (flpTurno)
            Point raton = new Point(flpTurno.PointToClient(xy).X, flpTurno.PointToClient(xy).Y);
            int x0=0;
            int x1=rectanguloFlpTurno.Width;
            int y0= 0;
            int y1 = rectanguloFlpTurno.Height;

            if (raton.X < x0 || raton.Y < y0 || raton.X > x1 || raton.Y > y1)
                flpControles.Visible = false;
        }

        void btnModificarTurno_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void mostrarDatosTurno(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            int idTurno = Convert.ToInt32(((Turno)control.Tag).IdTurno);
            GestorDeTurnos gestorDeTurnos = new GestorDeTurnos();
            Turno turno = gestorDeTurnos.obtenerTurnoPorId(idTurno);
            if (turno != null)
            {
                cmbPaciente.Text = turno.Paciente.ToString();
                cmbProfesional.Text = turno.Profesional.ToString();
                dtpFecha.Value = turno.FechaTurno;
                dtpHoraDesde.Value = turno.HoraInicio;
                dtpHoraHasta.Value = turno.HoraFin;
                lstPracticas.Items.Clear();
                foreach (Practica practica in turno.Practicas)
                {
                    lstPracticas.Items.Add(practica);
                }
            }
        }
        
        private void confirmarTurno(object sender, EventArgs e)
        {
            Turno turno = (((Button)sender).Tag) as Turno;
            GestorDeTurnos gestorDeTurnos = new GestorDeTurnos();
            if (gestorDeTurnos.tomarTurnoAConfirmar(turno))
            {
                //Elimino para volver a dibujar como si fuera un nuevo turno
                tlpTurnos.Controls.RemoveByKey(turno.IdTurno.ToString());

                turno.EstadoTurno.IdEstado = IDTURNOCONFIRMADO;
                bgwDibujadorDeNuevoTurno = new BackgroundWorker();
                bgwDibujadorDeNuevoTurno.DoWork += new DoWorkEventHandler(bgwDibujadorDeTurnoNuevo_DoWork);
                bgwDibujadorDeNuevoTurno.ProgressChanged += new ProgressChangedEventHandler(bgwDibujadorDeTurnoNuevo_ProgressChanged);
                bgwDibujadorDeNuevoTurno.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgwDibujadorDeTurnoNuevo_RunWorkerCompleted);
                bgwDibujadorDeNuevoTurno.RunWorkerAsync(turno);
                MessageBox.Show("Turno confirmado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                MessageBox.Show("No se ha podido confirmar el turno", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }

        private void cancelarTurno(object sender, EventArgs e)
        {
            Turno turno = (((Button)sender).Tag)as Turno;
            GestorDeTurnos gestorDeTurnos = new GestorDeTurnos();
            if (gestorDeTurnos.tomarTurnoACancelar(turno))
            {
                tlpTurnos.Controls.RemoveByKey(turno.IdTurno.ToString());
                MessageBox.Show("Turno cancelado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                MessageBox.Show("No se ha podido cancelar el turno", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Controlar Turno nuevo y Turno modificado
            Turno turno = new Turno();
            turno.Comentario = txtComentario.Text.Trim();
            turno.FechaAlta = DateTime.Now;
            turno.FechaTurno = dtpFecha.Value;
            turno.HoraFin = dtpHoraHasta.Value;
            turno.HoraInicio = dtpHoraDesde.Value;
            turno.EstadoTurno = new EstadoTurno();
            turno.EstadoTurno.IdEstado = 4;
            turno.EstadoTurno.Nombre = "Generado";
            turno.Paciente = (Paciente)cmbPaciente.SelectedItem;
            turno.Profesional = (Profesional)cmbProfesional.SelectedItem;
            
            List<Practica> practicas = new List<Practica>();
            foreach (Practica practica in lstPracticas.Items)
            {
                practicas.Add(practica);
            }
            turno.Practicas = practicas;

            GestorDeTurnos gestorDeTurnos = new GestorDeTurnos();
            int idTurno=gestorDeTurnos.tomarTurno(turno);
            if ( idTurno>0)
            {
                turno.IdTurno = idTurno;
                bgwDibujadorDeNuevoTurno = new BackgroundWorker();
                bgwDibujadorDeNuevoTurno.DoWork += new DoWorkEventHandler(bgwDibujadorDeTurnoNuevo_DoWork);
                bgwDibujadorDeNuevoTurno.ProgressChanged += new ProgressChangedEventHandler(bgwDibujadorDeTurnoNuevo_ProgressChanged);
                bgwDibujadorDeNuevoTurno.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgwDibujadorDeTurnoNuevo_RunWorkerCompleted);
                bgwDibujadorDeNuevoTurno.RunWorkerAsync(turno);
            }
            else
            {
                MessageBox.Show("No se ha registrado el turno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void bgwDibujadorDeTurnoNuevo_DoWork(object sender, DoWorkEventArgs e)
        {
            Turno turno = e.Argument as Turno;
            FlowLayoutPanel flpTurno = configurarDibujoDeTurno(turno);
            e.Result = flpTurno;
        }

        void bgwDibujadorDeTurnoNuevo_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            
        }

        void bgwDibujadorDeTurnoNuevo_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            FlowLayoutPanel flpTurno = e.Result as FlowLayoutPanel;
            ubicarTurno(flpTurno);

            bgwPintadorDeTurno = new BackgroundWorker();
            bgwPintadorDeTurno.WorkerReportsProgress = true;
            bgwPintadorDeTurno.WorkerSupportsCancellation = true;
            bgwPintadorDeTurno.DoWork += new DoWorkEventHandler(bgwPintadorDeTurnos_DoWork);
            bgwPintadorDeTurno.ProgressChanged += new ProgressChangedEventHandler(bgwPintadorDeTurnos_ProgressChanged);
            bgwPintadorDeTurno.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgwPintadorDeTurnos_RunWorkerCompleted);
            bgwPintadorDeTurno.RunWorkerAsync(flpTurno);
        }

        void bgwPintadorDeTurnos_DoWork(object sender, DoWorkEventArgs e)
        {
            FlowLayoutPanel flpTurno = e.Argument as FlowLayoutPanel;
            Turno turno = (Turno)flpTurno.Tag;
            Color colorAPintar = Color.FromArgb(255,255,255);
            switch (turno.EstadoTurno.IdEstado)
            {
                case 1:
                    colorAPintar = COLORTURNOCANCELADO;
                    break;
                case 2:
                    colorAPintar = COLORTURNOCONFIRMADO;
                    break;
                case 3:
                    colorAPintar = COLORTURNOELIMINADO;
                    break;
                case 4:
                    colorAPintar = COLORTURNOGENERADO;
                    break;
                case 5:
                    colorAPintar = COLORTURNOENESPERA;
                    break;
                case 6:
                    colorAPintar = COLORTURNOCUMPLIDO;
                    break;
            }

            Boolean detenerRed = false;
            Boolean detenerGreen = false;
            Boolean detenerBlue = false;
            Boolean detener = false;

            int inicioRed = 255;
            int inicioGreen = 255;
            int inicioBlue = 255;

            int limiteRed = colorAPintar.R;
            int limiteGreen = colorAPintar.G;
            int limiteBlue = colorAPintar.B;

            Object[] parametros = new Object[4] {inicioRed,inicioGreen,inicioBlue,flpTurno };
            try
            {
                while (detener == false)
                {
                    System.Threading.Thread.Sleep(5);

                    if (inicioRed == colorAPintar.R)
                        detenerRed = true;
                    else
                        inicioRed--;

                    if (inicioBlue == colorAPintar.G)
                        detenerBlue = true;
                    else
                        inicioBlue--;

                    if (inicioGreen == colorAPintar.G)
                        detenerGreen = true;
                    else
                        inicioGreen--;

                    if (detenerRed && detenerBlue && detenerGreen)
                    {
                        detener = true;
                        bgwPintadorDeTurno.CancelAsync();
                    }

                    parametros[0] = inicioRed;
                    parametros[1] = inicioGreen;
                    parametros[2] = inicioBlue;
                    parametros[3] = flpTurno;
                    bgwPintadorDeTurno.ReportProgress(inicioRed, parametros);//el parámetro red no se usa, pero debe estar.
                }
            }
            catch (InvalidOperationException ex)
            {

            }
        }

        void bgwPintadorDeTurnos_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Object[] parametros = e.UserState as Object[];
            int red = (int)parametros[0];
            int green = (int)parametros[1];
            int blue = (int)parametros[2];
            FlowLayoutPanel flpTurno = (FlowLayoutPanel)parametros[3];
            flpTurno.BackColor = Color.FromArgb(red, green, blue);
        }

        void bgwPintadorDeTurnos_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private DateTime[] calcularSemana(DateTime fechaActual)
        {
            DateTime fechaDesde = DateTime.MinValue;
            DateTime fechaHasta = DateTime.MaxValue;
            fechaDesde = fechaActual.AddDays(1 - Convert.ToDouble(fechaActual.DayOfWeek));
            fechaHasta = fechaActual.AddDays(6 - Convert.ToDouble(fechaActual.DayOfWeek)+1);
            DateTime[] fechas=new DateTime[]{fechaDesde,fechaHasta};
            return fechas;
        }
        
        private void limpiarGrilla()
        {
            foreach (int idTurno in lsIdTurnos)
            {
                tlpTurnos.Controls.RemoveByKey(idTurno.ToString());
            }
            lsIdTurnos.Clear();
        }

        private void dtpHoraDesde_ValueChanged(object sender, EventArgs e)
        {
            dtpHoraHasta.Value = dtpHoraDesde.Value;
        }

        private void cmbProfesional_SelectionChangeCommitted(object sender, EventArgs e)
        {
            limpiarGrilla();
        }
    }
}
