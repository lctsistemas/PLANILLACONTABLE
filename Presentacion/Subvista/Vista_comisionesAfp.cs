using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio.Models;

using Comun.Cache;
using Presentacion.Helps;

namespace Presentacion.Subvista
{
    public partial class FrmVista_comisionesAfp : Form
    {
        public FrmVista_comisionesAfp()
        {
            InitializeComponent();
            dgvcomision.AutoGenerateColumns = false;
        }

        //CARGAR AFP
        private void CargarAfps()
        {
            using (Nafp naf= new Nafp())
            {
                naf.Idmes = PlanillaCache.p_idmes;
                naf.Idperiodo = UserCache.Idperiodo;
                dgvcomision.DataSource = naf.Show_comisionafp("SPP");
            }
        }

        //TABLA
        private void Tabla()
        {
            dgvcomision.Columns["id_regimen"].Visible = false;
            dgvcomision.Columns["afp"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvcomision.Columns["afp"].Width = 170;//apf
            dgvcomision.Columns["afp"].ReadOnly = true;
            dgvcomision.Columns["Id_comision"].Visible = false; 
            dgvcomision.Columns["comision"].Width = 121;
            //dgvcomision.Columns["comision"].DefaultCellStyle.Format = "P"; //porcentaje.
            dgvcomision.Columns["saldo"].Width = 121;
            dgvcomision.Columns["seguro"].Width = 121;
            dgvcomision.Columns["aporte"].Width = 121;

            dgvcomision.Columns["tope"].Width = 121;
      

          
        }
        private void FrmVista_comisionesAfp_Load(object sender, EventArgs e)
        {
            CargarAfps();
            Tabla();
        }

        private void dgvcomision_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null)
            {
                switch (e.ColumnIndex)
                {
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                        if (e.Value.ToString() !="")
                        {
                            e.Value = Double.Parse(e.Value.ToString()) / 100;
                            e.CellStyle.Format = "P";
                        }
                        break;
                    default:
                        break;
                }
            }
        }


        //COLOR BOTON CERRAR
        private void btncerrar_MouseMove(object sender, MouseEventArgs e)
        {
            btncerrar.BackColor = Color.Crimson;
            btncerrar.ForeColor = Color.White;
        }

        private void btncerrar_MouseLeave(object sender, EventArgs e)
        {
            btncerrar.BackColor = Color.Transparent;
            btncerrar.ForeColor = Color.Crimson;
        }

        private void btncerrar_MouseDown(object sender, MouseEventArgs e)
        {
            btncerrar.BackColor = Color.FromArgb(241, 112, 122);
        }
        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //MOVER VENTANA
        private void PanelLista_MouseDown(object sender, MouseEventArgs e)
        {
            WindowsMove.ReleaseCapture();
            WindowsMove.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
