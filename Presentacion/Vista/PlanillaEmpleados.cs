using Comun.Cache;
using Negocio.Models;
using Negocio.ValueObjects;
using Presentacion.Helps;
using System;
using System.Windows.Forms;

namespace Presentacion.Vista
{
    public partial class PlanillaEmpleados : Form
    {
        String result;
        private NPlanilla np = new NPlanilla();
        public PlanillaEmpleados()
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
                np.Id_empresa = UserCache.Codigo_empresa;
                np.Id_periodo = UserCache.Idperiodo;
                dgvplanilla.DataSource = np.Getall();
            }
        }


private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnmaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void Tabla()
        {
            dgvplanilla.Columns[0].HeaderText = "Id_planilla";
            dgvplanilla.Columns[0].Width = 50;
            dgvplanilla.Columns[0].Visible = false;

            dgvplanilla.Columns[1].HeaderText = "PERIODO";
            dgvplanilla.Columns[1].Width = 100;

            dgvplanilla.Columns[2].HeaderText = "EMPRESA";
            dgvplanilla.Columns[2].Width = 100;
            dgvplanilla.Columns[2].Visible = false;

            dgvplanilla.Columns[3].HeaderText = "Id_mes";
            dgvplanilla.Columns[3].Width = 100;
            dgvplanilla.Columns[3].Visible = false;

            dgvplanilla.Columns[4].HeaderText = "MES";
            dgvplanilla.Columns[4].Width = 100;

            dgvplanilla.Columns[5].HeaderText = "FECHA INICIAL";
            dgvplanilla.Columns[5].Width = 120;

            dgvplanilla.Columns[6].HeaderText = "FECHA FINAL";
            dgvplanilla.Columns[6].Width = 120;

            dgvplanilla.Columns[7].HeaderText = "FECHA PAGO";
            dgvplanilla.Columns[7].Width = 120;

            dgvplanilla.Columns[8].HeaderText = "DIAS_MES";
            dgvplanilla.Columns[8].Width = 100;

            dgvplanilla.Columns[9].HeaderText = "HORAS_MES";
            dgvplanilla.Columns[9].Width = 100;

            dgvplanilla.Columns[10].HeaderText = "REM. BASICA";
            dgvplanilla.Columns[10].Width = 100;

            dgvplanilla.Columns[11].HeaderText = "ASIG. FAMILIAR";
            dgvplanilla.Columns[11].Width = 130;

            dgvplanilla.Columns[12].HeaderText = "TOPE HORARIO NOCT";
            dgvplanilla.Columns[12].Width = 150;

            dgvplanilla.Columns[13].HeaderText = "ESTADO";
            dgvplanilla.Columns[13].Width = 100;
            dgvplanilla.Columns[13].Visible = false;

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            Planilla fr = Planilla.GetInstance();
            fr.StartPosition = FormStartPosition.CenterParent;
            fr.ShowDialog();
            ShowPlanilla();

        }

        

        private void btnmodificar_Click(object sender, EventArgs e)
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

        private void btneliminar_Click(object sender, EventArgs e)
        {
            result = "";
            if (dgvplanilla.Rows.GetFirstRow(DataGridViewElementStates.Selected) != -1)
            {
                DialogResult r = Messages.M_question("¿Desea eliminar la fila?");
                if (r == DialogResult.Yes)
                {
                    using (np)
                    {
                        np.state = EntityState.Remover;
                        np.Id_planilla = Convert.ToInt32(dgvplanilla.CurrentRow.Cells[0].Value);
                        result = np.GuardarCambios();
                        ShowPlanilla();
                        Messages.M_info(result);
                    }
                }

            }
            else
            {
                Messages.M_warning("Seleccione una fila de la tabla");
            }
        }

        private void btnplanillamant_Click(object sender, EventArgs e)
        {
            PlanillaMensual fr = PlanillaMensual.GetInstance();
            fr.txtmes.Text= dgvplanilla.CurrentRow.Cells[3].Value.ToString();
            fr.StartPosition = FormStartPosition.CenterParent;
            fr.ShowDialog();
            ShowPlanilla();
        }
    }
}
