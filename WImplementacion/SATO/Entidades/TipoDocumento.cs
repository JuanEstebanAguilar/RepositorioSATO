using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class TipoDocumento
    {
        private int idTipoDocumento;

        public int IdTipoDocumento
        {
            get { return idTipoDocumento; }
            set { idTipoDocumento = value; }
        }
        private String nombre;

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private String sigla;

        public String Sigla
        {
            get { return sigla; }
            set { sigla = value; }
        }
        private String comentario;

        public String Comentario
        {
            get { return comentario; }
            set { comentario = value; }
        }

        public TipoDocumento(int idT, String nom, String sig, String com)
        {
            idTipoDocumento = idT;
            nombre = nom;
            sigla = sig;
            comentario = com;
        }
        public TipoDocumento(String nom, String sig, String com)
        {

            nombre = nom;
            sigla = sig;
            comentario = com;
        }

        public TipoDocumento(int idT, String nom)
        {
            idTipoDocumento = idT;
            nombre = nom;
        }

        public TipoDocumento(int idT)
        {
            idTipoDocumento = idT;
        }

        public TipoDocumento(String sig)
        {
            sigla = sig;
        }
        public TipoDocumento()
        { }
    }
}

