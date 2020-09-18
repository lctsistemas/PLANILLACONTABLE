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
            Application.Run(new RegimenSalud());
=======
            Application.Run(new frminicio());
>>>>>>> 92a94bebb50105ec4ab66578eea48ecf579803d0
        }
    }
}
