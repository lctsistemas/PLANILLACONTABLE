using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio.Models;
using Negocio.ValueObjects;
using Presentacion.Helps;

namespace Presentacion.Vista
{
    public partial class Manto_Regimen : Form
    {
        String result;
        private NRegimen nr=new NRegimen();
        public Manto_Regimen()
        {
            InitializeComponent();
        }

        private void Manto_Regimen_Load(object sender, EventArgs e)
        {
            //Tabla();
            cbxregimen.Items.Add("S.N.P");
            cbxregimen.Items.Add("S.P.P");
            ShowRegimen();
        }


        private void btnagregar_Click(object sender, EventArgs e)
        {
            using (nr) { nr.state = EntityState.Guardar; }
            
            Habilitar(true);
            limpiar();
            
        }

        private void limpiar()
        {
            txtdescripcion.Text = String.Empty;
            txtdescCorta.Text = String.Empty;
            cbxregimen.Text = "";
            cbxregimen.SelectedValue = 0;
        }

        private void Habilitar(bool v)
        {
            btnguardar.Enabled = v;
            txtdescripcion.Enabled = v;
            txtdescCorta.Enabled = v;
            cbxregimen.Enabled = v;
            txtdescripcion.Focus();
        }

        private void Tabla()
        {
            dgvregimen.Columns[0].HeaderText = "codigo";
            dgvregimen.Columns[0].Width = 100;

            dgvregimen.Columns[1].HeaderText = "DESCRIPCION";
            dgvregimen.Columns[1].Width = 150;

            dgvregimen.Columns[2].HeaderText = "DESCRIPCION CORTA";
            dgvregimen.Columns[2].Width = 100;

            dgvregimen.Columns[3].HeaderText = "TIPO REGIMEN";
            dgvregimen.Columns[3].Width = 100;

           

        }

        private void ShowRegimen()
        {
            using (nr)
            {
                dgvregimen.DataSource = nr.Getall();
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            result = "";
            using (nr)
            {
                if (nr.state == EntityState.Guardar)
                {
                    nr.Descripcion_corta = txtdescCorta.Text.Trim().ToUpper();
                    nr.Descripcion = txtdescripcion.Text.Trim().ToUpper();
                    nr.Tipo_regimen = cbxregimen.Text.Trim();

                    bool valida = new ValidacionDatos(nr).Validate();
                    if (valida)
                    {
                        if (String.IsNullOrEmpty(cbxregimen.SelectedItem.ToString().Trim()))
                            return;
                        result = nr.GuardarCambios();
                        ShowRegimen();
                        Messages.M_info(result);
                        if (nr.state == EntityState.Guardar)
                        {
                            limpiar();
                        }
                    }
                }
            }
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            dgvregimen.DataSource = nr.Search(txtbuscar.Text.Trim());
        }

        private void dgvregimen_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = dgvregimen.CurrentRow;

            if (dgvregimen.Rows.GetFirstRow(DataGridViewElementStates.Selected) != -1)
            {
                using (nr)
                {
                    nr.state = EntityState.Modificar;
                    nr.Codigo_Regimen = Convert.ToInt32(r.Cells[0].Value);
                    txtdescripcion.Text = Convert.ToString(r.Cells[1].Value);
                    txtdescCorta.Text = Convert.ToString(r.Cells[2].Value);
                    cbxregimen.Text = r.Cells[3].Value.ToString();
                    ValidateError.validate.Clear();//LIMPIA LOS ERRORPROVIDER
                }
            }
        }
    }
}
