namespace Presentacion
{
    partial class frmPaciente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPaciente));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbTipoTelefono = new System.Windows.Forms.ComboBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.btnQuitarTelefono = new System.Windows.Forms.Button();
            this.btnAgregarTelefono = new System.Windows.Forms.Button();
            this.lstTelefonos = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.btnQuitarCorreo = new System.Windows.Forms.Button();
            this.btnAgregarCorreo = new System.Windows.Forms.Button();
            this.lstCorreosElectronicos = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTorre = new System.Windows.Forms.TextBox();
            this.txtDepto = new System.Windows.Forms.TextBox();
            this.txtPiso = new System.Windows.Forms.TextBox();
            this.txtNumeroCalle = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnBuscarBarrio = new System.Windows.Forms.Button();
            this.btnBuscarLocalidad = new System.Windows.Forms.Button();
            this.cmbBarrios = new System.Windows.Forms.ComboBox();
            this.cmbLocalidades = new System.Windows.Forms.ComboBox();
            this.btnBuscarDepartamento = new System.Windows.Forms.Button();
            this.cmbDepartamentos = new System.Windows.Forms.ComboBox();
            this.btnBuscarProvincia = new System.Windows.Forms.Button();
            this.cmbProvincias = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbxBusquedaPacientes = new System.Windows.Forms.GroupBox();
            this.txtBuscarPaciente = new System.Windows.Forms.TextBox();
            this.btnBuscarPaciente = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtNumeroAfiliado = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtBusquedaCobertura = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnFiltrarCobertura = new System.Windows.Forms.Button();
            this.btnQuitarCobertura = new System.Windows.Forms.Button();
            this.btnAgregarCobertura = new System.Windows.Forms.Button();
            this.cmbCobertura = new System.Windows.Forms.ComboBox();
            this.btnBuscarCobertura = new System.Windows.Forms.Button();
            this.lstAfiliaciones = new System.Windows.Forms.ListBox();
            this.cmbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.btnBuscarTipoDocumento = new System.Windows.Forms.Button();
            this.txtNumeroPaciente = new System.Windows.Forms.TextBox();
            this.txtNumDocumento = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.dtpFechaAlta = new System.Windows.Forms.DateTimePicker();
            this.clinicaDataSet = new Presentacion.ClinicaDataSet();
            this.provinciasTableAdapter = new Presentacion.ClinicaDataSetTableAdapters.ProvinciasTableAdapter();
            this.label18 = new System.Windows.Forms.Label();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtComentarioUsuario = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.cmbCuenta = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.cmbNombreUsuario = new System.Windows.Forms.ComboBox();
            this.gbxBotonesAbm = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbxBusquedaPacientes.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clinicaDataSet)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.gbxBotonesAbm.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(366, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido:";
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(419, 95);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(338, 20);
            this.txtNombre.TabIndex = 4;
            this.txtNombre.Enter += new System.EventHandler(this.txtNombre_Enter);
            // 
            // txtApellido
            // 
            this.txtApellido.Enabled = false;
            this.txtApellido.Location = new System.Drawing.Point(108, 95);
            this.txtApellido.MaxLength = 50;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(245, 20);
            this.txtApellido.TabIndex = 3;
            this.txtApellido.Enter += new System.EventHandler(this.txtApellido_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbTipoTelefono);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.btnQuitarTelefono);
            this.groupBox1.Controls.Add(this.btnAgregarTelefono);
            this.groupBox1.Controls.Add(this.lstTelefonos);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(392, 310);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 96);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Teléfonos";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cmbTipoTelefono
            // 
            this.cmbTipoTelefono.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoTelefono.FormattingEnabled = true;
            this.cmbTipoTelefono.Items.AddRange(new object[] {
            "Personal",
            "Casa",
            "Trabajo"});
            this.cmbTipoTelefono.Location = new System.Drawing.Point(148, 19);
            this.cmbTipoTelefono.Name = "cmbTipoTelefono";
            this.cmbTipoTelefono.Size = new System.Drawing.Size(130, 21);
            this.cmbTipoTelefono.TabIndex = 1;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(9, 20);
            this.txtTelefono.MaxLength = 50;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(133, 20);
            this.txtTelefono.TabIndex = 0;
            this.txtTelefono.Enter += new System.EventHandler(this.txtTelefono_Enter);
            // 
            // btnQuitarTelefono
            // 
            this.btnQuitarTelefono.Image = ((System.Drawing.Image)(resources.GetObject("btnQuitarTelefono.Image")));
            this.btnQuitarTelefono.Location = new System.Drawing.Point(321, 19);
            this.btnQuitarTelefono.Name = "btnQuitarTelefono";
            this.btnQuitarTelefono.Size = new System.Drawing.Size(31, 21);
            this.btnQuitarTelefono.TabIndex = 3;
            this.btnQuitarTelefono.UseVisualStyleBackColor = true;
            this.btnQuitarTelefono.Click += new System.EventHandler(this.btnQuitarTelefono_Click);
            // 
            // btnAgregarTelefono
            // 
            this.btnAgregarTelefono.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarTelefono.Image")));
            this.btnAgregarTelefono.Location = new System.Drawing.Point(284, 19);
            this.btnAgregarTelefono.Name = "btnAgregarTelefono";
            this.btnAgregarTelefono.Size = new System.Drawing.Size(31, 21);
            this.btnAgregarTelefono.TabIndex = 2;
            this.btnAgregarTelefono.UseVisualStyleBackColor = true;
            this.btnAgregarTelefono.Click += new System.EventHandler(this.btnAgregarTelefono_Click);
            // 
            // lstTelefonos
            // 
            this.lstTelefonos.FormattingEnabled = true;
            this.lstTelefonos.Location = new System.Drawing.Point(9, 47);
            this.lstTelefonos.Name = "lstTelefonos";
            this.lstTelefonos.Size = new System.Drawing.Size(343, 43);
            this.lstTelefonos.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCorreo);
            this.groupBox2.Controls.Add(this.btnQuitarCorreo);
            this.groupBox2.Controls.Add(this.btnAgregarCorreo);
            this.groupBox2.Controls.Add(this.lstCorreosElectronicos);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(4, 310);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(382, 96);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Correos electrónicos";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(17, 19);
            this.txtCorreo.MaxLength = 50;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(287, 20);
            this.txtCorreo.TabIndex = 0;
            this.txtCorreo.Enter += new System.EventHandler(this.txtCorreo_Enter);
            // 
            // btnQuitarCorreo
            // 
            this.btnQuitarCorreo.Image = ((System.Drawing.Image)(resources.GetObject("btnQuitarCorreo.Image")));
            this.btnQuitarCorreo.Location = new System.Drawing.Point(345, 19);
            this.btnQuitarCorreo.Name = "btnQuitarCorreo";
            this.btnQuitarCorreo.Size = new System.Drawing.Size(31, 21);
            this.btnQuitarCorreo.TabIndex = 2;
            this.btnQuitarCorreo.UseVisualStyleBackColor = true;
            this.btnQuitarCorreo.Click += new System.EventHandler(this.btnQuitarCorreo_Click);
            // 
            // btnAgregarCorreo
            // 
            this.btnAgregarCorreo.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarCorreo.Image")));
            this.btnAgregarCorreo.Location = new System.Drawing.Point(310, 19);
            this.btnAgregarCorreo.Name = "btnAgregarCorreo";
            this.btnAgregarCorreo.Size = new System.Drawing.Size(31, 21);
            this.btnAgregarCorreo.TabIndex = 1;
            this.btnAgregarCorreo.UseVisualStyleBackColor = true;
            this.btnAgregarCorreo.Click += new System.EventHandler(this.btnAgregarCorreo_Click);
            // 
            // lstCorreosElectronicos
            // 
            this.lstCorreosElectronicos.FormattingEnabled = true;
            this.lstCorreosElectronicos.Location = new System.Drawing.Point(17, 46);
            this.lstCorreosElectronicos.Name = "lstCorreosElectronicos";
            this.lstCorreosElectronicos.Size = new System.Drawing.Size(359, 43);
            this.lstCorreosElectronicos.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTorre);
            this.groupBox3.Controls.Add(this.txtDepto);
            this.groupBox3.Controls.Add(this.txtPiso);
            this.groupBox3.Controls.Add(this.txtNumeroCalle);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtCalle);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.btnBuscarBarrio);
            this.groupBox3.Controls.Add(this.btnBuscarLocalidad);
            this.groupBox3.Controls.Add(this.cmbBarrios);
            this.groupBox3.Controls.Add(this.cmbLocalidades);
            this.groupBox3.Controls.Add(this.btnBuscarDepartamento);
            this.groupBox3.Controls.Add(this.cmbDepartamentos);
            this.groupBox3.Controls.Add(this.btnBuscarProvincia);
            this.groupBox3.Controls.Add(this.cmbProvincias);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(5, 200);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(752, 104);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Domicilio";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // txtTorre
            // 
            this.txtTorre.Location = new System.Drawing.Point(566, 73);
            this.txtTorre.MaxLength = 50;
            this.txtTorre.Name = "txtTorre";
            this.txtTorre.Size = new System.Drawing.Size(35, 20);
            this.txtTorre.TabIndex = 10;
            this.txtTorre.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTorre.Enter += new System.EventHandler(this.txtDepto_Enter);
            // 
            // txtDepto
            // 
            this.txtDepto.Location = new System.Drawing.Point(708, 74);
            this.txtDepto.MaxLength = 50;
            this.txtDepto.Name = "txtDepto";
            this.txtDepto.Size = new System.Drawing.Size(35, 20);
            this.txtDepto.TabIndex = 12;
            this.txtDepto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDepto.Enter += new System.EventHandler(this.txtDepto_Enter);
            // 
            // txtPiso
            // 
            this.txtPiso.Location = new System.Drawing.Point(636, 74);
            this.txtPiso.MaxLength = 50;
            this.txtPiso.Name = "txtPiso";
            this.txtPiso.Size = new System.Drawing.Size(32, 20);
            this.txtPiso.TabIndex = 11;
            this.txtPiso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPiso.Enter += new System.EventHandler(this.txtPiso_Enter);
            // 
            // txtNumeroCalle
            // 
            this.txtNumeroCalle.Location = new System.Drawing.Point(468, 75);
            this.txtNumeroCalle.MaxLength = 50;
            this.txtNumeroCalle.Name = "txtNumeroCalle";
            this.txtNumeroCalle.Size = new System.Drawing.Size(40, 20);
            this.txtNumeroCalle.TabIndex = 9;
            this.txtNumeroCalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNumeroCalle.Enter += new System.EventHandler(this.txtNumeroCalle_Enter);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(676, 76);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Dpto:";
            this.label12.Click += new System.EventHandler(this.label11_Click);
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(83, 73);
            this.txtCalle.MaxLength = 50;
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(293, 20);
            this.txtCalle.TabIndex = 8;
            this.txtCalle.Enter += new System.EventHandler(this.txtCalle_Enter);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(528, 77);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(35, 13);
            this.label20.TabIndex = 6;
            this.label20.Text = "Torre:";
            this.label20.Click += new System.EventHandler(this.label11_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(607, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Piso:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(424, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Número:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(51, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Calle:";
            // 
            // btnBuscarBarrio
            // 
            this.btnBuscarBarrio.Location = new System.Drawing.Point(709, 46);
            this.btnBuscarBarrio.Name = "btnBuscarBarrio";
            this.btnBuscarBarrio.Size = new System.Drawing.Size(31, 21);
            this.btnBuscarBarrio.TabIndex = 7;
            this.btnBuscarBarrio.Text = "...";
            this.btnBuscarBarrio.UseVisualStyleBackColor = true;
            this.btnBuscarBarrio.Click += new System.EventHandler(this.btnBuscarBarrio_Click);
            // 
            // btnBuscarLocalidad
            // 
            this.btnBuscarLocalidad.Location = new System.Drawing.Point(345, 45);
            this.btnBuscarLocalidad.Name = "btnBuscarLocalidad";
            this.btnBuscarLocalidad.Size = new System.Drawing.Size(31, 21);
            this.btnBuscarLocalidad.TabIndex = 5;
            this.btnBuscarLocalidad.Text = "...";
            this.btnBuscarLocalidad.UseVisualStyleBackColor = true;
            this.btnBuscarLocalidad.Click += new System.EventHandler(this.btnBuscarLocalidad_Click);
            // 
            // cmbBarrios
            // 
            this.cmbBarrios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBarrios.FormattingEnabled = true;
            this.cmbBarrios.Location = new System.Drawing.Point(468, 46);
            this.cmbBarrios.Name = "cmbBarrios";
            this.cmbBarrios.Size = new System.Drawing.Size(235, 21);
            this.cmbBarrios.TabIndex = 6;
            // 
            // cmbLocalidades
            // 
            this.cmbLocalidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLocalidades.FormattingEnabled = true;
            this.cmbLocalidades.Location = new System.Drawing.Point(83, 46);
            this.cmbLocalidades.Name = "cmbLocalidades";
            this.cmbLocalidades.Size = new System.Drawing.Size(256, 21);
            this.cmbLocalidades.TabIndex = 4;
            this.cmbLocalidades.SelectedIndexChanged += new System.EventHandler(this.cmbLocalidades_SelectedIndexChanged);
            // 
            // btnBuscarDepartamento
            // 
            this.btnBuscarDepartamento.Location = new System.Drawing.Point(709, 19);
            this.btnBuscarDepartamento.Name = "btnBuscarDepartamento";
            this.btnBuscarDepartamento.Size = new System.Drawing.Size(31, 21);
            this.btnBuscarDepartamento.TabIndex = 3;
            this.btnBuscarDepartamento.Text = "...";
            this.btnBuscarDepartamento.UseVisualStyleBackColor = true;
            this.btnBuscarDepartamento.Click += new System.EventHandler(this.btnBuscarDepartamento_Click);
            // 
            // cmbDepartamentos
            // 
            this.cmbDepartamentos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartamentos.FormattingEnabled = true;
            this.cmbDepartamentos.Location = new System.Drawing.Point(468, 19);
            this.cmbDepartamentos.Name = "cmbDepartamentos";
            this.cmbDepartamentos.Size = new System.Drawing.Size(235, 21);
            this.cmbDepartamentos.TabIndex = 2;
            this.cmbDepartamentos.SelectedIndexChanged += new System.EventHandler(this.cmbDepartamentos_SelectedIndexChanged);
            // 
            // btnBuscarProvincia
            // 
            this.btnBuscarProvincia.Location = new System.Drawing.Point(345, 19);
            this.btnBuscarProvincia.Name = "btnBuscarProvincia";
            this.btnBuscarProvincia.Size = new System.Drawing.Size(31, 21);
            this.btnBuscarProvincia.TabIndex = 1;
            this.btnBuscarProvincia.Text = "...";
            this.btnBuscarProvincia.UseVisualStyleBackColor = true;
            this.btnBuscarProvincia.Click += new System.EventHandler(this.btnBuscarProvincia_Click);
            // 
            // cmbProvincias
            // 
            this.cmbProvincias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProvincias.FormattingEnabled = true;
            this.cmbProvincias.Location = new System.Drawing.Point(83, 19);
            this.cmbProvincias.Name = "cmbProvincias";
            this.cmbProvincias.Size = new System.Drawing.Size(256, 21);
            this.cmbProvincias.TabIndex = 0;
            this.cmbProvincias.SelectedIndexChanged += new System.EventHandler(this.cmbProvincias_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(394, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Departamento:";
            this.label7.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(434, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Barrio:";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Localidad:";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Provincia:";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // gbxBusquedaPacientes
            // 
            this.gbxBusquedaPacientes.Controls.Add(this.txtBuscarPaciente);
            this.gbxBusquedaPacientes.Controls.Add(this.btnBuscarPaciente);
            this.gbxBusquedaPacientes.Location = new System.Drawing.Point(5, 12);
            this.gbxBusquedaPacientes.Name = "gbxBusquedaPacientes";
            this.gbxBusquedaPacientes.Size = new System.Drawing.Size(752, 47);
            this.gbxBusquedaPacientes.TabIndex = 0;
            this.gbxBusquedaPacientes.TabStop = false;
            this.gbxBusquedaPacientes.Text = "Búsqueda de Pacientes";
            this.gbxBusquedaPacientes.Enter += new System.EventHandler(this.Pacientes_Enter);
            // 
            // txtBuscarPaciente
            // 
            this.txtBuscarPaciente.Location = new System.Drawing.Point(17, 19);
            this.txtBuscarPaciente.MaxLength = 1000;
            this.txtBuscarPaciente.Name = "txtBuscarPaciente";
            this.txtBuscarPaciente.Size = new System.Drawing.Size(295, 20);
            this.txtBuscarPaciente.TabIndex = 0;
            // 
            // btnBuscarPaciente
            // 
            this.btnBuscarPaciente.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarPaciente.Image")));
            this.btnBuscarPaciente.Location = new System.Drawing.Point(317, 19);
            this.btnBuscarPaciente.Name = "btnBuscarPaciente";
            this.btnBuscarPaciente.Size = new System.Drawing.Size(31, 21);
            this.btnBuscarPaciente.TabIndex = 1;
            this.btnBuscarPaciente.UseVisualStyleBackColor = true;
            this.btnBuscarPaciente.Click += new System.EventHandler(this.btnBuscarPaciente_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtNumeroAfiliado);
            this.groupBox4.Controls.Add(this.label26);
            this.groupBox4.Controls.Add(this.txtBusquedaCobertura);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.btnFiltrarCobertura);
            this.groupBox4.Controls.Add(this.btnQuitarCobertura);
            this.groupBox4.Controls.Add(this.btnAgregarCobertura);
            this.groupBox4.Controls.Add(this.cmbCobertura);
            this.groupBox4.Controls.Add(this.btnBuscarCobertura);
            this.groupBox4.Controls.Add(this.lstAfiliaciones);
            this.groupBox4.Enabled = false;
            this.groupBox4.Location = new System.Drawing.Point(5, 412);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(751, 124);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cobertura";
            // 
            // txtNumeroAfiliado
            // 
            this.txtNumeroAfiliado.Location = new System.Drawing.Point(524, 46);
            this.txtNumeroAfiliado.MaxLength = 50;
            this.txtNumeroAfiliado.Name = "txtNumeroAfiliado";
            this.txtNumeroAfiliado.Size = new System.Drawing.Size(144, 20);
            this.txtNumeroAfiliado.TabIndex = 6;
            this.txtNumeroAfiliado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(459, 49);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(59, 13);
            this.label26.TabIndex = 35;
            this.label26.Text = "Nº Afiliado:";
            // 
            // txtBusquedaCobertura
            // 
            this.txtBusquedaCobertura.Location = new System.Drawing.Point(73, 18);
            this.txtBusquedaCobertura.MaxLength = 1000;
            this.txtBusquedaCobertura.Name = "txtBusquedaCobertura";
            this.txtBusquedaCobertura.Size = new System.Drawing.Size(332, 20);
            this.txtBusquedaCobertura.TabIndex = 0;
            this.txtBusquedaCobertura.Enter += new System.EventHandler(this.txtBusquedaCobertura_Enter);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(13, 21);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(58, 13);
            this.label17.TabIndex = 1;
            this.label17.Text = "Búsqueda:";
            this.label17.Click += new System.EventHandler(this.label1_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(23, 48);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Nombre:";
            this.label13.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnFiltrarCobertura
            // 
            this.btnFiltrarCobertura.Image = ((System.Drawing.Image)(resources.GetObject("btnFiltrarCobertura.Image")));
            this.btnFiltrarCobertura.Location = new System.Drawing.Point(411, 17);
            this.btnFiltrarCobertura.Name = "btnFiltrarCobertura";
            this.btnFiltrarCobertura.Size = new System.Drawing.Size(31, 21);
            this.btnFiltrarCobertura.TabIndex = 1;
            this.btnFiltrarCobertura.UseVisualStyleBackColor = true;
            this.btnFiltrarCobertura.Click += new System.EventHandler(this.btnFiltrarCobertura_Click);
            // 
            // btnQuitarCobertura
            // 
            this.btnQuitarCobertura.Image = ((System.Drawing.Image)(resources.GetObject("btnQuitarCobertura.Image")));
            this.btnQuitarCobertura.Location = new System.Drawing.Point(708, 44);
            this.btnQuitarCobertura.Name = "btnQuitarCobertura";
            this.btnQuitarCobertura.Size = new System.Drawing.Size(31, 21);
            this.btnQuitarCobertura.TabIndex = 5;
            this.btnQuitarCobertura.UseVisualStyleBackColor = true;
            this.btnQuitarCobertura.Click += new System.EventHandler(this.btnQuitarCobertura_Click);
            // 
            // btnAgregarCobertura
            // 
            this.btnAgregarCobertura.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarCobertura.Image")));
            this.btnAgregarCobertura.Location = new System.Drawing.Point(673, 44);
            this.btnAgregarCobertura.Name = "btnAgregarCobertura";
            this.btnAgregarCobertura.Size = new System.Drawing.Size(31, 21);
            this.btnAgregarCobertura.TabIndex = 4;
            this.btnAgregarCobertura.UseVisualStyleBackColor = true;
            this.btnAgregarCobertura.Click += new System.EventHandler(this.btnAgregarCobertura_Click);
            // 
            // cmbCobertura
            // 
            this.cmbCobertura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCobertura.FormattingEnabled = true;
            this.cmbCobertura.Location = new System.Drawing.Point(73, 46);
            this.cmbCobertura.Name = "cmbCobertura";
            this.cmbCobertura.Size = new System.Drawing.Size(332, 21);
            this.cmbCobertura.TabIndex = 2;
            this.cmbCobertura.SelectedIndexChanged += new System.EventHandler(this.cmbCobertura_SelectedIndexChanged);
            // 
            // btnBuscarCobertura
            // 
            this.btnBuscarCobertura.Location = new System.Drawing.Point(411, 45);
            this.btnBuscarCobertura.Name = "btnBuscarCobertura";
            this.btnBuscarCobertura.Size = new System.Drawing.Size(31, 22);
            this.btnBuscarCobertura.TabIndex = 3;
            this.btnBuscarCobertura.Text = "...";
            this.btnBuscarCobertura.UseVisualStyleBackColor = true;
            this.btnBuscarCobertura.Click += new System.EventHandler(this.button17_Click);
            // 
            // lstAfiliaciones
            // 
            this.lstAfiliaciones.FormattingEnabled = true;
            this.lstAfiliaciones.Location = new System.Drawing.Point(16, 72);
            this.lstAfiliaciones.Name = "lstAfiliaciones";
            this.lstAfiliaciones.Size = new System.Drawing.Size(723, 43);
            this.lstAfiliaciones.TabIndex = 7;
            // 
            // cmbTipoDocumento
            // 
            this.cmbTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDocumento.Enabled = false;
            this.cmbTipoDocumento.FormattingEnabled = true;
            this.cmbTipoDocumento.Location = new System.Drawing.Point(108, 122);
            this.cmbTipoDocumento.Name = "cmbTipoDocumento";
            this.cmbTipoDocumento.Size = new System.Drawing.Size(119, 21);
            this.cmbTipoDocumento.TabIndex = 5;
            this.cmbTipoDocumento.SelectedIndexChanged += new System.EventHandler(this.cmbTipoDocumento_SelectedIndexChanged);
            // 
            // btnBuscarTipoDocumento
            // 
            this.btnBuscarTipoDocumento.Enabled = false;
            this.btnBuscarTipoDocumento.Location = new System.Drawing.Point(233, 122);
            this.btnBuscarTipoDocumento.Name = "btnBuscarTipoDocumento";
            this.btnBuscarTipoDocumento.Size = new System.Drawing.Size(31, 21);
            this.btnBuscarTipoDocumento.TabIndex = 6;
            this.btnBuscarTipoDocumento.Text = "...";
            this.btnBuscarTipoDocumento.UseVisualStyleBackColor = true;
            this.btnBuscarTipoDocumento.Click += new System.EventHandler(this.button9_Click_1);
            // 
            // txtNumeroPaciente
            // 
            this.txtNumeroPaciente.Enabled = false;
            this.txtNumeroPaciente.Location = new System.Drawing.Point(108, 68);
            this.txtNumeroPaciente.MaxLength = 18;
            this.txtNumeroPaciente.Name = "txtNumeroPaciente";
            this.txtNumeroPaciente.Size = new System.Drawing.Size(90, 20);
            this.txtNumeroPaciente.TabIndex = 1;
            this.txtNumeroPaciente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNumeroPaciente.Enter += new System.EventHandler(this.txtNumeroPaciente_Enter);
            // 
            // txtNumDocumento
            // 
            this.txtNumDocumento.Enabled = false;
            this.txtNumDocumento.Location = new System.Drawing.Point(372, 120);
            this.txtNumDocumento.MaxLength = 50;
            this.txtNumDocumento.Name = "txtNumDocumento";
            this.txtNumDocumento.Size = new System.Drawing.Size(90, 20);
            this.txtNumDocumento.TabIndex = 7;
            this.txtNumDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNumDocumento.Enter += new System.EventHandler(this.txtNumDocumento_Enter);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(586, 125);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 13);
            this.label15.TabIndex = 27;
            this.label15.Text = "Nacimiento:";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(22, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Tipo documento:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 71);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "Número paciente:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(270, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Número documento:";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Enabled = false;
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(650, 122);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(106, 20);
            this.dtpFechaNacimiento.TabIndex = 9;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(586, 71);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 13);
            this.label16.TabIndex = 26;
            this.label16.Text = "Fecha alta:";
            // 
            // dtpFechaAlta
            // 
            this.dtpFechaAlta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaAlta.Location = new System.Drawing.Point(652, 68);
            this.dtpFechaAlta.Name = "dtpFechaAlta";
            this.dtpFechaAlta.Size = new System.Drawing.Size(104, 20);
            this.dtpFechaAlta.TabIndex = 2;
            // 
            // clinicaDataSet
            // 
            this.clinicaDataSet.DataSetName = "ClinicaDataSet";
            this.clinicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // provinciasTableAdapter
            // 
            this.provinciasTableAdapter.ClearBeforeFill = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(471, 125);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(34, 13);
            this.label18.TabIndex = 1;
            this.label18.Text = "Sexo:";
            // 
            // cmbSexo
            // 
            this.cmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSexo.Enabled = false;
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Location = new System.Drawing.Point(511, 121);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(73, 21);
            this.cmbSexo.TabIndex = 8;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(46, 155);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(63, 13);
            this.label19.TabIndex = 28;
            this.label19.Text = "Comentario:";
            // 
            // txtComentario
            // 
            this.txtComentario.Enabled = false;
            this.txtComentario.Location = new System.Drawing.Point(108, 152);
            this.txtComentario.MaxLength = 1000;
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(648, 41);
            this.txtComentario.TabIndex = 10;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtComentarioUsuario);
            this.groupBox5.Controls.Add(this.label25);
            this.groupBox5.Controls.Add(this.cmbEstado);
            this.groupBox5.Controls.Add(this.txtContrasenia);
            this.groupBox5.Controls.Add(this.label24);
            this.groupBox5.Controls.Add(this.label23);
            this.groupBox5.Controls.Add(this.cmbCuenta);
            this.groupBox5.Controls.Add(this.label22);
            this.groupBox5.Controls.Add(this.label21);
            this.groupBox5.Controls.Add(this.cmbNombreUsuario);
            this.groupBox5.Enabled = false;
            this.groupBox5.Location = new System.Drawing.Point(3, 542);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(752, 82);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Usuario";
            // 
            // txtComentarioUsuario
            // 
            this.txtComentarioUsuario.Location = new System.Drawing.Point(73, 49);
            this.txtComentarioUsuario.MaxLength = 1000;
            this.txtComentarioUsuario.Name = "txtComentarioUsuario";
            this.txtComentarioUsuario.Size = new System.Drawing.Size(666, 20);
            this.txtComentarioUsuario.TabIndex = 4;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(7, 52);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(63, 13);
            this.label25.TabIndex = 45;
            this.label25.Text = "Comentario:";
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(618, 16);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(121, 21);
            this.cmbEstado.TabIndex = 3;
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.Location = new System.Drawing.Point(276, 16);
            this.txtContrasenia.MaxLength = 50;
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.Size = new System.Drawing.Size(100, 20);
            this.txtContrasenia.TabIndex = 1;
            this.txtContrasenia.UseSystemPasswordChar = true;
            this.txtContrasenia.TextChanged += new System.EventHandler(this.txtContrasenia_TextChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(569, 18);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(43, 13);
            this.label24.TabIndex = 42;
            this.label24.Text = "Estado:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(206, 18);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(64, 13);
            this.label23.TabIndex = 41;
            this.label23.Text = "Contraseña:";
            this.label23.Click += new System.EventHandler(this.label23_Click);
            // 
            // cmbCuenta
            // 
            this.cmbCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCuenta.FormattingEnabled = true;
            this.cmbCuenta.Location = new System.Drawing.Point(442, 15);
            this.cmbCuenta.Name = "cmbCuenta";
            this.cmbCuenta.Size = new System.Drawing.Size(121, 21);
            this.cmbCuenta.TabIndex = 2;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(392, 18);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(44, 13);
            this.label22.TabIndex = 39;
            this.label22.Text = "Cuenta:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(5, 19);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(47, 13);
            this.label21.TabIndex = 38;
            this.label21.Text = "Nombre:";
            // 
            // cmbNombreUsuario
            // 
            this.cmbNombreUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNombreUsuario.FormattingEnabled = true;
            this.cmbNombreUsuario.Location = new System.Drawing.Point(53, 16);
            this.cmbNombreUsuario.Name = "cmbNombreUsuario";
            this.cmbNombreUsuario.Size = new System.Drawing.Size(141, 21);
            this.cmbNombreUsuario.TabIndex = 0;
            // 
            // gbxBotonesAbm
            // 
            this.gbxBotonesAbm.Controls.Add(this.btnSalir);
            this.gbxBotonesAbm.Controls.Add(this.btnGuardar);
            this.gbxBotonesAbm.Controls.Add(this.btnModificar);
            this.gbxBotonesAbm.Controls.Add(this.btnCancelar);
            this.gbxBotonesAbm.Controls.Add(this.btnEliminar);
            this.gbxBotonesAbm.Controls.Add(this.btnAgregar);
            this.gbxBotonesAbm.Location = new System.Drawing.Point(78, 623);
            this.gbxBotonesAbm.Name = "gbxBotonesAbm";
            this.gbxBotonesAbm.Size = new System.Drawing.Size(648, 65);
            this.gbxBotonesAbm.TabIndex = 16;
            this.gbxBotonesAbm.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Enabled = false;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(535, 19);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(95, 32);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(423, 19);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(95, 32);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Enabled = false;
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.Location = new System.Drawing.Point(221, 19);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(95, 32);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(120, 19);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(95, 32);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(322, 19);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(95, 32);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Enabled = false;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(19, 19);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(95, 32);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // frmPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 698);
            this.Controls.Add(this.gbxBotonesAbm);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNumDocumento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtComentario);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.dtpFechaAlta);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.cmbSexo);
            this.Controls.Add(this.cmbTipoDocumento);
            this.Controls.Add(this.btnBuscarTipoDocumento);
            this.Controls.Add(this.txtNumeroPaciente);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.gbxBusquedaPacientes);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pacientes";
            this.Load += new System.EventHandler(this.Paciente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gbxBusquedaPacientes.ResumeLayout(false);
            this.gbxBusquedaPacientes.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clinicaDataSet)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.gbxBotonesAbm.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Button btnQuitarTelefono;
        private System.Windows.Forms.Button btnAgregarTelefono;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Button btnQuitarCorreo;
        private System.Windows.Forms.Button btnAgregarCorreo;
        private System.Windows.Forms.ListBox lstCorreosElectronicos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnBuscarLocalidad;
        private System.Windows.Forms.ComboBox cmbLocalidades;
        private System.Windows.Forms.Button btnBuscarDepartamento;
        private System.Windows.Forms.ComboBox cmbDepartamentos;
        private System.Windows.Forms.Button btnBuscarProvincia;
        private System.Windows.Forms.ComboBox cmbProvincias;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBuscarBarrio;
        private System.Windows.Forms.ComboBox cmbBarrios;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNumeroCalle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPiso;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDepto;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox gbxBusquedaPacientes;
        private System.Windows.Forms.TextBox txtBuscarPaciente;
        private System.Windows.Forms.Button btnBuscarPaciente;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbCobertura;
        private System.Windows.Forms.Button btnBuscarCobertura;
        private System.Windows.Forms.ComboBox cmbTipoDocumento;
        private System.Windows.Forms.Button btnBuscarTipoDocumento;
        private System.Windows.Forms.TextBox txtNumeroPaciente;
        private System.Windows.Forms.TextBox txtNumDocumento;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.ComboBox cmbTipoTelefono;
        private System.Windows.Forms.ListBox lstAfiliaciones;
        private System.Windows.Forms.Button btnQuitarCobertura;
        private System.Windows.Forms.Button btnAgregarCobertura;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker dtpFechaAlta;
        private ClinicaDataSet clinicaDataSet;
        private ClinicaDataSetTableAdapters.ProvinciasTableAdapter provinciasTableAdapter;
        private System.Windows.Forms.TextBox txtBusquedaCobertura;
        private System.Windows.Forms.Button btnFiltrarCobertura;
        private System.Windows.Forms.ListBox lstTelefonos;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.TextBox txtTorre;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cmbNombreUsuario;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cmbCuenta;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtContrasenia;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtComentarioUsuario;
        private System.Windows.Forms.TextBox txtNumeroAfiliado;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.GroupBox gbxBotonesAbm;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
    }
}