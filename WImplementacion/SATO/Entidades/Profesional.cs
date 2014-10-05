using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Profesional : Persona
    {
        private String matricula;
        private int idprofesional;

        public int Idprofesional
        {
            get { return idprofesional; }
            set { idprofesional = value; }
        }

        public String Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }
        private String foto;

        public String Foto
        {
            get { return foto; }
            set { foto = value; }
        }
        public Profesional(String nom, String ape, DateTime feA, String nuD, TipoDocumento tiD, DateTime feN,
                        List<Telefono> tel, List<Correo> cor, Domicilio dom, Usuario usu, String com, Sexo sex, String fo,
                        String mat)
            : base(nom, ape, feA, nuD, tiD, feN, tel, cor, dom, usu, com, sex)
        {
            matricula =mat ;
            foto = fo;
            
        }
        public Profesional(String nom, String ape, DateTime feA, String nuD, TipoDocumento tiD, DateTime feN,
                        List<Telefono> tel, List<Correo> cor, Domicilio dom, Usuario usu, String com, Sexo sex, String fo,
                        String mat, int idProf, int idPer)
            : base(idPer, nom, ape, feA, nuD, tiD, feN, tel, cor, dom, usu, com, sex)
        {
            idprofesional = idProf;
            matricula = mat;
            foto = fo;

        }
         public Profesional(String nom, String ape, String nuD, TipoDocumento tiD, Domicilio dom,int id, String mat)
            : base(nom,ape,nuD,tiD,dom)
        {
             idprofesional=id;
            matricula = mat;
        }
         public Profesional(int idProf, String nom, String ape, DateTime feA, String nuD, TipoDocumento tiD, DateTime feN,
                         List<Telefono> tel, List<Correo> cor, Domicilio dom, Usuario usu, String com, Sexo sex, String fo,
                         String mat)
             : base(nom, ape, feA, nuD, tiD, feN, tel, cor, dom, usu, com, sex)
         {
             matricula = mat;
             foto = fo;
             idprofesional = idProf;
             
         }
         public Profesional(String nom, String ape, String nuD, TipoDocumento tiD, Domicilio dom, int id, String mat, int idPer)
             : base(idPer, nom, ape, nuD, tiD, dom)
         {
             idprofesional = id;
             matricula = mat;
         }

         public Profesional()
         { 
         }
         public override string ToString()
         {
             return Apellido + ", " + Nombre;
         }
    }
}
