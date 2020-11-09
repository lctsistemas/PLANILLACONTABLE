using Negocio.Models;
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
        }
        private void Fill_Banco()
        {
            using (nt = new Ntipocontrato())
            {
                dgvsubsidio.DataSource = nt.MostrarTcontrato();
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
            Fill_Banco();
        }

        private void dgvsubsidio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (dgvsubsidio.Rows[e.RowIndex].Cells["modificar"].Selected)
                {
                    mensaje = "";
                    using (nb = new NBanco())
                    {
                        nb.state = EntityState.Modificar;
                        nb.Nom_banco = dgvsubsidio.Rows[e.RowIndex].Cells["dgvtxtbanco"].Value.ToString();
                        nb.IdBanco = Convert.ToInt32(dgvsubsidio.Rows[e.RowIndex].Cells["dgvtxtidbanco"].Value);
                        mensaje = nb.GuardarCambios();
                        if (!mensaje.Equals(""))
                        {
                            Fill_Banco();

                        }
                        Messages.M_info(mensaje);
                        nb.state = EntityState.Guardar;
                    }
                }
                else if (dgvsubsidio.Rows[e.RowIndex].Cells["eliminar"].Selected)
                {
                    mensaje = "";
                    using (nb = new NBanco())
                    {
                        string cod_subsi = dgvsubsidio.CurrentRow.Cells["dgvtxtbanco"].Value.ToString();
                        DialogResult result = Messages.M_question("¿Está seguro de eliminar el tipo " + cod_subsi + "?");
                        if (result == DialogResult.Yes)
                        {
                            nb.state = EntityState.Remover;
                            nb.IdBanco = Convert.ToInt32(dgvsubsidio.Rows[e.RowIndex].Cells["dgvtxtidbanco"].Value);
                            mensaje = nb.GuardarCambios();
                            if (!mensaje.Equals(""))
                            {
                                Fill_Banco();

                            }
                            Messages.M_info(mensaje);
                            nb.state = EntityState.Guardar;
                        }
                    }
                }
            }
        }
    }
}
