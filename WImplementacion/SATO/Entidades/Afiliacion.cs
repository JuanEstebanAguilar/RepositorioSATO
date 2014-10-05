using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Afiliacion
    {
        private int idAfiliacion;

        public int IdAfiliacion
        {
            get { return idAfiliacion; }
            set { idAfiliacion = value; }
        }
        private String numeroAfiliado;

        public String NumeroAfiliado
        {
            get { return numeroAfiliado; }
            set { numeroAfiliado = value; }
        }
        private CoberturaMedica cobertura;

        public CoberturaMedica Cobertura
        {
            get { return cobertura; }
            set { cobertura = value; }
        }

        public Afiliacion()
        { }

        public Afiliacion(int idA, String num, CoberturaMedica cob)
        {
            idAfiliacion = idA;
            numeroAfiliado = num;
            cobertura = cob;
        }

        public Afiliacion(int idA)
        {
            idAfiliacion = idA;
        }

        public Afiliacion(String num, CoberturaMedica cob)
        {
            numeroAfiliado = num;
            cobertura = cob;
        }

        public override string ToString()
        {
            return "[" + numeroAfiliado + "] " + cobertura.Nombre + " (" + cobertura.Sigla + ")";
        }
    }
}