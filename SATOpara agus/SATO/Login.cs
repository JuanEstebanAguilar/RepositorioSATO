using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String usuario = txtUsuario.Text;
            if ((txtUsuario.Text.Equals("admin") && txtContrasenia.Text.Equals("admin")) || (txtUsuario.Text.Equals("aramirez") && txtContrasenia.Text.Equals("aramirez")))
            {
                frmPrincipal vtPrincipal = new frmPrincipal();
                vtPrincipal.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Verifique usuario y contraseña", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
