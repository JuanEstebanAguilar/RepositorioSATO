using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    class EstadoDetalleDiagramacion
    {
        private int idEstadoDetalleDiagramacion;

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
