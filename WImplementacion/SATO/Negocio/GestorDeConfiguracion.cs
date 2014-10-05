using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace Negocio
{
    public class GestorDeConfiguracion
    {
        protected Configuration configuration;

        public GestorDeConfiguracion()
        {
            configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            
        }
        public string getConfiguracion()
        { 
            //return configuration.AppSettings["ColorFondoVentanas"];
            return null;
        }
        public void setConfiguracion(Dictionary<string,string> configuracion)
        {
            foreach (KeyValuePair<string, string> par in configuracion)
            {
                configuration.AppSettings.Settings[par.Key].Value = par.Value;
                configuration.Save(ConfigurationSaveMode.Modified);    
            }
            
        }
    }
}
