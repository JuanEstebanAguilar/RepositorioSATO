using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Negocio;

namespace Presentacion
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            /*frmLogin vtLogin = new frmLogin();
            if (vtLogin.ShowDialog() == DialogResult.OK)
            {
                Splash vtSplash=new Splash();
                vtSplash.ShowDialog();
                frmPrincipal vtPrincipal = new frmPrincipal();
                vtPrincipal.ShowDialog();
            }*/
            Application.Run(new frmAtencion());
        }
    }
}
