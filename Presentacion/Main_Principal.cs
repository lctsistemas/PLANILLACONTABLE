using Presentacion.Vista;
using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Comun.Cache;
using Presentacion.Helps;

namespace Presentacion
{
    public partial class Main_Principal : Form
    {
        public Main_Principal()
        {
            InitializeComponent();
            Tooltip.Title(btncerrar, "Cerrar sesión", false);
            Tooltip.Title(pictmenu, "Menu", false);

        }
        //para maximizar toda la pantalla
        public void fullScreen()
        {
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        //CARGAR DATOS AL MEMORY CACHE.
        private void CargarDatos()
        {
            lblusuario.Text = UserCache.NombreUser;
            lblrol.Text = UserCache.RolUser;
            lblempresa.Text = UserCache.Empresa_Sucursal + ":  " + UserCache.Empresa;
            lbllocalidad.Text ="LOCALIDAD:  " + UserCache.Localidad_empresa;
            lblperiodo.Text = "PERIODO:  " + UserCache.Periodo;
            lblid_periodo.Text = "id periodo: " + UserCache.Idperiodo.ToString();
            lblidempresa.Text = "id empresa: " + UserCache.Codigo_empresa.ToString();
        }
        private void Main_Principal_Load(object sender, EventArgs e)
        {
            hideSubmenu();
            fullScreen();
            CargarDatos();
            lblhora.Text = DateTime.Now.ToString("HH : mm : ss");
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

        private void btndoc_Click(object sender, EventArgs e)
        {
            OpenForm<frmdocumento>();
        }

        private void btnempresa_Click(object sender, EventArgs e)
        {
            OpenForm<frmempresa>();
        }

        private void btncargo_Click(object sender, EventArgs e)
        {
            OpenForm<frmcargo>();
        }

        private void btnsucursal_Click(object sender, EventArgs e)
        {
            OpenForm<frmsucursal>();
            
        }

        private void btnafp_Click(object sender, EventArgs e)
        {
            OpenForm<Frmafp>();
        }
        private void btnusuario_Click(object sender, EventArgs e)
        {
            OpenForm<frmusuario>();
        }

        private void btnempleado_Click(object sender, EventArgs e)
        {
            OpenForm<frmempleado>();
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

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
          
        }
                           
        private void btnbanco_Click(object sender, EventArgs e)
        {
            OpenForm<Banco>();
        }

        private void btntipo_contrato_Click(object sender, EventArgs e)
        {
            OpenForm<TipoContrato>();
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
            btnmedia.Text = "";
            btnactualizar.Text = "";
            btnregistro.Text = "";
            btnreportes.Text = "";
            lineuser.Visible = false;
            lineperiodo.Visible = false;
            lblusuario.Visible = false;
        }

        private void ShowTextButton()
        {
            btnmedia.Text = "&Mantenimiento";
            btnactualizar.Text = "&Actualizar";
            btnregistro.Text = "R&egistro";
            btnreportes.Text = "&Repostes";
            lineuser.Visible = true;
            lineperiodo.Visible = true;
            lblusuario.Visible = true;
        }


        private void btnplanilla2_Click(object sender, EventArgs e)
        {
            OpenForm<FrmPlanillaEmpleados>();
        }

        private void btncalculo_Click(object sender, EventArgs e)
        {
            OpenFormFill<FrmPlanillaMensual2>();
        }
    }
}
