using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
   public class PresentacionMedicamento
    {
        private int idPresentacion;

        public int IdPresentacion
        {
            get { return idPresentacion; }
            set { idPresentacion = value; }
        }
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private string descripcion;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }






    }
}
