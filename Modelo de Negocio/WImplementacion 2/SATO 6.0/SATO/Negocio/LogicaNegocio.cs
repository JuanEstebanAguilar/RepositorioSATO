using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Datos;
using Entidades;

namespace Negocio
{
    public class LogicaNegocio
    {
        public List<Provincia> obtenerProvincias()
        {
            EnlaceDatos enlaceDatos = new EnlaceDatos();
            SqlDataReader drProvincias= enlaceDatos.getProvincias();

            List<Provincia> lsProvincias = new List<Provincia>();
            while (drProvincias.Read())
            {
                lsProvincias.Add(new Provincia(Convert.ToInt32(drProvincias[0].ToString()), drProvincias.GetString(1)));
            }
            return lsProvincias;
        }
        
        public List<Departamento> obtenerDepartamentosPorProvincia(int idProvincia)
        {
            EnlaceDatos enlaceDatos = new EnlaceDatos();
            SqlDataReader drDepartamentos = enlaceDatos.getDepartamentosPorProvincia(idProvincia);

            List<Departamento> lsDepartamentos = new List<Departamento>();
            while (drDepartamentos.Read())
            {
                lsDepartamentos.Add(new Departamento(Convert.ToInt32(drDepartamentos[0].ToString()), drDepartamentos.GetString(1)));
            }
            return lsDepartamentos;
        }

        public List<Localidad> obtenerLocalidadesPorDepartamento(int idDepartamento)
        {
            EnlaceDatos enlaceDatos = new EnlaceDatos();
            SqlDataReader drLocalidades = enlaceDatos.getLocalidadesPorDepartamento(idDepartamento);

            List<Localidad> lsLocalidades = new List<Localidad>();
            while (drLocalidades.Read())
            {
                lsLocalidades.Add(new Localidad(Convert.ToInt32(drLocalidades[0].ToString()), drLocalidades.GetString(1)));
            }
            return lsLocalidades;
        }

        public List<Barrio> obtenerBarriosPorLocalidad(int idLocalidad)
        {
            EnlaceDatos enlaceDatos = new EnlaceDatos();
            SqlDataReader drBarrios = enlaceDatos.getBarriosPorLocalidad(idLocalidad);

            List<Barrio> lsBarrios = new List<Barrio>();
            while (drBarrios.Read())
            { 
                lsBarrios.Add(new Barrio(Convert.ToInt32(drBarrios[0].ToString()),drBarrios.GetString(1)));
            }
            return lsBarrios;
        }

        public List<TipoDocumento> obtenerTiposDocumento()
        {
            EnlaceDatos enlaceDatos = new EnlaceDatos();
            SqlDataReader drTiposDocumento = enlaceDatos.getTiposDocumento();

            List<TipoDocumento> lsTiposDocumento = new List<TipoDocumento>();
            while (drTiposDocumento.Read())
            { 
                lsTiposDocumento.Add(new TipoDocumento(Convert.ToInt32(drTiposDocumento[0].ToString()),drTiposDocumento.GetString(1)));
            }
            return lsTiposDocumento;
        }

        public List<TipoTelefono> obtenerTiposTelefono()
        {
            EnlaceDatos enlaceDatos = new EnlaceDatos();
            SqlDataReader drTiposTelefono = enlaceDatos.getTiposTelefono();

            List<TipoTelefono> lsTiposTelefono = new List<TipoTelefono>();
            while (drTiposTelefono.Read())
            {
                lsTiposTelefono.Add(new TipoTelefono(Convert.ToInt32(drTiposTelefono[0].ToString()), drTiposTelefono.GetString(1)));
            }
            return lsTiposTelefono;
        }

        
        public List<Especialidad> obtenerEspecialidades()
        {
            EnlaceDatos enlaceDatos = new EnlaceDatos();
            SqlDataReader drEspecialidades = enlaceDatos.getEspecialidades();

            List<Especialidad> lsEspecialidades = new List<Especialidad>();
            while (drEspecialidades.Read())
            {
                lsEspecialidades.Add(new Especialidad(Convert.ToInt32(drEspecialidades[0].ToString()), drEspecialidades.GetString(1)));
            }
            return lsEspecialidades;
        }

        public List<Especialidad> cargarEspecialidadesPorProfesional(List<Especialidad> lista, Especialidad esp, String action)
        {
            if (action != null && action.Equals("add"))
            {
                foreach (Especialidad e in lista)
                {
                    if (e.Idespecialidad.Equals(esp.Idespecialidad))
                    {
                        return lista;
                    }
                }
                lista.Add(esp);
            }
            else if (action != null && action.Equals("remove"))
            {
                foreach (Especialidad e in lista)
                {
                    if (e.Idespecialidad.Equals(esp.Idespecialidad))
                    {
                        lista.RemoveAt(lista.IndexOf(e));
                        return lista;
                    }
                }
            }

            return lista;
        }   


        public List<CoberturaMedica> obtenerCoberturasMedicas()
        {
            EnlaceDatos enlaceDatos = new EnlaceDatos();
            SqlDataReader drCoberturasMedica = enlaceDatos.getCoberturasMedica();

            List<CoberturaMedica> lsCoberturasMedica = new List<CoberturaMedica>();
            while (drCoberturasMedica.Read())
            {
                lsCoberturasMedica.Add(new CoberturaMedica(Convert.ToInt32(drCoberturasMedica[0].ToString()), drCoberturasMedica.GetString(1), drCoberturasMedica.GetString(2)));
            }
            return lsCoberturasMedica;
        }

        public List<Profesional> obtenerProfesionales()
        {
            EnlaceDatos enlaceDatos = new EnlaceDatos();
            SqlDataReader drProfesionales = enlaceDatos.getProfesionales();

            List<Profesional> lsProfesionales = new List<Profesional>();
            while (drProfesionales.Read())
            {
                
            }
            return lsProfesionales;
        }

        public List<Sexo> obtenerSexos()
        {
            EnlaceDatos enlaceDatos = new EnlaceDatos();
            SqlDataReader drSexos = enlaceDatos.getSexos();

            List<Sexo> lsSexos = new List<Sexo>();
            while (drSexos.Read())
            { 
                lsSexos.Add(new Sexo(Convert.ToInt32(drSexos[0].ToString()),drSexos.GetString(1)));
            }
            return lsSexos;
        }

        public List<TipoDocumento> obtenerTodosTiposDocumento()
        {
            EnlaceDatos enlaceDatos = new EnlaceDatos();
            SqlDataReader drTiposDocumento = enlaceDatos.getAllTiposDocumento();

            List<TipoDocumento> lsTiposDocumento = new List<TipoDocumento>();
            while (drTiposDocumento.Read())
            { 
                lsTiposDocumento.Add(new TipoDocumento(Convert.ToInt32(drTiposDocumento[0].ToString()),drTiposDocumento.GetString(1),drTiposDocumento.GetString(2),drTiposDocumento.GetString(3)));
            }
            return lsTiposDocumento;
        }

        public List<Provincia> obtenerTodasProvincias()
        {
            EnlaceDatos enlaceDatos = new EnlaceDatos();
            SqlDataReader drProvincias = enlaceDatos.getAllProvincias();

            List<Provincia> lsProvincias = new List<Provincia>();
            while (drProvincias.Read())
            {
                lsProvincias.Add(new Provincia(Convert.ToInt32(drProvincias[0].ToString()), drProvincias.GetString(1), drProvincias.GetString(2)));
            }
            return lsProvincias;
        }

        public List<Departamento> obtenerTodosDepartamentos(int idProvincia)
        {
            EnlaceDatos enlaceDatos = new EnlaceDatos();
            SqlDataReader drDepartamentos = enlaceDatos.getAllDepartamentos(idProvincia);

            List<Departamento> lsDepartamentos = new List<Departamento>();
            while (drDepartamentos.Read())
            {
                lsDepartamentos.Add(new Departamento(Convert.ToInt32(drDepartamentos[0].ToString()), drDepartamentos.GetString(1), drDepartamentos.GetString(2)));
            }
            return lsDepartamentos;
        }

        public List<Localidad> obtenerTodasLocalidades(int idDepartamento)
        {
            EnlaceDatos enlaceDatos = new EnlaceDatos();
            SqlDataReader drLocalidades = enlaceDatos.getAllLocalidades(idDepartamento);

            List<Localidad> lsLocalidades = new List<Localidad>();
            while (drLocalidades.Read())
            {
                lsLocalidades.Add(new Localidad(Convert.ToInt32(drLocalidades[0].ToString()), drLocalidades.GetString(1), drLocalidades.GetString(2)));
            }
            return lsLocalidades;
        }
        public List<Cuenta> obtenerCuentasPaciente()
        {
            EnlaceDatos enlaceDatos = new EnlaceDatos();
            SqlDataReader drCuentas = enlaceDatos.getCuentaPaciente();

            List<Cuenta> lsCuentas = new List<Cuenta>();
            while (drCuentas.Read())
            {
                lsCuentas.Add(new Cuenta(Convert.ToInt32(drCuentas[0].ToString()), drCuentas.GetString(1), drCuentas.GetString(2)));
            }
            return lsCuentas;
        }

        public List<Cuenta> obtenerCuentas()
        {
            EnlaceDatos enlaceDatos = new EnlaceDatos();
            SqlDataReader drCuentas= enlaceDatos.getCuentas();

            List<Cuenta> lsCuentas = new List<Cuenta>();
            while (drCuentas.Read())
            {
                lsCuentas.Add(new Cuenta(Convert.ToInt32(drCuentas[0].ToString()), drCuentas.GetString(1), drCuentas.GetString(2)));
            }
            return lsCuentas;
        }

        public List<EstadoUsuario> obtenerEstadosUsuarios()
        {
            EnlaceDatos enlaceDatos = new EnlaceDatos();
            SqlDataReader drEstados = enlaceDatos.getEstadosUsuarios();

            List<EstadoUsuario> lsEstados = new List<EstadoUsuario>();
            while (drEstados.Read())
            {
                lsEstados.Add(new EstadoUsuario(Convert.ToInt32(drEstados[0].ToString()), drEstados.GetString(1), drEstados.GetString(2)));
            }
            return lsEstados;
        }

        public List<Turno> obtenerTurnosPorFecha(DateTime fecha)
        {
            EnlaceDatos enlaceDatos = new EnlaceDatos();
            SqlDataReader drTurnos = enlaceDatos.getTurnosPorFecha(fecha);

            List<Turno> lsTurnos = new List<Turno>();
            while(drTurnos.Read())
            { 
                //lsTurnos.Add(new Turno(Convert.ToDateTime(drTurnos.GetDateTime(0)),Convert.ToDateTime(drTurnos.GetDateTime(1)),Convert.ToDateTime(drTurnos.GetDateTime(2))));
            }
            return lsTurnos;
        }

