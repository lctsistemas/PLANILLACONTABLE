﻿using Negocio.Models;
using Presentacion.Helps;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Presentacion.Vista
{
    public partial class frmcontrato : Form
    {
        NContrato nContrato = new NContrato();
        Ntipocontrato ntcontrato;
        public frmcontrato()
        {
            InitializeComponent();
            Mostrar_banco();
            Mostrar_tcontrato();
        }
        
        private void Mostrar_banco()
        {
            using (nContrato)
            {
                cmbbanco.DataSource = nContrato.MostrarBanco();
                cmbbanco.DisplayMember = "nombre_banco";
                cmbbanco.ValueMember = "id_banco";
            }
        }

        private void Mostrar_tcontrato()
        {
            using ( ntcontrato=new Ntipocontrato())
            {
                cmbtipcont.DataSource = ntcontrato.MostrarTcontrato();
                cmbtipcont.DisplayMember = "tiem_contrato";
                cmbtipcont.ValueMember = "id_tcontrato";
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
