using Presentacion.Subvista;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BTNBUSCAR_Click(object sender, EventArgs e)
        {
            String usuario = txtusuario.Text.Trim().ToString();

            frmvista_usuario f_vist = new frmvista_usuario();
            this.AddOwnedForm(f_vist);
            f_vist.StartPosition = FormStartPosition.CenterParent;
            f_vist.ShowDialog();
        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnempresa_Click(object sender, EventArgs e)
        {

        }
    }
}
