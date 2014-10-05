using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
   public class Controles
    {
        private int idControl;

        public int IdControl
        {
            get { return idControl; }
            set { idControl = value; }
        }
        private string tipoControl;

        public string TipoControl
        {
            get { return tipoControl; }
            set { tipoControl = value; }
        }
        private int label;

        public int Label
        {
            get { return label; }
            set { label = value; }
        }
        private string texto;

        public string Texto
        {
            get { return texto; }
            set { texto = value; }
        }

   }


}
