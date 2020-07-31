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
        ListViewGroup empresa = new ListViewGroup("EMPRESA", HorizontalAlignment.Center);
        ListViewGroup sucursal = new ListViewGroup("SUCURSAL", HorizontalAlignment.Center);
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
            lstlista.Columns.Clear();
            lstlista.Items.Clear();
            lstlista.View = View.Details;
            lstlista.GridLines = true;
            
            lstlista.FullRowSelect = false;
            lstlista.Scrollable = true;
            lstlista.HideSelection = false;

            //agregamos columnas
            lstlista.Columns.Add("SUCURSAL",200,HorizontalAlignment.Left);
            lstlista.Columns.Add("EMPRESA",200,HorizontalAlignment.Left);
        }
        
        private void btnlogin_Click(object sender, EventArgs e)
        {
            lstlista.Items.Clear();
            if (txtuser.Text != "USUARIO")
            {
                if (txtpass.Text != "CONTRASEÑA")
                {
                    Nlogin nl = new Nlogin();
                    DataTable dt =new DataTable();
                    var validarLogin = nl.Login(txtuser.Text.Trim(), txtpass.Text.Trim(), dt);
                    if (validarLogin)
                    {
                        //dgvempresa.DataSource = dt;
                        //Ocultarcolumna();
                        //LLENA LA EMPRESA
                        //frmprincipal mainmenu = new frmprincipal();
                        //mainmenu.Show();
                        //mainmenu.FormClosed += Logout;//revisar
                        //this.Hide();

                        //llenar listview
                        foreach (DataRow item in dt.Rows)
                        {
                            lstlista.Items.Add(new ListViewItem(item["EMPRESA"].ToString(), empresa));
                            lstlista.Items.Add(new ListViewItem(item["SUCURSAL"].ToString(), sucursal));
                            

                            //agregamos esos grupos.
                            
                            //lstlista.Groups.Add(carnes);

                            //ListViewItem fila;
                            //fila = lstlista.Items.Add(item["SUCURSAL"].ToString()); //sucursal razon social
                            //fila.SubItems.Add(item["codigo_sucursal"].ToString()); //sucursal razon social
                            // fila.SubItems.Add(item["LOCALIDAD_SUCURSAL"].ToString()); //sucursal razon social
                            //fila.SubItems.Add(item["EMPRESA"].ToString()); //sucursal razon social
                            // fila.SubItems.Add(item["codigo_empresa"].ToString()); //sucursal razon social
                            //fila.SubItems.Add(item["LOCALIDAD_EMPRESA"].ToString()); //sucursal razon social
                        }

                    }
                    else
                    {
                        msgError("Incorrect username or password entered. \n Please try again. ");
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
            //Properties_listview();            
            lstlista.Groups.Add(empresa);
            lstlista.Groups.Add(sucursal);
        }
    }
}
