using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Presentacion
{
    public class Validador
    {
        public Boolean validarMatricula(TextBox textBox, String mensaje, String titulo)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        public Boolean validarNumeroPaciente(TextBox textBox, String mensaje, String titulo)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
        public Boolean validarString(TextBox textBox, String mensaje, String titulo)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        public Boolean validarQuitarItemLista(ListBox lista, String mensajeListaVacia, String mensajeItemNoSeleccionado, String titulo)
        {
            if (lista.Items.Count == 0)
            {
                MessageBox.Show(mensajeListaVacia, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                if (lista.SelectedIndex < 0)
                {
                    MessageBox.Show(mensajeItemNoSeleccionado, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        public void limpiarTexBox(Form formulario)
        {
            foreach (Control control in formulario.Controls)
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
                        if (controlHijo is ComboBox && controlHijo.Name.Equals("cmbNombreUsuario"))
                        {
                            ComboBox controlCombo = (ComboBox)controlHijo;
                            controlCombo.Items.Clear();
                        }
                    }
                }
            }
        }

        public void habilitarControles(Form formulario, Boolean estado)
        {
            foreach (Control control in formulario.Controls)
            {
                if (!control.Name.Equals("gbxBusquedaPacientes") && !control.Name.Equals("gbxBotonesAbm") && !control.Name.Equals("gbxBarrios"))
                {
                    control.Enabled = estado;
                }
            }
        }
        public void habilitarTodo(Form formulario, String estado)
        {
            foreach (Control textBox in formulario.Controls)
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

            foreach (Control button in formulario.Controls)
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

            foreach (Control group in formulario.Controls)
            {
                if (group is GroupBox && estado.Equals("habilitar"))
                {
                    group.Enabled = true;
                    if (group.HasChildren)
                    {
                        foreach (Control textBoxChild in formulario.Controls)
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
            foreach (Control comboBox in formulario.Controls)
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
            foreach (Control dateTimePicker in formulario.Controls)
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

        public void manejarBotonesABM(Button botonPresionado, Button agregar, Button cancelar,
                                    Button modificar, Button eliminar, Button guardar, Button salir)
        {
            //botones: btnAgregar,btnCancelar,btnModificar,btnEliminar,btnGuardar,btnSalir
            String nombre = botonPresionado.Name;
            if (nombre.Equals("btnAgregar") || nombre.Equals("btnModificar"))
            {
                agregar.Enabled = false;
                cancelar.Enabled = true;
                modificar.Enabled = false;
                eliminar.Enabled = false;
                guardar.Enabled = true;
                salir.Enabled = false;
            }

            if (nombre.Equals("btnCancelar") || nombre.Equals("btncancelar") || nombre.Equals("btnEliminar") || nombre.Equals("btnGuardar"))
            {
                agregar.Enabled = true;
                cancelar.Enabled = false;
                modificar.Enabled = true;
                eliminar.Enabled = true;
                guardar.Enabled = false;
                salir.Enabled = true;
            }
        }
    }
}
