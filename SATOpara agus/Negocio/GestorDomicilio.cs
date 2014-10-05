using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Entidades;
using Datos;
using Presentacion;

namespace Entidades
{
    public class GestorDomicilio
    {
        private List<Provincia> provincias;

        public void obtenerProvincias()
        {
            EnlaceDatos enlaceDatos = new EnlaceDatos();
            SqlDataReader drProvincias= enlaceDatos.getProvincias();

            List<Provincia> lsProvincias = new List<Provincia>();
            while (drProvincias.Read())
            {
                lsProvincias.Add(new Provincia(Convert.ToInt32(drProvincias[0].ToString()), drProvincias.GetString(1)));
            }
        }
        
    }
}