        public Especialidad obtenerEspecialidadxID(int idEspecialidad)
        {
            EnlaceDatos enlaceDatos = new EnlaceDatos();

            return enlaceDatos.getEspecialidadxID(idEspecialidad);

        }

        public Boolean tomarPaciente(Paciente paciente)
        {
            EnlaceDatos enlaceDatos = new EnlaceDatos();
            SqlDataReader drPacientes = enlaceDatos.getPacientesParaValidar();

            List<Entidades.Paciente> listaPacientes = new List<Entidades.Paciente>();
            if (drPacientes.HasRows)
            {
                while (drPacientes.Read())
                {
                    TipoDocumento tipd = new TipoDocumento();
                    Paciente p = new Paciente();
                    p.TipoDocumento = tipd;
                    p.TipoDocumento.IdTipoDocumento = Convert.ToInt32(drPacientes[0].ToString());
                    p.NumeroDocumento = drPacientes[1].ToString();
                    p.Numero = drPacientes[2].ToString();

                    listaPacientes.Add(p);
                }
                for (int i = 0; i < listaPacientes.Count; i++)
                {
                    if (listaPacientes[i].Numero == paciente.Numero || (listaPacientes[i].TipoDocumento.IdTipoDocumento == paciente.TipoDocumento.IdTipoDocumento && listaPacientes[i].NumeroDocumento == paciente.NumeroDocumento))
                    {
                        return false;
                    }
                }
            }
            
            String nombre = paciente.Nombre;
            String apellido = paciente.Apellido;
            DateTime fechaAlta = paciente.FechaAlta;
            String numeroDocumento = paciente.NumeroDocumento;
            int idTipoDocumento = paciente.TipoDocumento.IdTipoDocumento;
            DateTime fechaNacimiento = paciente.FechaNacimiento;
            String comentario=paciente.Comentario;
            int idSexo=paciente.Sexo.IdSexo;
            
            int idPersona=enlaceDatos.setPersona(nombre, apellido, fechaAlta, numeroDocumento, idTipoDocumento,
                                    fechaNacimiento, comentario, idSexo);

            String numPaciente = paciente.Numero;
            int idPaciente = enlaceDatos.setPaciente(numPaciente, idPersona);

            String calle=paciente.Domicilio.Calle;
            int idBarrio=paciente.Domicilio.Barrio.IdBarrio;
            String depto=paciente.Domicilio.Departamento;
            String numCalle=paciente.Domicilio.Numero;
            String piso=paciente.Domicilio.Piso;
            String torre=paciente.Domicilio.Torre;

            enlaceDatos.setDomicilio(calle, numCalle, depto, piso, torre, idBarrio, idPersona);

            if (paciente.Telefonos.Count>0)
            {
                String tel;
                int idTip;
                foreach (Telefono telefono in paciente.Telefonos)
                { 
                    tel=telefono.Numero;
                    idTip=telefono.TipoTelefono.IdTipoTelefono;
                    enlaceDatos.setTelefono(tel, idTip, idPersona);
                }
            }

            if (paciente.Correos.Count > 0)
            {
                String cor;
                foreach (Correo correo in paciente.Correos)
                {
                    cor = correo.Direccion;
                    enlaceDatos.setCorreo(cor, idPersona);
                }
            }

            if (paciente.Afiliaciones.Count > 0)
            {
                int idCob;
                String numAfi;
                foreach (Afiliacion afiliacion in paciente.Afiliaciones)
                { 
                    idCob=afiliacion.Cobertura.IdCoberturaMedica;
                    numAfi=afiliacion.NumeroAfiliado;
                    enlaceDatos.setAfiliacion(idPaciente, idCob, numAfi);
                }
            }

            string usuarioPac = paciente.Usuario.Nombre.ToString().Trim();
            string contraseñaUsuario = paciente.Usuario.Contrasenia.ToString().Trim();
            int idCuentaUsuario = paciente.Usuario.Cuenta.IdCuenta;
            string comentarioUsuario = paciente.Usuario.Comentario.ToString().Trim();
            int idEstadoUsuario = paciente.Usuario.Estado.IdEstado;
            enlaceDatos.setUsuario(usuarioPac, contraseñaUsuario, idCuentaUsuario, comentarioUsuario, idPersona, idEstadoUsuario);
            return true;

        }

        public List<Paciente> obtenerPacientesPorBusqueda(String parametro)
        {
            EnlaceDatos enlaceDatos = new EnlaceDatos();
            SqlDataReader drPacientes = enlaceDatos.getPacientePorBusqueda(parametro);

            if(drPacientes.HasRows)
            {
                List<Paciente> lsPacientes = new List<Paciente>();
                
                //TipoDocumento
                String sigla;TipoDocumento tipoDoc;

                //Barrio
                String nombreBarrio;Barrio barrio;
                
                //Localidad
                String nombreLocalidad;Localidad localidad;

                //Departamento
                String nombreDepartamento;Departamento departamento;

                //Provincia
                String nombreProvincia;Provincia provincia;

                //Domicilio
                String calle;String numCalle;String piso;String depto;String torre;Domicilio domicilio;

                //Paciente
                String numero;String nombre;String apellido;String numDocumento;
                int idPersona;
                int idPaciente;
                
                while (drPacientes.Read())
                { 
                    sigla=drPacientes.GetString(3);
                    tipoDoc=new TipoDocumento(sigla);

                    nombreBarrio=drPacientes.GetString(10);
                    barrio=new Barrio(nombreBarrio);

                    nombreLocalidad=drPacientes.GetString(11);
                    localidad=new Localidad(nombreLocalidad);
                    barrio.Localidad = localidad;

                    nombreDepartamento=drPacientes.GetString(12);
                    departamento=new Departamento(nombreDepartamento);
                    localidad.Departamento = departamento;

                    nombreProvincia=drPacientes.GetString(13);
                    provincia=new Provincia(nombreProvincia);
                    departamento.Provincia = provincia;

                    idPersona = Convert.ToInt32(drPacientes[14].ToString());
                    idPaciente = Convert.ToInt32(drPacientes[15].ToString());
                    calle=drPacientes.GetString(5);
                    numCalle=drPacientes.GetString(6);
                    depto=drPacientes.GetString(7);
                    piso=drPacientes.GetString(8);
                    torre=drPacientes.GetString(9);
                    domicilio=new Domicilio(calle,numCalle,depto,piso,torre,barrio);

                    numero=drPacientes.GetString(0);
                    apellido=drPacientes.GetString(1);
                    nombre=drPacientes.GetString(2);
                    numDocumento=drPacientes.GetString(4);

                    Paciente paciente = new Paciente(nombre, apellido, numDocumento, tipoDoc, domicilio, numero, idPersona, idPaciente);
                    lsPacientes.Add(paciente);
                }
                return lsPacientes;
            }
            return null;
        }

        public Boolean tomarEmpleado(Empleado empleado)
        {

            
            EnlaceDatos enlaceDatos = new EnlaceDatos();
            SqlDataReader drEmpleados= enlaceDatos.getEmpleadosParaValidar();
            
            List<Entidades.Empleado> listaEmpleados= new List<Entidades.Empleado>();
            if(drEmpleados.HasRows)
            {
                while(drEmpleados.Read())
                {
                    TipoDocumento tipd = new TipoDocumento();
                    Empleado e = new Empleado();
                    e.TipoDocumento = tipd;
                    e.TipoDocumento.IdTipoDocumento=Convert.ToInt32(drEmpleados[0].ToString());
                    e.NumeroDocumento=drEmpleados[1].ToString();
                    e.Legajo=drEmpleados[2].ToString();

                    listaEmpleados.Add(e);
                }
                for (int i = 0; i < listaEmpleados.Count; i++)
                {
                    if (listaEmpleados[i].Legajo == empleado.Legajo || (listaEmpleados[i].TipoDocumento.IdTipoDocumento == empleado.TipoDocumento.IdTipoDocumento && listaEmpleados[i].NumeroDocumento == empleado.NumeroDocumento))
                    {
                        return false;
                    }
                }
            }

            String nombre = empleado.Nombre;
            String apellido = empleado.Apellido;
            DateTime fechaAlta = empleado.FechaAlta;
            String numeroDocumento = empleado.NumeroDocumento;
            int idTipoDocumento = empleado.TipoDocumento.IdTipoDocumento;
            DateTime fechaNacimiento = empleado.FechaNacimiento;
            String comentario = empleado.Comentario;
            int idSexo = empleado.Sexo.IdSexo;

            int idPersona = enlaceDatos.setPersona(nombre, apellido, fechaAlta, numeroDocumento, idTipoDocumento,
                                    fechaNacimiento, comentario, idSexo);

            String numEmpleado = empleado.Legajo;
            int idEmpleado = enlaceDatos.setEmpleado(numEmpleado, idPersona);

            String calle = empleado.Domicilio.Calle;
            int idBarrio = empleado.Domicilio.Barrio.IdBarrio;
            String depto = empleado.Domicilio.Departamento;
            String numCalle = empleado.Domicilio.Numero;
            String piso = empleado.Domicilio.Piso;
            String torre = empleado.Domicilio.Torre;

            enlaceDatos.setDomicilio(calle, numCalle, depto, piso, torre, idBarrio, idPersona);

            if (empleado.Telefonos.Count > 0)
            {
                String tel;
                
                foreach (Telefono telefono in empleado.Telefonos)
                {
                    tel = telefono.Numero;
                    TipoTelefono tipTel = new TipoTelefono();
                    tipTel.IdTipoTelefono = telefono.TipoTelefono.IdTipoTelefono;
                    //tipTel.Nombre = telefono.TipoTelefono.Nombre;
                    telefono.TipoTelefono = tipTel;
                    enlaceDatos.setTelefono(tel, telefono.TipoTelefono.IdTipoTelefono, idPersona);
                }
            }

            if (empleado.Correos.Count > 0)
            {
                String cor;
                foreach (Correo correo in empleado.Correos)
                {
                    cor = correo.Direccion;
                    enlaceDatos.setCorreo(cor, idPersona);
                }
            }
            string nombreUsuarioEmp = empleado.Usuario.Nombre.ToString().Trim();
            string contraseniaUsuarioEmp = empleado.Usuario.Contrasenia.ToString().Trim();
            int idCuentaUsuarioEmp = empleado.Usuario.Cuenta.IdCuenta;
            string comentarioUsuarioEmp = empleado.Usuario.Comentario.ToString().Trim();
            int idEstadoUsuarioEmp = empleado.Usuario.Estado.IdEstado;
            enlaceDatos.setUsuario(nombreUsuarioEmp, contraseniaUsuarioEmp, idCuentaUsuarioEmp, comentarioUsuarioEmp, idPersona, idEstadoUsuarioEmp);
            return true;
        }

