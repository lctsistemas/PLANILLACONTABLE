using Negocio.Models;
using Presentacion.Helps;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Vista
{
    public partial class Privilegios : Form
    {
        private NPrivilegios np = new NPrivilegios();
        String result = "";
        public Privilegios()
        {
            InitializeComponent();
            Mostrar_Rol();
            //ShowPrivilegios();
            
        }

        //MOSTRAR ROL EN COMBOBOX
        private void Mostrar_Rol()
        {
            using (Nrol nr = new Nrol())
            {
                cbxrol.DataSource = nr.Getall();
                cbxrol.DisplayMember = "nombre_rol";
                cbxrol.ValueMember = "idrol";
                cbxrol.Text = null;
                
            }
        }
        //MOSTRAR LOS PRIVILEGIOS
        private void ShowPrivilegios()
        {
            List<NPrivilegios> lisprive;

            using (np)
            {
                np.Id_rol = Convert.ToInt32(cbxrol.SelectedValue);
                lisprive = np.Getall();
                if (lisprive.Count <= 0)
                {
                    lisprive.Clear();
                }
                else
                {

                    this.txtid_privilegios.Text = lisprive[0].Id_privilegios.ToString();
                    this.checktpla.Checked = lisprive[0].Btipopla;
                    this.checktipocont.Checked = lisprive[0].Btipocont;
                    this.checkregsalud.Checked = lisprive[0].Bregimensalud;
                    this.checksubnosub.Checked = lisprive[0].Bsubsinosub;
                    this.checkcargo.Checked = lisprive[0].Bcargo;
                    this.checktipodoc.Checked = lisprive[0].Btipodoc;
                    this.checkbanco.Checked = lisprive[0].Bbanco;
                    this.checkroles.Checked=lisprive[0].Broles;
                    this.checkregpens.Checked = lisprive[0].Bregimenpen;
                    this.checkcomis.Checked = lisprive[0].Bcomisiones;
                    this.checkempl.Checked = lisprive[0].Bempleado;
                    this.checkempresa.Checked = lisprive[0].Bempresa;
                    this.checksucursal.Checked = lisprive[0].Bsucursal;
                    this.checkusuario.Checked = lisprive[0].Busuario;
                    this.checkplan.Checked = lisprive[0].Bplanilla;
                }

            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            
            result = "";
            using (np)
            {
                if (txtid_privilegios.Text.Trim() != string.Empty)
                    np.Id_privilegios= Convert.ToInt32(txtid_privilegios.Text.Trim());

                np.Id_rol = Convert.ToInt32(cbxrol.SelectedValue);
                np.Btipopla = Convert.ToBoolean(checktpla.Checked);
                np.Btipocont = Convert.ToBoolean(checktipocont.Checked);
                np.Bregimensalud = Convert.ToBoolean(checkregsalud.Checked);
                np.Bsubsinosub = Convert.ToBoolean(checksubnosub.Checked);
                np.Bcargo = Convert.ToBoolean(checkcargo.Checked);
                np.Btipodoc = Convert.ToBoolean(checktipodoc.Checked);
                np.Bbanco = Convert.ToBoolean(checkbanco.Checked);
                np.Bregimenpen = Convert.ToBoolean(checkregpens.Checked);
                np.Bcomisiones = Convert.ToBoolean(checkcomis.Checked);
                np.Bempleado = Convert.ToBoolean(checkempl.Checked);
                np.Bempresa = Convert.ToBoolean(checkempresa.Checked);
                np.Bsucursal = Convert.ToBoolean(checksucursal.Checked);
                np.Busuario = Convert.ToBoolean(checkusuario.Checked);
                np.Bplanilla = Convert.ToBoolean(checkplan.Checked);



                result = np.SaveChanges();
               
                Messages.M_info(result);
               

            }
        }



        private void cbxrol_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbxrol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxrol.SelectedIndex == 0)
                btnguardar.Enabled = false;
            else
                btnguardar.Enabled = true;

            if (cbxrol.SelectedIndex > 0)
                ShowPrivilegios();

            
        }

        private void Privilegios_Load(object sender, EventArgs e)
        {
           cbxrol.SelectedIndex = cbxrol.Items.IndexOf(0);

        }



        private void btncerrar_MouseDown(object sender, MouseEventArgs e)
        {
            btncerrar.BackColor = Color.FromArgb(241, 112, 122);
        }

        private void btncerrar_MouseLeave(object sender, EventArgs e)
        {
            btncerrar.BackColor = Color.FromArgb(116, 118, 118);
        }

        private void btncerrar_MouseMove(object sender, MouseEventArgs e)
        {
            btncerrar.BackColor = Color.Crimson;
        }

        
    }
}
