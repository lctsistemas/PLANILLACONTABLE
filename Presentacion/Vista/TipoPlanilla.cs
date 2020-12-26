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
    public partial class FrmTipoPlanilla : Form
    {
        String result;
        private NTipoPlanilla ntp = new NTipoPlanilla();
        public FrmTipoPlanilla()
        {
            InitializeComponent();
        }

        private bool Validar()
        {
            if (String.IsNullOrWhiteSpace(txtTipoPlanilla.Text))
            {                
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

                ShowTipoplanilla();
                limpiar();
            }
        }

        private void ShowTipoplanilla()
        {
            using (ntp)
            {
                dgvtipoplanilla.DataSource = ntp.Getall();
                lbltotal.Text = "Total registro:  " + dgvtipoplanilla.RowCount;
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
                        
                        if (result.Contains("el tipo de planilla esta en uso"))
                            Messages.M_error(result);
                        else
                        {
                            Messages.M_info(result);
                            ShowTipoplanilla();
                        }
                        
                    }
                }

            }
            else
            {
                Messages.M_warning("Seleccione una fila de la tabla");
            }
            
        }

        private void limpiar()
        {            
            using (ntp) { ntp.state = EntityState.Guardar; }
            txtTipoPlanilla.Text = String.Empty;
            ValidateError.validate.Clear();
        }

        private void TipoPlanilla_Load(object sender, EventArgs e)
        {
            ShowTipoplanilla();
            Tabla();
        }

        private void Tabla()
        {
            dgvtipoplanilla.Columns[0].HeaderText = "Id_Tipo_Planilla";
            dgvtipoplanilla.Columns[0].Width = 50;
            dgvtipoplanilla.Columns[0].Visible = false;

            dgvtipoplanilla.Columns[1].HeaderText = "TIPO DE PLANILLA";
            dgvtipoplanilla.Columns[1].Width = 380;

            dgvtipoplanilla.Columns[2].HeaderText = "state";
            dgvtipoplanilla.Columns[2].Width = 50;
            dgvtipoplanilla.Columns[2].Visible = false;

        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //BOTONES COLOR
        private void btncerrar_MouseLeave(object sender, EventArgs e)
        {
            btncerrar.BackColor = Color.FromArgb(116, 118, 118);
        }

        private void btncerrar_MouseDown(object sender, MouseEventArgs e)
        {
            btncerrar.BackColor = Color.FromArgb(241, 112, 122);
        }

        private void btncerrar_MouseMove(object sender, MouseEventArgs e)
        {
            btncerrar.BackColor = Color.Crimson;
        }
        //MINIMIZAR
        private void btnminimizar_MouseDown(object sender, MouseEventArgs e)
        {
            btnminimizar.BackColor = Color.FromArgb(165, 171, 179);
        }

        private void btnminimizar_MouseLeave(object sender, EventArgs e)
        {
            btnminimizar.BackColor = Color.FromArgb(116, 118, 118);
        }

        private void btnminimizar_MouseMove(object sender, MouseEventArgs e)
        {
            btnminimizar.BackColor = Color.FromArgb(138, 140, 140);
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void dgvtipoplanilla_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow ro = dgvtipoplanilla.CurrentRow;

            if (dgvtipoplanilla.Rows.GetFirstRow(DataGridViewElementStates.Selected) != -1)
            {
                using (ntp)
                {
                    ntp.state = EntityState.Modificar;
                    ntp.IdTipoPlanilla = Convert.ToInt32(ro.Cells[0].Value);
                    txtTipoPlanilla.Text = ro.Cells[1].Value.ToString();                   
                    ValidateError.validate.Clear();
                }
            }

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        //MOVER VENTANA FORMULARIO
        private void MoverVentana()
        {
            WindowsMove.ReleaseCapture();
            WindowsMove.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void paneltip_planilla_MouseDown(object sender, MouseEventArgs e)
        {
            MoverVentana();
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            MoverVentana();
        }
    }
}