        public List<Empleado> obtenerEmpleadosPorBusqueda(string parametro)
        {
            EnlaceDatos enlaceDatos = new EnlaceDatos();
            SqlDataReader drEmpleado = enlaceDatos.getEmpleadoPorBusqueda(parametro);

            if (drEmpleado.HasRows)
            {
                List<Empleado> lstEmpleado = new List<Empleado>();

                String siglaEmp; TipoDocumento tipoDocEmp;

                //Barrio
                String nombreBarrioEmp; Barrio barrioEmp;

                //Localidad
                String nombreLocalidadEmp; Localidad localidadEmp;

                //Departamento
                String nombreDepartamentoEmp; Departamento departamentoEmp;

                //Provincia
                String nombreProvinciaEmp; Provincia provinciaEmp;

                //Domicilio
                String calleEmp; String numCalleEmp; String pisoEmp; String deptoEmp; String torreEmp; Domicilio domicilioEmp;

                //Empleado
                String legajoEmp; String nombreEmp; String apellidoEmp; String numDocumentoEmp;
                int idPersona;
                int idEmpleado;
                while (drEmpleado.Read())
                {
                    siglaEmp = drEmpleado.GetString(3);
                    tipoDocEmp = new TipoDocumento(siglaEmp);

                    nombreBarrioEmp = drEmpleado.GetString(10);
                    barrioEmp = new Barrio(nombreBarrioEmp);

                    nombreLocalidadEmp = drEmpleado.GetString(11);
                    localidadEmp = new Localidad(nombreLocalidadEmp);
                    barrioEmp.Localidad = localidadEmp;

                    nombreDepartamentoEmp = drEmpleado.GetString(12);
                    departamentoEmp = new Departamento(nombreDepartamentoEmp);
                    localidadEmp.Departamento = departamentoEmp;

                    nombreProvinciaEmp = drEmpleado.GetString(13);
                    provinciaEmp = new Provincia(nombreProvinciaEmp);
                    departamentoEmp.Provincia = provinciaEmp;

                    calleEmp = drEmpleado.GetString(5);
                    numCalleEmp = drEmpleado.GetString(6);
                    deptoEmp = drEmpleado.GetString(7);
                    pisoEmp = drEmpleado.GetString(8);
                    torreEmp = drEmpleado.GetString(9);
                    domicilioEmp = new Domicilio(calleEmp, numCalleEmp, deptoEmp, pisoEmp, torreEmp, barrioEmp);

                    legajoEmp = drEmpleado.GetString(0);
                    apellidoEmp = drEmpleado.GetString(1);
                    nombreEmp = drEmpleado.GetString(2);
                    numDocumentoEmp = drEmpleado.GetString(4);
                    idPersona = Convert.ToInt32(drEmpleado[14].ToString());
                    idEmpleado = Convert.ToInt32(drEmpleado[15].ToString());

                    Empleado empleado = new Empleado(nombreEmp, apellidoEmp, numDocumentoEmp, tipoDocEmp, domicilioEmp, legajoEmp, idPersona, idEmpleado);
                    lstEmpleado.Add(empleado);
                }
                return lstEmpleado;
            }
            return null;

        }

