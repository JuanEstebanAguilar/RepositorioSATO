using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class CoberturaMedica
    {
        private int idCoberturaMedica;

        public int IdCoberturaMedica
        {
            get { return idCoberturaMedica; }
            set { idCoberturaMedica = value; }
        }

        private String nombre;

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private Domicilio domicilio;

        public Domicilio Domicilio
        {
            get { return domicilio; }
            set { domicilio = value; }
        }
        private Telefono telefono;

        public Telefono Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        private String sigla;

        public String Sigla
        {
            get { return sigla; }
            set { sigla = value; }
        }
        private String numero;

        public String Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        private Correo correo;

        public Correo Correo
        {
            get { return correo; }
            set { correo = value; }
        }
        private String comentario;

        public String Comentario
        {
            get { return comentario; }
            set { comentario = value; }
        }

        public CoberturaMedica()
        { }

        public CoberturaMedica(int idC, String nom, Domicilio dom, Telefono tel, String sig, String num, Correo cor, String com)
        {
            idCoberturaMedica = idC;
            nombre = nom;
            domicilio = dom;
            telefono = tel;
            sigla = sig;
            numero = num;
            correo = cor;
            comentario = com;
        }

        public CoberturaMedica(int idC, String nom, String sig)
        {
            idCoberturaMedica = idC;
            nombre = nom;
            sigla = sig;
        }

        public CoberturaMedica(int idC, String nom_sig)
        {
            idCoberturaMedica = idC;
            nombre = nom_sig;
        }

        public override string ToString()
        {
            return nombre + " (" + sigla + ")";
        }
    }
}

