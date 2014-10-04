using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Practica
    {
        private int idPractica;

        public int IdPractica
        {
            get { return idPractica; }
            set { idPractica = value; }
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

        private int duracion;

        public int Duracion
        {
            get { return duracion; }
            set { duracion = value; }
        }

        public Practica()
        { }

        public Practica(int idP, String nom, int dur,String des)
        {
            idPractica = idP;
            nombre = nom;
            descripcion = des;
            duracion = dur;
        }

        public Practica(int idP, String nom,int dur)
        {
            idPractica = idP;
            nombre = nom;
            duracion = dur;
        }

        public override string ToString()
        {
            return nombre+" ("+duracion+"')";
        }

    }
}
