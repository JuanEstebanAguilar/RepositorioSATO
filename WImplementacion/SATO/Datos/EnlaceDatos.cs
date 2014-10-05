using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data;
using Entidades;

namespace Datos
{
    public class EnlaceDatos
    {
        static String strCadena = @"Data Source=PC-PC\PC;Initial Catalog=Clinica;Integrated Security=True";
        private SqlConnection getConexion()
        {
                SqlConnection cnConexion = new SqlConnection(strCadena);
                cnConexion.Open();
                return cnConexion;

        }
        public SqlDataReader getProvincias()
        {
            SqlCommand cmdProvincias = new SqlCommand("spGetProvincias", getConexion());
            cmdProvincias.CommandType = CommandType.StoredProcedure;
            SqlDataReader drProvincias = cmdProvincias.ExecuteReader();
            getConexion().Close();
            return drProvincias;
        }
        public SqlDataReader getEspecialidades()
        {
            SqlCommand cmdEspecialidades = new SqlCommand("spGetEspecialidades", getConexion());
            cmdEspecialidades.CommandType = CommandType.StoredProcedure;
            SqlDataReader drEspecialidades = cmdEspecialidades.ExecuteReader();
            return drEspecialidades;
        }

        public SqlDataReader getDepartamentosPorProvincia(int idprovincia)
        {
            SqlCommand cmdDepartamentos = new SqlCommand("spGetDepartamentosPorProvincia", getConexion());
            cmdDepartamentos.CommandType = CommandType.StoredProcedure;
            cmdDepartamentos.Parameters.Add(new SqlParameter("idprovincia", idprovincia));
            SqlDataReader drDepartamentos = cmdDepartamentos.ExecuteReader();
            return drDepartamentos;
        }

        public SqlDataReader getLocalidadesPorDepartamento(int iddepartamento)
        {
            SqlCommand cmdLocalidades = new SqlCommand("spGetLocalidadesPorDepartamento", getConexion());
            cmdLocalidades.CommandType = CommandType.StoredProcedure;
            cmdLocalidades.Parameters.Add(new SqlParameter("iddepartamento", iddepartamento));
            SqlDataReader drLocalidades = cmdLocalidades.ExecuteReader();
            return drLocalidades;
        }

        public SqlDataReader getBarriosPorLocalidad(int idlocalidad)
        {
            SqlCommand cmdBarrios = new SqlCommand("spGetBarriosPorLocalidad", getConexion());
            cmdBarrios.CommandType = CommandType.StoredProcedure;
            cmdBarrios.Parameters.Add(new SqlParameter("idlocalidad", idlocalidad));
            SqlDataReader drBarrios = cmdBarrios.ExecuteReader();
            return drBarrios;
        }

        public SqlDataReader getTiposDocumento()
        {
            SqlCommand cmdTiposDocumento = new SqlCommand("spGetTiposDocumento", getConexion());
            cmdTiposDocumento.CommandType = CommandType.StoredProcedure;
            SqlDataReader drTiposDocumento = cmdTiposDocumento.ExecuteReader();
            return drTiposDocumento;
        }

        public SqlDataReader getTiposTelefono()
        {
            SqlCommand cmdTiposTelefono = new SqlCommand("spGetTiposTelefono", getConexion());
            cmdTiposTelefono.CommandType = CommandType.StoredProcedure;
            SqlDataReader drTiposTelefono = cmdTiposTelefono.ExecuteReader();
            return drTiposTelefono;
        }

        public SqlDataReader getCoberturasMedica()
        {
            SqlCommand cmdCoberturasMedica = new SqlCommand("spGetCoberturasMedicas", getConexion());
            cmdCoberturasMedica.CommandType = CommandType.StoredProcedure;
            SqlDataReader drCoberturasMedica = cmdCoberturasMedica.ExecuteReader();
            return drCoberturasMedica;
        }

        public SqlDataReader getProfesionales()
        {
            SqlCommand cmdProfesionales = new SqlCommand("spGetProfesionales", getConexion());
            cmdProfesionales.CommandType = CommandType.StoredProcedure;
            SqlDataReader drProfesionales = cmdProfesionales.ExecuteReader();
            return drProfesionales;
        }

        public SqlDataReader getSexos()
        {
            SqlConnection cnConexion = getConexion();
            SqlCommand cmdSexos = new SqlCommand("spGetSexos", cnConexion);
            cmdSexos.CommandType = CommandType.StoredProcedure;
            SqlDataReader drSexos = cmdSexos.ExecuteReader();
            return drSexos;
        }

        public SqlDataReader getAllTiposDocumento()
        {
            SqlConnection cnConexion = getConexion();
            SqlCommand cmdTiposDocumento = new SqlCommand("spGetAllTiposDocumento", cnConexion);
            cmdTiposDocumento.CommandType = CommandType.StoredProcedure;
            SqlDataReader drTiposDocumento = cmdTiposDocumento.ExecuteReader();
            return drTiposDocumento;
        }

        public SqlDataReader getAllProvincias()
        {
            SqlConnection cnConexion = getConexion();
            SqlCommand cmdProvincias = new SqlCommand("spGetAllProvincias", cnConexion);
            cmdProvincias.CommandType = CommandType.StoredProcedure;
            SqlDataReader drProvincias = cmdProvincias.ExecuteReader();
            return drProvincias;
        }

        public SqlDataReader getAllDepartamentos(int idProvincia)
        {
            SqlCommand cmdDepartamentos = new SqlCommand("spGetAllDepartamentos", getConexion());
            cmdDepartamentos.CommandType = CommandType.StoredProcedure;
            cmdDepartamentos.Parameters.Add(new SqlParameter("idProv", idProvincia));
            SqlDataReader drDepartamentos = cmdDepartamentos.ExecuteReader();
            return drDepartamentos;
        }

        public SqlDataReader getAllLocalidades(int idDepartamento)
        {
            SqlCommand cmdLocalidades = new SqlCommand("spGetAllLocalidades", getConexion());
            cmdLocalidades.CommandType = CommandType.StoredProcedure;
            cmdLocalidades.Parameters.Add(new SqlParameter("idDep", idDepartamento));
            SqlDataReader drLocalidades = cmdLocalidades.ExecuteReader();
            return drLocalidades;
        }

        public SqlDataReader getAllBarrios(int idLocalidad)
        {
            SqlCommand cmdBarrios = new SqlCommand("spGetAllBarrios", getConexion());
            cmdBarrios.CommandType = CommandType.StoredProcedure;
            SqlDataReader drBarrios = cmdBarrios.ExecuteReader();
            return drBarrios;
        }

        public SqlDataReader getCuentas()
        {
            SqlCommand cmdCuentas = new SqlCommand("spGetCuentas", getConexion());
            cmdCuentas.CommandType = CommandType.StoredProcedure;
            SqlDataReader drCuentas = cmdCuentas.ExecuteReader();
            return drCuentas;
        }
        public SqlDataReader getCuentaPaciente()
        {
            SqlCommand cmdCuentas = new SqlCommand("spGetCuentas", getConexion());
            cmdCuentas.CommandType = CommandType.StoredProcedure;
            SqlDataReader drCuentas = cmdCuentas.ExecuteReader();
            return drCuentas;
        }


        public SqlDataReader getEstadosUsuarios()
        {
            SqlCommand cmdEstados = new SqlCommand("spGetEstadosUsuario", getConexion());
            cmdEstados.CommandType = CommandType.StoredProcedure;
            SqlDataReader drEstados = cmdEstados.ExecuteReader();
            return drEstados;
        }

        public SqlDataReader getTurnosPorFecha(DateTime fecha)
        {
            SqlCommand cmdturnos = new SqlCommand("spGetTurnosPorFecha", getConexion());
            cmdturnos.CommandType = CommandType.StoredProcedure;
            cmdturnos.Parameters.Add(new SqlParameter("fecha", fecha));
            SqlDataReader drTurnos = cmdturnos.ExecuteReader();
            return drTurnos;
        }


        public Especialidad getEspecialidadxID(int idEspecialidad)
        {
            SqlCommand cmdEspecialidad = new SqlCommand("spgetEspecialidadxID", getConexion());
            cmdEspecialidad.CommandType = CommandType.StoredProcedure;

            SqlParameter pNombre = new SqlParameter("nombre", SqlDbType.NVarChar);
            pNombre.Direction = ParameterDirection.Output;
            pNombre.Size = 50;

            SqlParameter pDescripcion = new SqlParameter("descripcion", SqlDbType.NVarChar);
            pDescripcion.Direction = ParameterDirection.Output;
            pDescripcion.Size = 50;

            cmdEspecialidad.Parameters.AddWithValue("idespecialidad", idEspecialidad);

            cmdEspecialidad.Parameters.Add(pNombre);
            cmdEspecialidad.Parameters.Add(pDescripcion);

            SqlDataReader drEspecialidades = cmdEspecialidad.ExecuteReader();

            String nombre = pNombre.Value.ToString();
            String descrip = pDescripcion.Value.ToString();

            Especialidad esp = new Especialidad(idEspecialidad, nombre, descrip);
            return esp;
        }


        public int setPersona(String nombre, String apellido, DateTime fechaAlta, String numeroDocumento,
                                int idTipoDocumento, DateTime fechaNacimiento, String comentario, int idSexo)
        {
            SqlCommand cmdPersona = new SqlCommand("spSetPersona", getConexion());
            cmdPersona.CommandType = CommandType.StoredProcedure;
            cmdPersona.Parameters.Add(new SqlParameter("nombre", nombre));
            cmdPersona.Parameters.Add(new SqlParameter("apellido", apellido));
            cmdPersona.Parameters.Add(new SqlParameter("fechaAlta", fechaAlta));
            cmdPersona.Parameters.Add(new SqlParameter("numeroDocumento", numeroDocumento));
            cmdPersona.Parameters.Add(new SqlParameter("idTipoDocumento", idTipoDocumento));
            cmdPersona.Parameters.Add(new SqlParameter("fechaNacimiento", fechaNacimiento));
            cmdPersona.Parameters.Add(new SqlParameter("comentario", comentario));
            cmdPersona.Parameters.Add(new SqlParameter("idSexo", idSexo));
            return Convert.ToInt32(cmdPersona.ExecuteScalar());
        }

        public int setPaciente(String numeroPaciente, int idPersona)
        {
            SqlCommand cmdPaciente = new SqlCommand("spSetPaciente", getConexion());
            cmdPaciente.CommandType = CommandType.StoredProcedure;
            cmdPaciente.Parameters.Add(new SqlParameter("idPersona", idPersona));
            cmdPaciente.Parameters.Add(new SqlParameter("numeroPaciente", numeroPaciente));
            return Convert.ToInt32(cmdPaciente.ExecuteScalar());
        }

