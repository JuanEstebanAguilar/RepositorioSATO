using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Turno
    {
        private int idTurno;

        public int IdTurno
        {
            get { return idTurno; }
            set { idTurno = value; }
        }
        private DateTime fechaAlta;

        public DateTime FechaAlta
        {
            get { return fechaAlta; }
            set { fechaAlta = value; }
        }
        private Profesional profesional;

        public Profesional Profesional
        {
            get { return profesional; }
            set { profesional = value; }
        }
        private Paciente paciente;

        public Paciente Paciente
        {
            get { return paciente; }
            set { paciente = value; }
        }
        private DateTime fechaTurno;

        public DateTime FechaTurno
        {
            get { return fechaTurno; }
            set { fechaTurno = value; }
        }
        private DateTime horaInicio;

        public DateTime HoraInicio
        {
            get { return horaInicio; }
            set { horaInicio = value; }
        }
        private DateTime horaFin;

        public DateTime HoraFin
        {
            get { return horaFin; }
            set { horaFin = value; }
        }
        private String comentario;

        public String Comentario
        {
            get { return comentario; }
            set { comentario = value; }
        }
        private Cobro cobro;

        public Cobro Cobro
        {
            get { return cobro; }
            set { cobro = value; }
        }

        private EstadoTurno estadoTurno;

        public EstadoTurno EstadoTurno
        {
            get { return estadoTurno; }
            set { estadoTurno = value; }
        }

        private List<Practica> practicas;

        public List<Practica> Practicas
        {
            get { return practicas; }
            set { practicas = value; }
        }

        public Turno()
        { }

        public Turno(DateTime feT, DateTime hoI, DateTime hoF)
        {
            fechaTurno = feT;
            horaInicio = hoI;
            horaFin = hoF;
        }
    }
}
