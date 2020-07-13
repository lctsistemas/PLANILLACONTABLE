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
        public TipoContrato()
        {
            InitializeComponent();
            ShowTipoContrato();
        }

        private void GenerarCodigo()
        {
            codigo = 0;
            using (nTipocont)
            {
                codigo = nTipocont.Getcodigo();
                txtcodigo.Text = "USER 0" + codigo;
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
            result = "";

            using (nTipocont)
            {
                if (nTipocont.state==EntityState.Guardar)
                {
                    nTipocont.id_tcontrato = Convert.ToInt32(txtcodigo.Text);
                    nTipocont.tiem_contrato = txttipo.Text.Trim().ToUpper();
                    ShowTipoContrato();

                    Messages.M_info(result);
                    if (nTipocont.state == EntityState.Guardar)
                    {
                        GenerarCodigo();
                        limpiar();
                    }
                }
            }
        }
    }
}
