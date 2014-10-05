namespace Presentacion
{
    partial class frmBarrio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBarrio));
            this.cmbDepartamentos = new System.Windows.Forms.ComboBox();
            this.cmbProvincias = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbxBarrios = new System.Windows.Forms.GroupBox();
            this.dgvBarrios = new System.Windows.Forms.DataGridView();
            this.idbarrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comentario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBarrio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbLocalidades = new System.Windows.Forms.ComboBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.gbxBarrios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarrios)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbDepartamentos
            // 
            this.cmbDepartamentos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartamentos.FormattingEnabled = true;
            this.cmbDepartamentos.Location = new System.Drawing.Point(406, 13);
            this.cmbDepartamentos.Name = "cmbDepartamentos";
            this.cmbDepartamentos.Size = new System.Drawing.Size(198, 21);
            this.cmbDepartamentos.TabIndex = 59;
            this.cmbDepartamentos.SelectedIndexChanged += new System.EventHandler(this.cmbDepartamentos_SelectedIndexChanged);
            // 
            // cmbProvincias
            // 
            this.cmbProvincias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProvincias.FormattingEnabled = true;
            this.cmbProvincias.Location = new System.Drawing.Point(67, 12);
            this.cmbProvincias.Name = "cmbProvincias";
            this.cmbProvincias.Size = new System.Drawing.Size(193, 21);
            this.cmbProvincias.TabIndex = 58;
            this.cmbProvincias.SelectedIndexChanged += new System.EventHandler(this.cmbProvincias_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 54;
            this.label3.Text = "Localidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 55;
            this.label4.Text = "Provincia:";
            // 
            // gbxBarrios
            // 
            this.gbxBarrios.Controls.Add(this.dgvBarrios);
            this.gbxBarrios.Location = new System.Drawing.Point(2, 93);
            this.gbxBarrios.Name = "gbxBarrios";
            this.gbxBarrios.Size = new System.Drawing.Size(641, 222);
            this.gbxBarrios.TabIndex = 53;
            this.gbxBarrios.TabStop = false;
            this.gbxBarrios.Text = "Barrios";
            // 
            // dgvBarrios
            // 
            this.dgvBarrios.AllowUserToAddRows = false;
            this.dgvBarrios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvBarrios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBarrios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idbarrio,
            this.nombre,
            this.comentario});
            this.dgvBarrios.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvBarrios.Location = new System.Drawing.Point(14, 19);
            this.dgvBarrios.Name = "dgvBarrios";
            this.dgvBarrios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvBarrios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBarrios.Size = new System.Drawing.Size(608, 197);
            this.dgvBarrios.TabIndex = 0;
            this.dgvBarrios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBarrios_CellClick);
            this.dgvBarrios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBarrios_CellContentClick);
            this.dgvBarrios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBarrios_CellDoubleClick);
            // 
            // idbarrio
            // 
            this.idbarrio.HeaderText = "";
            this.idbarrio.Name = "idbarrio";
            this.idbarrio.Visible = false;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.Width = 69;
            // 
            // comentario
            // 
            this.comentario.HeaderText = "Comentario";
            this.comentario.Name = "comentario";
            this.comentario.Width = 85;
            // 
            // txtComentario
            // 
            this.txtComentario.Enabled = false;
            this.txtComentario.Location = new System.Drawing.Point(67, 65);
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(574, 20);
            this.txtComentario.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Comentario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(323, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Departamento:";
            // 
            // txtBarrio
            // 
            this.txtBarrio.Enabled = false;
            this.txtBarrio.Location = new System.Drawing.Point(406, 39);
            this.txtBarrio.Name = "txtBarrio";
            this.txtBarrio.Size = new System.Drawing.Size(235, 20);
            this.txtBarrio.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(363, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 54;
            this.label5.Text = "Barrio:";
            // 
            // cmbLocalidades
            // 
            this.cmbLocalidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLocalidades.FormattingEnabled = true;
            this.cmbLocalidades.Location = new System.Drawing.Point(67, 38);
            this.cmbLocalidades.Name = "cmbLocalidades";
            this.cmbLocalidades.Size = new System.Drawing.Size(193, 21);
            this.cmbLocalidades.TabIndex = 58;
            this.cmbLocalidades.SelectedIndexChanged += new System.EventHandler(this.cmbLocalidades_SelectedIndexChanged);
            this.cmbLocalidades.DropDownClosed += new System.EventHandler(this.cmbLocalidades_DropDownClosed);
            // 
            // btnSalir
            // 
            this.btnSalir.Enabled = false;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(532, 355);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(95, 32);
            this.btnSalir.TabIndex = 64;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(420, 355);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(95, 32);
            this.btnGuardar.TabIndex = 65;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // btnModificar
            // 
            this.btnModificar.Enabled = false;
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.Location = new System.Drawing.Point(218, 355);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(95, 32);
            this.btnModificar.TabIndex = 63;
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(117, 355);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(95, 32);
            this.btnCancelar.TabIndex = 61;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(319, 355);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(95, 32);
            this.btnEliminar.TabIndex = 62;
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Enabled = false;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(16, 355);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(95, 32);
            this.btnAgregar.TabIndex = 60;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // frmBarrio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 399);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cmbDepartamentos);
            this.Controls.Add(this.cmbLocalidades);
            this.Controls.Add(this.cmbProvincias);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gbxBarrios);
            this.Controls.Add(this.txtComentario);
            this.Controls.Add(this.txtBarrio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmBarrio";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Barrio";
            this.Load += new System.EventHandler(this.frmBarrio_Load);
            this.gbxBarrios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarrios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDepartamentos;
        private System.Windows.Forms.ComboBox cmbProvincias;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbxBarrios;
        private System.Windows.Forms.DataGridView dgvBarrios;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBarrio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbLocalidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn idbarrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn comentario;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
    }
}