using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Correo
    {
        private int idCorreo;

        public int IdCorreo
        {
            get { return idCorreo; }
            set { idCorreo = value; }
        }
        private String direccion;

        public String Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public override string ToString()
        {
            return direccion;
        }

        public Correo(int idC, String dir)
        {
            idCorreo = idC;
            direccion = dir;
        }

        public Correo(String dir)
        {
            direccion = dir;
        }

        public Correo()
        { }
    }
}
