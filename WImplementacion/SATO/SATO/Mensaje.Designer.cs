namespace Presentacion
{
    partial class frmMensaje
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
            this.flpHistorial = new System.Windows.Forms.FlowLayoutPanel();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.btnEnviarMensaje = new System.Windows.Forms.Button();
            this.bgwBuscadorDeHistorialDeMensajes = new System.ComponentModel.BackgroundWorker();
            this.bgwEnviadorDeMensajes = new System.ComponentModel.BackgroundWorker();
            this.bgwBuscadorDeNuevosMensajes = new System.ComponentModel.BackgroundWorker();
            this.bgwBuscadorDeParametros = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // flpHistorial
            // 
            this.flpHistorial.AutoScroll = true;
            this.flpHistorial.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpHistorial.Location = new System.Drawing.Point(12, 12);
            this.flpHistorial.Name = "flpHistorial";
            this.flpHistorial.Size = new System.Drawing.Size(238, 249);
            this.flpHistorial.TabIndex = 0;
            // 
            // txtMensaje
            // 
            this.txtMensaje.Location = new System.Drawing.Point(12, 272);
            this.txtMensaje.Multiline = true;
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(198, 75);
            this.txtMensaje.TabIndex = 1;
            // 
            // btnEnviarMensaje
            // 
            this.btnEnviarMensaje.Location = new System.Drawing.Point(216, 272);
            this.btnEnviarMensaje.Name = "btnEnviarMensaje";
            this.btnEnviarMensaje.Size = new System.Drawing.Size(34, 77);
            this.btnEnviarMensaje.TabIndex = 2;
            this.btnEnviarMensaje.Text = ">>";
            this.btnEnviarMensaje.UseVisualStyleBackColor = true;
            this.btnEnviarMensaje.Click += new System.EventHandler(this.btnEnviarMensaje_Click);
            // 
            // bgwBuscadorDeHistorialDeMensajes
            // 
            this.bgwBuscadorDeHistorialDeMensajes.WorkerReportsProgress = true;
            this.bgwBuscadorDeHistorialDeMensajes.WorkerSupportsCancellation = true;
            // 
            // bgwEnviadorDeMensajes
            // 
            this.bgwEnviadorDeMensajes.WorkerReportsProgress = true;
            this.bgwEnviadorDeMensajes.WorkerSupportsCancellation = true;
            // 
            // bgwBuscadorDeNuevosMensajes
            // 
            this.bgwBuscadorDeNuevosMensajes.WorkerReportsProgress = true;
            this.bgwBuscadorDeNuevosMensajes.WorkerSupportsCancellation = true;
            // 
            // bgwBuscadorDeParametros
            // 
            this.bgwBuscadorDeParametros.WorkerReportsProgress = true;
            this.bgwBuscadorDeParametros.WorkerSupportsCancellation = true;
            // 
            // frmMensaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 359);
            this.Controls.Add(this.btnEnviarMensaje);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.flpHistorial);
            this.Name = "frmMensaje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mensaje";
            this.Load += new System.EventHandler(this.frmMensaje_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpHistorial;
        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.Button btnEnviarMensaje;
        private System.ComponentModel.BackgroundWorker bgwBuscadorDeHistorialDeMensajes;
        private System.ComponentModel.BackgroundWorker bgwEnviadorDeMensajes;
        private System.ComponentModel.BackgroundWorker bgwBuscadorDeNuevosMensajes;
        private System.ComponentModel.BackgroundWorker bgwBuscadorDeParametros;
    }
}