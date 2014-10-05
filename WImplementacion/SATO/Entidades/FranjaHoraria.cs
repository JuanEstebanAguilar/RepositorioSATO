using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class FranjaHoraria
    {
        private DateTime horaDesde;
        private DateTime horaHasta;

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

    }
}
