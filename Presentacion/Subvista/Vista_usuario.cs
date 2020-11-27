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
        Nusuario nu;
        private static frmvista_usuario _instance;
        public frmvista_usuario()
        {
            InitializeComponent();           
            Vista_user();
            Tabla();
        }

        //METODO PARA ACCEDER CON OTRO FORM, INSTANCIA.
        public static frmvista_usuario Getinstance()
        {
            if (_instance == null)
                _instance = new frmvista_usuario();

            return _instance;
        }


        private void Vista_user()
        {
            using (nu = new Nusuario())
            {

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

            dgvvista_user.Columns[1].HeaderText = "CODIGO ACCESO";
            dgvvista_user.Columns[1].Width = 150;

            dgvvista_user.Columns[2].HeaderText = "NOMBRE USUARIO";
            dgvvista_user.Columns[2].Width = 300;

            dgvvista_user.Columns[3].HeaderText = "CONTRASEÑA";
            dgvvista_user.Columns[3].Width = 100;
            dgvvista_user.Columns[3].Visible = false;

            dgvvista_user.Columns[4].HeaderText = "CODIGO ROL";
            dgvvista_user.Columns[4].Width = 50;
            dgvvista_user.Columns[4].Visible = false;

            dgvvista_user.Columns[5].HeaderText = "ROLES";
            dgvvista_user.Columns[5].Width = 230;
          
            dgvvista_user.Columns[6].HeaderText = "GENERO";
            dgvvista_user.Columns[6].Width = 50;
            dgvvista_user.Columns[6].Visible = false;

            dgvvista_user.Columns[7].Visible = false;//STATE
                                      
        }

        private void frmvista_usuario_Load(object sender, EventArgs e)
        {
            
            txtbuscar.Focus();            
            Tooltip.Title(txtbuscar, "Buscar por nombre o codigo", true);
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
            dgvvista_user.DataSource = nu.Search(txtbuscar.Text.Trim());
            lblcantidad.Text = "Total Registro: " + dgvvista_user.RowCount;
        }

        private void frmvista_usuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            _instance = null;
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

        private void btncerrar_MouseMove(object sender, MouseEventArgs e)
        {
            btncerrar.BackColor = Color.Crimson;
            btncerrar.ForeColor = Color.White;
        }
    }
}
