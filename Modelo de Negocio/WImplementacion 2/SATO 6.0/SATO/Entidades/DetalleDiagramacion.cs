using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class DetalleDiagramacion
    {
        private int iddetallediagramacion;

        public int Iddetallediagramacion
        {
            get { return iddetallediagramacion; }
            set { iddetallediagramacion = value; }
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
        private int dia;

        public int Dia
        {
            get { return dia; }
            set { dia = value; }
        }







    }
}
