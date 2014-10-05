using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Usuario
    {
        private int idusuario;

        public int Idusuario
        {
            get { return idusuario; }
            set { idusuario = value; }
        }
        private String nombre;

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private String contrasenia;

        public String Contrasenia
        {
            get { return contrasenia; }
            set { contrasenia = value; }
        }
        
        private Cuenta cuenta;

        public Cuenta Cuenta
        {
            get { return cuenta; }
            set { cuenta = value; }
        }
        private String comentario;

        public String Comentario
        {
            get { return comentario; }
            set { comentario = value; }
        }
        private EstadoUsuario estado;

        public EstadoUsuario Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        private Huella huella;

        public Huella Huella
        {
            get { return huella; }
            set { huella = value; }
        }

        public Usuario(String nom, String con, Cuenta cue, String com, EstadoUsuario est, Huella hue)
        {
            nombre = nom; contrasenia = con; cuenta = cue; comentario = com; estado = est; huella = hue;
        }

        public Usuario(String nom, String con, Cuenta cue, String com, EstadoUsuario est)
        {
            nombre = nom; contrasenia = con; cuenta = cue; comentario = com; estado = est;
        }

        public Usuario()
        { }

        public override string ToString()
        {
            return nombre;
        }
    }
}
