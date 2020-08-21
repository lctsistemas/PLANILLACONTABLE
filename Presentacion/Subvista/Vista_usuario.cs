using Negocio.Models;
using Presentacion.Helps;
using Presentacion.Vista;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Presentacion.Subvista
{
    public partial class frmvista_usuario : Form
    {
        Nusuario nu = new Nusuario();
        public frmvista_usuario()
        {
            InitializeComponent();
            Vista_user("");
            Tabla();
        }


        private void Vista_user(String arg)
        {
            using (nu)
            {
                nu.Nombre_refe = arg;
                dgvvista_user.DataSource = nu.Getall();
                lblcantidad.Text = "Total Registro: " + dgvvista_user.RowCount;
            }
        }

        //TITULO A LA TABLA.
        private void Tabla()
        {
            dgvvista_user.Columns[0].HeaderText = "CODIGO";
            dgvvista_user.Columns[0].Width = 50;
            dgvvista_user.Columns[0].Visible = false;

            dgvvista_user.Columns[1].HeaderText = "ACCESO USUARIO";
            dgvvista_user.Columns[1].Width = 150;

            dgvvista_user.Columns[2].HeaderText = "NOMBRE USUARIO";
            dgvvista_user.Columns[2].Width = 250;

            dgvvista_user.Columns[3].HeaderText = "CONTRASEÑA";
            dgvvista_user.Columns[3].Width = 100;
            dgvvista_user.Columns[3].Visible = false;

            dgvvista_user.Columns[4].HeaderText = "CODIGO ROL";
            dgvvista_user.Columns[4].Width = 50;
            dgvvista_user.Columns[4].Visible = false;

            dgvvista_user.Columns[5].HeaderText = "ROL";
            dgvvista_user.Columns[5].Width = 200;

            dgvvista_user.Columns[6].HeaderText = "STATE";
            dgvvista_user.Columns[6].Width = 50;
            dgvvista_user.Columns[6].Visible = false;
        }

        private void frmvista_usuario_Load(object sender, EventArgs e)
        {
            Tooltip.Title(txtbuscar, "Buscar por Nombre Usuario",true);
            txtbuscar.Focus();
        }

        private void dgvvista_user_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmempresa femp = (frmempresa)Owner;

           

            if (dgvvista_user.Rows.GetFirstRow(DataGridViewElementStates.Selected) != -1)
            {
                femp.txtiduser.Text = dgvvista_user.CurrentRow.Cells[0].Value.ToString();
                femp.txtusuario.Text = dgvvista_user.CurrentRow.Cells[2].Value.ToString();
                this.Close();
            }

        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            Vista_user(txtbuscar.Text.Trim());
        }        

        private void frmvista_usuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
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
            btncerrar.BackColor = Color.Transparent;
        }
    }
}
