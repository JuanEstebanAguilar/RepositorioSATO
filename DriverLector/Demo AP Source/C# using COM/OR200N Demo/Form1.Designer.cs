namespace OR200N_Demo
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該公開 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改這個方法的內容。
        ///
        /// </summary>
        private void InitializeComponent()
        {
            this.Enroll = new System.Windows.Forms.Button();
            this.Identify = new System.Windows.Forms.Button();
            this.FingerPic = new System.Windows.Forms.PictureBox();
            this.Stop = new System.Windows.Forms.Button();
            this.Status = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.FingerPic)).BeginInit();
            this.SuspendLayout();
            // 
            // Enroll
            // 
            this.Enroll.Location = new System.Drawing.Point(226, 12);
            this.Enroll.Name = "Enroll";
            this.Enroll.Size = new System.Drawing.Size(108, 39);
            this.Enroll.TabIndex = 0;
            this.Enroll.Text = "Enroll";
            this.Enroll.UseVisualStyleBackColor = true;
            this.Enroll.Click += new System.EventHandler(this.Enroll_Click);
            // 
            // Identify
            // 
            this.Identify.Location = new System.Drawing.Point(226, 72);
            this.Identify.Name = "Identify";
            this.Identify.Size = new System.Drawing.Size(108, 39);
            this.Identify.TabIndex = 1;
            this.Identify.Text = "Identify";
            this.Identify.UseVisualStyleBackColor = true;
            this.Identify.Click += new System.EventHandler(this.Identify_Click);
            // 
            // FingerPic
            // 
            this.FingerPic.Location = new System.Drawing.Point(12, 12);
            this.FingerPic.Name = "FingerPic";
            this.FingerPic.Size = new System.Drawing.Size(169, 203);
            this.FingerPic.TabIndex = 2;
            this.FingerPic.TabStop = false;
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(226, 135);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(108, 39);
            this.Stop.TabIndex = 3;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            // 
            // Status
            // 
            this.Status.Location = new System.Drawing.Point(13, 232);
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Size = new System.Drawing.Size(321, 22);
            this.Status.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 266);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.FingerPic);
            this.Controls.Add(this.Identify);
            this.Controls.Add(this.Enroll);
            this.Name = "Form1";
            this.Text = "OR200N Demo for C#";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.FingerPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Enroll;
        private System.Windows.Forms.Button Identify;
        private System.Windows.Forms.PictureBox FingerPic;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.TextBox Status;
    }
}

