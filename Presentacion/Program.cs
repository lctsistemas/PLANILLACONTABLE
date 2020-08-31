using Login_inicio;
using PlayerUI;
using Presentacion.Subvista;
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

            Application.Run(new Planilla());
=======
            Application.Run(new frmempleado());
>>>>>>> ddadd6181db422d25343eb35860ad50401db70fd

        }
    }
}
