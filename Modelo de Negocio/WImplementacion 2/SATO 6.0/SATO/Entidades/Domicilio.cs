using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Domicilio
    {
        private int idDomicilio;

        public int IdDomicilio
        {
            get { return idDomicilio; }
            set { idDomicilio = value; }
        }
        private String calle;

        public String Calle
        {
            get { return calle; }
            set { calle = value; }
        }
        private String numero;

        public String Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        private String departamento;

        public String Departamento
        {
            get { return departamento; }
            set { departamento = value; }
        }
        private String piso;

        public String Piso
        {
            get { return piso; }
            set { piso = value; }
        }

        private String torre;

        public String Torre
        {
            get { return torre; }
            set { torre = value; }
        }

        private Barrio barrio;

        public Barrio Barrio
        {
            get { return barrio; }
            set { barrio = value; }
        }

        public Domicilio(int idD, String cal, String num, String dep, String pis, String tor,Barrio bar)
        {
            idDomicilio = idD;
            calle = cal;
            numero = num;
            departamento = dep;
            piso = pis;
            torre = tor;
            barrio = bar;
        }

        public Domicilio(String cal, String num, String dep, String pis, String tor,Barrio bar)
        {
            calle = cal;
            numero = num;
            departamento = dep;
            piso = pis;
            torre = tor;
            barrio = bar;
        }
        public Domicilio()
        { }
    }
}
