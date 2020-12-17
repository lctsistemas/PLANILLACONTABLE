using Negocio;
using Negocio.ValueObjects;
using Presentacion.Helps;
using Presentacion.Subvista;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Presentacion.Vista
{
    public partial class frmsucursal : Form
    {
        String result;
        NSucursal nsu = new NSucursal();
        private static frmsucursal _instancia;
        public frmsucursal()
        {
            InitializeComponent();
            ExtensionMethods.DoubleBuffered(dgvsucursal,true);
            To_disable(false);
            Show_sucursal();
            Tabla();
        }

        //METODO INSTANCE QUE CONTENGA EL FORMULARIO PARA PODER ACCEDER MEDIANTE OTRO FORMULARIO
        public static frmsucursal Getinstancia()
        {
            if (_instancia == null)
            {
                _instancia = new frmsucursal();
            }
            return _instancia;
        }

        //TOTAL REGISTRO
        private void TotalDatos()
        {
            lbltotal.Text = "Registro Total: " + dgvsucursal.Rows.Count;
        }

        //MOSTRAR SUCURSAL
        private void Show_sucursal()
        {
            using (nsu)
            {
                dgvsucursal.DataSource = nsu.Getall();
                TotalDatos();
            }

        }

        private bool Validar()
        {
            if (String.IsNullOrWhiteSpace(txtcodigo_sucursal.Text) || String.IsNullOrWhiteSpace(txtrazon_social.Text) || String.IsNullOrWhiteSpace(txtlocalidad.Text) || String.IsNullOrWhiteSpace(txtdireccion.Text) || String.IsNullOrWhiteSpace(txtdomicilio.Text) || String.IsNullOrWhiteSpace(txtruc.Text) || String.IsNullOrWhiteSpace(txtregimen.Text) || String.IsNullOrWhiteSpace(txtusuario.Text))
            {
                ValidateChildren();
                return true;
            }
            else
                return false;
        }

        //MODIFICANDO TABLA
        private void Tabla()
        {
            dgvsucursal.Columns[0].HeaderText = "ESTADO";
            dgvsucursal.Columns[0].Width = 30;
            dgvsucursal.Columns[0].Visible = false;

            dgvsucursal.Columns[1].HeaderText = "SID EMPRESA MAESTRA";//de la tabla sucursal
            dgvsucursal.Columns[1].Width = 30;
            dgvsucursal.Columns[1].Visible = false;

            dgvsucursal.Columns[2].HeaderText = "ID EMPRESA";
            dgvsucursal.Columns[2].Width = 30;
            dgvsucursal.Columns[2].Visible = false;

            dgvsucursal.Columns[3].HeaderText = "CODIGO";
            dgvsucursal.Columns[3].Width = 80;
            dgvsucursal.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvsucursal.Columns[4].HeaderText = "RAZON SOCIAL O DENOMINACION";
            dgvsucursal.Columns[4].Width = 250;

            dgvsucursal.Columns[5].HeaderText = "LOCALIDAD";
            dgvsucursal.Columns[5].Width = 200;

            dgvsucursal.Columns[6].HeaderText = "DIRECCION";
            dgvsucursal.Columns[6].Width = 350;

            dgvsucursal.Columns[7].HeaderText = "DOMICILIO FISCAL";
            dgvsucursal.Columns[7].Width = 320;

            dgvsucursal.Columns[8].HeaderText = "RUC";
            dgvsucursal.Columns[8].Width = 90;

            dgvsucursal.Columns[9].HeaderText = "REGIMEN";
            dgvsucursal.Columns[9].Width = 250;

            dgvsucursal.Columns[10].HeaderText = "USUARIO";
            dgvsucursal.Columns[10].Width = 250;

            dgvsucursal.Columns[11].HeaderText = "EMPRESA";
            dgvsucursal.Columns[11].Width = 250;
            dgvsucursal.Columns[11].Visible = false;

            dgvsucursal.Columns[12].Visible = false;
            dgvsucursal.Columns[13].Visible = false;
        }

        //DESABILITAR CAJAS DE TEXTO
        private void To_disable(bool v)
        {
            txtcodigo_sucursal.Enabled = !v;
            txtrazon_social.Enabled = v;
            txtdomicilio.Enabled = v;
            txtruc.Enabled = v;
            txtregimen.Enabled = v;
            txtusuario.Enabled = v;
        }

        //LIMPIAR DATOS
        private void Limpiar()
        {
            txtcodigo_sucursal.Text = "";
            txtrazon_social.Text = "";
            txtdireccion.Text = "";
            txtlocalidad.Text = string.Empty;
            txtdomicilio.Text = "";
            txtruc.Text = "";
            txtusuario.Text = "";
            txtregimen.Text = "";
            txtcodigo_sucursal.Focus();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                return;
            }
            result = "";
            using (nsu)
            {
                nsu.razon_social = txtrazon_social.Text.Trim();
                nsu.direccion = txtdireccion.Text.Trim().ToUpper();
                nsu.domicilio = txtdomicilio.Text.Trim().ToUpper();
                nsu.ruc = txtruc.Text.Trim();
                nsu.regimen = txtregimen.Text.Trim();
                nsu.localidad = txtlocalidad.Text.Trim().ToUpper();

                nsu.scodigo_sucursal = txtcodigo_sucursal.Text.Trim().ToUpper();
                nsu.sidempresa = Convert.ToInt32(txtidempresa.Text.Trim());
                result = nsu.SaveChanges();
                if (result.Contains("¡Codigo"))
                {
                    Messages.M_error(result);
                }
                else
                {
                    Messages.M_info(result);
                    Show_sucursal();
                }
            }
        }

        private void frmsucursal_Load(object sender, EventArgs e)
        {
            txtidempresa.Visible = false;
            Tooltip.Title(txtbuscar, "Buscar por Razón Social o Codigo", true);
            Tooltip.Title(btnempresa, "Seleccione la Empresa Principal", true);
        }

        private void dgvsucursal_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow ro = dgvsucursal.CurrentRow;

            if (dgvsucursal.Rows.GetFirstRow(DataGridViewElementStates.Selected) != -1)
            {
                using (nsu)
                {
                    nsu.state = EntityState.Modificar;

                    nsu.eidemp_maestra = Convert.ToInt32(ro.Cells[1].Value);
                    txtidempresa.Text = ro.Cells[2].Value.ToString();
                    txtcodigo_sucursal.Text = ro.Cells[3].Value.ToString();
                    txtrazon_social.Text = ro.Cells[4].Value.ToString();
                    txtlocalidad.Text = ro.Cells[5].Value.ToString();
                    txtdireccion.Text = ro.Cells[6].Value.ToString();
                    txtdomicilio.Text = ro.Cells[7].Value.ToString();
                    txtruc.Text = ro.Cells[8].Value.ToString();
                    txtregimen.Text = ro.Cells[9].Value.ToString();
                    txtusuario.Text = ro.Cells[10].Value.ToString();
                    this.tapsucursal.SelectedIndex = 1;
                    ValidateError.validate.Clear();
                }
            }
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            dgvsucursal.DataSource = nsu.Search(txtbuscar.Text.Trim());
            TotalDatos();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (dgvsucursal.Rows.GetFirstRow(DataGridViewElementStates.Selected) != -1)
            {
                if (Messages.M_question("¿Desea Anular?") == DialogResult.Yes)
                {
                    result = "";
                    using (nsu)
                    {
                        nsu.state = EntityState.Remover;
                        nsu.sidem_maestra = Convert.ToInt32(dgvsucursal.CurrentRow.Cells[1].Value);
                        result = nsu.SaveChanges();
                        if (result.Contains("Acceso"))
                        {
                            Messages.M_error(result);
                        }
                        else
                        {
                            Messages.M_info(result);
                            Show_sucursal();
                        }
                    }
                }
            }
            else
            {
                Messages.M_warning("Seleccione una fila de la tabla");
            }
        }

        private void btnempresa_Click(object sender, EventArgs e)
        {
             using (frmvista_empresa f_vist = new frmvista_empresa())
             {           
                this.AddOwnedForm(f_vist);
                f_vist.ShowDialog();
            }
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            using (nsu) { nsu.state = EntityState.Guardar; }
            Limpiar();
        }

        private void frmsucursal_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
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

        private void btncerrar_MouseMove(object sender, MouseEventArgs e)
        {
            btncerrar.BackColor = Color.Crimson;
        }

        private void btncerrar_MouseLeave(object sender, EventArgs e)
        {
            btncerrar.BackColor = Color.SlateGray;
        }

        private void btncerrar_MouseDown(object sender, MouseEventArgs e)
        {
            btncerrar.BackColor = Color.FromArgb(245, 183, 177);
        }

        private void btnmaximizar_MouseMove(object sender, MouseEventArgs e)
        {
            btnmaximizar.BackColor = Color.FromArgb(31, 97, 141);
        }

        private void btnmaximizar_MouseLeave(object sender, EventArgs e)
        {
            btnmaximizar.BackColor = Color.SlateGray;
        }

        private void btnrestaurar_MouseMove(object sender, MouseEventArgs e)
        {
            btnrestaurar.BackColor = Color.FromArgb(31, 97, 141);
        }

        private void btnrestaurar_MouseLeave(object sender, EventArgs e)
        {
            btnrestaurar.BackColor = Color.SlateGray;
        }

        private void btnminimizar_MouseMove(object sender, MouseEventArgs e)
        {
            btnminimizar.BackColor = Color.FromArgb(31, 97, 141);
        }

        private void btnminimizar_MouseLeave(object sender, EventArgs e)
        {
            btnminimizar.BackColor = Color.SlateGray;
        }

        private void panelsucursal_MouseDown(object sender, MouseEventArgs e)
        {
            WindowsMove.ReleaseCapture();
            WindowsMove.SendMessage(this.Handle, 0x112, 0xf012, 0);
            btnrestaurar.Visible = false;
            btnmaximizar.Visible = true;
        }

        private void txtcodigo_sucursal_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateError.Validate_text(txtcodigo_sucursal, "¡Código de sucursal requerido!");
        }       

        private void txtlocalidad_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateError.Validate_text(txtlocalidad, "Localidad requerida!");
        }

        private void txtdireccion_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateError.Validate_text(txtdireccion, "¡Dirección requerida!");
        }
       
        private void txtusuario_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateError.Validate_text(txtusuario, "¡Usuario requerido!");
        }

      
    }
}
