using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using System.Data.SqlClient;
using Datos;

namespace Negocio
{
    public class GestorDeAtenciones
    {
        public List<Controles> obtenerControles(int idEnfermedad)
        {
            EnlaceDatos enlaceDatos = new EnlaceDatos();
            SqlDataReader drControl = enlaceDatos.getControles(idEnfermedad);
            List<Controles> lsControl = new List<Controles>();

            while (drControl.Read())
            {
                Controles control = new Controles();
                control.IdControl = Convert.ToInt32(drControl[0].ToString());
                control.TipoControl = drControl[1].ToString();
                control.Texto = drControl[2].ToString();

                lsControl.Add(control);
            }
            return lsControl;
        }

        public List<Enfermedad> obtenerEnefermedades()
        {
            EnlaceDatos enlaceDatos = new EnlaceDatos();
            SqlDataReader drEnfermedad = enlaceDatos.getEnfermedades();
            List<Enfermedad> lsEnfermedades = new List<Enfermedad>();

            while (drEnfermedad.Read())
            {
                Enfermedad enf = new Enfermedad();
                enf.Idenfermedad = Convert.ToInt32(drEnfermedad[0].ToString());
                enf.Nombre = drEnfermedad[1].ToString();
                lsEnfermedades.Add(enf);
            }
            return lsEnfermedades;
        }

        public List<Medicamento> obtenerMedicamentos()
        {
            EnlaceDatos enlaceDatos = new EnlaceDatos();
            SqlDataReader drMedicamento = enlaceDatos.getMedicamentos();
            List<Medicamento> lsMedicamento = new List<Medicamento>();

            while (drMedicamento.Read())
            {
                Medicamento medicamento = new Medicamento();
                PresentacionMedicamento presentacion = new PresentacionMedicamento();
                Proveedor proveedor = new Proveedor();

                medicamento.IdMedicamento = Convert.ToInt32(drMedicamento[0].ToString());
                medicamento.Nombre = drMedicamento[1].ToString();
                medicamento.Descripcion = drMedicamento[2].ToString();

                presentacion.IdPresentacion = Convert.ToInt32(drMedicamento[3].ToString());
                presentacion.Nombre = drMedicamento[4].ToString();
                presentacion.Descripcion = drMedicamento[5].ToString();

                proveedor.IdProveedor = Convert.ToInt32(drMedicamento[6].ToString());
                proveedor.Nombre = drMedicamento[7].ToString();
                proveedor.Fechaalta = Convert.ToDateTime(drMedicamento[8].ToString());

                medicamento.Presentacion = presentacion;
                medicamento.Proveedor = proveedor;

                lsMedicamento.Add(medicamento);
            }
            return lsMedicamento;
        }
        public List<Practica> obtenerPracticas()
        {
            EnlaceDatos enlace = new EnlaceDatos();
            SqlDataReader drPracticas = enlace.getPracticas();

            if (drPracticas.HasRows)
            {
                List<Practica> lsPracticas = new List<Practica>();
                while (drPracticas.Read())
                {
                    Practica practica = new Practica();
                    practica.IdPractica = Convert.ToInt32(drPracticas[0].ToString());
                    practica.Nombre = drPracticas.GetString(1);
                    practica.Duracion = Convert.ToInt32(drPracticas[2].ToString());
                    lsPracticas.Add(practica);
                }
                return lsPracticas;
            }
            return null;
        }

        public Boolean tomarAtencion(List<Practica> practica, Diagnostico diag, Prescripcion pres, DateTime fecha, Turno turno)
        {

            EnlaceDatos enlaceDatos = new EnlaceDatos();

            if (enlaceDatos.registrarAtencion(practica, diag, pres, fecha, turno) == true)
            { return true; }
            else
            { return false; }
             //SqlDataReader drProfesionales = enlaceDatos.getProfesionalesParaValidar();

            //List<Entidades.Profesional> listaProfesionales = new List<Entidades.Profesional>();
            //if (drProfesionales.HasRows)
            //{
            //    while (drProfesionales.Read())
            //    {
            //        TipoDocumento tipd = new TipoDocumento();
            //        Profesional e = new Profesional();
            //        e.TipoDocumento = tipd;
            //        e.TipoDocumento.IdTipoDocumento = Convert.ToInt32(drProfesionales[0].ToString());
            //        e.NumeroDocumento = drProfesionales[1].ToString();
            //        e.Matricula = drProfesionales[2].ToString();

            //        listaProfesionales.Add(e);
            //    }
            //    for (int i = 0; i < listaProfesionales.Count; i++)
            //    {
            //        if (listaProfesionales[i].Matricula == profesional.Matricula || (listaProfesionales[i].TipoDocumento.IdTipoDocumento == profesional.TipoDocumento.IdTipoDocumento && listaProfesionales[i].NumeroDocumento == profesional.NumeroDocumento))
            //        {
            //            return false;
            //        }
            //    }
            //}
            //enlaceDatos.registrarProfesional(profesional, usuario, esp, dom, lsttel, correo);
            //return true;

        }
        public List<Turno> obtenerPacientePorTurno(DateTime date, int idProfesional)
        {
            EnlaceDatos enlaceDatos = new EnlaceDatos();
            SqlDataReader drPacientes = enlaceDatos.getPacientesPorTurnos(date, idProfesional);
            List<Turno> lstTurno = new List<Turno>();

            while (drPacientes.Read())
            {
                Paciente pac = new Paciente();
                Turno t = new Turno();

                pac.IdPaciente = Convert.ToInt32(drPacientes[0].ToString());
                pac.Apellido = drPacientes[1].ToString();
                pac.Nombre = drPacientes[2].ToString();
                t.Paciente = pac;
                t.Comentario = drPacientes[3].ToString();
                t.IdTurno = Convert.ToInt32(drPacientes[4].ToString());
                lstTurno.Add(t);

            }
            return lstTurno;
        }

    }
}
