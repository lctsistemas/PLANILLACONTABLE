using Negocio.Models;
using Presentacion.Helps;
using Presentacion.Vista;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Presentacion.Subvista
{
    public partial class frmvista_empresa : Form
    {
        Nempresa ne;
        public frmvista_empresa()
        {
            InitializeComponent();
            Llenar_empresa();
            Tabla();
        }
        //SHOW EMPRESA
        private void Llenar_empresa()
        {
            using (ne = new Nempresa())
            {
                dgvvista_emp.DataSource = ne.Getall();
                TotalDatos();
            }
        }

        //TOTAL DATOS DE TABLA
        private void TotalDatos()
        {
            lbltotal.Text = "Total Registro: " + dgvvista_emp.RowCount;
        }
        private void Tabla()
        {
            dgvvista_emp.Columns[0].HeaderText = "ID";//codigo empresa maestra
            dgvvista_emp.Columns[0].Width = 30;
            dgvvista_emp.Columns[0].Visible = false;

            dgvvista_emp.Columns[1].HeaderText = "ESTADO";//para definir es estado eliminado
            dgvvista_emp.Columns[1].Width = 30;
            dgvvista_emp.Columns[1].Visible = false;

            dgvvista_emp.Columns[2].HeaderText = "ID USUARIO";
            dgvvista_emp.Columns[2].Width = 30;
            dgvvista_emp.Columns[2].Visible = false;

            dgvvista_emp.Columns[3].HeaderText = "ID EMPRESA MAESTRA";
            dgvvista_emp.Columns[3].Width = 30;
            dgvvista_emp.Columns[3].Visible = false;

            dgvvista_emp.Columns[4].HeaderText = "ID EMPRESA";
            dgvvista_emp.Columns[4].Width = 30;
            dgvvista_emp.Columns[4].Visible = false;

            dgvvista_emp.Columns[5].HeaderText = "CODIGO";
            dgvvista_emp.Columns[5].Width = 80;
            dgvvista_emp.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvvista_emp.Columns[6].HeaderText = "RAZON SOCIAL O DENOMINACION";
            dgvvista_emp.Columns[6].Width = 370;

            dgvvista_emp.Columns[7].HeaderText = "LOCALIDAD";
            dgvvista_emp.Columns[7].Width = 262;

            dgvvista_emp.Columns[8].HeaderText = "DIRECCION";
            dgvvista_emp.Columns[8].Width = 370;
            dgvvista_emp.Columns[8].Visible = false;

            dgvvista_emp.Columns[9].HeaderText = "DOMICILIO FISCAL";
            dgvvista_emp.Columns[9].Width = 370;
            dgvvista_emp.Columns[9].Visible = false;

            dgvvista_emp.Columns[10].HeaderText = "RUC";
            dgvvista_emp.Columns[10].Width = 90;
            dgvvista_emp.Columns[10].Visible = false;

            dgvvista_emp.Columns[11].HeaderText = "REGIMEN";
            dgvvista_emp.Columns[11].Width = 270;
            dgvvista_emp.Columns[11].Visible = false;

            dgvvista_emp.Columns[12].HeaderText = "USUARIO";
            dgvvista_emp.Columns[12].Width = 270;
            dgvvista_emp.Columns[12].Visible = false;

            //dgvvista_emp.Columns[13].Visible = true;

        }

        private void Vista_empresa_Load(object sender, EventArgs e)
        {
            Tooltip.Title(txtbuscar, "Buscar por Empresa", true);
            txtbuscar.Focus();
        }

        private void dgvvista_emp_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow ro = dgvvista_emp.CurrentRow;
            if (dgvvista_emp.Rows.GetFirstRow(DataGridViewElementStates.Selected) != -1)
            {
                frmsucursal su = (frmsucursal)Owner;
                
                su.txtidempresa.Text = ro.Cells[4].Value.ToString();
                su.txtcodigo_sucursal.Text = ro.Cells[5].Value.ToString();
                su.txtrazon_social.Text = ro.Cells[6].Value.ToString();
                su.txtdomicilio.Text = ro.Cells[9].Value.ToString();
                su.txtruc.Text = ro.Cells[10].Value.ToString();
                su.txtregimen.Text = ro.Cells[11].Value.ToString();
                su.txtusuario.Text = ro.Cells[12].Value.ToString();
                this.Close();
            }
        }

    
        private void btncerrards_MouseMove(object sender, MouseEventArgs e)
        {
            btncerrar.BackColor = Color.Crimson;
        }

        private void btncerrarsd_MouseLeave(object sender, EventArgs e)
        {
            btncerrar.BackColor = Color.Transparent;
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            dgvvista_emp.DataSource = ne.Search(txtbuscar.Text.Trim());
            TotalDatos();
        }
       
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
            btncerrar.BackColor = Color.FromArgb(241,112,122);
        }
    }
}
