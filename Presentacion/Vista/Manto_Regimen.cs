using System;
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
    public partial class Manto_Regimen : Form
    {
        public Manto_Regimen()
        {
            InitializeComponent();
        }

        private void Manto_Regimen_Load(object sender, EventArgs e)
        {
            cbxregimen.Items.Add("S.N.P");
            cbxregimen.Items.Add("S.P.P");
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {

        }
    }
}
