using Negocio.Models;
using Negocio.ValueObjects;
using Presentacion.Helps;
using System;
using System.Windows.Forms;

namespace Presentacion.Vista
{
    public partial class frmModificarPlanilla : Form
    {
        private NPlanilla np = new NPlanilla();
        public frmModificarPlanilla()
        {
            InitializeComponent();
        }

        private void frmModificarPlanilla_Load(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            using (np)
            {
                np.state = EntityState.Modificar;
                np.Fecha_pago = Convert.ToDateTime(txtpago.Text.Trim());
                string res = np.GuardarCambios();
                Messages.M_info(res);
            }

        }
    }
}
