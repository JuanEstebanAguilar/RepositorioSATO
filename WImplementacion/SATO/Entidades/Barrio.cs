using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Barrio
    {
        private int idBarrio;
        public Localidad localidad;

        public Localidad Localidad
        {
            get { return localidad; }
            set { localidad = value; }
        }

        public int IdBarrio
        {
            get { return idBarrio; }
            set { idBarrio = value; }
        }
        private String nombre;

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private String comentario;

        public String Comentario
        {
            get { return comentario; }
            set { comentario = value; }
        }

        public Barrio(int idb, String nom, String com)
        {
            idBarrio = idb;
            nombre = nom;
            comentario = com;
        }
        public Barrio(int idb, String nom)
        {
            idBarrio = idb;
            nombre = nom;
        }

        public Barrio(String nom)
        {
            nombre = nom;
        }
        public Barrio()
        { }

      
    }
}
