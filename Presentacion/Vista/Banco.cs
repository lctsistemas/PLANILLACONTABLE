using Negocio.Models;
using Negocio.ValueObjects;
using Presentacion.Helps;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Presentacion.Vista
{
    public partial class Banco : Form
    {
        String result;
        private Int32 codigoban;

        private NBanco nbanco = new NBanco();
        public Banco()
        {
            InitializeComponent();
        }
        private void Tabla()
        {
            dgvBanco.Columns[0].HeaderText = "CODIGO";
            dgvBanco.Columns[0].Width = 50;

            dgvBanco.Columns[1].HeaderText = "BANCO";
            dgvBanco.Columns[1].Width = 150;

            dgvBanco.Columns[2].HeaderText = "entidad";
            dgvBanco.Columns[2].Width = 150;
            dgvBanco.Columns[2].Visible = false;

        }
        private bool Validar()
        {
            if (String.IsNullOrWhiteSpace(txtBanco.Text))
            {
                ValidateChildren();
                return true;
            }
            else
                return false;
        }


        public void generarCodigo()
        {
            codigoban = 0;

            using (nbanco)
            {
                codigoban = nbanco.GetCodigo();
                txtcodigo.Text = "BAN 0" + codigoban;
            }
        }

        private void ShowBanco(String data)
        {
            using (nbanco)
            {
                nbanco.Nom_banco = data;
                try
                {
                    dgvBanco.DataSource = nbanco.Listar();

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);

                }

            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (Validar())
                return;

            result = "";
            using (nbanco)
            {
                if (nbanco.state == EntityState.Guardar)
                    nbanco.IdBanco = codigoban;
                nbanco.Nom_banco = txtBanco.Text.Trim();


                result = nbanco.GuardarCambios();

                Messages.M_info(result);
                if (nbanco.state == EntityState.Guardar)
                {
                    generarCodigo();
                    limpiar();
                }
                ShowBanco("");
            }
        }

        private void limpiar()
        {
            txtBanco.Text = String.Empty;
            txtBanco.Focus();
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

        

        private void Banco_Load(object sender, EventArgs e)
        {
            ShowBanco("");
            generarCodigo();
            Tabla();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            using (nbanco) { nbanco.state = EntityState.Guardar; }
            generarCodigo();

            limpiar();
        }
        private void BorrarError(TextBox textbox)
        {
            ValidateError.Validate_text(txtBanco, "");
           
        }


        private void txtBanco_Validating(object sender, CancelEventArgs e)
        {
            if (this.txtBanco.Text.Equals(""))
            {
                this.pictureBox2.Visible = true;
                this.pictureBox2.BackColor = Color.FromArgb(231, 76, 60);
            }

            else
            {
                this.pictureBox2.Visible = false;
                this.txtBanco.BackColor = Color.White;
            }
        }

        private void txtBanco_KeyDown(object sender, KeyEventArgs e)
        {
            this.pictureBox2.BackColor = Color.FromArgb(41, 128, 185);
        }

        private void btnremover_Click(object sender, EventArgs e)
        {
            result = "";
            if (dgvBanco.Rows.GetFirstRow(DataGridViewElementStates.Selected) != -1)
            {
                DialogResult re = Messages.M_question("¿Desea Eliminar Banco?");
                if (re == DialogResult.Yes)
                {
                    using (nbanco)
                    {
                        nbanco.state = EntityState.Remover;
                        nbanco.IdBanco = Convert.ToInt32(dgvBanco.CurrentRow.Cells[0].Value);//idusuario
                        result = nbanco.GuardarCambios();
                        Messages.M_info(result);
                        ShowBanco("");
                        btnguardar.Enabled = false;
                    }
                }

            }
            else
            {
                Messages.M_warning("Seleccione un Fila");
            }
        }

        

        private void Habilitar(bool v)
        {
            btnguardar.Enabled = v;
            txtcodigo.Enabled = v;
            txtBanco.Enabled = v;
            
        }

        private void dgvBanco_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = dgvBanco.CurrentRow;
            if (dgvBanco.Rows.GetFirstRow(DataGridViewElementStates.Selected) != -1)
            {
                using (nbanco)
                {
                    nbanco.state = EntityState.Modificar;
                    nbanco.IdBanco = Convert.ToInt32(r.Cells[0].Value);//idusuario
                    txtcodigo.Text = "USER 0" + nbanco.IdBanco;
                    txtBanco.Text = r.Cells[1].Value.ToString();

                    tablista.SelectedIndex = 0;
                    Habilitar(true);
                    ValidateError.validate.Clear();
                }

            }
        }

        private void txtBanco_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
