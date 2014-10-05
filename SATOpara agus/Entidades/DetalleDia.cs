using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class DetalleDia
    {
        private int idDetalleDia;

        public int IdDetalleDia
        {
            get { return idDetalleDia; }
            set { idDetalleDia = value; }
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

        private EstadoDetalleDia estado;

        public EstadoDetalleDia Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public override string ToString()
        {
            return horaInicio.ToShortTimeString()+" - "+horaFin.ToShortTimeString();
        }

        
    }
}