        public String tomarModificacionEmpleado(Empleado empleado, String legajoViejo, int tipoDniViejo, String nroDniViejo)
        {
            String mensaje = "";
            EnlaceDatos enlaceDatos = new EnlaceDatos();
            SqlDataReader drEmpleados = enlaceDatos.getEmpleadosParaValidar();
            List<Entidades.Empleado> listaEmpleados = new List<Entidades.Empleado>();
            if (empleado.Legajo == legajoViejo)
            {
                if (empleado.TipoDocumento.IdTipoDocumento == tipoDniViejo && empleado.NumeroDocumento == nroDniViejo)
                {

                    if (enlaceDatos.modificarEmpleado(empleado))
                    {
                        return mensaje = "Se modifico";
                    }
                    else
                    {
                        return mensaje="No se pudo modificar";
                    }
                }
                else
                {

                    if (drEmpleados.HasRows)
                    {
                        while (drEmpleados.Read())
                        {
                            TipoDocumento tipd = new TipoDocumento();
                            Empleado e = new Empleado();
                            e.TipoDocumento = tipd;
                            e.TipoDocumento.IdTipoDocumento = Convert.ToInt32(drEmpleados[0].ToString());
                            e.NumeroDocumento = drEmpleados[1].ToString();
                            e.Legajo = drEmpleados[2].ToString();

                            listaEmpleados.Add(e);
                        }
                        for (int i = 0; i < listaEmpleados.Count; i++)
                        {
                            if (listaEmpleados[i].TipoDocumento.IdTipoDocumento == empleado.TipoDocumento.IdTipoDocumento && listaEmpleados[i].NumeroDocumento == empleado.NumeroDocumento)
                            {
                                return mensaje="error de tipo y nro de DNI";
                            }
                        }
                    }
                    if (enlaceDatos.modificarEmpleado(empleado))
                    {
                        return mensaje = "Se modifico";
                    }
                    else
                    {
                        return mensaje = "No se pudo modificar";
                    }
                }
            }
            else
            {
                if (empleado.TipoDocumento.IdTipoDocumento == tipoDniViejo && empleado.NumeroDocumento == nroDniViejo)
                {

                    if (drEmpleados.HasRows)
                    {
                        while (drEmpleados.Read())
                        {
                            TipoDocumento tipd = new TipoDocumento();
                            Empleado e = new Empleado();
                            e.TipoDocumento = tipd;
                            e.TipoDocumento.IdTipoDocumento = Convert.ToInt32(drEmpleados[0].ToString());
                            e.NumeroDocumento = drEmpleados[1].ToString();
                            e.Legajo = drEmpleados[2].ToString();

                            listaEmpleados.Add(e);
                        }
                        for (int i = 0; i < listaEmpleados.Count; i++)
                        {
                            if (listaEmpleados[i].Legajo == empleado.Legajo)
                            {
                                return mensaje = "error de Legajo";
                            }
                        }
                    }
                    if (enlaceDatos.modificarEmpleado(empleado))
                    {
                        return mensaje = "Se modifico";
                    }
                    else
                    {
                        return mensaje = "No se pudo modificar";
                    }
                }
                else
                {

                    if (drEmpleados.HasRows)
                    {
                        while (drEmpleados.Read())
                        {
                            TipoDocumento tipd = new TipoDocumento();
                            Empleado e = new Empleado();
                            e.TipoDocumento = tipd;
                            e.TipoDocumento.IdTipoDocumento = Convert.ToInt32(drEmpleados[0].ToString());
                            e.NumeroDocumento = drEmpleados[1].ToString();
                            e.Legajo = drEmpleados[2].ToString();

                            listaEmpleados.Add(e);
                        }
                        for (int i = 0; i < listaEmpleados.Count; i++)
                        {
                            if (listaEmpleados[i].Legajo == empleado.Legajo) 
                            {
                                return mensaje = "error de Legajo";
                            }
                            else
                            {
                                if (listaEmpleados[i].TipoDocumento.IdTipoDocumento == empleado.TipoDocumento.IdTipoDocumento && listaEmpleados[i].NumeroDocumento == empleado.NumeroDocumento)
                                {
                                    return mensaje = "error de tipo y nro de DNI";
                                }
                            }
                        }
                    }
                    if (enlaceDatos.modificarEmpleado(empleado))
                    {
                        return mensaje = "Se modifico";
                    }
                    else
                    {
                        return mensaje = "No se pudo modificar";
                    }
                }

            }



        }
        public String tomarModificacionPaciente(Paciente paciente, String numeroViejo, int tipoDniViejo, String nroDniViejo)
        {
            String mensaje = "";
            EnlaceDatos enlaceDatos = new EnlaceDatos();
            SqlDataReader drPacientes = enlaceDatos.getPacientesParaValidar();
            DataTable dtAfiliacion = new DataTable();
            
            List<Paciente> listaPacientes = new List<Paciente>();

            if (paciente.Numero == numeroViejo)
            {
                if (paciente.TipoDocumento.IdTipoDocumento == tipoDniViejo && paciente.NumeroDocumento == nroDniViejo)
                {
                    if (paciente.Afiliaciones.Count > 0)
                    {
                        DataColumn[] columnas = new DataColumn[] {new DataColumn(),new DataColumn()};
                       
                        dtAfiliacion.Columns.AddRange(columnas);
                        foreach (Afiliacion afiliacion in paciente.Afiliaciones)
                        {
                             
                            DataRow dr = dtAfiliacion.NewRow();
                            dr[0] = afiliacion.Cobertura.IdCoberturaMedica;
                            dr[1] = afiliacion.NumeroAfiliado;
                            dtAfiliacion.Rows.Add(dr);
                            
                            
                        }
                    }
                    if (enlaceDatos.modificarPaciente(paciente, dtAfiliacion))
                    {
                        return mensaje = "Se modifico";
                    }
                    else
                    {
                        return mensaje = "No se pudo modificar";
                    }
                }
                else
                {

                    if (drPacientes.HasRows)
                    {
                        while (drPacientes.Read())
                        {
                            TipoDocumento tipd = new TipoDocumento();
                            Paciente pa = new Paciente();
                            pa.TipoDocumento = tipd;
                            pa.TipoDocumento.IdTipoDocumento = Convert.ToInt32(drPacientes[0].ToString());
                            pa.NumeroDocumento = drPacientes[1].ToString();
                            pa.Numero = drPacientes[2].ToString();

                            listaPacientes.Add(pa);
                        }
                        for (int i = 0; i < listaPacientes.Count; i++)
                        {
                            if (listaPacientes[i].TipoDocumento.IdTipoDocumento == paciente.TipoDocumento.IdTipoDocumento && listaPacientes[i].NumeroDocumento == paciente.NumeroDocumento)
                            {
                                return mensaje = "error de tipo y nro de DNI";
                            }
                        }
                    }
                    if (paciente.Afiliaciones.Count > 0)
                    {
                        DataColumn[] columnas = new DataColumn[] { new DataColumn(), new DataColumn() };

                        dtAfiliacion.Columns.AddRange(columnas);
                        foreach (Afiliacion afiliacion in paciente.Afiliaciones)
                        {

                            DataRow dr = dtAfiliacion.NewRow();
                            dr[0] = afiliacion.Cobertura.IdCoberturaMedica;
                            dr[1] = afiliacion.NumeroAfiliado;

                        }
                    }
                    if (enlaceDatos.modificarPaciente(paciente, dtAfiliacion))
                    {
                        return mensaje = "Se modifico";
                    }
                    else
                    {
                        return mensaje = "No se pudo modificar";
                    }
                }
            }
            else
            {
                if (paciente.TipoDocumento.IdTipoDocumento == tipoDniViejo && paciente.NumeroDocumento == nroDniViejo)
                {

                    if (drPacientes.HasRows)
                    {
                        while (drPacientes.Read())
                        {
                            TipoDocumento tipd = new TipoDocumento();
                            Paciente pa = new Paciente();
                            pa.TipoDocumento = tipd;
                            pa.TipoDocumento.IdTipoDocumento = Convert.ToInt32(drPacientes[0].ToString());
                            pa.NumeroDocumento = drPacientes[1].ToString();
                            pa.Numero = drPacientes[2].ToString();

                            listaPacientes.Add(pa);
                        }
                        for (int i = 0; i < listaPacientes.Count; i++)
                        {
                            if (listaPacientes[i].Numero == paciente.Numero)
                            {
                                return mensaje = "error de Numero de Paciente";
                            }
                        }
                    }
                    if (paciente.Afiliaciones.Count > 0)
                    {
                        DataColumn[] columnas = new DataColumn[] { new DataColumn(), new DataColumn() };

                        dtAfiliacion.Columns.AddRange(columnas);
                        foreach (Afiliacion afiliacion in paciente.Afiliaciones)
                        {

                            DataRow dr = dtAfiliacion.NewRow();
                            dr[0] = afiliacion.Cobertura.IdCoberturaMedica;
                            dr[1] = afiliacion.NumeroAfiliado;

                        }
                    }
                    if (enlaceDatos.modificarPaciente(paciente, dtAfiliacion))
                    {
                        return mensaje = "Se modifico";
                    }
                    else
                    {
                        return mensaje = "No se pudo modificar";
                    }
                }
                else
                {

                    if (drPacientes.HasRows)
                    {
                        while (drPacientes.Read())
                        {
                            TipoDocumento tipd = new TipoDocumento();
                            Paciente pa = new Paciente();
                            pa.TipoDocumento = tipd;
                            pa.TipoDocumento.IdTipoDocumento = Convert.ToInt32(drPacientes[0].ToString());
                            pa.NumeroDocumento = drPacientes[1].ToString();
                            pa.Numero = drPacientes[2].ToString();

                            listaPacientes.Add(pa);
                        }
                        for (int i = 0; i < listaPacientes.Count; i++)
                        {
                            if (listaPacientes[i].Numero == paciente.Numero)
                            {
                                return mensaje = "error de Numero de Paciente";
                            }
                            else
                            {
                                if (listaPacientes[i].TipoDocumento.IdTipoDocumento == paciente.TipoDocumento.IdTipoDocumento && listaPacientes[i].NumeroDocumento == paciente.NumeroDocumento)
                                {
                                    return mensaje = "error de tipo y nro de DNI";
                                }
                            }
                        }
                    }
                    if (paciente.Afiliaciones.Count > 0)
                    {
                        DataColumn[] columnas = new DataColumn[] { new DataColumn(), new DataColumn() };

                        dtAfiliacion.Columns.AddRange(columnas);
                        foreach (Afiliacion afiliacion in paciente.Afiliaciones)
                        {

                            DataRow dr = dtAfiliacion.NewRow();
                            dr[0] = afiliacion.Cobertura.IdCoberturaMedica;
                            dr[1] = afiliacion.NumeroAfiliado;

                        }
                    }
                    if (enlaceDatos.modificarPaciente(paciente, dtAfiliacion))
                    {
                        return mensaje = "Se modifico";
                    }
                    else
                    {
                        return mensaje = "No se pudo modificar";
                    }
                }

            }



        }
        public String tomarModificacionProfesional(Profesional profesional, String matriculaViejo, int tipoDniViejo, String nroDniViejo, List<Especialidad> esp)
        {
            String mensaje = "";
            EnlaceDatos enlaceDatos = new EnlaceDatos();
            SqlDataReader drProfesional = enlaceDatos.getProfesionalesParaValidar();
            List<Entidades.Empleado> listaProfesionales = new List<Entidades.Empleado>();
            if (profesional.Matricula == matriculaViejo)
            {
                if (profesional.TipoDocumento.IdTipoDocumento == tipoDniViejo && profesional.NumeroDocumento == nroDniViejo)
                {
                    if (enlaceDatos.modificarProfesional(profesional, esp))
                    {
                        return mensaje = "Se modifico";
                    }
                    else
                    {
                        return mensaje = "No se pudo modificar";
                    }
                }
                else
                {

                    if (drProfesional.HasRows)
                    {
                        while (drProfesional.Read())
                        {
                            TipoDocumento tipd = new TipoDocumento();
                            Empleado e = new Empleado();
                            e.TipoDocumento = tipd;
                            e.TipoDocumento.IdTipoDocumento = Convert.ToInt32(drProfesional[0].ToString());
                            e.NumeroDocumento = drProfesional[1].ToString();
                            e.Legajo = drProfesional[2].ToString();

                            listaProfesionales.Add(e);
                        }
                        for (int i = 0; i < listaProfesionales.Count; i++)
                        {
                            if (listaProfesionales[i].TipoDocumento.IdTipoDocumento == profesional.TipoDocumento.IdTipoDocumento && listaProfesionales[i].NumeroDocumento == profesional.NumeroDocumento)
                            {
                                return mensaje = "error de tipo y nro de DNI";
                            }
                        }
                    }
                    if (enlaceDatos.modificarProfesional(profesional, esp))
                    {
                        return mensaje = "Se modifico";
                    }
                    else
                    {
                        return mensaje = "No se pudo modificar";
                    }
                }
            }
            else
            {
                if (profesional.TipoDocumento.IdTipoDocumento == tipoDniViejo && profesional.NumeroDocumento == nroDniViejo)
                {

                    if (drProfesional.HasRows)
                    {
                        while (drProfesional.Read())
                        {
                            TipoDocumento tipd = new TipoDocumento();
                            Empleado e = new Empleado();
                            e.TipoDocumento = tipd;
                            e.TipoDocumento.IdTipoDocumento = Convert.ToInt32(drProfesional[0].ToString());
                            e.NumeroDocumento = drProfesional[1].ToString();
                            e.Legajo = drProfesional[2].ToString();

                            listaProfesionales.Add(e);
                        }
                        for (int i = 0; i < listaProfesionales.Count; i++)
                        {
                            if (listaProfesionales[i].Legajo == profesional.Matricula)
                            {
                                return mensaje = "error de Matricula";
                            }
                        }
                    }
                    if (enlaceDatos.modificarProfesional(profesional, esp))
                    {
                        return mensaje = "Se modifico";
                    }
                    else
                    {
                        return mensaje = "No se pudo modificar";
                    }
                }
                else
                {

                    if (drProfesional.HasRows)
                    {
                        while (drProfesional.Read())
                        {
                            TipoDocumento tipd = new TipoDocumento();
                            Empleado e = new Empleado();
                            e.TipoDocumento = tipd;
                            e.TipoDocumento.IdTipoDocumento = Convert.ToInt32(drProfesional[0].ToString());
                            e.NumeroDocumento = drProfesional[1].ToString();
                            e.Legajo = drProfesional[2].ToString();

                            listaProfesionales.Add(e);
                        }
                        for (int i = 0; i < listaProfesionales.Count; i++)
                        {
                            if (listaProfesionales[i].Legajo == profesional.Matricula)
                            {
                                return mensaje = "error de Matricula";
                            }
                            else
                            {
                                if (listaProfesionales[i].TipoDocumento.IdTipoDocumento == profesional.TipoDocumento.IdTipoDocumento && listaProfesionales[i].NumeroDocumento == profesional.NumeroDocumento)
                                {
                                    return mensaje = "error de tipo y nro de DNI";
                                }
                            }
                        }
                    }
                    if (enlaceDatos.modificarProfesional(profesional, esp))
                    {
                        return mensaje = "Se modifico";
                    }
                    else
                    {
                        return mensaje = "No se pudo modificar";
                    }
                }

            }



        }
        public Empleado obtenerEmpleadoPorLegajo(string leg)
        {
            EnlaceDatos enlace = new EnlaceDatos();
            SqlDataReader drEmpleado = enlace.getEmpleadoPorLegajo(leg);

            if (drEmpleado.HasRows)
            {
                if (drEmpleado.Read())
                {
                    Empleado empleado = new Empleado();
                    empleado.Idpersona = Convert.ToInt32(drEmpleado[17].ToString());
                    empleado.Apellido = drEmpleado.GetString(0);
                    empleado.Nombre = drEmpleado.GetString(1);
                    //empleado.Foto = drEmpleado.GetString(13);
                    empleado.FechaAlta = drEmpleado.GetDateTime(14);
                    empleado.FechaNacimiento = drEmpleado.GetDateTime(15);
                    empleado.IdEmpleado = Convert.ToInt32(drEmpleado[24].ToString());
                    empleado.Legajo = leg;

                    Sexo sexoEmp = new Sexo();
                    sexoEmp.IdSexo = Convert.ToInt32(drEmpleado[16].ToString());
                    sexoEmp.Nombre = drEmpleado.GetString(25);
                    empleado.Sexo = sexoEmp;

                    TipoDocumento tipoDocumentoEmp = new TipoDocumento();
                    tipoDocumentoEmp.IdTipoDocumento = Convert.ToInt32(drEmpleado[2].ToString());
                    tipoDocumentoEmp.Sigla = drEmpleado.GetString(26);
                    empleado.TipoDocumento = tipoDocumentoEmp;
                    empleado.NumeroDocumento = drEmpleado.GetString(3);


                    Cuenta cuenta = new Cuenta();
                    cuenta.IdCuenta = Convert.ToInt32(drEmpleado[19].ToString());
                    cuenta.Nombre = drEmpleado.GetString(27);

                    EstadoUsuario estadoUsuario = new EstadoUsuario();
                    estadoUsuario.IdEstado = Convert.ToInt32(drEmpleado[20].ToString());
                    estadoUsuario.Nombre = drEmpleado.GetString(28);

                    Usuario usuarioEmp = new Usuario();
                    usuarioEmp.Idusuario = Convert.ToInt32(drEmpleado[18].ToString());
                    usuarioEmp.Nombre = drEmpleado.GetString(23);
                    usuarioEmp.Cuenta = cuenta;
                    usuarioEmp.Estado = estadoUsuario;
                    usuarioEmp.Contrasenia = drEmpleado.GetString(21);
                    usuarioEmp.Comentario = drEmpleado.GetString(22);
                    empleado.Usuario = usuarioEmp;



                    Barrio barrioEmp = new Barrio();
                    barrioEmp.IdBarrio = Convert.ToInt32(drEmpleado[9].ToString());
                    barrioEmp.Nombre = drEmpleado.GetString(29);

                    Domicilio domicilioEmp = new Domicilio();
                    domicilioEmp.Calle = drEmpleado.GetString(4);
                    domicilioEmp.Numero = drEmpleado.GetString(5);
                    domicilioEmp.Departamento = drEmpleado.GetString(6);
                    domicilioEmp.Piso = drEmpleado.GetString(7);
                    domicilioEmp.Torre = drEmpleado.GetString(8);
                    domicilioEmp.Barrio = barrioEmp;
                    empleado.Domicilio = domicilioEmp;
                    Localidad localidadEmp = new Localidad();
                    localidadEmp.Idlocalidad = Convert.ToInt32(drEmpleado[10].ToString());
                    localidadEmp.Nombre = drEmpleado.GetString(30);
                    barrioEmp.Localidad = localidadEmp;

                    Departamento departamentoEmp = new Departamento();
                    departamentoEmp.IdDepartamento = Convert.ToInt32(drEmpleado[11].ToString());
                    departamentoEmp.Nombre = drEmpleado.GetString(31);
                    localidadEmp.Departamento = departamentoEmp;

                    Provincia provinciaEmp = new Provincia();
                    provinciaEmp.IdProvincia = Convert.ToInt32(drEmpleado[12].ToString());
                    provinciaEmp.Nombre = drEmpleado.GetString(32);
                    departamentoEmp.Provincia = provinciaEmp;

                    SqlDataReader drCorreos = enlace.getCorreosPorPersona(empleado.Idpersona);
                    List<Correo> correos = new List<Correo>();
                    if (drCorreos.HasRows)
                    {
                        while (drCorreos.Read())
                        {
                            Correo correo = new Correo();
                            correo.IdCorreo = Convert.ToInt32(drCorreos[0].ToString());
                            correo.Direccion = drCorreos.GetString(1);
                            correos.Add(correo);
                        }
                    }
                    empleado.Correos = correos;

                    SqlDataReader drTelefonos = enlace.getTelefonosPorPersona(empleado.Idpersona);
                    List<Telefono> telefonos = new List<Telefono>();
                    if (drTelefonos.HasRows)
                    {
                        while (drTelefonos.Read())
                        {
                            TipoTelefono tipoTelefono = new TipoTelefono();
                            tipoTelefono.Nombre = drTelefonos.GetString(3);
                            tipoTelefono.IdTipoTelefono = Convert.ToInt32(drTelefonos[2].ToString());

                            Telefono telefono = new Telefono();
                            telefono.IdTelefono = Convert.ToInt32(drTelefonos[0].ToString());
                            telefono.Numero = drTelefonos.GetString(1);
                            telefono.TipoTelefono = tipoTelefono;

                            telefonos.Add(telefono);
                        }
                    }
                    empleado.Telefonos = telefonos;

                    return empleado;
                }

            }
            return null;


        }
        public Boolean tomarEmpleadoAEliminar(Empleado empleado)
        {
            EnlaceDatos enlace = new EnlaceDatos();
            if (enlace.eliminarEmpleado(empleado.Legajo))
                return true;
            else
                return false;
        }



