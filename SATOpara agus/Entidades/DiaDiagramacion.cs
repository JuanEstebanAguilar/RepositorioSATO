using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class DiaDiagramacion
    {
        private int idDiaDiagramacion;

        public int IdDiaDiagramacion
        {
            get { return idDiaDiagramacion; }
            set { idDiaDiagramacion = value; }
        }
        private DateTime fecha;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        private List<DetalleDia> detallesDia;

        public List<DetalleDia> DetallesDia
        {
            get { return detallesDia; }
            set { detallesDia = value; }
        }

        private EstadoDiaDiagramacion estado;

        public EstadoDiaDiagramacion Estado
        {
            get { return estado; }
            set { estado = value; }
        }
    }
}
