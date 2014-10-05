using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;
using Negocio;


namespace Presentacion
{
    public partial class frmAtencion : Form
    {
        private List<object> lstGenericaEnfermedades = new List<object>();
        private List<Controles> lstControles = new List<Controles>();
        private List<Controles> lstControlesTxt=new List<Controles>();
        private List<Controles> lstControlesCheck = new List<Controles>();

        
       public frmAtencion()
        {
            InitializeComponent();
        }


        private void frmAtencion_Load(object sender, EventArgs e)
        {
            //cargarPacientes();
            cargarEnfermedades();
            //cargarPracticas();
            //cargarComentarios();
            //cargarMedicamentos();
         }

        private void cargarComentarios()
        {
            int a = 53;
            DateTime fecha;
            fecha = DateTime.Now;
            GestorDeAtenciones negocio = new GestorDeAtenciones();
            List<Turno> lstTurno = new List<Turno>();
            lstTurno = negocio.obtenerPacientePorTurno(fecha, a);

            if (lstTurno != null)
            {
                for (int i = 0; i < lstTurno.Count; i++)
                {
                    if (lstTurno[i].IdTurno == ((Turno)cmbTurnos.SelectedItem).IdTurno)
                    {
                        txtObservacionesDatosAtencion.Text = lstTurno[i].Comentario;
                    }
                }
            }

        }

        private void cargarMedicamentos()
        {
            GestorDeAtenciones negocio = new GestorDeAtenciones();
            List<Medicamento> lstMedicamento = new List<Medicamento>();
            lstMedicamento = negocio.obtenerMedicamentos();

            if (lstMedicamento != null)
            {
                foreach (Medicamento medicamento in lstMedicamento)
                {
                    cmbMedicamentos.Items.Add(medicamento);
                }
                    cmbMedicamentos.SelectedIndex = 0;
            }
        }


        private void cargarPracticas()
        {
            GestorDeAtenciones negocio = new GestorDeAtenciones();
            List<Practica> lstpracticas = new List<Practica>();
            lstpracticas = negocio.obtenerPracticas();

            if (lstpracticas != null)
            {
                foreach (Practica practica in lstpracticas)
                {   
                    cmbPracticas.Items.Add(practica);
                 }

                cmbPracticas.SelectedIndex = 0;
            }
        }
        private void cargarPacientes()
        {
            int a = 53;
            DateTime fecha;
            fecha = DateTime.Now;
            GestorDeAtenciones negocio = new GestorDeAtenciones();
            List<Turno> lstTurno = new List<Turno>();
            lstTurno = negocio.obtenerPacientePorTurno(fecha, a);

            if (lstTurno != null)
            {
                foreach (Turno turno in lstTurno)
                {
                    cmbTurnos.Items.Add(turno);
                }
                cmbTurnos.SelectedIndex = 0;
            }
        }
        
     private void cargarEnfermedades()
        {

            GestorDeAtenciones negocio = new GestorDeAtenciones();
         List<Enfermedad> lstenfermedades = new List<Enfermedad>();
         lstenfermedades = negocio.obtenerEnefermedades();

         if (lstenfermedades != null)
           {
               foreach (Enfermedad enf in lstenfermedades)
              {
                  cmbEnfermedades.Items.Add(enf);
               }
               cmbEnfermedades.SelectedIndex = 0;
           }
        
        }


     public List<Controles> obtenerControles()
     {
         int idenfermedad = ((Enfermedad)cmbEnfermedades.SelectedItem).Idenfermedad;
         GestorDeAtenciones negocio = new GestorDeAtenciones();
         List<Controles> lstcontroles = new List<Controles>();
         lstcontroles = negocio.obtenerControles(idenfermedad);
         return lstcontroles;
     }

