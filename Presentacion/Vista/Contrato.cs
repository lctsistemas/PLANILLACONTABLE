using Negocio.Models;
using Presentacion.Helps;
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
    public partial class frmcontrato : Form
    {
        public frmcontrato()
        {
            InitializeComponent();
            Mostrar_banco();
        }
        NEmpleado nEmpleado = new NEmpleado();
        NContrato nContrato = new NContrato();
        private void Mostrar_banco()
        {
            using (nContrato)
            {
                cmbbanco.DataSource = nContrato.MostrarBanco();
                cmbbanco.DisplayMember = "nombre_banco";
                cmbbanco.ValueMember = "id_banco";
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            //laflalk
        }

        private void frmcontrato_Load(object sender, EventArgs e)
        {
            cmbbanco.Text = "Seleccione...";
            cmbmoneda.SelectedIndex = 0;
            txtpen.Enabled = false;
        }

        private void frmcontrato_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void panelcontrato_MouseDown(object sender, MouseEventArgs e)
        {
            WindowsMove.ReleaseCapture();
            WindowsMove.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncerrar_MouseMove(object sender, MouseEventArgs e)
        {
            btncerrar.BackColor = Color.Crimson;
        }

        private void btncerrar_MouseLeave(object sender, EventArgs e)
        {
            btncerrar.BackColor = Color.SteelBlue;
        }

        private void btncerrar_MouseDown(object sender, MouseEventArgs e)
        {
            btncerrar.BackColor = Color.FromArgb(205, 97, 85);
        }
    }
    
}