        public List<Paciente> obtenerPacientes()
        {
            EnlaceDatos enlace = new EnlaceDatos();
            SqlDataReader drPacientes = enlace.getPacientes();

            if (drPacientes.HasRows)
            {
                List<Paciente> lsPacientes = new List<Paciente>();
                String nombre; String apellido;
                int idPersona;
                while (drPacientes.Read())
                {
                    idPersona = Convert.ToInt32(drPacientes[0].ToString());
                    apellido = drPacientes.GetString(1);
                    nombre = drPacientes.GetString(2);
                    lsPacientes.Add(new Paciente(idPersona, nombre, apellido));

                }
                return lsPacientes;
            }
            return null;
        }

        public Boolean tomarProfesional(Profesional profesional, List<Especialidad> espe)
        {
            EnlaceDatos enlaceDatos = new EnlaceDatos();
            SqlDataReader drProfesionales = enlaceDatos.getProfesionalesParaValidar();

            List<Entidades.Profesional> listaProfesionales = new List<Entidades.Profesional>();
            if (drProfesionales.HasRows)
            {
                while (drProfesionales.Read())
                {
                    TipoDocumento tipd = new TipoDocumento();
                    Profesional e = new Profesional();
                    e.TipoDocumento = tipd;
                    e.TipoDocumento.IdTipoDocumento = Convert.ToInt32(drProfesionales[0].ToString());
                    e.NumeroDocumento = drProfesionales[1].ToString();
                    e.Matricula = drProfesionales[2].ToString();

                    listaProfesionales.Add(e);
                }
                for (int i = 0; i < listaProfesionales.Count; i++)
                {
                    if (listaProfesionales[i].Matricula == profesional.Matricula || (listaProfesionales[i].TipoDocumento.IdTipoDocumento == profesional.TipoDocumento.IdTipoDocumento && listaProfesionales[i].NumeroDocumento == profesional.NumeroDocumento))
                    {
                        return false;
                    }
                }
            }
            enlaceDatos.registrarProfesional(profesional, espe);
            return true;

        }

