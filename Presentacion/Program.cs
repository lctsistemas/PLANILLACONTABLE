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
            Application.Run(new FrmPlanillaMensual2());
=======
            Application.Run(new RegimenSalud());
>>>>>>> 21bcf66f4cd16bbcc763042e48a02468fd05237f

        }
    }
}
