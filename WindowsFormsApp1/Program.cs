using System;
using System.Windows.Forms;

namespace ControlPorcino
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal de la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Configura la apariencia visual
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Form principal al iniciar la aplicación
            Application.Run(new Form1());
        }
    }
}

