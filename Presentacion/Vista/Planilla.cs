﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Vista
{
    public partial class Planilla : Form
    {
        public Planilla()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize() {
            String[] mes = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
            //string m=mes[0];
            cbxmes.Items.AddRange(mes);
        }
    }
}
