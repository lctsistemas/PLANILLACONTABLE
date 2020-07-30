using Login_inicio;
using Presentacion.Vista;
using System;
using System.Windows.Forms;

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
<<<<<<< HEAD
            Application.Run(new frminicio());
=======
            Application.Run(new TipoContrato());

>>>>>>> 4496efca2df9ba69dff5b760d53de3a8dd04521a
        }
    }
}
