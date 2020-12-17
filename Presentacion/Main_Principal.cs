using Presentacion.Vista;
using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Comun.Cache;
using Presentacion.Helps;

namespace Presentacion
{
    public partial class FrmMain_principal : Form
    {
        public FrmMain_principal()
        {
            InitializeComponent();
           

        }
        //para maximizar toda la pantalla
        public void fullScreen()
        {
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
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
            ToolTip.SetToolTip(btncerrar, "Cerrar sesión");
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


        private void btnmedia_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuMedia);
        }


        private void btnafp_Click(object sender, EventArgs e)
        {
            OpenForm<Frmafp>();
        }
        private void btnusuario_Click(object sender, EventArgs e)
        {
            OpenForm<frmusuario>();
        }


        private void btnactualizar_Click(object sender, EventArgs e)
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
            btnregistro.Text = "";
            btnactualizar.Text = "";
            btnmanteni.Text = "";
            btnreportes.Text = "";
            lineuser.Visible = false;
            lineperiodo.Visible = false;
            lblusuario.Visible = false;
        }

        private void ShowTextButton()
        {
            btnregistro.Text = "R&EGISTRO";
            btnactualizar.Text = "&ACTUALIZAR";
            btnmanteni.Text = "&MANTENIMIENTO";
            btnreportes.Text = "&REPORTES";
            lineuser.Visible = true;
            lineperiodo.Visible = true;
            lblusuario.Visible = true;
        }


        private void btnplanilla2_Click(object sender, EventArgs e)
        {
            OpenFormFill<FrmPlanillaEmpleados>();
        }

        private void btncalculo_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string fecha = DateTime.Now.ToLongDateString();
            string hora = DateTime.Now.ToLongTimeString();
            tlblhora.Text = fecha + "   |   " + hora;
        }

        private void btnemp_Click(object sender, EventArgs e)
        {
            OpenForm<frmempleado>();
        }

        private void btndoc_Click_1(object sender, EventArgs e)
        {
            OpenForm<frmdocumento>();
        }

        private void btnregsalud_Click(object sender, EventArgs e)
        {
            OpenForm<FrmRegimenSalud>();
        }

        private void btnregpens_Click(object sender, EventArgs e)
        {
            OpenForm<FrmManto_Regimen>();
        }

        private void btnsubsidios_Click(object sender, EventArgs e)
        {
            OpenForm<frmsubsidios>();
        }

        private void btnban_Click(object sender, EventArgs e)
        {
            OpenForm<Banco2>();
        }

        private void btntipocont_Click(object sender, EventArgs e)
        {
            OpenForm<TipoContrato2>();
        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            OpenFormFill<FrmPlanillaMensual2>();
        }

        private void btnempresa_Click_1(object sender, EventArgs e)
        {
            OpenForm<frmempresa>();
        }

        private void btnsucursal_Click_1(object sender, EventArgs e)
        {
            OpenForm<frmsucursal>();
        }

        private void btntipoplanilla_Click(object sender, EventArgs e)
        {
            OpenForm<TipoPlanilla>();
        }

        private void btncargo_Click(object sender, EventArgs e)
        {
            OpenForm<frmcargo>();
        }
    }
}
