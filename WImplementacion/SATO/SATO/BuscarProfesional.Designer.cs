namespace Presentacion
{
    partial class BuscarProfesional
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarProfesional));
            this.Pacientes = new System.Windows.Forms.GroupBox();
            this.txtbuscarprof = new System.Windows.Forms.TextBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.dgvProfesionales = new System.Windows.Forms.DataGridView();
            this.idprofesional = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroCalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.torre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.piso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pacientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesionales)).BeginInit();
            this.SuspendLayout();
            // 
            // Pacientes
            // 
            this.Pacientes.Controls.Add(this.txtbuscarprof);
            this.Pacientes.Controls.Add(this.btnbuscar);
            this.Pacientes.Controls.Add(this.dgvProfesionales);
            this.Pacientes.Location = new System.Drawing.Point(12, 12);
            this.Pacientes.Name = "Pacientes";
            this.Pacientes.Size = new System.Drawing.Size(745, 660);
            this.Pacientes.TabIndex = 0;
            this.Pacientes.TabStop = false;
            this.Pacientes.Text = "Profesionales";
            // 
            // txtbuscarprof
            // 
            this.txtbuscarprof.Location = new System.Drawing.Point(6, 19);
            this.txtbuscarprof.Name = "txtbuscarprof";
            this.txtbuscarprof.Size = new System.Drawing.Size(295, 20);
            this.txtbuscarprof.TabIndex = 1;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnbuscar.Image")));
            this.btnbuscar.Location = new System.Drawing.Point(307, 19);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(31, 21);
            this.btnbuscar.TabIndex = 2;
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // dgvProfesionales
            // 
            this.dgvProfesionales.AllowUserToAddRows = false;
            this.dgvProfesionales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvProfesionales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfesionales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idprofesional,
            this.matricula,
            this.nombre,
            this.apellido,
            this.tipoDocumento,
            this.nroDocumento,
            this.provincia,
            this.departamento,
            this.localidad,
            this.barrio,
            this.calle,
            this.numeroCalle,
            this.torre,
            this.piso,
            this.depto});
            this.dgvProfesionales.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvProfesionales.Location = new System.Drawing.Point(15, 45);
            this.dgvProfesionales.Name = "dgvProfesionales";
            this.dgvProfesionales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProfesionales.Size = new System.Drawing.Size(723, 608);
            this.dgvProfesionales.TabIndex = 3;
            this.dgvProfesionales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProfesionales_CellContentClick);
            this.dgvProfesionales.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProfesionales_CellDoubleClick);
            // 
            // idprofesional
            // 
            this.idprofesional.DataPropertyName = "idprofesional";
            this.idprofesional.HeaderText = "IdProfesional";
            this.idprofesional.Name = "idprofesional";
            this.idprofesional.Visible = false;
            this.idprofesional.Width = 93;
            // 
            // matricula
            // 
            this.matricula.DataPropertyName = "matricula";
            this.matricula.HeaderText = "Matricula";
            this.matricula.Name = "matricula";
            this.matricula.Width = 75;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombres";
            this.nombre.Name = "nombre";
            this.nombre.Width = 74;
            // 
            // apellido
            // 
            this.apellido.DataPropertyName = "nombre";
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            this.apellido.Width = 69;
            // 
            // tipoDocumento
            // 
            this.tipoDocumento.DataPropertyName = "documento";
            this.tipoDocumento.HeaderText = "Tipo de documento";
            this.tipoDocumento.Name = "tipoDocumento";
            this.tipoDocumento.Width = 114;
            // 
            // nroDocumento
            // 
            this.nroDocumento.HeaderText = "Nro de documento";
            this.nroDocumento.Name = "nroDocumento";
            this.nroDocumento.Width = 110;
            // 
            // provincia
            // 
            this.provincia.HeaderText = "Provincia";
            this.provincia.Name = "provincia";
            this.provincia.Width = 76;
            // 
            // departamento
            // 
            this.departamento.HeaderText = "Departamento";
            this.departamento.Name = "departamento";
            this.departamento.Width = 99;
            // 
            // localidad
            // 
            this.localidad.HeaderText = "Localidad";
            this.localidad.Name = "localidad";
            this.localidad.Width = 78;
            // 
            // barrio
            // 
            this.barrio.DataPropertyName = "barrio";
            this.barrio.HeaderText = "Barrio";
            this.barrio.Name = "barrio";
            this.barrio.Width = 59;
            // 
            // calle
            // 
            this.calle.HeaderText = "Calle";
            this.calle.Name = "calle";
            this.calle.Width = 55;
            // 
            // numeroCalle
            // 
            this.numeroCalle.HeaderText = "Número";
            this.numeroCalle.Name = "numeroCalle";
            this.numeroCalle.Width = 69;
            // 
            // torre
            // 
            this.torre.HeaderText = "Torre";
            this.torre.Name = "torre";
            this.torre.Width = 57;
            // 
            // piso
            // 
            this.piso.HeaderText = "Piso";
            this.piso.Name = "piso";
            this.piso.Width = 52;
            // 
            // depto
            // 
            this.depto.HeaderText = "Depto";
            this.depto.Name = "depto";
            this.depto.Width = 61;
            // 
            // BuscarProfesional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 684);
            this.Controls.Add(this.Pacientes);
            this.Name = "BuscarProfesional";
            this.Text = "BuscarProfesional";
            this.Load += new System.EventHandler(this.BuscarProfesional_Load);
            this.Pacientes.ResumeLayout(false);
            this.Pacientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesionales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Pacientes;
        private System.Windows.Forms.DataGridView dgvProfesionales;
        private System.Windows.Forms.TextBox txtbuscarprof;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idprofesional;
        private System.Windows.Forms.DataGridViewTextBoxColumn matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn provincia;
        private System.Windows.Forms.DataGridViewTextBoxColumn departamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn localidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn barrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroCalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn torre;
        private System.Windows.Forms.DataGridViewTextBoxColumn piso;
        private System.Windows.Forms.DataGridViewTextBoxColumn depto;
    }
}