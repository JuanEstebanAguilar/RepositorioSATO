using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Negocio;
using System.Data.SqlClient;
using Entidades;


namespace Presentacion
{
    public partial class frmProfesional : Form

    {
        private string matriculaVieja;
        private int tipoDniViejo;
        private string nroDniViejo;
        private Boolean esNuevo;
        private int idProfesionalSel;
        private int idPersonaSel;
        private Validador validador = new Validador();
        List<Especialidad> listaEspecialidad = new List<Especialidad>();
        public frmProfesional()
        {
            InitializeComponent();
        }
        
        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            frmTiposDocumento vtTipoDocumento = new frmTiposDocumento();
            vtTipoDocumento.ShowDialog();
            mostrarTiposDocumento();
        }

        private void Profesional_Load(object sender, EventArgs e)
        {
            //cargarfkingprofdefecto();
            mostrarProvincias();
            mostrarTiposDocumento();
            mostrarTiposTelefono();
            mostrarEspecialidades();
            mostrarSexos();
            mostrarEstadosUsuario();
            mostrarCuentasUsuario();
            deshabilitarcampos();
            btnAgregarProf.Enabled = true;
            btnsalir.Enabled = true;
            grbProfesionales.Enabled = true;
            txtbuscarprofesional.Enabled = true;
            btnBuscarProfesional.Enabled = true;

            ToolTip toolTip1 = new ToolTip();

            // Set up the delays for the ToolTip.
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip1.ShowAlways = true;

            // Set up the ToolTip text for the Button and Checkbox.
            toolTip1.SetToolTip(btnAgregarProf, "Agrega un Profesional");
            toolTip1.SetToolTip(btncancelar, "Cancela la acción que se esta realizando");
            toolTip1.SetToolTip(btneditar, "Habilita la modificación del Profesional");
            toolTip1.SetToolTip(btneliminar, "Elimina el Profesional");
            toolTip1.SetToolTip(btnGrabar, "Guarda el Profesional creado o modificado");
            toolTip1.SetToolTip(btnsalir, "Sale de la ventana");
       
            //cargarGrillaEspecialidades();
        }

        private void mostrarProvincias()
        {
            GestorDePersonas gestorPersonas = new GestorDePersonas();
            cmbProvincias.Items.Clear();
            cmbProvincias.ValueMember = "idProvincia";
            cmbProvincias.DisplayMember = "nombre";
            cmbProvincias.DataSource = gestorPersonas.obtenerProvincias();
        }
        private void mostrarSexos()
        {
            GestorDePersonas gestorPersonas = new GestorDePersonas();
            cmbSexo.ValueMember = "idSexo";
            cmbSexo.DisplayMember = "nombre";
            cmbSexo.DataSource = gestorPersonas.obtenerSexos();
        }
        
        private void mostrarCuentasUsuario()
        {
            GestorDePersonas gestorPersonas = new GestorDePersonas();
            cmbCuenta.ValueMember = "idCuenta";
            cmbCuenta.DisplayMember = "nombre";
            cmbCuenta.DataSource = gestorPersonas.obtenerCuentas();
        }
        private void mostrarEstadosUsuario()
        {
            GestorDePersonas gestorPersonas = new GestorDePersonas();
            cmbEstado.ValueMember = "idEstado";
            cmbEstado.DisplayMember = "nombre";
            cmbEstado.DataSource = gestorPersonas.obtenerEstadosUsuarios();
        }

        private void mostrarTiposTelefono()
        {
            GestorDePersonas gestorPersonas = new GestorDePersonas();
            cmbTipoTelefono.ValueMember = "idTipoTelefono";
            cmbTipoTelefono.DisplayMember = "nombre";
            cmbTipoTelefono.DataSource = gestorPersonas.obtenerTiposTelefono();
        }

        private void mostrarEspecialidades()
        {
            GestorDePersonas gestorPersonas = new GestorDePersonas();
            cmbEspecialidades.ValueMember = "idespecialidad";
            cmbEspecialidades.DisplayMember = "nombre";
            cmbEspecialidades.DataSource = gestorPersonas.obtenerEspecialidades();
        }

