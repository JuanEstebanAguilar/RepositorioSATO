namespace Presentacion
{
    partial class frmAtencion
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabatencion = new System.Windows.Forms.TabPage();
            this.btnDiagramar = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.flyp2 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnQuitarPractica = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.listaPracticas = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbPracticas = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtObservacionPrescripcion = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.listaMedicamentos = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtdia = new System.Windows.Forms.TextBox();
            this.txthoras = new System.Windows.Forms.TextBox();
            this.txtnumeroComprimidos = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbMedicamentos = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.lstenfermedades = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtObservacionesDiagnostico = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbEnfermedades = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtObservacionesDatosAtencion = new System.Windows.Forms.TextBox();
            this.drogadiccion = new System.Windows.Forms.CheckBox();
            this.alcoholismo = new System.Windows.Forms.CheckBox();
            this.tabaquismo = new System.Windows.Forms.CheckBox();
            this.tuberculosis = new System.Windows.Forms.CheckBox();
            this.epilepsia = new System.Windows.Forms.CheckBox();
            this.congenitos = new System.Windows.Forms.CheckBox();
            this.alergias = new System.Windows.Forms.CheckBox();
            this.asma = new System.Windows.Forms.CheckBox();
            this.cardiovascular = new System.Windows.Forms.CheckBox();
            this.hipertension = new System.Windows.Forms.CheckBox();
            this.cancer = new System.Windows.Forms.CheckBox();
            this.diabetes = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbTurnos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabhc = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabatencion.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabatencion);
            this.tabControl1.Controls.Add(this.tabhc);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(893, 730);
            this.tabControl1.TabIndex = 0;
            // 
            // tabatencion
            // 
            this.tabatencion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabatencion.Controls.Add(this.btnDiagramar);
            this.tabatencion.Controls.Add(this.groupBox6);
            this.tabatencion.Controls.Add(this.btnSalir);
            this.tabatencion.Controls.Add(this.btnImprimir);
            this.tabatencion.Controls.Add(this.btnGuardar);
            this.tabatencion.Controls.Add(this.btnCancelar);
            this.tabatencion.Controls.Add(this.btnNuevo);
            this.tabatencion.Controls.Add(this.groupBox2);
            this.tabatencion.Controls.Add(this.groupBox1);
            this.tabatencion.Location = new System.Drawing.Point(4, 22);
            this.tabatencion.Name = "tabatencion";
            this.tabatencion.Padding = new System.Windows.Forms.Padding(3);
            this.tabatencion.Size = new System.Drawing.Size(885, 704);
            this.tabatencion.TabIndex = 0;
            this.tabatencion.Text = "Atencion";
            this.tabatencion.Click += new System.EventHandler(this.tabatencion_Click);
            // 
            // btnDiagramar
            // 
            this.btnDiagramar.Image = global::Presentacion.Properties.Resources._16__Edit_2_;
            this.btnDiagramar.Location = new System.Drawing.Point(213, 664);
            this.btnDiagramar.Name = "btnDiagramar";
            this.btnDiagramar.Size = new System.Drawing.Size(95, 32);
            this.btnDiagramar.TabIndex = 69;
            this.btnDiagramar.UseVisualStyleBackColor = true;
            this.btnDiagramar.Click += new System.EventHandler(this.btnDiagramar_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.flyp2);
            this.groupBox6.Controls.Add(this.button1);
            this.groupBox6.Location = new System.Drawing.Point(660, 62);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(217, 372);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Estudios y analisis adjuntos";
            // 
            // flyp2
            // 
            this.flyp2.AutoScroll = true;
            this.flyp2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flyp2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flyp2.Location = new System.Drawing.Point(6, 73);
            this.flyp2.Name = "flyp2";
            this.flyp2.Size = new System.Drawing.Size(199, 288);
            this.flyp2.TabIndex = 1;
            this.flyp2.WrapContents = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Adjuntar Archivo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::Presentacion.Properties.Resources.salir;
            this.btnSalir.Location = new System.Drawing.Point(521, 664);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(95, 32);
            this.btnSalir.TabIndex = 66;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Image = global::Presentacion.Properties.Resources.printer;
            this.btnImprimir.Location = new System.Drawing.Point(420, 664);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(95, 32);
            this.btnImprimir.TabIndex = 67;
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::Presentacion.Properties.Resources.disk;
            this.btnGuardar.Location = new System.Drawing.Point(319, 664);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(95, 32);
            this.btnGuardar.TabIndex = 68;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::Presentacion.Properties.Resources.cancelar;
            this.btnCancelar.Location = new System.Drawing.Point(112, 664);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(95, 32);
            this.btnCancelar.TabIndex = 65;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::Presentacion.Properties.Resources.agregar;
            this.btnNuevo.Location = new System.Drawing.Point(11, 664);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(95, 32);
            this.btnNuevo.TabIndex = 64;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox7);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(6, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(648, 596);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de Atención";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnQuitarPractica);
            this.groupBox7.Controls.Add(this.button11);
            this.groupBox7.Controls.Add(this.listaPracticas);
            this.groupBox7.Controls.Add(this.label3);
            this.groupBox7.Controls.Add(this.cmbPracticas);
            this.groupBox7.Location = new System.Drawing.Point(6, 139);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(621, 78);
            this.groupBox7.TabIndex = 8;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Practicas";
            // 
            // btnQuitarPractica
            // 
            this.btnQuitarPractica.Image = global::Presentacion.Properties.Resources.borrar;
            this.btnQuitarPractica.Location = new System.Drawing.Point(347, 51);
            this.btnQuitarPractica.Name = "btnQuitarPractica";
            this.btnQuitarPractica.Size = new System.Drawing.Size(31, 21);
            this.btnQuitarPractica.TabIndex = 39;
            this.btnQuitarPractica.UseVisualStyleBackColor = true;
            this.btnQuitarPractica.Click += new System.EventHandler(this.btnQuitarPractica_Click);
            // 
            // button11
            // 
            this.button11.Image = global::Presentacion.Properties.Resources.agregar;
            this.button11.Location = new System.Drawing.Point(347, 24);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(31, 21);
            this.button11.TabIndex = 38;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // listaPracticas
            // 
            this.listaPracticas.FormattingEnabled = true;
            this.listaPracticas.Location = new System.Drawing.Point(384, 19);
            this.listaPracticas.Name = "listaPracticas";
            this.listaPracticas.ScrollAlwaysVisible = true;
            this.listaPracticas.Size = new System.Drawing.Size(218, 56);
            this.listaPracticas.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Practicas Realizadas:";
            // 
            // cmbPracticas
            // 
            this.cmbPracticas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPracticas.FormattingEnabled = true;
            this.cmbPracticas.Location = new System.Drawing.Point(123, 24);
            this.cmbPracticas.Name = "cmbPracticas";
            this.cmbPracticas.Size = new System.Drawing.Size(187, 21);
            this.cmbPracticas.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.button2);
            this.groupBox5.Controls.Add(this.txtObservacionPrescripcion);
            this.groupBox5.Controls.Add(this.button3);
            this.groupBox5.Controls.Add(this.listaMedicamentos);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.txtdia);
            this.groupBox5.Controls.Add(this.txthoras);
            this.groupBox5.Controls.Add(this.txtnumeroComprimidos);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.cmbMedicamentos);
            this.groupBox5.Location = new System.Drawing.Point(6, 378);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(621, 212);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Prescripción médica";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 167);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 71;
            this.label10.Text = "Observaciones:";
            // 
            // button2
            // 
            this.button2.Image = global::Presentacion.Properties.Resources.borrar;
            this.button2.Location = new System.Drawing.Point(344, 49);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(31, 21);
            this.button2.TabIndex = 41;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txtObservacionPrescripcion
            // 
            this.txtObservacionPrescripcion.Location = new System.Drawing.Point(89, 150);
            this.txtObservacionPrescripcion.Multiline = true;
            this.txtObservacionPrescripcion.Name = "txtObservacionPrescripcion";
            this.txtObservacionPrescripcion.Size = new System.Drawing.Size(513, 47);
            this.txtObservacionPrescripcion.TabIndex = 70;
            // 
            // button3
            // 
            this.button3.Image = global::Presentacion.Properties.Resources.agregar;
            this.button3.Location = new System.Drawing.Point(344, 24);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(31, 21);
            this.button3.TabIndex = 40;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listaMedicamentos
            // 
            this.listaMedicamentos.FormattingEnabled = true;
            this.listaMedicamentos.Location = new System.Drawing.Point(384, 19);
            this.listaMedicamentos.Name = "listaMedicamentos";
            this.listaMedicamentos.ScrollAlwaysVisible = true;
            this.listaMedicamentos.Size = new System.Drawing.Size(218, 56);
            this.listaMedicamentos.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "label9";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "label8";
            // 
            // txtdia
            // 
            this.txtdia.Location = new System.Drawing.Point(89, 110);
            this.txtdia.Name = "txtdia";
            this.txtdia.Size = new System.Drawing.Size(129, 20);
            this.txtdia.TabIndex = 11;
            // 
            // txthoras
            // 
            this.txthoras.Location = new System.Drawing.Point(89, 85);
            this.txthoras.Name = "txthoras";
            this.txthoras.Size = new System.Drawing.Size(129, 20);
            this.txthoras.TabIndex = 10;
            // 
            // txtnumeroComprimidos
            // 
            this.txtnumeroComprimidos.Location = new System.Drawing.Point(134, 57);
            this.txtnumeroComprimidos.Margin = new System.Windows.Forms.Padding(1, 3, 3, 3);
            this.txtnumeroComprimidos.Name = "txtnumeroComprimidos";
            this.txtnumeroComprimidos.Size = new System.Drawing.Size(129, 20);
            this.txtnumeroComprimidos.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Medicamento:";
            // 
            // cmbMedicamentos
            // 
            this.cmbMedicamentos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMedicamentos.FormattingEnabled = true;
            this.cmbMedicamentos.Location = new System.Drawing.Point(80, 24);
            this.cmbMedicamentos.Name = "cmbMedicamentos";
            this.cmbMedicamentos.Size = new System.Drawing.Size(173, 21);
            this.cmbMedicamentos.TabIndex = 6;
            this.cmbMedicamentos.SelectedIndexChanged += new System.EventHandler(this.cmbMedicamentos_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Controls.Add(this.button5);
            this.groupBox4.Controls.Add(this.lstenfermedades);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.panel1);
            this.groupBox4.Controls.Add(this.txtObservacionesDiagnostico);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.cmbEnfermedades);
            this.groupBox4.Location = new System.Drawing.Point(6, 223);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(621, 149);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Diagnóstico";
            // 
            // button4
            // 
            this.button4.Image = global::Presentacion.Properties.Resources.borrar;
            this.button4.Location = new System.Drawing.Point(347, 56);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(31, 21);
            this.button4.TabIndex = 42;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Image = global::Presentacion.Properties.Resources.agregar;
            this.button5.Location = new System.Drawing.Point(347, 29);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(31, 21);
            this.button5.TabIndex = 41;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // lstenfermedades
            // 
            this.lstenfermedades.FormattingEnabled = true;
            this.lstenfermedades.HorizontalScrollbar = true;
            this.lstenfermedades.Location = new System.Drawing.Point(384, 24);
            this.lstenfermedades.Name = "lstenfermedades";
            this.lstenfermedades.ScrollAlwaysVisible = true;
            this.lstenfermedades.Size = new System.Drawing.Size(218, 56);
            this.lstenfermedades.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(291, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Obeservaciones:";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panel1.Location = new System.Drawing.Point(10, 51);
            this.panel1.Margin = new System.Windows.Forms.Padding(1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 87);
            this.panel1.TabIndex = 2;
            this.panel1.WrapContents = false;
            // 
            // txtObservacionesDiagnostico
            // 
            this.txtObservacionesDiagnostico.Location = new System.Drawing.Point(384, 93);
            this.txtObservacionesDiagnostico.Multiline = true;
            this.txtObservacionesDiagnostico.Name = "txtObservacionesDiagnostico";
            this.txtObservacionesDiagnostico.Size = new System.Drawing.Size(218, 45);
            this.txtObservacionesDiagnostico.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Enfermedad:";
            // 
            // cmbEnfermedades
            // 
            this.cmbEnfermedades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEnfermedades.FormattingEnabled = true;
            this.cmbEnfermedades.Location = new System.Drawing.Point(80, 24);
            this.cmbEnfermedades.Name = "cmbEnfermedades";
            this.cmbEnfermedades.Size = new System.Drawing.Size(173, 21);
            this.cmbEnfermedades.TabIndex = 0;
            this.cmbEnfermedades.SelectedIndexChanged += new System.EventHandler(this.cmbEnfermedades_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtObservacionesDatosAtencion);
            this.groupBox3.Controls.Add(this.drogadiccion);
            this.groupBox3.Controls.Add(this.alcoholismo);
            this.groupBox3.Controls.Add(this.tabaquismo);
            this.groupBox3.Controls.Add(this.tuberculosis);
            this.groupBox3.Controls.Add(this.epilepsia);
            this.groupBox3.Controls.Add(this.congenitos);
            this.groupBox3.Controls.Add(this.alergias);
            this.groupBox3.Controls.Add(this.asma);
            this.groupBox3.Controls.Add(this.cardiovascular);
            this.groupBox3.Controls.Add(this.hipertension);
            this.groupBox3.Controls.Add(this.cancer);
            this.groupBox3.Controls.Add(this.diabetes);
            this.groupBox3.Location = new System.Drawing.Point(9, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(621, 114);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Antecedentes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Observaciones del paciente:";
            // 
            // txtObservacionesDatosAtencion
            // 
            this.txtObservacionesDatosAtencion.Enabled = false;
            this.txtObservacionesDatosAtencion.Location = new System.Drawing.Point(145, 73);
            this.txtObservacionesDatosAtencion.Multiline = true;
            this.txtObservacionesDatosAtencion.Name = "txtObservacionesDatosAtencion";
            this.txtObservacionesDatosAtencion.Size = new System.Drawing.Size(463, 35);
            this.txtObservacionesDatosAtencion.TabIndex = 12;
            // 
            // drogadiccion
            // 
            this.drogadiccion.AutoSize = true;
            this.drogadiccion.Location = new System.Drawing.Point(517, 42);
            this.drogadiccion.Name = "drogadiccion";
            this.drogadiccion.Size = new System.Drawing.Size(89, 17);
            this.drogadiccion.TabIndex = 11;
            this.drogadiccion.Text = "Drogadicción";
            this.drogadiccion.UseVisualStyleBackColor = true;
            // 
            // alcoholismo
            // 
            this.alcoholismo.AutoSize = true;
            this.alcoholismo.Location = new System.Drawing.Point(517, 19);
            this.alcoholismo.Name = "alcoholismo";
            this.alcoholismo.Size = new System.Drawing.Size(82, 17);
            this.alcoholismo.TabIndex = 10;
            this.alcoholismo.Text = "Alcoholismo";
            this.alcoholismo.UseVisualStyleBackColor = true;
            // 
            // tabaquismo
            // 
            this.tabaquismo.AutoSize = true;
            this.tabaquismo.Location = new System.Drawing.Point(405, 42);
            this.tabaquismo.Name = "tabaquismo";
            this.tabaquismo.Size = new System.Drawing.Size(84, 17);
            this.tabaquismo.TabIndex = 9;
            this.tabaquismo.Text = "Tabaquismo";
            this.tabaquismo.UseVisualStyleBackColor = true;
            // 
            // tuberculosis
            // 
            this.tuberculosis.AutoSize = true;
            this.tuberculosis.Location = new System.Drawing.Point(405, 19);
            this.tuberculosis.Name = "tuberculosis";
            this.tuberculosis.Size = new System.Drawing.Size(86, 17);
            this.tuberculosis.TabIndex = 8;
            this.tuberculosis.Text = "Tuberculosis";
            this.tuberculosis.UseVisualStyleBackColor = true;
            // 
            // epilepsia
            // 
            this.epilepsia.AutoSize = true;
            this.epilepsia.Location = new System.Drawing.Point(304, 42);
            this.epilepsia.Name = "epilepsia";
            this.epilepsia.Size = new System.Drawing.Size(68, 17);
            this.epilepsia.TabIndex = 7;
            this.epilepsia.Text = "Epilepsia";
            this.epilepsia.UseVisualStyleBackColor = true;
            // 
            // congenitos
            // 
            this.congenitos.AutoSize = true;
            this.congenitos.Location = new System.Drawing.Point(304, 19);
            this.congenitos.Name = "congenitos";
            this.congenitos.Size = new System.Drawing.Size(79, 17);
            this.congenitos.TabIndex = 6;
            this.congenitos.Text = "Congénitos";
            this.congenitos.UseVisualStyleBackColor = true;
            // 
            // alergias
            // 
            this.alergias.AutoSize = true;
            this.alergias.Location = new System.Drawing.Point(218, 42);
            this.alergias.Name = "alergias";
            this.alergias.Size = new System.Drawing.Size(63, 17);
            this.alergias.TabIndex = 5;
            this.alergias.Text = "Alergias";
            this.alergias.UseVisualStyleBackColor = true;
            // 
            // asma
            // 
            this.asma.AutoSize = true;
            this.asma.Location = new System.Drawing.Point(218, 19);
            this.asma.Name = "asma";
            this.asma.Size = new System.Drawing.Size(52, 17);
            this.asma.TabIndex = 4;
            this.asma.Text = "Asma";
            this.asma.UseVisualStyleBackColor = true;
            // 
            // cardiovascular
            // 
            this.cardiovascular.AutoSize = true;
            this.cardiovascular.Location = new System.Drawing.Point(106, 42);
            this.cardiovascular.Name = "cardiovascular";
            this.cardiovascular.Size = new System.Drawing.Size(96, 17);
            this.cardiovascular.TabIndex = 3;
            this.cardiovascular.Text = "Cardiovascular";
            this.cardiovascular.UseVisualStyleBackColor = true;
            // 
            // hipertension
            // 
            this.hipertension.AutoSize = true;
            this.hipertension.Location = new System.Drawing.Point(106, 19);
            this.hipertension.Name = "hipertension";
            this.hipertension.Size = new System.Drawing.Size(85, 17);
            this.hipertension.TabIndex = 2;
            this.hipertension.Text = "Hipertensión";
            this.hipertension.UseVisualStyleBackColor = true;
            // 
            // cancer
            // 
            this.cancer.AutoSize = true;
            this.cancer.Location = new System.Drawing.Point(6, 42);
            this.cancer.Name = "cancer";
            this.cancer.Size = new System.Drawing.Size(60, 17);
            this.cancer.TabIndex = 1;
            this.cancer.Text = "Cáncer";
            this.cancer.UseVisualStyleBackColor = true;
            // 
            // diabetes
            // 
            this.diabetes.AutoSize = true;
            this.diabetes.Location = new System.Drawing.Point(6, 19);
            this.diabetes.Name = "diabetes";
            this.diabetes.Size = new System.Drawing.Size(68, 17);
            this.diabetes.TabIndex = 0;
            this.diabetes.Text = "Diabetes";
            this.diabetes.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbTurnos);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(650, 47);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Turno";
            // 
            // cmbTurnos
            // 
            this.cmbTurnos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTurnos.FormattingEnabled = true;
            this.cmbTurnos.Location = new System.Drawing.Point(50, 19);
            this.cmbTurnos.Name = "cmbTurnos";
            this.cmbTurnos.Size = new System.Drawing.Size(159, 21);
            this.cmbTurnos.TabIndex = 3;
            this.cmbTurnos.SelectedIndexChanged += new System.EventHandler(this.cmbTurnos_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Turno:";
            // 
            // tabhc
            // 
            this.tabhc.Location = new System.Drawing.Point(4, 22);
            this.tabhc.Name = "tabhc";
            this.tabhc.Padding = new System.Windows.Forms.Padding(3);
            this.tabhc.Size = new System.Drawing.Size(885, 704);
            this.tabhc.TabIndex = 1;
            this.tabhc.Text = "Historias Clinicas";
            // 
            // frmAtencion
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(893, 733);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmAtencion";
            this.Text = "Atencion";
            this.Load += new System.EventHandler(this.frmAtencion_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabatencion.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabatencion;
        private System.Windows.Forms.TabPage tabhc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbTurnos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDiagramar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtObservacionesDatosAtencion;
        private System.Windows.Forms.CheckBox drogadiccion;
        private System.Windows.Forms.CheckBox alcoholismo;
        private System.Windows.Forms.CheckBox tabaquismo;
        private System.Windows.Forms.CheckBox tuberculosis;
        private System.Windows.Forms.CheckBox epilepsia;
        private System.Windows.Forms.CheckBox congenitos;
        private System.Windows.Forms.CheckBox alergias;
        private System.Windows.Forms.CheckBox asma;
        private System.Windows.Forms.CheckBox cardiovascular;
        private System.Windows.Forms.CheckBox hipertension;
        private System.Windows.Forms.CheckBox cancer;
        private System.Windows.Forms.CheckBox diabetes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbEnfermedades;
        private System.Windows.Forms.FlowLayoutPanel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtObservacionesDiagnostico;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbMedicamentos;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ListBox listaPracticas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbPracticas;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button btnQuitarPractica;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtdia;
        private System.Windows.Forms.TextBox txthoras;
        private System.Windows.Forms.TextBox txtnumeroComprimidos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listaMedicamentos;
        private System.Windows.Forms.FlowLayoutPanel flyp2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtObservacionPrescripcion;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ListBox lstenfermedades;
    }
}