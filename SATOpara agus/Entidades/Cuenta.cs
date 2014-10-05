using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Cuenta
    {
        private int idCuenta;

        public int IdCuenta
        {
            get { return idCuenta; }
            set { idCuenta = value; }
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

        public Cuenta(int idC, String nom, String des)
        {
            idCuenta = idC;
            nombre = nom;
            descripcion = des;
        }

        public Cuenta(String nom,String des)
        {
            nombre = nom;
            descripcion = des;
        }

        public Cuenta(int idC, String nom)
        {
            idCuenta = idC;
            nombre = nom;
        }

        public override string ToString()
        {
            return idCuenta + nombre;
        }
        public Cuenta()
        { }
    }
}
