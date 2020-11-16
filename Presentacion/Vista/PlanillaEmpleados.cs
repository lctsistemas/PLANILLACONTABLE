using Comun.Cache;
using Negocio.Models;
using Negocio.ValueObjects;
using Presentacion.Helps;
using System;
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

            dgvplanilla.Columns[11].HeaderText = "ESTADO";
            dgvplanilla.Columns[11].Width = 50;
            dgvplanilla.Columns[11].Visible = false;

        }     
     
        private void tbtnnuevo_Click(object sender, EventArgs e)
        {
            FrmPlanilla fr = FrmPlanilla.GetInstance();
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
            PlanillaMensual fr = PlanillaMensual.GetInstance();
            fr.txtmes.Text = dgvplanilla.CurrentRow.Cells[3].Value.ToString();
            fr.StartPosition = FormStartPosition.CenterParent;
            fr.ShowDialog();
            ShowPlanilla();
        }

        private void paneltitulo_MouseDown(object sender, MouseEventArgs e)
        {
            WindowsMove.ReleaseCapture();
            WindowsMove.SendMessage(this.Handle, 0x112, 0xf012, 0);
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
    }
}