     private void cmbEnfermedades_SelectedIndexChanged(object sender, EventArgs e)
     {
         
         bool bantxt = false;
         bool bancheck = false;
         lstControlesTxt.Clear();
         lstControlesTxt.Clear();
         lstControles.Clear();
         lstControles = obtenerControles();
         
         limpiarComponentes();


         for (int i = 0; i < lstControles.Count; i++)
           {
            if (lstControles[i].TipoControl.ToString() == "t")
             { bantxt = true;
             lstControlesTxt.Add(lstControles[i]);
             }
                if (lstControles[i].TipoControl.ToString() == "c")
                 { bancheck = true;
                 lstControlesCheck.Add(lstControles[i]);
                 }
            }

         if (bantxt == true && bancheck == true)
         {
                         
                             for(int j=0; j<lstControlesTxt.Count;j++)
                             {
                                 FlowLayoutPanel flp2 = new FlowLayoutPanel();
                                 flp2.Margin = new System.Windows.Forms.Padding(1);
                                 flp2.Margin = new System.Windows.Forms.Padding(1,7, 1, 4);
                                 flp2.AutoSize = true;
                                 Label label = new Label();
                                 label.Margin = new System.Windows.Forms.Padding(1);
                                 label.Name = lstControlesTxt[j].IdControl.ToString();
                                 label.Text = lstControlesTxt[j].Texto.ToString();
                                 label.AutoSize = true;
                                 TextBox txt = new TextBox();
                                 txt.Margin = new System.Windows.Forms.Padding(1);
                                 txt.Name = lstControlesTxt[j].IdControl.ToString();
                                 flp2.Controls.Add(label);
                                 flp2.Controls.Add(txt);

                                 panel1.Controls.Add(flp2);
                             }
                             lstControlesTxt.Clear();
                          
                             for (int i = 0; i < lstControlesCheck.Count; i++)
                             {
                                 CheckBox check = new CheckBox();
                                 check.Margin = new System.Windows.Forms.Padding(1);
                                 check.Name = lstControlesCheck[i].IdControl.ToString();
                                 check.Text = lstControlesCheck[i].Texto.ToString();
                                 check.AutoSize = true;
                                 panel1.Controls.Add(check);
                                
                             }
                             lstControlesCheck.Clear();
                          
                        }
         

        else if(bantxt==true && bancheck==false)
                {
                    for (int j = 0; j < lstControlesTxt.Count; j++)
                    {
                        FlowLayoutPanel flp2 = new FlowLayoutPanel();
                        flp2.Margin = new System.Windows.Forms.Padding(1);
                        flp2.Margin = new System.Windows.Forms.Padding(1, 7, 1, 4);
                        flp2.AutoSize = true;
                        Label label = new Label();
                        label.Margin = new System.Windows.Forms.Padding(1);
                        label.Name = lstControlesTxt[j].IdControl.ToString();
                        label.Text = lstControlesTxt[j].Texto.ToString();
                        label.AutoSize = true;
                        TextBox txt = new TextBox();
                        txt.Margin = new System.Windows.Forms.Padding(1);
                        txt.Name = lstControlesTxt[j].IdControl.ToString();
                        flp2.Controls.Add(label);
                        flp2.Controls.Add(txt);

                        panel1.Controls.Add(flp2);
                    }
                    lstControlesTxt.Clear();
                 }

         else if (bantxt == false && bancheck == true)
         {
             for (int i = 0; i < lstControlesCheck.Count; i++)
             {
                 CheckBox check = new CheckBox();
                 check.Margin = new System.Windows.Forms.Padding(1);
                 check.Name = lstControlesCheck[i].IdControl.ToString();
                 check.Text = lstControlesCheck[i].Texto.ToString();
                 check.AutoSize = true;
                 panel1.Controls.Add(check);

             }
             lstControlesCheck.Clear();
         }
}



     private void limpiarComponentes()
     {
        

             foreach (Control c in panel1.Controls)
             {
                 panel1.Controls.Remove(c);
             }


             foreach (Control c in panel1.Controls)
             {
                 panel1.Controls.Remove(c);
             }

             foreach (Control c in panel1.Controls)
             {
                 panel1.Controls.Remove(c);
             }
             foreach (Control c in panel1.Controls)
             {
                 panel1.Controls.Remove(c);
             }
             foreach (Control c in panel1.Controls)
             {
                 panel1.Controls.Remove(c);
             }
             foreach (Control c in panel1.Controls)
             {
                 panel1.Controls.Remove(c);
             }
             foreach (Control c in panel1.Controls)
             {
                 panel1.Controls.Remove(c);
             }
             foreach (Control c in panel1.Controls)
             {
                 panel1.Controls.Remove(c);
             }
        
       
    
     }

     private void tabatencion_Click(object sender, EventArgs e)
     {

     }

     private void cmbTurnos_SelectedIndexChanged(object sender, EventArgs e)
     {
         cargarComentarios();
     }

   

     private void button11_Click(object sender, EventArgs e)
     {
         if (cmbPracticas.Items.Count > 0 && cmbPracticas.SelectedIndex >= 0)
         {
             Practica practica = (Practica)cmbPracticas.SelectedItem;
             listaPracticas.Items.Add(practica);
             listaPracticas.SelectedIndex = 0;
         }
     }

     private void btnQuitarPractica_Click(object sender, EventArgs e)
     {
         Validador validador = new Validador();
         if (validador.validarQuitarItemLista(listaPracticas, "No hay practicas para quitar", "Seleccione una practica", "Atención"))
         { listaPracticas.Items.RemoveAt(listaPracticas.SelectedIndex); }
         else
         { }
     }

