using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Dia
    {
        private int idDia;
        private String nombre;

        public int IdDia
        {
            get { return idDia; }
            set { idDia = value; }
        }
        
        public String Nombre
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
