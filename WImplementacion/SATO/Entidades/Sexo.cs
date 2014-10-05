using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Sexo
    {
        private int idSexo;
        public int IdSexo
        {
            get { return idSexo; }
            set { idSexo = value; }
        }

        private String nombre;
        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public Sexo(int idS, String nom)
        {
            idSexo = idS;
            nombre = nom;
        }
        public Sexo()
        { }
    }
}
