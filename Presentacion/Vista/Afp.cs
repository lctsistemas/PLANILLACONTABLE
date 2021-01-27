using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Comun.Cache;
using Negocio.Models;
using Negocio.ValueObjects;
using Presentacion.Helps;
namespace Presentacion.Vista
{
    public partial class Frmafp : Form
    {
        private Nafp nafp;
        public Frmafp()
        {
            InitializeComponent();
            dgvonp.AutoGenerateColumns = false;
            dgvcomision.AutoGenerateColumns = false;
            
        }       

        // MOSTRA MES
        private void ShowMes()
        {
            string[] meses = { "ENERO", "FEBRERO", "MARZO", "ABRIL", "MAYO", "JUNIO", "JULIO", "AGOSTO", "SETIEMBRE", "OCTUBRE", "NOVIEMBRE", "DICIEMBRE" };
            cbomes.Items.AddRange(meses);            
        }

        //MOSTRAR COMISIONES AFP
        private void Fill_comisionafp(int idmeses)
        {
            using (nafp =new Nafp())
            {
                nafp.Idmes = idmeses;
                nafp.Idperiodo = UserCache.Idperiodo;
                dgvcomision.DataSource = nafp.Show_comisionafp("SPP");
            }
        }

        //MOSTRAR COMISIONES ONP
        private void Fill_comisionOnp(int idmeses)
        {
            using (nafp = new Nafp())
            {
                nafp.Idmes = idmeses;
                nafp.Idperiodo = UserCache.Idperiodo;
                dgvonp.DataSource = nafp.Show_comisionOnp("SNP");
            }
        }

