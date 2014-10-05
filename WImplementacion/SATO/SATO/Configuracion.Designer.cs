namespace Presentacion
{
    partial class frmConfiguracion
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbFuentes = new System.Windows.Forms.ComboBox();
            this.nudTamanioFuente = new System.Windows.Forms.NumericUpDown();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnGuardarConfiguracion = new System.Windows.Forms.Button();
            this.btnCancelarConfiguracion = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTamanioFuente)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(581, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(573, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Apariencia";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnColor);
            this.groupBox1.Controls.Add(this.nudTamanioFuente);
            this.groupBox1.Controls.Add(this.cmbFuentes);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(14, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 400);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Color";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ventanas:";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(573, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Seguridad";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fuente:";
            // 
            // cmbFuentes
            // 
            this.cmbFuentes.FormattingEnabled = true;
            this.cmbFuentes.Location = new System.Drawing.Point(88, 62);
            this.cmbFuentes.Name = "cmbFuentes";
            this.cmbFuentes.Size = new System.Drawing.Size(135, 21);
            this.cmbFuentes.TabIndex = 2;
            // 
            // nudTamanioFuente
            // 
            this.nudTamanioFuente.Location = new System.Drawing.Point(244, 62);
            this.nudTamanioFuente.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudTamanioFuente.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nudTamanioFuente.Name = "nudTamanioFuente";
            this.nudTamanioFuente.Size = new System.Drawing.Size(64, 20);
            this.nudTamanioFuente.TabIndex = 3;
            this.nudTamanioFuente.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(88, 30);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(135, 23);
            this.btnColor.TabIndex = 4;
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnGuardarConfiguracion
            // 
            this.btnGuardarConfiguracion.Image = global::Presentacion.Properties.Resources.disk;
            this.btnGuardarConfiguracion.Location = new System.Drawing.Point(396, 458);
            this.btnGuardarConfiguracion.Name = "btnGuardarConfiguracion";
            this.btnGuardarConfiguracion.Size = new System.Drawing.Size(90, 31);
            this.btnGuardarConfiguracion.TabIndex = 1;
            this.btnGuardarConfiguracion.UseVisualStyleBackColor = true;
            this.btnGuardarConfiguracion.Click += new System.EventHandler(this.btnGuardarConfiguracion_Click);
            // 
            // btnCancelarConfiguracion
            // 
            this.btnCancelarConfiguracion.Image = global::Presentacion.Properties.Resources.cross;
            this.btnCancelarConfiguracion.Location = new System.Drawing.Point(492, 458);
            this.btnCancelarConfiguracion.Name = "btnCancelarConfiguracion";
            this.btnCancelarConfiguracion.Size = new System.Drawing.Size(85, 31);
            this.btnCancelarConfiguracion.TabIndex = 2;
            this.btnCancelarConfiguracion.UseVisualStyleBackColor = true;
            // 
            // frmConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 493);
            this.Controls.Add(this.btnCancelarConfiguracion);
            this.Controls.Add(this.btnGuardarConfiguracion);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmConfiguracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuracion";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTamanioFuente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbFuentes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudTamanioFuente;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnGuardarConfiguracion;
        private System.Windows.Forms.Button btnCancelarConfiguracion;
    }
}