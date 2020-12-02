using Negocio.Models;
using Negocio.ValueObjects;
using Presentacion.Helps;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Presentacion.Vista
{
    public partial class FrmManto_Regimen : Form
    {
        String result;
        private NRegimen nr = new NRegimen();
        public FrmManto_Regimen()
        {
            InitializeComponent();
        }

        private void Manto_Regimen_Load(object sender, EventArgs e)
        {

            cbxregimen.Items.Add("SNP");
            cbxregimen.Items.Add("SPP");
            ShowRegimen();
            Tabla();
            Habilitar(false);
        }


        private void btnagregar_Click(object sender, EventArgs e)
        {
            using (nr) { nr.state = EntityState.Guardar; }

            Habilitar(true);
            limpiar();

        }

        private void limpiar()
        {
            txtdescripcion.Text = String.Empty;
            txtdescCorta.Text = String.Empty;
            cbxregimen.Text = "";            
            using (nr) { nr.state = EntityState.Guardar; }
        }

        private void Habilitar(bool v)
        {
            btnguardar.Enabled = v;
            txtdescripcion.Enabled = v;
            txtdescCorta.Enabled = v;
            cbxregimen.Enabled = v;
            txtdescripcion.Focus();
        }

        private void Tabla()
        {
            dgvregimen.Columns[0].HeaderText = "codigo";
            dgvregimen.Columns[0].Width = 100;
            dgvregimen.Columns[0].Visible = false;

            dgvregimen.Columns[1].HeaderText = "DESCRIPCION";
            dgvregimen.Columns[1].Width = 150;

            dgvregimen.Columns[2].HeaderText = "DES. CORTA";
            dgvregimen.Columns[2].Width = 140;

            dgvregimen.Columns[3].HeaderText = "TIPO REGIMEN";
            dgvregimen.Columns[3].Width = 217;

            dgvregimen.Columns[4].HeaderText = "";
            dgvregimen.Columns[4].Width = 100;
            dgvregimen.Columns[4].Visible = false;

        }

        private void ShowRegimen()
        {
            using (nr)
            {
                dgvregimen.DataSource = nr.Getall();
                lbltotal.Text = "Total registro: " + dgvregimen.Rows.Count;
            }
        }

        private bool Validar()
        {
            if (String.IsNullOrWhiteSpace(txtdescripcion.Text)|| String.IsNullOrWhiteSpace(txtdescCorta.Text)|| String.IsNullOrWhiteSpace(cbxregimen.Text))
            {
                ValidateChildren();
                return true;
            }
            else
                return false;
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            result = "";
            if (Validar())
            {
                ValidateChildren();
                return;
            }
            using (nr)
            {
                nr.Descripcion_corta = txtdescCorta.Text.Trim().ToUpper();
                nr.Descripcion = txtdescripcion.Text.Trim().ToUpper();
                nr.Tipo_regimen = cbxregimen.Text.Trim();

                bool valida = new ValidacionDatos(nr).Validate();
                if (valida)
                {
                    if (String.IsNullOrEmpty(cbxregimen.SelectedItem.ToString().Trim()))
                        return;
                    result = nr.GuardarCambios();

                    Messages.M_info(result);
                    limpiar();
                }

                ShowRegimen();
            }
        }

      

        private void dgvregimen_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = dgvregimen.CurrentRow;
            Habilitar(true);
            if (dgvregimen.Rows.GetFirstRow(DataGridViewElementStates.Selected) != -1)
            {
                using (nr)
                {
                    nr.state = EntityState.Modificar;
                    nr.Codigo_Regimen = Convert.ToInt32(r.Cells[0].Value);
                    txtdescripcion.Text = Convert.ToString(r.Cells[1].Value);
                    txtdescCorta.Text = Convert.ToString(r.Cells[2].Value);
                    cbxregimen.Text = r.Cells[3].Value.ToString();
                    ValidateError.validate.Clear();//LIMPIA LOS ERRORPROVIDER                    
                }
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            result = "";
            if (dgvregimen.Rows.GetFirstRow(DataGridViewElementStates.Selected) != -1)
            {
                DialogResult r = Messages.M_question("¿Desea eliminar la fila?");
                if (r == DialogResult.Yes)
                {
                    using (nr)
                    {
                        nr.state = EntityState.Remover;
                        nr.Codigo_Regimen = Convert.ToInt32(dgvregimen.CurrentRow.Cells[0].Value);
                        result = nr.GuardarCambios();
                        ShowRegimen();
                        Messages.M_info(result);
                    }
                }
            }
            else
            {
                Messages.M_warning("Seleccione una fila de la tabla");
            }
        }

        private void txtdescripcion_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
                ValidateError.Validate_text(txtdescripcion, "Campo Requerido");

        }

        private void txtdescCorta_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateError.Validate_text(txtdescCorta, "Campo Requerido");
        }

        private void cbxregimen_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateError.Validate_combo(cbxregimen, "Campo Requerido");
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btncerrar_MouseDown(object sender, MouseEventArgs e)
        {
            btncerrar.BackColor = Color.FromArgb(245, 183, 177);
        }

        private void btncerrar_MouseHover(object sender, EventArgs e)
        {
            btncerrar.BackColor = Color.Crimson;
        }

        private void btncerrar_MouseLeave(object sender, EventArgs e)
        {
            btncerrar.BackColor = Color.SteelBlue;
        }

        private void btnminimizar_MouseLeave(object sender, EventArgs e)
        {
            btnminimizar.BackColor = Color.SteelBlue;
        }

        private void btnminimizar_MouseHover(object sender, EventArgs e)
        {
            btnminimizar.BackColor = Color.FromArgb(31, 97, 141);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            WindowsMove.ReleaseCapture();
            WindowsMove.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label5_MouseDown(object sender, MouseEventArgs e)
        {
            WindowsMove.ReleaseCapture();
            WindowsMove.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
