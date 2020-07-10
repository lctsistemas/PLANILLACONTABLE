using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Menu_Principal : Form
    {
        public Menu_Principal()
        {
            InitializeComponent();
            

        }

        private void ocultarpanel()
        {
            panelsubmenu.Visible = false;
            panelmedia2.Visible = false;
            panelmedia3.Visible = false;

        }

        private void hidemenu()
        {
            if (panelsubmenu.Visible == true)
                panelsubmenu.Visible = false;
            if (panelmedia2.Visible == true)
                panelmedia2.Visible = false;
            if (panelmedia3.Visible == true)
                panelmedia3.Visible = false;
        }

        private void showmenu(Panel submenu)
        {

            if (submenu.Visible == false)
            {
                hidemenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;


        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void btnmaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnrestaurar.Visible = true;
            btnmaximizar.Visible = false;

        }

        private void btnrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnrestaurar.Visible = false;
            btnmaximizar.Visible = true;
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void MenuLateral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnmedia_Click(object sender, EventArgs e)
        {
            showmenu(panelsubmenu);
        }

        private void btnmedia2_Click(object sender, EventArgs e)
        {
            showmenu(panelmedia2);

        }

        private void btnmedia3_Click(object sender, EventArgs e)
        {
            showmenu(panelmedia3);

        }

        private void Menu_Principal_Load(object sender, EventArgs e)
        {
            ocultarpanel();
        }
    }
}
