using Comun.Cache;
using Negocio.Models;
using Negocio.ValueObjects;
using Presentacion.Helps;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Presentacion.Vista
{
    public partial class FrmPlanillaEmpleados : Form
    {
        String result;
        private NPlanilla np = new NPlanilla();
        public FrmPlanillaEmpleados()
        {
            InitializeComponent();
        }

        private void Prueba_Load(object sender, EventArgs e)
        {
            
            ShowPlanilla();
            Tabla();
            dgvplanilla.DoubleBuffered(true);
        }

        private void ShowPlanilla()
        {
            using (np)
            {
                np.Id_empresam = UserCache.Codigo_empresa;
                np.Id_periodo = UserCache.Idperiodo;
                dgvplanilla.DataSource = np.Getall();
            }
        }

        //DISEÑO A TABLA        
        private void Tabla()
        {
            dgvplanilla.Columns[0].HeaderText = "Id planilla";
            dgvplanilla.Columns[0].Width = 50;
            dgvplanilla.Columns[0].Visible = false;

            dgvplanilla.Columns[1].HeaderText = "PERIODO";
            dgvplanilla.Columns[1].Width = 80;
            dgvplanilla.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvplanilla.Columns[2].HeaderText = "idmes";
            dgvplanilla.Columns[2].Width = 50;
            dgvplanilla.Columns[2].Visible = false;

            dgvplanilla.Columns[3].HeaderText = "idemp maestra";
            dgvplanilla.Columns[3].Width = 50;
            dgvplanilla.Columns[3].Visible = false;

            dgvplanilla.Columns[4].HeaderText = "MES";
            dgvplanilla.Columns[4].Width = 100;

            dgvplanilla.Columns[5].HeaderText = "FECHA INICIAL";
            dgvplanilla.Columns[5].Width = 140;
            dgvplanilla.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvplanilla.Columns[6].HeaderText = "FECHA FINAL";
            dgvplanilla.Columns[6].Width = 140;
            dgvplanilla.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvplanilla.Columns[7].HeaderText = "FECHA PAGO";
            dgvplanilla.Columns[7].Width = 140;
            dgvplanilla.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvplanilla.Columns[8].HeaderText = "DIAS";
            dgvplanilla.Columns[8].Width = 70;
            dgvplanilla.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvplanilla.Columns[9].HeaderText = "HORAS MES";
            dgvplanilla.Columns[9].Width = 100;
            dgvplanilla.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvplanilla.Columns[10].HeaderText = "TOPE HORA NOCTURNA";
            dgvplanilla.Columns[10].Width = 140;
            dgvplanilla.Columns[10].DefaultCellStyle.Format = "N2";
            dgvplanilla.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
           
            dgvplanilla.Columns[11].Visible = false; // id tipo de planilla.
            dgvplanilla.Columns[12].HeaderText = "TIPO DE PLANILLA";
            dgvplanilla.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvplanilla.Columns[12].Width = 100;
            dgvplanilla.Columns[13].Visible = false; // estado de guardar, modificar, eliminar

        }
        

        //METODO PARA VER SI EL  MES EXISTE
        public bool Existe(int x)
        {
            using (np)
            {
                if (np.Existe(x))
                {
                    return true;
                }
                return false;
            }
            
        }

        private void tbtnnuevo_Click(object sender, EventArgs e)
        {
            FrmPlanilla fr = FrmPlanilla.GetInstance();
            this.AddOwnedForm(fr);
            fr.StartPosition = FormStartPosition.CenterParent;
            fr.ShowDialog();
            ShowPlanilla();
        }

        private void tbtnmodificar_Click(object sender, EventArgs e)
        {
            np.state = EntityState.Modificar;
            frmModificarPlanilla formodi = new frmModificarPlanilla();

            formodi.lblper.Text = dgvplanilla.CurrentRow.Cells[1].Value.ToString();//periodo
            formodi.cbxmes.Text = dgvplanilla.CurrentRow.Cells[4].Value.ToString();//mes

            formodi.txtpago.Text = dgvplanilla.CurrentRow.Cells[7].Value.ToString();//fecha pago
            formodi.StartPosition = FormStartPosition.CenterParent;
            formodi.ShowDialog();
            ShowPlanilla();
        }

        private void tbtneliminar_Click(object sender, EventArgs e)
        {
            result = "";
            if (dgvplanilla.Rows.GetFirstRow(DataGridViewElementStates.Selected) != -1)
            {
                string mes = dgvplanilla.CurrentRow.Cells[4].Value.ToString();
                DialogResult r = Messages.M_question("¿Desea eliminar la planilla de " + mes + "?");
                if (r == DialogResult.Yes)
                {
                    using (np)
                    {
                        np.state = EntityState.Remover;
                        np.Id_planilla = Convert.ToInt32(dgvplanilla.CurrentRow.Cells[0].Value);
                        result = np.GuardarCambios();
                        
                        if (result.Contains("la planilla tiene cálculo"))
                            Messages.M_error(result);
                        else
                        {
                            Messages.M_info(result);
                            ShowPlanilla();
                        }                       
                    }
                }

            }
            else
            {
                Messages.M_warning("Seleccione una fila de la tabla");
            }
        }

        private void tbtcalculo_Click(object sender, EventArgs e)
        {
            DateTime del, al, pago;
            FrmPlanillaMensual2 plm = FrmPlanillaMensual2.Getinstancia();
           
            this.AddOwnedForm(plm);
            this.toolmenu.Visible = false;
            this.btncerrar.Enabled = false;

            PlanillaCache.p_idplanilla = Convert.ToInt32(dgvplanilla.CurrentRow.Cells[0].Value);
            PlanillaCache.p_idmes = Convert.ToInt32(dgvplanilla.CurrentRow.Cells[2].Value);
            plm.Lblperiodo.Text = (dgvplanilla.CurrentRow.Cells[1].Value.ToString() + " - " + dgvplanilla.CurrentRow.Cells[4].Value.ToString());
            
            del= Convert.ToDateTime(dgvplanilla.CurrentRow.Cells[5].Value);
            plm.TxtfechaInicio.Text = del.ToString("dd,MM,yyyy");

            al = Convert.ToDateTime(dgvplanilla.CurrentRow.Cells[6].Value);
            plm.TxtfechaFin.Text = al.ToString("dd,MM,yyyy");

            pago = Convert.ToDateTime(dgvplanilla.CurrentRow.Cells[7].Value);
            plm.Txtpago.Text =pago.ToString("dd,MM,yyyy");

            plm.txtdiasMes.Text = dgvplanilla.CurrentRow.Cells[8].Value.ToString();
            plm.txtid_tipoplanilla.Text = dgvplanilla.CurrentRow.Cells[11].Value.ToString().Trim();
            plm.lbltipoplanilla.Text = dgvplanilla.CurrentRow.Cells[12].Value.ToString();

            plm.FormBorderStyle = FormBorderStyle.None;
            plm.TopLevel = false;//como ventana nivel superior
            plm.Dock = DockStyle.Fill;
            this.Controls.Add(plm);
            this.Tag = plm;//datos sobre el control
            plm.BringToFront();
            //f_vist.StartPosition = FormStartPosition.CenterParent;
            plm.Show();
        }

        private void paneltitulo_MouseDown(object sender, MouseEventArgs e)
        {
            //WindowsMove.ReleaseCapture();
            //WindowsMove.SendMessage(this.Handle, 0x112, 0xf012, 0);
            //if (this.WindowState == FormWindowState.Normal)
            //{
            //    btnrestaurar.Visible = false;
            //    btnmaximizar.Visible = true;
            //}                
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnmaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnrestaurar.Visible = true;
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

        //restaurar
        private void btnrestaurar_MouseDown(object sender, MouseEventArgs e)
        {
            btnrestaurar.BackColor = Color.FromArgb(165, 171, 179);
        }

        private void btnrestaurar_MouseLeave(object sender, EventArgs e)
        {
            btnrestaurar.BackColor = Color.FromArgb(116, 118, 118);
        }

        private void btnrestaurar_MouseMove(object sender, MouseEventArgs e)
        {
            btnrestaurar.BackColor = Color.FromArgb(138, 140, 140);
        }
        //maximizar
        private void btnmaximizar_MouseDown(object sender, MouseEventArgs e)
        {
            btnmaximizar.BackColor = Color.FromArgb(165, 171, 179);
        }

        private void btnmaximizar_MouseLeave(object sender, EventArgs e)
        {
            btnmaximizar.BackColor = Color.FromArgb(116, 118, 118);
        }

        private void btnmaximizar_MouseMove(object sender, MouseEventArgs e)
        {
            btnmaximizar.BackColor = Color.FromArgb(138, 140, 140);
        }
        //minimizar
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
        //..

    }
}