        public void setAfiliacion(int idPaciente, int idCobertura, String numeroAfiliado)
        {
            SqlCommand cmdAfiliacion = new SqlCommand("spSetAfiliacion", getConexion());
            cmdAfiliacion.CommandType = CommandType.StoredProcedure;
            cmdAfiliacion.Parameters.Add(new SqlParameter("idPaciente", idPaciente));
            cmdAfiliacion.Parameters.Add(new SqlParameter("idCobertura", idCobertura));
            cmdAfiliacion.Parameters.Add(new SqlParameter("numeroAfiliado", numeroAfiliado));
            cmdAfiliacion.ExecuteNonQuery();
        }

        public void setDomicilio(String calle, String numero, String departamento, String piso, String torre,
                                int idBarrio, int idPersona)
        {
            SqlCommand cmdDomicilio = new SqlCommand("spSetDomicilio", getConexion());
            cmdDomicilio.CommandType = CommandType.StoredProcedure;
            cmdDomicilio.Parameters.Add(new SqlParameter("calle", calle));
            cmdDomicilio.Parameters.Add(new SqlParameter("numero", numero));
            cmdDomicilio.Parameters.Add(new SqlParameter("departamento", departamento));
            cmdDomicilio.Parameters.Add(new SqlParameter("piso", piso));
            cmdDomicilio.Parameters.Add(new SqlParameter("torre", torre));
            cmdDomicilio.Parameters.Add(new SqlParameter("idBarrio", idBarrio));
            cmdDomicilio.Parameters.Add(new SqlParameter("idPersona", idPersona));
            cmdDomicilio.ExecuteNonQuery();
        }

        public void setTelefono(String numero, int idTipoTelefono, int idPersona)
        {
            SqlCommand cmdTelefono = new SqlCommand("spSetTelefono", getConexion());
            cmdTelefono.CommandType = CommandType.StoredProcedure;
            cmdTelefono.Parameters.Add(new SqlParameter("numero", numero));
            cmdTelefono.Parameters.Add(new SqlParameter("idTipoTelefono", idTipoTelefono));
            cmdTelefono.Parameters.Add(new SqlParameter("idPersona", idPersona));
            cmdTelefono.ExecuteNonQuery();
        }

        public void setCorreo(String direccion, int idPersona)
        {
            SqlCommand cmdCorreo = new SqlCommand("spSetCorreo", getConexion());
            cmdCorreo.CommandType = CommandType.StoredProcedure;
            cmdCorreo.Parameters.Add(new SqlParameter("direccion", direccion));
            cmdCorreo.Parameters.Add(new SqlParameter("idPersona", idPersona));
            cmdCorreo.ExecuteNonQuery();
        }

        public void setUsuario(String nombre, String contrasenia, int idCuenta, String comentario,
                                int idPersona, int idEstadoUsuario)
        {
            SqlCommand cmdUsuario = new SqlCommand("spSetUsuario", getConexion());
            cmdUsuario.CommandType = CommandType.StoredProcedure;
            cmdUsuario.Parameters.Add(new SqlParameter("nombre", nombre));
            cmdUsuario.Parameters.Add(new SqlParameter("contrasenia", contrasenia));
            cmdUsuario.Parameters.Add(new SqlParameter("idCuenta", idCuenta));
            cmdUsuario.Parameters.Add(new SqlParameter("comentario", comentario));
            cmdUsuario.Parameters.Add(new SqlParameter("idPersona", idPersona));
            cmdUsuario.Parameters.Add(new SqlParameter("idEstadoUsuario", idEstadoUsuario));
            cmdUsuario.ExecuteNonQuery();
        }

        public SqlDataReader getPacientePorBusqueda(String parametro)
        {
            SqlCommand cmdPaciente = new SqlCommand("spGetPacientePorBusqueda", getConexion());
            cmdPaciente.CommandType = CommandType.StoredProcedure;
            cmdPaciente.Parameters.Add(new SqlParameter("parametro", "%" + parametro + "%"));
            SqlDataReader drPaciente = cmdPaciente.ExecuteReader();
            return drPaciente;
        }
        public SqlDataReader getProfesionalPorBusqueda(String parametro)
        {
            SqlCommand cmdProfesional = new SqlCommand("spGetProfesionalPorBusqueda", getConexion());
            cmdProfesional.CommandType = CommandType.StoredProcedure;
            cmdProfesional.Parameters.Add(new SqlParameter("parametro", "%" + parametro + "%"));
            SqlDataReader drProfesional = cmdProfesional.ExecuteReader();
            return drProfesional;
        }

        public SqlDataReader getPacientes()
        {
            SqlCommand cmdPaciente = new SqlCommand("spGetPacientes", getConexion());
            cmdPaciente.CommandType = CommandType.StoredProcedure;
            SqlDataReader drPaciente = cmdPaciente.ExecuteReader();
            return drPaciente;
        }

        public SqlDataReader getEmpleadosParaValidar()
        {
            SqlCommand cmdEmpleado = new SqlCommand("spGetEmpleadosParaValidar", getConexion());
            cmdEmpleado.CommandType = CommandType.StoredProcedure;
            SqlDataReader drEmpleado = cmdEmpleado.ExecuteReader();
            return drEmpleado;
        }

        public SqlDataReader getBarrioParaValidar()
        {
            SqlCommand cmdBarrio = new SqlCommand("spGetBarrioParaValidar", getConexion());
            cmdBarrio.CommandType = CommandType.StoredProcedure;
            SqlDataReader drBarrio = cmdBarrio.ExecuteReader();
            return drBarrio;
        }
        public SqlDataReader getTipoDocParaValidar()
        {
            SqlCommand cmdTipoDoc = new SqlCommand("spGetTipoDocParaValidar", getConexion());
            cmdTipoDoc.CommandType = CommandType.StoredProcedure;
            SqlDataReader drTipoDoc = cmdTipoDoc.ExecuteReader();
            return drTipoDoc;
        }


        public SqlDataReader getPacientesParaValidar()
        {
            SqlCommand cmdPaciente = new SqlCommand("spGetPacientesParaValidar", getConexion());
            cmdPaciente.CommandType = CommandType.StoredProcedure;
            SqlDataReader drPaciente = cmdPaciente.ExecuteReader();
            return drPaciente;
        }
        public SqlDataReader getProfesionalesParaValidar()
        {
            SqlCommand cmdProfesional = new SqlCommand("spGetProfesionalesParaValidar", getConexion());
            cmdProfesional.CommandType = CommandType.StoredProcedure;
            SqlDataReader drProfesional = cmdProfesional.ExecuteReader();
            return drProfesional;
        }
        public SqlDataReader getConsultorios()
        {
            SqlCommand cmdConsultorios = new SqlCommand("spGetConsultorios", getConexion());
            cmdConsultorios.CommandType = CommandType.StoredProcedure;
            SqlDataReader drConsultorios = cmdConsultorios.ExecuteReader();
            return drConsultorios;
        }
        public SqlDataReader getPracticas()
        {
            SqlCommand cmdPracticas = new SqlCommand("spGetPracticas", getConexion());
            cmdPracticas.CommandType = CommandType.StoredProcedure;
            return cmdPracticas.ExecuteReader();
        }
        public SqlDataReader getPacientePorNumero(String numPaciente)
        {
            SqlCommand cmdPaciente = new SqlCommand("spGetPacientePorNumero", getConexion());
            cmdPaciente.CommandType = CommandType.StoredProcedure;
            cmdPaciente.Parameters.Add(new SqlParameter("numPaciente", numPaciente));
            SqlDataReader drPacienteBusqueda = cmdPaciente.ExecuteReader();
            return drPacienteBusqueda;
        }
        public SqlDataReader getCorreosPorPersona(int param)
        {
            SqlCommand cmdProfesional = new SqlCommand("spGetCorreosPorPersona", getConexion());
            cmdProfesional.CommandType = CommandType.StoredProcedure;
            cmdProfesional.Parameters.Add(new SqlParameter("param", param));
            SqlDataReader drProfesional = cmdProfesional.ExecuteReader();
            return drProfesional;
        }
        public SqlDataReader getTelefonosPorPersona(int param)
        {
            SqlCommand cmdProfesional = new SqlCommand("spGetTelefonosPorPersona", getConexion());
            cmdProfesional.CommandType = CommandType.StoredProcedure;
            cmdProfesional.Parameters.Add(new SqlParameter("param", param));
            SqlDataReader drProfesional = cmdProfesional.ExecuteReader();
            return drProfesional;
        }
        public SqlDataReader getAfiliacionesPorPaciente(int idPaciente)
        {
            SqlCommand cmdAfiliaciones = new SqlCommand("spGetAfiliacionesPorPaciente", getConexion());
            cmdAfiliaciones.CommandType = CommandType.StoredProcedure;
            cmdAfiliaciones.Parameters.Add(new SqlParameter("idpaciente", idPaciente));
            return cmdAfiliaciones.ExecuteReader();
        }
        public SqlDataReader getCoberturasPorBusqueda(String parametro)
        {
            SqlCommand cmdCoberturas = new SqlCommand("spGetCoberturasPorBusqueda", getConexion());
            cmdCoberturas.CommandType = CommandType.StoredProcedure;
            cmdCoberturas.Parameters.Add(new SqlParameter("parametros", parametro));
            return cmdCoberturas.ExecuteReader();
        }

