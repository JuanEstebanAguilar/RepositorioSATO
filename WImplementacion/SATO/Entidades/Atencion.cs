using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Atencion
    {
        private int idAtencion;

        public int IdAtencion
        {
            get { return idAtencion; }
            set { idAtencion = value; }
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
        private DateTime fecha;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        private DateTime horaAtencion;

        public DateTime HoraAtencion
        {
            get { return horaAtencion; }
            set { horaAtencion = value; }
        }
        private List<DetalleAtencion> detalles;

        public List<DetalleAtencion> Detalles
        {
            get { return detalles; }
            set { detalles = value; }
        }
        private String tratamiento;

        public String Tratamiento
        {
            get { return tratamiento; }
            set { tratamiento = value; }
        }
        private Consultorio consultorio;

        public Consultorio Consultorio
        {
            get { return consultorio; }
            set { consultorio = value; }
        }
    }
}