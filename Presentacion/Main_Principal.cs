using Presentacion.Vista;
using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Comun.Cache;
using Presentacion.Helps;
using System.Drawing;

namespace Presentacion
{
    public partial class FrmMain_principal : Form
    {
        public FrmMain_principal()
        {
            InitializeComponent();
            Permisos();
            
        }

        //para maximizar toda la pantalla
        public void fullScreen()
        {
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        //PERMISOS DE ACCESO
        private void Permisos()
        {
            //MessageBox.Show("Bienvenido: " + UserCache.RolUser);
            if (UserCache.RolUser == Rol.Auxiliar)
            {               
                btntipoplanilla.Enabled = false;
                btntipocontrato.Enabled = false;
                btnregsalud.Enabled = false;
                btnrol.Enabled = false;
                btnmantenimiento.Enabled = false;//contiene sub menu botones
                //btnregimen_pensionario.Enabled = false;
                //btncomisionesafp.Enabled = false;
                btnempresa.Enabled = false;
                btnsucursal.Enabled = false;
                btnusurio.Enabled = false;
                btnbanco.Enabled = false;
            }else if (UserCache.RolUser==Rol.Contabilidad)
            {
                btnrol.Enabled = false;
            }
           
        }


        //CARGAR DATOS DE MEMORY CACHE.
        private void CargarDatos()
        {
            if (UserCache.Genero.Equals("F"))
                pictuser.Image = Properties.Resources.administradora;
            lblusuario.Text = UserCache.NombreUser;
            lblrol.Text = UserCache.RolUser;
            lblempresa.Text = UserCache.Empresa_Sucursal + ":  " + UserCache.Empresa + "  |  LOCALIDAD: "+ UserCache.Localidad_empresa;
            lblruc.Text = UserCache.Ruc;           
            lblperiodo.Text = "PERIODO:  " + UserCache.Periodo;
            lblid_periodo.Text = "id periodo: " + UserCache.Idperiodo.ToString();
            lblidempresa.Text = "id empresa: " + UserCache.Codigo_empresa.ToString();
        }
        private void Main_Principal_Load(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(pictmenu, "Menu");
            //ToolTip.SetToolTip(btncerrar, "Cerrar sesión");
            timer1.Start();            
            hideSubmenu();
            fullScreen();
            CargarDatos();
            //tlblhora.Text = DateTime.Now.ToString("HH : mm : ss");
        }

        private void hideSubmenu()
        {
            panelSubMenuMedia.Visible = false;
            panelactualizar.Visible = false;
            panelregistro.Visible = false;
        }

        private void showSubMenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }


