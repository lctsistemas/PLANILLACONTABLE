using Negocio.Models;
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
    }s
}
