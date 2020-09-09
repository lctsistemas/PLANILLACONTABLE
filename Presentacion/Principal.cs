using Comun.Cache;
using Presentacion.Vista;
using System;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmprincipal : Form
    {
        public frmprincipal()
        {
            InitializeComponent();
            ocultarpanel();
        }

        private void ocultarpanel()
        {
            panelsubmenu.Visible = false;
            panelmedia2.Visible = false;
            panelmedia3.Visible = false;
        }

        private void hidemenu()
        {
            if (panelsubmenu.Visible == true)
                panelsubmenu.Visible = false;
            if (panelmedia2.Visible == true)
                panelmedia2.Visible = false;
            if (panelmedia3.Visible == true)
                panelmedia3.Visible = false;
        }

        private void showmenu(Panel submenu)
        {

            if (submenu.Visible == false)
            {
                hidemenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }

        private void btnmedia_Click(object sender, EventArgs e)
        {
            showmenu(panelsubmenu);
        }

        private void btnmedia2_Click(object sender, EventArgs e)
        {
            showmenu(panelmedia2);
        }

        private void btnmedia3_Click(object sender, EventArgs e)
        {
            showmenu(panelmedia3);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            /*other codigo*/
            /**/
        }

        private void button8_Click(object sender, EventArgs e)
        {
            /*other codigo*/
            hidemenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            /*other codigo*/
            hidemenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            /*other codigo*/
            hidemenu();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            /*other codigo*/
            hidemenu();
        }

        private void btnmedia4_Click(object sender, EventArgs e)
        {
            /*other codigo*/
            hidemenu();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarDatos();
            this.Text = UserCache.NombreUser +"  |   "+lblempresa.Text;
        }

        private void CargarDatos()
        {
            lblusuario.Text = UserCache.NombreUser;
            lblrol.Text = UserCache.RolUser;
            lblempresa.Text =UserCache.Empresa_Sucursal+":  "+ UserCache.Empresa;
            lbllocalidad.Text = UserCache.Localidad_empresa;
            lblperiodo.Text = UserCache.Periodo;
            lblid_periodo.Text = UserCache.Idperiodo.ToString();
            lblidempresa.Text = UserCache.Codigo_empresa.ToString();
        }

        //ABRIR FORMULARIO
        private Form activefor = null;
        private void openchilform(Form childform)
        {
            if (activefor != null)
            {
                activefor.Close();
            }
            activefor = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panelcontent.Controls.Add(childform);
            panelcontent.Tag = childform;//esta sobre el control
            childform.BringToFront();//indica que el formulario llamado esta frente al logo que exite
            childform.Show();
        }

        private void openchilform2(Form childform)
        {
            if (activefor != null)
            {
                activefor.Close();
            }
            activefor = childform;
            childform.TopLevel = false;
            //childform.FormBorderStyle = FormBorderStyle.None;
            //childform.Dock = DockStyle.Fill;
            panelcontent.Controls.Add(childform);
            panelcontent.Tag = childform;//esta sobre el control
            //childform.BringToFront();//indica que el formulario llamado esta frente al logo que exite
            childform.Show();
        }

        private void btnsucursal_Click(object sender, EventArgs e)
        {
            openchilform(new frmsucursal());
        }

        private void btnempresa_Click(object sender, EventArgs e)
        {
            openchilform(new frmempresa());
        }

        private void btndocumento_Click(object sender, EventArgs e)
        {
            openchilform(new frmdocumento());
        }

        private void btncargo_Click(object sender, EventArgs e)
        {
            openchilform(new frmcargo());
        }

        private void btnusuario_Click(object sender, EventArgs e)
        {
            openchilform(new frmusuario());
        }

        private void btnempleado_Click(object sender, EventArgs e)
        {
            openchilform2(new frmempleado());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openchilform(new Planilla_Manto());

        }
    }
}
