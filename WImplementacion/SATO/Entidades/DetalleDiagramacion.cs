using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class DetalleDiagramacion
    {
        private int iddetallediagramacion;
        private DateTime horaDesde;
        private DateTime horaHasta;
        private DateTime fecha;

        public int Iddetallediagramacion
        {
            get { return iddetallediagramacion; }
            set { iddetallediagramacion = value; }
        }

        public DateTime HoraDesde
        {
            get { return horaDesde; }
            set { horaDesde = value; }
        }
        
        public DateTime HoraHasta
        {
            get { return horaHasta; }
            set { horaHasta = value; }
        }
        
        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
    }
}
