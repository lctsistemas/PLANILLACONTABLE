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

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnmaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void paneltitulo_MouseDown(object sender, MouseEventArgs e)
        {
            WindowsMove.ReleaseCapture();
            WindowsMove.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label16_MouseDown(object sender, MouseEventArgs e)
        {
            WindowsMove.ReleaseCapture();
            WindowsMove.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
