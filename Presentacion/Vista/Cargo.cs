using Negocio.Models;
using Negocio.ValueObjects;
using Presentacion.Helps;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Presentacion.Vista
{
    public partial class frmcargo : Form
    {
        private Ncargo nc = new Ncargo();
        string result = "";
        public frmcargo()
        {
            InitializeComponent();
            ShowCargo();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        //METODO MOSTRAR
        private void ShowCargo()
        {
            using (nc)
            {
                dgvcargo.DataSource = nc.Getall();
                TotalDatos();
            }
        }

        //TOTAL REGISTRO EN TABLA
        private void TotalDatos()
        {
            lbltotal.Text = "Total registro: " + dgvcargo.Rows.Count;
        }

        //MODIFICAR DATAGRIDVIEW
        private void Tabla()
        {
            dgvcargo.Columns[0].HeaderText = "CODIGO";
            dgvcargo.Columns[0].Width = 50;
            dgvcargo.Columns[0].Visible = false;

            dgvcargo.Columns[1].HeaderText = "CARGO";
            dgvcargo.Columns[1].Width = 154;

            dgvcargo.Columns[2].HeaderText = "DESCRIPCION";
            dgvcargo.Columns[2].Width = 281;         

        }

        //VALIDAR CONTROLES
        private bool Validar()
        {
            if (String.IsNullOrWhiteSpace(txtnom_cargo.Text))
            {
                ValidateChildren();
                return true;
            }
            else
                return false;
        }


        //HABILITAR CONTROLES
        private void Habilitar(bool v)
        {
            txtnom_cargo.Enabled = v;
            txtdescrip.Enabled = v;
            btnguardar.Enabled = v;
            btneliminar.Enabled = false;
           
        }

        //LIMPIAR CONTROLES
        private void limpiar()
        {
            using (nc) { nc.state = EntityState.Guardar; }
            txtnom_cargo.Text = String.Empty;
            txtdescrip.Text = String.Empty;
            txtnom_cargo.Focus();
        }

        //LOAD
        private void frmcargo_Load(object sender, EventArgs e)
        {
            Tabla();
            Tooltip.Title(txtbuscar, "Buscar por cargo", true);
            Habilitar(false);
        }

        //GUARDAR
        private void btnguardar_Click(object sender, EventArgs e)
        {

            if (Validar())
            {
                return;
            }
            using (nc)
            {
                nc.nombre_cargo = txtnom_cargo.Text.Trim().ToUpper();
                nc.descripcion = txtdescrip.Text.Trim().ToUpper();

                result = nc.SaveChanges();
                ShowCargo();
                limpiar();
                Messages.M_info(result);
            }
        }

        //NUEVO
        private void btnnuevo_Click(object sender, EventArgs e)
        {            
            ValidateError.validate.Clear();
            Habilitar(true);
            limpiar();
        }

        

        //CHANGE BUSCAR
        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            dgvcargo.DataSource = nc.Search(txtbuscar.Text.Trim());
            TotalDatos();

        }
        //DELETE
        private void btneliminar_Click(object sender, EventArgs e)
        {
            result = "";
            if (dgvcargo.Rows.GetFirstRow(DataGridViewElementStates.Selected) != -1)
            {
                DialogResult r = Messages.M_question("¿Desea eliminar la fila?");
                if (r == DialogResult.Yes)
                {
                    using (nc)
                    {
                        nc.state = EntityState.Remover;
                        nc.idcargo = Convert.ToInt32(dgvcargo.CurrentRow.Cells[0].Value);
                        result = nc.SaveChanges();

                        if (result.Contains("esta en uso"))
                            Messages.M_warning(result);
                        else
                        {
                            ShowCargo();
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



        //DATOS EN CAJA DEL DATAGRI..
        private void dgvcargo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = dgvcargo.CurrentRow;

            if (dgvcargo.Rows.GetFirstRow(DataGridViewElementStates.Selected) != -1)
            {
                using (nc)
                {
                    nc.state = EntityState.Modificar;
                    nc.idcargo = Convert.ToInt32(r.Cells[0].Value);
                    txtnom_cargo.Text = Convert.ToString(r.Cells[1].Value);
                    txtdescrip.Text = Convert.ToString(r.Cells[2].Value);
                    ValidateError.validate.Clear();//LIMPIA LOS ERRORPROVIDER
                    Habilitar(true);
                }
            }

        }
        //VALIDAR CAJA
        private void txtnom_cargo_Validating(object sender, CancelEventArgs e)
        {
            ValidateError.Validate_text(txtnom_cargo, "Ingrese Cargo");
        }

        private void txtnom_cargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Keypress.Text(e, txtdescrip);
            Keypress.SoloLetras(e);
        }        

        private void btncerrar_Click(object sender, EventArgs e)
        {
           this.Close();
        }
      
        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void barratitulo_MouseDown(object sender, MouseEventArgs e)
        {
            WindowsMove.ReleaseCapture();
            WindowsMove.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void frmcargo_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }       

        //botones 
        private void btncerrar_MouseLeave(object sender, EventArgs e)
        {
            btncerrar.BackColor = Color.FromArgb(116,118,118);
        }

        private void btncerrar_MouseDown(object sender, MouseEventArgs e)
        {
            btncerrar.BackColor = Color.FromArgb(241,112,122);
        }

    
        private void txtbuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Keypress.SoloLetras(e);
        }

        private void btnminimizar_MouseLeave(object sender, EventArgs e)
        {
            btnminimizar.BackColor = Color.FromArgb(116, 118, 118);
        }

        private void btnminimizar_MouseMove(object sender, MouseEventArgs e)
        {
            btnminimizar.BackColor = Color.FromArgb(138,140,140);
        }

        private void btncerrar_MouseMove(object sender, MouseEventArgs e)
        {
            btncerrar.BackColor = Color.Crimson;
        }

        private void btnminimizar_MouseDown(object sender, MouseEventArgs e)
        {
            btnminimizar.BackColor = Color.FromArgb(165,171,179);
        }

        private void dgvcargo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
                btneliminar.Enabled = true;
        }
    }
}

