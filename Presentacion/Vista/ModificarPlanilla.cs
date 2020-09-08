using Negocio.Models;
using Negocio.ValueObjects;
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
            }
            
        }
    }
}
