﻿using Negocio.Models;
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
            if (String.IsNullOrWhiteSpace(txtacceso.Text) || String.IsNullOrWhiteSpace(txtnom_usuario.Text) || String.IsNullOrWhiteSpace(txtpassword.Text))
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
            dgvusuario.Columns[2].Width = 270;

            dgvusuario.Columns[3].HeaderText = "CONTRASEÑA";
            dgvusuario.Columns[3].Width = 100;

            dgvusuario.Columns[4].HeaderText = "genero";
            dgvusuario.Columns[4].Width = 50;
            dgvusuario.Columns[4].Visible = false;

            dgvusuario.Columns[5].HeaderText = "CODIGO ROL";
            dgvusuario.Columns[5].Width = 50;
            dgvusuario.Columns[5].Visible = false;

            dgvusuario.Columns[6].HeaderText = "ROL";
            dgvusuario.Columns[6].Width = 220;

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
                    cbogenero.Text = r.Cells[4].Value.ToString();//genero
                    cborol.SelectedValue = r.Cells[5].Value.ToString();//idrol
                    cborol.Text = r.Cells[6].Value.ToString();//rol
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

        private void btncerrar_MouseLeave(object sender, EventArgs e)
        {
            btncerrar.BackColor = Color.SteelBlue;
        }

        private void btncerrar_MouseDown(object sender, MouseEventArgs e)
        {
            btncerrar.BackColor = Color.FromArgb(245, 183, 177);
        }

        private void txtbuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Keypress.SoloLetras(e);
        }

        private void btncerrar_MouseMove(object sender, MouseEventArgs e)
        {
            btncerrar.BackColor = Color.Crimson;
        }

        private void paneltitulo_user_MouseDown(object sender, MouseEventArgs e)
        {
            WindowsMove.ReleaseCapture();
            WindowsMove.SendMessage(this.Handle, 0x112, 0xf012, 0);
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
    }
}
