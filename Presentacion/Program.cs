using Login_inicio;
using Presentacion.Vista;
using System;
using System.Windows.Forms;

using Presentacion.Subvista;

namespace Presentacion
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.o
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
            Application.Run(new frmcargo());
=======
            Application.Run(new Banco2());

>>>>>>> 1eaf8bed196a6fa14c75ddf6b3555f893388787b

        }
    }
}
