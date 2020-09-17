using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using Negocio.Models;
using Presentacion.Helps;
namespace Presentacion.Vista
{
    public partial class Frmafp : Form
    {
        private Nafp nafp;
        public Frmafp()
        {
            InitializeComponent();
            Fill_mes();
        }

        private void Fill_mes()
        {
            using (nafp = new Nafp())
            {
                cbomes.DataSource = nafp.Mostrar_mes();
                cbomes.DisplayMember = "Mes";             
                cbomes.ValueMember = "Idmes";
            }
        }
        private void linkcomisiones_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
            Process.Start(@"https://www.sbs.gob.pe/app/spp/empleadores/comisiones_spp/paginas/comision_prima.aspx");
        }

        private void btncerrar_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void Frmafp_Load(object sender, System.EventArgs e)
        {
            dgvcomision.Rows.Add();
        }

        private void dgvcomision_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dgvcomision.Rows.Add();
                dgvcomision.CurrentCell = dgvcomision.Rows[dgvcomision.Rows.Count - 1].Cells[0];
            }
        }

        private void btnupdate_Click(object sender, System.EventArgs e)
        {
            List<Nafp> obsa = new List<Nafp>();

            foreach (DataGridViewRow item in dgvcomision.Rows)
            {
                var lisnafp = new Nafp()
                {
                    Codigo_regimen = Convert.ToInt32(txtcodigo_regimen.Text.Trim()),
                    Comision = Convert.ToDecimal(item.Cells["comision"].Value),
                    Saldo = Convert.ToDecimal(item.Cells["saldo"].Value),
                    Seguro = Convert.ToDecimal(item.Cells["seguro"].Value),
                    Aporte = Convert.ToDecimal(item.Cells["aporte"].Value),
                    Tope = Convert.ToDecimal(item.Cells["tope"].Value),
                    Idmes = Convert.ToInt32(txtidmes.Text.Trim()),
                    Idperiodo = Convert.ToInt32(txtidperiodo.Text.Trim())
                };
                obsa.Add(lisnafp);
            }

            using (nafp = new Nafp())
            {
                nafp.InsertarMassiveData(obsa);
                Messages.M_info("Insertado correctamente");
            }

        }

        private void btncerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
