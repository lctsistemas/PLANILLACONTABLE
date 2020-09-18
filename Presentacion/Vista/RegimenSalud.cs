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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            GenerarCodigo();
        }
    }
}
