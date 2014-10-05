using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;

namespace Presentacion
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
            
            bgwSplash.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgwSplash_RunWorkerCompleted);
            bgwSplash.ProgressChanged += new ProgressChangedEventHandler(bgwSplash_ProgressChanged);
            bgwSplash.DoWork += new DoWorkEventHandler(bgwSplash_DoWork);
            bgwSplash.RunWorkerAsync();
        }

        void bgwSplash_DoWork(object sender, DoWorkEventArgs e)
        {
            int i;
            for (i = 1; i <= 100; i++)
            {
                bgwSplash.ReportProgress(i);
                System.Threading.Thread.Sleep(100);
            }
        }

        void bgwSplash_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pgbCarga.Value = e.ProgressPercentage;
            
        }

        void bgwSplash_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
