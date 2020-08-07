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
using System.Windows.Forms;

namespace Presentacion.Vista
{
    public partial class TipoContrato : Form
    {
        private String result;
        Ntipocontrato nTipocont = new Ntipocontrato();
        private Int32 codigo;
        private Int32 codtipcont;
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

        private void GenerarCodigo()
        {
            codigo = 0;
            using (nTipocont)
            {
                codigo = nTipocont.Getcodigo();
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
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {

            if (Validar_campo())
            {
                Messages.M_warning("Ingrese un tipo de contrato  por favor");
                return;
            }
            result = "";

            using (nTipocont)
            {
                if (nTipocont.state == EntityState.Guardar)
                {
                    nTipocont.id_tcontrato = codtipcont;
                    nTipocont.tiem_contrato = txttipo.Text.Trim().ToUpper();
                    ShowTipoContrato();
                    result = nTipocont.GuardarCambios();
                    Messages.M_info(result);
                    if (nTipocont.state == EntityState.Guardar)
                    {
                        GenerarCodigo();
                        limpiar();
                        ShowTipoContrato();

                    }
                }
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
            GenerarCodigo();
            limpiar();
        }

        private void TipoContrato_Load(object sender, EventArgs e)
        {
            generarCodigo();
        }

        private void generarCodigo()
        {
            codtipcont = 0;

            using (nTipocont)
            {
                codtipcont = nTipocont.Getcodigo();
            }
        }

        private void dgvtipocontrato_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = dgvtipocontrato.CurrentRow;
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
