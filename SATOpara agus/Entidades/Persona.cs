using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Persona
    {
        private int idPersona;

        public int Idpersona
        {
            get { return idPersona; }
            set { idPersona = value; }
        }

        private String nombre;

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private String apellido;

        public String Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        private DateTime fechaAlta;

        public DateTime FechaAlta
        {
            get { return fechaAlta; }
            set { fechaAlta = value; }
        }
        private String numeroDocumento;

        public String NumeroDocumento
        {
            get { return numeroDocumento; }
            set { numeroDocumento = value; }
        }
        private TipoDocumento tipoDocumento;

        public TipoDocumento TipoDocumento
        {
            get { return tipoDocumento; }
            set { tipoDocumento = value; }
        }
        private DateTime fechaNacimiento;

        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }
        private List<Telefono> telefonos;

        public List<Telefono> Telefonos
        {
            get { return telefonos; }
            set { telefonos = value; }
        }

        
        private List<Correo> correos;

        public List<Correo> Correos
        {
            get { return correos; }
            set { correos = value; }
        }

        private Domicilio domicilio;

        public Domicilio Domicilio
        {
            get { return domicilio; }
            set { domicilio = value; }
        }
        private Usuario usuario;

        public Usuario Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        private String comentario;

        public String Comentario
        {
            get { return comentario; }
            set { comentario = value; }
        }

        private Sexo sexo;

        public Sexo Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public Persona(int idP,String nom,String ape,DateTime feA,String num,TipoDocumento tiD,DateTime feN,
                        List<Telefono> tel,List<Correo> cor,Domicilio dom,Usuario usu,String com,Sexo sex)
        {
            idPersona = idP;
            nombre = nom;
            apellido = ape;
            fechaAlta = feA;
            numeroDocumento = num;
            tipoDocumento = tiD;
            fechaNacimiento = feN;
            telefonos = tel;
            correos = cor;
            domicilio = dom;
            usuario = usu;
            comentario = com;
            sexo = sex;
        }

        public Persona(String nom, String ape, DateTime feA, String num, TipoDocumento tiD, DateTime feN,
                        List<Telefono> tel, List<Correo> cor, Domicilio dom, Usuario usu, String com,Sexo sex)
        {
            nombre = nom;
            apellido = ape;
            fechaAlta = feA;
            numeroDocumento = num;
            tipoDocumento = tiD;
            fechaNacimiento = feN;
            telefonos = tel;
            correos = cor;
            domicilio = dom;
            usuario = usu;
            comentario = com;
            sexo = sex;
        }

        public Persona(String nom, String ape, String num, TipoDocumento tiD,Domicilio dom)
        {
            nombre = nom;
            apellido = ape;
            numeroDocumento = num;
            tipoDocumento = tiD;
            domicilio = dom;
        }
        public Persona(int idPa, String nom, String ape)
        {
            idPersona = idPa;
            nombre = nom;
            apellido = ape;
        }

        public Persona()
        { }
        public Persona(int idP, String nom, String ape, String num, TipoDocumento tiD, Domicilio dom)
        {
            idPersona = idP;
            nombre = nom;
            apellido = ape;
            numeroDocumento = num;
            tipoDocumento = tiD;
            domicilio = dom;
        }
    }
}
