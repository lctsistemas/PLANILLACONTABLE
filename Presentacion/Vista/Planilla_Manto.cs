﻿using Comun.Cache;
using Negocio.Models;
using Negocio.ValueObjects;
using Presentacion.Helps;
using System;
using System.Windows.Forms;

namespace Presentacion.Vista
{
    public partial class Planilla_Manto : Form
    {
        String result;
        private NPlanilla np = new NPlanilla();
        public Planilla_Manto()
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

            dgvplanilla.Columns[2].HeaderText = "MES";
            dgvplanilla.Columns[2].Width = 100;

            dgvplanilla.Columns[3].HeaderText = "FECHA INICIAL";
            dgvplanilla.Columns[3].Width = 120;

            dgvplanilla.Columns[4].HeaderText = "FECHA FINAL";
            dgvplanilla.Columns[4].Width = 120;

            dgvplanilla.Columns[5].HeaderText = "FECHA PAGO";
            dgvplanilla.Columns[5].Width = 120;

            dgvplanilla.Columns[6].HeaderText = "DIAS_MES";
            dgvplanilla.Columns[6].Width = 100;

            dgvplanilla.Columns[7].HeaderText = "HORAS_MES";
            dgvplanilla.Columns[7].Width = 100;

            dgvplanilla.Columns[8].HeaderText = "REM. BASICA";
            dgvplanilla.Columns[8].Width = 100;

            dgvplanilla.Columns[9].HeaderText = "ASIG. FAMILIAR";
            dgvplanilla.Columns[9].Width = 130;

            dgvplanilla.Columns[10].HeaderText = "state";
            dgvplanilla.Columns[10].Width = 100;
            dgvplanilla.Columns[10].Visible = false;
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            Planilla fr = Planilla.GetInstance();
            fr.StartPosition = FormStartPosition.CenterParent;
            fr.ShowDialog();
            ShowPlanilla();

        }

        private void paneltitulo_MouseDown(object sender, MouseEventArgs e)
        {
            WindowsMove.ReleaseCapture();
            WindowsMove.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label16_MouseDown(object sender, MouseEventArgs e)
        {
            WindowsMove.ReleaseCapture();
            WindowsMove.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            np.state = EntityState.Modificar;
            frmModificarPlanilla formodi = new frmModificarPlanilla();

            formodi.lblper.Text = dgvplanilla.CurrentRow.Cells[1].Value.ToString();//periodo
            formodi.cbxmes.Text = dgvplanilla.CurrentRow.Cells[2].Value.ToString();//mes

            formodi.txtpago.Text = dgvplanilla.CurrentRow.Cells[5].Value.ToString();//fecha pago
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
    }
}
