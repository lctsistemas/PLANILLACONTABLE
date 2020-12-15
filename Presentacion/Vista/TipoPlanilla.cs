using Negocio.Models;
using Negocio.ValueObjects;
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
    public partial class TipoPlanilla : Form
    {
        String result;
        private NTipoPlanilla ntp = new NTipoPlanilla();
        public TipoPlanilla()
        {
            InitializeComponent();
        }

        private bool Validar()
        {
            if (String.IsNullOrWhiteSpace(txtTipoPlanilla.Text))
            {
                ValidateChildren();
                return true;
            }
            else
                return false;
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                ValidateChildren();
                return;
            }
            result = "";
            using (ntp)
            {
                //ntp.IdTipoPlanilla = Convert.ToInt32(txtTipoPlanilla.Text.ToString());
                ntp.Tipo_Planilla = txtTipoPlanilla.Text.ToString();

                result = ntp.GuardarCambios();
                Messages.M_info(result);

                Showregimensalud();
            }
        }

        private void Showregimensalud()
        {
            using (ntp)
            {
                dgvtipoplanilla.DataSource = ntp.Getall();
            }
        }

        private void txtTipoPlanilla_Validating(object sender, CancelEventArgs e)
        {
            ValidateError.Validate_text(txtTipoPlanilla, "Campo Requerido");
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            result = "";
            if (dgvtipoplanilla.Rows.GetFirstRow(DataGridViewElementStates.Selected) != -1)
            {
                DialogResult r = Messages.M_question("¿Desea eliminar la fila?");
                if (r == DialogResult.Yes)
                {
                    using (ntp)
                    {
                        ntp.state = EntityState.Remover;
                        ntp.IdTipoPlanilla = Convert.ToInt32(dgvtipoplanilla.CurrentRow.Cells[0].Value);
                        result = ntp.GuardarCambios();
                        Showregimensalud();
                        Messages.M_info(result);
                    }
                }

            }
            else
            {
                Messages.M_warning("Seleccione una fila de la tabla");
            }
            limpiar();
        }

        private void limpiar()
        {
            txtTipoPlanilla.Text = String.Empty;

            using (ntp) { ntp.state = EntityState.Guardar; }
        }

        private void TipoPlanilla_Load(object sender, EventArgs e)
        {
            Showregimensalud();
        }

        private void Tabla()
        {
            dgvtipoplanilla.Columns[0].HeaderText = "Id_Tipo_Planilla";
            dgvtipoplanilla.Columns[0].Width = 50;
            dgvtipoplanilla.Columns[0].Visible = false;

            dgvtipoplanilla.Columns[1].HeaderText = "COD. REGIMEN SALUD";
            dgvtipoplanilla.Columns[1].Width = 120;

            dgvtipoplanilla.Columns[2].HeaderText = "state";
            dgvtipoplanilla.Columns[2].Width = 250;
            dgvtipoplanilla.Columns[2].Visible = false;

        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
