using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Huella
    {
        private int idHuella;
        private String codigo;
        
        public int IdHuella
        {
            get { return idHuella; }
            set { idHuella = value; }
        }
        
        public String Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
    }
}
