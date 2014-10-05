using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Miopia
    {
        private int idEnfermedad;

        public int IdEnfermedad
        {
            get { return idEnfermedad; }
            set { idEnfermedad = value; }
        }
       
        private int rangoderecho;

        public int Rangoderecho
        {
            get { return rangoderecho; }
            set { rangoderecho = value; }
        }
        private int rangoizquierdo;

        public int Rangoizquierdo
        {
            get { return rangoizquierdo; }
            set { rangoizquierdo = value; }
        }
        private int ojoDerecho;

        public int OjoDerecho
        {
            get { return ojoDerecho; }
            set { ojoDerecho = value; }
        }
        private int ojoIzquierdo;

        public int OjoIzquierdo
        {
            get { return ojoIzquierdo; }
            set { ojoIzquierdo = value; }
        }

        public override string ToString()
        {
             return "Miopia" + ": " + "Rango derecho: " + rangoderecho + " - " + "Rango izquierdo: " + rangoizquierdo + " - " + "Perdida parcial:";
        }

    }
}