        //EDITAR CELDAS TABLA
        private void Tabla()
        {
            dgvcomision.Columns["id_regimen"].Visible = false;
            dgvcomision.Columns["afp"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;            
            dgvcomision.Columns["afp"].Width = 200;//apf
            dgvcomision.Columns["afp"].ReadOnly = true;
            dgvcomision.Columns["Id_comision"].Visible = false;
            dgvcomision.Columns["comision"].Width = 131;
            dgvcomision.Columns["saldo"].Width = 131;
            dgvcomision.Columns["seguro"].Width = 131;
            dgvcomision.Columns["aporte"].Width = 131;
            dgvcomision.Columns["tope"].Width = 131;
            //dgvcomision.Columns[8].Visible = false;
            //dgvcomision.Columns[9].Visible = false;

            //TABLA PAR ONP
            dgvonp.Columns["idregi"].Visible = false;
            dgvonp.Columns["idcomi"].Visible = false;
            dgvonp.Columns["donp"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvonp.Columns["donp"].ReadOnly = true;
            dgvonp.Columns["onpcomision"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

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
            ShowMes();           
            lblperiodo.Text = "Periodo:  "+ UserCache.Periodo;            
            MesInicial();                      
            Tabla();
            chkonp.Checked = false;
           
        }      

        private void btnupdate_Click(object sender, System.EventArgs e)
        {
            if (dgvcomision.RowCount == 0)
                return;

            using (nafp = new Nafp())
            {
                nafp.State = EntityState.Modificar;
                if (nafp.ListNafp == null)
                    nafp.ListNafp = new List<Nafp>();

                foreach (DataGridViewRow item in dgvcomision.Rows)
                {
                    nafp.ListNafp.Add(new Nafp()
                    {                       
                        Comision = Convert.ToDecimal(item.Cells["comision"].Value),
                        Saldo = Convert.ToDecimal(item.Cells["saldo"].Value),
                        Seguro = Convert.ToDecimal(item.Cells["seguro"].Value),
                        Aporte = Convert.ToDecimal(item.Cells["aporte"].Value),
                        Tope = Convert.ToDecimal(item.Cells["tope"].Value),                 
                        Id_comision = Convert.ToInt32(item.Cells["id_comision"].Value)
                    });
                }
                string result = nafp.EditComision();
                //Para ONP
                nafp.Comision = Convert.ToDecimal(dgvonp.CurrentRow.Cells["onpcomision"].Value);
                nafp.Id_comision = Convert.ToInt32(dgvonp.CurrentRow.Cells["idcomi"].Value);

                string verificar = nafp.SaveOnp();
                if (!verificar.Equals(""))
                {
                    Messages.M_info(result);
                    btnupdate.Enabled = false;                    
                }
                nafp.ListNafp.Clear();
                nafp.State = EntityState.Guardar;

            }                                    
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (dgvcomision.RowCount == 0)
            {
                btnguardar.Enabled = false;
                return;
            }
                
            using (nafp = new Nafp())
            {
                if (nafp.ListNafp == null)
                    nafp.ListNafp = new List<Nafp>();

                foreach (DataGridViewRow item in dgvcomision.Rows)
                {
                    nafp.ListNafp.Add(new Nafp()
                    {
                        Codigo_regimen = Convert.ToInt32(item.Cells["id_regimen"].Value),
                        Comision = Convert.ToDecimal(item.Cells["comision"].Value),
                        Saldo = Convert.ToDecimal(item.Cells["saldo"].Value),
                        Seguro = Convert.ToDecimal(item.Cells["seguro"].Value),
                        Aporte = Convert.ToDecimal(item.Cells["aporte"].Value),
                        Tope = Convert.ToDecimal(item.Cells["tope"].Value),
                        Idmes = Convert.ToInt32(cbomes.SelectedIndex + 1),
                        Idperiodo = UserCache.Idperiodo
                    });
                }
                string result = nafp.SaveComision();
                // PARA ONP
                nafp.Codigo_regimen = Convert.ToInt32(dgvonp.CurrentRow.Cells["idregi"].Value);
                nafp.Comision = Convert.ToDecimal(dgvonp.CurrentRow.Cells["onpcomision"].Value);
                nafp.Idmes = Convert.ToInt32(cbomes.SelectedIndex + 1);
                nafp.Idperiodo = UserCache.Idperiodo;
                string verificar = nafp.SaveOnp();
                if (!verificar.Equals(""))
                {
                    Messages.M_info(result);
                    btnguardar.Enabled = false;
                }
                   
                nafp.ListNafp.Clear();
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
       
        private void dgvcomision_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvcomision.Rows.Count > 0)
            {
                dgvcomision.BeginEdit(true);
            }
        }

        private void dgvcomision_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            DataGridViewCellStyle style = e.CellStyle;

            style.Font = new Font(style.Font.FontFamily, 10, FontStyle.Bold);
            style.BackColor = Color.Beige;
        }

      

        private void cbomes_SelectedIndexChanged(object sender, EventArgs e)
        {            
            Fill_comisionafp(Convert.ToInt32(cbomes.SelectedIndex + 1));
            Fill_comisionOnp(Convert.ToInt32(cbomes.SelectedIndex + 1));
            btnguardar.Enabled = false;
            btnupdate.Enabled = false;
        }

        private void chkonp_CheckedChanged(object sender, EventArgs e)
        {
            if (chkonp.Checked == false)
                dgvonp.Visible = false;
            else if(chkonp.Checked==true)
                dgvonp.Visible = true;
        }

        private void chkcopy_pega_CheckedChanged(object sender, EventArgs e)
        {
            if (chkcopy_pega.Checked == true)
            {
                if (dgvcomision.RowCount > 0)
                {
                    chkcopy_pega.BackColor = Color.Maroon;
                    chkcopy_pega.Text = "PEGAR";
                    txtidmes.Text = "" + (Convert.ToInt32(cbomes.SelectedIndex + 1));
                }
                else
                    chkcopy_pega.Checked = false;
            }
            else if (chkcopy_pega.Checked == false)
            {
                if (chkcopy_pega.Text.Equals("PEGAR") && dgvcomision.Rows.Count == 0)
                {
                    chkcopy_pega.BackColor = Color.FromArgb(160,160,160);
                    chkcopy_pega.Text = "COPIAR";
                    Fill_comisionafp(Convert.ToInt32(txtidmes.Text.Trim()));
                    Fill_comisionOnp(Convert.ToInt32(txtidmes.Text.Trim()));
                    btnguardar.Enabled = true;
                    //MessageBox.Show("PEGADO");
                }                
            }           
        }

     
        private void dgvcomision_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvcomision.RowCount > 0 && btnguardar.Enabled==false)
                btnupdate.Enabled = true;
                //MessageBox.Show("cell cambio de valor");// si funciona
        }

        //BOTONES COLOR
        private void btncerrar_MouseLeave(object sender, EventArgs e)
        {
            btncerrar.BackColor = Color.FromArgb(116, 118, 118);
        }

        private void btncerrar_MouseMove(object sender, MouseEventArgs e)
        {
            btncerrar.BackColor = Color.Crimson;
        }

        private void btncerrar_MouseDown(object sender, MouseEventArgs e)
        {
            btncerrar.BackColor = Color.FromArgb(241,112,122);
        }
        //MINIMIZAR
        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnminimizar_MouseDown(object sender, MouseEventArgs e)
        {
            btnminimizar.BackColor = Color.FromArgb(165,171,179);
        }

        private void btnminimizar_MouseLeave(object sender, EventArgs e)
        {
            btnminimizar.BackColor = Color.FromArgb(116,118,118);
        }

        private void btnminimizar_MouseMove(object sender, MouseEventArgs e)
        {
            btnminimizar.BackColor = Color.FromArgb(130,140,140);
        }
        //..

        //private void dgvcomision_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        //{
        //    MessageBox.Show("cell state changed");
        //}
    }
}
