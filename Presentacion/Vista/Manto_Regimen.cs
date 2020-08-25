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
            cbxregimen.Items.Add("S.N.P");
            cbxregimen.Items.Add("S.P.P");
            ShowRegimen();
        }


        private void btnagregar_Click(object sender, EventArgs e)
        {
            using (nr) { nr.state = EntityState.Guardar; }
            Habilitar(true);
            limpiar();
            Tabla();
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

        }

        private void Tabla()
        {
            dgvregimen.Columns[0].HeaderText = "CODIGO";
            dgvregimen.Columns[0].Width = 50;
            dgvregimen.Columns[0].Visible = false;

            dgvregimen.Columns[1].HeaderText = "ACCESO USUARIO";
            dgvregimen.Columns[1].Width = 150;

            dgvregimen.Columns[2].HeaderText = "NOMBRE USUARIO";
            dgvregimen.Columns[2].Width = 250;

            
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
                        Messages.M_info(result);
                        if (nr.state == EntityState.Guardar)
                        {
                            limpiar();
                        }
                    }
                }
            }
        }
    }
}
