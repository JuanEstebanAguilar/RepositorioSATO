using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class EstadoUsuario
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

        public EstadoUsuario(int idE, String nom, String des)
        {
            idEstado = idE; nombre = nom; descripcion = des;
        }

        public EstadoUsuario(String nom, String des)
        {
            nombre = nom; descripcion = des;
        }

        public EstadoUsuario(int idE, String nom)
        {
            idEstado = idE;
            nombre = nom;
        }

        public override string ToString()
        {
            return Nombre + Descripcion;
        }

        public EstadoUsuario()
        { }
    }
}
