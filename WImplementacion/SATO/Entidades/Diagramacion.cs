using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Diagramacion
    {
        private int idDiagramacion;
        private Profesional profesional;
        private EstadoDiagramacion estadoDiagramacion;
        private DateTime fechaAlta;
        private DateTime fechaDesde;
        private DateTime fechaHasta;
        private List<DetalleDiagramacion> detallesDiagramacion;

        public int IdDiagramacion
        {
            get { return idDiagramacion; }
            set { idDiagramacion = value; }
        }
        
        public Profesional Profesional
        {
            get { return profesional; }
            set { profesional = value; }
        }

        public DateTime FechaAlta
        {
            get { return fechaAlta; }
            set { fechaAlta = value; }
        }
        
        public DateTime FechaDesde
        {
            get { return fechaDesde; }
            set { fechaDesde = value; }
        }
        
        public DateTime FechaHasta
        {
            get { return fechaHasta; }
            set { fechaHasta = value; }
        }
        
        public List<DetalleDiagramacion> DetallesDiagramacion
        {
            get { return detallesDiagramacion; }
            set { detallesDiagramacion = value; }
        }
     }
}