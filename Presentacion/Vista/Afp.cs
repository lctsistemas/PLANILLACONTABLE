using System.Diagnostics;
using System.Windows.Forms;

namespace Presentacion.Vista
{
    public partial class frmafp : Form
    {
        public frmafp()
        {
            InitializeComponent();
        }

        private void linkcomisiones_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(@"https://www.sbs.gob.pe/app/spp/empleadores/comisiones_spp/paginas/comision_prima.aspx");
        }
    }
}
