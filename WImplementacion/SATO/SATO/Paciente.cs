using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Negocio;
using Entidades;

namespace Presentacion
{
    public partial class frmPaciente : Form
    {
        private String numeroPacViejo;
        private int tipoDniViejo;
        private String nroDniViejo;
        private Boolean esNuevo;
        private int idPersonaGrilla;
        private int idPacientegrilla;
        private Validador validador = new Validador();
        public frmPaciente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            
        }

        private void button15_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            frmTiposDocumento vtTipoDocumento = new frmTiposDocumento();
            vtTipoDocumento.ShowDialog();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            frmTiposDocumento vtTipoDocumento = new frmTiposDocumento();
            vtTipoDocumento.ShowDialog();
            mostrarTiposDocumento();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            frmCobertura vtCoberturas = new frmCobertura();
            vtCoberturas.ShowDialog();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void Paciente_Load(object sender, EventArgs e)
        {
            mostrarProvincias();
            mostrarTiposDocumento();
            mostrarTiposTelefono();
            mostrarCoberturasMedica();
            mostrarSexos();
            mostrarCuentasUsuario();
            mostrarEstadosUsuario();
            cargarGrilla();
            validador.manejarBotonesABM(btnCancelar, btnAgregar, btnCancelar, btnModificar, btnEliminar, btnGuardar, btnSalir);
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            ToolTip toolTip1 = new ToolTip();

            // Set up the delays for the ToolTip.
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip1.ShowAlways = true;

            // Set up the ToolTip text for the Button and Checkbox.
            toolTip1.SetToolTip(btnAgregar, "Agrega un Paciente");
            toolTip1.SetToolTip(btnCancelar, "Cancela la acción que se esta realizando");
            toolTip1.SetToolTip(btnModificar, "Habilita la modificación del Paciente");
            toolTip1.SetToolTip(btnEliminar, "Elimina el Paciente");
            toolTip1.SetToolTip(btnGuardar, "Guarda el Paciente creado o modificado");
            toolTip1.SetToolTip(btnSalir, "Sale de la ventana");
        }

        private void cargarGrilla()
        {
            
        }

        private void mostrarProvincias()
        {
            GestorDePersonas gestorPersonas = new GestorDePersonas();
            cmbProvincias.Items.Clear();
            cmbProvincias.ValueMember = "idProvincia";
            cmbProvincias.DisplayMember = "nombre";
            cmbProvincias.DataSource = gestorPersonas.obtenerProvincias();
        }

        private void cmbProvincias_SelectedIndexChanged(object sender, EventArgs e)
        {
            mostrarDepartamentosPorProvincia((int)cmbProvincias.SelectedValue);
        }

        private void mostrarDepartamentosPorProvincia(int idProvincia)
        {
            GestorDePersonas gestorPersonas = new GestorDePersonas();
            cmbDepartamentos.ValueMember = "idDepartamento";
            cmbDepartamentos.DisplayMember = "nombre";
            cmbDepartamentos.DataSource = gestorPersonas.obtenerDepartamentosPorProvincia(idProvincia);
        }

        private void mostrarLocalidadesPorDepartamento(int idDepartamento)
        {
            GestorDePersonas gestorPersonas = new GestorDePersonas();
            cmbLocalidades.ValueMember = "idLocalidad";
            cmbLocalidades.DisplayMember = "nombre";
            cmbLocalidades.DataSource = gestorPersonas.obtenerLocalidadesPorDepartamento(idDepartamento);
        }

