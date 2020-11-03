﻿using Negocio.Models;
using Negocio.ValueObjects;
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

namespace Presentacion.Vista
{
    public partial class frmsubsidios : Form
    {
        String result;
        private NSubsidios ns = new NSubsidios();
        public frmsubsidios()
        {
            InitializeComponent();
        }

        private void ShowSubsidio()
        {
            using (ns)
            {
                dgvsubsidio.DataSource = ns.Getall();
            }
        }

        private void Tabla()
        {
            dgvsubsidio.Columns[0].HeaderText = "id_subsidios";
            dgvsubsidio.Columns[0].Width = 100;
            dgvsubsidio.Columns[0].Visible = false;

            dgvsubsidio.Columns[1].HeaderText = "Codigo subsudio";
            dgvsubsidio.Columns[1].Width = 80;


            dgvsubsidio.Columns[2].HeaderText = "Tipo de suspension";
            dgvsubsidio.Columns[2].Width = 80;

            dgvsubsidio.Columns[3].HeaderText = "Descripcion corta";
            dgvsubsidio.Columns[3].Width = 200;

            dgvsubsidio.Columns[4].HeaderText = "Descripcion subsidio";
            dgvsubsidio.Columns[4].Width = 250;

            dgvsubsidio.Columns[5].HeaderText = "Tipo Subsidio";
            dgvsubsidio.Columns[5].Width = 120;

            dgvsubsidio.Columns[6].HeaderText = "Descuento";
            dgvsubsidio.Columns[6].Width = 80;

            dgvsubsidio.Columns[7].HeaderText = "state";
            dgvsubsidio.Columns[7].Width = 100;
            dgvsubsidio.Columns[7].Visible = false;

            foreach (DataGridViewColumn col in dgvsubsidio.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            Habilitar(true);
        }

        private void Habilitar(bool estado)
        {
            txtcodigosubsidio.Enabled = estado;
            cbxsuspension.Enabled = estado;
            txtdescCorta.Enabled = estado;
            txtdescSubsi.Enabled = estado;
            cbxtiposub.Enabled = estado;
            txtcodigosubsidio.Focus();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            result = "";
            using (ns)
            {
                //ns.Id_subsidios = Convert.ToInt32(tx.Text.Trim());
                ns.Cod_subsidios = txtcodigosubsidio.Text.Trim();
                ns.Tipo_suspension = cbxsuspension.SelectedItem.ToString();
                ns.Descripcion_corta = txtdescCorta.Text.Trim();
                ns.Descripcion_subsidio = txtdescSubsi.Text.Trim();
                ns.Tipo_subsidio = cbxtiposub.Text.Trim();
                ns.Descuento = Convert.ToBoolean(checkDescuento.Text.ToString());

                bool valida = new ValidacionDatos(ns).Validate();
                if (valida)
                {
                    result = ns.SaveChanges();
                    Messages.M_info(result);
                }
                ShowSubsidio();
                limpiar();
            }
        }

        private void Subsidios_Load(object sender, EventArgs e)
        {
            ShowSubsidio();
            Tabla();
            Habilitar(false);
            cbxsuspension.Items.Add("S.P");
            cbxsuspension.Items.Add("S.I");

            cbxtiposub.Items.Add("SUBSIDIADOS");
            cbxtiposub.Items.Add("NO SUBSIDIADOS");
        }

        private void limpiar()
        {
            txtcodigosubsidio.Text = String.Empty;
            cbxtiposub.Text = String.Empty;
            txtdescCorta.Text = String.Empty;
            txtdescSubsi.Text = String.Empty;
            cbxsuspension.Text = String.Empty;

            using (ns) { ns.state = EntityState.Guardar; }
        }
    }
}
