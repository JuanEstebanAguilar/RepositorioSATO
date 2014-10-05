using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class TipoMensaje
    {
        private int idTipoMensaje;
        private String nombre;
        
        public TipoMensaje(int idT, String nom)
        { idTipoMensaje = idT; this.nombre = nom; }

        public void setIdTipoMensaje(int idT)
        { idTipoMensaje = idT; }

        public int getIdTipoMensaje()
        { return idTipoMensaje; }

        public void setNombre(String nom)
        { nombre = nom; }

        public String getNombre()
        { return nombre; }
    }
}
