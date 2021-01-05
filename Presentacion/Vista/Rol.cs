using Negocio.Models;
using Negocio.ValueObjects;
using Presentacion.Helps;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Presentacion.Vista
{
    public partial class frmrol : Form
    {
        Nrol nr = new Nrol();
        string result = "";
    
        public frmrol()
        {
            InitializeComponent();
           
        }
        
        //METODO SHOW IN DATAGRIVIEW
        private void ShowRol()
        {
            using (nr)
            {
                dgvrol.DataSource = nr.Getall();
                lbltotal.Text = "Total registro:  " + dgvrol.RowCount.ToString();
            }
        }
        //MODIFICAR DATAGRIDVIEW
        private void Tabla()
        {
            dgvrol.Columns[0].HeaderText = "CODIGO";
            dgvrol.Columns[0].Width = 50;
            dgvrol.Columns[0].Visible = false;

            dgvrol.Columns[1].HeaderText = "NOMBRE ROL";
            dgvrol.Columns[1].Width = 344;
        }
        private void Limpiar()
        {
            txtrol.Text = String.Empty;
            using (nr) { nr.state = EntityState.Guardar; }
            txtrol.Focus();
        }

        //HABILITAR
        private void Habilitar(bool v)
        {
            btnsave.Enabled = v;
            btneliminar.Enabled = false;
            txtrol.Enabled = v;
        }

        //...........
      

        //GUARDAR
        private void btnsave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtrol.Text)) {

                ValidateChildren();
                return;
            }                
            using (nr)
            {
                nr.nombre_rol = txtrol.Text.Trim().ToUpper();
                result = nr.SaveChanges();
                ShowRol(); 
                Limpiar();
                Messages.M_info(result);
                
            }
        }
        //LOAD
        private void frmrol_Load(object sender, EventArgs e)
        {
            Habilitar(false);
            ShowRol();
            Tabla();
        }
        //PARA EDITAR
        private void dgvrol_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvrol.Rows.GetFirstRow(DataGridViewElementStates.Selected) != -1 && e.RowIndex > -1)
            {
                Habilitar(true);
                using (nr)
                {
                    nr.state = EntityState.Modificar;
                    nr.idrol = Convert.ToInt32(dgvrol.CurrentRow.Cells[0].Value);//idrol
                    txtrol.Text = dgvrol.CurrentRow.Cells[1].Value.ToString();//nombre rol
                    ValidateError.validate.Clear();
                    
                }
            }
        }
        //NUEVO
        private void btnnuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
            Habilitar(true);
            ValidateError.validate.Clear();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (dgvrol.Rows.GetFirstRow(DataGridViewElementStates.Selected) != -1)
            {
                DialogResult rsu = Messages.M_question("¿Desea eliminar rol?");
                if (rsu == DialogResult.Yes)
                {
                    using (nr)
                    {
                        nr.state = EntityState.Remover;
                        nr.idrol = Convert.ToInt32(dgvrol.CurrentRow.Cells[0].Value);
                        result = nr.SaveChanges();
                        
                        if (result.Contains("esta en uso."))
                        {
                            Messages.M_warning(result);
                        }
                        else
                        {
                            ShowRol();
                            Limpiar();
                            Messages.M_info(result);

                        }
                        

                    }
                }
            }
        }

        private void txtrol_KeyPress(object sender, KeyPressEventArgs e)
        {
            Keypress.SoloLetras(e);
        }

        private void txtrol_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateError.Validate_text(txtrol, "Rol requerido!");
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
        private void btncerrar_MouseLeave(object sender, EventArgs e)
        {
            btncerrar.BackColor = Color.FromArgb(116, 118, 118);
        }

        private void btncerrar_MouseDown(object sender, MouseEventArgs e)
        {
            btncerrar.BackColor = Color.FromArgb(241, 112, 122);
        }

        private void btncerrar_MouseMove(object sender, MouseEventArgs e)
        {
            btncerrar.BackColor = Color.Crimson;
        }

        //MINIMIZAR
        private void btnminimizar_MouseDown(object sender, MouseEventArgs e)
        {
            btnminimizar.BackColor = Color.FromArgb(165, 171, 179);
        }

        private void btnminimizar_MouseLeave(object sender, EventArgs e)
        {
            btnminimizar.BackColor = Color.FromArgb(116, 118, 118);
        }

        private void btnminimizar_MouseMove(object sender, MouseEventArgs e)
        {
            btnminimizar.BackColor = Color.FromArgb(138, 140, 140);
        }
        //...
        private void panelheader_MouseDown(object sender, MouseEventArgs e)
        {
            WindowsMove.ReleaseCapture();
            WindowsMove.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void dgvrol_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                btneliminar.Enabled = true;
                ValidateError.validate.Clear();
            }
               
        }
    }
}
