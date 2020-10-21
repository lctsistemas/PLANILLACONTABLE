using Negocio.Models;
using Negocio.ValueObjects;
using Presentacion.Helps;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Presentacion.Vista
{
    public partial class TipoContrato : Form
    {
        private String result;
        Ntipocontrato nTipocont = new Ntipocontrato();
        //private Int32 codigo;
        //private Int32 codtipcont;
        public TipoContrato()
        {
            InitializeComponent();
            ShowTipoContrato();
            Tabla();
        }

        private bool Validar_campo()
        {
            if (string.IsNullOrEmpty(txttipo.Text))
            {
                ValidateChildren();
                return true;
            }
            else
            {
                return false;
            }
        }

        private void ShowTipoContrato()
        {
            using (nTipocont)
            {
                dgvtipocontrato.DataSource = nTipocont.MostrarTcontrato();

            }
        }

        private void limpiar()
        {
            txttipo.Text = String.Empty;
            using (nTipocont) { nTipocont.state = EntityState.Guardar; }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {

            result = "";

            using (nTipocont)
            {
                //nTipocont.id_tcontrato = nTipocont.Getcodigo();

                nTipocont.tiem_contrato = txttipo.Text.Trim().ToUpper();

                bool validar = new ValidacionDatos(nTipocont).Validate();
                if (validar)
                {
                    result = nTipocont.GuardarCambios();

                    Messages.M_info(result);

                }

                ShowTipoContrato();

                limpiar();

            }
        }


        private void Tabla()
        {
            dgvtipocontrato.Columns[0].HeaderText = "CODIGO";
            dgvtipocontrato.Columns[0].Width = 50;

            dgvtipocontrato.Columns[1].HeaderText = "TIPO CONTRATO";
            dgvtipocontrato.Columns[1].Width = 150;

            dgvtipocontrato.Columns[2].HeaderText = "TIPO CONTRATO";
            dgvtipocontrato.Columns[2].Width = 150;
            dgvtipocontrato.Columns[2].Visible = false;

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            using (nTipocont) { nTipocont.state = EntityState.Guardar; }
            Habilitar(true);
            limpiar();
        }

        private void TipoContrato_Load(object sender, EventArgs e)
        {
            Habilitar(false);
        }

        private void Habilitar(bool v)
        {
            btnguardar.Enabled = v;
            txttipo.Enabled = v;
           
        }

        private void dgvtipocontrato_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = dgvtipocontrato.CurrentRow;
            Habilitar(true);
            if (dgvtipocontrato.Rows.GetFirstRow(DataGridViewElementStates.Selected) != -1)
            {
                using (nTipocont)
                {
                    nTipocont.state = EntityState.Modificar;
                    nTipocont.id_tcontrato = Convert.ToInt32(r.Cells[0].Value);
                    txttipo.Text = r.Cells[1].Value.ToString();

                    tabtipo.SelectedIndex = 0;
                    ValidateError.validate.Clear();
                }

            }
        }

        private void txttipo_Validating(object sender, CancelEventArgs e)
        {
            ValidateError.Validate_text(txttipo, "Campo requerido");
        }
    }
}
