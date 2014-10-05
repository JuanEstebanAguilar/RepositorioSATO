namespace Presentacion
{
    partial class frmTurnos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTurnos));
            this.cmbPaciente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbProfesional = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpHoraDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraHasta = new System.Windows.Forms.DateTimePicker();
            this.cmbPracticas = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lstPracticas = new System.Windows.Forms.ListBox();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnQuitarPractica = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnBuscarProfesional = new System.Windows.Forms.Button();
            this.btnBuscarPractica = new System.Windows.Forms.Button();
            this.btnBuscarPaciente = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pnlTurnos = new System.Windows.Forms.Panel();
            this.lblViernes = new System.Windows.Forms.Label();
            this.tlpTurnos = new System.Windows.Forms.TableLayoutPanel();
            this.lblJueves = new System.Windows.Forms.Label();
            this.lblLunes = new System.Windows.Forms.Label();
            this.lblMiercoles = new System.Windows.Forms.Label();
            this.lblMartes = new System.Windows.Forms.Label();
            this.tltTurnos = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.pnlTurnos.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbPaciente
            // 
            this.cmbPaciente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbPaciente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbPaciente.FormattingEnabled = true;
            this.cmbPaciente.Location = new System.Drawing.Point(73, 12);
            this.cmbPaciente.Name = "cmbPaciente";
            this.cmbPaciente.Size = new System.Drawing.Size(228, 21);
            this.cmbPaciente.TabIndex = 0;
            this.tltTurnos.SetToolTip(this.cmbPaciente, "Listado de pacientes registrados. En caso de no encontrar el paciente buscado\r\nin" +
                    "gresarlo en el botón");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Paciente:";
            // 
            // cmbProfesional
            // 
            this.cmbProfesional.FormattingEnabled = true;
            this.cmbProfesional.Location = new System.Drawing.Point(466, 12);
            this.cmbProfesional.Name = "cmbProfesional";
            this.cmbProfesional.Size = new System.Drawing.Size(228, 21);
            this.cmbProfesional.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(398, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Profesional:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(74, 39);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(264, 20);
            this.dtpFecha.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Fecha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(395, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Hora desde:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(565, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Hora hasta:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(398, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Comentario:";
            // 
            // dtpHoraDesde
            // 
            this.dtpHoraDesde.CustomFormat = "HH:mm tt";
            this.dtpHoraDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraDesde.Location = new System.Drawing.Point(468, 39);
            this.dtpHoraDesde.Name = "dtpHoraDesde";
            this.dtpHoraDesde.Size = new System.Drawing.Size(91, 20);
            this.dtpHoraDesde.TabIndex = 34;
            this.dtpHoraDesde.ValueChanged += new System.EventHandler(this.dtpHoraDesde_ValueChanged);
            // 
            // dtpHoraHasta
            // 
            this.dtpHoraHasta.CustomFormat = "HH:mm tt";
            this.dtpHoraHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraHasta.Location = new System.Drawing.Point(633, 39);
            this.dtpHoraHasta.Name = "dtpHoraHasta";
            this.dtpHoraHasta.Size = new System.Drawing.Size(97, 20);
            this.dtpHoraHasta.TabIndex = 34;
            // 
            // cmbPracticas
            // 
            this.cmbPracticas.FormattingEnabled = true;
            this.cmbPracticas.Location = new System.Drawing.Point(73, 66);
            this.cmbPracticas.Name = "cmbPracticas";
            this.cmbPracticas.Size = new System.Drawing.Size(229, 21);
            this.cmbPracticas.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Práctica:";
            // 
            // lstPracticas
            // 
            this.lstPracticas.FormattingEnabled = true;
            this.lstPracticas.Location = new System.Drawing.Point(75, 96);
            this.lstPracticas.Name = "lstPracticas";
            this.lstPracticas.Size = new System.Drawing.Size(226, 43);
            this.lstPracticas.TabIndex = 39;
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(466, 69);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(264, 70);
            this.txtComentario.TabIndex = 40;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(15, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(715, 94);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar";
            // 
            // btnQuitarPractica
            // 
            this.btnQuitarPractica.Image = ((System.Drawing.Image)(resources.GetObject("btnQuitarPractica.Image")));
            this.btnQuitarPractica.Location = new System.Drawing.Point(307, 118);
            this.btnQuitarPractica.Name = "btnQuitarPractica";
            this.btnQuitarPractica.Size = new System.Drawing.Size(31, 21);
            this.btnQuitarPractica.TabIndex = 38;
            this.btnQuitarPractica.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Image = ((System.Drawing.Image)(resources.GetObject("button11.Image")));
            this.button11.Location = new System.Drawing.Point(307, 96);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(31, 21);
            this.button11.TabIndex = 37;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.btnAgregarPractica_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(623, 601);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(95, 32);
            this.btnSalir.TabIndex = 29;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.Location = new System.Drawing.Point(522, 601);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(95, 32);
            this.btnImprimir.TabIndex = 30;
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(421, 601);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(95, 32);
            this.btnGuardar.TabIndex = 30;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.Location = new System.Drawing.Point(219, 601);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(95, 32);
            this.btnModificar.TabIndex = 28;
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(118, 601);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(95, 32);
            this.btnCancelar.TabIndex = 26;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(320, 601);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(95, 32);
            this.btnEliminar.TabIndex = 27;
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(17, 601);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(95, 32);
            this.btnNuevo.TabIndex = 25;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnBuscarProfesional
            // 
            this.btnBuscarProfesional.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarProfesional.Image")));
            this.btnBuscarProfesional.Location = new System.Drawing.Point(700, 11);
            this.btnBuscarProfesional.Name = "btnBuscarProfesional";
            this.btnBuscarProfesional.Size = new System.Drawing.Size(31, 21);
            this.btnBuscarProfesional.TabIndex = 2;
            this.btnBuscarProfesional.UseVisualStyleBackColor = true;
            this.btnBuscarProfesional.Click += new System.EventHandler(this.btnBuscarProfesional_Click);
            // 
            // btnBuscarPractica
            // 
            this.btnBuscarPractica.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarPractica.Image")));
            this.btnBuscarPractica.Location = new System.Drawing.Point(307, 65);
            this.btnBuscarPractica.Name = "btnBuscarPractica";
            this.btnBuscarPractica.Size = new System.Drawing.Size(31, 21);
            this.btnBuscarPractica.TabIndex = 2;
            this.btnBuscarPractica.UseVisualStyleBackColor = true;
            this.btnBuscarPractica.Click += new System.EventHandler(this.btnBuscarPractica_Click);
            // 
            // btnBuscarPaciente
            // 
            this.btnBuscarPaciente.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarPaciente.Image")));
            this.btnBuscarPaciente.Location = new System.Drawing.Point(307, 11);
            this.btnBuscarPaciente.Name = "btnBuscarPaciente";
            this.btnBuscarPaciente.Size = new System.Drawing.Size(31, 21);
            this.btnBuscarPaciente.TabIndex = 2;
            this.btnBuscarPaciente.UseVisualStyleBackColor = true;
            this.btnBuscarPaciente.Click += new System.EventHandler(this.btnBuscarPaciente_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pnlTurnos);
            this.groupBox2.Location = new System.Drawing.Point(15, 245);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(715, 350);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Turnos activos";
            // 
            // pnlTurnos
            // 
            this.pnlTurnos.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlTurnos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlTurnos.Controls.Add(this.lblViernes);
            this.pnlTurnos.Controls.Add(this.tlpTurnos);
            this.pnlTurnos.Controls.Add(this.lblJueves);
            this.pnlTurnos.Controls.Add(this.lblLunes);
            this.pnlTurnos.Controls.Add(this.lblMiercoles);
            this.pnlTurnos.Controls.Add(this.lblMartes);
            this.pnlTurnos.Location = new System.Drawing.Point(7, 41);
            this.pnlTurnos.Name = "pnlTurnos";
            this.pnlTurnos.Size = new System.Drawing.Size(698, 298);
            this.pnlTurnos.TabIndex = 42;
            // 
            // lblViernes
            // 
            this.lblViernes.AutoSize = true;
            this.lblViernes.Location = new System.Drawing.Point(591, 12);
            this.lblViernes.Name = "lblViernes";
            this.lblViernes.Size = new System.Drawing.Size(41, 13);
            this.lblViernes.TabIndex = 47;
            this.lblViernes.Text = "label12";
            // 
            // tlpTurnos
            // 
            this.tlpTurnos.AutoScroll = true;
            this.tlpTurnos.ColumnCount = 7;
            this.tlpTurnos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpTurnos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpTurnos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpTurnos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpTurnos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpTurnos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpTurnos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpTurnos.Location = new System.Drawing.Point(0, 37);
            this.tlpTurnos.Name = "tlpTurnos";
            this.tlpTurnos.RowCount = 20;
            this.tlpTurnos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpTurnos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpTurnos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpTurnos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpTurnos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpTurnos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpTurnos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpTurnos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpTurnos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpTurnos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpTurnos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpTurnos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpTurnos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpTurnos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpTurnos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpTurnos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpTurnos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpTurnos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpTurnos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpTurnos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpTurnos.Size = new System.Drawing.Size(691, 273);
            this.tlpTurnos.TabIndex = 0;
            // 
            // lblJueves
            // 
            this.lblJueves.AutoSize = true;
            this.lblJueves.Location = new System.Drawing.Point(481, 12);
            this.lblJueves.Name = "lblJueves";
            this.lblJueves.Size = new System.Drawing.Size(41, 13);
            this.lblJueves.TabIndex = 46;
            this.lblJueves.Text = "label11";
            // 
            // lblLunes
            // 
            this.lblLunes.AutoSize = true;
            this.lblLunes.Location = new System.Drawing.Point(178, 12);
            this.lblLunes.Name = "lblLunes";
            this.lblLunes.Size = new System.Drawing.Size(35, 13);
            this.lblLunes.TabIndex = 43;
            this.lblLunes.Text = "label8";
            // 
            // lblMiercoles
            // 
            this.lblMiercoles.AutoSize = true;
            this.lblMiercoles.Location = new System.Drawing.Point(374, 12);
            this.lblMiercoles.Name = "lblMiercoles";
            this.lblMiercoles.Size = new System.Drawing.Size(41, 13);
            this.lblMiercoles.TabIndex = 45;
            this.lblMiercoles.Text = "label10";
            // 
            // lblMartes
            // 
            this.lblMartes.AutoSize = true;
            this.lblMartes.Location = new System.Drawing.Point(268, 12);
            this.lblMartes.Name = "lblMartes";
            this.lblMartes.Size = new System.Drawing.Size(35, 13);
            this.lblMartes.TabIndex = 44;
            this.lblMartes.Text = "label9";
            // 
            // button1
            // 
            this.button1.Image = global::Presentacion.Properties.Resources.nonaccept;
            this.button1.Location = new System.Drawing.Point(364, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 45;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmTurnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 645);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtComentario);
            this.Controls.Add(this.lstPracticas);
            this.Controls.Add(this.btnQuitarPractica);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.cmbPracticas);
            this.Controls.Add(this.dtpHoraHasta);
            this.Controls.Add(this.dtpHoraDesde);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBuscarProfesional);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscarPractica);
            this.Controls.Add(this.btnBuscarPaciente);
            this.Controls.Add(this.cmbProfesional);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbPaciente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTurnos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Turnos";
            this.Load += new System.EventHandler(this.Turno_Load);
            this.groupBox2.ResumeLayout(false);
            this.pnlTurnos.ResumeLayout(false);
            this.pnlTurnos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPaciente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarPaciente;
        private System.Windows.Forms.ComboBox cmbProfesional;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscarProfesional;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpHoraDesde;
        private System.Windows.Forms.DateTimePicker dtpHoraHasta;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.ComboBox cmbPracticas;
        private System.Windows.Forms.Button btnBuscarPractica;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnQuitarPractica;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.ListBox lstPracticas;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel pnlTurnos;
        private System.Windows.Forms.TableLayoutPanel tlpTurnos;
        private System.Windows.Forms.Label lblViernes;
        private System.Windows.Forms.Label lblJueves;
        private System.Windows.Forms.Label lblMiercoles;
        private System.Windows.Forms.Label lblMartes;
        private System.Windows.Forms.Label lblLunes;
        private System.Windows.Forms.ToolTip tltTurnos;
        private System.Windows.Forms.Button button1;
    }
}