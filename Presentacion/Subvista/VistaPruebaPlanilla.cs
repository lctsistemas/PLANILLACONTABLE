using Comun.Cache;
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

namespace Presentacion.Subvista
{
    public partial class FrmVistaPruebaPlanilla : Form
    {
        public FrmVistaPruebaPlanilla()
        {
            InitializeComponent();
        }

        private void FrmVistaPruebaPlanilla_Load(object sender, EventArgs e)
        {
            MostrarCalculoPrueba();
        }

        private void MostrarCalculoPrueba()
        {
            using (NplanillaM np = new NplanillaM())
            {
                np.Pid_planilla = PlanillaCache.p_idplanilla;
                np.PId_mes = PlanillaCache.p_idmes;
                this.dgvlistprueba.DataSource = np.Show_planillaPrueba(np);
                this.Text = "TOTAL REGISTRO : " + dgvlistprueba.RowCount;
            }
        }
    }
}
