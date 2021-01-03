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
            Habilitar(true);
            limpiar();
            ValidateError.validate.Clear();
        }

        private void limpiar()
        {
            txtdescripcion.Text = String.Empty;
            txtdescCorta.Text = String.Empty;
            cbxregimen.Text = null;            
            using (nr) { nr.state = EntityState.Guardar; }
        }

        private void Habilitar(bool v)
        {
            btnguardar.Enabled = v;
            txtdescripcion.Enabled = v;
            txtdescCorta.Enabled = v;
            cbxregimen.Enabled = v;
            txtdescripcion.Focus();
            btneliminar.Enabled = false;
        }

        private void Tabla()
        {
            dgvregimen.Columns[0].HeaderText = "codigo";
            dgvregimen.Columns[0].Width = 100;
            dgvregimen.Columns[0].Visible = false;

            dgvregimen.Columns[1].HeaderText = "DESCRIPCION";
            dgvregimen.Columns[1].Width = 158;

            dgvregimen.Columns[2].HeaderText = "DES. CORTA";
            dgvregimen.Columns[2].Width = 148;

            dgvregimen.Columns[3].HeaderText = "TIPO REGIMEN";
            dgvregimen.Columns[3].Width = 123;

            dgvregimen.Columns[4].HeaderText = "ESTADO"; //ADD, EDIT, DELETE
            dgvregimen.Columns[4].Width = 50;
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
                result = nr.GuardarCambios();
                              
                ShowRegimen();
                Messages.M_info(result);
                limpiar();
            }
        }

      

        private void dgvregimen_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = dgvregimen.CurrentRow;
            
            if (dgvregimen.Rows.GetFirstRow(DataGridViewElementStates.Selected) != -1 && e.RowIndex > -1)
            {
                Habilitar(true);
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
                        if (result.Contains("La operacion fue denegada"))
                            Messages.M_warning(result);
                        else
                        {
                            ShowRegimen();
                            Messages.M_info(result);
                        }
                        limpiar();
                        
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

        //BOTONES COLORES
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
        private void btncerrar_MouseMove(object sender, MouseEventArgs e)
        {
            btncerrar.BackColor = Color.Crimson;
        }

        private void btnminimizar_MouseDown(object sender, MouseEventArgs e)
        {
            btnminimizar.BackColor = Color.FromArgb(165,171,179);
        }

        private void btnminimizar_MouseMove(object sender, MouseEventArgs e)
        {
            btnminimizar.BackColor = Color.FromArgb(138,140,140);
        }

        //ventana y titulo
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

        private void dgvregimen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
                btneliminar.Enabled = true;
        }
    }
}
