using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using Comun.Cache;
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
            Fill_regimenPensionario();
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

        private void Fill_regimenPensionario()
        {
            using (nafp = new Nafp())
            {
                //ENVIASMOS TIPO DE REGIMEN = SPP
                dgvcomision.DataSource = nafp.Mostrar_regimenPensionario("SPP");
            }
        }

        //EDITAR CELDAS TABLA
        private void Tabla()
        {
            dgvcomision.Columns["id_regimen"].Visible = false;
            dgvcomision.Columns["afp"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvcomision.Columns["afp"].Width = 200;//apf
            dgvcomision.Columns["comision"].Width = 130;
            dgvcomision.Columns["saldo"].Width = 130;
            dgvcomision.Columns["seguro"].Width = 130;
            dgvcomision.Columns["aporte"].Width = 130;
            dgvcomision.Columns["tope"].Width = 130;
        }

        //MOSTRAR MES INICIAL
        private void MesInicial()
        {
            //string mes_maquinapc = DateTime.Now.ToString("MMMM");
            int mes = DateTime.Now.Month;
            //cbomes.SelectedItem = mes_maquinapc;
            cbomes.SelectedIndex =(mes - 1);
            
        }
        private void linkcomisiones_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {          
            Process.Start(@"https://www.sbs.gob.pe/app/spp/empleadores/comisiones_spp/paginas/comision_prima.aspx");
        }

        private void Frmafp_Load(object sender, System.EventArgs e)
        {
            //dgvcomision.Rows.Add();
            lblperiodo.Text = "Periodo:  "+ UserCache.Periodo;
            Tabla();
            MesInicial();
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
                    //Cells["id_regimen"] esos nombres estan en: name de las celdas de datagri.
                    Codigo_regimen = Convert.ToInt32(item.Cells["id_regimen"].Value),
                    Comision = Convert.ToDecimal(item.Cells["comision"].Value),
                    Saldo = Convert.ToDecimal(item.Cells["saldo"].Value),
                    Seguro = Convert.ToDecimal(item.Cells["seguro"].Value),
                    Aporte = Convert.ToDecimal(item.Cells["aporte"].Value),
                    Tope = Convert.ToDecimal(item.Cells["tope"].Value),
                    Idmes = Convert.ToInt32(cbomes.SelectedValue),
                    Idperiodo = UserCache.Idperiodo
                };
                obsa.Add(lisnafp);
            }

            using (nafp = new Nafp())
            {
                nafp.InsertarMassiveData(obsa);
                Messages.M_info("Insertado correctamente");
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void paneltitulo_MouseDown(object sender, MouseEventArgs e)
        {
            WindowsMove.ReleaseCapture();
            WindowsMove.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {           
           // MessageBox.Show("values "+cbomes.SelectedValue);
            //MessageBox.Show("index  "+cbomes.SelectedIndex);            
        }

    }
}
