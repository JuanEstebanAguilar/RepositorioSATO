using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Empleado : Persona
        {
            private string legajo;

            public string Legajo
            {
                get { return legajo; }
                set { legajo = value; }
            }
            private string foto;

            public string Foto
            {
                get { return foto; }
                set { foto = value; }
            }
            private int idEmpleado;

            public int IdEmpleado
            {
                get { return idEmpleado; }
                set { idEmpleado = value; }
            }
            public Empleado(String nom, String ape, DateTime feA, String nuD, TipoDocumento tiD, DateTime feN,
                            List<Telefono> tel, List<Correo> cor, Domicilio dom, Usuario usu, String com, Sexo sex, string leg)
                : base(nom, ape, feA, nuD, tiD, feN, tel, cor, dom, usu, com, sex)
            {
                legajo = leg;
            }
            public Empleado(String nom, String ape, String nuD, TipoDocumento tiD, Domicilio dom, String leg, int idP, int idE)
                : base(idP, nom, ape, nuD, tiD, dom)
            {
                legajo = leg;
                idEmpleado = idE;
            }
            public Empleado()
            {

            }
            public Empleado(String nom, String ape, DateTime feA, String nuD, TipoDocumento tiD, DateTime feN,
                            List<Telefono> tel, List<Correo> cor, Domicilio dom, Usuario usu, String com, Sexo sex, string leg, int idE, int idP)
                : base(idP, nom, ape, feA, nuD, tiD, feN, tel, cor, dom, usu, com, sex)
            {
                legajo = leg;
                idEmpleado = idE;
            }

       

        }
    
}
