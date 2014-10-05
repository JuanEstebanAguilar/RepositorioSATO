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

        private Turno turno;

        public Turno Turno
        {
            get { return turno; }
            set { turno = value; }
        }
        private Prescripcion prescripcion;

        public Prescripcion Prescripcion
        {
            get { return prescripcion; }
            set { prescripcion = value; }
        }




    }
}