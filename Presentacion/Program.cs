using Login_inicio;
using Presentacion.Vista;
using System;
using System.Windows.Forms;

using Presentacion.Subvista;


namespace Presentacion
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
            Application.Run(new frmvista_usuario());
=======
            Application.Run(new TipoPlanilla());
>>>>>>> 11a55eb12caf741f2874eed70274547c211de856

        }
    }
}
