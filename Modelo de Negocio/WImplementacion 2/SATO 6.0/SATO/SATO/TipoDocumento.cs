using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Negocio;
using Entidades;

namespace Presentacion
{
    public partial class frmTiposDocumento : Form
    {
        public frmTiposDocumento()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTiposDocumento_Load(object sender, EventArgs e)
        {
            cargarGrilla();
        }

        private void cargarGrilla()
        {
            Negocio.LogicaNegocio negocio = new Negocio.LogicaNegocio();
            List<TipoDocumento> lsTiposDocumento = negocio.obtenerTodosTiposDocumento();

            foreach (TipoDocumento tipoDocumento in lsTiposDocumento)
            {
                int fila = dgvTiposDocumento.Rows.Add();
                dgvTiposDocumento.Rows[fila].Cells["numero"].Value = lsTiposDocumento[fila].IdTipoDocumento;
                dgvTiposDocumento.Rows[fila].Cells["nombre"].Value = lsTiposDocumento[fila].Nombre;
                dgvTiposDocumento.Rows[fila].Cells["sigla"].Value = lsTiposDocumento[fila].Sigla;
                dgvTiposDocumento.Rows[fila].Cells["comentario"].Value = lsTiposDocumento[fila].Comentario;
            }
        }
    }
}