        public bool registrarProfesional(Profesional profesional, List<Especialidad> especialidades)
        {
            SqlTransaction trans;
            SqlConnection cn = getConexion();
            trans = cn.BeginTransaction();
            try
            {

                //Registrar Persona

                SqlCommand cmd = new SqlCommand("spSetPersonaProfesional", cn, trans);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter pid = cmd.Parameters.Add("@idpersona", SqlDbType.Int);
                pid.Direction = ParameterDirection.Output;

                SqlParameter pNombre = cmd.Parameters.AddWithValue("@nombre", profesional.Nombre);
                SqlParameter pApellido = cmd.Parameters.AddWithValue("@apellido", profesional.Apellido);
                SqlParameter pFechaAlta = cmd.Parameters.AddWithValue("@fechaAlta", profesional.FechaAlta);
                SqlParameter pnumeroDocumento = cmd.Parameters.AddWithValue("@numeroDocumento", profesional.NumeroDocumento);
                SqlParameter pidTipoDocumento = cmd.Parameters.AddWithValue("@idTipoDocumento", profesional.TipoDocumento.IdTipoDocumento);
                SqlParameter pFechaNacimiento = cmd.Parameters.AddWithValue("@fechaNacimiento", profesional.FechaNacimiento);
                SqlParameter pcomentario = cmd.Parameters.AddWithValue("@comentario", profesional.Comentario);
                SqlParameter idSexo = cmd.Parameters.AddWithValue("@idSexo", profesional.Sexo.IdSexo);

                cmd.ExecuteNonQuery();
                int id = Convert.ToInt32(pid.Value.ToString());
                cmd.Parameters.Clear();


                //Registrar Profesional
                cmd = new SqlCommand("spSetProfesional", cn, trans);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter pidprofesional = cmd.Parameters.Add("@idprofesional", SqlDbType.Int);
                pidprofesional.Direction = ParameterDirection.Output;

                SqlParameter pmatricula = cmd.Parameters.AddWithValue("@matricula", profesional.Matricula);
                SqlParameter pfoto = cmd.Parameters.AddWithValue("@foto", profesional.Foto);
                SqlParameter pidPersona = cmd.Parameters.AddWithValue("@idpersona", id);


                cmd.ExecuteNonQuery();

                int idprofesionalp = Convert.ToInt32(pidprofesional.Value.ToString());
                cmd.Parameters.Clear();


                //Registrar Usuario

                cmd = new SqlCommand("spSetUsuario", cn, trans);
                cmd.CommandType = CommandType.StoredProcedure;


                SqlParameter pnombre = cmd.Parameters.AddWithValue("@nombre", profesional.Usuario.Nombre);
                SqlParameter pcontrasenia = cmd.Parameters.AddWithValue("@contrasenia", profesional.Usuario.Contrasenia);
                SqlParameter pidcuenta = cmd.Parameters.AddWithValue("@idCuenta", profesional.Usuario.Cuenta.IdCuenta);
                SqlParameter pcomentariousuario = cmd.Parameters.AddWithValue("@comentario", profesional.Usuario.Comentario);
                SqlParameter pidPersonausuario = cmd.Parameters.AddWithValue("@idPersona", id);
                SqlParameter pidEstadousuario = cmd.Parameters.AddWithValue("@idEstadoUsuario", profesional.Usuario.Estado.IdEstado);


                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();

                //Registrar Telefono
                cmd = new SqlCommand("spSetTelefono", cn, trans);
                cmd.CommandType = CommandType.StoredProcedure;

                foreach (Telefono telefono in profesional.Telefonos)
                {
                    SqlParameter pnumerotelefono = cmd.Parameters.AddWithValue("@numero", telefono.Numero);
                    //     SqlParameter pidTipoTelefono = cmd.Parameters.AddWithValue("@idTipoTelefono", tel[i].TipoTelefono.IdTipoTelefono);
                    SqlParameter pidTipoTelefono = cmd.Parameters.AddWithValue("@idTipoTelefono", telefono.TipoTelefono.IdTipoTelefono);
                    SqlParameter pidPersonatelefono = cmd.Parameters.AddWithValue("@idPersona", id);

                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                }
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public bool registrarProfesional(Profesional profesional, Usuario usuario, List<Especialidad> esp, Domicilio dom, List<Telefono> tel, List<Correo> correo)
        {
            SqlTransaction trans;
            SqlConnection cn = getConexion();
            trans = cn.BeginTransaction();
            try
            {

                //Registrar Persona

                SqlCommand cmd = new SqlCommand("spSetPersonaProfesional", cn, trans);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter pid = cmd.Parameters.Add("@idpersona", SqlDbType.Int);
                pid.Direction = ParameterDirection.Output;

                SqlParameter pNombre = cmd.Parameters.AddWithValue("@nombre", profesional.Nombre);
                SqlParameter pApellido = cmd.Parameters.AddWithValue("@apellido", profesional.Apellido);
                SqlParameter pFechaAlta = cmd.Parameters.AddWithValue("@fechaAlta", profesional.FechaAlta);
                SqlParameter pnumeroDocumento = cmd.Parameters.AddWithValue("@numeroDocumento", profesional.NumeroDocumento);
                SqlParameter pidTipoDocumento = cmd.Parameters.AddWithValue("@idTipoDocumento", profesional.TipoDocumento.IdTipoDocumento);
                SqlParameter pFechaNacimiento = cmd.Parameters.AddWithValue("@fechaNacimiento", profesional.FechaNacimiento);
                SqlParameter pcomentario = cmd.Parameters.AddWithValue("@comentario", profesional.Comentario);
                SqlParameter idSexo = cmd.Parameters.AddWithValue("@idSexo", profesional.Sexo.IdSexo);

                cmd.ExecuteNonQuery();
                int id = Convert.ToInt32(pid.Value.ToString());
                cmd.Parameters.Clear();


                //Registrar Profesional
                cmd = new SqlCommand("spSetProfesional", cn, trans);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter pidprofesional = cmd.Parameters.Add("@idprofesional", SqlDbType.Int);
                pidprofesional.Direction = ParameterDirection.Output;

                SqlParameter pmatricula = cmd.Parameters.AddWithValue("@matricula", profesional.Matricula);
                SqlParameter pfoto = cmd.Parameters.AddWithValue("@foto", profesional.Foto);
                SqlParameter pidPersona = cmd.Parameters.AddWithValue("@idpersona", id);


                cmd.ExecuteNonQuery();

                int idprofesionalp = Convert.ToInt32(pidprofesional.Value.ToString());
                cmd.Parameters.Clear();


                //Registrar Usuario

                cmd = new SqlCommand("spSetUsuario", cn, trans);
                cmd.CommandType = CommandType.StoredProcedure;


                SqlParameter pnombre = cmd.Parameters.AddWithValue("@nombre", usuario.Nombre);
                SqlParameter pcontrasenia = cmd.Parameters.AddWithValue("@contrasenia", usuario.Contrasenia);
                SqlParameter pidcuenta = cmd.Parameters.AddWithValue("@idCuenta", usuario.Cuenta.IdCuenta);
                SqlParameter pcomentariousuario = cmd.Parameters.AddWithValue("@comentario", usuario.Comentario);
                SqlParameter pidPersonausuario = cmd.Parameters.AddWithValue("@idPersona", id);
                SqlParameter pidEstadousuario = cmd.Parameters.AddWithValue("@idEstadoUsuario", usuario.Estado.IdEstado);


                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();

                //Registrar Telefono
                cmd = new SqlCommand("spSetTelefono", cn, trans);
                cmd.CommandType = CommandType.StoredProcedure;

                foreach (Telefono telefono in tel)
                {
                    SqlParameter pnumerotelefono = cmd.Parameters.AddWithValue("@numero", telefono.Numero);
                    //     SqlParameter pidTipoTelefono = cmd.Parameters.AddWithValue("@idTipoTelefono", tel[i].TipoTelefono.IdTipoTelefono);
                    SqlParameter pidTipoTelefono = cmd.Parameters.AddWithValue("@idTipoTelefono", telefono.TipoTelefono.IdTipoTelefono);
                    SqlParameter pidPersonatelefono = cmd.Parameters.AddWithValue("@idPersona", id);

                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                }


                //Registrar Correo
                cmd = new SqlCommand("spSetCorreo", cn, trans);
                cmd.CommandType = CommandType.StoredProcedure;

                for (int i = 0; i < correo.Count; i++)
                {
                    SqlParameter pdireecionelectronica = cmd.Parameters.AddWithValue("@direccion", correo[i].Direccion);
                    SqlParameter pidPersonacorreo = cmd.Parameters.AddWithValue("@idPersona", id);

                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                }

                //Registrar Domicilio
                cmd = new SqlCommand("spSetDomicilio", cn, trans);
                cmd.CommandType = CommandType.StoredProcedure;


                SqlParameter pcalle = cmd.Parameters.AddWithValue("@calle", dom.Calle);
                SqlParameter pnumero = cmd.Parameters.AddWithValue("@numero", dom.Numero);
                SqlParameter pdepartamento = cmd.Parameters.AddWithValue("@departamento", dom.Departamento);
                SqlParameter ppiso = cmd.Parameters.AddWithValue("@piso", dom.Piso);
                SqlParameter ptorre = cmd.Parameters.AddWithValue("@torre", dom.Torre);
                SqlParameter pidBarrio = cmd.Parameters.AddWithValue("@idBarrio", dom.Barrio.IdBarrio);
                SqlParameter pidPersonaparadomicilio = cmd.Parameters.AddWithValue("@idPersona", id);


                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();

                //grabar Especialidades x Profesional
                for (int i = 0; i < esp.Count; i++)
                {
                    cmd = new SqlCommand("spSetEspecialidadesxProfesional", cn, trans);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter pidespecialidad = cmd.Parameters.AddWithValue("@idespecialidad", esp[i].Idespecialidad);
                    SqlParameter pidprofesionalxespecialidad = cmd.Parameters.AddWithValue("@idprofesional", idprofesionalp);
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();

                }

                trans.Commit();
                cn.Close();
                return true;

            }
            catch (SqlException ex)
            {
                trans.Rollback();
                cn.Close();
                return false;

            }
        }

        public SqlDataReader getProfesionalxID(int param)
        {
            SqlCommand cmdProfesional = new SqlCommand("spGetProfesionalxID", getConexion());
            cmdProfesional.CommandType = CommandType.StoredProcedure;
            cmdProfesional.Parameters.Add(new SqlParameter("param", param));
            SqlDataReader drProfesional = cmdProfesional.ExecuteReader();
            return drProfesional;
        }


        public SqlDataReader getAllBarriosPorLocalidad(int idLocalidad)
        {
            SqlCommand cmdBarrios = new SqlCommand("spGetAllBarriosPorLocalidad", getConexion());
            cmdBarrios.CommandType = CommandType.StoredProcedure;
            cmdBarrios.Parameters.Add(new SqlParameter("idlocalidad", idLocalidad));
            return cmdBarrios.ExecuteReader();
        }

        public SqlDataReader getBarrioPorId(int idBarrio)
        {
            SqlCommand cmdBarrio = new SqlCommand("spGetBarrioPorId", getConexion());
            cmdBarrio.CommandType = CommandType.StoredProcedure;
            cmdBarrio.Parameters.Add(new SqlParameter("@idbarrio", idBarrio));
            return cmdBarrio.ExecuteReader();
        }

        public int setBarrio(String nombre, int idLocalidad, String comentario)
        {
            SqlCommand cmdBarrio = new SqlCommand("spSetBarrio", getConexion());
            cmdBarrio.CommandType = CommandType.StoredProcedure;
            cmdBarrio.Parameters.Add(new SqlParameter("nombre", nombre));
            cmdBarrio.Parameters.Add(new SqlParameter("idlocalidad", idLocalidad));
            cmdBarrio.Parameters.Add(new SqlParameter("comentario", comentario));
            return Convert.ToInt32(cmdBarrio.ExecuteScalar());
        }
        public SqlDataReader getTipoDocumentoPorId(int idTipoDoc)
        {
            SqlCommand cmdTipoDoc = new SqlCommand("spGetTipoDocumentoPorId", getConexion());
            cmdTipoDoc.CommandType = CommandType.StoredProcedure;
            cmdTipoDoc.Parameters.Add(new SqlParameter("@idtipodocumento", idTipoDoc));
            return cmdTipoDoc.ExecuteReader();
        }


        public SqlDataReader getEspecialidadPorProfesional(int param)
        {
            SqlCommand cmdProfesional = new SqlCommand("getEspecialidadPorProfesional", getConexion());
            cmdProfesional.CommandType = CommandType.StoredProcedure;
            cmdProfesional.Parameters.Add(new SqlParameter("param", param));
            SqlDataReader drProfesional = cmdProfesional.ExecuteReader();
            return drProfesional;
        }
        public Boolean eliminarPaciente(String numeroPaciente)
        {
            SqlConnection cn = getConexion();
            try
            {
                SqlCommand cmdIdPersona = new SqlCommand("spGetPersonaPorPaciente", cn);
                cmdIdPersona.CommandType = CommandType.StoredProcedure;
                cmdIdPersona.Parameters.Add(new SqlParameter("numeropaciente", numeroPaciente));
                int idPersona = Convert.ToInt32(cmdIdPersona.ExecuteScalar());

                SqlCommand cmdIdPaciente = new SqlCommand("spGetIdPacientePorNumero", cn);
                cmdIdPaciente.CommandType = CommandType.StoredProcedure;
                cmdIdPaciente.Parameters.Add(new SqlParameter("numeropaciente", numeroPaciente));
                int idPaciente = Convert.ToInt32(cmdIdPaciente.ExecuteScalar());

                SqlTransaction trans = cn.BeginTransaction();
                SqlParameter prtIdPersona = new SqlParameter("idpersona", idPersona);

                SqlCommand cmdAfiliaciones = new SqlCommand("spEliminarAfiliacionesPorPaciente", cn);//
                cmdAfiliaciones.CommandType = CommandType.StoredProcedure;
                cmdAfiliaciones.Parameters.Add(new SqlParameter("idpaciente", idPaciente));
                cmdAfiliaciones.Transaction = trans;
                cmdAfiliaciones.ExecuteNonQuery();

                SqlCommand cmdDomicilio = new SqlCommand("spEliminarDomicilioPorPaciente", cn);//
                cmdDomicilio.CommandType = CommandType.StoredProcedure;
                cmdDomicilio.Parameters.Add(new SqlParameter("idpersona", idPersona));
                cmdDomicilio.Transaction = trans;
                cmdDomicilio.ExecuteNonQuery();

                SqlCommand cmdTelefonos = new SqlCommand("spEliminarTelefonosPorPaciente", cn);//
                cmdTelefonos.CommandType = CommandType.StoredProcedure;
                cmdTelefonos.Parameters.Add(new SqlParameter("idpersona", idPersona));
                cmdTelefonos.Transaction = trans;
                cmdTelefonos.ExecuteNonQuery();

                SqlCommand cmdCorreos = new SqlCommand("spEliminarCorreosPorPaciente", cn);//
                cmdCorreos.CommandType = CommandType.StoredProcedure;
                cmdCorreos.Parameters.Add(new SqlParameter("idpersona", idPersona));
                cmdCorreos.Transaction = trans;
                cmdCorreos.ExecuteNonQuery();

                SqlCommand cmdUsuario = new SqlCommand("spEliminarUsuarioPorPaciente", cn);//
                cmdUsuario.CommandType = CommandType.StoredProcedure;
                cmdUsuario.Parameters.Add(new SqlParameter("idpersona", idPersona));
                cmdUsuario.Transaction = trans;
                cmdUsuario.ExecuteNonQuery();

                SqlCommand cmdPaciente = new SqlCommand("spEliminarPaciente", cn);
                cmdPaciente.CommandType = CommandType.StoredProcedure;
                cmdPaciente.Parameters.Add(new SqlParameter("idpersona", idPersona));
                cmdPaciente.Transaction = trans;
                cmdPaciente.ExecuteNonQuery();

                SqlCommand cmdPersonas = new SqlCommand("spEliminarPersona", cn);
                cmdPersonas.CommandType = CommandType.StoredProcedure;
                cmdPersonas.Parameters.Add(new SqlParameter("idpersona", idPersona));
                cmdPersonas.Transaction = trans;
                cmdPersonas.ExecuteNonQuery();

                trans.Commit();

                return true;
            }
            catch (SqlException e)
            {
                return false;
            }
        }

        public Boolean eliminarProfesional(int numeroProfesional)
        {
            SqlConnection cn = getConexion();

            try
            {
                SqlCommand cmdIdPersona = new SqlCommand("spGetPersonaPorProfesional", cn);
                cmdIdPersona.CommandType = CommandType.StoredProcedure;
                cmdIdPersona.Parameters.Add(new SqlParameter("numeroProfesional", numeroProfesional));
                int idPersona = Convert.ToInt32(cmdIdPersona.ExecuteScalar());

                SqlTransaction trans = cn.BeginTransaction();
                SqlParameter prtIdPersona = new SqlParameter("idpersona", idPersona);

                SqlCommand cmdAfiliaciones = new SqlCommand("spEliminarEspecialidadesPorProfesional", cn);//
                cmdAfiliaciones.CommandType = CommandType.StoredProcedure;
                cmdAfiliaciones.Parameters.Add(new SqlParameter("numeroProfesional", numeroProfesional));
                cmdAfiliaciones.Transaction = trans;
                cmdAfiliaciones.ExecuteNonQuery();

                SqlCommand cmdDomicilio = new SqlCommand("spEliminarDomicilioPorProfesional", cn);//
                cmdDomicilio.CommandType = CommandType.StoredProcedure;
                cmdDomicilio.Parameters.Add(new SqlParameter("idpersona", idPersona));
                cmdDomicilio.Transaction = trans;
                cmdDomicilio.ExecuteNonQuery();

                SqlCommand cmdTelefonos = new SqlCommand("spEliminarTelefonosPorProfesional", cn);//
                cmdTelefonos.CommandType = CommandType.StoredProcedure;
                cmdTelefonos.Parameters.Add(new SqlParameter("idpersona", idPersona));
                cmdTelefonos.Transaction = trans;
                cmdTelefonos.ExecuteNonQuery();

                SqlCommand cmdCorreos = new SqlCommand("spEliminarCorreosPorProfesional", cn);//
                cmdCorreos.CommandType = CommandType.StoredProcedure;
                cmdCorreos.Parameters.Add(new SqlParameter("idpersona", idPersona));
                cmdCorreos.Transaction = trans;
                cmdCorreos.ExecuteNonQuery();

                SqlCommand cmdUsuario = new SqlCommand("spEliminarUsuarioPorProfesional", cn);//
                cmdUsuario.CommandType = CommandType.StoredProcedure;
                cmdUsuario.Parameters.Add(new SqlParameter("idpersona", idPersona));
                cmdUsuario.Transaction = trans;
                cmdUsuario.ExecuteNonQuery();

                SqlCommand cmdPaciente = new SqlCommand("spEliminarProfesional", cn);
                cmdPaciente.CommandType = CommandType.StoredProcedure;
                cmdPaciente.Parameters.Add(new SqlParameter("idpersona", idPersona));
                cmdPaciente.Transaction = trans;
                cmdPaciente.ExecuteNonQuery();

                SqlCommand cmdPersonas = new SqlCommand("spEliminarPersona", cn);
                cmdPersonas.CommandType = CommandType.StoredProcedure;
                cmdPersonas.Parameters.Add(new SqlParameter("idpersona", idPersona));
                cmdPersonas.Transaction = trans;
                cmdPersonas.ExecuteNonQuery();

                trans.Commit();

                return true;
            }
            catch (SqlException e)
            {
                return false;
            }
        }

        public int setEmpleado(String legajoEmp, int idPersona)
        {
            SqlCommand cmdEmpleado = new SqlCommand("spSetEmpleado", getConexion());
            cmdEmpleado.CommandType = CommandType.StoredProcedure;
            cmdEmpleado.Parameters.Add(new SqlParameter("idPersona", idPersona));
            cmdEmpleado.Parameters.Add(new SqlParameter("legajoEmpleado", legajoEmp));
            cmdEmpleado.Parameters.Add(new SqlParameter("foto", ""));
            return Convert.ToInt32(cmdEmpleado.ExecuteScalar());
        }

        public int setTipoDocumento(String nombre, String sigla, String comentario)
        {
            SqlCommand cmdTipoDoc = new SqlCommand("spSetTipoDocumento", getConexion());
            cmdTipoDoc.CommandType = CommandType.StoredProcedure;
            cmdTipoDoc.Parameters.Add(new SqlParameter("nombre", nombre));
            cmdTipoDoc.Parameters.Add(new SqlParameter("sigla", sigla));
            cmdTipoDoc.Parameters.Add(new SqlParameter("comentario", comentario));
            return Convert.ToInt32(cmdTipoDoc.ExecuteScalar());
        }


        public SqlDataReader getEmpleadoPorBusqueda(String parametro)
        {
            SqlCommand cmdEmpleadoBusqueda = new SqlCommand("spGetEmpleadosPorBusqueda", getConexion());
            cmdEmpleadoBusqueda.CommandType = CommandType.StoredProcedure;
            cmdEmpleadoBusqueda.Parameters.Add(new SqlParameter("parametro", "%" + parametro + "%"));
            SqlDataReader drEmpleadoBusqueda = cmdEmpleadoBusqueda.ExecuteReader();
            return drEmpleadoBusqueda;
        }

        public bool modificarProfesional(Profesional profesional, List<Especialidad> especialidades)
        {
            SqlTransaction trans;
            SqlConnection cn = getConexion();
            trans = cn.BeginTransaction();
            try
            {

                //Modificar Persona

                SqlCommand cmd = new SqlCommand("spModificarPersona", cn, trans);
                cmd.CommandType = CommandType.StoredProcedure;


                SqlParameter pidPersona = cmd.Parameters.AddWithValue("@idPersona", profesional.Idpersona);
                SqlParameter pNombre = cmd.Parameters.AddWithValue("@nombre", profesional.Nombre);
                SqlParameter pApellido = cmd.Parameters.AddWithValue("@apellido", profesional.Apellido);
                SqlParameter pFechaAlta = cmd.Parameters.AddWithValue("@fechaAlta", profesional.FechaAlta);
                SqlParameter pnumeroDocumento = cmd.Parameters.AddWithValue("@numeroDocumento", profesional.NumeroDocumento);
                SqlParameter pidTipoDocumento = cmd.Parameters.AddWithValue("@idTipoDocumento", profesional.TipoDocumento.IdTipoDocumento);
                SqlParameter pFechaNacimiento = cmd.Parameters.AddWithValue("@fechaNacimiento", profesional.FechaNacimiento);
                SqlParameter pcomentario = cmd.Parameters.AddWithValue("@comentario", profesional.Comentario);
                SqlParameter idSexo = cmd.Parameters.AddWithValue("@idSexo", profesional.Sexo.IdSexo);

                cmd.ExecuteNonQuery();

                cmd.Parameters.Clear();


                //Modificar Profesional
                cmd = new SqlCommand("spModificarProfesional", cn, trans);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter pmatricula = cmd.Parameters.AddWithValue("@matricula", profesional.Matricula);
                if (profesional.Foto == null)
                {
                    SqlParameter pfoto = cmd.Parameters.AddWithValue("@foto", "");
                }
                else
                {
                    SqlParameter pfoto = cmd.Parameters.AddWithValue("@foto", profesional.Foto);
                }
                SqlParameter pIdPersona = cmd.Parameters.AddWithValue("@idPersona", profesional.Idpersona);


                cmd.ExecuteNonQuery();

                //Modificar Usuario

                cmd = new SqlCommand("spModificarUsuario", cn, trans);
                cmd.CommandType = CommandType.StoredProcedure;


                SqlParameter pnombre = cmd.Parameters.AddWithValue("@nombre", profesional.Usuario.Nombre);
                SqlParameter pcontrasenia = cmd.Parameters.AddWithValue("@contrasenia", profesional.Usuario.Contrasenia);
                SqlParameter pidcuenta = cmd.Parameters.AddWithValue("@idCuenta", profesional.Usuario.Cuenta.IdCuenta);
                SqlParameter pcomentariousuario = cmd.Parameters.AddWithValue("@comentario", profesional.Usuario.Comentario);
                SqlParameter pidPersonausuario = cmd.Parameters.AddWithValue("@idPersona", profesional.Idpersona);
                SqlParameter pidEstadousuario = cmd.Parameters.AddWithValue("@idEstadoUsuario", profesional.Usuario.Estado.IdEstado);


                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();

                //Modificar Telefono
                SqlCommand cmdTelefonos = new SqlCommand("spEliminarTelefonosPorProfesional", cn);//
                cmdTelefonos.CommandType = CommandType.StoredProcedure;
                cmdTelefonos.Parameters.Add(new SqlParameter("idpersona", profesional.Idpersona));
                cmdTelefonos.Transaction = trans;
                cmdTelefonos.ExecuteNonQuery();


                cmd = new SqlCommand("spSetTelefono", cn, trans);
                cmd.CommandType = CommandType.StoredProcedure;

                foreach (Telefono telefono in profesional.Telefonos)
                {
                    SqlParameter pnumerotelefono = cmd.Parameters.AddWithValue("@numero", telefono.Numero);
                    //     SqlParameter pidTipoTelefono = cmd.Parameters.AddWithValue("@idTipoTelefono", tel[i].TipoTelefono.IdTipoTelefono);
                    SqlParameter pidTipoTelefono = cmd.Parameters.AddWithValue("@idTipoTelefono", telefono.TipoTelefono.IdTipoTelefono);
                    SqlParameter pidPersonatelefono = cmd.Parameters.AddWithValue("@idPersona", profesional.Idpersona);

                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                }


                //Modificar Correo

                SqlCommand cmdCorreos = new SqlCommand("spEliminarCorreosPorEmpleado", cn);
                cmdCorreos.CommandType = CommandType.StoredProcedure;
                cmdCorreos.Parameters.Add(new SqlParameter("idpersona", profesional.Idpersona));
                cmdCorreos.Transaction = trans;
                cmdCorreos.ExecuteNonQuery();

                cmd = new SqlCommand("spSetCorreo", cn, trans);
                cmd.CommandType = CommandType.StoredProcedure;

                for (int i = 0; i < profesional.Correos.Count; i++)
                {
                    SqlParameter pdireecionelectronica = cmd.Parameters.AddWithValue("@direccion", profesional.Correos[i].Direccion);
                    SqlParameter pidPersonacorreo = cmd.Parameters.AddWithValue("@idPersona", profesional.Idpersona);

                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                }

                //Modificar Domicilio
                cmd = new SqlCommand("spModificarDomicilio", cn, trans);
                cmd.CommandType = CommandType.StoredProcedure;


                SqlParameter pcalle = cmd.Parameters.AddWithValue("@calle", profesional.Domicilio.Calle);
                SqlParameter pnumero = cmd.Parameters.AddWithValue("@numero", profesional.Domicilio.Numero);
                SqlParameter pdepartamento = cmd.Parameters.AddWithValue("@departamento", profesional.Domicilio.Departamento);
                SqlParameter ppiso = cmd.Parameters.AddWithValue("@piso", profesional.Domicilio.Piso);
                SqlParameter ptorre = cmd.Parameters.AddWithValue("@torre", profesional.Domicilio.Torre);
                SqlParameter pidBarrio = cmd.Parameters.AddWithValue("@idBarrio", profesional.Domicilio.Barrio.IdBarrio);
                SqlParameter pidPersonaparadomicilio = cmd.Parameters.AddWithValue("@idPersona", profesional.Idpersona);


                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();

                //modificar Especialidades x Profesional
                SqlCommand cmdEspecialidades = new SqlCommand("spEliminarEspecialidadesPorProfesional", cn);//
                cmdEspecialidades.CommandType = CommandType.StoredProcedure;
                cmdEspecialidades.Parameters.Add(new SqlParameter("numeroProfesional", profesional.Idprofesional));
                cmdEspecialidades.Transaction = trans;
                cmdEspecialidades.ExecuteNonQuery();

                for (int i = 0; i < especialidades.Count; i++)
                {
                    cmd = new SqlCommand("spSetEspecialidadesxProfesional", cn, trans);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter pidespecialidad = cmd.Parameters.AddWithValue("@idespecialidad", especialidades[i].Idespecialidad);
                    SqlParameter pidprofesionalxespecialidad = cmd.Parameters.AddWithValue("@idprofesional", profesional.Idprofesional);
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();

                }

                trans.Commit();
                cn.Close();
                return true;

            }
            catch (SqlException ex)
            {
                trans.Rollback();
                cn.Close();
                return false;

            }
        }
        public Boolean modificarEmpleado(Empleado empleado)
        {
            SqlTransaction trans;
            SqlConnection cn = getConexion();
            trans = cn.BeginTransaction();
            try
            {

                //Modificar Persona

                SqlCommand cmd = new SqlCommand("spModificarPersona", cn, trans);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter pIdPersona = cmd.Parameters.AddWithValue("@idpersona", empleado.Idpersona);
                SqlParameter pNombre = cmd.Parameters.AddWithValue("@nombre", empleado.Nombre);
                SqlParameter pApellido = cmd.Parameters.AddWithValue("@apellido", empleado.Apellido);
                SqlParameter pFechaAlta = cmd.Parameters.AddWithValue("@fechaAlta", empleado.FechaAlta);
                SqlParameter pnumeroDocumento = cmd.Parameters.AddWithValue("@numeroDocumento", empleado.NumeroDocumento);
                SqlParameter pidTipoDocumento = cmd.Parameters.AddWithValue("@idTipoDocumento", empleado.TipoDocumento.IdTipoDocumento);
                SqlParameter pFechaNacimiento = cmd.Parameters.AddWithValue("@fechaNacimiento", empleado.FechaNacimiento);
                SqlParameter pcomentario = cmd.Parameters.AddWithValue("@comentario", empleado.Comentario);
                SqlParameter idSexo = cmd.Parameters.AddWithValue("@idSexo", empleado.Sexo.IdSexo);

                cmd.ExecuteNonQuery();

                cmd.Parameters.Clear();


                //Modificar Empleado
                cmd = new SqlCommand("spModificarEmpleado", cn, trans);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter plegajo = cmd.Parameters.AddWithValue("@legajoEmpleado", empleado.Legajo);
                if (empleado.Foto == null)
                {
                    SqlParameter pfoto = cmd.Parameters.AddWithValue("@foto", "");
                }
                else
                {
                    SqlParameter pfoto = cmd.Parameters.AddWithValue("@foto", empleado.Foto);
                }
                SqlParameter pidPersona = cmd.Parameters.AddWithValue("@idpersona", empleado.Idpersona);


                cmd.ExecuteNonQuery();




                //Modificar Usuario

                cmd = new SqlCommand("spModificarUsuario", cn, trans);
                cmd.CommandType = CommandType.StoredProcedure;


                SqlParameter pnombre = cmd.Parameters.AddWithValue("@nombre", empleado.Usuario.Nombre);
                SqlParameter pcontrasenia = cmd.Parameters.AddWithValue("@contrasenia", empleado.Usuario.Contrasenia);
                SqlParameter pidcuenta = cmd.Parameters.AddWithValue("@idCuenta", empleado.Usuario.Cuenta.IdCuenta);
                SqlParameter pcomentariousuario = cmd.Parameters.AddWithValue("@comentario", empleado.Usuario.Comentario);
                SqlParameter pidPersonausuario = cmd.Parameters.AddWithValue("@idPersona", empleado.Idpersona);
                SqlParameter pidEstadousuario = cmd.Parameters.AddWithValue("@idEstadoUsuario", empleado.Usuario.Estado.IdEstado);


                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();

                //Modificar Telefono

                SqlCommand cmdTelefonos = new SqlCommand("spEliminarTelefonosPorEmpleado", cn);//
                cmdTelefonos.CommandType = CommandType.StoredProcedure;
                cmdTelefonos.Parameters.Add(new SqlParameter("idpersona", empleado.Idpersona));
                cmdTelefonos.Transaction = trans;
                cmdTelefonos.ExecuteNonQuery();


                cmd = new SqlCommand("spSetTelefono", cn, trans);
                cmd.CommandType = CommandType.StoredProcedure;

                foreach (Telefono telefono in empleado.Telefonos)
                {
                    SqlParameter pnumerotelefono = cmd.Parameters.AddWithValue("@numero", telefono.Numero);
                    //     SqlParameter pidTipoTelefono = cmd.Parameters.AddWithValue("@idTipoTelefono", tel[i].TipoTelefono.IdTipoTelefono);
                    SqlParameter pidTipoTelefono = cmd.Parameters.AddWithValue("@idTipoTelefono", telefono.TipoTelefono.IdTipoTelefono);
                    SqlParameter pidPersonatelefono = cmd.Parameters.AddWithValue("@idPersona", empleado.Idpersona);

                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                }


                //Modificar Correo

                SqlCommand cmdCorreos = new SqlCommand("spEliminarCorreosPorEmpleado", cn);
                cmdCorreos.CommandType = CommandType.StoredProcedure;
                cmdCorreos.Parameters.Add(new SqlParameter("idpersona", empleado.Idpersona));
                cmdCorreos.Transaction = trans;
                cmdCorreos.ExecuteNonQuery();

                cmd = new SqlCommand("spSetCorreo", cn, trans);
                cmd.CommandType = CommandType.StoredProcedure;

                for (int i = 0; i < empleado.Correos.Count; i++)
                {
                    SqlParameter pdireecionelectronica = cmd.Parameters.AddWithValue("@direccion", empleado.Correos[i].Direccion);
                    SqlParameter pidPersonacorreo = cmd.Parameters.AddWithValue("@idPersona", empleado.Idpersona);

                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                }

                //Modificar Domicilio
                cmd = new SqlCommand("spModificarDomicilio", cn, trans);
                cmd.CommandType = CommandType.StoredProcedure;


                SqlParameter pcalle = cmd.Parameters.AddWithValue("@calle", empleado.Domicilio.Calle);
                SqlParameter pnumero = cmd.Parameters.AddWithValue("@numero", empleado.Domicilio.Numero);
                SqlParameter pdepartamento = cmd.Parameters.AddWithValue("@departamento", empleado.Domicilio.Departamento);
                SqlParameter ppiso = cmd.Parameters.AddWithValue("@piso", empleado.Domicilio.Piso);
                SqlParameter ptorre = cmd.Parameters.AddWithValue("@torre", empleado.Domicilio.Torre);
                SqlParameter pidBarrio = cmd.Parameters.AddWithValue("@idBarrio", empleado.Domicilio.Barrio.IdBarrio);
                SqlParameter pidPersonaparadomicilio = cmd.Parameters.AddWithValue("@idPersona", empleado.Idpersona);


                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();




                trans.Commit();
                cn.Close();
                return true;

            }
            catch (SqlException ex)
            {
                trans.Rollback();
                cn.Close();
                return false;

            }

        }


        public Boolean modificarTipoDocumento(TipoDocumento tipoDoc)
        {
            SqlTransaction trans;
            SqlConnection cn = getConexion();
            trans = cn.BeginTransaction();
            try
            {



                SqlCommand cmd = new SqlCommand("spModificarTipodocumento", cn, trans);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter pIdTipoDocumento = cmd.Parameters.AddWithValue("@idtipodocumento", tipoDoc.IdTipoDocumento);
                SqlParameter pNombre = cmd.Parameters.AddWithValue("@nombre", tipoDoc.Nombre);
                SqlParameter pSigla = cmd.Parameters.AddWithValue("@sigla", tipoDoc.Sigla);
                SqlParameter pcomentario = cmd.Parameters.AddWithValue("@comentario", tipoDoc.Comentario);

                cmd.ExecuteNonQuery();

                cmd.Parameters.Clear();


                trans.Commit();
                cn.Close();
                return true;

            }
            catch (SqlException ex)
            {
                trans.Rollback();
                cn.Close();
                return false;

            }

        }
        public Boolean modificarPaciente(Paciente paciente, DataTable dtAfiliacion)
        {
            SqlTransaction trans;
            SqlConnection cn = getConexion();
            trans = cn.BeginTransaction();
            try
            {

                //Modificar Persona

                SqlCommand cmd = new SqlCommand("spModificarPersona", cn, trans);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter pIdPersona = cmd.Parameters.AddWithValue("@idpersona", paciente.Idpersona);
                SqlParameter pNombre = cmd.Parameters.AddWithValue("@nombre", paciente.Nombre);
                SqlParameter pApellido = cmd.Parameters.AddWithValue("@apellido", paciente.Apellido);
                SqlParameter pFechaAlta = cmd.Parameters.AddWithValue("@fechaAlta", paciente.FechaAlta);
                SqlParameter pnumeroDocumento = cmd.Parameters.AddWithValue("@numeroDocumento", paciente.NumeroDocumento);
                SqlParameter pidTipoDocumento = cmd.Parameters.AddWithValue("@idTipoDocumento", paciente.TipoDocumento.IdTipoDocumento);
                SqlParameter pFechaNacimiento = cmd.Parameters.AddWithValue("@fechaNacimiento", paciente.FechaNacimiento);
                SqlParameter pcomentario = cmd.Parameters.AddWithValue("@comentario", paciente.Comentario);
                SqlParameter idSexo = cmd.Parameters.AddWithValue("@idSexo", paciente.Sexo.IdSexo);

                cmd.ExecuteNonQuery();

                cmd.Parameters.Clear();


                //Modificar Paciente
                cmd = new SqlCommand("spModificarPaciente", cn, trans);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter pNumero = cmd.Parameters.AddWithValue("@numeroPaciente", paciente.Numero);
                SqlParameter pidPersona = cmd.Parameters.AddWithValue("@idpersona", paciente.Idpersona);



                cmd.ExecuteNonQuery();




                //Modificar Usuario

                cmd = new SqlCommand("spModificarUsuario", cn, trans);
                cmd.CommandType = CommandType.StoredProcedure;


                SqlParameter pnombre = cmd.Parameters.AddWithValue("@nombre", paciente.Usuario.Nombre);
                SqlParameter pcontrasenia = cmd.Parameters.AddWithValue("@contrasenia", paciente.Usuario.Contrasenia);
                SqlParameter pidcuenta = cmd.Parameters.AddWithValue("@idCuenta", paciente.Usuario.Cuenta.IdCuenta);
                SqlParameter pcomentariousuario = cmd.Parameters.AddWithValue("@comentario", paciente.Usuario.Comentario);
                SqlParameter pidPersonausuario = cmd.Parameters.AddWithValue("@idPersona", paciente.Idpersona);
                SqlParameter pidEstadousuario = cmd.Parameters.AddWithValue("@idEstadoUsuario", paciente.Usuario.Estado.IdEstado);


                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();

                //Modificar Telefono

                SqlCommand cmdTelefonos = new SqlCommand("spEliminarTelefonosPorPaciente", cn);//
                cmdTelefonos.CommandType = CommandType.StoredProcedure;
                cmdTelefonos.Parameters.Add(new SqlParameter("idpersona", paciente.Idpersona));
                cmdTelefonos.Transaction = trans;
                cmdTelefonos.ExecuteNonQuery();


                cmd = new SqlCommand("spSetTelefono", cn, trans);
                cmd.CommandType = CommandType.StoredProcedure;

                foreach (Telefono telefono in paciente.Telefonos)
                {
                    SqlParameter pnumerotelefono = cmd.Parameters.AddWithValue("@numero", telefono.Numero);
                    //     SqlParameter pidTipoTelefono = cmd.Parameters.AddWithValue("@idTipoTelefono", tel[i].TipoTelefono.IdTipoTelefono);
                    SqlParameter pidTipoTelefono = cmd.Parameters.AddWithValue("@idTipoTelefono", telefono.TipoTelefono.IdTipoTelefono);
                    SqlParameter pidPersonatelefono = cmd.Parameters.AddWithValue("@idPersona", paciente.Idpersona);

                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                }


                //Modificar Correo

                SqlCommand cmdCorreos = new SqlCommand("spEliminarCorreosPorPaciente", cn);
                cmdCorreos.CommandType = CommandType.StoredProcedure;
                cmdCorreos.Parameters.Add(new SqlParameter("idpersona", paciente.Idpersona));
                cmdCorreos.Transaction = trans;
                cmdCorreos.ExecuteNonQuery();

                cmd = new SqlCommand("spSetCorreo", cn, trans);
                cmd.CommandType = CommandType.StoredProcedure;

                for (int i = 0; i < paciente.Correos.Count; i++)
                {
                    SqlParameter pdireecionelectronica = cmd.Parameters.AddWithValue("@direccion", paciente.Correos[i].Direccion);
                    SqlParameter pidPersonacorreo = cmd.Parameters.AddWithValue("@idPersona", paciente.Idpersona);

                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                }

                //Modificar Afiliacion

                SqlCommand cmdAfiliaciones = new SqlCommand("spEliminarAfiliacionesPorPaciente", cn);
                cmdAfiliaciones.CommandType = CommandType.StoredProcedure;
                cmdAfiliaciones.Parameters.Add(new SqlParameter("idpaciente", paciente.IdPaciente));
                cmdAfiliaciones.Transaction = trans;
                cmdAfiliaciones.ExecuteNonQuery();


                foreach (DataRow dr in dtAfiliacion.Rows)
                {
                    SqlCommand cmdAfiliacion = new SqlCommand("spSetAfiliacion", cn, trans);
                    cmdAfiliacion.CommandType = CommandType.StoredProcedure;
                    cmdAfiliacion.Parameters.Add(new SqlParameter("idPaciente", paciente.IdPaciente));
                    cmdAfiliacion.Parameters.Add(new SqlParameter("idCobertura", Convert.ToInt32(dr[0].ToString())));
                    cmdAfiliacion.Parameters.Add(new SqlParameter("numeroAfiliado", dr[1].ToString()));
                    cmdAfiliacion.ExecuteNonQuery();
                }


                //Modificar Domicilio
                cmd = new SqlCommand("spModificarDomicilio", cn, trans);
                cmd.CommandType = CommandType.StoredProcedure;
                
                SqlParameter pcalle = cmd.Parameters.AddWithValue("@calle", paciente.Domicilio.Calle);
                SqlParameter pnumero = cmd.Parameters.AddWithValue("@numero", paciente.Domicilio.Numero);
                SqlParameter pdepartamento = cmd.Parameters.AddWithValue("@departamento", paciente.Domicilio.Departamento);
                SqlParameter ppiso = cmd.Parameters.AddWithValue("@piso", paciente.Domicilio.Piso);
                SqlParameter ptorre = cmd.Parameters.AddWithValue("@torre", paciente.Domicilio.Torre);
                SqlParameter pidBarrio = cmd.Parameters.AddWithValue("@idBarrio", paciente.Domicilio.Barrio.IdBarrio);
                SqlParameter pidPersonaparadomicilio = cmd.Parameters.AddWithValue("@idPersona", paciente.Idpersona);

                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                trans.Commit();
                cn.Close();
                return true;

            }
            catch (SqlException ex)
            {
                trans.Rollback();
                cn.Close();
                return false;

            }
        }

        public SqlDataReader getEmpleadoPorLegajo(String legajo)
        {
            SqlCommand cmdEmpleadoBusqueda = new SqlCommand("spGetEmpleadoPorLegajo", getConexion());
            cmdEmpleadoBusqueda.CommandType = CommandType.StoredProcedure;
            cmdEmpleadoBusqueda.Parameters.Add(new SqlParameter("legajo", legajo));
            SqlDataReader drEmpleadoBusqueda = cmdEmpleadoBusqueda.ExecuteReader();
            return drEmpleadoBusqueda;
        }
        public Boolean eliminarEmpleado(String legajoEmp)
        {
            SqlConnection cn = getConexion();
            try
            {
                SqlCommand cmdIdPersona = new SqlCommand("spGetPersonaPorEmpleado", cn);
                cmdIdPersona.CommandType = CommandType.StoredProcedure;
                cmdIdPersona.Parameters.Add(new SqlParameter("legajoempleado", legajoEmp));
                int idPersona = Convert.ToInt32(cmdIdPersona.ExecuteScalar());

                SqlCommand cmdIdEmpleado = new SqlCommand("spGetIdEmpleadoPorLegajo", cn);
                cmdIdEmpleado.CommandType = CommandType.StoredProcedure;
                cmdIdEmpleado.Parameters.Add(new SqlParameter("legajoempleado", legajoEmp));
                int idEmpleado = Convert.ToInt32(cmdIdEmpleado.ExecuteScalar());

                SqlTransaction trans = cn.BeginTransaction();
                SqlParameter prtIdPersona = new SqlParameter("idpersona", idPersona);

                SqlCommand cmdDomicilio = new SqlCommand("spEliminarDomicilioPorEmpleado", cn);//
                cmdDomicilio.CommandType = CommandType.StoredProcedure;
                cmdDomicilio.Parameters.Add(new SqlParameter("idpersona", idPersona));
                cmdDomicilio.Transaction = trans;
                cmdDomicilio.ExecuteNonQuery();

                SqlCommand cmdTelefonos = new SqlCommand("spEliminarTelefonosPorEmpleado", cn);//
                cmdTelefonos.CommandType = CommandType.StoredProcedure;
                cmdTelefonos.Parameters.Add(new SqlParameter("idpersona", idPersona));
                cmdTelefonos.Transaction = trans;
                cmdTelefonos.ExecuteNonQuery();

                SqlCommand cmdCorreos = new SqlCommand("spEliminarCorreosPorEmpleado", cn);//
                cmdCorreos.CommandType = CommandType.StoredProcedure;
                cmdCorreos.Parameters.Add(new SqlParameter("idpersona", idPersona));
                cmdCorreos.Transaction = trans;
                cmdCorreos.ExecuteNonQuery();

                SqlCommand cmdUsuario = new SqlCommand("spEliminarUsuarioPorEmpleado", cn);//
                cmdUsuario.CommandType = CommandType.StoredProcedure;
                cmdUsuario.Parameters.Add(new SqlParameter("idpersona", idPersona));
                cmdUsuario.Transaction = trans;
                cmdUsuario.ExecuteNonQuery();

                SqlCommand cmdEmpleado = new SqlCommand("spEliminarEmpleado", cn);
                cmdEmpleado.CommandType = CommandType.StoredProcedure;
                cmdEmpleado.Parameters.Add(new SqlParameter("idpersona", idPersona));
                cmdEmpleado.Transaction = trans;
                cmdEmpleado.ExecuteNonQuery();

                SqlCommand cmdPersonas = new SqlCommand("spEliminarPersona", cn);
                cmdPersonas.CommandType = CommandType.StoredProcedure;
                cmdPersonas.Parameters.Add(new SqlParameter("idpersona", idPersona));
                cmdPersonas.Transaction = trans;
                cmdPersonas.ExecuteNonQuery();

                trans.Commit();

                return true;
            }
            catch (SqlException e)
            {
                return false;
            }
        }

        public Boolean eliminarTipoDocumento(String nombreTipoDoc)
        {
            SqlConnection cn = getConexion();
            try
            {
                SqlCommand cmdIdTipoDocumento = new SqlCommand("spGetIdTipoDocumentoPorNombre", cn);
                cmdIdTipoDocumento.CommandType = CommandType.StoredProcedure;
                cmdIdTipoDocumento.Parameters.Add(new SqlParameter("nombre", nombreTipoDoc));
                int idTipoDocumento = Convert.ToInt32(cmdIdTipoDocumento.ExecuteScalar());

                SqlTransaction trans = cn.BeginTransaction();
                SqlParameter prtIdTipoDocumento = new SqlParameter("idtipodocumento", idTipoDocumento);

                SqlCommand cmdTipoDocumento = new SqlCommand("spEliminarTipoDocumento", cn);
                cmdTipoDocumento.CommandType = CommandType.StoredProcedure;
                cmdTipoDocumento.Parameters.Add(new SqlParameter("idtipodocumento", idTipoDocumento));
                cmdTipoDocumento.Transaction = trans;
                cmdTipoDocumento.ExecuteNonQuery();

                trans.Commit();

                return true;
            }
            catch (SqlException e)
            {
                return false;
            }
        }

        
        //Cambios de Juan

        public SqlDataReader getTurnosPorSemana(DateTime fechaDesde, DateTime fechaHasta, int idProfesional)
        {
            SqlCommand cmdturnos = new SqlCommand("spGetTurnosPorSemana", getConexion());
            cmdturnos.CommandType = CommandType.StoredProcedure;
            cmdturnos.Parameters.Add(new SqlParameter("fechadesde", fechaDesde));
            cmdturnos.Parameters.Add(new SqlParameter("fechahasta", fechaHasta));
            cmdturnos.Parameters.Add(new SqlParameter("idprofesional", idProfesional));
            SqlDataReader drTurnos = cmdturnos.ExecuteReader();
            return drTurnos;
        }

        public SqlDataReader getAllProfesionales()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("spGetAllProfesionales", getConexion());
                cmd.CommandType = CommandType.StoredProcedure;
                return cmd.ExecuteReader();
            }

            catch (SqlException ex)
            {
                return null;
            }
        }

