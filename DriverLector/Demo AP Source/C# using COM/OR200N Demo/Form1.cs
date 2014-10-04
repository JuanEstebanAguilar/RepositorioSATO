using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WisSensorNLibLib;

namespace OR200N_Demo
{
    public partial class Form1 : Form
    {
        private const int MaxUser = 10;
        WisSensorN WisObj = new WisSensorN();
        string[] DB = new string[MaxUser];
        int nEnrolled = 0;
        string indx;
        string msg;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Please make sure the scanner is plugged!!");
            WisObj.Open();
            WisObj.DataEvent += new _IWisSensorNEvents_DataEventEventHandler(WisObj_DataEvent);
            WisObj.SetDisplay((int)FingerPic.Handle);
        }

        private delegate void CompleteHandler(string bir);
        private void Complete(string str)
        {
            Status.Text = str;
        }

        private void WisObj_DataEvent(WisSensorNLibLib.DATA data, string str)
        {
            switch (data)
            {
                case DATA.DATA_ENROLL:
                    indx = nEnrolled.ToString();
                    msg = "User #" + indx + " is enrolled successfully!!";
                    this.Invoke(new CompleteHandler(Complete), new object[] { msg });
                    DB[nEnrolled] = string.Copy(str);
                    nEnrolled++;
                    break;

                case DATA.DATA_IDENTIFY_CAPTURE:
                    int nMatched;
                    nMatched = WisObj.Identify(str, DB);
                    if (nMatched < 0)
                    {
                        msg = "No valid finger matched!!";
                        this.Invoke(new CompleteHandler(Complete), new object[] { msg });
                    }
                    else
                    {
                        indx = nMatched.ToString();
                        msg = "User #" + indx + " is matched!!";
                        this.Invoke(new CompleteHandler(Complete), new object[] { msg });
                    }
                    break;

                case DATA.DATA_VERIFY_CAPTURE:
                    break;
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            WisObj.Close();
        }

        private void Enroll_Click(object sender, EventArgs e)
        {
            if (nEnrolled >= MaxUser)
            {
                MessageBox.Show("Exceed maximum enrolled number (10)!!");
            }
            else
            {
                Status.Text = "Please put your finger on the scanner!!";
                WisObj.StartEnroll();
            }
        }

        private void Identify_Click(object sender, EventArgs e)
        {
            Status.Text = "Please put your finger on the scanner!!";
            WisObj.IdentifyCapture();
        }
    }
}