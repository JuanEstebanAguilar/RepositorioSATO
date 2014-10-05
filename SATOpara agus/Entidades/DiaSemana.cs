using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class DiaSemana
    {
        private int idDiaSemana;

        public int IdDiaSemana
        {
            get { return idDiaSemana; }
            set { idDiaSemana = value; }
        }
        private String nombre;

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
