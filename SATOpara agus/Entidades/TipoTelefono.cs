using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class TipoTelefono
    {
        private int idTipoTelefono;

        public int IdTipoTelefono
        {
            get { return idTipoTelefono; }
            set { idTipoTelefono = value; }
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

        public TipoTelefono(int idT, String nom, String des)
        {
            idTipoTelefono = idT;
            nombre = nom;
            descripcion = des;
        }

        public TipoTelefono(int idT, String nom)
        {
            idTipoTelefono = idT;
            nombre = nom;
        }

        public override string ToString()
        {
            return nombre;
        }

        public TipoTelefono()
        { }
    }
}
