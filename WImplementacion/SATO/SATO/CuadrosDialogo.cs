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
    public partial class frmCuadrosDialogo : Form
    {
        public frmCuadrosDialogo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El paciente se ha registrado correctamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desea guardar los cambios?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No se ha podido conectar con el servidor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No se ha detectado impresora", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void frmCuadrosDialogo_Load(object sender, EventArgs e)
        {

        }
    }
}
