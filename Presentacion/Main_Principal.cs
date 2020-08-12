using Presentacion.Vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Main_Principal : Form
    {
        public Main_Principal()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void Main_Principal_Load(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void hideSubmenu()
        {
            panelSubMenuMedia.Visible = false;
            panelactualizar.Visible = false;
            panelregistro.Visible = false;
        }

        private void showSubMenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }


        private void btnmedia_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuMedia);
        }

        private void btndoc_Click(object sender, EventArgs e)
        {
            openchildform(new frmdocumento());
            hideSubmenu();
        }

        private void btnempresa_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btncargo_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btnsucursal_Click(object sender, EventArgs e)
        {
            hideSubmenu();

        }

        private void btnafp_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btnonp_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btnusuario_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btnempleado_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            showSubMenu(panelactualizar);
        }

        private void btnregistro_Click(object sender, EventArgs e)
        {
            showSubMenu(panelregistro);
        }

        private void btnrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnrestaurar.Visible = true;
            btnmaximizar.Visible = false;
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnmaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnrestaurar.Visible = true;
            btnmaximizar.Visible = false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private Form activeForm = null;
        private void openchildform(Form chilform)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm = chilform;
                chilform.TopLevel = false;
                chilform.FormBorderStyle = FormBorderStyle.None;
                chilform.Dock = DockStyle.Fill;
                panelchildform.Controls.Add(chilform);
                panelchildform.Tag = chilform;
                chilform.BringToFront();
                chilform.Show();

            }
        }
    }
}
