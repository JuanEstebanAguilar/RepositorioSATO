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
    public partial class frmDiagramacion : Form
    {

        private List<DetalleDiagramacion> detallesDiagramacion = new List<DetalleDiagramacion>();
        private DateTime fechaDesde;
        private int[,] cuadro = new int[52, 7];//Grilla en memoria

        public frmDiagramacion()
        {
            InitializeComponent();
        }
              
        private void frmDiagramacion_Load(object sender, EventArgs e)
        {
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnDiagramar.Enabled = false;
           
            dtpFechaInicio.Value = DateTime.Now;
            dtpFechaFin.Value = dtpFechaInicio.Value.AddYears(1);
            limpiarGrilla();
            

            //dibujarGrilla(dtpFechaInicio.Value);
            dibujarGrilla(DateTime.Now);
            cargarProfesionales();
            cargarDias();
            cmbProfesionales.SelectedIndex = 0;
            dtpFechaFin.Value= dtpFechaInicio.Value.AddYears(1);
        }

        void tlpDiagramacion_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            if (e.Row<52)
            {
                if (e.Row >= 1 && e.Column >= 2)
                { 
                    Rectangle r=e.CellBounds;
                    if (cuadro[e.Row,e.Column] == 1)
                        e.Graphics.FillRectangle(Brushes.DarkSeaGreen, r);
                    else
                        e.Graphics.FillRectangle(Brushes.SkyBlue, r);
                }
            }
        }

        private void cargarProfesionales()
        {

            GestorDePersonas gestorPersonas = new GestorDePersonas();
            List<Profesional> lsProfesionales = gestorPersonas.obtenerProfesionales();
            if (lsProfesionales != null)
            {
                foreach (Profesional profesional in lsProfesionales)
                {
                    cmbProfesionales.Items.Add(profesional);
                }
                cmbProfesionales.SelectedIndex = 0;
            }
        }

        private void cargarDias()
        {
            GestorDeTurnos gestorTurnos = new GestorDeTurnos();
            List<Dia> lsDias = gestorTurnos.obtenerDiasSemana();
            if (lsDias != null)
            {
                foreach (Dia dia in lsDias)
                {
                    cmbDia.Items.Add(dia);
                }
                cmbDia.SelectedIndex = 0;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GestorDeTurnos gestorDeTurnos = new GestorDeTurnos();
            Diagramacion diagramacion = new Diagramacion();
            diagramacion.FechaAlta = DateTime.Now;
            diagramacion.FechaDesde= dtpFechaInicio.Value;
            diagramacion.FechaHasta = dtpFechaFin.Value;
            diagramacion.Profesional = (Profesional)cmbProfesionales.SelectedItem;
            
            btnNuevo.Enabled = true;
            btnCancelar.Enabled = false;
            btnGuardar.Enabled = false;
            btnDiagramar.Enabled = false;
            limpiarGrilla();
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            
            dtpFechaInicio.Value = DateTime.Now;
            dtpFechaFin.Value = dtpFechaInicio.Value.AddYears(1);
            dtpFechaInicio.Enabled = false;
            dtpFechaFin.Enabled = false;
            dtpHoraDesde.Enabled = false;
            dtpHoraHasta.Enabled = false;
            cmbProfesionales.SelectedIndex = 0;
        }

        private void cargarGrilla()
        {
            GestorDeTurnos gestorDeTurnos = new GestorDeTurnos();

            //calcula los extremos de la semana
            DateTime fechaSeleccionada = dtpFecha.Value;
            DateTime fechaDesde = DateTime.MinValue;
            DateTime fechaHasta = DateTime.MinValue;
            fechaDesde = fechaSeleccionada.AddDays(1 - Convert.ToDouble(fechaSeleccionada.DayOfWeek));
            fechaHasta = fechaSeleccionada.AddDays(5 - Convert.ToDouble(fechaSeleccionada.DayOfWeek));
    

            int idProfesional = ((Profesional)cmbProfesionales.SelectedItem).Idprofesional;


            /*Diagramacion diagramacion = GestorDeTurnos.obtenerDiagramacionPorSemana(fechaDesde, fechaHasta, idProfesional);

    
            cmbProfesionales.SelectedItem = diagramacion.Profesional.Idprofesional;
            dtpFechaInicio.Value = diagramacion.FechaInicio;
            dtpFechaFin.Value = diagramacion.FechaFin;
            //cmbProfesionales.Text = diagramacion.Profesional.ToString();
            List<DetalleDiagramacion> lstDetallesDiagramacion = gestorDeTurnos.obtenerDetalleDeDiagramacionPorDiagramacion(diagramacion);
            

            if (lstDetallesDiagramacion != null)
            {
                foreach (Negocio.DetalleDiagramacion diag in lstDetallesDiagramacion)
                {
                    int cord= (int)diag.Dia + 2;
                    dibujarDiagramacion(diag,cord);
                }
            }*/
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            //dibujarGrilla();
            limpiarGrilla();
            cargarGrilla();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cmbDia.SelectedIndex = 0;
            cmbProfesionales.SelectedIndex = 0;
            dtpFechaInicio.Value = DateTime.Now;
            dtpFechaFin.Value = dtpFechaInicio.Value.AddYears(1);
            dtpFechaInicio.Enabled = false;
            dtpFechaFin.Enabled = false;
            dtpHoraDesde.Enabled = false;
            dtpHoraHasta.Enabled = false;
            btnGuardar.Enabled = false;
            btnNuevo.Enabled = true;
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
            btnNuevo.Enabled = false;
            btnCancelar.Enabled = true;
            btnDiagramar.Enabled = true;

            cmbDia.SelectedIndex = 0;
            cmbProfesionales.SelectedIndex = 0;
            dtpFechaInicio.Value = DateTime.Now;
            dtpFechaFin.Value = dtpFechaInicio.Value.AddYears(1);
            dtpFechaInicio.Enabled = true;
            dtpFechaFin.Enabled = true;
            dtpHoraDesde.Enabled = true;
            dtpHoraHasta.Enabled = true;
            cmbDia.Enabled = true;
           
            limpiarGrilla();
        }

        private void cargarCabeceraGrilla()
        {
            lblLunes.Text = fechaDesde.ToString("ddd d MMM");
            lblMartes.Text = fechaDesde.AddDays(1).ToString("ddd d MMM");
            lblMiercoles.Text = fechaDesde.AddDays(2).ToString("ddd d MMM");
            lblJueves.Text = fechaDesde.AddDays(3).ToString("ddd d MMM");
            lblViernes.Text = fechaDesde.AddDays(4).ToString("ddd d MMM");
        }

        private void dibujarGrilla(DateTime fecha)
        {
            tlpDiagramacion.RowCount = 79;

            cargarCabeceraGrilla();

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

            DateTime horario = Convert.ToDateTime("08:00:00");

            for (int i = 1; i <= 48; i++)
            {
                cuadro[i, 1] = Convert.ToInt32(horario.Hour.ToString() + horario.Minute.ToString());
                horario = horario.AddMinutes(15);
            }
            int dia;
            foreach (DetalleDiagramacion detalle in detallesDiagramacion)
            {
                dia = ((int)detalle.Fecha.DayOfWeek);
                double cantidadCeldas = ((TimeSpan)(detalle.HoraHasta - detalle.HoraDesde)).TotalMinutes / 15;
                int horaActual;
                for (int hora = 1; hora < cuadro.GetLength(0); hora++)
                {
                    horaActual = Convert.ToInt32(detalle.HoraDesde.Hour.ToString() + detalle.HoraDesde.Minute.ToString());
                    if (cuadro[hora, 1] == horaActual)
                    {
                        int k = hora;
                        for (int j = 1; j <= cantidadCeldas; j++)
                        {
                            cuadro[k, dia + 1] = 1;
                            k++;
                        }
                    }
                }
            }

            tlpDiagramacion.CellPaint += new TableLayoutCellPaintEventHandler(tlpDiagramacion_CellPaint);
        }

        private void btnAgregarDia_Click(object sender, EventArgs e)
        {
            Dia dia = (Dia)cmbDia.SelectedItem;
            TreeNode nodoHora = new TreeNode(dtpHoraDesde.Value.ToShortTimeString() +" a "+ dtpHoraHasta.Value.ToShortTimeString());
            
            Boolean crearDia = true;
            foreach(TreeNode nodoActual in tvwDetalleDiagramacion.Nodes)
            {
                if (dia.Nombre.ToString().Equals(nodoActual.Text.ToString()))
                {
                    nodoActual.Nodes.Add(nodoHora);
                    crearDia = false;
                    return;
                }
            }
            if (crearDia == true)
            {
                TreeNode nodoDia = new TreeNode(dia.Nombre.ToString());
                nodoDia.Nodes.Add(nodoHora);
                tvwDetalleDiagramacion.Nodes.Add(nodoDia);
                tvwDetalleDiagramacion.ExpandAll();
                tvwDetalleDiagramacion.Sort();
                //Para ordenar implementar la interfaz IComparer
                //http://msdn.microsoft.com/es-es/library/system.windows.forms.treeview.treeviewnodesorter(v=vs.110).aspx
            }
        }
    }
}
