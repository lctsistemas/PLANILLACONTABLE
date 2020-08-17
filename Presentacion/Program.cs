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
            Application.Run(new frminicio());
=======

           
            Application.Run(new Main_Principal());

>>>>>>> e2c7c0e5ddaca8ef63baf584e348423a05a8cf86
        }
    }
}
