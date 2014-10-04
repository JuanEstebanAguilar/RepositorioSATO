using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
   public class Prescripcion
    {

        private List<Medicamento> listamedicamentos;

        public List<Medicamento> Listamedicamentos
        {
            get { return listamedicamentos; }
            set { listamedicamentos = value; }
        }
        private int idPrescripcion;

        public int IdPrescripcion
        {
            get { return idPrescripcion; }
            set { idPrescripcion = value; }
        }
private int horas;

public int Horas
{
    get { return horas; }
    set { horas = value; }
}
private int dias;

public int Dias
{
    get { return dias; }
    set { dias = value; }
}

private string observacion;

public string Observacion
{
    get { return observacion; }
    set { observacion = value; }
}

private double cantidadMedicamentos;

public double CantidadMedicamentos
{
    get { return cantidadMedicamentos; }
    set { cantidadMedicamentos = value; }
}
  }
}