     private void cmbMedicamentos_SelectedIndexChanged(object sender, EventArgs e)
     {

         if (((Medicamento)cmbMedicamentos.SelectedItem).Presentacion.IdPresentacion == 1)
         {
             label7.Text = "Numero de comprimidos:";
             label7.AutoSize = true;
             label8.Text = "Cada (horas):";
             label8.AutoSize = true;
             label9.Text = "Durante (dias):";
             label9.AutoSize = true;
         }

         else if (((Medicamento)cmbMedicamentos.SelectedItem).Presentacion.IdPresentacion == 2)
         {
             label7.Text = "Volumen en ml o cm3:";
             label7.AutoSize = true;
             label8.Text = "Cada (horas):";
             label8.AutoSize = true;
             label9.Text = "Durante (dias):";
             label9.AutoSize = true;
     }

         else if (((Medicamento)cmbMedicamentos.SelectedItem).Presentacion.IdPresentacion == 3)
         {
             label7.Text = "Volumen en ml o cm3:";
             label7.AutoSize = true;
             label8.Text = "Cada (horas):";
             label8.AutoSize = true;
             label9.Text = "Durante (dias):";
             label9.AutoSize = true;
    }

         else if (((Medicamento)cmbMedicamentos.SelectedItem).Presentacion.IdPresentacion == 4)
         {
             label7.Text = "Volumen en gramos:";
             label7.AutoSize = true;
             label8.Text = "Cada (horas):";
             label8.AutoSize = true;
             label9.Text = "Durante (dias):";
             label9.AutoSize = true;
  }


         else if (((Medicamento)cmbMedicamentos.SelectedItem).Presentacion.IdPresentacion == 5)
         {
             label7.Text = "Numero de gotas:";
             label7.AutoSize = true;
             label8.Text = "Cada (horas):";
             label8.AutoSize = true;
             label9.Text = "Durante (dias):";
             label9.AutoSize = true;


         }


     }
    OpenFileDialog ofd = new OpenFileDialog();
     private void button1_Click(object sender, EventArgs e)
     {
              if (ofd.ShowDialog() == DialogResult.OK)
         {
             string direccion = ofd.FileName;
             string nombrearchivo = ofd.SafeFileName;

             FlowLayoutPanel flp1 = new FlowLayoutPanel();
             flp1.Margin = new System.Windows.Forms.Padding(1, 7, 1, 4);
             flp1.Name = nombrearchivo;
             flp1.Size = new Size(411,30);
           
             Label labeldireccion = new Label();
             labeldireccion.Margin = new System.Windows.Forms.Padding(1);
             labeldireccion.Name = nombrearchivo;
             Font fuente = new Font("Arial", 8, FontStyle.Bold);
             labeldireccion.Font = fuente;
             labeldireccion.Text = nombrearchivo;
             labeldireccion.Size = new Size(100, 30);
             Button btneliminar = new Button();
             btneliminar.Margin = new System.Windows.Forms.Padding(1);
             btneliminar.Name = nombrearchivo;
             btneliminar.Size = new Size(31,21);
             btneliminar.Image = global::Presentacion.Properties.Resources.borrar;
             btneliminar.Click += new EventHandler(btneliminar_Click);
             
             flp1.Controls.Add(labeldireccion);
             flp1.Controls.Add(btneliminar);
             flyp2.Controls.Add(flp1);
  }

     }

     void btneliminar_Click(object sender, EventArgs e)
     {

         string ideliminar = Convert.ToString(((Button)sender).Name.ToString());
         flyp2.Controls.RemoveByKey(ideliminar);
     }

