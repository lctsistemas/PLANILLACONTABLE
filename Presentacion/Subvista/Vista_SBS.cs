using System.Windows.Forms;

namespace Presentacion.Subvista
{
    public partial class Frmvista_sbs : Form
    {
        public Frmvista_sbs()
        {
            InitializeComponent();
        }

        private void frmvista_sbs_Load(object sender, System.EventArgs e)
        {
            Navegar();
        }

        private void Navegar()
        {
            webafp.Navigate("https://www.sbs.gob.pe/app/spp/empleadores/comisiones_spp/paginas/comision_prima.aspx");
            
        }
    }
}
