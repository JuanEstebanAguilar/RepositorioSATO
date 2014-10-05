using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class EstadoDiaDiagramacion
    {
        private int idEstadoDiaDiagramacion;

        public int IdEstadoDiaDiagramacion
        {
            get { return idEstadoDiaDiagramacion; }
            set { idEstadoDiaDiagramacion = value; }
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
