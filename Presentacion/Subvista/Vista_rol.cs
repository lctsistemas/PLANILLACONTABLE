using Negocio.Models;
using Presentacion.Helps;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Subvista
{
    public partial class FrmVista_rol : Form
    {
        public FrmVista_rol()
        {
            InitializeComponent();
        }

        private void LLenarVistaRol()
        {
            using (Nrol nr=new Nrol())
            {
                dgvrol.DataSource = nr.Getall();
            }
        }

        //TABLA
        private void Tabla()
        {
            dgvrol.Columns[0].HeaderText = "CODIGO";
            dgvrol.Columns[0].Width = 50;
            dgvrol.Columns[0].Visible = false;

            dgvrol.Columns[1].HeaderText = "NOMBRE ROL";
            dgvrol.Columns[1].Width = 344;
        }

        private void FrmVista_rol_Load(object sender, EventArgs e)
        {
            LLenarVistaRol();
            Tabla();
        }

        //BOTON CERRAR
        private void btncerrar_MouseMove(object sender, MouseEventArgs e)
        {
            btncerrar.BackColor = Color.Crimson;
            btncerrar.ForeColor = Color.White;
        }

        private void btncerrar_MouseLeave(object sender, EventArgs e)
        {
            btncerrar.BackColor = Color.Transparent;
            btncerrar.ForeColor = Color.Crimson;
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncerrar_MouseDown(object sender, MouseEventArgs e)
        {
            btncerrar.BackColor = Color.FromArgb(241, 112, 122);
        }

        private void panel_rol_MouseDown(object sender, MouseEventArgs e)
        {
            WindowsMove.ReleaseCapture();
            WindowsMove.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

      
    }
}
