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
    public partial class frmTurnos : Form
    {
        private Color COLORTURNOGENERADO = Color.DodgerBlue;
        private Color COLORTURNOCANCELADO = Color.Crimson;
        private Color COLORTURNOELIMINADO = Color.LightCoral;
        private Color COLORTURNOCONFIRMADO = Color.DarkSeaGreen;
        private DateTime fechaActual = DateTime.Now;
        private List<int> lsIdTurnos = new List<int>();

        private Validador validador = new Validador();
        
        protected FlowLayoutPanel flpControles;
        protected FlowLayoutPanel flpTurno;


        protected Panel panelPrueba;
        protected Button botonPrueba;


        public frmTurnos()
        {
            InitializeComponent();
        }

        private void Turno_Load(object sender, EventArgs e)
        {
            
            cargarHoraPrueba();

            dibujarGrilla(dtpFecha.Value);
            cargarProfesionales();
            cargarPacientes();
            cargarPracticas();
            cargarEstados();
            cargarGrilla();
        }

        private void cargarHoraPrueba()
        {
            dtpHoraDesde.Value = Convert.ToDateTime("08:00");
            dtpHoraHasta.Value = Convert.ToDateTime("08:00");
        }

    

        private void cargarProfesionales()
        {
            LogicaNegocio negocio = new LogicaNegocio();

            List<Profesional> lsProfesionales = negocio.obtenerTodosProfesionales();
            if (lsProfesionales != null)
            {
                foreach (Profesional profesional in lsProfesionales)
                {
                    cmbProfesional.Items.Add(profesional);
                }
                cmbProfesional.SelectedIndex = 0;
            }
        }

        private void cargarPacientes()
        {
            LogicaNegocio negocio = new LogicaNegocio();

            List<Paciente> lsPacientes = negocio.obtenerTodosPacientes();

            if (lsPacientes != null)
            {
                foreach (Persona persona in lsPacientes)
                {
                    cmbPaciente.Items.Add(persona);
                }
                cmbPaciente.SelectedIndex = 0;
            }
        }

        private void cargarPracticas()
        {
            LogicaNegocio negocio = new LogicaNegocio();

            List<Practica> lsPracticas = negocio.obtenerPracticas();

            if (lsPracticas!=null)
            {
                foreach (Practica practica in lsPracticas)
                {
                    cmbPracticas.Items.Add(practica);
                }
                cmbPracticas.SelectedIndex = 0;
            }
        }

        private void cargarEstados()
        {
            LogicaNegocio negocio = new LogicaNegocio();
            List<EstadoTurno> lsEstados = negocio.obtenerTodosEstadosTurno();
            if (lsEstados!=null)
            {
                foreach (EstadoTurno estado in lsEstados)
                {
                    cmbEstado.Items.Add(estado);
                }
                cmbEstado.SelectedIndex = 0;
            }

        }

        private void dibujarGrilla(DateTime fecha)
        {
            //Carga los días
            tlpTurnos.RowCount = 79;
            String[] dias = new String[] { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes" };
            for (int i = 0; i <= 4; i++)
            { 
                Label lblDia=new Label();
                lblDia.TextAlign = ContentAlignment.MiddleCenter;
                lblDia.Name = dias[i].ToString();
                lblDia.Text=dias[i].ToString();
                lblDia.Font = new Font("Arial", 12);
                
                tlpTurnos.Controls.Add(lblDia, i+2, 0);
            }

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
            String param = "";

            LogicaNegocio logicaNegocio = new LogicaNegocio();
            List<Paciente> lsPacientes = logicaNegocio.obtenerPacientesPorBusqueda(param);

            if (lsPacientes != null)
            {
                BuscarPacienteTurno vtBuscarPaciente = new BuscarPacienteTurno(lsPacientes);
                vtBuscarPaciente.pacienteAPasar += new BuscarPacienteTurno.pasarPaciente(mostrarPacienteSeleccionado);

                vtBuscarPaciente.ShowDialog();
            }
            else
            {
                MessageBox.Show("No hay pacientes registrados", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public void mostrarPacienteSeleccionado(String numPaciente)
        {
            LogicaNegocio negocio = new LogicaNegocio();
            Paciente paciente = negocio.obtenerPacientePorNumero(numPaciente);
            cmbPaciente.Text = paciente.ToString();
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
            String parametro = "";
            LogicaNegocio logicaNegocio = new LogicaNegocio();
            List<Profesional> lsProfesional = logicaNegocio.obtenerProfesionalPorBusqueda(parametro);

            if (lsProfesional != null)
            {
                BuscarProfesional vtBuscarProfesional = new BuscarProfesional(lsProfesional);
                vtBuscarProfesional.profesionalAPasar += new BuscarProfesional.pasarProfesional(mostrarProfesionalSeleccionado);
                vtBuscarProfesional.ShowDialog();
            }

            else
            {
                MessageBox.Show("No hay profesionales registrados", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void mostrarProfesionalSeleccionado(string param)
        {
            LogicaNegocio negocio = new LogicaNegocio();
            int parametroidprofesional = Convert.ToInt32(param);
            Profesional profesional = negocio.obtenerProfesionalxID(parametroidprofesional);
            cmbProfesional.Text = profesional.ToString();
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

        private void btnQuitarPractica_Click(object sender, EventArgs e)
        {
            if (validador.validarQuitarItemLista(lstPracticas, "No hay prácticas para quitar", "Seleccione una práctica", "Atención"))
            { lstPracticas.Items.RemoveAt(lstPracticas.SelectedIndex); }
            else
            { btnQuitarPractica.Focus(); }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            lstPracticas.Items.Clear();
            cmbEstado.Text="Generado";
            txtComentario.Text = "";
            dtpHoraDesde.Value = Convert.ToDateTime("08:00:00");
            dtpHoraHasta.Value = Convert.ToDateTime("08:00:00");
        }

        private void dibujarTurno(Turno turno)
        {
            lsIdTurnos.Add(turno.IdTurno);
            int duracion = ((int)(turno.HoraFin - turno.HoraInicio).TotalMinutes);

            Color COLORAUSAR=COLORTURNOGENERADO;
            if (turno.EstadoTurno.IdEstado == 1)
            {COLORAUSAR = COLORTURNOCANCELADO;}
            if (turno.EstadoTurno.IdEstado == 2)
            {COLORAUSAR = COLORTURNOCONFIRMADO;}
            if (turno.EstadoTurno.IdEstado == 3)
            { COLORAUSAR= COLORTURNOELIMINADO; }
            if (turno.EstadoTurno.IdEstado == 4)
            { COLORAUSAR= COLORTURNOGENERADO; }


            FlowLayoutPanel flpTurno = new FlowLayoutPanel();
            flpTurno.Name = turno.IdTurno.ToString();
            //flpTurno.Visible = false;
            flpTurno.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            flpTurno.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            flpTurno.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flpTurno.Location = new System.Drawing.Point(470, 74);
            flpTurno.BackColor = COLORAUSAR;
            flpTurno.Name = turno.IdTurno.ToString();
            flpTurno.Size = new System.Drawing.Size(130, duracion * 40 / 15);
            flpTurno.TabIndex = 0;
            flpTurno.WrapContents = false;
            flpTurno.Click += new EventHandler(flpTurno_Click);
            flpTurno.MouseEnter += new EventHandler(flpTurno_MouseEnter);
            flpTurno.MouseLeave += new EventHandler(flpTurno_MouseLeave);
            
            Label lblPaciente = new Label();
            lblPaciente.Name = turno.IdTurno.ToString();
            lblPaciente.Font = new Font("Arial", 8, FontStyle.Bold);
            lblPaciente.Text = turno.IdTurno.ToString()+" - "+turno.Paciente.Apellido+", "+turno.Paciente.Nombre;
            lblPaciente.AutoSize = true;
            lblPaciente.Click += new EventHandler(lblPaciente_Click);
            flpTurno.Controls.Add(lblPaciente);

            Label lblHorario = new Label();
            lblHorario.Name = turno.IdTurno.ToString();
            lblHorario.Font = new Font("Arial", 8, FontStyle.Italic);
            lblHorario.Text = String.Format("{0:HH:mm}", turno.HoraInicio) +" - "+ String.Format("{0:HH:mm}", turno.HoraFin);
            lblHorario.Click += new EventHandler(lblHorario_Click);
            flpTurno.Controls.Add(lblHorario);
                        
            // flpControles
            FlowLayoutPanel flpControles = new FlowLayoutPanel();
            flpControles.Location = new System.Drawing.Point(491, 74);
            flpControles.Name = "flpControles";
            flpControles.AutoSize = true;
            flpControles.Visible = false;
            flpControles.Dock = DockStyle.Bottom;
            
            // btnConfirmar
            Button btnConfirmarTurno = new Button();
            btnConfirmarTurno.Size = new System.Drawing.Size(30, 23);
            btnConfirmarTurno.FlatStyle=FlatStyle.Flat;
            btnConfirmarTurno.FlatAppearance.BorderSize = 0;
            btnConfirmarTurno.FlatAppearance.CheckedBackColor = COLORAUSAR;
            btnConfirmarTurno.Image = global::Presentacion.Properties.Resources.accept;
            btnConfirmarTurno.Margin = new System.Windows.Forms.Padding(0);
            btnConfirmarTurno.Name = turno.IdTurno.ToString();
            btnConfirmarTurno.TabIndex = 0;
            btnConfirmarTurno.UseVisualStyleBackColor = true;
            btnConfirmarTurno.Click += new EventHandler(btnConfirmarTurno_Click);
            flpControles.Controls.Add(btnConfirmarTurno);

            // btnModificar
            Button btnModificarTurno = new Button();
            btnModificarTurno.Size = new System.Drawing.Size(30, 23);
            btnModificarTurno.FlatStyle = FlatStyle.Flat;
            btnModificarTurno.FlatAppearance.BorderSize = 0;
            btnModificarTurno.FlatAppearance.CheckedBackColor = COLORAUSAR;
            btnModificarTurno.Image = global::Presentacion.Properties.Resources.time;
            btnModificarTurno.Margin = new System.Windows.Forms.Padding(0);
            btnModificarTurno.Name = turno.IdTurno.ToString();
            btnModificarTurno.TabIndex = 1;
            btnModificarTurno.UseVisualStyleBackColor = true;
            btnModificarTurno.Click += new EventHandler(btnModificarTurno_Click);
            flpControles.Controls.Add(btnModificarTurno);

            // btnCancelar
            Button btnCancelarTurno = new Button();
            btnCancelarTurno.Size = new System.Drawing.Size(30, 23);
            btnCancelarTurno.FlatStyle = FlatStyle.Flat;
            btnCancelarTurno.FlatAppearance.BorderSize = 0;
            btnCancelarTurno.FlatAppearance.CheckedBackColor = COLORAUSAR;
            btnCancelarTurno.Image = global::Presentacion.Properties.Resources.cross;
            btnCancelarTurno.Margin = new System.Windows.Forms.Padding(0);
            btnCancelarTurno.Name = turno.IdTurno.ToString();
            btnCancelarTurno.TabIndex = 2;
            btnCancelarTurno.UseVisualStyleBackColor = true;
            btnCancelarTurno.Click += new EventHandler(btnCancelar_Click);
            flpControles.Controls.Add(btnCancelarTurno);

            flpTurno.Controls.Add(flpControles);

            //calcula la ubicación del turno
            Control[] controles = tlpTurnos.Controls.Find(String.Format("{0:HH:mm}",turno.HoraInicio), false);
            TableLayoutPanelCellPosition coordenadas= tlpTurnos.GetCellPosition(controles[0]);
            int fila=coordenadas.Row;
            int columna = (int)turno.FechaTurno.DayOfWeek + 1;
            tlpTurnos.SetRowSpan(flpTurno, duracion / 15);
            tlpTurnos.Controls.Add(flpTurno, columna, fila);
            flpTurno.Visible = true;
            flpTurno = null;
        }

        void lblHorario_MouseEnter(object sender, EventArgs e)
        {
            flpControles.Visible = true;
        }

        void flpTurno_MouseLeave(object sender, EventArgs e)
        {
            if (GetChildAtPoint(this.PointToClient(MousePosition)) is Panel)
            {
                flpControles.Visible = true;
            }
            else
            {
                flpControles.Visible = false;
            }
        }

        void flpTurno_MouseEnter(object sender, EventArgs e)
        {
            flpTurno = (FlowLayoutPanel)sender;
            Object[] controles = flpTurno.Controls.Find("flpControles",false);
            flpControles = (FlowLayoutPanel)controles[0];
            flpControles.Visible = true;
        }


        void btnModificarTurno_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void lblHorario_Click(object sender, EventArgs e)
        {
            Label lblTurno = (Label)sender;
            mostrarTurno(Convert.ToInt32(lblTurno.Name.ToString()));
            
        }

        void lblPaciente_Click(object sender, EventArgs e)
        {
            Label lblTurno = (Label)sender;
            mostrarTurno(Convert.ToInt32(lblTurno.Name.ToString()));
        }

        private void mostrarTurno(int idTurno)
        {
            LogicaNegocio negocio = new LogicaNegocio();
            Turno turno = negocio.obtenerTurnoPorId(idTurno);
            if (turno != null)
            {
                cmbPaciente.SelectedItem = turno.Paciente;
                cmbProfesional.Text = turno.Profesional.ToString();
                cmbEstado.Text = turno.EstadoTurno.Nombre.ToString();
                dtpFecha.Value = turno.FechaTurno;
                dtpHoraDesde.Value = turno.HoraInicio;
                dtpHoraHasta.Value = turno.HoraFin;
                cmbEstado.SelectedItem = turno.EstadoTurno;
                lstPracticas.Items.Clear();
                foreach (Practica practica in turno.Practicas)
                {
                    lstPracticas.Items.Add(practica);
                }
            }
        }

        void flpTurno_Click(object sender, EventArgs e)
        {
            FlowLayoutPanel flpTurno = (FlowLayoutPanel)sender;
            mostrarTurno(Convert.ToInt32(flpTurno.Name.ToString()));
        }

        void btnCancelar_Click(object sender, EventArgs e)
        {
            int idTurno=Convert.ToInt32(((Button)sender).Name.ToString());
            LogicaNegocio negocio = new LogicaNegocio();
            if (negocio.tomarTurnoACancelar(idTurno))
            {
                limpiarGrilla();
                cargarGrilla();
                MessageBox.Show("Turno cancelado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                MessageBox.Show("No se ha podido cancelar el turno", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        void btnConfirmarTurno_Click(object sender, EventArgs e)
        {
            int idTurno = Convert.ToInt32(((Button)sender).Name.ToString());
            LogicaNegocio negocio = new LogicaNegocio();
            if (negocio.tomarTurnoAConfirmar(idTurno))
            {
                limpiarGrilla();
                cargarGrilla();
                MessageBox.Show("Turno confirmado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                MessageBox.Show("No se ha podido confirmar el turno", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }
        
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Turno turno = new Turno();
            turno.Comentario = txtComentario.Text.Trim();
            turno.FechaAlta = DateTime.Now;
            turno.FechaTurno = dtpFecha.Value;
            turno.HoraFin = dtpHoraHasta.Value;
            turno.HoraInicio = dtpHoraDesde.Value;
            turno.Paciente = (Paciente)cmbPaciente.SelectedItem;
            turno.Profesional = (Profesional)cmbProfesional.SelectedItem;
            turno.EstadoTurno = (EstadoTurno)cmbEstado.SelectedItem;

            List<Practica> practicas = new List<Practica>();
            foreach (Practica practica in lstPracticas.Items)
            {
                practicas.Add(practica);
            }
            turno.Practicas = practicas;

            LogicaNegocio logicaNeg = new LogicaNegocio();
            int idTurno = logicaNeg.tomarTurno(turno);
            if (idTurno>0)
            {
                turno.IdTurno = idTurno;
                dibujarTurno(turno);
                MessageBox.Show("Turno registrado", "Importante", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Turno no registrado", "Importante", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {

            limpiarGrilla();
            cargarGrilla();
        }

        private DateTime[] calcularSemana(DateTime fechaActual)
        {
            DateTime fechaDesde = DateTime.MinValue;
            DateTime fechaHasta = DateTime.MaxValue;
            fechaDesde = fechaActual.AddDays(1 - Convert.ToDouble(fechaActual.DayOfWeek));
            fechaHasta = fechaActual.AddDays(5 - Convert.ToDouble(fechaActual.DayOfWeek));
            DateTime[] fechas=new DateTime[]{fechaDesde,fechaHasta};
            return fechas;
        }

        private void cargarGrilla()
        {
            LogicaNegocio negocio = new LogicaNegocio();

            DateTime[] fechas = calcularSemana(dtpFecha.Value);
                        
            int idProfesional = ((Profesional)cmbProfesional.SelectedItem).Idprofesional;
            int idEstado = ((EstadoTurno)cmbEstado.SelectedItem).IdEstado;
            



            List<Turno> lsTurnos = negocio.obtenerTurnosPorSemana(fechas[0], fechas[1], idProfesional,idEstado);
            if (lsTurnos != null)
            {
                foreach (Turno turno in lsTurnos)
                {
                    lsIdTurnos.Add(turno.IdTurno);
                    dibujarTurno(turno);
                }
            }
        }

        private void limpiarGrilla()
        {
            foreach (int idTurno in lsIdTurnos)
            {
                tlpTurnos.Controls.RemoveByKey(idTurno.ToString());
            }

            foreach (int idTurno in lsIdTurnos)
            {
                tlpTurnos.Controls.RemoveByKey(idTurno.ToString());
            }
        }

        private void dtpHoraDesde_ValueChanged(object sender, EventArgs e)
        {
            dtpHoraHasta.Value = dtpHoraDesde.Value;
        }

        private void tlpTurnos_Click(object sender, EventArgs e)
        {
            
        }

        private void tlpTurnos_MouseClick(object sender, MouseEventArgs e)
        {

            
        }

        private void cmbProfesional_SelectionChangeCommitted(object sender, EventArgs e)
        {
            limpiarGrilla();
            cargarGrilla();
        }

        private void cmbEstado_SelectionChangeCommitted(object sender, EventArgs e)
        {
            limpiarGrilla();
            cargarGrilla();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

       
    }
}
