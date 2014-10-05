using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Datos;
using Entidades;
using System.Data.SqlClient;

namespace Negocio
{
    public class GestorDeTurnos
    {
        public List<Turno> obtenerTurnosPorFecha(DateTime fecha)
        {
            EnlaceDatos enlaceDatos = new EnlaceDatos();
            SqlDataReader drTurnos = enlaceDatos.getTurnosPorFecha(fecha);

            List<Turno> lsTurnos = new List<Turno>();
            while (drTurnos.Read())
            {
                //lsTurnos.Add(new Turno(Convert.ToDateTime(drTurnos.GetDateTime(0)),Convert.ToDateTime(drTurnos.GetDateTime(1)),Convert.ToDateTime(drTurnos.GetDateTime(2))));
            }
            return lsTurnos;
        }

        public int tomarTurno(Turno turno)
        {
            DateTime fechaAlta = turno.FechaAlta;
            int idProfesional = turno.Profesional.Idprofesional;
            int idPaciente = turno.Paciente.IdPaciente;
            DateTime fechaTurno = turno.FechaTurno;
            DateTime horaInicio = turno.HoraInicio;
            DateTime horaFin = turno.HoraFin;
            String comentario = turno.Comentario;
            int idEstado = turno.EstadoTurno.IdEstado;

            List<int> lsIdPracticas = new List<int>();
            foreach (Practica practica in turno.Practicas)
            {
                lsIdPracticas.Add(practica.IdPractica);
            }

            EnlaceDatos enlace = new EnlaceDatos();
            return enlace.registrarTurno(fechaAlta, idProfesional, idPaciente, fechaTurno, horaInicio, horaFin, idEstado, comentario, lsIdPracticas);
        }

        public List<Turno> obtenerTurnosPorSemana(DateTime fechaDesde, DateTime fechaHasta, int idProfesional)
        {
            EnlaceDatos datos = new EnlaceDatos();
            SqlDataReader drTurnos = datos.getTurnosPorSemana(fechaDesde, fechaHasta, idProfesional);
            if (drTurnos.HasRows)
            {
                List<Turno> lsTurnos = new List<Turno>();
                while (drTurnos.Read())
                {
                    Turno turno = new Turno();
                    turno.IdTurno = Convert.ToInt32(drTurnos[0].ToString());
                    turno.FechaTurno = drTurnos.GetDateTime(1);
                    turno.HoraInicio = Convert.ToDateTime(drTurnos[2].ToString());
                    turno.HoraFin = Convert.ToDateTime(drTurnos[3].ToString());
                    turno.Comentario = drTurnos.GetString(4);

                    EstadoTurno estado = new EstadoTurno();
                    estado.IdEstado = Convert.ToInt32(drTurnos[5].ToString());
                    estado.Nombre = drTurnos[6].ToString();

                    Paciente paciente = new Paciente();
                    paciente.IdPaciente = Convert.ToInt32(drTurnos[7].ToString());
                    paciente.Apellido = drTurnos[8].ToString();
                    paciente.Nombre = drTurnos[9].ToString();

                    turno.EstadoTurno = estado;
                    turno.Paciente = paciente;
                    lsTurnos.Add(turno);
                }
                return lsTurnos;
            }
            return null;
        }

        public List<EstadoTurno> obtenerTodosEstadosTurno()
        {
            EnlaceDatos enlace = new EnlaceDatos();
            SqlDataReader drEstados = enlace.getAllEstadosTurno();
            if (drEstados.HasRows)
            {
                List<EstadoTurno> lsEstados = new List<EstadoTurno>();
                while (drEstados.Read())
                {
                    EstadoTurno estados = new EstadoTurno();
                    estados.IdEstado = Convert.ToInt32(drEstados[0].ToString());
                    estados.Nombre = drEstados.GetString(1);
                    lsEstados.Add(estados);
                }
                return lsEstados;
            }
            return null;
        }

        public Boolean tomarTurnoAEliminar(Turno turno)
        {
            EnlaceDatos enlace = new EnlaceDatos();
            if (enlace.eliminarTurno(turno.IdTurno))
                return true;
            else
                return false;
        }

        public Boolean tomarTurnoACancelar(Turno turno)
        {
            EnlaceDatos enlace = new EnlaceDatos();
            if (enlace.cancelarTurno(turno.IdTurno))
                return true;
            else
                return false;
        }

        public Boolean tomarTurnoAConfirmar(Turno turno)
        {
            EnlaceDatos enlace = new EnlaceDatos();
            if (enlace.confirmarTurno(turno.IdTurno))
                return true;
            else
                return false;
        }

