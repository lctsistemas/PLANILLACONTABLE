using Negocio.Models;
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
    public partial class ListaNoSubsidiados : Form
    {
        private NSubsidios ns = new NSubsidios();

        public ListaNoSubsidiados()
        {
            InitializeComponent();
            ShowNoSubsidiados();
        }

        private static ListaNoSubsidiados instance;

        public static ListaNoSubsidiados GetInstance()
        {
            if (instance == null)
                instance = new ListaNoSubsidiados();

            return instance;
        }

        private void Tabla()
        {
            dgvnosubsidiados.Columns[0].HeaderText = "id_subsidios";
            dgvnosubsidiados.Columns[0].Width = 100;
            dgvnosubsidiados.Columns[0].Visible = false;

            dgvnosubsidiados.Columns[1].HeaderText = "Cod_subsidio";
            dgvnosubsidiados.Columns[1].Width = 150;

            dgvnosubsidiados.Columns[2].HeaderText = "Descripcion";
            dgvnosubsidiados.Columns[2].Width = 350;

            dgvnosubsidiados.Columns[3].HeaderText = "Tipo Subsidio";
            dgvnosubsidiados.Columns[3].Width = 100;
            dgvnosubsidiados.Columns[3].Visible = false;


            dgvnosubsidiados.Columns[4].HeaderText = "descuento";
            dgvnosubsidiados.Columns[4].Width = 100;

        }

        private void ListaNoSubsidiados_Load(object sender, EventArgs e)
        {
            ShowNoSubsidiados();
            Tabla();
        }

        private void ShowNoSubsidiados()
        {
            using (ns)
            {
                ns.Tipo_subsidio = "NO SUBSIDIADOS";
                dgvnosubsidiados.DataSource = ns.Getall();
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            frmDiasSubsidiados formdiasSubsidiados = new frmDiasSubsidiados();

            formdiasSubsidiados.txtcodsub.Text = dgvnosubsidiados.CurrentRow.Cells[1].Value.ToString();//periodo
            formdiasSubsidiados.txtdescrip.Text = dgvnosubsidiados.CurrentRow.Cells[2].Value.ToString();//mes

            formdiasSubsidiados.StartPosition = FormStartPosition.CenterParent;
            formdiasSubsidiados.ShowDialog();
        }
    }
}
