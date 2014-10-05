using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
   public class Enfermedad
    {

        private int idenfermedad;

        public int Idenfermedad
        {
            get { return idenfermedad; }
            set { idenfermedad = value; }
        }
        string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public override string ToString()
        {
            return nombre;
        }

         }
}
