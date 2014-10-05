using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class EstadoDiagramacion
    {
        private int idEstadoDiagramacion;
        private String nombre;
        private String descripcion;
        public int IdEstadoDiagramacion
        {
            get { return idEstadoDiagramacion; }
            set { idEstadoDiagramacion = value; }
        }
        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public String Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
    }
}
