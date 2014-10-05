using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class EstadoTurno
    {
        private int idEstado;

        public int IdEstado
        {
            get { return idEstado; }
            set { idEstado = value; }
        }
        private String nombre;

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private String descripcion;

        public String Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public EstadoTurno()
        { }

        public override string ToString()
        {
            return nombre;
        }
    }
}
