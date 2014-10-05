using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Datos;
using Entidades;
using System.Data.SqlClient;

namespace Negocio
{
    public class GestorDeMensajes
    {
        public List<Mensaje> obtenerHistorialDeMensajes(int idpersonaorigen, int idpersonadestino)
        {
            EnlaceDatos enlaceDatos = new EnlaceDatos();
            SqlDataReader drMensajes = enlaceDatos.getHistorialDeMensajes(idpersonaorigen, idpersonadestino);
            if (drMensajes.HasRows)
            {
                List<Mensaje> mensajes = new List<Mensaje>();
                while (drMensajes.Read())
                {
                    int idMensaje = Convert.ToInt32(drMensajes[0].ToString());
                    String contenido = drMensajes[1].ToString();
                    EstadoMensaje estado = new EstadoMensaje(Convert.ToInt32(drMensajes[2].ToString()), "");
                    TipoMensaje tipo = new TipoMensaje(Convert.ToInt32(drMensajes[3].ToString()), "");
                    DateTime fechaHora = Convert.ToDateTime(drMensajes[4].ToString());
                    Persona persona = new Persona(Convert.ToInt32(drMensajes[5].ToString()), "", "");
                    Mensaje mensaje = new Mensaje(idMensaje, contenido, tipo, estado, fechaHora, persona);
                    mensajes.Add(mensaje);
                }
                return mensajes;
            }
            return null;
        }

        public Boolean tomarMensaje(Mensaje mensaje)
        {
            EnlaceDatos enlace = new EnlaceDatos();
            String contenido = mensaje.Contenido;
            int idpersona = mensaje.Persona.Idpersona;

            return enlace.registrarMensaje(contenido, idpersona);
        }

        public List<Mensaje> obtenerNuevosMensajes(int idpersonaorigen)
        {
            EnlaceDatos enlace = new EnlaceDatos();
            SqlDataReader drNuevosMensajes = enlace.getNuevosMensajes(idpersonaorigen, 103, 2, 2);
            if (drNuevosMensajes != null)
            {
                if (drNuevosMensajes.HasRows)
                {
                    List<Mensaje> mensajes = new List<Mensaje>();
                    while (drNuevosMensajes.Read())
                    {
                        int idMensaje = Convert.ToInt32(drNuevosMensajes[0].ToString());
                        String contenido = drNuevosMensajes[1].ToString();
                        EstadoMensaje estado = new EstadoMensaje(Convert.ToInt32(drNuevosMensajes[2].ToString()), "");
                        TipoMensaje tipo = new TipoMensaje(Convert.ToInt32(drNuevosMensajes[3].ToString()), "");
                        DateTime fechaHora = Convert.ToDateTime(drNuevosMensajes[4].ToString());
                        Persona persona = new Persona(Convert.ToInt32(drNuevosMensajes[5].ToString()), "", "");
                        Mensaje mensaje = new Mensaje(idMensaje, contenido, tipo, estado, fechaHora, persona);
                        mensajes.Add(mensaje);
                    }
                    return mensajes;
                }
                else
                    return null;
            }
            else
                return null;
        }

        public Boolean verificarNuevosMensajes(int idpersonadestino)
        {
            EnlaceDatos enlace = new EnlaceDatos();
            return enlace.hayNuevosMensajesPorSesion(idpersonadestino);
        }

    }
}
