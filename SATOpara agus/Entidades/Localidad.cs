using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Localidad
    {
        private int idlocalidad;
        private Departamento departamento;

        public Departamento Departamento
        {
            get { return departamento; }
            set { departamento = value; }
        }

        public int Idlocalidad
        {
            get { return idlocalidad; }
            set { idlocalidad = value; }
        }
        private String nombre;

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private List<Barrio> barrios;

        public List<Barrio> Barrios
        {
            get { return barrios; }
            set { barrios = value; }
        }
        private String comentario;

        public String Comentario
        {
            get { return comentario; }
            set { comentario = value; }
        }

        public Localidad(int idL, String nom, List<Barrio> bar, String com)
        {
            idlocalidad = idL;
            nombre = nom;
            barrios = bar;
            comentario = com;
        }

        public Localidad(int idL, String nom)
        {
            idlocalidad = idL;
            nombre = nom;
        }

        public Localidad(int idL, String nom, String com)
        {
            idlocalidad = idL;
            nombre = nom;
            comentario = com;
        }

        public Localidad(String nom)
        {
            nombre = nom;
            barrios = new List<Barrio>();
        }
        public Localidad()
        { }

    }
}