        public List<Profesional> obtenerProfesionalPorBusqueda(String parametro)
        {
            EnlaceDatos enlaceDatos = new EnlaceDatos();
            SqlDataReader drProfesionales = enlaceDatos.getProfesionalPorBusqueda(parametro);
            

            if (drProfesionales.HasRows)
            {
                List<Profesional> lsProfesional = new List<Profesional>();

                //TipoDocumento
                String sigla; TipoDocumento tipoDoc;

                //Barrio
                String nombreBarrio; Barrio barrio;

                //Localidad
                String nombreLocalidad; Localidad localidad;

                //Departamento
                String nombreDepartamento; Departamento departamento;

                //Provincia
                String nombreProvincia; Provincia provincia;

                //Domicilio
                String calle; String numCalle; String piso; String depto; String torre; Domicilio domicilio;

                //Profesional
                String matricula; String nombre; String apellido; String numDocumento; 
                int idprof;
                int idPer;

                while (drProfesionales.Read())
                {
                    sigla = drProfesionales.GetString(3);
                    tipoDoc = new TipoDocumento(sigla);

                    nombreBarrio = drProfesionales.GetString(10);
                    barrio = new Barrio(nombreBarrio);

                    nombreLocalidad = drProfesionales.GetString(11);
                    localidad = new Localidad(nombreLocalidad);
                    barrio.Localidad = localidad;

                    nombreDepartamento = drProfesionales.GetString(12);
                    departamento = new Departamento(nombreDepartamento);
                    localidad.Departamento = departamento;

                    nombreProvincia = drProfesionales.GetString(13);
                    provincia = new Provincia(nombreProvincia);
                    departamento.Provincia = provincia;

                    calle = drProfesionales.GetString(5);
                    numCalle = drProfesionales.GetString(6);
                    depto = drProfesionales.GetString(7);
                    piso = drProfesionales.GetString(8);
                    torre = drProfesionales.GetString(9);
                    domicilio = new Domicilio(calle, numCalle, depto, piso, torre, barrio);

                    matricula = drProfesionales.GetString(0);
                    apellido = drProfesionales.GetString(1);
                    nombre = drProfesionales.GetString(2);
                    numDocumento = drProfesionales.GetString(4);
                    idprof = Convert.ToInt32(drProfesionales[14].ToString());
                    idPer = Convert.ToInt32(drProfesionales[15].ToString());

                    Profesional profesional = new Profesional(nombre, apellido, numDocumento, tipoDoc, domicilio,idprof,matricula, idPer);

                    lsProfesional.Add(profesional);
                }
                return lsProfesional;
            } 
            return null;
        }
        public List<Consultorio> obtenerConsultorios()
        {
            EnlaceDatos enlace = new EnlaceDatos();
            SqlDataReader drConsultorios = enlace.getConsultorios();

            if (drConsultorios.HasRows)
            {
                List<Consultorio> lsConsultorios = new List<Consultorio>();
                while (drConsultorios.Read())
                {
                    lsConsultorios.Add(new Consultorio(Convert.ToInt32(drConsultorios[0].ToString()),
                                                        Convert.ToInt32(drConsultorios[1].ToString()),
                                                        drConsultorios.GetString(2)));
                }
                return lsConsultorios;
            }
            return null;
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
                    practica.IdPractica=Convert.ToInt32(drPracticas[0].ToString());
                    practica.Nombre=drPracticas.GetString(1);
                    practica.Duracion = Convert.ToInt32(drPracticas[2].ToString());
                    lsPracticas.Add(practica);
               }
                return lsPracticas;
            }
            return null;
        }


        public Paciente obtenerPacientePorNumero(String numPaciente)
        {
            EnlaceDatos enlace = new EnlaceDatos();
            SqlDataReader drPaciente = enlace.getPacientePorNumero(numPaciente);

            if (drPaciente.HasRows)
            {
                if (drPaciente.Read())
                {
                    Paciente paciente = new Paciente();
                    paciente.Idpersona = Convert.ToInt32(drPaciente[0].ToString());
                    paciente.Nombre = drPaciente.GetString(1);
                    paciente.Apellido = drPaciente.GetString(2);
                    paciente.FechaAlta = drPaciente.GetDateTime(3);
                    paciente.NumeroDocumento = drPaciente.GetString(4);
                    paciente.FechaNacimiento = drPaciente.GetDateTime(5);
                    paciente.Comentario = drPaciente.GetString(6);
                    paciente.IdPaciente = Convert.ToInt32(drPaciente[7].ToString());
                    paciente.Numero = drPaciente.GetString(8);

                    TipoDocumento tipoDocumento = new TipoDocumento();
                    int idTipoDocumento = Convert.ToInt32(drPaciente[9].ToString());
                    tipoDocumento.IdTipoDocumento = idTipoDocumento;
                    tipoDocumento.Sigla = drPaciente.GetString(10);
                    paciente.TipoDocumento = tipoDocumento;

                    Sexo sexo = new Sexo();
                    sexo.IdSexo = Convert.ToInt32(drPaciente[11].ToString());
                    sexo.Nombre = drPaciente.GetString(12);
                    paciente.Sexo = sexo;

                    Domicilio domicilio = new Domicilio();
                    domicilio.IdDomicilio = Convert.ToInt32(drPaciente[13].ToString());
                    domicilio.Calle = drPaciente.GetString(14);
                    domicilio.Departamento = drPaciente.GetString(15);
                    domicilio.Piso = drPaciente.GetString(16);
                    domicilio.Torre = drPaciente.GetString(17);
                    domicilio.Numero = drPaciente.GetString(33);
                    paciente.Domicilio = domicilio;

                    Barrio barrio = new Barrio();
                    barrio.IdBarrio = Convert.ToInt32(drPaciente[18].ToString());
                    barrio.Nombre = drPaciente.GetString(19);
                    domicilio.Barrio = barrio;

                    Localidad localidad = new Localidad();
                    localidad.Idlocalidad = Convert.ToInt32(drPaciente[20].ToString());
                    localidad.Nombre = drPaciente.GetString(21);
                    barrio.localidad = localidad;

                    Departamento departamento = new Departamento();
                    departamento.IdDepartamento = Convert.ToInt32(drPaciente[22].ToString());
                    departamento.Nombre = drPaciente.GetString(23);
                    localidad.Departamento = departamento;

                    Provincia provincia = new Provincia();
                    provincia.IdProvincia = Convert.ToInt32(drPaciente[24].ToString());
                    provincia.Nombre = drPaciente.GetString(25);
                    departamento.Provincia = provincia;

                    SqlDataReader drCorreos = enlace.getCorreosPorPersona(paciente.Idpersona);
                    List<Correo> correos = new List<Correo>();
                    if (drCorreos.HasRows)
                    {
                        while (drCorreos.Read())
                        {
                            Correo correo = new Correo();
                            correo.IdCorreo = Convert.ToInt32(drCorreos[0].ToString());
                            correo.Direccion = drCorreos.GetString(1);
                            correos.Add(correo);
                        }
                    }
                    paciente.Correos = correos;

                    SqlDataReader drTelefonos = enlace.getTelefonosPorPersona(paciente.Idpersona);
                    List<Telefono> telefonos = new List<Telefono>();
                    if (drTelefonos.HasRows)
                    {
                        while (drTelefonos.Read())
                        {
                            TipoTelefono tipoTelefono = new TipoTelefono();
                            tipoTelefono.Nombre = drTelefonos.GetString(3);
                            tipoTelefono.IdTipoTelefono = Convert.ToInt32(drTelefonos[2].ToString());

                            Telefono telefono = new Telefono();
                            telefono.IdTelefono = Convert.ToInt32(drTelefonos[0].ToString());
                            telefono.Numero = drTelefonos.GetString(1);
                            telefono.TipoTelefono = tipoTelefono;

                            telefonos.Add(telefono);
                        }
                    }
                    paciente.Telefonos = telefonos;

                    SqlDataReader drAfiliaciones = enlace.getAfiliacionesPorPaciente(paciente.IdPaciente);
                    List<Afiliacion> afiliaciones = new List<Afiliacion>();
                    if (drAfiliaciones.HasRows)
                    {
                        while (drAfiliaciones.Read())
                        {
                            Afiliacion afiliacion = new Afiliacion();
                            afiliacion.IdAfiliacion = Convert.ToInt32(drAfiliaciones[0].ToString());
                            afiliacion.NumeroAfiliado = drAfiliaciones.GetString(1);

                            CoberturaMedica cobertura = new CoberturaMedica();
                            cobertura.IdCoberturaMedica = Convert.ToInt32(drAfiliaciones[2].ToString());
                            cobertura.Nombre = drAfiliaciones.GetString(3);
                            cobertura.Sigla = drAfiliaciones.GetString(4);
                            afiliacion.Cobertura = cobertura;

                            afiliaciones.Add(afiliacion);
                        }
                    }
                    paciente.Afiliaciones = afiliaciones;

                    EstadoUsuario estadoUsuario = new EstadoUsuario();
                    estadoUsuario.IdEstado = Convert.ToInt32(drPaciente[26].ToString());
                    estadoUsuario.Nombre = drPaciente.GetString(27);

                    Cuenta cuenta = new Cuenta();
                    cuenta.IdCuenta = Convert.ToInt32(drPaciente[28].ToString());
                    cuenta.Nombre = drPaciente.GetString(29);

                    Usuario usuario = new Usuario();
                    usuario.Idusuario = Convert.ToInt32(drPaciente[30].ToString());
                    usuario.Nombre = drPaciente.GetString(31);
                    usuario.Contrasenia = drPaciente.GetString(32);
                    usuario.Cuenta = cuenta;
                    usuario.Estado = estadoUsuario;

                    paciente.Usuario = usuario;
                    return paciente;
                }
            }
            return null;
        }
        public List<CoberturaMedica> obtenerCoberturasPorBusqueda(String parametro)
        {
            EnlaceDatos enlace = new EnlaceDatos();
            SqlDataReader drCoberturas = enlace.getCoberturasPorBusqueda(parametro);
            if (drCoberturas.HasRows)
            {
                List<CoberturaMedica> lstCoberturas = new List<CoberturaMedica>();
                while (drCoberturas.Read())
                {
                    CoberturaMedica cobertura = new CoberturaMedica();
                    cobertura.IdCoberturaMedica = Convert.ToInt32(drCoberturas[0].ToString());
                    cobertura.Nombre = drCoberturas.GetString(1);
                    cobertura.Sigla = drCoberturas.GetString(2);
                    lstCoberturas.Add(cobertura);
                }
                return lstCoberturas;
            }
            return null;
        }
        public Barrio obtenerBarrioPorId(int idBarrio)
        {
            EnlaceDatos enlace = new EnlaceDatos();
            SqlDataReader drBarrio = enlace.getBarrioPorId(idBarrio);
            if (drBarrio.HasRows)
            {
                drBarrio.Read();
                Provincia provincia = new Provincia();
                provincia.IdProvincia = Convert.ToInt32(drBarrio[7].ToString());
                provincia.Nombre = drBarrio.GetString(8);

                Departamento departamento = new Departamento();
                departamento.IdDepartamento = Convert.ToInt32(drBarrio[5].ToString());
                departamento.Nombre = drBarrio.GetString(6);

                Localidad localidad = new Localidad();
                localidad.Idlocalidad = Convert.ToInt32(drBarrio[3].ToString());
                localidad.Nombre = drBarrio.GetString(4);

                Barrio barrio = new Barrio();
                barrio.IdBarrio = Convert.ToInt32(drBarrio[0].ToString());
                barrio.Nombre = drBarrio.GetString(1);
                barrio.Comentario = drBarrio.GetString(2);

                departamento.Provincia = provincia;
                localidad.Departamento = departamento;
                barrio.Localidad = localidad;

                return barrio;
            }
            return null;
        }
        public Boolean tomarBarrio(Barrio barrio)
        {
            String nombre = barrio.Nombre;
            String comentario = barrio.Comentario;
            int idLocalidad = barrio.Localidad.Idlocalidad;
            EnlaceDatos enlace = new EnlaceDatos();
            if (enlace.setBarrio(nombre, comentario, idLocalidad))
                return true;
            return false;

        }
        public Boolean tomarPacienteAEliminar(Paciente paciente)
        {
            EnlaceDatos enlace = new EnlaceDatos();
            if (enlace.eliminarPaciente(paciente.Numero))
                return true;
            else
                return false;
        }

    public Profesional obtenerProfesionalxID(int param)
     {
       EnlaceDatos enlaceDatos = new EnlaceDatos();
       SqlDataReader drProfesional= enlaceDatos.getProfesionalxID(param);
       if (drProfesional.HasRows)
       {
           drProfesional.Read();

           Profesional prof = new Profesional();
           prof.Idprofesional = param;
           prof.Idpersona = Convert.ToInt32(drProfesional[18].ToString());
           prof.Apellido = drProfesional.GetString(0);
           prof.Nombre = drProfesional[1].ToString();
           TipoDocumento tipoDocumento = new TipoDocumento();
           tipoDocumento.IdTipoDocumento = Convert.ToInt32(drProfesional[2].ToString());
           prof.TipoDocumento = tipoDocumento;
           prof.NumeroDocumento = drProfesional[3].ToString();
           prof.FechaAlta = drProfesional.GetDateTime(14);
           prof.FechaNacimiento = drProfesional.GetDateTime(15);
           prof.Matricula = drProfesional[13].ToString();
           prof.Comentario=drProfesional[17].ToString();
           Sexo sex = new Sexo();
           int idSexo = Convert.ToInt32(drProfesional[16].ToString());
           sex.IdSexo = idSexo;
           prof.Sexo = sex;
           Provincia provincia = new Provincia();
           Departamento depto = new Departamento();
           Localidad loc = new Localidad();
           Barrio barr = new Barrio();
           Domicilio dom = new Domicilio();

           provincia.IdProvincia = Convert.ToInt32(drProfesional[12].ToString());
           depto.Provincia = provincia;


           depto.IdDepartamento = Convert.ToInt32(drProfesional[11].ToString());
           loc.Departamento = depto;


           loc.Idlocalidad = Convert.ToInt32(drProfesional[10].ToString());
           barr.Localidad = loc;

           barr.IdBarrio = Convert.ToInt32(drProfesional[9].ToString());
           dom.Barrio = barr;

        
           dom.Calle = drProfesional[4].ToString();
           dom.Numero = drProfesional[5].ToString();
           dom.Departamento = drProfesional[7].ToString();
           dom.Piso = drProfesional[6].ToString();
           dom.Torre = drProfesional[8].ToString();
           prof.Domicilio = dom;

           SqlDataReader drCorreos = enlaceDatos.getCorreosPorPersona(prof.Idpersona);
           List<Correo> lstcorreos = new List<Correo>();
           if (drCorreos.HasRows)
           {
               while (drCorreos.Read())
               {
                   Correo correo = new Correo();
                   correo.Direccion = drCorreos.GetString(1);
                   lstcorreos.Add(correo);
               }
           }
           prof.Correos = lstcorreos;


           SqlDataReader drTelefonos = enlaceDatos.getTelefonosPorPersona(prof.Idpersona);
           List<Telefono> lsttelefonos = new List<Telefono>();
           if (drTelefonos.HasRows)
           {

               while (drTelefonos.Read())
               {
                   Telefono telefono = new Telefono();
                   telefono.Numero = drTelefonos.GetString(1);
                   telefono.IdTelefono =Convert.ToInt32(drTelefonos[0].ToString());
                   TipoTelefono tipoTelefono = new TipoTelefono();
                   tipoTelefono.Nombre = drTelefonos.GetString(3);
                   tipoTelefono.IdTipoTelefono = Convert.ToInt32(drTelefonos[2].ToString());
                   telefono.TipoTelefono = tipoTelefono;

                   lsttelefonos.Add(telefono);
               }
           }
           prof.Telefonos = lsttelefonos;

           
           Cuenta cuenta = new Cuenta();
           cuenta.IdCuenta = Convert.ToInt32(drProfesional[19].ToString());

           EstadoUsuario estadoUsuario = new EstadoUsuario();
           estadoUsuario.IdEstado = Convert.ToInt32(drProfesional[21].ToString());

           Usuario usuarioProf = new Usuario();
           usuarioProf.Idusuario = Convert.ToInt32(drProfesional[24].ToString());
           usuarioProf.Nombre = drProfesional.GetString(20);
           usuarioProf.Cuenta = cuenta;
           usuarioProf.Estado = estadoUsuario;
           usuarioProf.Contrasenia = drProfesional.GetString(22);
           usuarioProf.Comentario = drProfesional.GetString(23);
           prof.Usuario = usuarioProf;
    

         return prof;


       }
       return null;

        }

    public List<Especialidad> obtenerEspecialidadPorProfesional(int param)
    {
        EnlaceDatos enlaceDatos = new EnlaceDatos();
        SqlDataReader drEspecialidadesPorProfesional = enlaceDatos.getEspecialidadPorProfesional(param);

        List<Especialidad> lsEspecialidadesPorProfesional = new List<Especialidad>();
        while (drEspecialidadesPorProfesional.Read())
        {
            Especialidad esp = new Especialidad();
            esp.Idespecialidad = Convert.ToInt32(drEspecialidadesPorProfesional[0].ToString());
            esp.Nombre = drEspecialidadesPorProfesional[1].ToString();
            esp.Descripcion = drEspecialidadesPorProfesional[2].ToString();
            lsEspecialidadesPorProfesional.Add(esp);
        }
        return lsEspecialidadesPorProfesional;
    }

    public Boolean tomarProfesionalAEliminar(Profesional profesional)
    {
        EnlaceDatos enlace = new EnlaceDatos();
        if (enlace.eliminarProfesional(profesional.Idprofesional))
            return true;
        else
            return false;
    }

    public List<Especialidad> limpiarGrilla()
    {
        List<Especialidad> list = new List<Especialidad>();
        return list;
    }
        //Cambios de Juan



    public List<Profesional> obtenerTodosProfesionales()
    {
        EnlaceDatos enlace = new EnlaceDatos();
        SqlDataReader drProfesionales = enlace.getAllProfesionales();
        if (drProfesionales.HasRows)
        {
            List<Profesional> lsProfesionales = new List<Profesional>();
            while (drProfesionales.Read())
            {
                Profesional profesional = new Profesional();
                profesional.Idprofesional = Convert.ToInt32(drProfesionales[0].ToString());
                profesional.Apellido = drProfesionales.GetString(1);
                profesional.Nombre = drProfesionales.GetString(2);
                lsProfesionales.Add(profesional);
            }
            return lsProfesionales;
        }
        return null;
    }

      public List<Paciente> obtenerTodosPacientes()
    {
        EnlaceDatos enlace = new EnlaceDatos();
        SqlDataReader drPacientes = enlace.getAllPacientes();
        if (drPacientes.HasRows)
        {
            List<Paciente> lsPacientes = new List<Paciente>();
            while (drPacientes.Read())
            {
                Paciente paciente = new Paciente();
                paciente.IdPaciente = Convert.ToInt32(drPacientes[0].ToString());
                paciente.Apellido = drPacientes.GetString(1);
                paciente.Nombre = drPacientes.GetString(2);
                lsPacientes.Add(paciente);
            }
            return lsPacientes;
        }
        return null;
    }

    public int tomarTurno(Turno turno)
    {
        DateTime fechaAlta = turno.FechaAlta;
        int idProfesional = turno.Profesional.Idprofesional;
        int idPaciente = turno.Paciente.IdPaciente;
        DateTime fechaTurno = turno.FechaTurno;
        DateTime horaInicio = turno.HoraInicio;
        DateTime horaFin = turno.HoraFin;
        String comentario = turno.Comentario;
        int idEstado = turno.EstadoTurno.IdEstado;

        List<int> lsIdPracticas = new List<int>();
        foreach (Practica practica in turno.Practicas)
        {
            lsIdPracticas.Add(practica.IdPractica);
        }

        EnlaceDatos enlace = new EnlaceDatos();
        return enlace.registrarTurno(fechaAlta, idProfesional, idPaciente, fechaTurno, horaInicio, horaFin, idEstado, comentario, lsIdPracticas);
    }

    public List<Turno> obtenerTurnosPorSemana(DateTime fechaDesde, DateTime fechaHasta, int idProfesional, int idEstado)
    {
        EnlaceDatos datos = new EnlaceDatos();
        SqlDataReader drTurnos = datos.getTurnosPorSemana(fechaDesde, fechaHasta, idProfesional, idEstado);
        if (drTurnos.HasRows)
        {
            List<Turno> lsTurnos = new List<Turno>();
            while (drTurnos.Read())
            {

                Turno turno = new Turno();
                turno.IdTurno = Convert.ToInt32(drTurnos[0].ToString());
                turno.FechaTurno = drTurnos.GetDateTime(1);
                turno.HoraInicio = Convert.ToDateTime(drTurnos[2].ToString());
                turno.HoraFin = Convert.ToDateTime(drTurnos[3].ToString());
                turno.Comentario = drTurnos.GetString(4);

                EstadoTurno estado = new EstadoTurno();
                estado.IdEstado = Convert.ToInt32(drTurnos[5].ToString());
                estado.Nombre = drTurnos[6].ToString();

                Paciente paciente = new Paciente();
                paciente.IdPaciente = Convert.ToInt32(drTurnos[7].ToString());
                paciente.Apellido = drTurnos[8].ToString();
                paciente.Nombre = drTurnos[9].ToString();

                turno.EstadoTurno = estado;
                turno.Paciente = paciente;
                lsTurnos.Add(turno);
            }
            return lsTurnos;
        }
        return null;
    }

    public List<EstadoTurno> obtenerTodosEstadosTurno()
    {
        EnlaceDatos enlace = new EnlaceDatos();
        SqlDataReader drEstados = enlace.getAllEstadosTurno();
        if (drEstados.HasRows)
        {
            List<EstadoTurno> lsEstados = new List<EstadoTurno>();
            while (drEstados.Read())
            {
                EstadoTurno estados = new EstadoTurno();
                estados.IdEstado = Convert.ToInt32(drEstados[0].ToString());
                estados.Nombre = drEstados.GetString(1);
                lsEstados.Add(estados);
            }
            return lsEstados;
        }
        return null;
    }

    public Boolean tomarTurnoAEliminar(int idTurno)
    {
        EnlaceDatos enlace = new EnlaceDatos();
        if (enlace.eliminarTurno(idTurno))
            return true;
        else
            return false;
    }

    public Boolean tomarTurnoACancelar(int idTurno)
    {
        EnlaceDatos enlace = new EnlaceDatos();
        if (enlace.cancelarTurno(idTurno))
            return true;
        else
            return false;
    }

    public Boolean tomarTurnoAConfirmar(int idTurno)
    {
        EnlaceDatos enlace = new EnlaceDatos();
        if (enlace.confirmarTurno(idTurno))
            return true;
        else
            return false;
    }

    public Turno obtenerTurnoPorId(int idTurno)
    {
        EnlaceDatos enlace = new EnlaceDatos();
        SqlDataReader drTurno = enlace.getTurnoPorId(idTurno);
        SqlDataReader drPaciente = enlace.getPacientePorTurno(idTurno);
        if (drTurno.HasRows && drPaciente.HasRows)
        {
            drTurno.Read();
            Turno turno = new Turno();
            turno.IdTurno = Convert.ToInt32(drTurno[0].ToString());
            turno.FechaTurno = drTurno.GetDateTime(1);
            turno.HoraInicio = Convert.ToDateTime(drTurno.GetDateTime(2).ToShortTimeString());
            turno.HoraFin = drTurno.GetDateTime(3);
            turno.Comentario = drTurno.GetString(4);

            Profesional profesional = new Profesional();
            profesional.Idprofesional = Convert.ToInt32(drTurno[5].ToString());
            profesional.Apellido = drTurno.GetString(6);
            profesional.Nombre = drTurno.GetString(7);

            EstadoTurno estado = new EstadoTurno();
            estado.IdEstado = Convert.ToInt32(drTurno[8].ToString());
            estado.Nombre = drTurno.GetString(9);

            drPaciente.Read();
            Paciente paciente = new Paciente();
            paciente.IdPaciente = Convert.ToInt32(drPaciente[0].ToString());
            paciente.Apellido = drPaciente.GetString(1);
            paciente.Nombre = drPaciente.GetString(2);

            turno.EstadoTurno = estado;
            turno.Profesional = profesional;
            turno.Paciente = paciente;

            SqlDataReader drPracticas = enlace.getPracticasPorTurno(turno.IdTurno);
            {
                if (drPracticas.HasRows)
                {
                    List<Practica> practicas = new List<Practica>();
                    while (drPracticas.Read())
                    {
                        Practica practica = new Practica();
                        practica.IdPractica = Convert.ToInt32(drPracticas[0].ToString());
                        practica.Nombre = drPracticas.GetString(1);
                        practica.Duracion = Convert.ToInt32(drPracticas[2].ToString());
                        practicas.Add(practica);
                    }
                    turno.Practicas = practicas;
                }
            }
            return turno;
        }
        return null;
    }


        //Cambios de Agus

    //public Boolean grabarDiagramacion(Diagramacion diag, List<DetalleDiagramacion> listaDetallDiagramacion)
    //{
    //    EnlaceDatos enld = new EnlaceDatos();
    //    if (enld.registrarDiagramacion(diag, listaDetallDiagramacion) == true)
    //    { return true; }
    //    else { return false; }
    //}


    //public List<Profesional> obtenerProfesionalesParaDiagramacion()
    //{
    //    EnlaceDatos enlaceDatos = new EnlaceDatos();
    //    SqlDataReader drProfesionales = enlaceDatos.getProfesionalesParaDiagramacion();
    //    List<Profesional> lsProfesionales = new List<Profesional>();
    //    while (drProfesionales.Read())
    //    {
    //        Profesional prof = new Profesional();
    //        prof.Idpersona = Convert.ToInt32(drProfesionales[0].ToString());
    //        prof.Nombre = drProfesionales[2].ToString();
    //        prof.Apellido = drProfesionales[1].ToString();
    //        prof.Idprofesional = Convert.ToInt32(drProfesionales[3].ToString());
    //        lsProfesionales.Add(prof);
    //    }
    //    return lsProfesionales;
    //}

    //public Diagramacion obtenerDiagramacionPorSemana(DateTime fechaDesde, DateTime fechaHasta, int idProfesional)
    //{
    //    Entidades.Diagramacion diagram = new Diagramacion();
    //    Profesional profesional = new Profesional();
    //    EnlaceDatos datos = new EnlaceDatos();
    //    SqlDataReader drDiagramacion = datos.getDiagramacionesPorProfesional(idProfesional);

    //    if (drDiagramacion.HasRows)
    //    {
    //        drDiagramacion.Read();
    //        diagram.Profesional = profesional;
    //        diagram.IdDiagramacion = Convert.ToInt32(drDiagramacion[0].ToString());
    //        diagram.Profesional.Idprofesional = Convert.ToInt32(drDiagramacion[1].ToString());
    //        diagram.FechaAlta = Convert.ToDateTime(drDiagramacion[2].ToString());
    //        diagram.FechaInicio = Convert.ToDateTime(drDiagramacion[3].ToString());
    //        diagram.FechaFin = Convert.ToDateTime(drDiagramacion[4].ToString());
    //    }

    //    return diagram;
    //}

    //public List<Entidades.DetalleDiagramacion> obtenerDetalleDeDiagramacionPorDiagramacion(Entidades.Diagramacion diagramacion)
    //{
    //    EnlaceDatos enlaceDatos = new EnlaceDatos();
    //    SqlDataReader drDetallesDiagramacion = enlaceDatos.getDetallesDeDiagramacionPorDiagramacion(diagramacion);
    //    List<DetalleDiagramacion> lsDetalles = new List<DetalleDiagramacion>();
    //    while (drDetallesDiagramacion.Read())
    //    {
    //        DetalleDiagramacion det = new DetalleDiagramacion();
    //        det.Iddetallediagramacion = Convert.ToInt32(drDetallesDiagramacion[0].ToString());
    //        det.HoraInicio = Convert.ToDateTime(drDetallesDiagramacion[1].ToString());
    //        det.HoraFin = Convert.ToDateTime(drDetallesDiagramacion[2].ToString());
    //        det.Dia = Convert.ToInt32(drDetallesDiagramacion[3].ToString());
    //        lsDetalles.Add(det);
    //    }
    //    return lsDetalles;
    //}

        //Cambios Juan entrega 5-11
    public List<Profesional> obtenerProfesionalesParaDiagramacion()
    {
        EnlaceDatos enlaceDatos = new EnlaceDatos();
        SqlDataReader drProfesionales = enlaceDatos.getProfesionalesParaDiagramacion();
        List<Profesional> lsProfesionales = new List<Profesional>();
        while (drProfesionales.Read())
        {
            Profesional prof = new Profesional();
            prof.Idpersona = Convert.ToInt32(drProfesionales[0].ToString());
            prof.Nombre = drProfesionales[2].ToString();
            prof.Apellido = drProfesionales[1].ToString();
            prof.Idprofesional = Convert.ToInt32(drProfesionales[3].ToString());
            lsProfesionales.Add(prof);
        }
        return lsProfesionales;
    }

    public Diagramacion obtenerDiagramacionPorSemana(DateTime fechaDesde, DateTime fechaHasta, int idProfesional)
    {
        Diagramacion diagram = new Diagramacion();
        Profesional profesional = new Profesional();
        EnlaceDatos datos = new EnlaceDatos();
        SqlDataReader drDiagramacion = datos.getDiagramacionesPorProfesional(idProfesional);

        if (drDiagramacion.HasRows)
        {
            drDiagramacion.Read();
            diagram.Profesional = profesional;
            diagram.IdDiagramacion = Convert.ToInt32(drDiagramacion[0].ToString());
            diagram.Profesional.Idprofesional = Convert.ToInt32(drDiagramacion[1].ToString());
            diagram.FechaAlta = Convert.ToDateTime(drDiagramacion[2].ToString());
            diagram.FechaDesde = Convert.ToDateTime(drDiagramacion[3].ToString());
            diagram.FechaHasta = Convert.ToDateTime(drDiagramacion[4].ToString());
        }

        return diagram;
    }

    public List<EstadoDetalleDia> obtenerEstadosDetalleDia()
    {
        EnlaceDatos enlace = new EnlaceDatos();
        SqlDataReader drEstados = enlace.getAllEstadosDetalleDia();
        if (drEstados.HasRows)
        {
            List<EstadoDetalleDia> lsEstados = new List<EstadoDetalleDia>();
            while (drEstados.Read())
            {
                EstadoDetalleDia estado = new EstadoDetalleDia();
                estado.IdEstadoDetalleDia = Convert.ToInt32(drEstados[0].ToString());
                estado.Nombre = drEstados.GetString(1);
                lsEstados.Add(estado);
            }
            return lsEstados;
        }
        return null;
    }

    public Boolean tomarDiagramacion(Diagramacion diagramacion)
    {
        /*EnlaceDatos enlace = new EnlaceDatos();
        DataColumn[] columnas = new DataColumn[] {new DataColumn(),new DataColumn(),new DataColumn(),
                                                  new DataColumn(),new DataColumn(),new DataColumn(),
                                                  new DataColumn(),new DataColumn(),new DataColumn(),
                                                  new DataColumn()};
        DataTable dtDiagramacion = new DataTable();
        dtDiagramacion.Columns.AddRange(columnas);
            
        foreach (DiaDiagramacion dia in diagramacion.DiasDiagramacion)
        {
                
            foreach (DetalleDia detalle in dia.DetallesDia)
            {
                DateTime horaInicio = detalle.HoraInicio;
                DateTime horaFin = detalle.HoraFin;
                int idEstadoDetalle = detalle.Estado.IdEstadoDetalleDia;

                DataRow dr = dtDiagramacion.NewRow();
                dr[0] = diagramacion.Profesional.Idprofesional;
                dr[1] = diagramacion.FechaAlta;
                dr[2] = diagramacion.FechaDesde;
                dr[3] = diagramacion.FechaHasta;
                dr[4] = diagramacion.Estado.Idestadodiagramacion;
                dr[5] = dia.Fecha;
                dr[6] = dia.Estado.IdEstadoDiaDiagramacion;
                dr[7] = detalle.HoraInicio;
                dr[8] = detalle.HoraFin;
                dr[9] = detalle.Estado.IdEstadoDetalleDia;
                dtDiagramacion.Rows.Add(dr);
            }
        }
        if (enlace.registrarDiagramacion(dtDiagramacion))
            return true;
        else
            return false;*/
        EnlaceDatos enlace = new EnlaceDatos();
        return enlace.registrarDiagramacion(diagramacion);


    }

    public List<EstadoDiagramacion> obtenerEstadosDiagramacion()
    {
        EnlaceDatos enlace = new EnlaceDatos();
        SqlDataReader drEstados = enlace.getAllEstadosDiagramacion();


        if (drEstados.HasRows)
        {
            List<EstadoDiagramacion> lsEstados = new List<EstadoDiagramacion>();
            while (drEstados.Read())
            {
                EstadoDiagramacion estado = new EstadoDiagramacion();
                estado.Idestadodiagramacion = Convert.ToInt32(drEstados[0].ToString());
                estado.Nombre = drEstados.GetString(1);
                lsEstados.Add(estado);
            }
            return lsEstados;
        }
        return null;
    }

    public List<DiaSemana> obtenerDiasSemana()
    {
        EnlaceDatos enlace = new EnlaceDatos();
        SqlDataReader drDias = enlace.getAllDiasSemana();
        if (drDias.HasRows)
        {
            List<DiaSemana> lsDias = new List<DiaSemana>();
            while (drDias.Read())
            {
                DiaSemana dia = new DiaSemana();
                dia.IdDiaSemana = Convert.ToInt32(drDias[0].ToString());
                dia.Nombre = drDias.GetString(1);
                lsDias.Add(dia);
            }
            return lsDias;
        }
        return null;
    }

    public List<MotivoExcepcion> obtenerMotivosExcepcion()
    {
        EnlaceDatos enlace = new EnlaceDatos();
        SqlDataReader drMotivosExcepcion = enlace.getAllMotivosExcepcion();
        if (drMotivosExcepcion.HasRows)
        {
            List<MotivoExcepcion> lsMotivos = new List<MotivoExcepcion>();
            while (drMotivosExcepcion.Read())
            {
                MotivoExcepcion motivo = new MotivoExcepcion();
                motivo.IdMotivoExcepcion = Convert.ToInt32(drMotivosExcepcion[0].ToString());
                motivo.Nombre = drMotivosExcepcion.GetString(1);
                lsMotivos.Add(motivo);
            }
            return lsMotivos;
        }
        return null;
    }

    public Diagramacion obtenerDiagramacionPorFechaYProfesional(DateTime fecha, int idProfesional)
    {
        EnlaceDatos enlace = new EnlaceDatos();
        SqlDataReader drDiagramacion = enlace.getDiagramacionPorFechaYProfesional(fecha, idProfesional);
        if (drDiagramacion.HasRows)
        {
            drDiagramacion.Read();
            Diagramacion diagramacion = new Diagramacion();
            diagramacion.IdDiagramacion = Convert.ToInt32(drDiagramacion[0].ToString());
            diagramacion.FechaAlta = Convert.ToDateTime(drDiagramacion.GetDateTime(1));
            diagramacion.FechaDesde = Convert.ToDateTime(drDiagramacion.GetDateTime(2));
            diagramacion.FechaHasta = Convert.ToDateTime(drDiagramacion.GetDateTime(3));
            diagramacion.DiasDiagramacion = new List<DiaDiagramacion>();

            EstadoDiagramacion estadoDiagramacion = new EstadoDiagramacion();
            estadoDiagramacion.Idestadodiagramacion = Convert.ToInt32(drDiagramacion[4].ToString());
            estadoDiagramacion.Nombre = drDiagramacion.GetString(5);

            diagramacion.Estado = estadoDiagramacion;


            //Calcula los extremos de la semana
            DateTime fechaDesde = DateTime.MinValue;
            DateTime fechaHasta = DateTime.MinValue;
            fechaDesde = fecha.AddDays(1 - Convert.ToDouble(fecha.DayOfWeek));
            fechaHasta = fecha.AddDays(5 - Convert.ToDouble(fecha.DayOfWeek));

            SqlDataReader drDiasDiagramacion = enlace.getDiasPorDiagramacion(diagramacion.IdDiagramacion, fechaDesde, fechaHasta);
            if (drDiasDiagramacion != null)
            {
                while (drDiasDiagramacion.Read())
                {
                    DiaDiagramacion diaDiagramacion = new DiaDiagramacion();
                    diaDiagramacion.IdDiaDiagramacion = Convert.ToInt32(drDiasDiagramacion[0].ToString());
                    diaDiagramacion.Fecha = Convert.ToDateTime(drDiasDiagramacion[1].ToString());
                    diaDiagramacion.DetallesDia = new List<DetalleDia>();

                    EstadoDiaDiagramacion estadoDia = new EstadoDiaDiagramacion();
                    estadoDia.IdEstadoDiaDiagramacion = Convert.ToInt32(drDiasDiagramacion[2].ToString());
                    estadoDia.Nombre = drDiasDiagramacion[3].ToString();

                    diaDiagramacion.Estado = estadoDia;

                    SqlDataReader drDetallesDia = enlace.getDetallesPorDia(diaDiagramacion.IdDiaDiagramacion);
                    if (drDetallesDia != null)
                    {
                        while (drDetallesDia.Read())
                        {
                            DetalleDia detalleDia = new DetalleDia();
                            detalleDia.IdDetalleDia = Convert.ToInt32(drDetallesDia[0].ToString());
                            detalleDia.HoraInicio = Convert.ToDateTime(drDetallesDia[1].ToString());
                            detalleDia.HoraFin = Convert.ToDateTime(drDetallesDia[2].ToString());

                            EstadoDetalleDia estadoDetalle = new EstadoDetalleDia();
                            estadoDetalle.IdEstadoDetalleDia = Convert.ToInt32(drDetallesDia[3].ToString());
                            estadoDetalle.Nombre = drDetallesDia[4].ToString();

                            detalleDia.Estado = estadoDetalle;

                            diaDiagramacion.DetallesDia.Add(detalleDia);
                        }

                    }
                    diagramacion.DiasDiagramacion.Add(diaDiagramacion);
                }
                return diagramacion;
            }
        }
        return null;
    }

    //////////////////////////////////////////// Desde aca empieza el Agus parte de atencion =) ////////////////////////////////////////////////////////////////////////

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

  }
}
