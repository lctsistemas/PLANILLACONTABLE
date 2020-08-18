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
<<<<<<< HEAD
            Application.SetCompatibleTextRenderingDefault(false);
           
            Application.Run(new Main_Principal());
=======
            Application.SetCompatibleTextRenderingDefault(false);         
            Application.Run(new frmprincipal());

>>>>>>> a6af058c3fe3d4b96dadbea62cddc5fbab151bce
        }
    }
}
