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
    public partial class frmProvincia : Form
    {
        public frmProvincia()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmProvincia_Load(object sender, EventArgs e) //método habilitarVentana()
        {
            cargarGrilla();
            /*GestorDomicilio gestorDomicilio = new GestorDomicilio();
            gestorDomicilio.obtenerProvincias();*/
        }

        private void cargarGrilla()
        {
            GestorDePersonas gestorDePersonas = new GestorDePersonas();
            List<Provincia> lsProvincias = gestorDePersonas.obtenerTodasProvincias();

            foreach (Provincia provincia in lsProvincias)
            {
                int fila = dgvProvincias.Rows.Add();
                dgvProvincias.Rows[fila].Cells["provincia"].Value = lsProvincias[fila].Nombre;
                dgvProvincias.Rows[fila].Cells["comentario"].Value = lsProvincias[fila].Comentario;
            }
        }
        /*private void mostrarProvincias(List<Provincia> provincias)
        {
            foreach (Provincia provincia in provincias)
            {
                int fila = dgvProvincias.Rows.Add();
                dgvProvincias.Rows[fila].Cells["provincia"].Value = provincia.Nombre;
                dgvProvincias.Rows[fila].Cells["comentario"].Value = provincia.Comentario;
            }
        }*/
    }
}
