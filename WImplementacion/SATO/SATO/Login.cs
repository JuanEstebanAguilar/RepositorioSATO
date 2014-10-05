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
using System.Speech.Synthesis;
using WisSensorNLibLib;

namespace Presentacion
{
    public partial class frmLogin : Form
    {
        private SpeechSynthesizer speechSynth = new SpeechSynthesizer();
        private WisSensorN lector=new WisSensorN();
        
        public frmLogin()
        {
            InitializeComponent();
            /*foreach (InstalledVoice voice in speechSynth.GetInstalledVoices())
                listBox1.Items.Add(voice.VoiceInfo.Name);*/
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            lector.Open();
            lector.DataEvent += new _IWisSensorNEvents_DataEventEventHandler(lector_DataEvent);
        }

        private void lector_DataEvent(DATA accion, string codigo)
        {

            switch (accion)
            {
                case DATA.DATA_ENROLL:
                    //registrarHuella(codigo);
                    break;
                case DATA.DATA_IDENTIFY_CAPTURE:
                    {
                        GestorDePersonas gestorPersonas = new GestorDePersonas();
                        Persona persona = gestorPersonas.validarUsuario(codigo,lector);
                        if (persona != null)
                        {
                            speechSynth.SelectVoice("ScanSoft Isabel_Dri40_16kHz");
                            speechSynth.Speak("Bienvenida Alicia");
                            
                            MessageBox.Show("Persona reconocida", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show("Persona no reconocida", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
            }


            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Usuario usuario=new Usuario();
            usuario.Nombre=txtUsuario.Text.ToString().Trim();
            usuario.Contrasenia=txtContrasenia.Text.ToString().Trim();
            
            GestorDePersonas gestorDePersonas = new GestorDePersonas();
            Persona personaLogueada = gestorDePersonas.validarUsuario(usuario);
            if (personaLogueada != null)
            {
                SingletonPersonaLogueada.getInstancia(personaLogueada);
                //speechSynth.SelectVoice("ScanSoft Isabel_Dri40_16kHz");
                //speechSynth.Speak("Bienvenida "+personaLogueada.Nombre.ToString());
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                //MessageBox.Show("Verifique los datos ingresados", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                //speechSynth.SelectVoice("ScanSoft Isabel_Dri40_16kHz");
                //speechSynth.Speak("Verifique los datos ingresados");
                txtContrasenia.Text = "";
                txtUsuario.Text = "";
                txtUsuario.Focus();
            }
            //"ScanSoft Isabel_Dri40_16kHz"
            
            //speechSynth.SelectVoice(listBox1.SelectedItem.ToString());
            

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHuella_Click(object sender, EventArgs e)
        {
            lector.IdentifyCapture();
        }

        
    }
}
