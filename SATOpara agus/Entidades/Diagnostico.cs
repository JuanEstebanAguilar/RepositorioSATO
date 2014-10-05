using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Diagnostico
    {
        private int idDiagnostico;

        public int IdDiagnostico
        {
            get { return idDiagnostico; }
            set { idDiagnostico = value; }
        }

        private List<object> listEnfermedades;

        public List<object> ListEnfermedades
        {
            get { return listEnfermedades; }
            set { listEnfermedades = value; }
        }

        private string observaciones;

        public string Observaciones
        {
            get { return observaciones; }
            set { observaciones = value; }
        }

    }
}
