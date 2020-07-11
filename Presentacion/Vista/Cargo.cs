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
        //[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        //private static extern IntPtr CreateRoundRectRgn
        //   (
        //       int nLeftRect,     // x-coordinate of upper-left corner
        //       int nTopRect,      // y-coordinate of upper-left corner
        //       int nRightRect,    // x-coordinate of lower-right corner
        //       int nBottomRect,   // y-coordinate of lower-right corner
        //       int nWidthEllipse, // height of ellipse
        //       int nHeightEllipse // width of ellipse
        //   );
        public frmcargo()
        {
            InitializeComponent();
            ShowCargo("");
            this.FormBorderStyle = FormBorderStyle.None;
            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        //METODO MOSTRAR
        private void ShowCargo(string data)
        {

            using (nc)
            {
                nc.nombre_cargo = data;
                dgvcargo.DataSource = nc.Getall();
                lbltotal.Text = "TOTAL REGISTRO: " + dgvcargo.Rows.Count;
            }

        }


        //MODIFICAR DATAGRIDVIEW
        private void Tabla()
        {
            dgvcargo.Columns[0].HeaderText = "CODIGO";
            dgvcargo.Columns[0].Width = 50;
            dgvcargo.Columns[0].Visible = false;

            dgvcargo.Columns[1].HeaderText = "CARGO";
            dgvcargo.Columns[1].Width = 150;

            dgvcargo.Columns[2].HeaderText = "DESCRIPCION";
            dgvcargo.Columns[2].Width = 200;

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
            btneliminar.Enabled = v;
        }

        //LIMPIAR CONTROLES
        private void limpiar()
        {
            txtnom_cargo.Text = String.Empty;
            txtdescrip.Text = String.Empty;
            txtnom_cargo.Focus();
        }

        //LOAD
        private void frmcargo_Load(object sender, EventArgs e)
        {
            Tabla();
            Tooltip.Title(txtbuscar, "Buscar por cargo");
            Habilitar(false);
        }

        //GUARDAR
        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (Validar())
                return;

            using (nc)
            {
                nc.nombre_cargo = txtnom_cargo.Text.Trim().ToUpper();
                nc.descripcion = txtdescrip.Text.Trim().ToUpper();
                result = nc.SaveChanges();
                ShowCargo("");
                Messages.M_info(result);
            }
        }

        //NUEVO
        private void btnnuevo_Click(object sender, EventArgs e)
        {
            nc.state = EntityState.Guardar;
            ValidateError.validate.Clear();
            Habilitar(true);
            limpiar();
        }
        //CHANGE BUSCAR
        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            ShowCargo(txtbuscar.Text.Trim());
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
                        ShowCargo("");
                        Messages.M_info(result);
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
        }


        private void txtdescrip_KeyPress(object sender, KeyPressEventArgs e)
        {
            Keypress.Button(e, btnguardar);
        }

        private void txtnom_cargo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnmaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnminimizar.Visible = true;
            btnmaximizar.Visible = false;
        }

        private void btnrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnrestaurar.Visible = false;
            btnmaximizar.Visible = true;
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

        private void btncerrar_MouseHover(object sender, EventArgs e)
        {
            btncerrar.BackColor = Color.Crimson;
        }

        private void btncerrar_MouseLeave(object sender, EventArgs e)
        {
            btncerrar.BackColor = Color.SteelBlue;
        }

        private void btncerrar_MouseDown(object sender, MouseEventArgs e)
        {
            btncerrar.BackColor = Color.FromArgb(245, 183, 177);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
