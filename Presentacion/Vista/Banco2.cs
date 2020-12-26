using Negocio.Models;
using Negocio.ValueObjects;
using Presentacion.Helps;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Vista
{
    public partial class FrmBanco2 : Form
    {
        NBanco nb;
        string mensaje;
        
        public FrmBanco2()
        {
            InitializeComponent();
            
            Fill_Banco();
            Tabla();
            //this.FormBorderStyle = FormBorderStyle.None;
            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        /*[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
           (
               int nLeftRect,     // x-coordinate of upper-left corner
               int nTopRect,      // y-coordinate of upper-left corner
               int nRightRect,    // x-coordinate of lower-right corner
               int nBottomRect,   // y-coordinate of lower-right corner
               int nWidthEllipse, // height of ellipse
               int nHeightEllipse // width of ellipse
           );*/


        //TABLA
        private void Tabla()
        {
            dgvbanco.Columns["bid"].Visible = false;
            dgvbanco.Columns[4].Visible = false; // estado add, edit, delete
         
        }

        private void Fill_Banco()
        {
            using (nb = new NBanco())
            {       
                dgvbanco.DataSource = nb.Getall();
                lbltotal.Text = "Total registro: " + dgvbanco.Rows.Count;
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtBanco.Text)) { 
                ValidateChildren();
                return;
            }
            mensaje = "";
            using (nb = new NBanco())
            {
                nb.Nom_banco = txtBanco.Text.Trim().ToUpper();
                mensaje = nb.GuardarCambios();
            }

            txtBanco.Text = string.Empty;
            txtBanco.Focus();
            Fill_Banco();            
        }

        private void dgvbanco_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (dgvbanco.Rows[e.RowIndex].Cells["bmodificar"].Selected)
                {
                    mensaje = "";
                    using (nb = new NBanco())
                    {
                        nb.state = EntityState.Modificar;
                        nb.IdBanco = Convert.ToInt32(dgvbanco.Rows[e.RowIndex].Cells["bid"].Value);
                        nb.Nom_banco = dgvbanco.Rows[e.RowIndex].Cells["bnombre"].Value.ToString().ToUpper();                        
                        mensaje = nb.GuardarCambios();                        
                        Fill_Banco();
                        
                        Messages.M_info(mensaje);
                        nb.state = EntityState.Guardar;
                    }
                }
                else if (dgvbanco.Rows[e.RowIndex].Cells["beliminar"].Selected)
                {
                    mensaje = "";
                    using (nb = new NBanco())
                    {
                        string nombre_ban = dgvbanco.CurrentRow.Cells["bnombre"].Value.ToString();
                        DialogResult result = Messages.M_question("¿Está seguro de eliminar  "+ nombre_ban + "?");
                        if (result == DialogResult.Yes)
                        {
                            nb.state = EntityState.Remover;
                            nb.IdBanco = Convert.ToInt32(dgvbanco.Rows[e.RowIndex].Cells["bid"].Value);
                           
                            mensaje = nb.GuardarCambios();
                            if (mensaje.Contains ("esta  asignado.")  )
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

       

        //MOVER VENTANA
        private void MoverWindows()
        {
            WindowsMove.ReleaseCapture();
            WindowsMove.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void lblbanco_MouseDown(object sender, MouseEventArgs e)
        {
            MoverWindows();   
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            MoverWindows();
        }

        //botones colores
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
        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //MINIMIZAR
        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

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
       //...

        private void txtBanco_Validating(object sender, CancelEventArgs e)
        {
            ValidateError.Validate_text(txtBanco, "Campo requerido!");            
        }


        //PARA PODER EDITAR
        private void dgvbanco_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvbanco.Rows.Count > 0)
            {
                dgvbanco.BeginEdit(true);
            }
        }

        private void dgvbanco_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            DataGridViewCellStyle style = e.CellStyle;

            style.Font = new Font(style.Font.FontFamily, 10, FontStyle.Bold);
            style.BackColor = Color.Beige;
        }
    }
}
