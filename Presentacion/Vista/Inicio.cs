﻿using System;
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
using Comun.Cache;

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
        //PROPIEDADES DE LISTVIEW
        private void Properties_listview()
        {
            /*lstlista.Columns.Clear();
            lstlista.Items.Clear();
            lstlista.View = View.Details;
            lstlista.GridLines = true;
            
            lstlista.FullRowSelect = false;
            lstlista.Scrollable = true;
            lstlista.HideSelection = false;*/

            //agregamos columnas

            /*lstlista.Columns.Add("SUCURSAL",200,HorizontalAlignment.Left);
            lstlista.Columns.Add("EMPRESA",200,HorizontalAlignment.Left);*/
        }
        
        private void btnlogin_Click(object sender, EventArgs e)
        {
            
            if (txtuser.Text != "USUARIO")
            {
                if (txtpass.Text != "CONTRASEÑA")
                {
                    using (nlo=new Nlogin())
                    {
                        lis_empresa = new List<object>();
                        bool validarLogin = nlo.Login(txtuser.Text.Trim(), txtpass.Text.Trim());
                        if (validarLogin)
                        {
                            if (nlo.Business(lis_empresa))
                            {
                                dgvlogin.DataSource = lis_empresa;
                                Ocultarcolumna();
                                if (activo)
                                {
                                    frmprincipal mainmenu = new frmprincipal();
                                    mainmenu.Show();
                                    mainmenu.FormClosed += Logout;//revisar
                                    this.Hide();
                                }
                            }                                                        
                            msgError("");
                        }
                        else
                        {
                            msgError("Incorrect username or password entered. \n Please try again. ");
                            txtpass.Text = "CONTRASEÑA";
                            txtpass.UseSystemPasswordChar = false;
                            txtuser.Focus();
                        }
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
            dgvlogin.Columns[0].Width = 200;
            dgvlogin.Columns[3].Width = 200;
            dgvlogin.Columns[1].Visible = false;
            dgvlogin.Columns[2].Visible = false;
            dgvlogin.Columns[4].Visible = false;
            dgvlogin.Columns[5].Visible = false;
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
        
        private void dgvlogin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            activo = false;
            if (dgvlogin.Columns[e.ColumnIndex].Name == "EMPRESA")
            {
                UserCache.Empresa = dgvlogin.CurrentRow.Cells[0].Value.ToString();
                UserCache.Codigo_empresa = Convert.ToInt32(dgvlogin.CurrentRow.Cells[1].Value);
                UserCache.Localidad_empresa = dgvlogin.CurrentRow.Cells[2].Value.ToString();
                UserCache.Periodo = numeric_periodo.Value.ToString();
                activo = true;
            }
            else if (dgvlogin.Columns[e.ColumnIndex].Name == "SUCURSAL")
            {
                try
                {
                    UserCache.Empresa = dgvlogin.CurrentRow.Cells[3].Value.ToString();
                    UserCache.Codigo_empresa = Convert.ToInt32(dgvlogin.CurrentRow.Cells[4].Value);
                    UserCache.Localidad_empresa = dgvlogin.CurrentRow.Cells[5].Value.ToString();
                    UserCache.Periodo = numeric_periodo.Value.ToString();
                    activo = true;
                }
                catch (Exception)
                {
                    activo = false;
                    Messages.M_error("Seleccione Una Empresa.");
                }
            }
        }

        private void numeric_periodo_ValueChanged(object sender, EventArgs e)
        {
            UserCache.Periodo = numeric_periodo.Value.ToString();
        }
    }
}
