using Negocio.Models;
using Negocio.ValueObjects;
using Presentacion.Helps;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Presentacion.Vista
{
    public partial class frmusuario : Form
    {
        private Nusuario nu = new Nusuario();
        private String result;

        public frmusuario()
        {
            InitializeComponent();
            ShowRol();
            ShowUser();
        }
        //MOSTRAR ROL
        private void ShowRol()
        {
            using (Nrol nr = new Nrol())
            {
                cborol.DataSource = nr.Getall();
                cborol.DisplayMember = "nombre_rol";
                cborol.ValueMember = "idrol";
            }
        }

        //MOSTRAR USUARIO
        private void ShowUser()
        {
            using (nu)
            {
                dgvusuario.DataSource = nu.Getall();
                lbltotal.Text = "Total Registro  " + dgvusuario.RowCount;
            }
        }

        private bool Validar()
        {
            if (String.IsNullOrWhiteSpace(txtacceso.Text) || String.IsNullOrWhiteSpace(txtnom_usuario.Text)
                || String.IsNullOrWhiteSpace(txtpassword.Text) || String.IsNullOrWhiteSpace(cbogenero.Text)
                || String.IsNullOrWhiteSpace(cborol.Text))
            {
                ValidateChildren();
                return true;
            }
            else
                return false;
        }

        //MODIFICAR DATAGRIDVIEW
        private void Tabla()
        {
            dgvusuario.Columns[0].HeaderText = "CODIGO";
            dgvusuario.Columns[0].Width = 50;
            dgvusuario.Columns[0].Visible = false;

            dgvusuario.Columns[1].HeaderText = "ACCESO USUARIO";
            dgvusuario.Columns[1].Width = 150;

            dgvusuario.Columns[2].HeaderText = "NOMBRE USUARIO";
            dgvusuario.Columns[2].Width = 340;

            dgvusuario.Columns[3].HeaderText = "CONTRASEÑA";
            dgvusuario.Columns[3].Width = 100;

            dgvusuario.Columns[4].HeaderText = "CODIGO ROL";
            dgvusuario.Columns[4].Width = 50;
            dgvusuario.Columns[4].Visible = false;

            dgvusuario.Columns[5].HeaderText = "ROL";
            dgvusuario.Columns[5].Width = 240;

            dgvusuario.Columns[6].HeaderText = "GENERO";
            dgvusuario.Columns[6].Width = 50;
            dgvusuario.Columns[6].Visible = false;

            dgvusuario.Columns[7].HeaderText = "STATE";
            dgvusuario.Columns[7].Width = 50;
            dgvusuario.Columns[7].Visible = false;
        }

        //HABILITAR CONTROLES
        private void Habilitar(bool v)
        {
            btnguardar.Enabled = v;
            txtacceso.Enabled = v;
            txtnom_usuario.Enabled = v;
            txtpassword.Enabled = v;
            cborol.Enabled = v;
            cbogenero.Enabled = v;
            btnrol.Enabled = v;
        }

        //LIMPIAR CONTROLES
        private void limpiar()
        {
            txtacceso.Text = String.Empty;
            txtnom_usuario.Text = String.Empty;
            txtpassword.Text = String.Empty;
            cborol.Text = "";
            cbogenero.Text = null;
            cborol.SelectedValue = 0;
            txtacceso.Focus();
        }

        //LOAD
        private void frmusuario_Load(object sender, EventArgs e)
        {
            cbogenero.Items.Add("M");
            cbogenero.Items.Add("F");
            Tooltip.Title(btnrol, "Registrar Rol", true);
            Tooltip.Title(txtbuscar, "Buscar por Nombre o Codigo", true);
            Tabla();
            Habilitar(false);
            cborol.Text = "";
            cborol.SelectedValue = 0;
        }

        //FORMULARIO ROL
        private void btnrol_Click(object sender, EventArgs e)
        {
            frmrol fr = frmrol.GetInstance();
            fr.StartPosition = FormStartPosition.CenterParent;
            fr.ShowDialog();
            ShowRol();
        }

        //NUEVO
        private void btnnuevo_Click(object sender, EventArgs e)
        {
            using (nu) { nu.state = EntityState.Guardar; }
            Habilitar(true);
            limpiar();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                return;
            }
            result = "";
            using (nu)
            {
                nu.Codigo_usu = txtacceso.Text.Trim().ToUpper();
                nu.Nombre_refe = txtnom_usuario.Text.Trim().ToUpper();
                nu.Password = txtpassword.Text.Trim();
                nu.Genero = cbogenero.SelectedItem.ToString();
                nu.Idrol = Convert.ToInt32(cborol.SelectedValue);

                result = nu.SaveChanges();
                Messages.M_info(result);
                ShowUser();
                limpiar();
            }
        }

        //BUSCAR
        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            dgvusuario.DataSource = nu.Search(txtbuscar.Text.Trim());
            lbltotal.Text = "Total Registro  " + dgvusuario.RowCount;
        }
        //DATAGRIDVIEW
        private void dgvusuario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = dgvusuario.CurrentRow;
            if (dgvusuario.Rows.GetFirstRow(DataGridViewElementStates.Selected) != -1)
            {
                using (nu)
                {
                    nu.state = EntityState.Modificar;
                    nu.Idusuario = Convert.ToInt32(r.Cells[0].Value);//idusuario              
                    txtacceso.Text = r.Cells[1].Value.ToString();//codigo acceso
                    txtnom_usuario.Text = r.Cells[2].Value.ToString();//referencia
                    txtpassword.Text = r.Cells[3].Value.ToString();//contrasena                    
                    cborol.SelectedValue = r.Cells[4].Value.ToString();//idrol
                    cborol.Text = r.Cells[5].Value.ToString();//rol
                    cbogenero.Text = r.Cells[6].Value.ToString();//genero
                    tabuser.SelectedIndex = 1;
                    Habilitar(true);
                    ValidateError.validate.Clear();
                }
            }
        }
        //REMOVER BUTTON
        private void btnremover_Click(object sender, EventArgs e)
        {
            result = "";
            if (dgvusuario.Rows.GetFirstRow(DataGridViewElementStates.Selected) != -1)
            {
                DialogResult re = Messages.M_question("¿Desea eliminar usuario?");
                if (re == DialogResult.Yes)
                {
                    using (nu)
                    {
                        nu.state = EntityState.Remover;
                        nu.Idusuario = Convert.ToInt32(dgvusuario.CurrentRow.Cells[0].Value);//idusuario
                        result = nu.SaveChanges();
                        if (result.Contains("esta asignado"))
                            Messages.M_error(result);
                        else
                        {
                            Messages.M_info(result);
                            ShowUser();
                            btnguardar.Enabled = false;
                        }
                    }
                }
            }
            else
            {
                Messages.M_warning("Seleccione un Fila");
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmusuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        //botones colores
        private void btncerrar_MouseLeave(object sender, EventArgs e)
        {
            btncerrar.BackColor = Color.FromArgb(116,118,118);
        }

        private void btncerrar_MouseDown(object sender, MouseEventArgs e)
        {
            btncerrar.BackColor = Color.FromArgb(241,112,122);
        }     

        private void btncerrar_MouseMove(object sender, MouseEventArgs e)
        {
            btncerrar.BackColor = Color.Crimson;
        }

        //restaurar
        private void btnrestaurar_MouseDown(object sender, MouseEventArgs e)
        {
            btnrestaurar.BackColor = Color.FromArgb(165,171,179);
        }

        private void btnrestaurar_MouseLeave(object sender, EventArgs e)
        {
            btnrestaurar.BackColor = Color.FromArgb(116,118,118);
        }

        private void btnrestaurar_MouseMove(object sender, MouseEventArgs e)
        {
            btnrestaurar.BackColor = Color.FromArgb(138,140,140);
        }
        //maximizar
        private void btnmaximizar_MouseDown(object sender, MouseEventArgs e)
        {
            btnmaximizar.BackColor = Color.FromArgb(165,171,179);
        }

        private void btnmaximizar_MouseLeave(object sender, EventArgs e)
        {
            btnmaximizar.BackColor = Color.FromArgb(116,118,118);
        }

        private void btnmaximizar_MouseMove(object sender, MouseEventArgs e)
        {
            btnmaximizar.BackColor = Color.FromArgb(138,140,140);
        }
        //minimizar
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
            btnminimizar.BackColor = Color.FromArgb(138,140,140);
        }
        //..

        private void txtbuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Keypress.SoloLetras(e);
        }
        private void paneltitulo_user_MouseDown(object sender, MouseEventArgs e)
        {
            WindowsMove.ReleaseCapture();
            WindowsMove.SendMessage(this.Handle, 0x112, 0xf012, 0);
            if(this.WindowState == FormWindowState.Normal)
            {
                btnrestaurar.Visible = false;
                btnmaximizar.Visible = true;
            }
            
        }

        private void btnmaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnrestaurar.Visible = true;
            btnmaximizar.Visible = false;
        }

        private void btnrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnrestaurar.Visible = false;
            btnmaximizar.Visible = true;
        }
        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void cbogenero_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateError.Validate_combo(cbogenero, "Campo genero requerido!");
        }

        private void cborol_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateError.Validate_combo(cborol, "Campo rol requerido!");
        }

        private void txtacceso_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateError.Validate_text(txtacceso, "Codigo de acceso requerido!");
        }

        private void txtnom_usuario_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateError.Validate_text(txtnom_usuario, "Nombre de usuario requerido!");
        }

        private void txtpassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateError.Validate_text(txtpassword, "Contraseña requerida!");
        }

        
       

       
    }
}
