using Negocio.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Presentacion.Vista
{
    public partial class TipoContrato : Form
    {
        Ntipocontrato nTipocontrato = new Ntipocontrato();
        public TipoContrato()
        {
            InitializeComponent();
            ShowTipoContrato();
        }

        private void ShowTipoContrato()
        {
            using (nTipocontrato)
            {
                dgvtipocontrato.DataSource = nTipocontrato.MostrarTcontrato();

            }
        }

    }
}
