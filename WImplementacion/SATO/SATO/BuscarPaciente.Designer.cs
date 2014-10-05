namespace Presentacion
{
    partial class frmBuscarPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscarPaciente));
            this.Pacientes = new System.Windows.Forms.GroupBox();
            this.txtBuscarPaciente = new System.Windows.Forms.TextBox();
            this.dgvPacientes = new System.Windows.Forms.DataGridView();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipodocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numerocalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.torre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.piso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscarPaciente = new System.Windows.Forms.Button();
            this.Pacientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // Pacientes
            // 
            this.Pacientes.Controls.Add(this.txtBuscarPaciente);
            this.Pacientes.Controls.Add(this.dgvPacientes);
            this.Pacientes.Controls.Add(this.btnBuscarPaciente);
            this.Pacientes.Location = new System.Drawing.Point(12, 12);
            this.Pacientes.Name = "Pacientes";
            this.Pacientes.Size = new System.Drawing.Size(760, 660);
            this.Pacientes.TabIndex = 0;
            this.Pacientes.TabStop = false;
            this.Pacientes.Text = "Pacientes";
            this.Pacientes.Enter += new System.EventHandler(this.Pacientes_Enter);
            // 
            // txtBuscarPaciente
            // 
            this.txtBuscarPaciente.Location = new System.Drawing.Point(17, 19);
            this.txtBuscarPaciente.MaxLength = 1000;
            this.txtBuscarPaciente.Name = "txtBuscarPaciente";
            this.txtBuscarPaciente.Size = new System.Drawing.Size(295, 20);
            this.txtBuscarPaciente.TabIndex = 0;
            // 
            // dgvPacientes
            // 
            this.dgvPacientes.AllowUserToAddRows = false;
            this.dgvPacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numero,
            this.apellido,
            this.nombre,
            this.tipodocumento,
            this.documento,
            this.provincia,
            this.departamento,
            this.localidad,
            this.barrio,
            this.calle,
            this.numerocalle,
            this.torre,
            this.piso,
            this.depto});
            this.dgvPacientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPacientes.Location = new System.Drawing.Point(17, 46);
            this.dgvPacientes.Name = "dgvPacientes";
            this.dgvPacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPacientes.Size = new System.Drawing.Size(723, 608);
            this.dgvPacientes.TabIndex = 2;
            this.dgvPacientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPacientes_CellContentClick);
            this.dgvPacientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPacientes_CellDoubleClick);
            // 
            // numero
            // 
            this.numero.HeaderText = "Número";
            this.numero.Name = "numero";
            this.numero.Width = 69;
            // 
            // apellido
            // 
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            this.apellido.Width = 69;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.Width = 69;
            // 
            // tipodocumento
            // 
            this.tipodocumento.HeaderText = "Tipo Documento";
            this.tipodocumento.Name = "tipodocumento";
            this.tipodocumento.Width = 102;
            // 
            // documento
            // 
            this.documento.HeaderText = "Documento";
            this.documento.Name = "documento";
            this.documento.Width = 87;
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
            // numerocalle
            // 
            this.numerocalle.HeaderText = "Número";
            this.numerocalle.Name = "numerocalle";
            this.numerocalle.Width = 69;
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
            this.depto.HeaderText = "Departamento";
            this.depto.Name = "depto";
            this.depto.Width = 99;
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
            // frmBuscarPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 684);
            this.Controls.Add(this.Pacientes);
            this.Name = "frmBuscarPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuscarPaciente";
            this.Load += new System.EventHandler(this.frmBuscarPaciente_Load);
            this.Pacientes.ResumeLayout(false);
            this.Pacientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Pacientes;
        private System.Windows.Forms.TextBox txtBuscarPaciente;
        private System.Windows.Forms.DataGridView dgvPacientes;
        private System.Windows.Forms.Button btnBuscarPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipodocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn provincia;
        private System.Windows.Forms.DataGridViewTextBoxColumn departamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn localidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn barrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn numerocalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn torre;
        private System.Windows.Forms.DataGridViewTextBoxColumn piso;
        private System.Windows.Forms.DataGridViewTextBoxColumn depto;
    }
}