        public Turno obtenerTurnoPorId(int idTurno)
        {
            EnlaceDatos enlace = new EnlaceDatos();
            
            
            
            
            
            ///// Acá corregir. El turno conoce al paciente




            SqlDataReader drTurno = enlace.getTurnoPorId(idTurno);
            SqlDataReader drPaciente = enlace.getPacientePorTurno(idTurno);
            if (drTurno.HasRows && drPaciente.HasRows)
            {
                drTurno.Read();
                Turno turno = new Turno();
                turno.IdTurno = Convert.ToInt32(drTurno[0].ToString());
                turno.FechaTurno = drTurno.GetDateTime(1);
                turno.HoraInicio = Convert.ToDateTime(drTurno.GetDateTime(2).ToShortTimeString());
                turno.HoraFin = drTurno.GetDateTime(3);
                turno.Comentario = drTurno.GetString(4);

                Profesional profesional = new Profesional();
                profesional.Idprofesional = Convert.ToInt32(drTurno[5].ToString());
                profesional.Apellido = drTurno.GetString(6);
                profesional.Nombre = drTurno.GetString(7);

                EstadoTurno estado = new EstadoTurno();
                estado.IdEstado = Convert.ToInt32(drTurno[8].ToString());
                estado.Nombre = drTurno.GetString(9);

                drPaciente.Read();
                Paciente paciente = new Paciente();
                paciente.IdPaciente = Convert.ToInt32(drPaciente[0].ToString());
                paciente.Apellido = drPaciente.GetString(1);
                paciente.Nombre = drPaciente.GetString(2);

                turno.EstadoTurno = estado;
                turno.Profesional = profesional;
                turno.Paciente = paciente;

                SqlDataReader drPracticas = enlace.getPracticasPorTurno(turno.IdTurno);
                {
                    if (drPracticas.HasRows)
                    {
                        List<Practica> practicas = new List<Practica>();
                        while (drPracticas.Read())
                        {
                            Practica practica = new Practica();
                            practica.IdPractica = Convert.ToInt32(drPracticas[0].ToString());
                            practica.Nombre = drPracticas.GetString(1);
                            practica.Duracion = Convert.ToInt32(drPracticas[2].ToString());
                            practicas.Add(practica);
                        }
                        turno.Practicas = practicas;
                    }
                }
                return turno;
            }
            return null;
        }

        public Diagramacion obtenerDiagramacionPorSemana(int idProfesional, DateTime fechaDesde, DateTime fechaHasta)
        {
            EnlaceDatos enlaceDatos = new EnlaceDatos();
            SqlDataReader drDiagramacion = enlaceDatos.getDiagramacionPorFecha(idProfesional, fechaDesde);
            if (drDiagramacion.HasRows)
            {
                drDiagramacion.Read();
                Diagramacion diagramacion = new Diagramacion();
                diagramacion.IdDiagramacion = Convert.ToInt32(drDiagramacion[0].ToString());
                diagramacion.FechaAlta = Convert.ToDateTime(drDiagramacion[1].ToString());
                diagramacion.FechaDesde = Convert.ToDateTime(drDiagramacion[2].ToString());
                diagramacion.FechaHasta = Convert.ToDateTime(drDiagramacion[3].ToString());

                SqlDataReader drDetallesDiagramacion = enlaceDatos.getDetallesDeDiagramacionPorSemana(idProfesional, fechaDesde, fechaHasta);
                if (drDetallesDiagramacion.HasRows)
                {
                    while (drDetallesDiagramacion.Read())
                    {
                        DetalleDiagramacion detalle = new DetalleDiagramacion();
                        detalle.Iddetallediagramacion = Convert.ToInt32(drDetallesDiagramacion[0].ToString());
                        detalle.Fecha = Convert.ToDateTime(drDetallesDiagramacion[1].ToString());
                        detalle.HoraDesde = Convert.ToDateTime(drDetallesDiagramacion[2].ToString());
                        detalle.HoraHasta = Convert.ToDateTime(drDetallesDiagramacion[3].ToString());
                        diagramacion.DetallesDiagramacion.Add(detalle);
                    }
                }
                return diagramacion;
            }
            else
                return null;
        }

        public List<Dia> obtenerDiasSemana()
        {
            EnlaceDatos enlaceDatos = new EnlaceDatos();
            SqlDataReader drDias = enlaceDatos.getDiasSemana();
            if (drDias.HasRows)
            {
                List<Dia> lsDias = new List<Dia>();
                while (drDias.Read())
                {
                    Dia dia = new Dia();
                    dia.IdDia = Convert.ToInt32(drDias[0].ToString());
                    dia.Nombre = drDias[1].ToString();
                    lsDias.Add(dia);
                }
                return lsDias;
            }
            return null;
        }

    }
}
