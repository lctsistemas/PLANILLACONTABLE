using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Negocio.Models;
using Negocio.ValueObjects;
using Presentacion.Helps;
using Presentacion.Subvista;

namespace Presentacion.Vista
{
    public partial class frmempresa : Form
    {
        Nempresa ne = new Nempresa();
        String result;
        public frmempresa()
        {
            InitializeComponent();
            Show_empresa("");
            Tabla();
        }

        private void Show_empresa(String buscar)
        {
            using (ne)
            {
                ne.search = buscar;
                dgvempresa.DataSource = ne.Getall();
                lbltotal.Text = "TOTAL REGISTRO:  "+dgvempresa.RowCount;
            }
        }
        private void Tabla()
        {
            dgvempresa.Columns[0].HeaderText = "CODIGO";//codigo empresa maestra
            dgvempresa.Columns[0].Width = 30;
            dgvempresa.Columns[0].Visible = false;

            dgvempresa.Columns[1].HeaderText = "ESTADO";//para definir es estado eliminado
            dgvempresa.Columns[1].Width = 30;
            dgvempresa.Columns[1].Visible = false;

            dgvempresa.Columns[2].HeaderText = "ID USUARIO";
            dgvempresa.Columns[2].Width = 30;
            dgvempresa.Columns[2].Visible = false;

            dgvempresa.Columns[3].HeaderText = "ID EMPRESA MAESTRA";
            dgvempresa.Columns[3].Width = 30;
            dgvempresa.Columns[3].Visible = false;

            dgvempresa.Columns[4].HeaderText = "ID EMPRESA";
            dgvempresa.Columns[4].Width = 30;
            dgvempresa.Columns[4].Visible = false;

            dgvempresa.Columns[5].HeaderText = "CODIGO EMPRESA";
            dgvempresa.Columns[5].Width = 100;

            dgvempresa.Columns[6].HeaderText = "RAZON SOCIAL";
            dgvempresa.Columns[6].Width = 350;

            dgvempresa.Columns[7].HeaderText = "LOCALIDAD";
            dgvempresa.Columns[7].Width = 250;

            dgvempresa.Columns[8].HeaderText = "DIRECCION";
            dgvempresa.Columns[8].Width = 370;

            dgvempresa.Columns[9].HeaderText = "DOMICILIO FISCAL";
            dgvempresa.Columns[9].Width = 370;

            dgvempresa.Columns[10].HeaderText = "RUC";
            dgvempresa.Columns[10].Width = 90;

            dgvempresa.Columns[11].HeaderText = "REGIMEN";
            dgvempresa.Columns[11].Width = 270;

            dgvempresa.Columns[12].HeaderText = "USUARIO";
            dgvempresa.Columns[12].Width = 270;

            dgvempresa.Columns[13].Visible = false;
            //dgvempresa.Columns[12].Visible = false;

        }

        //VALIDAR CONTROLES
        private bool Validar()
        {
            if (String.IsNullOrWhiteSpace(txtcodigo_empresa.Text) || String.IsNullOrWhiteSpace(txtrazon_social.Text)
                || String.IsNullOrWhiteSpace(txtdireccion.Text) || String.IsNullOrWhiteSpace(txtdomicilio.Text) 
                || String.IsNullOrWhiteSpace(txtruc.Text) || String.IsNullOrWhiteSpace(txtusuario.Text) 
                || cboregimen.Text.Equals(""))
            {
                ValidateChildren();
                return true;
            }
            else
                return false;
        }
        //METODO LIMPIAR
        private void Limpiar()
        {
            txtcodigo_empresa.Text = "";
            txtrazon_social.Text = "";
            txtlocalidad.Text = String.Empty;
            txtdireccion.Text = "";
            txtdomicilio.Text = "";
            txtruc.Text = "";
            txtusuario.Text = "";
            cboregimen.Text = null;
            txtrazon_social.Focus();
        }
        //CARGAR REGIMEN
        private void CargarRegimen()
        {
            cboregimen.Items.Add("Nuevo Régimen Único Simplificado");
            cboregimen.Items.Add("Régimen Especial de Impuesto a la Renta");
            cboregimen.Items.Add("Régimen MYPE Tributario");
            cboregimen.Items.Add("Régimen General");
        }
        //BOTON GUARDAR
        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (Validar())
                return;

            result = "";
            using (ne)
            {
                ne.razon_social = txtrazon_social.Text.Trim().ToUpper();
                ne.direccion = txtdireccion.Text.Trim().ToUpper();
                ne.domicilio = txtdomicilio.Text.Trim().ToUpper();
                ne.ruc = txtruc.Text.Trim();
                ne.regimen = cboregimen.SelectedItem.ToString();
                ne.localidad = txtlocalidad.Text.Trim().ToUpper();

                ne.ecodigo_empresa = txtcodigo_empresa.Text.Trim().ToUpper();
                ne.eidusuario = Convert.ToInt32(txtiduser.Text.Trim());
                result = ne.SaveChanges();
                if (result.Contains("CODIGO"))
                {
                    Messages.M_error(result);
                }
                else
                {
                    Messages.M_info(result);
                    Show_empresa("");
                }

            }
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            using (ne) { ne.state = EntityState.Guardar; }
            Limpiar();
            ValidateError.validate.Clear();                      
        }

