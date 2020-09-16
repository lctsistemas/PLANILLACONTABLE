using System.Diagnostics;
using System.Windows.Forms;
using Presentacion.Subvista;
namespace Presentacion.Vista
{
    public partial class Frmafp : Form
    {
        public Frmafp()
        {
            InitializeComponent();
        }

        private void linkcomisiones_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
            //Process.Start(@"https://www.sbs.gob.pe/app/spp/empleadores/comisiones_spp/paginas/comision_prima.aspx");
        }

        private void btncerrar_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
