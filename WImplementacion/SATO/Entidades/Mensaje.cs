using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Mensaje
    {
        private int idMensaje;
        private String contenido;
        private TipoMensaje tipoMensaje;
        private EstadoMensaje estadoMensaje;
        private DateTime fechaHora;
        private Persona persona;

        public Mensaje(int idM, String con, TipoMensaje tip, EstadoMensaje est, DateTime fec,Persona per)
        { idMensaje = idM; contenido = con; tipoMensaje = tip; estadoMensaje = est; fechaHora = fec; persona=per;}

        public Mensaje(String con, TipoMensaje tip, EstadoMensaje est, DateTime fec, Persona per)
        {contenido = con; tipoMensaje = tip; estadoMensaje = est; fechaHora = fec; persona = per; }

        public Mensaje(String contenido, Persona persona)
        {this.contenido = contenido;this.persona = persona;}

        public int IdMensaje
        {
            get { return idMensaje; }
            set { idMensaje = value; }
        }
        public String Contenido
        {
            get { return contenido; }
            set { contenido = value; }
        }

        public TipoMensaje TipoMensaje
        {
            get { return tipoMensaje; }
            set { tipoMensaje = value; }
        }

        public EstadoMensaje EstadoMensaje
        {
            get { return estadoMensaje; }
            set { estadoMensaje = value; }
        }

        public DateTime FechaHora
        {
            get { return fechaHora; }
            set { fechaHora = value; }
        }

        public Persona Persona
        {
            get { return persona; }
            set { persona = value; }
        }
    }
}