        private void btnusuario_Click(object sender, EventArgs e)
        {
            //TIENE QUE SER OTRA MANERA ESTO.
            frmvista_usuario f_vist = new frmvista_usuario();
            this.AddOwnedForm(f_vist);
            f_vist.StartPosition = FormStartPosition.CenterParent;
            f_vist.ShowDialog();

        }

        private void frmempresa_Load(object sender, EventArgs e)
        {
            txtusuario.Enabled = false;
            txtiduser.Visible = false;
            Tooltip.Title(btnusuario, "Seleccione Usuario");
            Tooltip.Title(txtbuscar, "Buscar por Razon Social o Codigo Empresa");
            CargarRegimen();
        }

        private void txtcodigo_empresa_Validating(object sender, CancelEventArgs e)
        {
            ValidateError.Validate_text(txtcodigo_empresa,"Ingrese Codigo");
        }

        private void txtrazon_social_Validating(object sender, CancelEventArgs e)
        {
            ValidateError.Validate_text(txtrazon_social,"Ingrese Razon Social");
        }

        private void txtdireccion_Validating(object sender, CancelEventArgs e)
        {
            ValidateError.Validate_text(txtdireccion,"Ingrese Dirección");
        }

        private void txtdomicilio_Validated(object sender, EventArgs e)
        {
            ValidateError.Validate_text(txtdomicilio,"Ingrese Domicilio");
        }

        private void txtruc_Validating(object sender, CancelEventArgs e)
        {
            ValidateError.Validate_text(txtruc,"Ingrese Ruc");
        }

        private void cboregimen_Validating(object sender, CancelEventArgs e)
        {
            ValidateError.Validate_combo(cboregimen,"Seleccione Regimen");
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            Show_empresa(txtbuscar.Text.Trim());
        }

        private void dgvempresa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow ro = dgvempresa.CurrentRow;

            if (dgvempresa.Rows.GetFirstRow(DataGridViewElementStates.Selected) != -1)
            {
                using (ne)
                {
                    ne.state = EntityState.Modificar;
                    txtiduser.Text = ro.Cells[2].Value.ToString();
                    ne.eidemp_maestra = Convert.ToInt32(ro.Cells[3].Value);
                    txtcodigo_empresa.Text = ro.Cells[5].Value.ToString();
                    txtrazon_social.Text = ro.Cells[6].Value.ToString();
                    txtlocalidad.Text = ro.Cells[7].Value.ToString();
                    txtdireccion.Text = ro.Cells[8].Value.ToString();
                    txtdomicilio.Text = ro.Cells[9].Value.ToString();
                    txtruc.Text = ro.Cells[10].Value.ToString();
                    cboregimen.Text = ro.Cells[11].Value.ToString();
                    txtusuario.Text = ro.Cells[12].Value.ToString();
                    this.tabempresa.SelectedIndex = 1;
                    ValidateError.validate.Clear();
                }
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (dgvempresa.Rows.GetFirstRow(DataGridViewElementStates.Selected) != -1)
            {
                if (Messages.M_question("¿Desea Eliminar?") == DialogResult.Yes)
                {
                    result = "";
                    using (ne)
                    {
                        ne.state = EntityState.Remover;
                        ne.eidemp_maestra = Convert.ToInt32(dgvempresa.CurrentRow.Cells[3].Value);
                        result = ne.SaveChanges();
                        if (result.Contains("ACCESO"))
                        {
                            Messages.M_error(result);
                        }
                        else
                        {
                            Messages.M_info(result);
                            Show_empresa("");
                        }
                    }
                }
            }
            else
            {
                Messages.M_warning("Seleccione Una Fila de la Tabla");
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void frmempresa_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

         private void btncerrar_MouseMove(object sender, MouseEventArgs e)
        {
            btncerrar.BackColor = Color.Crimson;
        }

        private void btncerrar_MouseLeave(object sender, EventArgs e)
        {
            btncerrar.BackColor = Color.SteelBlue;
        }

        private void btncerrar_MouseDown(object sender, MouseEventArgs e)
        {
            btncerrar.BackColor = Color.FromArgb(245, 183, 177);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            WindowsMove.ReleaseCapture();
            WindowsMove.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnmaximizar_MouseLeave(object sender, EventArgs e)
        {
            btnmaximizar.BackColor = Color.SteelBlue;
        }

        private void btnrestaurar_MouseLeave(object sender, EventArgs e)
        {
            btnrestaurar.BackColor = Color.SteelBlue;
        }

        private void btnminimizar_MouseLeave(object sender, EventArgs e)
        {
            btnminimizar.BackColor = Color.SteelBlue;
        }

        private void btnminimizar_MouseMove(object sender, MouseEventArgs e)
        {
            btnminimizar.BackColor = Color.FromArgb(31, 97, 141);//plomito oscuro
        }

        private void btnrestaurar_MouseMove(object sender, MouseEventArgs e)
        {
            btnrestaurar.BackColor = Color.FromArgb(31, 97, 141);
        }

        private void btnmaximizar_MouseMove(object sender, MouseEventArgs e)
        {
            btnmaximizar.BackColor = Color.FromArgb(31, 97, 141);
        }

        
    }
}
