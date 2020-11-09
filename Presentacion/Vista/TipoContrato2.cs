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
    public partial class TipoContrato2 : Form
    {
        Ntipocontrato nt;
        string mensaje;
        public TipoContrato2()
        {
            InitializeComponent();
            Fill_TipoContrato();
        }
        private void Fill_TipoContrato()
        {
            using (nt = new Ntipocontrato())
            {
                dgvTcontrato.DataSource = nt.MostrarTcontrato();
            }
        }
        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtTipoContrato.Text))
                return;

            mensaje = "";
            using (nt = new Ntipocontrato())
            {
                nt.tiem_contrato = txtTipoContrato.Text.Trim();
                mensaje = nt.GuardarCambios();
            }

            txtTipoContrato.Text = string.Empty;
            txtTipoContrato.Focus();
            Fill_TipoContrato();
        }

        private void dgvsubsidio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (dgvTcontrato.Rows[e.RowIndex].Cells["modificar"].Selected)
                {
                    mensaje = "";
                    using (nt = new Ntipocontrato())
                    {
                        nt.state = EntityState.Modificar;
                        nt.tiem_contrato = dgvTcontrato.Rows[e.RowIndex].Cells["dgvtxttcontrato"].Value.ToString();
                        nt.id_tcontrato = Convert.ToInt32(dgvTcontrato.Rows[e.RowIndex].Cells["dgvtxtidtcontrato"].Value);
                        mensaje = nt.GuardarCambios();
                        if (!mensaje.Equals(""))
                        {
                            Fill_TipoContrato();

                        }
                        Messages.M_info(mensaje);
                        nt.state = EntityState.Guardar;
                    }
                }
                else if (dgvTcontrato.Rows[e.RowIndex].Cells["eliminar"].Selected)
                {
                    mensaje = "";
                    using (nt = new Ntipocontrato())
                    {
                        string cod_subsi = dgvTcontrato.CurrentRow.Cells["dgvtxtidtcontrato"].Value.ToString();
                        DialogResult result = Messages.M_question("¿Está seguro de eliminar el tipo " + cod_subsi + "?");
                        if (result == DialogResult.Yes)
                        {
                            nt.state = EntityState.Remover;
                            nt.id_tcontrato = Convert.ToInt32(dgvTcontrato.Rows[e.RowIndex].Cells["dgvtxtidtcontrato"].Value);
                            mensaje = nt.GuardarCambios();
                            if (!mensaje.Equals(""))
                            {
                                Fill_TipoContrato();

                            }
                            Messages.M_info(mensaje);
                            nt.state = EntityState.Guardar;
                        }
                    }
                }
            }
        }
    }
}
