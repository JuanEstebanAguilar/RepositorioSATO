using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
   public class Atigmatismo
    {
        private int idEnfermedad;

        public int IdEnfermedad
        {
            get { return idEnfermedad; }
            set { idEnfermedad = value; }
        }
        private int rangoDerecho;

        public int RangoDerecho
        {
            get { return rangoDerecho; }
            set { rangoDerecho = value; }
        }
        private int rangoIzquierdo;

        public int RangoIzquierdo
        {
            get { return rangoIzquierdo; }
            set { rangoIzquierdo = value; }
        }

        public override string ToString()
        {
            return "Atigmatismo" + ": " + "Rango derecho: " + rangoDerecho + " - "+"Rango izquierdo: " + rangoIzquierdo;
        }


    }
}
