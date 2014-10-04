using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Provincia
    {
        private int idProvincia;


        public int IdProvincia
        {
            get { return idProvincia; }
            set { idProvincia = value; }
        }
        
        private String nombre;

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private List<Departamento> departamentos;

        public List<Departamento> Departamentos
        {
            get { return departamentos; }
            set { departamentos = value; }
        }
        private String comentario;

        public String Comentario
        {
            get { return comentario; }
            set { comentario = value; }
        }
        
        public Provincia(int id, String nom, List<Departamento> dep, String com)
        {
            idProvincia = id;
            nombre = nom;
            departamentos = dep;
            comentario = com;
        }

        public Provincia(int id, String nom, String com)
        { 
            idProvincia = id;
            nombre = nom;
            comentario = com;
            departamentos = new List<Departamento>();
        }

        public Provincia(int id, String nom)
        {
            idProvincia = id;
            nombre = nom;
            departamentos = new List<Departamento>();
        }

        public Provincia(String nom)
        {
            nombre = nom;
            departamentos = new List<Departamento>();
        }
        public Provincia()
        { }
    }
}
