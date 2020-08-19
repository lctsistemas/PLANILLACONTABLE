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
            Application.Run(new frminicio());
=======

            Application.SetCompatibleTextRenderingDefault(false);
           
            Application.Run(new Main_Principal());                   
   
>>>>>>> 65ee9f6ab643d7b34c18f38c45fb51adbf1120b6
        }
    }
}
