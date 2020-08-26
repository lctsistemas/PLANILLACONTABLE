using Negocio.Models;
using Negocio.ValueObjects;
using Presentacion.Helps;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Presentacion.Vista
{
    public partial class frmusuario : Form
    {
        private Nusuario nu = new Nusuario();
        
        private String result;
        private Int32 codigo;


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
                dgvusuario.DataSource= nu.Getall();
                lbltotal.Text = "Total Registro  " + dgvusuario.RowCount;
            }
        }

        //GENERAR CODIGO 
        private void GenerarCodigo()
        {
            codigo = 0;
            using (nu)
            {
                codigo = nu.Getcodigo();
                txtcodigo.Text = "USER 0" + codigo;
            }
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
            dgvusuario.Columns[2].Width = 250;

            dgvusuario.Columns[3].HeaderText = "CONTRASEÑA";
            dgvusuario.Columns[3].Width = 100;

            dgvusuario.Columns[4].HeaderText = "CODIGO ROL";
            dgvusuario.Columns[4].Width = 50;
            dgvusuario.Columns[4].Visible = false;

            dgvusuario.Columns[5].HeaderText = "ROL";
            dgvusuario.Columns[5].Width = 200;

            dgvusuario.Columns[6].HeaderText = "STATE";
            dgvusuario.Columns[6].Width = 50;
            dgvusuario.Columns[6].Visible = false;
        }        

        //HABILITAR CONTROLES
        private void Habilitar(bool v)
        {
            btnguardar.Enabled = v;
            txtacceso.Enabled = v;
            txtnom_usuario.Enabled = v;
            txtpassword.Enabled = v;
            cborol.Enabled = v;
            btnrol.Enabled = v;
        }

        //LIMPIAR CONTROLES
        private void limpiar()
        {
            txtacceso.Text = String.Empty;
            txtnom_usuario.Text = String.Empty;
            txtpassword.Text = String.Empty;
            cborol.Text = "";
            cborol.SelectedValue = 0;
            txtacceso.Focus();
        }

        //LOAD
        private void frmusuario_Load(object sender, EventArgs e)
        {
            Tooltip.Title(btnrol, "Registrar Rol",true);
            Tooltip.Title(txtbuscar, "Buscar por Nombre o Codigo",true);
            Tabla();
            Habilitar(false);
            cborol.Text = "";
            cborol.SelectedValue = 0;
            txtcodigo.Enabled = false;
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
            GenerarCodigo();
            Habilitar(true);
            limpiar();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            result = "";
            using (nu)
            {
                if (nu.state == EntityState.Guardar)
                    nu.Idusuario = codigo;

                nu.Codigo_usu = txtacceso.Text.Trim().ToUpper();
                nu.Nombre_refe = txtnom_usuario.Text.Trim().ToUpper();
                nu.Password = txtpassword.Text.Trim();
                nu.Idrol = Convert.ToInt32(cborol.SelectedValue);

                bool valida = new ValidacionDatos(nu).Validate(lblerror);
                if (valida)
                {
                    if (String.IsNullOrEmpty(cborol.SelectedText))
                        return;
                    result = nu.SaveChanges();
                    ShowUser();
                    Messages.M_info(result);
                    if (nu.state == EntityState.Guardar)
                    {
                        GenerarCodigo();
                        limpiar();
                    }
                }
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
                    txtcodigo.Text = "USER 0" + nu.Idusuario;
                    txtacceso.Text = r.Cells[1].Value.ToString();//codigo acceso
                    txtnom_usuario.Text = r.Cells[2].Value.ToString();//referencia
                    txtpassword.Text = r.Cells[3].Value.ToString();//contrasena
                    cborol.SelectedValue = r.Cells[4].Value.ToString();//idrol
                    cborol.Text = r.Cells[5].Value.ToString();//rol
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
                DialogResult re = Messages.M_question("¿Desea Eliminar Usuario?");
                if (re == DialogResult.Yes)
                {
                    using (nu)
                    {
                        nu.state = EntityState.Remover;
                        nu.Idusuario = Convert.ToInt32(dgvusuario.CurrentRow.Cells[0].Value);//idusuario
                        result = nu.SaveChanges();
                        Messages.M_info(result);
                        ShowUser();
                        btnguardar.Enabled = false;
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
    }
}
