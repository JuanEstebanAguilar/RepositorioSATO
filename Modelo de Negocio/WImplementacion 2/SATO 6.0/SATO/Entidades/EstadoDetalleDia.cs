using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class EstadoDetalleDia
    {
        private int idEstadoDetalleDia;

        public int IdEstadoDetalleDia
        {
            get { return idEstadoDetalleDia; }
            set { idEstadoDetalleDia = value; }
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

        public override string ToString()
        {
            return nombre;
        }
    }
}
