using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class MotivoExcepcion
    {
        private int idMotivoExcepcion;

        public int IdMotivoExcepcion
        {
            get { return idMotivoExcepcion; }
            set { idMotivoExcepcion = value; }
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
