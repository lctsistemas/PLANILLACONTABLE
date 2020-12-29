using Comun.Cache;
using Negocio.Models;
using Presentacion;
using Presentacion.Helps;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Login_inicio
{
    public partial class frminicio : Form
    {
        Nlogin nlo;
        List<object> lis_empresa;
        bool activo = false;

        public frminicio()
        {
            InitializeComponent();
            Fill_user();            
            IniciarPlaceHolder();

        }

        //MOVER FORMULARIO
        private void MoverVentana()
        {
            WindowsMove.ReleaseCapture();
            WindowsMove.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //LLAMAR USUARIO PARA CARGAR EN COMBOBOX
        private void Fill_user()
        {
            using (Nusuario nusu = new Nusuario())               
            {
                Cbouser.DataSource = nusu.Getall();
                Cbouser.DisplayMember = "nombre_refe";
                Cbouser.ValueMember = "name_rol";//mostrar el rol como Value. para que muestre en caja de texto ROL.
                Cbouser.Text = null;               
            }
        }       

        //PARA USER
        private void txtuser_Enter(object sender, EventArgs e)
        {
            if (txtuser.Text.Equals("USUARIO"))
            {
                txtuser.Text = String.Empty;
                txtuser.ForeColor = Color.LightGray;
            }
        }
        private void txtuser_Leave(object sender, EventArgs e)
        {
            //cuando sale del foco
            if (String.IsNullOrWhiteSpace(txtuser.Text))
            {
                txtuser.Text = "USUARIO";
                txtuser.ForeColor = Color.DimGray;
            }
        }

        //PARA ROLES
        private void txtroles_Enter(object sender, EventArgs e)
        {
            if (txtroles.Text.Trim().Equals("ROL"))
            {
                txtroles.Text = String.Empty;
                txtroles.ForeColor = Color.LightGray;
            }
        }

        private void txtroles_Leave(object sender, EventArgs e)
        {
            IniciarPlaceHolder();
        }

        void IniciarPlaceHolder()
        {
            if (String.IsNullOrWhiteSpace(txtroles.Text))
            {
                txtroles.Text = "ROL";
                txtroles.ForeColor = Color.DimGray;
            }
        }


        //PARA PASSWORD
        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text.Equals("CONTRASEÑA"))
            {
                txtpass.Text = String.Empty;
                txtpass.ForeColor = Color.LightGray;
                txtpass.UseSystemPasswordChar = true;
                //txtpass.PasswordChar = Convert.ToChar("*");
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtpass.Text))
            {
                txtpass.Text = "CONTRASEÑA";
                txtpass.ForeColor = Color.DimGray;
                txtpass.UseSystemPasswordChar = false;
            }
        }      

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
       
        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtuser.Text != "USUARIO")
            {               
                    if (txtpass.Text != "CONTRASEÑA")
                    {
                        using (nlo = new Nlogin())
                        {
                            lis_empresa = new List<object>();
                            bool validarLogin = nlo.Login(txtuser.Text.Trim(), txtroles.Text.Trim(), txtpass.Text.Trim());
                            if (validarLogin)
                            {
                                if (nlo.Business(lis_empresa))
                                {
                                    dgvlogin.DataSource = lis_empresa;
                                    Ocultarcolumna();
                                    BloquearAcceso(true);
                                    //if (activo)
                                    //{
                                        //FrmMain_principal mainmenu = new FrmMain_principal();
                                        //mainmenu.Show();
                                        //mainmenu.FormClosed += Logout;//revisar
                                        //this.Hide();
                                        //Messages.M_warning("Seleccione fila para acceder");
                                    //}
                                }else
                                {
                                    dgvlogin.DataSource = null;
                                    if (dgvlogin.Rows.Count <= 0)
                                        Messages.M_warning("No se le asigno empresas. \n Por favor consulte con el \n Administrador");                                    
                                }

                                msgError("");
                            }else
                            {
                                msgError("Datos incorrecto. \n Por favor Intente de Nuevo");
                                txtpass.Text = "CONTRASEÑA";
                                txtpass.UseSystemPasswordChar = false;
                                txtuser.Focus();
                            }

                        }

                    }
                    else
                        msgError("Por favor ingrese \n contraseña");
                
            }
            else
                msgError("Por favor seleccione \n un usuario");
        }


        private void msgError(string msg)
        {
            lblerror.Text = " " +msg;
            lblerror.Visible = true;
        }

        //cerrar sesion
        private void Logout(object sender, FormClosedEventArgs e)
        {
            //txtuser.Text = "USUARIO";
            //txtpass.Text = "CONTRASEÑA";
            //txtpass.UseSystemPasswordChar = false;
            activo = false;
            lblerror.Visible = false;
            this.Show();
            txtuser.Focus();
        }

        private void Ocultarcolumna()
        {            
            dgvlogin.Columns[1].Width = 241;//nombre empresa.
            dgvlogin.Columns[4].Width = 241;//nombre sucursal.
            dgvlogin.Columns[0].Visible = false;//ruc
            dgvlogin.Columns[2].Visible = false;//codigo empresa
            dgvlogin.Columns[3].Visible = false;//localidad empresa
            dgvlogin.Columns[5].Visible = false;//codigo sucursal
            dgvlogin.Columns[6].Visible = false;//localidad sucursal
        }

        private void frminicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            //this.Dispose(); no funciona cuando hay application.exit();
        }

        private void frminicio_MouseDown(object sender, MouseEventArgs e)
        {
            MoverVentana();
        }

        private void frminicio_Load(object sender, EventArgs e)
        {
            YearNow();
        }

        private void YearNow()
        {
            DateTime fechaActual = DateTime.Now;
            numeric_periodo.Value = fechaActual.Year;
        }

        private void dgvlogin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            activo = false;
            if (dgvlogin.Columns[e.ColumnIndex].Name == "EMPRESA")
            {
                UserCache.Ruc = dgvlogin.CurrentRow.Cells[0].Value.ToString();
                UserCache.Empresa = dgvlogin.CurrentRow.Cells[1].Value.ToString();
                UserCache.Codigo_empresa = Convert.ToInt32(dgvlogin.CurrentRow.Cells[2].Value);
                UserCache.Localidad_empresa = dgvlogin.CurrentRow.Cells[3].Value.ToString();
                UserCache.Periodo = numeric_periodo.Value.ToString();
                UserCache.Idperiodo = Getidperiodo();
                UserCache.Empresa_Sucursal = "EMPRESA";
                activo = true;
            }
            else if (dgvlogin.Columns[e.ColumnIndex].Name == "SUCURSAL")
            {
                try
                {
                    UserCache.Ruc = dgvlogin.CurrentRow.Cells[0].Value.ToString();
                    UserCache.Empresa = dgvlogin.CurrentRow.Cells[4].Value.ToString();
                    UserCache.Codigo_empresa = Convert.ToInt32(dgvlogin.CurrentRow.Cells[5].Value);
                    UserCache.Localidad_empresa = dgvlogin.CurrentRow.Cells[6].Value.ToString();
                    UserCache.Periodo = numeric_periodo.Value.ToString();
                    UserCache.Idperiodo = Getidperiodo();
                    UserCache.Empresa_Sucursal = "SUCURSAL";
                    activo = true;
                }
                catch (Exception)
                {
                    activo = false;
                    //Messages.M_error("Seleccione Una Empresa.");
                }
            }
        }

        //botones
        private void lblcerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void lblcerrar_MouseMove(object sender, MouseEventArgs e)
        {
            lblcerrar.BackColor = Color.Crimson;         
        }

        private void lblcerrar_MouseLeave(object sender, EventArgs e)
        {
            lblcerrar.BackColor = Color.FromArgb(33, 33, 33);           
        }

        private void lblcerrar_MouseDown(object sender, MouseEventArgs e)
        {
            lblcerrar.BackColor = Color.FromArgb(123, 36, 28);
        }

        //minimizar
        private void lblminimizar_MouseMove(object sender, MouseEventArgs e)
        {
            lblminimizar.BackColor = Color.FromArgb(51,51,51);          
        }

        private void lblminimizar_MouseLeave(object sender, EventArgs e)
        {
            lblminimizar.BackColor = Color.FromArgb(33, 33, 33);
        }

        private void lblminimizar_MouseDown(object sender, MouseEventArgs e)
        {
            lblminimizar.BackColor = Color.FromArgb(60,60,60);
        }
        private void lblminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //...
        private void txtuser_TextChanged(object sender, EventArgs e)
        {
            activo = false;
            BloquearAcceso(false);
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {
            activo = false;
            BloquearAcceso(false);
        }

        private void BloquearAcceso(bool val)
        {
            dgvlogin.Enabled = val;
        }

        //GET ID PERIODO
        private int Getidperiodo()
        {
            int v2;
            using (nlo = new Nlogin())
            {
                v2 = nlo.Get_idperiodo((int)numeric_periodo.Value);
            }
            return v2;
        }

        private void numeric_periodo_ValueChanged(object sender, EventArgs e)
        {
            UserCache.Idperiodo=Getidperiodo();
            UserCache.Periodo = numeric_periodo.Value.ToString();
        }

        private void Cbouser_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtuser.Text = Cbouser.Text.Trim();
            txtuser.ForeColor = Color.LightCyan;
            txtroles.Text = ""+Cbouser.SelectedValue;
            txtroles.ForeColor = Color.LightCyan;
        }        

        private void txtuser_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ESTAMOS BLOQUEANDO LA TECLA ENTER.
            Keypress.Text(e, txtuser);
        }

        private void panelinicio_MouseDown(object sender, MouseEventArgs e)
        {
            MoverVentana();
        }

        private void dgvlogin_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (activo)
            {
                FrmMain_principal mainmenu = new FrmMain_principal();
                mainmenu.Show();
                mainmenu.FormClosed += Logout;//revisar
                this.Hide();
            }
            else
                MessageBox.Show("errorrr");
        }
    }
}
