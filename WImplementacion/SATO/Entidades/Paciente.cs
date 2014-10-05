using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Paciente : Persona
    {
        private int idPaciente;

        public int IdPaciente
        {
            get { return idPaciente; }
            set { idPaciente = value; }
        }

        private String numero;

        public String Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        private List<Afiliacion> afiliaciones;

        public List<Afiliacion> Afiliaciones
        {
            get { return afiliaciones; }
            set { afiliaciones = value; }
        }
        public Paciente(int idP, String nom, String ape, DateTime feA, String nuD, TipoDocumento tiD, DateTime feN,
                        List<Telefono> tel, List<Correo> cor, Domicilio dom, Usuario usu, String com, Sexo sex, String nuP,
                        List<Afiliacion> afi)
            : base(idP, nom, ape, feA, nuD, tiD, feN, tel, cor, dom, usu, com, sex)
        {
            numero = nuP;
            afiliaciones = afi;
        }
        public Paciente(int idP, String nom, String ape, DateTime feA, String nuD, TipoDocumento tiD, DateTime feN,
                        List<Telefono> tel, List<Correo> cor, Domicilio dom, Usuario usu, String com, Sexo sex, String nuP,
                        List<Afiliacion> afi, int idPaci)
            : base(idP, nom, ape, feA, nuD, tiD, feN, tel, cor, dom, usu, com, sex)
        {
            numero = nuP;
            afiliaciones = afi;
            idPaciente = idPaci;
        }

        public Paciente(String nom, String ape, DateTime feA, String nuD, TipoDocumento tiD, DateTime feN,
                        List<Telefono> tel, List<Correo> cor, Domicilio dom, Usuario usu, String com, Sexo sex, String nuP,
                        List<Afiliacion> afi)
            : base(nom, ape, feA, nuD, tiD, feN, tel, cor, dom, usu, com, sex)
        {
            numero = nuP;
            afiliaciones = afi;
        }

        public Paciente(String nom, String ape, String nuD, TipoDocumento tiD, Domicilio dom, String nuP, int idP)
            : base(idP, nom, ape, nuD, tiD, dom)
        {
            numero = nuP;
        }

        public Paciente(int idPe, String nom, String ape)
            : base(idPe, nom, ape)
        { }

        public Paciente()
        { }
        public Paciente(String nom, String ape, String nuD, TipoDocumento tiD, Domicilio dom, String nuP, int idP, int idPac)
            : base(idP, nom, ape, nuD, tiD, dom)
        {
            numero = nuP;
            idPaciente = idPac;
        }

        public override string ToString()
        {
            return base.Apellido + ", " + base.Nombre;
        }


    }
}

