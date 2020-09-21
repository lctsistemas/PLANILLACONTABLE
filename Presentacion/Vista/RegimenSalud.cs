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
    public partial class RegimenSalud : Form
    {
        String result;
        private NRegimenSalud nrs = new NRegimenSalud();
        private Int32 codigo;
        public RegimenSalud()
        {
            InitializeComponent();
        }

        private void GenerarCodigo()
        {
            codigo = 0;
            using (nrs)
            {
                codigo = nrs.GetCodigo();
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            result = "";
            using (nrs)
            {
                nrs.Id_regimen_salud = codigo;

                nrs.Cod_regi_salud = Convert.ToInt32(txtcodregsal.Text.ToString());
                nrs.Regimen_salud =txtregsal.Text.ToString();


                bool valida = new ValidacionDatos(nrs).Validate();
                if (valida)
                {

                    result = nrs.GuardarCambios();

                    Messages.M_info(result);
                }

                GenerarCodigo();

            }
        }

        private void Tabla()
        {
            dgvregimensalud.Columns[0].HeaderText = "Id_regimen_salud";
            dgvregimensalud.Columns[0].Width = 50;
            dgvregimensalud.Columns[0].Visible = false;

            dgvregimensalud.Columns[1].HeaderText = "Cod. regimen salud";
            dgvregimensalud.Columns[1].Width = 150;

            dgvregimensalud.Columns[2].HeaderText = "Regimen Salud";
            dgvregimensalud.Columns[2].Width = 300;

            dgvregimensalud.Columns[3].HeaderText = "state";
            dgvregimensalud.Columns[3].Width = 100;
            dgvregimensalud.Columns[3].Visible = false;



        }

        private void Showregimensalud()
        {
            using (nrs)
            {
                dgvregimensalud.DataSource = nrs.Getall();
            }
        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            GenerarCodigo();
        }

        private void RegimenSalud_Load(object sender, EventArgs e)
        {
            Showregimensalud();
            Tabla();
        }
    }
}
