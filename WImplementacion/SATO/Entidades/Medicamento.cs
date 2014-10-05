using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Medicamento
    {
        private int idMedicamento;

        public int IdMedicamento
        {
            get { return idMedicamento; }
            set { idMedicamento = value; }
        }
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private string descripcion;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        private PresentacionMedicamento presentacion;

        public PresentacionMedicamento Presentacion
        {
            get { return presentacion; }
            set { presentacion = value; }
        }
        private Proveedor proveedor;

        public Proveedor Proveedor
        {
            get { return proveedor; }
            set { proveedor = value; }
        }

        private int dias;

        public int Dias
        {
            get { return dias; }
            set { dias = value; }
        }
        private int horas;

        public int Horas
        {
            get { return horas; }
            set { horas = value; }
        }

        private double cantidad;

        public double Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }


        public override string ToString()
        {
            if (cantidad == 0 && horas == 0 && dias == 0)
            { return Nombre; }
            else
            {
                return Nombre + " - " + "Cantidad: " + cantidad + " - " + "Durante (dias): " + " - " + dias + " - " + "Cada (horas): " + horas;
            }
        }
    }
}
