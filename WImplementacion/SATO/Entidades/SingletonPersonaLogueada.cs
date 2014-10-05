using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class SingletonPersonaLogueada
    {
        private static SingletonPersonaLogueada personaLogueada=null;
        private Persona persona;
        private SingletonPersonaLogueada()
        { 
            
        }
        public static SingletonPersonaLogueada getInstancia(Persona persona)
        {
            if (personaLogueada == null)
            {
                personaLogueada = new SingletonPersonaLogueada();
                personaLogueada.persona = persona;
            }
            return personaLogueada;
        }
        public Persona getPersona()
        { return persona; }
    }
}
