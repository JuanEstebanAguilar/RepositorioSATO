using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Diagramacion
    {
        private int idDiagramacion;

        public int IdDiagramacion
        {
            get { return idDiagramacion; }
            set { idDiagramacion = value; }
        }

        private Profesional profesional;

        public Profesional Profesional
        {
            get { return profesional; }
            set { profesional = value; }
        }

        private DateTime fechaAlta;

        public DateTime FechaAlta
        {
            get { return fechaAlta; }
            set { fechaAlta = value; }
        }
        private DateTime fechaDesde;

        public DateTime FechaDesde
        {
            get { return fechaDesde; }
            set { fechaDesde = value; }
        }
        
        private DateTime fechaHasta;

        public DateTime FechaHasta
        {
            get { return fechaHasta; }
            set { fechaHasta = value; }
        }


        private List<DiaDiagramacion> diasDiagramacion;

        public List<DiaDiagramacion> DiasDiagramacion
        {
            get { return diasDiagramacion; }
            set { diasDiagramacion = value; }
        }

        private EstadoDiagramacion estado;

        public EstadoDiagramacion Estado
        {
            get { return estado; }
            set { estado = value; }
        }

     }
}