using Negocio.Models;
using Presentacion.Helps;
using Presentacion.Vista;
using System;
using System.Windows.Forms;

namespace Presentacion.Subvista
{
    public partial class frmvista_empresa : Form
    {
        public frmvista_empresa()
        {
            InitializeComponent();
            Llenar_empresa("");
            Tabla();
        }
        //SHOW EMPRESA
        private void Llenar_empresa(String txt)
        {
            using (Nempresa ne = new Nempresa())
            {
                ne.search = txt;
                dgvvista_emp.DataSource = ne.Getall();
                lbltotal.Text = "Total Registro: " + dgvvista_emp.RowCount;
            }
        }


        private void Tabla()
        {
            dgvvista_emp.Columns[0].HeaderText = "CODIGO";//codigo empresa maestra
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

            dgvvista_emp.Columns[5].HeaderText = "CODIGO EMPRESA";
            dgvvista_emp.Columns[5].Width = 65;

            dgvvista_emp.Columns[6].HeaderText = "RAZON SOCIAL";
            dgvvista_emp.Columns[6].Width = 350;

            dgvvista_emp.Columns[7].HeaderText = "LOCALIDAD";
            dgvvista_emp.Columns[7].Width = 250;

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

            dgvvista_emp.Columns[13].Visible = false;
            //dgvempresa.Columns[12].Visible = false;
        }

        private void Vista_empresa_Load(object sender, EventArgs e)
        {
            Tooltip.Title(txtbuscar, "Buscar por Empresa");
        }

        private void dgvvista_emp_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow ro = dgvvista_emp.CurrentRow;
            if (dgvvista_emp.Rows.GetFirstRow(DataGridViewElementStates.Selected) != -1)
            {
                frmsucursal su = (frmsucursal)Owner;
                //frmsucursal su = frmsucursal.Getinstancia();
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

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            this.Llenar_empresa(txtbuscar.Text.Trim());
        }
    }
}
