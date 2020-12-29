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
    public partial class FrmRegimenSalud : Form
    {
        String result;
        private NRegimenSalud nrs = new NRegimenSalud();
        public FrmRegimenSalud()
        {
            InitializeComponent();            
        }
      


        private bool Validar()
        {
            if (String.IsNullOrWhiteSpace(txtcodregsal.Text) || String.IsNullOrWhiteSpace(txtregsal.Text))
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
            using (nrs)
            {
                nrs.Cod_regi_salud = txtcodregsal.Text.Trim();
                nrs.Descripcion =txtregsal.Text.ToString();

                result = nrs.GuardarCambios();
                Messages.M_info(result);
           
                Showregimensalud();
                limpiar();               
            }
        }

        private void Tabla()
        {
            dgvregimensalud.Columns[0].HeaderText = "Id_regimen_salud";
            dgvregimensalud.Columns[0].Width = 50;
            dgvregimensalud.Columns[0].Visible = false;            

            dgvregimensalud.Columns[1].HeaderText = "COD. REGIMEN SALUD";
            dgvregimensalud.Columns[1].Width = 127;
            dgvregimensalud.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvregimensalud.Columns[2].HeaderText = "REGIMEN SALUD";
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
                lbltotal.Text = "Total registro:  " + dgvregimensalud.RowCount;
            }
        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {            
            Habilitar(true);
            limpiar();
          
        }

        private void RegimenSalud_Load(object sender, EventArgs e)
        {
            Showregimensalud();
            Habilitar(false);
            Tabla();
          
        }

        private void Habilitar(bool v)
        {
            btnguardar.Enabled = v;
            btneliminar.Enabled = false;
            txtcodregsal.Enabled = v;
            txtregsal.Enabled = v;
            txtcodregsal.Focus();
        }

        private void dgvregimensalud_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = dgvregimensalud.CurrentRow;
          
            if (dgvregimensalud.Rows.GetFirstRow(DataGridViewElementStates.Selected) != -1)
            {
                Habilitar(true);
                using (nrs)
                {
                    nrs.state = EntityState.Modificar;
                    nrs.Id_regimen_salud = Convert.ToInt32(r.Cells[0].Value);

                    txtcodregsal.Text = Convert.ToString(r.Cells[1].Value);
                    txtregsal.Text = Convert.ToString(r.Cells[2].Value);
                    ValidateError.validate.Clear();//LIMPIA LOS ERRORPROVIDER                    
                }
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            result = "";
            if (dgvregimensalud.Rows.GetFirstRow(DataGridViewElementStates.Selected) != -1)
            {
                DialogResult r = Messages.M_question("¿Desea eliminar la fila?");
                if (r == DialogResult.Yes)
                {
                    using (nrs)
                    {
                        nrs.state = EntityState.Remover;
                        nrs.Id_regimen_salud = Convert.ToInt32(dgvregimensalud.CurrentRow.Cells[0].Value);
                        result = nrs.GuardarCambios();
                        if (result.Contains("asignado a un contrato"))
                            Messages.M_warning(result);
                        else
                        {
                            Showregimensalud();
                            limpiar();
                            Messages.M_info(result);
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
            txtcodregsal.Text = String.Empty;
            txtregsal.Text = String.Empty;

            using (nrs) { nrs.state = EntityState.Guardar; }
        }

        private void txtcodregsal_Validating(object sender, CancelEventArgs e)
        {
           
                ValidateError.Validate_text(txtcodregsal, "Campo Requerido");

        }

        private void txtregsal_Validating(object sender, CancelEventArgs e)
        {
            ValidateError.Validate_text(txtregsal, "Campo Requerido");
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            WindowsMove.ReleaseCapture();
            WindowsMove.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            WindowsMove.ReleaseCapture();
            WindowsMove.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }         
     

        #region BOTONES CERRAR Y MINIMIZAR
        private void btncerrar_MouseDown(object sender, MouseEventArgs e)
        {
            btncerrar.BackColor = Color.FromArgb(241,112,122);
        }

        private void btncerrar_MouseLeave(object sender, EventArgs e)
        {
            btncerrar.BackColor = Color.FromArgb(116,118,118);
        }

        private void btncerrar_MouseMove(object sender, MouseEventArgs e)
        {
            btncerrar.BackColor = Color.Crimson;
        }

        private void btnminimizar_MouseDown(object sender, MouseEventArgs e)
        {
            btnminimizar.BackColor = Color.FromArgb(165,171,179);
        }

        private void btnminimizar_MouseLeave(object sender, EventArgs e)
        {
            btnminimizar.BackColor = Color.FromArgb(116,118,118);
        }

        private void btnminimizar_MouseMove(object sender, MouseEventArgs e)
        {
            btnminimizar.BackColor = Color.FromArgb(138,140,140);
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void dgvregimensalud_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)            
                btneliminar.Enabled = true;
            
        }
    }
}
