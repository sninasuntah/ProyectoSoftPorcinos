using System;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace ControlPorcino
{
    static class Program
    {
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Form principal al iniciar la aplicación
            Application.Run(new PantallaPrincipal());
        }
    }
}

