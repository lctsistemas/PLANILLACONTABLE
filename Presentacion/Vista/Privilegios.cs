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
        public Privilegios()
        {
            InitializeComponent();
            Mostrar_Rol();
        }

        private NPrivilegios np = new NPrivilegios();

        String result = "";

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


        private void ShowSubsidio()
        {
            using (np)
            {
                //dgv.DataSource = np.get();
                //lbltotal.Text = "Total registro:  " + dgvsubsidio.RowCount;
            }
        }


        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                ValidateChildren();
                return;
            }

            result = "";
            using (np)
            {
                np.Id_rol = cbxrol.SelectedIndex;
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
                if (result.Contains("Codigo ya existe"))
                    Messages.M_warning(result);
                else
                {

                    //ShowSubsidio();

                    ShowSubsidio();
                    //limpiar();

                    Messages.M_info(result);
                }

            }
        }

        private void Mostrar_Rol()
        {
            using (Nrol nr = new Nrol())
            {
                cbxrol.DataSource = nr.Getall();
                cbxrol.DisplayMember = "nombre_rol";
                cbxrol.ValueMember = "idrol";
            }
        }

        private bool ValidarDatos()
        {
            if (cbxrol.Text == String.Empty)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        private void cbxrol_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbxrol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxrol.SelectedIndex == 0)
            {
                //ns.state = EntityState.Modificar;
                using (np)
                {
                    cbxrol.DataSource = np.Getall();
                }
            }

        }


    }
}