     private void button5_Click(object sender, EventArgs e)
     {   int a= ((Enfermedad)cmbEnfermedades.SelectedItem).Idenfermedad;

         switch (a)
         {  case 1:

                 Atigmatismo atigmatismo = new Atigmatismo();
 
                 foreach(Control control1 in panel1.Controls)
                 { 
                     if (control1 is FlowLayoutPanel)
                     {
                         foreach (Control control in control1.Controls)
                         {
                             if (control is TextBox && control.Name == "1")
                             {int rangoderecho;

                             if (control.Text == "")
                             { rangoderecho = 0; }

                             else
                             {
                            rangoderecho = Convert.ToInt32(control.Text.ToString());
                              }
                             atigmatismo.RangoDerecho = rangoderecho;
                          
                             }
                             else if (control is TextBox && control.Name == "2")
                             {
                                 int rangoizquierdo;
                                 if (control.Text == "")
                                 { rangoizquierdo = 0; }

                                 else
                                 {
                                     rangoizquierdo = Convert.ToInt32(control.Text.ToString());
                                 }

                                 atigmatismo.RangoIzquierdo = rangoizquierdo;
                             }
                           }
                         }
                     }
                 atigmatismo.IdEnfermedad = 1;
                 lstenfermedades.Items.Add(atigmatismo);
             break;
 
             case 2:
                 
             Miopia miopia = new Miopia();
               
             foreach (Control control1 in panel1.Controls)
                 {
                     if (control1 is FlowLayoutPanel)
                     {

                         foreach (Control control in control1.Controls)
                         {
                             if (control is TextBox && control.Name == "6")
                             {
                                 int rangoderecho;

                                 if (control.Text == "")
                                 { rangoderecho = 0; }
                                 else
                                 {
                                     rangoderecho = Convert.ToInt32(control.Text.ToString());
                                     
                                 }
                                 miopia.Rangoderecho = rangoderecho;
                             }

                             else if (control is TextBox && control.Name == "10")
                             {
                                 int rangoizquierdo;
                                 if (control.Text == "")
                                 { rangoizquierdo = 0; }

                                 else
                                 {
                                     rangoizquierdo = Convert.ToInt32(control.Text.ToString());

                                 }
                                 miopia.Rangoizquierdo = rangoizquierdo;
                             }
                         }
                      }
                     else if (control1 is CheckBox && control1.Name == "3")
                     {
                         int al;
                         if (((CheckBox)control1).Checked)
                         { al = 1; }
                         else { al = 0; }

                         miopia.OjoDerecho = al;
                     }

                     else if (control1 is CheckBox && control1.Name == "4")
                     {
                         int al;
                         if (((CheckBox)control1).Checked)
                         { al = 1; }
                         else { al = 0; }
                         miopia.OjoIzquierdo = al;
                     }
                 
                 }
             miopia.IdEnfermedad = 2;
             lstenfermedades.Items.Add(miopia);
            break;
         }
     }

     private void btnGuardar_Click(object sender, EventArgs e)
     {
         
         // Creo las practicas
         
         List<Practica> practicas = new List<Practica>();

         foreach(Practica practica in listaPracticas.Items)
               
         {practicas.Add(practica);        
         }

         
         //Creo el diagnostico
         Diagnostico diagnostico = new Diagnostico();
         List<object> listaEnfermedades = new List<object>();         

         foreach(object ob in lstenfermedades.Items)
         {
             listaEnfermedades.Add(ob);
         }

         string observacionesDiagnostico;

         observacionesDiagnostico = txtObservacionesDiagnostico.Text;

         diagnostico.ListEnfermedades = listaEnfermedades;
         diagnostico.Observaciones = observacionesDiagnostico;


        //Creo la prescripcion
         Prescripcion prescripcion = new Prescripcion();
         prescripcion.Listamedicamentos = new List<Medicamento>();
         prescripcion.Horas = Convert.ToInt32(txthoras.Text.ToString());
         prescripcion.Dias = Convert.ToInt32(txtdia.Text.ToString());
         prescripcion.CantidadMedicamentos = Convert.ToInt32(txtnumeroComprimidos.Text.ToString());

         string observacionprescripcion;
         observacionprescripcion = txtObservacionPrescripcion.Text;

         foreach (Medicamento med in listaMedicamentos.Items)
         {
                         
             prescripcion.Listamedicamentos.Add(med);
             prescripcion.CantidadMedicamentos = med.Cantidad;
             prescripcion.Dias = med.Dias;
             prescripcion.Horas = med.Horas;
         }
         prescripcion.Observacion = observacionprescripcion;

         GestorDeAtenciones logica = new GestorDeAtenciones();
         DateTime fecha = DateTime.Now;
         Turno turno = ((Turno)cmbTurnos.SelectedItem);

         if (logica.tomarAtencion(practicas, diagnostico, prescripcion, fecha, turno) == true)
         { MessageBox.Show("Atencion registrada con exito", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
         this.Close();
         }
         else { MessageBox.Show("No se ha podido registrar la atencion", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information); }
     
     
     }

     private void button3_Click(object sender, EventArgs e)
     {

         Medicamento medicamento = new Medicamento();
         medicamento = (Medicamento)cmbMedicamentos.SelectedItem;
         medicamento.Cantidad = Convert.ToDouble(txtnumeroComprimidos.Text.ToString());
         medicamento.Dias = Convert.ToInt32(txtdia.Text.ToString());
         medicamento.Horas = Convert.ToInt32(txthoras.Text.ToString());
         listaMedicamentos.Items.Add(medicamento);


     }

     private void btnDiagramar_Click(object sender, EventArgs e)
     {

     }

     private void btnSalir_Click(object sender, EventArgs e)
     {

     }

     private void btnCancelar_Click(object sender, EventArgs e)
     {

     }

     private void btnNuevo_Click(object sender, EventArgs e)
     {

     }
  }
}