        public SqlDataReader getAllPacientes()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("spGetAllPacientes", getConexion());
                cmd.CommandType = CommandType.StoredProcedure;
                return cmd.ExecuteReader();
            }

            catch (SqlException ex)
            {
                return null;
            }
        }


        public int registrarTurno(DateTime fechaAlta, int idProfesional, int idPaciente, DateTime fechaTurno,
                                    DateTime horaInicio, DateTime horaFin, int idEstado, String comentario, List<int> lsIdPracticas)
        {
            try
            {
                SqlConnection cn = getConexion();
                //cn.BeginTransaction(); Agregar la transacción
                SqlCommand cmdTurno = new SqlCommand("spSetTurno", cn);
                cmdTurno.CommandType = CommandType.StoredProcedure;
                cmdTurno.Parameters.Add(new SqlParameter("fechaalta", fechaAlta));
                cmdTurno.Parameters.Add(new SqlParameter("idprofesional", idProfesional));
                cmdTurno.Parameters.Add(new SqlParameter("idpaciente", idPaciente));
                cmdTurno.Parameters.Add(new SqlParameter("fechaturno", fechaTurno));
                cmdTurno.Parameters.Add(new SqlParameter("horainicio", horaInicio));
                cmdTurno.Parameters.Add(new SqlParameter("horafin", horaFin));
                cmdTurno.Parameters.Add(new SqlParameter("idestado", idEstado));
                cmdTurno.Parameters.Add(new SqlParameter("comentario", comentario));
                int idTurno = Convert.ToInt32(cmdTurno.ExecuteScalar());

                SqlCommand cmdPracticas = new SqlCommand("spSetPracticasTurnos", getConexion());
                cmdPracticas.CommandType = CommandType.StoredProcedure;
                SqlParameter prtIdPractica = new SqlParameter();
                prtIdPractica.ParameterName = "idpractica";
                SqlParameter prtIdTurno = new SqlParameter();
                prtIdTurno.ParameterName = "idturno";

                foreach (int idPractica in lsIdPracticas)
                {
                    prtIdPractica.Value = idPractica;
                    prtIdTurno.Value = idTurno;
                    cmdPracticas.Parameters.Add(prtIdPractica);
                    cmdPracticas.Parameters.Add(prtIdTurno);
                    cmdPracticas.ExecuteNonQuery();
                    cmdPracticas.Parameters.Clear();
                }
                return idTurno;
            }
            catch (SqlException ex)
            {
                return 0;
            }
        }

        public SqlDataReader getAllEstadosTurno()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("spGetAllEstados", getConexion());
                cmd.CommandType = CommandType.StoredProcedure;
                return cmd.ExecuteReader();
            }

            catch (SqlException ex)
            {
                return null;
            }
        }

        public Boolean eliminarTurno(int idTurno)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("spEliminarTurno", getConexion());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("idturno", idTurno));
                cmd.ExecuteNonQuery();
                return true;
            }

            catch (SqlException ex)
            {
                return false;
            }
        }
        public Boolean cancelarTurno(int idTurno)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("spCancelarTurno", getConexion());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("idturno", idTurno));
                cmd.ExecuteNonQuery();
                return true;
            }

            catch (SqlException ex)
            {
                return false;
            }
        }

        public Boolean confirmarTurno(int idTurno)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("spConfirmarTurno", getConexion());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("idturno", idTurno));
                cmd.ExecuteNonQuery();
                return true;
            }

            catch (SqlException ex)
            {
                return false;
            }
        }

        public SqlDataReader getTurnoPorId(int idTurno)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("spGetTurnoPorId", getConexion());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("idturno", idTurno));
                return cmd.ExecuteReader();
            }

            catch (SqlException ex)
            {
                return null;
            }
        }

        public SqlDataReader getPacientePorTurno(int idTurno)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("spGetPacientePorTurno", getConexion());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("idturno", idTurno));
                return cmd.ExecuteReader();
            }

            catch (SqlException ex)
            {
                return null;
            }
        }

        public SqlDataReader getPracticasPorTurno(int idTurno)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("spGetPracticasPorTurno", getConexion());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("idturno", idTurno));
                return cmd.ExecuteReader();
            }

            catch (SqlException ex)
            {
                return null;
            }
        }

        public SqlDataReader getHistorialDeMensajes(int idpersonaorigen, int idpersonadestino)
        {
            SqlCommand cmdHistorialMensajes = new SqlCommand("spGetHistorialDeMensajes", getConexion());
            cmdHistorialMensajes.CommandType = CommandType.StoredProcedure;
            cmdHistorialMensajes.Parameters.Add(new SqlParameter("idpersonaorigen", idpersonaorigen));
            cmdHistorialMensajes.Parameters.Add(new SqlParameter("idpersonadestino", idpersonadestino));
            SqlDataReader drHistorialMensajes = cmdHistorialMensajes.ExecuteReader();
            if (drHistorialMensajes.HasRows)
                return drHistorialMensajes;
            else
                return null;
        }

        public Boolean registrarMensaje(String contenido, int idpersona)
        {
            SqlCommand cmdEnviarMensaje = new SqlCommand("spSetMensaje", getConexion());
            cmdEnviarMensaje.CommandType = CommandType.StoredProcedure;
            cmdEnviarMensaje.Parameters.Add(new SqlParameter("contenido", contenido));
            cmdEnviarMensaje.Parameters.Add(new SqlParameter("idtipomensaje", 1));
            cmdEnviarMensaje.Parameters.Add(new SqlParameter("idestadomensaje", 2));
            cmdEnviarMensaje.Parameters.Add(new SqlParameter("fechahora", DateTime.Now));
            cmdEnviarMensaje.Parameters.Add(new SqlParameter("idpersona", idpersona));
            int respuesta = cmdEnviarMensaje.ExecuteNonQuery();
            if (respuesta > 0)
                return true;
            else
            {
                return false;
            }
        }

        public SqlDataReader getNuevosMensajes(int idpersonaorigen, int idpersonadestino, int idestadomensaje, int idtipo)
        {
            SqlCommand cmdNuevosMensaje = new SqlCommand("spGetNuevosMensajes", getConexion());
            cmdNuevosMensaje.CommandType = CommandType.StoredProcedure;
            cmdNuevosMensaje.Parameters.Add(new SqlParameter("@idpersonaorigen", idpersonaorigen));
            cmdNuevosMensaje.Parameters.Add(new SqlParameter("@idpersonadestino", idpersonadestino));
            cmdNuevosMensaje.Parameters.Add(new SqlParameter("@idestadomensaje", 2));
            cmdNuevosMensaje.Parameters.Add(new SqlParameter("@idtipomensaje", 2));

            SqlDataReader drNuevosMensajes = cmdNuevosMensaje.ExecuteReader();
            if (drNuevosMensajes.HasRows)
            {
                SqlCommand cmdMensajesLeidos = new SqlCommand("spSetEstadoMensajeLeido", getConexion());
                cmdMensajesLeidos.CommandType = CommandType.StoredProcedure;
                cmdMensajesLeidos.Parameters.Add(new SqlParameter("idpersonaorigen", idpersonaorigen));
                int cantidad = cmdMensajesLeidos.ExecuteNonQuery();
                if (cantidad > 0)
                    return drNuevosMensajes;
                else
                    return null;
            }
            else
                return null;
        }

        public Boolean hayNuevosMensajesPorSesion(int idpersonadestino)
        {
            SqlCommand cmdHayNuevosMensajes = new SqlCommand("spHayNuevosMensajesParaSesion", getConexion());
            cmdHayNuevosMensajes.CommandType = CommandType.StoredProcedure;
            cmdHayNuevosMensajes.Parameters.Add(new SqlParameter("@idpersonadestino", idpersonadestino));
            cmdHayNuevosMensajes.Parameters.Add(new SqlParameter("@idestadomensaje", 2));
            cmdHayNuevosMensajes.Parameters.Add(new SqlParameter("@idtipomensaje", 2));

            if ((cmdHayNuevosMensajes.ExecuteReader()).HasRows)
            {
                cmdHayNuevosMensajes.Connection.Close();
                return true;
            }
            else
            {
                cmdHayNuevosMensajes.Connection.Close();
                return false;
            }
        }

        public SqlDataReader validarUsuario(String nombre, String contrasenia)
        {
            SqlCommand cmdValidarUsuario = new SqlCommand("spGetPersonaLogueada", getConexion());
            cmdValidarUsuario.CommandType = CommandType.StoredProcedure;
            cmdValidarUsuario.Parameters.Add(new SqlParameter("@nombre", nombre));
            cmdValidarUsuario.Parameters.Add(new SqlParameter("@contrasenia", contrasenia));
            return cmdValidarUsuario.ExecuteReader();
        }

        public SqlDataReader getHuellas()
        {
            SqlCommand cmdHuellas = new SqlCommand("spGetHuellas", getConexion());
            cmdHuellas.CommandType = CommandType.StoredProcedure;
            return cmdHuellas.ExecuteReader();
        }

        public SqlDataReader getDiagramacionPorFecha(int idprofesional, DateTime fecha)
        {
            SqlCommand cmdDiagramacion = new SqlCommand("spGetDiagramacionPorFecha",getConexion());
            cmdDiagramacion.Parameters.Add(new SqlParameter("idprofesional", idprofesional));
            cmdDiagramacion.Parameters.Add(new SqlParameter("fecha", fecha));
            cmdDiagramacion.CommandType = CommandType.StoredProcedure;
            return cmdDiagramacion.ExecuteReader();
            
        }

        public SqlDataReader getDetallesDeDiagramacionPorSemana(int idprofesional, DateTime fechadesde, DateTime fechahasta)
        {
            SqlCommand cmdDetallesDiagramacion = new SqlCommand("spGetDetallesDeDiagramacionPorSemana",getConexion());
            cmdDetallesDiagramacion.Parameters.Add(new SqlParameter("idprofesional", idprofesional));
            cmdDetallesDiagramacion.Parameters.Add(new SqlParameter("fechadesde", fechadesde));
            cmdDetallesDiagramacion.Parameters.Add(new SqlParameter("fechahasta", fechahasta));
            cmdDetallesDiagramacion.CommandType = CommandType.StoredProcedure;
            return cmdDetallesDiagramacion.ExecuteReader();
        }

        public SqlDataReader getDiasSemana()
        {
            SqlCommand cmdDias = new SqlCommand("spGetDiasSemana", getConexion());
            cmdDias.CommandType = CommandType.StoredProcedure;
            return cmdDias.ExecuteReader();
        }

        public SqlDataReader getControles(int idEnfermedad)
        {
            SqlCommand cmdControles = new SqlCommand("spGetControles", getConexion());
            cmdControles.CommandType = CommandType.StoredProcedure;
            cmdControles.Parameters.Add(new SqlParameter("idEnfermedad", idEnfermedad));
            SqlDataReader drControles = cmdControles.ExecuteReader();
            return drControles;
        }
        public SqlDataReader getMedicamentos()
        {
            SqlCommand cmdMedicamentos = new SqlCommand("spGetMedicamentos", getConexion());
            cmdMedicamentos.CommandType = CommandType.StoredProcedure;
            SqlDataReader drMedicamentos = cmdMedicamentos.ExecuteReader();
            return drMedicamentos;
        }
        public SqlDataReader getEnfermedades()
        {
            SqlCommand cmdEnfermedades = new SqlCommand("spGetEnfermedades", getConexion());
            cmdEnfermedades.CommandType = CommandType.StoredProcedure;
            SqlDataReader drEnfermedades = cmdEnfermedades.ExecuteReader();
            return drEnfermedades;
        }

        public bool registrarAtencion(List<Practica> practicas, Diagnostico diag, Prescripcion presc, DateTime fecha, Turno turno)
        {
            SqlTransaction trans;
            SqlConnection cn = getConexion();
            trans = cn.BeginTransaction();
            try
            {

                //Registrar Prescripcion
                SqlCommand cmd = new SqlCommand("spSetPrescripcionMedica", cn, trans);
                cmd.CommandType = CommandType.StoredProcedure;
                DateTime fechaPresc = DateTime.Now;

                SqlParameter pidPrescripcion = cmd.Parameters.Add("@idPrescripcion", SqlDbType.Int);
                SqlParameter pFechaPrescripcion = cmd.Parameters.AddWithValue("@fechaPresc", fechaPresc);

                pidPrescripcion.Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();
                int idp = Convert.ToInt32(pidPrescripcion.Value.ToString());
                cmd.Parameters.Clear();

                //Registrar Atencion

                cmd = new SqlCommand("spSetAtencion", cn, trans);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter pid = cmd.Parameters.Add("@idatencion", SqlDbType.Int);
                pid.Direction = ParameterDirection.Output;
                SqlParameter idturno = cmd.Parameters.AddWithValue("@idturno", turno.IdTurno);
                SqlParameter fechaAtencion = cmd.Parameters.AddWithValue("@fechaAtencion", fecha);
                SqlParameter idPrescripcion = cmd.Parameters.AddWithValue("@idPrescripcion", idp);

                cmd.ExecuteNonQuery();
                int id = Convert.ToInt32(pid.Value.ToString());
                cmd.Parameters.Clear();




                //Registrar DetallePrescripcion
                cmd = new SqlCommand("spSetDetallePrescripcion", cn, trans);
                cmd.CommandType = CommandType.StoredProcedure;


                SqlParameter pDetallePrescripcionid = cmd.Parameters.Add("@idDetallePrescripcion", SqlDbType.Int);
                pDetallePrescripcionid.Direction = ParameterDirection.Output;

                SqlParameter pDPidPrescripcion = cmd.Parameters.AddWithValue("@idPrescripcion", id);

                foreach (Medicamento medic in presc.Listamedicamentos)
                {
                    SqlParameter pidMedicamento = cmd.Parameters.AddWithValue("@idMedicamento", medic.IdMedicamento);
                    SqlParameter phoras = cmd.Parameters.AddWithValue("@horas", presc.Horas);
                    SqlParameter pdias = cmd.Parameters.AddWithValue("@dias", presc.Dias);
                    SqlParameter pcantMedicamentos = cmd.Parameters.AddWithValue("@cantMedicamentos", presc.CantidadMedicamentos);

                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                }


                //Registrar DetalleAtencion

                cmd = new SqlCommand("spSetDetalleAtencion", cn, trans);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter pidDetalleAtencion = cmd.Parameters.Add("@iddetalleatencion", SqlDbType.Int);
                pidDetalleAtencion.Direction = ParameterDirection.Output;
                SqlParameter idPracticas = cmd.Parameters.AddWithValue("@idPracticas", turno.IdTurno);
                SqlParameter idatencion = cmd.Parameters.AddWithValue("@idatencion", id);


                foreach (Object obj in diag.ListEnfermedades)
                {

                    if (obj is Entidades.Miopia)
                    {

                        SqlParameter idEnfermedadMiopia = cmd.Parameters.AddWithValue("@idEnfermedad", ((Miopia)obj).IdEnfermedad);
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                    }

                    else if (obj is Atigmatismo)
                    {
                        SqlParameter idEnfermedadAtigmatismo = cmd.Parameters.AddWithValue("@idEnfermedad", ((Entidades.Atigmatismo)obj).IdEnfermedad);
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                    }
                }


                trans.Commit();
                cn.Close();
                return true;

            }
            catch (SqlException ex)
            {
                trans.Rollback();
                cn.Close();
                return false;

            }
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

        public SqlDataReader getPacientesPorTurnos(DateTime date, int idProfesional)
        {
            SqlCommand cmdPacientesPorTurnos = new SqlCommand("spGetPacientesPorTurno", getConexion());
            cmdPacientesPorTurnos.CommandType = CommandType.StoredProcedure;
            cmdPacientesPorTurnos.Parameters.Add(new SqlParameter("fechaturno", date));
            cmdPacientesPorTurnos.Parameters.Add(new SqlParameter("idprofesional", idProfesional));
            SqlDataReader drPacientesPorTurnos = cmdPacientesPorTurnos.ExecuteReader();
            return drPacientesPorTurnos;
        }                
    }
}