        private void cargarGrillaEspecialidades()
        {
            GestorDePersonas gestorPersonas = new GestorDePersonas();
            listaEspecialidad = gestorPersonas.cargarEspecialidadesPorProfesional(listaEspecialidad, null, null);
            grillaespecialidades.DataSource = listaEspecialidad;
        }


        private void mostrarTiposDocumento()
        {
            GestorDePersonas gestorPersonas = new GestorDePersonas();
            cmbTipoDocumento.ValueMember = "idTipoDocumento";
            cmbTipoDocumento.DisplayMember = "nombre";
            cmbTipoDocumento.DataSource = gestorPersonas.obtenerTiposDocumento();
        }

        private void mostrarBarriosPorLocalidad(int idLocalidad)
        {
            GestorDePersonas gestorPersonas = new GestorDePersonas();
            cmbBarrios.ValueMember = "idBarrio";
            cmbBarrios.DisplayMember = "nombre";
            cmbBarrios.DataSource = gestorPersonas.obtenerBarriosPorLocalidad(idLocalidad);
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

        private void btnAgregarProf_Click(object sender, EventArgs e)
        {
            limpiarTextBox();
            habilitarcampos();
            grbProfesionales.Enabled = false;
            txtbuscarprofesional.Enabled = false;
            btnBuscarProfesional.Enabled = false;
            btnAgregarProf.Enabled = false;
            btneditar.Enabled = false;
            btneliminar.Enabled = false;
            esNuevo = true;
            //btnsalir.Enabled = true;
            groupBox3.Enabled = true;
            GestorDePersonas gestorPersonas = new GestorDePersonas();
            grillaespecialidades.DataSource = gestorPersonas.limpiarGrilla();
            txtmatricula.Focus();
    }

        private void cmbDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            mostrarLocalidadesPorDepartamento((int)cmbDepartamentos.SelectedValue);
        }

