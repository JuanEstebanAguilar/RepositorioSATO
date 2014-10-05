using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Text;
using Negocio;

namespace Presentacion
{
    public partial class frmConfiguracion : Form
    {
        private ColorDialog colorDialog;
        private InstalledFontCollection installedFont;
        public frmConfiguracion()
        {
            InitializeComponent();
            colorDialog = new ColorDialog();
            installedFont = new InstalledFontCollection();
            cargarFuentes();
            
        }

        private void cargarFuentes()
        {
            foreach (FontFamily font in installedFont.Families)
            {
                cmbFuentes.Items.Add(font.Name);
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                btnColor.BackColor = colorDialog.Color;
            }
        }

        private void btnGuardarConfiguracion_Click(object sender, EventArgs e)
        {
            GestorDeConfiguracion gestorConfiguracion = new GestorDeConfiguracion();

        }
    }
}
