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
            Application.Run(new TipoContrato2());


=======
            Application.Run(new frmcargo());
>>>>>>> ee8efd450f253c5cb93ef538bb267d63a219dc0f
        }
    }
}
