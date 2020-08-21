using Login_inicio;
using PlayerUI;
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
            Application.Run(new Manto_Regimen());

=======
            Application.Run(new frminicio());
>>>>>>> MCarlos
        }
    }
}
