using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Especialidad
    {
        private int idespecialidad;

        public int Idespecialidad
        {
            get { return idespecialidad; }
            set { idespecialidad = value; }
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


        public Especialidad(int id, String nom, String des)
        {
            idespecialidad = id;
            nombre = nom;
            descripcion = des;
        }

        public Especialidad(int id, String nom)
        {
            idespecialidad = id;
            nombre = nom;

        }

        public Especialidad()
        { }
    }
}
