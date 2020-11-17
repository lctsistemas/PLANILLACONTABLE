using Negocio.Models;
using Negocio.ValueObjects;
using Presentacion.Helps;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Presentacion.Vista
{
    public partial class frmdocumento : Form
    {
        private Ndocumento nd = new Ndocumento();
        string result;

        public frmdocumento()
        {
            InitializeComponent();
            ShowDocument();
        }
        //METODO MOSTRAR
        private void ShowDocument()
        {
            using (nd)
            {               
                dgvdocumento.DataSource = nd.Getall();
                lbltotal.Text = "Total registro: " + dgvdocumento.Rows.Count;
            }
        }
        //MODIFICAR DATAGRIDVIEW
        private void Tabla()
        {
            dgvdocumento.Columns[0].HeaderText = "ID";
            dgvdocumento.Columns[0].Width = 50;
            dgvdocumento.Columns[0].Visible = false;
            
            dgvdocumento.Columns[1].HeaderText = "CODIGO";
            dgvdocumento.Columns[1].Width = 50;
            dgvdocumento.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvdocumento.Columns[2].HeaderText = "DOCUMENTO";
            dgvdocumento.Columns[2].Width = 130;

            dgvdocumento.Columns[3].HeaderText = "DESCRIPCION";
            dgvdocumento.Columns[3].Width = 250;
            
        }
        //VALIDAR CONTROLES
        /*private bool Validar()
        {
            if (String.IsNullOrWhiteSpace(txtdocumento.Text))
            {
                ValidateChildren();
                return true;
            }
            else
                return false;
        }*/

        //HABILITAR CONTROLES
        private void Habilitar(bool v)
        {
            txtdocumento.Enabled = v;
            txtdescripcion.Enabled = v;
            btnguardar.Enabled = v;
            btneliminar.Enabled = v;
        }

        //LIMPIAR CONTROLES
        private void limpiar()
        {
            txtdocumento.Text = String.Empty;
            txtdescripcion.Text = String.Empty;
            txtcoddoc.Text = String.Empty;
            txtdocumento.Focus();
        }
        //LOAD
        private void frmdocumento_Load(object sender, EventArgs e)
        {
            Tabla();
            Tooltip.Title(txtbuscar, "Buscar por documento", true);
            Habilitar(false);
        }
        //NUEVO
        private void btnnuevo_Click(object sender, EventArgs e)
        {
            nd.state = EntityState.Guardar;
            ValidateError.validate.Clear();
            Habilitar(true);
            limpiar();

        }
        //SAVE CHANGE
        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtdocumento.Text) || string.IsNullOrWhiteSpace(txtcoddoc.Text))
            {
                ValidateChildren();
                return;
            }
           

            using (nd)
            {
                
                    nd.nombre_documento = txtdocumento.Text.Trim().ToUpper();
                    nd.descripcion = txtdescripcion.Text.Trim().ToUpper();
                    nd.cod_doc = txtcoddoc.Text.Trim().ToUpper();

               
                   result = nd.SaveChanges();
                   ShowDocument();
                   limpiar();
                
            }
        }
        //VALIATE
        private void txtdocumento_Validating(object sender, CancelEventArgs e)
        {
            ValidateError.Validate_text(txtdocumento, "Campo requerido!");
        }
        //BUSCAR
        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            dgvdocumento.DataSource = nd.Search(txtbuscar.Text.Trim());
            lbltotal.Text = "TOTAL REGISTRO: " + dgvdocumento.Rows.Count;
        }

        //TABLA
        private void dgvdocumento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = dgvdocumento.CurrentRow;

            if (dgvdocumento.Rows.GetFirstRow(DataGridViewElementStates.Selected) != -1)
            {
                nd.state = EntityState.Modificar;
                nd.iddocumento = Convert.ToInt32(r.Cells[0].Value);
                txtcoddoc.Text = Convert.ToString(r.Cells[1].Value);
                txtdocumento.Text = Convert.ToString(r.Cells[2].Value);
                txtdescripcion.Text = Convert.ToString(r.Cells[3].Value);
                Habilitar(true);

                ValidateError.validate.Clear();//LIMPIA LOS ERRORPROVIDER
            }
        }
        //ELIMINAR
        private void btneliminar_Click(object sender, EventArgs e)
        {
            result = "";
            if (dgvdocumento.Rows.GetFirstRow(DataGridViewElementStates.Selected) != -1)
            {
                DialogResult r = Messages.M_question("¿Desea eliminar la fila?");
                if (r == DialogResult.Yes)
                {
                    nd.state = EntityState.Remover;
                    nd.iddocumento = Convert.ToInt32(dgvdocumento.CurrentRow.Cells[0].Value);
                    result = nd.SaveChanges();
                    ShowDocument();
                    Messages.M_info(result);
                }

            }
            else
            {
                Messages.M_warning("Seleccione una fila de la tabla");
            }

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

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnrestaurar.Visible = false;
            btnmaximizar.Visible = true;

        }

        private void barraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            WindowsMove.ReleaseCapture();
            WindowsMove.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void frmdocumento_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void btncerrar_MouseMove(object sender, MouseEventArgs e)
        {
            btncerrar.BackColor = Color.FromArgb(231, 76, 60);
        }

        private void btncerrar_MouseLeave(object sender, EventArgs e)
        {
            btncerrar.BackColor = Color.FromArgb(36, 113, 163);
        }

        private void btncerrar_MouseDown(object sender, MouseEventArgs e)
        {
            btncerrar.BackColor = Color.FromArgb(205, 97, 85);
        }

        private void barraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtdocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Keypress.SoloLetras(e);
        }



        private void txtbuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Keypress.SoloLetras(e);

        }

        private void txtcoddoc_Validating(object sender, CancelEventArgs e)
        {
            ValidateError.Validate_text(txtcoddoc, "Campo codigo documento requerido!");
        }

        private void txtcoddoc_Validated(object sender, EventArgs e)
        {
            ValidateError.Validate_text(txtcoddoc, "Campo requerido");
        }

        private void txtdocumento_Validated(object sender, EventArgs e)
        {
            ValidateError.Validate_text(txtdocumento, "Campo requerido");
        }
    }
}
