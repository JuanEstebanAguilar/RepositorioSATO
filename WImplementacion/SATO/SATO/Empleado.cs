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
    public partial class frmEmpleado : Form
    {
        private String ESTADOCONTROLES = "habilitar";
        private int idEmpleadoSeleccionado;
        private int idPersonaSeleccionado;
        private String legajoViejo;
        private int tipoDniViejo;
        private String nroDniViejo;
        private Boolean esNuevo;
        private Validador validador = new Validador();
        public frmEmpleado()
        {
            InitializeComponent();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            frmTiposDocumento eTipoDocumento = new frmTiposDocumento();
            eTipoDocumento.ShowDialog();
            mostrarTiposDocumento();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Provincia provincia = new Provincia();
            provincia = (Provincia)cmbProvinciaEmpleado.SelectedItem;

            Departamento departamento = new Departamento();
            departamento = (Departamento)cmbDepartamentoEmpleado.SelectedItem;

            Localidad localidad = new Localidad();
            localidad = (Localidad)cmbLocalidadEmpleado.SelectedItem;

            departamento.Provincia = provincia;
            localidad.Departamento = departamento;

            frmBarrio vtBarrio = new frmBarrio(localidad);
            vtBarrio.ShowDialog();

            int idLocalidad = Convert.ToInt32(cmbLocalidadEmpleado.SelectedValue);
            mostrarBarriosPorLocalidad(idLocalidad);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void mostrarProvincias()
        {
            GestorDePersonas gestorPersonas = new GestorDePersonas();
            cmbProvinciaEmpleado.Items.Clear();
            cmbProvinciaEmpleado.ValueMember = "idProvincia";
            cmbProvinciaEmpleado.DisplayMember = "nombre";
            cmbProvinciaEmpleado.DataSource = gestorPersonas.obtenerProvincias();
        }

        private void cmbProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            mostrarDepartamentosPorProvincia((int)cmbProvinciaEmpleado.SelectedValue);
        }
        private void mostrarDepartamentosPorProvincia(int idProvincia)
        {
            GestorDePersonas gestorPersonas = new GestorDePersonas();
            cmbDepartamentoEmpleado.ValueMember = "idDepartamento";
            cmbDepartamentoEmpleado.DisplayMember = "nombre";
            cmbDepartamentoEmpleado.DataSource = gestorPersonas.obtenerDepartamentosPorProvincia(idProvincia);
        }
        private void mostrarLocalidadesPorDepartamento(int idDepartamento)
        {
            GestorDePersonas gestorPersonas = new GestorDePersonas();
            cmbLocalidadEmpleado.ValueMember = "idLocalidad";
            cmbLocalidadEmpleado.DisplayMember = "nombre";
            cmbLocalidadEmpleado.DataSource = gestorPersonas.obtenerLocalidadesPorDepartamento(idDepartamento);
        }
        private void mostrarBarriosPorLocalidad(int idLocalidad)
        {
            GestorDePersonas gestorPersonas = new GestorDePersonas();
            cmbBarrioEmpleado.ValueMember = "idBarrio";
            cmbBarrioEmpleado.DisplayMember = "nombre";
            cmbBarrioEmpleado.DataSource = gestorPersonas.obtenerBarriosPorLocalidad(idLocalidad);
        }
        private void mostrarTiposTelefono()
        {
            GestorDePersonas GestorPersonas = new GestorDePersonas();
            cmbTipoTelefonoEmpleado.ValueMember = "idTipoTelefono";
            cmbTipoTelefonoEmpleado.DisplayMember = "nombre";
            cmbTipoTelefonoEmpleado.DataSource = GestorPersonas.obtenerTiposTelefono();
        }
        private void mostrarTiposDocumento()
        {
            GestorDePersonas gestorPersonas = new GestorDePersonas();
            cmbTipoDocumentoEmpleado.ValueMember = "idTipoDocumento";
            cmbTipoDocumentoEmpleado.DisplayMember = "nombre";
            cmbTipoDocumentoEmpleado.DataSource = gestorPersonas.obtenerTiposDocumento();
        }
        private void btnAgregarEmail_Click(object sender, EventArgs e)
        {
            if (validador.validarString(txtEmail, "Ingrese una dirección de correo", "Atención"))
            {
                Correo correo = new Correo(txtEmail.Text.Trim());
                lstEmail.Items.Add(correo);
                txtEmail.Text = "";
                txtEmail.Focus();
            }
            else
            {
                txtEmail.Focus();
            }
        }

        private void btnQuitarEmail_Click(object sender, EventArgs e)
        {
            if (validador.validarQuitarItemLista(lstEmail, "No hay correo para quitar", "Seleccione un correo", "Atención"))
            { lstEmail.Items.RemoveAt(lstEmail.SelectedIndex); }
            else
            { btnQuitarEmail.Focus(); }
        }
        private void habilitarControles(String estado)
        {
            foreach (Control textBox in this.Controls)
            {
                if (textBox is TextBox && estado.Equals("habilitar"))
                {
                    textBox.Enabled = true;
                }
                if (textBox is TextBox && estado.Equals("deshabilitar"))
                {
                    textBox.Enabled = false;
                }
            }

            foreach (Control button in this.Controls)
            {
                if (button is Button && estado.Equals("habilitar"))
                {
                    button.Enabled = true;
                }
                if (button is Button && estado.Equals("deshabilitar"))
                {
                    button.Enabled = false;
                }
                
            }

            foreach (Control group in this.Controls)
            {
                if (group is GroupBox && estado.Equals("habilitar"))
                {
                    group.Enabled = true;
                    if (group.HasChildren)
                    {
                        foreach (Control textBoxChild in this.Controls)
                        {
                            if (textBoxChild is TextBox && estado.Equals("habilitar"))
                            {
                                textBoxChild.Enabled = true;
                            }
                            if (textBoxChild is TextBox && estado.Equals("deshabilitar"))
                            {
                                textBoxChild.Enabled = false;
                            }
                        }
                    }

                }
                if (group is GroupBox && estado.Equals("deshabilitar"))
                {
                    group.Enabled = false;
                }
            }
            foreach (Control comboBox in this.Controls)
            {
                if (comboBox is ComboBox && estado.Equals("habilitar"))
                {
                    comboBox.Enabled = true;
                }
                if (comboBox is ComboBox && estado.Equals("deshabilitar"))
                {
                    comboBox.Enabled = false;
                }
            }
            foreach (Control dateTimePicker in this.Controls)
            {
                if (dateTimePicker is DateTimePicker && estado.Equals("habilitar"))
                {
                    dateTimePicker.Enabled = true;
                }
                if (dateTimePicker is DateTimePicker && estado.Equals("deshabilitar"))
                {
                    dateTimePicker.Enabled = false;
                }
            }
        }

        private void Empleado_Load_1(object sender, EventArgs e)
        {
            mostrarProvincias();
            mostrarTiposDocumento();
            mostrarTiposTelefono();
            mostrarSexos();
            mostrarEstadosUsuario();
            mostrarCuentasUsuario();
            

         
            ESTADOCONTROLES = "deshabilitar";
            habilitarControles(ESTADOCONTROLES);
            btnAgregarEmpleado.Enabled = true;
            btnSalir.Enabled = true;
            grpEmpleado.Enabled = true;
            txtBusquedaEmpleado.Enabled = true;
            btnBuscarEmpleado.Enabled = true;

            ToolTip toolTip1 = new ToolTip();

            // Set up the delays for the ToolTip.
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip1.ShowAlways = true;

            // Set up the ToolTip text for the Button and Checkbox.
            toolTip1.SetToolTip(btnAgregarEmpleado, "Agrega un Empleado");
            toolTip1.SetToolTip(btnCancelar, "Cancela la acción que se esta realizando");
            toolTip1.SetToolTip(btnModificarEmpleado, "Habilita la modificación del Empleado");
            toolTip1.SetToolTip(btnQuitarEmpleado, "Elimina el Empleado");
            toolTip1.SetToolTip(btnGuardarEmpleado, "Guarda el Empleado creado o modificado");
            toolTip1.SetToolTip(btnSalir, "Sale de la ventana");

        }
        private void limpiarTextBox()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = "";
                }
                if (control is GroupBox)
                {
                    foreach (Control controlHijo in control.Controls)
                    {
                        if (controlHijo is TextBox)
                        {
                            controlHijo.Text = "";
                        }
                        if (controlHijo is ListBox)
                        {
                            ListBox controlList = (ListBox)controlHijo;
                            controlList.Items.Clear();
                        }
                    }
                }
            }
        }

        private void btnAgregarTelefono_Click(object sender, EventArgs e)
        {
            if (validador.validarString(txtTelefonoEmpleado, "Ingrese un número de teléfono", "Atención"))
            {
                TipoTelefono tipoTelefono = new TipoTelefono(Convert.ToInt32(cmbTipoTelefonoEmpleado.SelectedValue), cmbTipoTelefonoEmpleado.SelectedItem.ToString());
                Telefono telefono = new Telefono(txtTelefonoEmpleado.Text.Trim(), tipoTelefono);
                lstTelefonos.Items.Add(telefono);
                txtTelefonoEmpleado.Text = "";
                txtTelefonoEmpleado.Focus();
            }
            
        }

        private void btnQuitarTelefono_Click(object sender, EventArgs e)
        {
            if (validador.validarQuitarItemLista(lstTelefonos, "No hay teléfono para quitar", "Seleccione un teléfono", "Atención"))
            { lstTelefonos.Items.RemoveAt(lstTelefonos.SelectedIndex); }
            else
            { btnQuitarTelefono.Focus(); }
        }

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            limpiarTextBox();
            ESTADOCONTROLES = "habilitar";
            habilitarControles(ESTADOCONTROLES);
            grpEmpleado.Enabled = true;
            txtBusquedaEmpleado.Enabled = true;
            btnBuscarEmpleado.Enabled = true;
            btnAgregarEmpleado.Enabled = false;
            btnModificarEmpleado.Enabled = false;
            btnQuitarEmpleado.Enabled = false;
            esNuevo = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarTextBox();
            ESTADOCONTROLES = "deshabilitar";
            habilitarControles(ESTADOCONTROLES);
            btnAgregarEmpleado.Enabled = true;
            btnSalir.Enabled = true;
            grpEmpleado.Enabled = true;
            
            txtBusquedaEmpleado.Enabled = true;
            btnBuscarEmpleado.Enabled = true;
        }

        private void cmbDepartamentoEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            mostrarLocalidadesPorDepartamento((int)cmbDepartamentoEmpleado.SelectedValue);
        }
        private void cmbLocalidadEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            mostrarBarriosPorLocalidad((int)cmbLocalidadEmpleado.SelectedValue);
        }
        private void seleccionarTexto(TextBox txt)
        {
            txt.SelectionStart = 0;
            txt.SelectionLength = txt.TextLength;
        }

        private void txtLegajoEmpleado_Enter(object sender, EventArgs e)
        {
            seleccionarTexto(txtLegajoEmpleado);
        }

        private void txtNombreempleado_Enter(object sender, EventArgs e)
        {
            seleccionarTexto(txtNombreEmpleado);
        }

        private void txtApellidoEmpleado_Enter(object sender, EventArgs e)
        {
            seleccionarTexto(txtApellidoEmpleado);  
        }

        private void txtNroDocumentoEmpleado_Enter(object sender, EventArgs e)
        {
            seleccionarTexto(txtNroDocumentoEmpleado);
        }

        private void txtCalleEmpleado_Enter(object sender, EventArgs e)
        {
            seleccionarTexto(txtCalleEmpleado);
        }

        private void txtNumero_Enter(object sender, EventArgs e)
        {
            seleccionarTexto(txtNumero);
        }

        private void txtPiso_Enter(object sender, EventArgs e)
        {
            seleccionarTexto(txtPiso);
        }

        private void txtDpto_Enter(object sender, EventArgs e)
        {
            seleccionarTexto(txtDpto);
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            seleccionarTexto(txtEmail);
        }

        private void txtTelefonoEmpleado_Enter(object sender, EventArgs e)
        {
            seleccionarTexto(txtTelefonoEmpleado);
        }

        private void txtProfesional_Enter(object sender, EventArgs e)
        {
            seleccionarTexto(txtBusquedaEmpleado);
        }
        private void mostrarSexos()
        {
            GestorDePersonas gestorPersonas = new GestorDePersonas();
            cmbSexoEmpleado.ValueMember = "idSexo";
            cmbSexoEmpleado.DisplayMember = "nombre";
            cmbSexoEmpleado.DataSource = gestorPersonas.obtenerSexos();
        }
        private void mostrarCuentasUsuario()
        {
            GestorDePersonas gestorPersonas = new GestorDePersonas();
            cmbCuentaEmpleado.ValueMember = "idCuenta";
            cmbCuentaEmpleado.DisplayMember = "nombre";
            cmbCuentaEmpleado.DataSource = gestorPersonas.obtenerCuentas();
        }
        private void mostrarEstadosUsuario()
        {
            GestorDePersonas gestorPersonas = new GestorDePersonas();
            cmbEstadoEmpleado.ValueMember = "idEstado";
            cmbEstadoEmpleado.DisplayMember = "nombre";
            cmbEstadoEmpleado.DataSource = gestorPersonas.obtenerEstadosUsuarios();
        }
        private Boolean guardarEmpleado()
        {
            String legajoEmp;
            if (validador.validarNumeroPaciente(txtLegajoEmpleado, "Ingrese el número de empleado", "Atención"))
            { legajoEmp = txtLegajoEmpleado.Text.Trim(); }
            else { return false; }

            DateTime fechaAltaEmp = dtpFechaAltaEmpleado.Value.Date;
            DateTime fechaNacimientoEmp = dtpFechaNacEmpleado.Value.Date;

            String nombreEmp;
            if (validador.validarString(txtNombreEmpleado, "Ingrese el nombre del empleado", "Atención"))
            { nombreEmp = txtNombreEmpleado.Text.Trim(); }
            else { return false; }

            String apellidoEmp;
            if (validador.validarString(txtApellidoEmpleado, "Ingrese el apellido del empleado", "Atención"))
            { apellidoEmp = txtApellidoEmpleado.Text.Trim(); }
            else { return false; }
            String numeroDocumentoEmp;
            if (validador.validarString(txtNroDocumentoEmpleado, "Ingrese el número de documento", "Atención"))
            { numeroDocumentoEmp = txtNroDocumentoEmpleado.Text.Trim(); }
            else { return false; }

            int idTipoDocEmp = Convert.ToInt32(cmbTipoDocumentoEmpleado.SelectedValue);
            String nombreTipoDocEmp = cmbTipoDocumentoEmpleado.Text;
            TipoDocumento tipoDocumentoEmp = new TipoDocumento(idTipoDocEmp, nombreTipoDocEmp);



            String nombreSexoEmp = cmbSexoEmpleado.Text;
            int idSexoEmp = (int)cmbSexoEmpleado.SelectedValue;
            Sexo sexoEmp = new Sexo(idSexoEmp, nombreSexoEmp);


            int idBarrioEmp = Convert.ToInt32(cmbBarrioEmpleado.SelectedValue);
            String nombreBarrioEmp = cmbBarrioEmpleado.Text;
            Barrio barrioEmp = new Barrio(idBarrioEmp, nombreBarrioEmp);


            String calleEmp;
            if (validador.validarString(txtCalleEmpleado, "Ingrese el nombre de la calle", "Atencion"))
            { calleEmp = txtCalleEmpleado.Text.ToString().Trim(); }
            else { return false; }

            String numeroCalleEmp;
            if (validador.validarString(txtNumero, "Ingrese número de la calle", "Atencion"))
            { numeroCalleEmp = txtNumero.Text.Trim(); }
            else { return false; }

            String pisoEmp = txtPiso.Text.Trim();
            String deptoEmp = txtDpto.Text.Trim();
            String torreEmp = txtTorreEmpleado.Text.Trim();
            Domicilio domicilioEmp = new Domicilio(calleEmp, numeroCalleEmp, deptoEmp, pisoEmp, torreEmp, barrioEmp);

            List<Correo> correosEmp = new List<Correo>();
            foreach (Correo correo in lstEmail.Items)
            {
                correosEmp.Add(correo);
            }

            List<Telefono> telefonosEmp = new List<Telefono>();
            foreach (Telefono telefono in lstTelefonos.Items)
            {
                telefonosEmp.Add(telefono);
            }


            String nombreCuentaEmp = cmbCuentaEmpleado.SelectedItem.ToString();
            int idCuentaEmp = (int)cmbCuentaEmpleado.SelectedValue;
            Cuenta cuentaEmp = new Cuenta(idCuentaEmp, nombreCuentaEmp);

            String nombreEstadoEmp = cmbCuentaEmpleado.SelectedItem.ToString();
            int idEstadoEmp = (int)cmbEstadoEmpleado.SelectedValue;
            EstadoUsuario estadoUsuarioEmp = new EstadoUsuario(idEstadoEmp, nombreEstadoEmp);

            String nombreUsuarioEmp;
            if (validador.validarString(txtNombreUsuarioEmpleado, "Ingrese el nombre de Usuario", "Atención"))
            { nombreUsuarioEmp = txtNombreUsuarioEmpleado.Text.Trim(); }
            else { return false; }

            String contraseniaEmp;
            if (validador.validarString(txtContraseniaEmpleado, "Ingrese la contraseña", "Atención"))
            { contraseniaEmp = txtContraseniaEmpleado.Text.Trim(); }
            else { return false; }

            String comentarioUsuarioEmp = txtComentarioUsuarioEmpleado.Text.Trim();

            Usuario usuarioEmp = new Usuario(nombreUsuarioEmp, contraseniaEmp, cuentaEmp, comentarioUsuarioEmp, estadoUsuarioEmp);

            Empleado e = new Empleado(nombreEmp, apellidoEmp, fechaAltaEmp, numeroDocumentoEmp, tipoDocumentoEmp, fechaNacimientoEmp, telefonosEmp, correosEmp, domicilioEmp, usuarioEmp, comentarioUsuarioEmp, sexoEmp, legajoEmp);

            GestorDePersonas gestorPersonas = new GestorDePersonas();
            if (gestorPersonas.tomarEmpleado(e)) 
            {
                return true;
            }
            else
            {
                MessageBox.Show("El empleado ya se encuentra registrado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }

        private void btnGuardarEmpleado_Click(object sender, EventArgs e)
        {
            if (esNuevo == true)
            {
                if (guardarEmpleado())
                {
                    limpiarTextBox();
                    ESTADOCONTROLES = "deshabilitar";
                    habilitarControles(ESTADOCONTROLES);
                    btnAgregarEmpleado.Enabled = true;
                    btnSalir.Enabled = true;
                    grpEmpleado.Enabled = true;

                    txtBusquedaEmpleado.Enabled = true;
                    btnBuscarEmpleado.Enabled = true;
                    MessageBox.Show("El empleado se registro exitosamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if (modificarEmpleado())
                {
                    limpiarTextBox();
                    ESTADOCONTROLES = "deshabilitar";
                    habilitarControles(ESTADOCONTROLES);
                    btnAgregarEmpleado.Enabled = true;
                    btnSalir.Enabled = true;
                    grpEmpleado.Enabled = true;

                    txtBusquedaEmpleado.Enabled = true;
                    btnBuscarEmpleado.Enabled = true;

                }
            }

        }
        private void btnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            String parametro = txtBusquedaEmpleado.Text.Trim();

            GestorDePersonas gestorPersonas = new GestorDePersonas();
            List<Empleado> lsEmpleados = gestorPersonas.obtenerEmpleadosPorBusqueda(parametro);

            if (lsEmpleados != null)
            {
                BuscarEmpleado vtBuscarEmpleado = new BuscarEmpleado(lsEmpleados);
                vtBuscarEmpleado.empleadoAPasar += new BuscarEmpleado.pasarEmpleado(mostrarEmpleadoGrilla);

                vtBuscarEmpleado.ShowDialog();
            }
            else
            {
                MessageBox.Show("No hay empleados registrados", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        

        
        private void mostrarEmpleadoGrilla(string leg)
        {
            GestorDePersonas gestorPersonas = new GestorDePersonas();
            Empleado empleado= gestorPersonas.obtenerEmpleadoPorLegajo(leg);

            idEmpleadoSeleccionado = empleado.IdEmpleado;
            idPersonaSeleccionado = empleado.Idpersona;
            txtLegajoEmpleado.Text= empleado.Legajo;

            legajoViejo = empleado.Legajo;

            dtpFechaAltaEmpleado.Value= empleado.FechaAlta;
            dtpFechaNacEmpleado.Value= empleado.FechaNacimiento;
            txtNombreEmpleado.Text=empleado.Nombre;
            txtApellidoEmpleado.Text=empleado.Apellido;
            txtNroDocumentoEmpleado.Text= empleado.NumeroDocumento;

            nroDniViejo = empleado.NumeroDocumento;

            cmbTipoDocumentoEmpleado.SelectedValue= empleado.TipoDocumento.IdTipoDocumento;

            tipoDniViejo = empleado.TipoDocumento.IdTipoDocumento;

            cmbSexoEmpleado.SelectedValue= empleado.Sexo.IdSexo;
            txtCalleEmpleado.Text= empleado.Domicilio.Calle;
            txtNumero.Text= empleado.Domicilio.Numero;
            txtPiso.Text= empleado.Domicilio.Piso;
            txtDpto.Text= empleado.Domicilio.Departamento;
            txtTorreEmpleado.Text= empleado.Domicilio.Torre;

            txtNombreUsuarioEmpleado.Text = empleado.Usuario.Nombre;
            txtContraseniaEmpleado.Text = empleado.Usuario.Contrasenia;
            txtComentarioUsuarioEmpleado.Text = empleado.Usuario.Comentario;

            cmbProvinciaEmpleado.SelectedValue= empleado.Domicilio.Barrio.Localidad.Departamento.Provincia.IdProvincia;
            cmbDepartamentoEmpleado.SelectedValue= empleado.Domicilio.Barrio.Localidad.Departamento.IdDepartamento;
            cmbLocalidadEmpleado.SelectedValue= empleado.Domicilio.Barrio.Localidad.Idlocalidad;
            cmbBarrioEmpleado.SelectedValue= empleado.Domicilio.Barrio.IdBarrio;
            cmbCuentaEmpleado.SelectedValue = empleado.Usuario.Cuenta.IdCuenta;
            cmbEstadoEmpleado.SelectedValue = empleado.Usuario.Estado.IdEstado;

            lstTelefonos.Items.Clear();
            if(empleado.Telefonos.Count > 0)
            {
                
                foreach(Telefono telefono in empleado.Telefonos)
                {
                    lstTelefonos.Items.Add(telefono);
                }
            }

            lstEmail.Items.Clear();
            if(empleado.Correos.Count > 0)
            {
                
                
                foreach(Correo correo in empleado.Correos)
                {
                    lstEmail.Items.Add(correo);
                }
            }
            ESTADOCONTROLES = "deshabilitar";
            habilitarControles(ESTADOCONTROLES);
            btnAgregarEmpleado.Enabled = true;
            btnModificarEmpleado.Enabled = true;
            btnSalir.Enabled = true;
            grpEmpleado.Enabled = true;
            btnQuitarEmpleado.Enabled = true;
            txtBusquedaEmpleado.Enabled = true;
            btnBuscarEmpleado.Enabled = true;
        }
        private Boolean modificarEmpleado()
        {
            String legajoEmp;
            if (validador.validarNumeroPaciente(txtLegajoEmpleado, "Ingrese el número de empleado", "Atención"))
            { legajoEmp = txtLegajoEmpleado.Text.Trim(); }
            else { return false; }

            DateTime fechaAltaEmp = dtpFechaAltaEmpleado.Value.Date;
            DateTime fechaNacimientoEmp = dtpFechaNacEmpleado.Value.Date;

            String nombreEmp;
            if (validador.validarString(txtNombreEmpleado, "Ingrese el nombre del empleado", "Atención"))
            { nombreEmp = txtNombreEmpleado.Text.Trim(); }
            else { return false; }

            String apellidoEmp;
            if (validador.validarString(txtApellidoEmpleado, "Ingrese el apellido del empleado", "Atención"))
            { apellidoEmp = txtApellidoEmpleado.Text.Trim(); }
            else { return false; }
            String numeroDocumentoEmp;
            if (validador.validarString(txtNroDocumentoEmpleado, "Ingrese el número de documento", "Atención"))
            { numeroDocumentoEmp = txtNroDocumentoEmpleado.Text.Trim(); }
            else { return false; }

            int idTipoDocEmp = Convert.ToInt32(cmbTipoDocumentoEmpleado.SelectedValue);
            String nombreTipoDocEmp = cmbTipoDocumentoEmpleado.Text;
            TipoDocumento tipoDocumentoEmp = new TipoDocumento(idTipoDocEmp, nombreTipoDocEmp);



            String nombreSexoEmp = cmbSexoEmpleado.Text;
            int idSexoEmp = (int)cmbSexoEmpleado.SelectedValue;
            Sexo sexoEmp = new Sexo(idSexoEmp, nombreSexoEmp);


            int idBarrioEmp = Convert.ToInt32(cmbBarrioEmpleado.SelectedValue);
            String nombreBarrioEmp = cmbBarrioEmpleado.Text;
            Barrio barrioEmp = new Barrio(idBarrioEmp, nombreBarrioEmp);


            String calleEmp;
            if (validador.validarString(txtCalleEmpleado, "Ingrese el nombre de la calle", "Atencion"))
            { calleEmp = txtCalleEmpleado.Text.ToString().Trim(); }
            else { return false; }

            String numeroCalleEmp;
            if (validador.validarString(txtNumero, "Ingrese número de la calle", "Atencion"))
            { numeroCalleEmp = txtNumero.Text.Trim(); }
            else { return false; }

            String pisoEmp = txtPiso.Text.Trim();
            String deptoEmp = txtDpto.Text.Trim();
            String torreEmp = txtTorreEmpleado.Text.Trim();
            Domicilio domicilioEmp = new Domicilio(calleEmp, numeroCalleEmp, deptoEmp, pisoEmp, torreEmp, barrioEmp);

            List<Correo> correosEmp = new List<Correo>();
            foreach (Correo correo in lstEmail.Items)
            {
                correosEmp.Add(correo);
            }

            List<Telefono> telefonosEmp = new List<Telefono>();
            foreach (Telefono telefono in lstTelefonos.Items)
            {
                telefonosEmp.Add(telefono);
            }


            String nombreCuentaEmp = cmbCuentaEmpleado.SelectedItem.ToString();
            int idCuentaEmp = (int)cmbCuentaEmpleado.SelectedValue;
            Cuenta cuentaEmp = new Cuenta(idCuentaEmp, nombreCuentaEmp);

            String nombreEstadoEmp = cmbCuentaEmpleado.SelectedItem.ToString();
            int idEstadoEmp = (int)cmbEstadoEmpleado.SelectedValue;
            EstadoUsuario estadoUsuarioEmp = new EstadoUsuario(idEstadoEmp, nombreEstadoEmp);

            String nombreUsuarioEmp;
            if (validador.validarString(txtNombreUsuarioEmpleado, "Ingrese el nombre de Usuario", "Atención"))
            { nombreUsuarioEmp = txtNombreUsuarioEmpleado.Text.Trim(); }
            else { return false; }

            String contraseniaEmp;
            if (validador.validarString(txtContraseniaEmpleado, "Ingrese la contraseña", "Atención"))
            { contraseniaEmp = txtContraseniaEmpleado.Text.Trim(); }
            else { return false; }

            int idEmpleadoSel = idEmpleadoSeleccionado;
            int idPersona = idPersonaSeleccionado;
            String comentarioUsuarioEmp = txtComentarioUsuarioEmpleado.Text.Trim();

            Usuario usuarioEmp = new Usuario(nombreUsuarioEmp, contraseniaEmp, cuentaEmp, comentarioUsuarioEmp, estadoUsuarioEmp);

            Empleado e = new Empleado(nombreEmp, apellidoEmp, fechaAltaEmp, numeroDocumentoEmp, tipoDocumentoEmp, fechaNacimientoEmp, telefonosEmp, correosEmp, domicilioEmp, usuarioEmp, comentarioUsuarioEmp, sexoEmp, legajoEmp, idEmpleadoSeleccionado, idPersonaSeleccionado);

            GestorDePersonas gestorPersonas = new GestorDePersonas();
            string mensaje = gestorPersonas.tomarModificacionEmpleado(e, legajoViejo, tipoDniViejo, nroDniViejo);
            if (mensaje.Equals("Se modifico"))
            {
                MessageBox.Show("Empleado modificado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                if(mensaje.Equals("No se pudo modificar"))
                {
                    MessageBox.Show("El Empleado no se pudo modificar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                else
                {
                    if(mensaje.Equals("error de tipo y nro de DNI"))
                    {

                        MessageBox.Show("La combinacion de tipo de DNI y numero de DNI ya existe", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNroDocumentoEmpleado.Focus();
                        return false;
                    }
                    else
                    {
                        if (mensaje.Equals("error de Legajo"))
                        {
                            MessageBox.Show("El Legajo del empleado ya existe", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtLegajoEmpleado.Focus();
                            return false;
                        }
                        else
                        {
                            MessageBox.Show("El Legajo del empleado y la combinacion de tipo y numero de DNI ya existe", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtLegajoEmpleado.Focus();
                            return false;
                        }
                        
                    }
                }
                
            }

            
        }
            
        

        private void btnModificarEmpleado_Click(object sender, EventArgs e)
        {
            
            ESTADOCONTROLES = "habilitar";
            habilitarControles(ESTADOCONTROLES);
            grpEmpleado.Enabled = true;
            txtBusquedaEmpleado.Enabled = true;
            btnBuscarEmpleado.Enabled = true;
            btnAgregarEmpleado.Enabled = false;
            btnModificarEmpleado.Enabled = false;
            btnQuitarEmpleado.Enabled = false;
            esNuevo = false;
        }

        private void eliminarEmpleado(String legajoEmp)
        {
            Empleado empleado = new Empleado();
            empleado.Legajo = legajoEmp;
            GestorDePersonas gestorPersonas = new GestorDePersonas();
            if (gestorPersonas.tomarEmpleadoAEliminar(empleado))
            {
                MessageBox.Show("Empleado eliminado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No se pudo eliminar el empleado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void btnQuitarEmpleado_Click(object sender, EventArgs e)
        {
            if (validador.validarString(txtLegajoEmpleado, "Seleccione un empleado", "Atención"))
            {
                ESTADOCONTROLES = "deshabilitar";
                habilitarControles(ESTADOCONTROLES);
                btnAgregarEmpleado.Enabled = true;
                btnSalir.Enabled = true;
                grpEmpleado.Enabled = true;
                
                txtBusquedaEmpleado.Enabled = true;
                btnBuscarEmpleado.Enabled = true;
                eliminarEmpleado(txtLegajoEmpleado.Text.Trim());
                limpiarTextBox();
             
                
                
            }
            else
            {
                txtBusquedaEmpleado.Focus();
                
            }
            
        }

        
    }
}
