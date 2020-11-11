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
    public partial class Banco2 : Form
    {
        NBanco nb;
        string mensaje;
        
        public Banco2()
        {
            InitializeComponent();
            //Fillcombo();
            Fill_Banco();
            Tabla();
        }

        private void Fill_Banco()
        {
            using (nb = new NBanco())
            {       
                dgvsubsidio.DataSource = nb.Getall();
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtBanco.Text))
                return;

            mensaje = "";
            using (nb = new NBanco())
            {
                nb.Nom_banco = txtBanco.Text.Trim();
                mensaje = nb.GuardarCambios();
            }

            txtBanco.Text = string.Empty;
            txtBanco.Focus();
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
                            //MessageBox.Show("id banco es: "+nb.IdBanco);
                            mensaje = nb.GuardarCambios();
                            if (mensaje.Contains ("ESTA SIENDO USADO")  )
                            {
                                Messages.M_error(mensaje);
                            }
                            else
                            {
                                Messages.M_info(mensaje);
                                Fill_Banco();
                            }
                               
                            nb.state = EntityState.Guardar;
                        }
                    }
                }
            }
        }

        private void Tabla()
        {
            dgvsubsidio.Columns["dgvtxtidbanco"].Visible = false;
            dgvsubsidio.Columns["dgvtxtbanco"].ReadOnly = false;
        }
    }
}