        private void btnconfiguracion_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuMedia);
        }       

        private void btnmantenimiento_Click(object sender, EventArgs e)
        {
            showSubMenu(panelactualizar);
        }

        private void btnregistro_Click(object sender, EventArgs e)
        {
            showSubMenu(panelregistro);
        }
       
        //METODO PARA ABRIR FORMULARIO DENTRO DE PANEL
        private void OpenForm<Myform>() where Myform : Form, new()
        {
            Form formulario;
            formulario = panelchildform.Controls.OfType<Myform>().FirstOrDefault();
            if (formulario == null)
            {
                formulario = new Myform();
                formulario.TopLevel = false;
                //formulario.FormBorderStyle = FormBorderStyle.None;
                //formulario.Dock = DockStyle.Fill;
                panelchildform.Controls.Add(formulario);
                panelchildform.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                //formulario.Close();
                formulario.BringToFront();
            }
        }

        //METODO PARA ABRIR FORMULARIO DENTRO DE PANEL PERO TODO EL ANCHO FILL
        private void OpenFormFill<Myform>() where Myform : Form, new()
        {
            Form formulario;
            formulario = panelchildform.Controls.OfType<Myform>().FirstOrDefault();
            if (formulario == null)
            {
                formulario = new Myform();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelchildform.Controls.Add(formulario);
                panelchildform.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                //formulario.Close();
                formulario.BringToFront();
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void pictmenu_Click(object sender, EventArgs e)
        {

            if (PanelSideMenu.Width == 250)
            {
                PanelSideMenu.Width = 50;
                HideTextButton();
                hideSubmenu();

            }
            else
            {
                PanelSideMenu.Width = 250;
                ShowTextButton();
            }
        }
        private void HideTextButton()
        {
            btnconfiguracion.Text = "";
            btnmantenimiento.Text = "";
            btnregistro.Text = "";
            btnreportes.Text = "";
            lineuser.Visible = false;
            lineperiodo.Visible = false;
            lblusuario.Visible = false;
        }

        private void ShowTextButton()
        {
            btnconfiguracion.Text = "&CONFIGURACION";
            btnmantenimiento.Text = "&MANTENIMIENTO";
            btnregistro.Text = "&REGISTRO";
            btnreportes.Text = "R&EPORTES";
            lineuser.Visible = true;
            lineperiodo.Visible = true;
            lblusuario.Visible = true;
        }


        

     
        private void timer1_Tick(object sender, EventArgs e)
        {
            string fecha = DateTime.Now.ToLongDateString();
            string hora = DateTime.Now.ToLongTimeString();
            tlblhora.Text = fecha + "   |   " + hora;
        }

        //BOTONES PARA ABRIL FORMULARIOS
        private void btnregimen_pensionario_Click(object sender, EventArgs e)
        {
            OpenForm<FrmManto_Regimen>();
        }
        private void btnempresa_Click(object sender, EventArgs e)
        {
            OpenForm<frmempresa>();
        }
        private void btntipocontrato_Click(object sender, EventArgs e)
        {
            OpenForm<FrmTipoContrato>();
        }

        private void btntipoplanilla_Click(object sender, EventArgs e)
        {
            OpenForm<FrmTipoPlanilla>();
        }     

        private void btnregsalud_Click(object sender, EventArgs e)
        {
            OpenForm<FrmRegimenSalud>();
        }

        private void btnsubsidiados_Click(object sender, EventArgs e)
        {
            OpenForm<frmsubsidios>();
        }

        private void btncargo_Click(object sender, EventArgs e)
        {
            OpenForm<frmcargo>();
        }

        private void btntipodocumento_Click(object sender, EventArgs e)
        {
            OpenForm<frmdocumento>();
        }

        private void btnrol_Click(object sender, EventArgs e)
        {
            OpenForm<frmrol>();
        }
        private void btnbanco_Click(object sender, EventArgs e)
        {
            OpenForm<FrmBanco2>();
        }

        private void btnsucursal_Click(object sender, EventArgs e)
        {
            OpenForm<frmsucursal>();
        }

        private void btnusurio_Click(object sender, EventArgs e)
        {
            OpenForm<frmusuario>();
        }

        private void btnplanilla_Click(object sender, EventArgs e)
        {
            OpenFormFill<FrmPlanillaEmpleados>();
        }

        private void btncomisionesafp_Click(object sender, EventArgs e)
        {
            OpenForm<Frmafp>();
        }

        private void btnempleado_Click(object sender, EventArgs e)
        {
            OpenForm<frmempleado>();
        }

        //BOTONES COLORES
        private void btncerrar_MouseLeave(object sender, EventArgs e)
        {
            btncerrar.BackColor = Color.FromArgb(27, 79, 144);
        }

        private void btncerrar_MouseDown(object sender, MouseEventArgs e)
        {
            btncerrar.BackColor = Color.FromArgb(123,36,28);
        }

        private void btncerrar_MouseMove(object sender, MouseEventArgs e)
        {
            btncerrar.BackColor = Color.Crimson;
        }

        //MINIMIZAR
        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnminimizar_MouseDown(object sender, MouseEventArgs e)
        {
            btnminimizar.BackColor = Color.FromArgb(31,92,167);
        }

        private void btnminimizar_MouseLeave(object sender, EventArgs e)
        {
            btnminimizar.BackColor = Color.FromArgb(27, 79, 144);
        }

        private void btnminimizar_MouseMove(object sender, MouseEventArgs e)
        {
            btnminimizar.BackColor = Color.FromArgb(23,69,125);
        }     

        //...
    }
}
