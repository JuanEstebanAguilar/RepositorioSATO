namespace Presentacion
{
    partial class frmDepartamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepartamento));
            this.Pacientes = new System.Windows.Forms.GroupBox();
            this.dgvDepartamentos = new System.Windows.Forms.DataGridView();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.cmbProvincias = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comentario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pacientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // Pacientes
            // 
            this.Pacientes.Controls.Add(this.dgvDepartamentos);
            this.Pacientes.Location = new System.Drawing.Point(12, 66);
            this.Pacientes.Name = "Pacientes";
            this.Pacientes.Size = new System.Drawing.Size(641, 222);
            this.Pacientes.TabIndex = 25;
            this.Pacientes.TabStop = false;
            this.Pacientes.Text = "Departamentos";
            // 
            // dgvDepartamentos
            // 
            this.dgvDepartamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.departamento,
            this.comentario});
            this.dgvDepartamentos.Location = new System.Drawing.Point(14, 19);
            this.dgvDepartamentos.Name = "dgvDepartamentos";
            this.dgvDepartamentos.Size = new System.Drawing.Size(608, 197);
            this.dgvDepartamentos.TabIndex = 0;
            // 
            // button6
            // 
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(542, 294);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(95, 32);
            this.button6.TabIndex = 23;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(430, 294);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(95, 32);
            this.button5.TabIndex = 24;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(228, 294);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 32);
            this.button4.TabIndex = 22;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(127, 294);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 32);
            this.button3.TabIndex = 20;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(329, 294);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 32);
            this.button2.TabIndex = 21;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(26, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 32);
            this.button1.TabIndex = 19;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(85, 40);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(568, 20);
            this.textBox2.TabIndex = 17;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(374, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(279, 20);
            this.textBox1.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Comentario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(291, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Departamento:";
            // 
            // button12
            // 
            this.button12.Image = ((System.Drawing.Image)(resources.GetObject("button12.Image")));
            this.button12.Location = new System.Drawing.Point(254, 12);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(31, 21);
            this.button12.TabIndex = 27;
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // cmbProvincias
            // 
            this.cmbProvincias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProvincias.FormattingEnabled = true;
            this.cmbProvincias.Location = new System.Drawing.Point(85, 12);
            this.cmbProvincias.Name = "cmbProvincias";
            this.cmbProvincias.Size = new System.Drawing.Size(163, 21);
            this.cmbProvincias.TabIndex = 28;
            this.cmbProvincias.SelectedIndexChanged += new System.EventHandler(this.cmbProvincias_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Provincia:";
            // 
            // departamento
            // 
            this.departamento.HeaderText = "Departamento";
            this.departamento.Name = "departamento";
            // 
            // comentario
            // 
            this.comentario.HeaderText = "Comentario";
            this.comentario.Name = "comentario";
            // 
            // frmDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 338);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.cmbProvincias);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Pacientes);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmDepartamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Departamento";
            this.Load += new System.EventHandler(this.frmDepartamento_Load);
            this.Pacientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Pacientes;
        private System.Windows.Forms.DataGridView dgvDepartamentos;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.ComboBox cmbProvincias;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn departamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn comentario;
    }
}