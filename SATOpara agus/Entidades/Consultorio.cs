using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Consultorio
    {
        private int idConsultorio;

        public int IdConsultorio
        {
            get { return idConsultorio; }
            set { idConsultorio = value; }
        }
        private int numero;

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
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

        public Consultorio(int idC, int num, String nom)
        {
            idConsultorio = idC;
            numero = num;
            nombre = nom;
        }

        public override string ToString()
        {
            return numero + nombre;
        }

    }
}