        private void cmbLocalidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            mostrarBarriosPorLocalidad((int)cmbLocalidades.SelectedValue);
        }

        private void cmbProvincias_SelectedIndexChanged(object sender, EventArgs e)
        {
            mostrarDepartamentosPorProvincia((int)cmbProvincias.SelectedValue);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Validador validador = new Validador();

            if (validador.validarString(txtCorreo, "Ingrese una dirección de correo", "Atención"))
            {
                Correo correo = new Correo("Rivadavia 758");
                correo.Direccion = txtCorreo.Text.Trim();
                lstCorreosElectronicos.Items.Add(correo);
                txtCorreo.Text = "";
                txtCorreo.Focus();
            }
            else { }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Validador validador = new Validador();

            if (validador.validarString(txtTelefono, "Ingrese una dirección de correo", "Atención"))
            {
                TipoTelefono tipoTelefono = new TipoTelefono(Convert.ToInt32(cmbTipoTelefono.SelectedValue), cmbTipoTelefono.SelectedItem.ToString());
                Telefono telefono = new Telefono(txtTelefono.Text.Trim(), tipoTelefono);
                lstTelefonos.Items.Add(telefono);
                txtTelefono.Text = "";
                txtTelefono.Focus();
            }
            else { }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            GestorDePersonas gestorPersonas = new GestorDePersonas();

            Especialidad esp = gestorPersonas.obtenerEspecialidadxID(Convert.ToInt32(cmbEspecialidades.SelectedValue));
            listaEspecialidad = gestorPersonas.cargarEspecialidadesPorProfesional(listaEspecialidad, esp, "add");
            grillaespecialidades.DataSource = null;
            grillaespecialidades.DataSource = listaEspecialidad;
          
         }

        private void button18_Click(object sender, EventArgs e)
        {
            try
            {
                GestorDePersonas gestorPersonas = new GestorDePersonas();

                Int32 idGrilla = Int32.Parse(grillaespecialidades.CurrentRow.Cells["idespecialidad"].Value.ToString());

                Especialidad esp = gestorPersonas.obtenerEspecialidadxID(idGrilla);
                listaEspecialidad = gestorPersonas.cargarEspecialidadesPorProfesional(listaEspecialidad, esp, "remove");
                grillaespecialidades.DataSource = null;
                grillaespecialidades.DataSource = listaEspecialidad;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seleccione una especialidad de la\ngrilla antes de intertart borrarla.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Boolean guardarProfesional()
        {
           
            
                string matricula;
                if (validador.validarString(txtmatricula, "Ingrese el matricula del profesional", "Atención"))
                { matricula = txtmatricula.Text.Trim(); }
                else { return false; }
                String nombreprof;
                if (validador.validarString(txtnombre, "Ingrese el nombre del profesional", "Atención"))
                { nombreprof = txtnombre.Text.Trim(); }
                else { return false; }
       

                String apellidoprof;
                 if (validador.validarString(txtapellido, "Ingrese el apellido del profesional", "Atención"))
                { apellidoprof = txtapellido.Text.Trim(); }
                else { return false; }

                 String nrodoc;
                 if (validador.validarString(txtnrodoc, "Ingrese el numero de documento del profesional", "Atención"))
                 { nrodoc = txtnrodoc.Text.Trim(); }
                 else { return false; }

                String calleProf;

                if (validador.validarString(txtcalle, "Ingrese el nombre de la calle del profesional", "Atención"))
                { calleProf = txtcalle.Text.Trim(); }
                else { return false;}

                String numeroCalleProf;

                 if (validador.validarString(txtnumero, "Ingrese el numero de la calle del profesional", "Atención"))
                { numeroCalleProf = txtnumero.Text.Trim(); }
                else { return false;}

                DateTime fechaAlta = dtpFechaAlta.Value.Date;
                DateTime fechanac = dtpfechanac.Value.Date;
                
                int idTipoDocProf = Convert.ToInt32(cmbTipoDocumento.SelectedValue);
                String nombretipoDocProf = cmbTipoDocumento.Text;
                TipoDocumento tipoDocumentoProf = new TipoDocumento(idTipoDocProf, nombretipoDocProf);

                int idBarrioProf = Convert.ToInt32(cmbBarrios.SelectedValue);
                String nombreBarrioProf = cmbBarrios.Text;
                Barrio barrioProf = new Barrio(idBarrioProf, nombreBarrioProf);

                String pisoProf = txtpiso.Text.Trim();
                String deptoProf = txtdpto.Text.Trim();
                String torreProf = txttorre.Text.Trim();
                Domicilio domicilioProf = new Domicilio(calleProf, numeroCalleProf, pisoProf, deptoProf, torreProf, barrioProf);

                List<Correo> correosProf = new List<Correo>();
                foreach (Correo correo in lstCorreosElectronicos.Items)
                {
                    correosProf.Add(correo);
                }

                List<Telefono> telefonosProf = new List<Telefono>();

                foreach (Telefono telefono in lstTelefonos.Items)
                {
                    telefonosProf.Add(telefono);
                }

                int idSexoProf = Convert.ToInt32(cmbSexo.SelectedValue);
                String nombreSexoProf = cmbSexo.Text;
                Sexo sexoProf = new Sexo(idSexoProf, nombreSexoProf);


                String nombreCuentaProf = cmbCuenta.SelectedItem.ToString();
                int idCuentaProf = (int)cmbCuenta.SelectedValue;
                Cuenta cuentaProf = new Cuenta(idCuentaProf, nombreCuentaProf);

                String nombreEstadoProf = cmbEstado.SelectedItem.ToString();
                int idEstadoProf = (int)cmbEstado.SelectedValue;
                EstadoUsuario estadoUsuarioProf = new EstadoUsuario(idEstadoProf, nombreEstadoProf);

                String nombreUsuarioProf = txtusuario.Text.Trim();
                String contraseniaProf = txtcontraseña.Text.Trim();
                String comentarioUsuarioProf = txtcomentario.Text.Trim();

                Usuario usuarioProf = new Usuario(nombreUsuarioProf, contraseniaProf, cuentaProf, comentarioUsuarioProf, estadoUsuarioProf);

                List<Especialidad> lstespecialidades = new List<Especialidad>();

                for (int i = 0; i < grillaespecialidades.Rows.Count; i++)
                {
                    int id = Convert.ToInt32(grillaespecialidades["idespecialidad", i].Value.ToString());
                    string nombre = grillaespecialidades["nombre", i].Value.ToString();
                    string descripcion = grillaespecialidades["descripcion", i].Value.ToString();
                    Especialidad esp = new Especialidad(id, nombre, descripcion);
                    lstespecialidades.Add(esp);

                }
                Profesional prof = new Profesional(nombreprof, apellidoprof, fechaAlta, nrodoc, tipoDocumentoProf, fechanac, telefonosProf, correosProf, domicilioProf, usuarioProf, comentarioUsuarioProf, sexoProf, "", matricula);

                GestorDePersonas gestorPersonas = new GestorDePersonas();

                
                if (gestorPersonas.tomarProfesional(prof, lstespecialidades))
                {
                    Validador val = new Validador();
                    val.limpiarTexBox(this);
                    grillaespecialidades.DataSource = gestorPersonas.limpiarGrilla();
                    deshabilitarcampos();
                    //btnGrabar.Enabled = false;
                    btnAgregarProf.Enabled = true;
                    //btncancelar.Enabled = false;
                    //btneliminar.Enabled = false;
                    //btneditar.Enabled = false;
                    grbProfesionales.Enabled = true;
                    txtbuscarprofesional.Enabled = true;
                    btnBuscarProfesional.Enabled = true;
                    btnsalir.Enabled = true;

                    MessageBox.Show("Profesional guardado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("El profesional ya se encuentra registrado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

            }
        

        private void btnBuscarProfesional_Click_1(object sender, EventArgs e)
        {
          
        }


        private void mostrarProfesionalSeleccionado(string param)
        {
            GestorDePersonas gestorPersonas = new GestorDePersonas();
              int parametroidprofesional=Convert.ToInt32(param);
              Profesional profesional = gestorPersonas.obtenerProfesionalxID(parametroidprofesional);
              lstCorreosElectronicos.Items.Clear();
              lstTelefonos.Items.Clear();
              txtnroProfesional.Text = profesional.Idprofesional.ToString();
              txtapellido.Text = profesional.Apellido;
              txtcalle.Text = profesional.Domicilio.Calle;
              txtcomentario.Text = profesional.Comentario;
              txtdpto.Text = profesional.Domicilio.Departamento;

              idProfesionalSel = profesional.Idprofesional;
              idPersonaSel = profesional.Idpersona;
              txtmatricula.Text = profesional.Matricula;
              matriculaVieja= profesional.Matricula;

              txtnombre.Text = profesional.Nombre;
          
              txtnrodoc.Text = profesional.NumeroDocumento;
              nroDniViejo= profesional.NumeroDocumento;

              txtpiso.Text = profesional.Domicilio.Piso;
              txttorre.Text = profesional.Domicilio.Torre;
              txtnumero.Text = profesional.Domicilio.Numero;
              cmbProvincias.SelectedValue = profesional.Domicilio.Barrio.Localidad.Departamento.Provincia.IdProvincia;
              cmbDepartamentos.SelectedValue = profesional.Domicilio.Barrio.Localidad.Departamento.IdDepartamento;
              cmbLocalidades.SelectedValue = profesional.Domicilio.Barrio.Localidad.Idlocalidad;
              cmbBarrios.SelectedValue = profesional.Domicilio.Barrio.IdBarrio;
          
              cmbTipoDocumento.SelectedValue = profesional.TipoDocumento.IdTipoDocumento;
              tipoDniViejo= profesional.TipoDocumento.IdTipoDocumento;

              cmbSexo.SelectedValue = profesional.Sexo.IdSexo;
              cmbCuenta.SelectedValue = profesional.Usuario.Cuenta.IdCuenta;
              cmbEstado.SelectedValue = profesional.Usuario.Estado.IdEstado;
          
              foreach (Correo correo in profesional.Correos)
              {
                  lstCorreosElectronicos.Items.Add(correo);
              }

              foreach (Telefono tel in profesional.Telefonos)
              {
                  lstTelefonos.Items.Add(tel);
              }

              txtusuario.Text = profesional.Usuario.Nombre;
              cmbCuenta.SelectedValue = profesional.Usuario.Cuenta.IdCuenta;
              txtcontraseña.Text = profesional.Usuario.Contrasenia;
              cmbEstado.SelectedValue = profesional.Usuario.Estado.IdEstado;
              txtcomentariousuario.Text = profesional.Usuario.Comentario;
              List<Especialidad> lstespecialidad = gestorPersonas.obtenerEspecialidadPorProfesional(parametroidprofesional);
              listaEspecialidad = null;
              listaEspecialidad = lstespecialidad;
              grillaespecialidades.DataSource = lstespecialidad;
              
              deshabilitarcampos();
              txtbuscarprofesional.Enabled = true;
              btnBuscarProfesional.Enabled = true;
              btnAgregarProf.Enabled = true;
              btneditar.Enabled = true;
              //btnGrabar.Enabled = false;
              btneliminar.Enabled = true;
              btnsalir.Enabled = true;
   }

       private void txtbuscarprofesional_TextChanged(object sender, EventArgs e)
       {

       }

       private void btnBuscarProfesional_Click(object sender, EventArgs e)
       {
           String parametro = txtbuscarprofesional.Text.Trim();
           GestorDePersonas gestorPersonas=new GestorDePersonas();
           List<Profesional> lsProfesional = gestorPersonas.obtenerProfesionalPorBusqueda(parametro);

           if (lsProfesional != null)
           {
               BuscarProfesional vtBuscarProfesional = new BuscarProfesional(lsProfesional);
               vtBuscarProfesional.profesionalAPasar += new BuscarProfesional.pasarProfesional(mostrarProfesionalSeleccionado);
               vtBuscarProfesional.ShowDialog();
           }

           else
           {
               MessageBox.Show("No hay profesionales registrados", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
           }

       }

       private void habilitarcampos()
       {
           txtapellido.Enabled = true;
           txtbuscarprofesional.Enabled = true;
           txtcalle.Enabled = true;
           txtcomentario.Enabled = true;
           txtcomentariousuario.Enabled = true;
           txtcontraseña.Enabled = true;
           txtCorreo.Enabled = true;
           txtdpto.Enabled = true;
           txtmatricula.Enabled = true;
           txtnombre.Enabled = true;
           txtnrodoc.Enabled = true;
           txtnumero.Enabled = true;
           txtpiso.Enabled = true;
           txtTelefono.Enabled = true;
           txttorre.Enabled = true;
           txtusuario.Enabled = true;
           cmbBarrios.Enabled = true;
           cmbCuenta.Enabled = true;
           cmbDepartamentos.Enabled = true;
           cmbEspecialidades.Enabled = true;
           cmbEstado.Enabled = true;
           cmbLocalidades.Enabled = true;
           cmbProvincias.Enabled = true;
           cmbSexo.Enabled = true;
           cmbTipoDocumento.Enabled = true;
           cmbTipoTelefono.Enabled = true;
           grillaespecialidades.Enabled = true;
           button10.Enabled = true;
           button11.Enabled = true;
           button8.Enabled = true;
           button7.Enabled = true;
           button15.Enabled = true;
           button17.Enabled = true;
           button18.Enabled = true;
           dtpFechaAlta.Enabled = true;
           dtpfechanac.Enabled = true;
           lstCorreosElectronicos.Enabled = true;
           lstTelefonos.Enabled = true;
           btnAgregarProf.Enabled = true;
           btncancelar.Enabled = true;
           btneditar.Enabled = true;
           btneliminar.Enabled = true;
           btnGrabar.Enabled = true;
           btnsalir.Enabled = true;
           
       }

       private void deshabilitarcampos()
       {
           txtapellido.Enabled = false;
           txtbuscarprofesional.Enabled = false;
           txtcalle.Enabled = false;
           txtcomentario.Enabled = false;
           txtcomentariousuario.Enabled = false;
           txtcontraseña.Enabled = false;
           txtCorreo.Enabled = false;
           txtdpto.Enabled = false;
           txtmatricula.Enabled = false;
           txtnombre.Enabled = false;
           txtnrodoc.Enabled = false;
           txtnumero.Enabled = false;
           txtpiso.Enabled = false;
           txtTelefono.Enabled = false;
           txttorre.Enabled = false;
           txtusuario.Enabled = false;
           cmbBarrios.Enabled = false;
           cmbCuenta.Enabled = false;
           cmbDepartamentos.Enabled = false;
           cmbEspecialidades.Enabled = false;
           cmbEstado.Enabled = false;
           cmbLocalidades.Enabled = false;
           cmbProvincias.Enabled = false;
           cmbSexo.Enabled = false;
           cmbTipoDocumento.Enabled = false;
           cmbTipoTelefono.Enabled = false;
           grillaespecialidades.Enabled = false;
           button10.Enabled = false;
           button11.Enabled = false;
           button8.Enabled = false;
           button7.Enabled = false;
           button15.Enabled = false;
           button17.Enabled = false;
           button18.Enabled = false;
           dtpFechaAlta.Enabled = false;
           dtpfechanac.Enabled = false;
           lstCorreosElectronicos.Enabled = false;
           lstTelefonos.Enabled = false;
           btnAgregarProf.Enabled = false;
           btncancelar.Enabled = false;
           btneditar.Enabled = false;
           btneliminar.Enabled = false;
           btnGrabar.Enabled = false;
           btnsalir.Enabled = false;
       }

       

       private void btncancelar_Click(object sender, EventArgs e)
       {
           GestorDePersonas gestorPersonas = new GestorDePersonas();
           grillaespecialidades.DataSource = gestorPersonas.limpiarGrilla();
           limpiarTextBox();
           deshabilitarcampos();
           btnAgregarProf.Enabled = true;
           btnsalir.Enabled = true;
           grbProfesionales.Enabled = true;
           txtbuscarprofesional.Enabled = true;
           btnBuscarProfesional.Enabled = true;
        }

       private void btneliminar_Click(object sender, EventArgs e)
       {
           
           if (validador.validarString(txtmatricula, "Seleccione un profesional", "Atención"))
           {
               int numeroProfesional = Convert.ToInt32(txtnroProfesional.Text.ToString());
               eliminarProfesional(numeroProfesional);
               GestorDePersonas gestorPersonas = new GestorDePersonas();
               grillaespecialidades.DataSource = gestorPersonas.limpiarGrilla();
               deshabilitarcampos();
               btnAgregarProf.Enabled = true;
               btnsalir.Enabled = true;
               grbProfesionales.Enabled = true;
               txtbuscarprofesional.Enabled = true;
               btnBuscarProfesional.Enabled = true;
               limpiarTextBox();
           }
           else
           {
               txtbuscarprofesional.Focus();
           }
      }
      private void eliminarProfesional(int numeroProfesional)
       {   Profesional profesional = new Profesional();
           profesional.Idprofesional =numeroProfesional;
           GestorDePersonas gestorPersonas = new GestorDePersonas();
           if (gestorPersonas.tomarProfesionalAEliminar(profesional))
               MessageBox.Show("Profesional eliminado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
           else
               MessageBox.Show("No se pudo eliminar el profesional", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
       }

       private void button10_Click(object sender, EventArgs e)
       {
           Validador validador = new Validador();
           if (validador.validarQuitarItemLista(lstCorreosElectronicos, "No hay correo para quitar", "Seleccione un correo", "Atención"))
           { lstCorreosElectronicos.Items.RemoveAt(lstCorreosElectronicos.SelectedIndex); }
           else
           {}
       }

       private void button8_Click(object sender, EventArgs e)
       {
           Validador validador = new Validador();
           if (validador.validarQuitarItemLista(lstTelefonos, "No hay correo para quitar", "Seleccione un correo", "Atención"))
           { lstTelefonos.Items.RemoveAt(lstTelefonos.SelectedIndex); }
           else
           { }
       }

       private void btnGrabar_Click(object sender, EventArgs e)
       {
           if (esNuevo == true)
           {
               guardarProfesional();
           }
           else
           {
               if (modificarProfesional())
               {
                   GestorDePersonas gestorPersonas = new GestorDePersonas();
                   limpiarTextBox();
                   grillaespecialidades.DataSource = gestorPersonas.limpiarGrilla();
                   deshabilitarcampos();
                   btnGrabar.Enabled = false;
                   btnAgregarProf.Enabled = true;
                   btncancelar.Enabled = false;
                   btneliminar.Enabled = false;
                   btneditar.Enabled = false;
                   grbProfesionales.Enabled = true;
                   txtbuscarprofesional.Enabled = true;
                   btnBuscarProfesional.Enabled = true;
                   btnsalir.Enabled = true;

               }
           }
       }

       private void btneditar_Click(object sender, EventArgs e)
       {
           habilitarcampos();
           grbProfesionales.Enabled = false;
           txtbuscarprofesional.Enabled = false;
           btnBuscarProfesional.Enabled = false;
           btnAgregarProf.Enabled = false;
           btneditar.Enabled = false;
           btneliminar.Enabled = false;
           esNuevo = false;
           groupBox3.Enabled = true;
           txtmatricula.Focus();
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
       private Boolean modificarProfesional()
       {
           string matricula;
                if (validador.validarString(txtmatricula, "Ingrese el matricula del profesional", "Atención"))
                { matricula = txtmatricula.Text.Trim(); }
                else { return false; }
                String nombreprof;
                if (validador.validarString(txtnombre, "Ingrese el nombre del profesional", "Atención"))
                { nombreprof = txtnombre.Text.Trim(); }
                else { return false; }
       

                String apellidoprof;
                 if (validador.validarString(txtapellido, "Ingrese el apellido del profesional", "Atención"))
                { apellidoprof = txtapellido.Text.Trim(); }
                else { return false; }

                 String nrodoc;
                 if (validador.validarString(txtnrodoc, "Ingrese el numero de documento del profesional", "Atención"))
                 { nrodoc = txtnrodoc.Text.Trim(); }
                 else { return false; }

                String calleProf;

                if (validador.validarString(txtcalle, "Ingrese el nombre de la calle del profesional", "Atención"))
                { calleProf = txtcalle.Text.Trim(); }
                else { return false;}

                String numeroCalleProf;

                 if (validador.validarString(txtnumero, "Ingrese el numero de la calle del profesional", "Atención"))
                { numeroCalleProf = txtnumero.Text.Trim(); }
                else { return false;}

            DateTime fechaAlta = dtpFechaAlta.Value.Date;
                DateTime fechanac = dtpfechanac.Value.Date;
                int numeroProfesional = Convert.ToInt32(txtnroProfesional.Text.ToString());
               
     


                int idTipoDocProf = Convert.ToInt32(cmbTipoDocumento.SelectedValue);
                String nombretipoDocProf = cmbTipoDocumento.Text;
                TipoDocumento tipoDocumentoProf = new TipoDocumento(idTipoDocProf, nombretipoDocProf);


                int idBarrioProf = Convert.ToInt32(cmbBarrios.SelectedValue);
                String nombreBarrioProf = cmbBarrios.Text;
                Barrio barrioProf = new Barrio(idBarrioProf, nombreBarrioProf);

                String pisoProf = txtpiso.Text.Trim();
                String deptoProf = txtdpto.Text.Trim();
                String torreProf = txttorre.Text.Trim();
                Domicilio domicilioProf = new Domicilio(calleProf, numeroCalleProf, pisoProf, deptoProf, torreProf, barrioProf);

                List<Correo> correosProf = new List<Correo>();
                foreach (Correo correo in lstCorreosElectronicos.Items)
                {
                    correosProf.Add(correo);
                }

                List<Telefono> telefonosProf = new List<Telefono>();

                foreach (Telefono telefono in lstTelefonos.Items)
                {
                    telefonosProf.Add(telefono);
                }

                int idSexoProf = Convert.ToInt32(cmbSexo.SelectedValue);
                String nombreSexoProf = cmbSexo.Text;
                Sexo sexoProf = new Sexo(idSexoProf, nombreSexoProf);


                String nombreCuentaProf = cmbCuenta.SelectedItem.ToString();
                int idCuentaProf = (int)cmbCuenta.SelectedValue;
                Cuenta cuentaProf = new Cuenta(idCuentaProf, nombreCuentaProf);

                String nombreEstadoProf = cmbEstado.SelectedItem.ToString();
                int idEstadoProf = (int)cmbEstado.SelectedValue;
                EstadoUsuario estadoUsuarioProf = new EstadoUsuario(idEstadoProf, nombreEstadoProf);

                String nombreUsuarioProf = txtusuario.Text.Trim();
                String contraseniaProf = txtcontraseña.Text.Trim();
                String comentarioUsuarioProf = txtcomentario.Text.Trim();

                Usuario usuarioProf = new Usuario(nombreUsuarioProf, contraseniaProf, cuentaProf, comentarioUsuarioProf, estadoUsuarioProf);
                int idProfesionalMod = idProfesionalSel;
                int idPersonaMod = idPersonaSel;

           //     Profesional prof = new Profesional(nombreprof, apellidoprof, fechaAlta, numeroProfesional, tipoDocumentoProf, fechanac, telefonosProf, correosProf, domicilioProf, usuarioProf, comentarioUsuarioProf, sexoProf, null, matriculaVieja, idProfesionalMod, idPersonaSel);
                Profesional prof = new Profesional(nombreprof, apellidoprof, fechaAlta, nrodoc, tipoDocumentoProf, fechanac, telefonosProf, correosProf, domicilioProf, usuarioProf, comentarioUsuarioProf, sexoProf, "", matricula, idProfesionalMod, idPersonaMod);

                GestorDePersonas gestorPersonas = new GestorDePersonas();
                
           List<Especialidad> lstespecialidades = new List<Especialidad>();

                for (int i = 0; i < grillaespecialidades.Rows.Count; i++)
                {
                    int id = Convert.ToInt32(grillaespecialidades["idespecialidad", i].Value.ToString());
                    string nombre = grillaespecialidades["nombre", i].Value.ToString();
                    string descripcion = grillaespecialidades["descripcion", i].Value.ToString();
                    Especialidad esp = new Especialidad(id, nombre, descripcion);
                    lstespecialidades.Add(esp);

                }
                string mensaje = gestorPersonas.tomarModificacionProfesional(prof, matriculaVieja, tipoDniViejo, nroDniViejo, lstespecialidades);
                if (mensaje.Equals("Se modifico"))
                {
                    MessageBox.Show("Profesional modificado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    if (mensaje.Equals("No se pudo modificar"))
                    {
                        MessageBox.Show("El Profesional no se pudo modificar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                    else
                    {
                        if (mensaje.Equals("error de tipo y nro de DNI"))
                        {

                            MessageBox.Show("La combinacion de tipo de DNI y numero de DNI ya existe", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtnrodoc.Focus();
                            return false;
                        }
                        else
                        {
                            if (mensaje.Equals("error de Matricula"))
                            {
                                MessageBox.Show("La matricula del profesional ya existe", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtmatricula.Focus();
                                return false;
                            }
                            else
                            {
                                MessageBox.Show("La matricula del profesional y la combinacion de tipo y numero de DNI ya existe", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtmatricula.Focus();
                                return false;
                            }

                        }
                    }

            }
        }
    }
}
