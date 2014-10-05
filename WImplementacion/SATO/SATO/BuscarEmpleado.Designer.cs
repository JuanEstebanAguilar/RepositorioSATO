namespace Presentacion
{
    partial class BuscarEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarEmpleado));
            this.gpbBuscarEmpleado = new System.Windows.Forms.GroupBox();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpersona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idempleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.btnBuscarEmpleado = new System.Windows.Forms.Button();
            this.txtBuscarEmpleado = new System.Windows.Forms.TextBox();
            this.gpbBuscarEmpleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbBuscarEmpleado
            // 
            this.gpbBuscarEmpleado.Controls.Add(this.dgvEmpleados);
            this.gpbBuscarEmpleado.Controls.Add(this.btnBuscarEmpleado);
            this.gpbBuscarEmpleado.Controls.Add(this.txtBuscarEmpleado);
            this.gpbBuscarEmpleado.Location = new System.Drawing.Point(12, 12);
            this.gpbBuscarEmpleado.Name = "gpbBuscarEmpleado";
            this.gpbBuscarEmpleado.Size = new System.Drawing.Size(761, 660);
            this.gpbBuscarEmpleado.TabIndex = 0;
            this.gpbBuscarEmpleado.TabStop = false;
            this.gpbBuscarEmpleado.Text = "Empleados";
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.AllowUserToAddRows = false;
            this.dgvEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.legajo,
            this.idpersona,
            this.idempleado,
            this.nombre,
            this.apellido,
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
            this.dgvEmpleados.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvEmpleados.Location = new System.Drawing.Point(15, 45);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpleados.Size = new System.Drawing.Size(723, 608);
            this.dgvEmpleados.TabIndex = 3;
            this.dgvEmpleados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleados_CellDoubleClick);
            // 
            // legajo
            // 
            this.legajo.HeaderText = "Legajo";
            this.legajo.Name = "legajo";
            this.legajo.Width = 64;
            // 
            // idpersona
            // 
            this.idpersona.HeaderText = "idpersona";
            this.idpersona.Name = "idpersona";
            this.idpersona.Visible = false;
            this.idpersona.Width = 78;
            // 
            // idempleado
            // 
            this.idempleado.HeaderText = "idempleado";
            this.idempleado.Name = "idempleado";
            this.idempleado.Visible = false;
            this.idempleado.Width = 86;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.Width = 69;
            // 
            // apellido
            // 
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            this.apellido.Width = 69;
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
            // btnBuscarEmpleado
            // 
            this.btnBuscarEmpleado.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarEmpleado.Image")));
            this.btnBuscarEmpleado.Location = new System.Drawing.Point(316, 18);
            this.btnBuscarEmpleado.Name = "btnBuscarEmpleado";
            this.btnBuscarEmpleado.Size = new System.Drawing.Size(31, 21);
            this.btnBuscarEmpleado.TabIndex = 2;
            this.btnBuscarEmpleado.UseVisualStyleBackColor = true;
            this.btnBuscarEmpleado.Click += new System.EventHandler(this.btnBuscarEmpleado_Click);
            // 
            // txtBuscarEmpleado
            // 
            this.txtBuscarEmpleado.Location = new System.Drawing.Point(15, 19);
            this.txtBuscarEmpleado.Name = "txtBuscarEmpleado";
            this.txtBuscarEmpleado.Size = new System.Drawing.Size(295, 20);
            this.txtBuscarEmpleado.TabIndex = 1;
            // 
            // BuscarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 684);
            this.Controls.Add(this.gpbBuscarEmpleado);
            this.Name = "BuscarEmpleado";
            this.Text = "BuscarEmpleado";
            this.Load += new System.EventHandler(this.BuscarEmpleado_Load);
            this.gpbBuscarEmpleado.ResumeLayout(false);
            this.gpbBuscarEmpleado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbBuscarEmpleado;
        private System.Windows.Forms.TextBox txtBuscarEmpleado;
        private System.Windows.Forms.Button btnBuscarEmpleado;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpersona;
        private System.Windows.Forms.DataGridViewTextBoxColumn idempleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
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