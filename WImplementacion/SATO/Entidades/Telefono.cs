using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Telefono
    {
        private int idTelefono;

        public int IdTelefono
        {
            get { return idTelefono; }
            set { idTelefono = value; }
        }
        private String numero;

        public String Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        private TipoTelefono tipoTelefono;

        public TipoTelefono TipoTelefono
        {
            get { return tipoTelefono; }
            set { tipoTelefono = value; }
        }

        public Telefono(int IdT, String num, TipoTelefono tiT)
        {
            idTelefono = IdT;
            numero = num;
            tipoTelefono = tiT;
        }

        public Telefono(String num, TipoTelefono tiT)
        {
            numero = num;
            tipoTelefono = tiT;
        }

        public override string ToString()
        {
            return numero + " (" + tipoTelefono.Nombre + ")";
        }
        public Telefono()
        { }
    }
}
