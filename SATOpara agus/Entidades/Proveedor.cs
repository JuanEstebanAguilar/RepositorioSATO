using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Proveedor
    {
        private int idProveedor;

        public int IdProveedor
        {
            get { return idProveedor; }
            set { idProveedor = value; }
        }
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private DateTime fechaalta;

        public DateTime Fechaalta
        {
            get { return fechaalta; }
            set { fechaalta = value; }
        }



    }
}
