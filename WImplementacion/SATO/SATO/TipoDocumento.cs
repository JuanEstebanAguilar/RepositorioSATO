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
        public delegate void pasarTipoDoc(String nombreTipoDoc);
        public event pasarTipoDoc tipoDocAPasar;
        private String ESTADOCONTROLES = "habilitar";
        private Boolean esNuevo;
        private Validador validador = new Validador();
        private int idTipoDocumentoSeleccionado;
        private string nombreViejo;

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
            ESTADOCONTROLES = "deshabilitar";
            habilitarControles(ESTADOCONTROLES);
            btnNuevo.Enabled = true;
            btnSalir.Enabled = true;
            grpTipoDocumentos.Enabled = true;
            

        }

        private void cargarGrilla()
        {
            GestorDePersonas gestorPersonas = new GestorDePersonas();
            List<TipoDocumento> lsTiposDocumento = gestorPersonas.obtenerTodosTiposDocumento();

            foreach (TipoDocumento tipoDocumento in lsTiposDocumento)
            {
                int fila = dgvTiposDocumento.Rows.Add();
                dgvTiposDocumento.Rows[fila].Cells["numero"].Value = lsTiposDocumento[fila].IdTipoDocumento;
                dgvTiposDocumento.Rows[fila].Cells["nombre"].Value = lsTiposDocumento[fila].Nombre;
                dgvTiposDocumento.Rows[fila].Cells["sigla"].Value = lsTiposDocumento[fila].Sigla;
                dgvTiposDocumento.Rows[fila].Cells["comentario"].Value = lsTiposDocumento[fila].Comentario;
            }
        }
        private void dgvTiposDocumento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                TipoDocumento tipodoc = new TipoDocumento();
                tipodoc.Nombre = dgvTiposDocumento[0, e.RowIndex].Value.ToString();

                tipoDocAPasar(tipodoc.Nombre);
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpiarTextBox();
            ESTADOCONTROLES = "habilitar";
            habilitarControles(ESTADOCONTROLES);
            btnNuevo.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            esNuevo = true;
        }
        private void limpiarTextBox()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = "";
                }
                if (control is GroupBox)
                {
                    foreach (Control controlHijo in control.Controls)
                    {
                        if (controlHijo is TextBox)
                        {
                            controlHijo.Text = "";
                        }
                        if (controlHijo is ListBox)
                        {
                            ListBox controlList = (ListBox)controlHijo;
                            controlList.Items.Clear();
                        }
                    }
                }
            }
        }
        private void habilitarControles(String estado)
        {
            foreach (Control textBox in this.Controls)
            {
                if (textBox is TextBox && estado.Equals("habilitar"))
                {
                    textBox.Enabled = true;
                }
                if (textBox is TextBox && estado.Equals("deshabilitar"))
                {
                    textBox.Enabled = false;
                }
            }

            foreach (Control button in this.Controls)
            {
                if (button is Button && estado.Equals("habilitar"))
                {
                    button.Enabled = true;
                }
                if (button is Button && estado.Equals("deshabilitar"))
                {
                    button.Enabled = false;
                }

            }

            foreach (Control group in this.Controls)
            {
                if (group is GroupBox && estado.Equals("habilitar"))
                {
                    group.Enabled = true;
                    if (group.HasChildren)
                    {
                        foreach (Control textBoxChild in this.Controls)
                        {
                            if (textBoxChild is TextBox && estado.Equals("habilitar"))
                            {
                                textBoxChild.Enabled = true;
                            }
                            if (textBoxChild is TextBox && estado.Equals("deshabilitar"))
                            {
                                textBoxChild.Enabled = false;
                            }
                        }
                    }

                }
                if (group is GroupBox && estado.Equals("deshabilitar"))
                {
                    group.Enabled = false;
                }
            }
            foreach (Control comboBox in this.Controls)
            {
                if (comboBox is ComboBox && estado.Equals("habilitar"))
                {
                    comboBox.Enabled = true;
                }
                if (comboBox is ComboBox && estado.Equals("deshabilitar"))
                {
                    comboBox.Enabled = false;
                }
            }
            foreach (Control dateTimePicker in this.Controls)
            {
                if (dateTimePicker is DateTimePicker && estado.Equals("habilitar"))
                {
                    dateTimePicker.Enabled = true;
                }
                if (dateTimePicker is DateTimePicker && estado.Equals("deshabilitar"))
                {
                    dateTimePicker.Enabled = false;
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarTextBox();
            ESTADOCONTROLES = "deshabilitar";
            habilitarControles(ESTADOCONTROLES);
            btnNuevo.Enabled = true;
            btnSalir.Enabled = true;
            grpTipoDocumentos.Enabled = true;
            
        }
        private Boolean guardarTipoDocumento()
        {
            String nombreTipoDoc;
            if (validador.validarString(txtNombre, "Ingrese el nombre del tipo de documento", "Atención"))
            { nombreTipoDoc = txtNombre.Text.Trim(); }
            else { return false; }

            String siglaTipoDoc;
            if (validador.validarString(txtSigla, "Ingrese la sigla del tipo de documento", "Atención"))
            { siglaTipoDoc = txtSigla.Text.Trim(); }
            else { return false; }

            String comentarioTipoDoc;
            if (validador.validarString(txtComentario, "Ingrese el comentario", "Atención"))
            { comentarioTipoDoc = txtComentario.Text.Trim(); }
            else { comentarioTipoDoc = ""; }

            TipoDocumento tipoDocumento = new TipoDocumento(nombreTipoDoc, siglaTipoDoc, comentarioTipoDoc);

            GestorDePersonas gestorPersonas = new GestorDePersonas();
            if (gestorPersonas.tomarTipoDocumento(tipoDocumento))
            {
                return true;
            }
            else
            {
                MessageBox.Show("El tipo de documento ya se encuentra registrado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }


        private Boolean modificarTipoDocumento()
        {
            String nombreTipoDocu;
            if (validador.validarString(txtNombre, "Ingrese el nombre del tipo de documento", "Atención"))
            { nombreTipoDocu = txtNombre.Text.Trim(); }
            else { return false; }

            String siglaTipoDocu;
            if (validador.validarString(txtSigla, "Ingrese la sigla del tipo de documento", "Atención"))
            { siglaTipoDocu = txtSigla.Text.Trim(); }
            else { return false; }
            
            String comentarioTipoDocu;
            if (validador.validarString(txtComentario, "Ingrese el comentario", "Atención"))
            { comentarioTipoDocu = txtComentario.Text.Trim(); }
            else { comentarioTipoDocu=""; }

            int idTipoDocSel = idTipoDocumentoSeleccionado;
            

            TipoDocumento td = new TipoDocumento(idTipoDocSel, nombreTipoDocu, siglaTipoDocu, comentarioTipoDocu);

            GestorDePersonas gestorPersonas = new GestorDePersonas();
            string mensaje = gestorPersonas.tomarModificacionTipoDocumento(td, nombreViejo);
            if (mensaje.Equals("Se modifico"))
            {
                MessageBox.Show("Empleado modificado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                if (mensaje.Equals("No se pudo modificar"))
                {
                    MessageBox.Show("El Empleado no se pudo modificar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                else
                {
                    if (mensaje.Equals("error de nombre"))
                    {

                        MessageBox.Show("El nombre del tipo de documento ya existe", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNombre.Focus();
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            ESTADOCONTROLES = "habilitar";
            habilitarControles(ESTADOCONTROLES);
            grpTipoDocumentos.Enabled = true;
            txtNombre.Enabled = true;
            btnNuevo.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            esNuevo = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (esNuevo == true)
            {
                if (guardarTipoDocumento())
                {
                    limpiarTextBox();
                    dgvTiposDocumento.Rows.Clear();
                    cargarGrilla();
                    ESTADOCONTROLES = "deshabilitar";
                    habilitarControles(ESTADOCONTROLES);
                    btnNuevo.Enabled = true;
                    btnSalir.Enabled = true;
                    grpTipoDocumentos.Enabled = true;
                    MessageBox.Show("El tipo de documento se registro exitosamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if (modificarTipoDocumento())
                {
                    limpiarTextBox();
                    limpiarTextBox();
                    dgvTiposDocumento.Rows.Clear();
                    cargarGrilla();
                    ESTADOCONTROLES = "deshabilitar";
                    habilitarControles(ESTADOCONTROLES);
                    btnNuevo.Enabled = true;
                    btnSalir.Enabled = true;
                    grpTipoDocumentos.Enabled = true;
                }
            }
        }

        private void dgvTiposDocumento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                TipoDocumento tipoDoc = new TipoDocumento();
                tipoDoc.IdTipoDocumento = Convert.ToInt32(dgvTiposDocumento[0, e.RowIndex].Value.ToString());
                GestorDePersonas gestorPersonas = new GestorDePersonas();
                tipoDoc = gestorPersonas.obtenerTipoDocumentoPorId(tipoDoc.IdTipoDocumento);
                txtNombre.Text = tipoDoc.Nombre;
                txtSigla.Text = tipoDoc.Sigla;
                txtComentario.Text = tipoDoc.Comentario;
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
                idTipoDocumentoSeleccionado = Convert.ToInt32(dgvTiposDocumento[0, e.RowIndex].Value.ToString());
                nombreViejo = tipoDoc.Nombre;
            }
        }
        private void eliminarTipoDocumento(String nombreTipoDoc)
        {
            TipoDocumento tipoDocumento = new TipoDocumento();
            tipoDocumento.Nombre = nombreTipoDoc;
            GestorDePersonas gestorPersonas = new GestorDePersonas();
            if (gestorPersonas.tomarTipoDocumentoAEliminar(tipoDocumento))
            {
                MessageBox.Show("Tipo de Documento eliminado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No se pudo eliminar el tipo de documento", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (validador.validarString(txtNombre, "Seleccione un Tipo de Documento", "Atención"))
            {
                
                ESTADOCONTROLES = "deshabilitar";
                habilitarControles(ESTADOCONTROLES);
                btnNuevo.Enabled = true;
                btnSalir.Enabled = true;
                grpTipoDocumentos.Enabled = true;

                
                eliminarTipoDocumento(txtNombre.Text.Trim());
                limpiarTextBox();
                dgvTiposDocumento.Rows.Clear();
                cargarGrilla();
            }
            else
            {
                dgvTiposDocumento.Focus();

            }
        }
    }
}
