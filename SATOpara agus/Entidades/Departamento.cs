using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Departamento
    {
        private int idDepartamento;
        private Provincia provincia;

        public Provincia Provincia
        {
            get { return provincia; }
            set { provincia = value; }
        }

        public int IdDepartamento
        {
            get { return idDepartamento; }
            set { idDepartamento = value; }
        }
        private String nombre;

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private List<Localidad> localidades;

        public List<Localidad> Localidades
        {
            get { return localidades; }
            set { localidades = value; }
        }
        private String comentario;

        public String Comentario
        {
            get { return comentario; }
            set { comentario = value; }
        }
        public Departamento (int idDep,String nom,List<Localidad> loc,String com)
        {
            idDepartamento = idDep;
            nombre = nom;
            localidades = loc;
            comentario = com;
        }
        public Departamento (int idDep, String nom)
        {
            idDepartamento = idDep;
            nombre = nom;
            localidades = new List<Localidad>();
        }

        public Departamento(int idDep, String nom, String com)
        {
            idDepartamento = idDep;
            nombre = nom;
            comentario = com;
            localidades = new List<Localidad>();
        }

        public Departamento(String nom)
        {
            nombre = nom;
            localidades = new List<Localidad>();
        }
        public Departamento()
        { }
    }
}
