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

            Application.Run(new Privilegios());



        }
    }
}
