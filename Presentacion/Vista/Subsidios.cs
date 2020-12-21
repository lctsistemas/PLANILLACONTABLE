using Negocio.Models;
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
                lbltotal.Text = "Total registro:  " + dgvsubsidio.RowCount;
            }
        }

        private void Tabla()
        {
            dgvsubsidio.Columns[0].HeaderText = "id_subsidios";
            dgvsubsidio.Columns[0].Width = 100;
            dgvsubsidio.Columns[0].Visible = false;

            dgvsubsidio.Columns[1].HeaderText = "CODI GO";
            dgvsubsidio.Columns[1].Width = 50;
            dgvsubsidio.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvsubsidio.Columns[2].HeaderText = "TIPO DE SUSPENSION";
            dgvsubsidio.Columns[2].Width = 90;
            dgvsubsidio.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvsubsidio.Columns[3].HeaderText = "DESCRIPCION CORTA";
            dgvsubsidio.Columns[3].Width = 220;

            dgvsubsidio.Columns[4].HeaderText = "DESCRIPCION LARGA";
            dgvsubsidio.Columns[4].Width = 295;

            dgvsubsidio.Columns[5].HeaderText = "ESTADO";
            dgvsubsidio.Columns[5].Width = 100;

            dgvsubsidio.Columns[6].HeaderText = "DESCUENTO";
            dgvsubsidio.Columns[6].Width = 80;

            dgvsubsidio.Columns[7].HeaderText = "state";
            dgvsubsidio.Columns[7].Width = 50;
            dgvsubsidio.Columns[7].Visible = false;

            //foreach (DataGridViewColumn col in dgvsubsidio.Columns)
            //{
            //    col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //    col.HeaderCell.Style.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Pixel);
            //}
        }

      
        private void limpiar()
        {
            txtcodigosubsidio.Text = String.Empty;
            cbxtiposub.Text = null;
            txtdescCorta.Text = String.Empty;
            txtdescSubsi.Text = String.Empty;
            cbxsuspension.Text = null;
            checkDescuento.Checked = false;

            using (ns) { ns.state = EntityState.Guardar; }
        }


        private void Habilitar(bool estado)
        {
            txtcodigosubsidio.Enabled = estado;
            cbxsuspension.Enabled = estado;
            txtdescCorta.Enabled = estado;
            txtdescSubsi.Enabled = estado;
            cbxtiposub.Enabled = estado;
            checkDescuento.Enabled = estado;
            txtcodigosubsidio.Focus();
        }

        private void tbtnnuevo_Click(object sender, EventArgs e)
        {
            Habilitar(true);
            limpiar();
        }

        private void tbtnguardar_Click(object sender, EventArgs e)
        {
            result = "";
            using (ns)
            {                
                ns.Cod_subsidios = txtcodigosubsidio.Text.Trim();
                ns.Tipo_suspension = cbxsuspension.SelectedItem.ToString();
                ns.Descripcion_corta = txtdescCorta.Text.Trim();
                ns.Descripcion_subsidio = txtdescSubsi.Text.Trim();
                ns.Tipo_subsidio = cbxtiposub.Text.Trim();
                ns.Descuento = Convert.ToBoolean(checkDescuento.Checked);

                result = ns.SaveChanges();
                Messages.M_info(result);

                ShowSubsidio();
                limpiar();
            }
        }

        private void tbtneliminar_Click(object sender, EventArgs e)
        {
            result = "";
            if (dgvsubsidio.Rows.GetFirstRow(DataGridViewElementStates.Selected) != -1)
            {
                DialogResult r = Messages.M_question("¿Desea eliminar la fila?");
                if (r == DialogResult.Yes)
                {
                    using (ns)
                    {
                        ns.state = EntityState.Remover;
                        ns.Id_subsidios = Convert.ToInt32(dgvsubsidio.CurrentRow.Cells[0].Value);
                        result = ns.SaveChanges();
                        ShowSubsidio();
                        Messages.M_info(result);
                    }
                }

            }
            else
            {
                Messages.M_warning("Seleccione una fila de la tabla");
            }

        }

        private void Subsidios_Load(object sender, EventArgs e)
        {
            ShowSubsidio();
            Tabla();
            Habilitar(false);
            cbxsuspension.Items.Add("S.P.");
            cbxsuspension.Items.Add("S.I.");

            cbxtiposub.Items.Add("SUBSIDIADOS");
            cbxtiposub.Items.Add("NO SUBSIDIADOS");
        }      

        private void dgvsubsidio_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = dgvsubsidio.CurrentRow;
            Habilitar(true);
            if (dgvsubsidio.Rows.GetFirstRow(DataGridViewElementStates.Selected) != -1)
            {
                using (ns)
                {
                    ns.state = EntityState.Modificar;
                    ns.Id_subsidios = Convert.ToInt32(r.Cells[0].Value);
                    txtcodigosubsidio.Text = Convert.ToString(r.Cells[1].Value);
                    cbxsuspension.SelectedItem = r.Cells[2].Value.ToString();
                    txtdescCorta.Text = Convert.ToString(r.Cells[3].Value);
                    txtdescSubsi.Text = Convert.ToString(r.Cells[4].Value);
                    cbxtiposub.Text = Convert.ToString(r.Cells[5].Value);
                    checkDescuento.Checked = Convert.ToBoolean(r.Cells[6].Value);
                    ValidateError.validate.Clear();//LIMPIA LOS ERRORPROVIDER
                   
                }
            }
        }      

        private void btncerrar_MouseDown(object sender, MouseEventArgs e)
        {
            btncerrar.BackColor = Color.FromArgb(241,112,122);
        }
        
        private void btncerrar_MouseLeave(object sender, EventArgs e)
        {
            btncerrar.BackColor = Color.FromArgb(116,118,118);
        }

        private void btnminimizar_MouseLeave(object sender, EventArgs e)
        {
            btnminimizar.BackColor = Color.FromArgb(116,118,118);
        }

        private void btnminimizar_MouseMove(object sender, MouseEventArgs e)
        {
            btnminimizar.BackColor = Color.FromArgb(138,140,140);
        }
        private void btncerrar_MouseMove(object sender, MouseEventArgs e)
        {
            btncerrar.BackColor = Color.Crimson;
        }
        private void btnminimizar_MouseDown(object sender, MouseEventArgs e)
        {
            btnminimizar.BackColor = Color.FromArgb(165,171,179);
        }
        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            WindowsMove.ReleaseCapture();
            WindowsMove.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        
    }
}
