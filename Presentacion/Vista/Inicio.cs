using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Negocio;
using Negocio.Models;
using System.Collections;
using Presentacion;
using Presentacion.Helps;

namespace Login_inicio
{
    public partial class frminicio : Form
    {
        public frminicio()
        {
            InitializeComponent();
        }                   

        private void Ocultarcolumna()
        {
            dgvempresa.Columns[1].Visible = false;
            dgvempresa.Columns[3].Visible = false;
        }
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

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text.Equals("CONTRASEÑA"))
            {
                txtpass.Text = String.Empty;
                txtpass.ForeColor = Color.LightGray;
                txtpass.UseSystemPasswordChar = true;
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

        private void lblcerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
                    Nlogin nl = new Nlogin();
                    ArrayList dt =new ArrayList();
                    var validarLogin = nl.Login(txtuser.Text.Trim(), txtpass.Text.Trim(), dt);
                    if (validarLogin)
                    {
                        dgvempresa.DataSource = (object) dt;
                        Ocultarcolumna();
                        //LLENA LA EMPRESA
                        //frmprincipal mainmenu = new frmprincipal();
                        //mainmenu.Show();
                        //mainmenu.FormClosed += Logout;//revisar
                        //this.Hide();

                    }
                    else
                    {
                        msgError("Incorrect username or password entered. \n Please trye again. ");
                        txtpass.Text = "CONTRASEÑA";
                        txtpass.UseSystemPasswordChar = false;
                        txtuser.Focus();
                    }
                }
                else
                    msgError("please enter password");
            }
            else
                msgError("please enter username");
        }


        private void msgError(string msg)
        {
            lblerror.Text = "  " + msg;
            lblerror.Visible = true;
        }

        //cerrar sesion
        private void Logout(object sender, FormClosedEventArgs e)
        {
            txtuser.Text = "USUARIO";
            txtpass.Text = "CONTRASEÑA";
            txtpass.UseSystemPasswordChar = false;
            lblerror.Visible = false;
            this.Show();
            txtuser.Focus();
        }

        private void frminicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            //this.Dispose(); no funciona cuando hay application.exit();
        }

        private void frminicio_MouseDown(object sender, MouseEventArgs e)
        {
            WindowsMove.ReleaseCapture();
            WindowsMove.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void frminicio_Load(object sender, EventArgs e)
        {
            //Ocultarcolumna();
        }
    }
}