        private void cmbDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            mostrarLocalidadesPorDepartamento((int)cmbDepartamentos.SelectedValue);
        }

        private void mostrarBarriosPorLocalidad(int idLocalidad)
        {
            GestorDePersonas gestorPersonas = new GestorDePersonas();
            cmbBarrios.ValueMember = "idBarrio";
            cmbBarrios.DisplayMember = "nombre";
            cmbBarrios.DataSource = gestorPersonas.obtenerBarriosPorLocalidad(idLocalidad);
        }

        private void mostrarTiposTelefono()
        {
            GestorDePersonas gestorPersonas = new GestorDePersonas();
            cmbTipoTelefono.ValueMember = "idTipoTelefono";
            cmbTipoTelefono.DisplayMember = "nombre";
            cmbTipoTelefono.DataSource = gestorPersonas.obtenerTiposTelefono();
        }

        private void cmbLocalidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            mostrarBarriosPorLocalidad((int)cmbLocalidades.SelectedValue);
        }

        private void mostrarTiposDocumento()
        {
            GestorDePersonas gestorPersonas = new GestorDePersonas();
            cmbTipoDocumento.ValueMember = "idTipoDocumento";
            cmbTipoDocumento.DisplayMember = "nombre";
            cmbTipoDocumento.DataSource = gestorPersonas.obtenerTiposDocumento();
        }

        private void mostrarCoberturasMedica()
        {
            GestorDePersonas gestorPersonas = new GestorDePersonas();
            List<CoberturaMedica> coberturasMedicas= gestorPersonas.obtenerCoberturasMedicas();
            foreach (CoberturaMedica coberturaMedica in coberturasMedicas)
            {
                cmbCobertura.Items.Add(coberturaMedica);
            }
            cmbCobertura.ValueMember = "idCobertura";
            cmbCobertura.SelectedIndex = 0;
            
        }

        private void mostrarCuentasUsuario()
        {
            GestorDePersonas gestorPersonas = new GestorDePersonas();
            cmbCuenta.ValueMember = "idCuenta";
            cmbCuenta.DisplayMember = "nombre";
            cmbCuenta.DataSource = gestorPersonas.obtenerCuentasPaciente();
        }

        private void mostrarEstadosUsuario()
        {
            GestorDePersonas gestorPersonas = new GestorDePersonas();
            cmbEstado.ValueMember = "idEstado";
            cmbEstado.DisplayMember = "nombre";
            cmbEstado.DataSource = gestorPersonas.obtenerEstadosUsuarios();
        }

        private void mostrarSexos()
        {
            GestorDePersonas gestorPersonas = new GestorDePersonas();
            cmbSexo.ValueMember = "idSexo";
            cmbSexo.DisplayMember = "nombre";
            cmbSexo.DataSource = gestorPersonas.obtenerSexos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            cmbCuenta.Text = "Paciente";
            validador.limpiarTexBox(this);
            validador.habilitarControles(this, true);
            validador.manejarBotonesABM(btnAgregar, btnAgregar, btnCancelar, btnModificar, btnEliminar,
                                        btnGuardar, btnSalir);
            txtNumeroPaciente.Focus();
            esNuevo = true;
        }

        private void manejarControlesNuevoPaciente()
        { 
            
        }

        private void habilitarControles(Boolean estado)
        {
            
        }
                
        private Boolean guardarPaciente()
        {
            String numPaciente;
            if (validador.validarNumeroPaciente(txtNumeroPaciente,"Ingrese el número de paciente","Atención"))
            {numPaciente = txtNumeroPaciente.Text.Trim();}
            else{return false;}
            
            DateTime fechaAlta = dtpFechaAlta.Value.Date;
            DateTime fechaNacimiento = dtpFechaNacimiento.Value.Date;

            String nombre;
            if (validador.validarString(txtNombre,"Ingrese el nombre del paciente","Atención"))
            {nombre = txtNombre.Text.Trim();}
            else{return false;}

            String apellido;
            if(validador.validarString(txtApellido,"Ingrese el apellido del paciente","Atención"))
            {apellido=txtApellido.Text.Trim();}
            else{return false;}
            
            String numeroDocumento;
            if (validador.validarString(txtNumDocumento,"Ingrese el número de documento","Atención"))
            {numeroDocumento = txtNumDocumento.Text.Trim(); } 
            else {return false; }
      
            //Tipo de documento
            int idTipoDoc = Convert.ToInt32(cmbTipoDocumento.SelectedValue);
            String nombreTipoDoc = cmbTipoDocumento.Text;
            TipoDocumento tipoDocumento = new TipoDocumento(idTipoDoc, nombreTipoDoc);
                        
            //Sexo
            int idSexo = Convert.ToInt32(cmbSexo.SelectedValue);
            String nombreSexo = cmbSexo.Text;
            Sexo sexo = new Sexo(idSexo, nombreSexo);
            
            //Barrio
            int idBarrio = Convert.ToInt32(cmbBarrios.SelectedValue);
            String nombreBarrio = cmbBarrios.Text;
            Barrio barrio=new Barrio(idBarrio,nombreBarrio);
            
            //Domicilio
            String calle;
            if(validador.validarString(txtCalle,"Ingrese el nombre de la calle","Atencion"))
            {calle=txtCalle.Text.ToString();}
            else { return false;}

            String numeroCalle;
            if (validador.validarString(txtNumeroCalle, "Ingrese número de la calle","Atencion"))
            { numeroCalle = txtNumeroCalle.Text.Trim(); }
            else { return false; }

            String piso = txtPiso.Text.Trim();
            String depto = txtDepto.Text.Trim();
            String torre=txtTorre.Text.Trim();
            Domicilio domicilio = new Domicilio(calle, numeroCalle, depto, piso, torre,barrio);
                
            String comentario = txtComentario.Text.Trim();
            
            List<Correo> correos = new List<Correo>();
            foreach (Correo correo in lstCorreosElectronicos.Items)
            {
                correos.Add(correo);
            }
                        
            List<Telefono> telefonos = new List<Telefono>();
            foreach (Telefono telefono in lstTelefonos.Items)
            {
                telefonos.Add(telefono);
            }
            
            List<Afiliacion> afiliaciones = new List<Afiliacion>();
            foreach (Afiliacion afiliacion in lstAfiliaciones.Items)
            {
                afiliaciones.Add(afiliacion);
            }

            //usuario.
            Cuenta cuenta = new Cuenta();
            cuenta = (Cuenta)cmbCuenta.SelectedItem;
            
            EstadoUsuario estadoUsuario = new EstadoUsuario();
            estadoUsuario = (EstadoUsuario)cmbEstado.SelectedItem;

            String contrasenia;
            if (validador.validarString(txtContrasenia, "Ingrese la contraseña","Atención"))
            { contrasenia = txtContrasenia.Text.Trim(); }
            else { return false; }

            String nombreUsuario = cmbNombreUsuario.Text;
            String comentarioUsuario=txtComentarioUsuario.Text.Trim();
            Usuario usuario = new Usuario(nombreUsuario, contrasenia, cuenta, comentarioUsuario, estadoUsuario);

            Paciente paciente = new Paciente(nombre,apellido,fechaAlta,numeroDocumento,tipoDocumento,fechaNacimiento,telefonos,
                                            correos,domicilio,usuario,comentario,sexo,numPaciente,afiliaciones);
            GestorDePersonas gestorPersonas = new GestorDePersonas();
            if(gestorPersonas.tomarPaciente(paciente))
            {
                return true;
            }
            else
            {
                MessageBox.Show("El paciente ya se encuentra registrado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (esNuevo == true)
            {
                if (guardarPaciente())
                {
                    MessageBox.Show("El paciente se registro exitosamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    validador.habilitarControles(this, false);
                    validador.manejarBotonesABM(btnGuardar, btnAgregar, btnCancelar, btnModificar, btnEliminar,
                                            btnGuardar, btnSalir);
                }
                else
                {
                    MessageBox.Show("El paciente no se registro exitosamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if (modificarPaciente())
                {
                    validador.habilitarControles(this, false);
                    validador.manejarBotonesABM(btnGuardar, btnAgregar, btnCancelar, btnModificar, btnEliminar,
                                            btnGuardar, btnSalir);
                }
            }
        }

        private void btnAgregarCorreo_Click(object sender, EventArgs e)
        {
            if (validador.validarString(txtCorreo,"Ingrese una dirección de correo","Atención"))
            {
                Correo correo = new Correo(txtCorreo.Text.Trim());
                lstCorreosElectronicos.Items.Add(correo);
                cmbNombreUsuario.Items.Add(correo);
                txtCorreo.Text = "";
                txtCorreo.Focus();
            }
            else
            {
                txtCorreo.Focus();
            }
        }

        private void btnQuitarCorreo_Click(object sender, EventArgs e)
        {
            if (validador.validarQuitarItemLista(lstCorreosElectronicos, "No hay correo para quitar", "Seleccione un correo", "Atención"))
            { lstCorreosElectronicos.Items.RemoveAt(lstCorreosElectronicos.SelectedIndex); }
            else
            { btnQuitarCorreo.Focus();}
        }
        
        private void btnAgregarTelefono_Click(object sender, EventArgs e)
        {
            if (validador.validarString(txtTelefono,"Ingrese un número de teléfono","Atención"))
            {
                TipoTelefono tipoTelefono = new TipoTelefono(Convert.ToInt32(cmbTipoTelefono.SelectedValue), cmbTipoTelefono.SelectedItem.ToString());
                Telefono telefono = new Telefono(txtTelefono.Text.Trim(), tipoTelefono);
                lstTelefonos.Items.Add(telefono);
                txtTelefono.Text = "";
                txtTelefono.Focus();
            }
            else
            {
                txtTelefono.Focus();
            }
        }

        private void btnAgregarCobertura_Click(object sender, EventArgs e)
        {
            if(validador.validarString(txtNumeroAfiliado,"Ingrese el número de afiliado","Atención"))
            {
                CoberturaMedica cobertura=(CoberturaMedica)cmbCobertura.SelectedItem;
                String numeroAfiliado=txtNumeroAfiliado.Text.Trim();
                Afiliacion afiliacion = new Afiliacion(numeroAfiliado, cobertura);
                lstAfiliaciones.Items.Add(afiliacion);
                txtNumeroAfiliado.Text = "";
            }
            else
            {
                txtNumeroAfiliado.Focus();
            }
        }

        private void btnQuitarTelefono_Click(object sender, EventArgs e)
        {
            if (validador.validarQuitarItemLista(lstTelefonos, "No hay teléfono para quitar", "Seleccione un teléfono", "Atención"))
            { lstTelefonos.Items.RemoveAt(lstTelefonos.SelectedIndex); }
            else
            { btnQuitarTelefono.Focus(); }
        }

        private void btnQuitarCobertura_Click(object sender, EventArgs e)
        {
            if (validador.validarQuitarItemLista(lstAfiliaciones, "No hay afiliaciones para quitar", "Seleccione una afiliacion", "Atención"))
            { lstAfiliaciones.Items.RemoveAt(lstTelefonos.SelectedIndex);}
            else
            {btnQuitarCobertura.Focus();}
        }

        private void cmbTipoTelefono_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmbCobertura_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtApellido_Enter(object sender, EventArgs e)
        {
            seleccionarTexto(txtApellido);
        }

        private void seleccionarTexto(TextBox txt)
        {
            txt.SelectionStart = 0;
            txt.SelectionLength = txt.TextLength;
        }

        private void txtNumeroPaciente_Enter(object sender, EventArgs e)
        {
            seleccionarTexto(txtNumeroPaciente);
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            seleccionarTexto(txtNombre);
        }

        private void txtNumDocumento_Enter(object sender, EventArgs e)
        {
            seleccionarTexto(txtNumDocumento);
        }

        private void txtCalle_Enter(object sender, EventArgs e)
        {
            seleccionarTexto(txtCalle);
        }

        private void txtBusquedaCobertura_Enter(object sender, EventArgs e)
        {
            seleccionarTexto(txtBusquedaCobertura);
        }

        private void txtNumeroCalle_Enter(object sender, EventArgs e)
        {
            seleccionarTexto(txtNumeroCalle);
        }

        private void txtPiso_Enter(object sender, EventArgs e)
        {
            seleccionarTexto(txtPiso);
        }

        private void txtDepto_Enter(object sender, EventArgs e)
        {
            seleccionarTexto(txtDepto);
        }

        private void txtCorreo_Enter(object sender, EventArgs e)
        {
            seleccionarTexto(txtCorreo);
        }

        private void txtTelefono_Enter(object sender, EventArgs e)
        {
            seleccionarTexto(txtTelefono);
        }
        
        private void btnBuscarDepartamento_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBuscarLocalidad_Click(object sender, EventArgs e)
        {
            frmLocalidad vtLocalidad = new frmLocalidad();
            Provincia provincia = (Provincia)cmbProvincias.SelectedItem;
            Departamento departamento = (Departamento)cmbDepartamentos.SelectedItem;
            vtLocalidad.mostrarProvinciaYDepartamento(provincia, departamento);
            vtLocalidad.ShowDialog();
        }

        private void btnBuscarBarrio_Click(object sender, EventArgs e)
        {
            Provincia provincia = new Provincia();
            provincia=(Provincia)cmbProvincias.SelectedItem;
            
            Departamento departamento = new Departamento();
            departamento= (Departamento)cmbDepartamentos.SelectedItem;
            
            Localidad localidad = new Localidad();
            localidad=(Localidad)cmbLocalidades.SelectedItem;
            
            departamento.Provincia=provincia;
            localidad.Departamento=departamento;

            frmBarrio vtBarrio = new frmBarrio(localidad);
            vtBarrio.ShowDialog();

            int idLocalidad=Convert.ToInt32(cmbLocalidades.SelectedValue);
            mostrarBarriosPorLocalidad(idLocalidad);
        }

        

        private void btnBuscarProvincia_Click(object sender, EventArgs e)
        {
            frmProvincia vtProvincia = new frmProvincia();
            vtProvincia.ShowDialog();
        }

        private void btnBuscarPaciente_Click(object sender, EventArgs e)
        {
            String parametro = txtBuscarPaciente.Text.Trim();

            GestorDePersonas gestorPersonas=new GestorDePersonas();
            List<Paciente> lsPacientes = gestorPersonas.obtenerPacientesPorBusqueda(parametro);

            if (lsPacientes != null)
            {
                frmBuscarPaciente vtBuscarPaciente = new frmBuscarPaciente(lsPacientes);
                vtBuscarPaciente.pacienteAPasar += new frmBuscarPaciente.pasarPaciente(mostrarPacienteSeleccionado);

                vtBuscarPaciente.ShowDialog();
            }
            else
            {
                MessageBox.Show("No hay pacientes registrados", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void mostrarPacienteSeleccionado(String numPaciente)
        {
            GestorDePersonas gestorPersonas=new GestorDePersonas();
            Paciente paciente = gestorPersonas.obtenerPacientePorNumero(numPaciente);

            txtNumeroPaciente.Text = paciente.Numero;
            numeroPacViejo = paciente.Numero;

            dtpFechaAlta.Value = paciente.FechaAlta;
            dtpFechaNacimiento.Value = paciente.FechaNacimiento;
            txtNombre.Text = paciente.Nombre;
            txtApellido.Text = paciente.Apellido;
            
            txtNumDocumento.Text = paciente.NumeroDocumento;
            nroDniViejo = paciente.NumeroDocumento;

            cmbTipoDocumento.SelectedValue = paciente.TipoDocumento.IdTipoDocumento;
            tipoDniViejo = paciente.TipoDocumento.IdTipoDocumento;

            cmbSexo.SelectedValue = paciente.Sexo.IdSexo;
            txtCalle.Text = paciente.Domicilio.Calle;
            txtNumeroCalle.Text = paciente.Domicilio.Numero;
            txtPiso.Text = paciente.Domicilio.Piso;
            txtDepto.Text = paciente.Domicilio.Departamento;
            txtTorre.Text = paciente.Domicilio.Torre;
            idPersonaGrilla = paciente.Idpersona;
            idPacientegrilla = paciente.IdPaciente;

            cmbProvincias.SelectedValue = paciente.Domicilio.Barrio.Localidad.Departamento.Provincia.IdProvincia;
            cmbDepartamentos.SelectedValue = paciente.Domicilio.Barrio.Localidad.Departamento.IdDepartamento;
            cmbLocalidades.SelectedValue= paciente.Domicilio.Barrio.Localidad.Idlocalidad;
            cmbBarrios.SelectedValue = paciente.Domicilio.Barrio.IdBarrio;

            lstTelefonos.Items.Clear();
            if (paciente.Telefonos.Count > 0)
            { 
                foreach(Telefono telefono in paciente.Telefonos)
                {
                    lstTelefonos.Items.Add(telefono);
                }
            }

            lstCorreosElectronicos.Items.Clear();
            if (paciente.Correos.Count > 0)
            {
                foreach(Correo correo in paciente.Correos)
                {
                    lstCorreosElectronicos.Items.Add(correo);
                }
            }

            lstAfiliaciones.Items.Clear();
            if (paciente.Afiliaciones.Count > 0)
            {
                foreach (Afiliacion afiliacion in paciente.Afiliaciones)
                {
                    lstAfiliaciones.Items.Add(afiliacion);
                }
            }
            cmbNombreUsuario.Items.Clear();
            cmbNombreUsuario.Items.Add(paciente.Usuario);
            cmbNombreUsuario.SelectedIndex = 0;

            cmbCuenta.SelectedValue = paciente.Usuario.Cuenta.IdCuenta;
            txtContrasenia.Text = paciente.Usuario.Contrasenia.ToString();
            cmbEstado.SelectedValue = paciente.Usuario.Estado.IdEstado;

        }

        private void cmbTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Pacientes_Enter(object sender, EventArgs e)
        {

        }

        private void btnFiltrarCobertura_Click(object sender, EventArgs e)
        {
            String parametro=txtBusquedaCobertura.Text.Trim();
            if (!parametro.Equals(""))
            {
                GestorDePersonas gestorPersonas = new GestorDePersonas();
                List<CoberturaMedica> lstCoberturas = gestorPersonas.obtenerCoberturasPorBusqueda(parametro);
                if (lstCoberturas.Count > 0)
                { 
                    
                }
            }
            else
            {
                MessageBox.Show("Ingrese algún datos de la cobertura", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            validador.habilitarControles(this, false);
            validador.manejarBotonesABM(btnCancelar, btnAgregar, btnCancelar, btnModificar, btnEliminar,
                                        btnGuardar, btnSalir);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            validador.habilitarControles(this, true);
            validador.manejarBotonesABM(btnModificar, btnAgregar, btnCancelar, btnModificar, btnEliminar,
                                        btnGuardar, btnSalir);
            esNuevo = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (validador.validarString(txtNumeroPaciente, "Seleccione un paciente", "Atención"))
            {
                eliminarPaciente(txtNumeroPaciente.Text.Trim());
                validador.limpiarTexBox(this);
                validador.habilitarControles(this, false);
                validador.manejarBotonesABM(btnEliminar, btnAgregar, btnCancelar, btnModificar, btnEliminar,
                                            btnGuardar, btnSalir);
                
            }
            else
            {
                txtBuscarPaciente.Focus();
            }
            
        }

        private void eliminarPaciente(String numeroPaciente)
        {
            Paciente paciente = new Paciente();
            paciente.Numero = numeroPaciente;
            GestorDePersonas gestorPersonas=new GestorDePersonas();
            if (gestorPersonas.tomarPacienteAEliminar(paciente))
                MessageBox.Show("Paciente eliminado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo eliminar el paciente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void txtContrasenia_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private Boolean modificarPaciente()
        {
            String numPaciente;
            if (validador.validarNumeroPaciente(txtNumeroPaciente, "Ingrese el número de paciente", "Atención"))
            { numPaciente = txtNumeroPaciente.Text.Trim(); }
            else { return false; }

            DateTime fechaAlta = dtpFechaAlta.Value.Date;
            DateTime fechaNacimiento = dtpFechaNacimiento.Value.Date;

            String nombre;
            if (validador.validarString(txtNombre, "Ingrese el nombre del paciente", "Atención"))
            { nombre = txtNombre.Text.Trim(); }
            else { return false; }

            String apellido;
            if (validador.validarString(txtApellido, "Ingrese el apellido del paciente", "Atención"))
            { apellido = txtApellido.Text.Trim(); }
            else { return false; }

            String numeroDocumento;
            if (validador.validarString(txtNumDocumento, "Ingrese el número de documento", "Atención"))
            { numeroDocumento = txtNumDocumento.Text.Trim(); }
            else { return false; }

            //Tipo de documento
            int idTipoDoc = Convert.ToInt32(cmbTipoDocumento.SelectedValue);
            String nombreTipoDoc = cmbTipoDocumento.Text;
            TipoDocumento tipoDocumento = new TipoDocumento(idTipoDoc, nombreTipoDoc);

            //Sexo
            int idSexo = Convert.ToInt32(cmbSexo.SelectedValue);
            String nombreSexo = cmbSexo.Text;
            Sexo sexo = new Sexo(idSexo, nombreSexo);

            //Barrio
            int idBarrio = Convert.ToInt32(cmbBarrios.SelectedValue);
            String nombreBarrio = cmbBarrios.Text;
            Barrio barrio = new Barrio(idBarrio, nombreBarrio);

            //Domicilio
            String calle;
            if (validador.validarString(txtCalle, "Ingrese el nombre de la calle", "Atencion"))
            { calle = txtCalle.Text.ToString(); }
            else { return false; }

            String numeroCalle;
            if (validador.validarString(txtNumeroCalle, "Ingrese número de la calle", "Atencion"))
            { numeroCalle = txtNumeroCalle.Text.Trim(); }
            else { return false; }

            String piso = txtPiso.Text.Trim();
            String depto = txtDepto.Text.Trim();
            String torre = txtTorre.Text.Trim();
            Domicilio domicilio = new Domicilio(calle, numeroCalle, depto, piso, torre, barrio);

            String comentario = txtComentario.Text.Trim();

            List<Correo> correos = new List<Correo>();
            foreach (Correo correo in lstCorreosElectronicos.Items)
            {
                correos.Add(correo);
            }

            List<Telefono> telefonos = new List<Telefono>();
            foreach (Telefono telefono in lstTelefonos.Items)
            {
                telefonos.Add(telefono);
            }

            List<Afiliacion> afiliaciones = new List<Afiliacion>();
            foreach (Afiliacion afiliacion in lstAfiliaciones.Items)
            {

                afiliaciones.Add(afiliacion);
            }

            //usuario.
            Cuenta cuenta = new Cuenta();
            cuenta = (Cuenta)cmbCuenta.SelectedItem;

            EstadoUsuario estadoUsuario = new EstadoUsuario();
            estadoUsuario = (EstadoUsuario)cmbEstado.SelectedItem;

            String contrasenia;
            if (validador.validarString(txtContrasenia, "Ingrese la contraseña", "Atención"))
            { contrasenia = txtContrasenia.Text.Trim(); }
            else { return false; }

            int idPer = idPersonaGrilla;
            int idPac = idPacientegrilla;
            String nombreUsuario = cmbNombreUsuario.Text;
            String comentarioUsuario = txtComentarioUsuario.Text.Trim();
            Usuario usuario = new Usuario(nombreUsuario, contrasenia, cuenta, comentarioUsuario, estadoUsuario);

            Paciente paciente = new Paciente(idPer, nombre, apellido, fechaAlta, numeroDocumento, tipoDocumento, fechaNacimiento, telefonos,
                                            correos, domicilio, usuario, comentario, sexo, numPaciente, afiliaciones, idPac);
            
            GestorDePersonas gestorPersonas=new GestorDePersonas();
            string mensaje = gestorPersonas.tomarModificacionPaciente(paciente, numeroPacViejo, tipoDniViejo, nroDniViejo);
            if (mensaje.Equals("Se modifico"))
            {
                MessageBox.Show("Paciente modificado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                if (mensaje.Equals("No se pudo modificar"))
                {
                    MessageBox.Show("El Paciente no se pudo modificar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                else
                {
                    if (mensaje.Equals("error de tipo y nro de DNI"))
                    {

                        MessageBox.Show("La combinacion de tipo de DNI y numero de DNI ya existe", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNumDocumento.Focus();
                        return false;
                    }
                    else
                    {
                        if (mensaje.Equals("error de Numero de Paciente"))
                        {
                            MessageBox.Show("El Numero del paciente ya existe", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtNumeroPaciente.Focus();
                            return false;
                        }
                        else
                        {
                            MessageBox.Show("El Numero del Paciente y la combinacion de tipo y numero de DNI ya existe", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtNumeroPaciente.Focus();
                            return false;
                        }

                    }
                }

            }
 
        }
    }
}
