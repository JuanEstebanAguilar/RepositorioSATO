using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class EstadoMensaje
    {
        private int idEstadoMensaje;
        private String nombre;

        public EstadoMensaje(int idE, String nom)
        { idEstadoMensaje = idE; nombre = nom; }

        public int getIdEstadoMensaje()
        { return idEstadoMensaje; }

        public void setIdEstadoMensaje(int idE)
        { idEstadoMensaje = idE; }

        public String getNombre()
        { return nombre; }

        public void setNombre(String nom)
        { nombre = nom; }
    }
}
