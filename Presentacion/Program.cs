﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Presentacion.Subvista;
using Presentacion.Vista;

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
            Application.Run(new Banco());
        }
    }
}
