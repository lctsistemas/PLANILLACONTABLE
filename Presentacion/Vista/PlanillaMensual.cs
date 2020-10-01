using Presentacion.Helps;
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
    public partial class PlanillaMensual : Form
    {
        public PlanillaMensual()
        {
            InitializeComponent();
        }

        private void label10_MouseDown(object sender, MouseEventArgs e)
        {
            WindowsMove.ReleaseCapture();
            WindowsMove.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void panel6_MouseDown(object sender, MouseEventArgs e)
        {
            WindowsMove.ReleaseCapture();
            WindowsMove.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PlanillaMensual_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
            txtDNI.Focus();
        }

        private void txtDiurna25_TextChanged(object sender, EventArgs e)
        {
            if (txtDiurna25.Text == "")
            {
                txtDiurna25.Text = "0";
            }
            else if (txtMinDiurna25.Text == "")
            {
                txtMinDiurna25.Text = "0";
            }
            else
            {
                double remuneracion = Double.Parse(txtHaberBasico.Text.ToString());
                double asignacion = Double.Parse(txtAsigFamiliar.Text.ToString());

                double precioPorHoraDiurna = ((remuneracion + asignacion) / 30) / 8;
                double recargo25 = precioPorHoraDiurna * 0.25;
                double total_recargo = precioPorHoraDiurna + recargo25;
                txtPrecioHoraDiurna25.Text = total_recargo.ToString("N2");

                double recargo35 = precioPorHoraDiurna * 0.35;
                double total_recargo35 = precioPorHoraDiurna + recargo35;
                txtPrecioHoraDiurna35.Text = total_recargo35.ToString("N2");

                double horadiurna25 = Double.Parse(txtDiurna25.Text.ToString());
                double mindiurna25 = Double.Parse(txtMinDiurna25.Text.ToString());

                double dias_mes = (remuneracion + asignacion) / 30;
                double horas_mes = dias_mes / 8;
                double minutos_mes = horas_mes / 60;

                double recargo25minutos = minutos_mes * 0.25;
                double sumarecargo25minutos = minutos_mes + recargo25minutos;

                double horaporsumarecargo = sumarecargo25minutos * mindiurna25;

                double horadiurna25_2 = (horadiurna25 * total_recargo) + horaporsumarecargo;
                txtTotalDiurna25.Text = horadiurna25_2.ToString("N2");



                double totalDiurna25 = Double.Parse(txtTotalDiurna25.Text);
                double totalDiurna35 = Double.Parse(txtTotalDiurna35.Text);

                double totalSumaDiurna = totalDiurna25 + totalDiurna35;
                txtTotalDiurna.Text = totalSumaDiurna.ToString("N2");
            }
        }

        private void txtMinDiurna25_TextChanged(object sender, EventArgs e)
        {
            if (txtDiurna25.Text == "")
            {
                txtDiurna25.Text = "0";
            }
            else if (txtMinDiurna25.Text == "")
            {
                txtMinDiurna25.Text = "0";
            }
            else
            {
                double remuneracion = Double.Parse(txtHaberBasico.Text.ToString());
                double asignacion = Double.Parse(txtAsigFamiliar.Text.ToString());

                double precioPorHoraDiurna = ((remuneracion + asignacion) / 30) / 8;
                double recargo25 = precioPorHoraDiurna * 0.25;
                double total_recargo = precioPorHoraDiurna + recargo25;
                txtPrecioHoraDiurna25.Text = total_recargo.ToString("N2");

                double recargo35 = precioPorHoraDiurna * 0.35;
                double total_recargo35 = precioPorHoraDiurna + recargo35;
                txtPrecioHoraDiurna35.Text = total_recargo35.ToString("N2");

                double horadiurna25 = Double.Parse(txtDiurna25.Text.ToString());
                double mindiurna25 = Double.Parse(txtMinDiurna25.Text.ToString());

                double dias_mes = (remuneracion + asignacion) / 30;
                double horas_mes = dias_mes / 8;
                double minutos_mes = horas_mes / 60;

                double recargo25minutos = minutos_mes * 0.25;
                double sumarecargo25minutos = minutos_mes + recargo25minutos;

                double horaporsumarecargo = sumarecargo25minutos * mindiurna25;

                double horadiurna25_2 = (horadiurna25 * total_recargo) + horaporsumarecargo;
                txtTotalDiurna25.Text = horadiurna25_2.ToString("N2");

                double totalDiurna25 = Double.Parse(txtTotalDiurna25.Text);
                double totalDiurna35 = Double.Parse(txtTotalDiurna35.Text);

                double totalSumaDiurna = totalDiurna25 + totalDiurna35;
                txtTotalDiurna.Text = totalSumaDiurna.ToString("N2");
            }
        }

        private void txtDiurna35_TextChanged(object sender, EventArgs e)
        {
            if (txtDiurna35.Text == "")
            {
                txtDiurna35.Text = "0";
            }
            else if (txtMinDiurna35.Text == "")
            {
                txtMinDiurna35.Text = "0";
            }
            else
            {
                double remuneracion = Double.Parse(txtHaberBasico.Text.ToString());
                double asignacion = Double.Parse(txtAsigFamiliar.Text.ToString());

                double precioPorHoraDiurna = ((remuneracion + asignacion) / 30) / 8;
                double recargo25 = precioPorHoraDiurna * 0.25;
                double total_recargo = precioPorHoraDiurna + recargo25;
                txtPrecioHoraDiurna25.Text = total_recargo.ToString("N2");

                double recargo35 = precioPorHoraDiurna * 0.35;
                double total_recargo35 = precioPorHoraDiurna + recargo35;
                txtPrecioHoraDiurna35.Text = total_recargo35.ToString("N2");

                double horadiurna35 = Double.Parse(txtDiurna35.Text.ToString());
                double mindiurna35 = Double.Parse(txtMinDiurna35.Text.ToString());

                double dias_mes = (remuneracion + asignacion) / 30;
                double horas_mes = dias_mes / 8;
                double minutos_mes = horas_mes / 60;

                double recargo35minutos = minutos_mes * 0.35;
                double sumarecargo35minutos = minutos_mes + recargo35minutos;

                double horaporsumarecargo35 = sumarecargo35minutos * mindiurna35;

                double horadiurna35_2 = (horadiurna35 * total_recargo35) + horaporsumarecargo35;
                txtTotalDiurna35.Text = horadiurna35_2.ToString("N2");

                double totalDiurna25 = Double.Parse(txtTotalDiurna25.Text);
                double totalDiurna35 = Double.Parse(txtTotalDiurna35.Text);

                double totalSumaDiurna = totalDiurna25 + totalDiurna35;
                txtTotalDiurna.Text = totalSumaDiurna.ToString("N2");
            }
        }

        private void txtMinDiurna35_TextChanged(object sender, EventArgs e)
        {
            if (txtDiurna35.Text == "")
            {
                txtDiurna35.Text = "0";
            }
            else if (txtMinDiurna35.Text == "")
            {
                txtMinDiurna35.Text = "0";
            }
            else
            {
                double remuneracion = Double.Parse(txtHaberBasico.Text.ToString());
                double asignacion = Double.Parse(txtAsigFamiliar.Text.ToString());

                double precioPorHoraDiurna = ((remuneracion + asignacion) / 30) / 8;
                double recargo25 = precioPorHoraDiurna * 0.25;
                double total_recargo = precioPorHoraDiurna + recargo25;
                txtPrecioHoraDiurna25.Text = total_recargo.ToString("N2");

                double recargo35 = precioPorHoraDiurna * 0.35;
                double total_recargo35 = precioPorHoraDiurna + recargo35;
                txtPrecioHoraDiurna35.Text = total_recargo35.ToString("N2");

                double horadiurna35 = Double.Parse(txtDiurna35.Text.ToString());
                double mindiurna35 = Double.Parse(txtMinDiurna35.Text.ToString());

                double dias_mes = (remuneracion + asignacion) / 30;
                double horas_mes = dias_mes / 8;
                double minutos_mes = horas_mes / 60;

                double recargo35minutos = minutos_mes * 0.35;
                double sumarecargo35minutos = minutos_mes + recargo35minutos;

                double horaporsumarecargo35 = sumarecargo35minutos * mindiurna35;

                double horadiurna35_2 = (horadiurna35 * total_recargo35) + horaporsumarecargo35;
                txtTotalDiurna35.Text = horadiurna35_2.ToString("N2");

                double totalDiurna25 = Double.Parse(txtTotalDiurna25.Text);
                double totalDiurna35 = Double.Parse(txtTotalDiurna35.Text);

                double totalSumaDiurna = totalDiurna25 + totalDiurna35;
                txtTotalDiurna.Text = totalSumaDiurna.ToString("N2");
            }
        }

        private void txtNocturna25_TextChanged(object sender, EventArgs e)
        {
            if (txtNocturna25.Text == "")
            {
                txtNocturna25.Text = "0";
            }
            else if (txtMinNocturna25.Text == "")
            {
                txtMinNocturna25.Text = "0";
            }
            else
            {
                double remuneracion = Double.Parse(txtHaberBasico.Text.ToString());
                double asignacion = Double.Parse(txtAsigFamiliar.Text.ToString());

                double precioPorNocturna = ((((remuneracion + asignacion) + (remuneracion + asignacion) * 0.35)) / 30) / 8;
                double recargoNocturna25 = precioPorNocturna * 0.25;
                double totalRecargoNocturna = precioPorNocturna + recargoNocturna25;
                txtPrecioHoraNocturna25.Text = totalRecargoNocturna.ToString("N2");

                double recargoNocturna35 = precioPorNocturna * 0.35;
                double totalNocturnarecargo35 = precioPorNocturna + recargoNocturna35;
                txtPrecioHoraNocturna35.Text = totalNocturnarecargo35.ToString("N2");

                double horadiurna25 = Double.Parse(txtNocturna25.Text.ToString());
                double mindiurna25 = Double.Parse(txtMinNocturna25.Text.ToString());

                double dias_mes = (remuneracion + asignacion) / 30;
                double horas_mes = dias_mes / 8;
                double minutos_mes = horas_mes / 60;

                double recargo25minutos = minutos_mes * 0.25;
                double sumarecargo25minutos = minutos_mes + recargo25minutos;

                double horaporsumarecargo = (sumarecargo25minutos * mindiurna25) * 1.35;

                double horadiurna25_2 = (horadiurna25 * totalRecargoNocturna) + horaporsumarecargo;
                txtTotalNocturna25.Text = horadiurna25_2.ToString("N2");

                double totalDiurna25 = Double.Parse(txtTotalNocturna25.Text);
                double totalDiurna35 = Double.Parse(txtTotalNocturna35.Text);

                double totalSumaDiurna = totalDiurna25 + totalDiurna35;
                txtTotalNocturna.Text = totalSumaDiurna.ToString("N2");
            }
        }
        private static PlanillaMensual instance;

        public static PlanillaMensual GetInstance()
        {
            if (instance == null)
                instance = new PlanillaMensual();

            return instance;
        }

        

        private void txtNocturna35_TextChanged(object sender, EventArgs e)
        {
            if (txtNocturna35.Text == "")
            {
                txtNocturna35.Text = "0";
            }
            else if (txtMinNocturna35.Text == "")
            {
                txtMinNocturna35.Text = "0";
            }
            else
            {
                double remuneracion = Double.Parse(txtHaberBasico.Text.ToString());
                double asignacion = Double.Parse(txtAsigFamiliar.Text.ToString());

                double precioPorNocturna = ((((remuneracion + asignacion) + (remuneracion + asignacion) * 0.35)) / 30) / 8;
                double recargoNocturna25 = precioPorNocturna * 0.25;
                double totalRecargoNocturna = precioPorNocturna + recargoNocturna25;
                txtPrecioHoraNocturna25.Text = totalRecargoNocturna.ToString("N2");

                double recargoNocturna35 = precioPorNocturna * 0.35;
                double totalNocturnarecargo35 = precioPorNocturna + recargoNocturna35;
                txtPrecioHoraNocturna35.Text = totalNocturnarecargo35.ToString("N2");

                double horadiurna25 = Double.Parse(txtNocturna35.Text.ToString());
                double mindiurna25 = Double.Parse(txtMinNocturna35.Text.ToString());

                double dias_mes = (remuneracion + asignacion) / 30;
                double horas_mes = dias_mes / 8;
                double minutos_mes = horas_mes / 60;

                double recargo25minutos = minutos_mes * 0.35;
                double sumarecargo25minutos = minutos_mes + recargo25minutos;

                double horaporsumarecargo = (sumarecargo25minutos * mindiurna25) * 1.35;

                double horadiurna25_2 = (horadiurna25 * totalNocturnarecargo35) + horaporsumarecargo;
                txtTotalNocturna35.Text = horadiurna25_2.ToString("N2");

                double totalDiurna25 = Double.Parse(txtTotalNocturna25.Text);
                double totalDiurna35 = Double.Parse(txtTotalNocturna35.Text);

                double totalSumaDiurna = totalDiurna25 + totalDiurna35;
                txtTotalNocturna.Text = totalSumaDiurna.ToString("N2");
            }
        }

        private void txtMinNocturna35_TextChanged(object sender, EventArgs e)
        {
            if (txtNocturna35.Text == "")
            {
                txtNocturna35.Text = "0";
            }
            else if (txtMinNocturna35.Text == "")
            {
                txtMinNocturna35.Text = "0";
            }
            else
            {
                double remuneracion = Double.Parse(txtHaberBasico.Text.ToString());
                double asignacion = Double.Parse(txtAsigFamiliar.Text.ToString());

                double precioPorNocturna = ((((remuneracion + asignacion) + (remuneracion + asignacion) * 0.35)) / 30) / 8;
                double recargoNocturna25 = precioPorNocturna * 0.25;
                double totalRecargoNocturna = precioPorNocturna + recargoNocturna25;
                txtPrecioHoraNocturna25.Text = totalRecargoNocturna.ToString("N2");

                double recargoNocturna35 = precioPorNocturna * 0.35;
                double totalNocturnarecargo35 = precioPorNocturna + recargoNocturna35;
                txtPrecioHoraNocturna35.Text = totalNocturnarecargo35.ToString("N2");

                double horadiurna25 = Double.Parse(txtNocturna35.Text.ToString());
                double mindiurna25 = Double.Parse(txtMinNocturna35.Text.ToString());

                double dias_mes = (remuneracion + asignacion) / 30;
                double horas_mes = dias_mes / 8;
                double minutos_mes = horas_mes / 60;

                double recargo25minutos = minutos_mes * 0.35;
                double sumarecargo25minutos = minutos_mes + recargo25minutos;

                double horaporsumarecargo = (sumarecargo25minutos * mindiurna25) * 1.35;

                double horadiurna25_2 = (horadiurna25 * totalNocturnarecargo35) + horaporsumarecargo;
                txtTotalNocturna35.Text = horadiurna25_2.ToString("N2");

                double totalDiurna25 = Double.Parse(txtTotalNocturna25.Text);
                double totalDiurna35 = Double.Parse(txtTotalNocturna35.Text);

                double totalSumaDiurna = totalDiurna25 + totalDiurna35;
                txtTotalNocturna.Text = totalSumaDiurna.ToString("N2");
            }
        }

        private void txtHoraFeriado_TextChanged(object sender, EventArgs e)
        {
            if (txtHoraFeriado.Text == "")
            {
                txtHoraFeriado.Text = "0";
            }
            else if (txtMinFeriado.Text == "")
            {
                txtMinFeriado.Text = "0";
            }
            else
            {
                double remuneracion = Double.Parse(txtHaberBasico.Text.ToString());
                double asignacion = Double.Parse(txtAsigFamiliar.Text.ToString());

                double feriado = (((remuneracion + asignacion) / 30) / 8) * 2;
                txtPrecioHoraFeriado.Text = feriado.ToString("N2");

                double horadiurna25 = Double.Parse(txtHoraFeriado.Text.ToString());
                double mindiurna25 = Double.Parse(txtMinFeriado.Text.ToString());

                double dias_mes = (remuneracion + asignacion) / 30;
                double horas_mes = dias_mes / 8;
                double minutos_mes = horas_mes / 60;

                double recargo25minutos = minutos_mes * 2;
                double sumarecargo25minutos = minutos_mes + recargo25minutos;

                double horaporsumarecargo = (sumarecargo25minutos * mindiurna25);

                double horadiurna25_2 = (horadiurna25 * feriado) + horaporsumarecargo;
                txtTotalFeriado.Text = horadiurna25_2.ToString("N2");

            }
        }

        private void txtMinFeriado_TextChanged(object sender, EventArgs e)
        {
            if (txtHoraFeriado.Text == "")
            {
                txtHoraFeriado.Text = "0";
            }
            else if (txtMinFeriado.Text == "")
            {
                txtMinFeriado.Text = "0";
            }
            else
            {
                double remuneracion = Double.Parse(txtHaberBasico.Text.ToString());
                double asignacion = Double.Parse(txtAsigFamiliar.Text.ToString());

                double feriado = (((remuneracion + asignacion) / 30) / 8) * 2;
                txtPrecioHoraFeriado.Text = feriado.ToString("N2");

                double horadiurna25 = Double.Parse(txtHoraFeriado.Text.ToString());
                double mindiurna25 = Double.Parse(txtMinFeriado.Text.ToString());

                double dias_mes = (remuneracion + asignacion) / 30;
                double horas_mes = dias_mes / 8;
                double minutos_mes = horas_mes / 60;

                double recargo25minutos = minutos_mes * 2;

                double horaporsumarecargo = (recargo25minutos * mindiurna25);

                double horadiurna25_2 = (horadiurna25 * feriado) + horaporsumarecargo;
                txtTotalFeriado.Text = horadiurna25_2.ToString("N2");

            }
        }

        private void txtHoraBonificacionNocturna_TextChanged(object sender, EventArgs e)
        {
            if (txtHoraBonificacionNocturna.Text == "")
            {
                txtHoraBonificacionNocturna.Text = "0";
            }
            else if (txtMinBonificacionNocturna.Text == "")
            {
                txtMinBonificacionNocturna.Text = "0";
            }
            else
            {
                double remuneracion = Double.Parse(txtHaberBasico.Text.ToString());
                double asignacion = Double.Parse(txtAsigFamiliar.Text.ToString());

                double bonificacionNocturna = (((remuneracion + asignacion) / 30) / 8) * 0.35;
                txtPrecioHoraBoniNocturna.Text = bonificacionNocturna.ToString("N2");

                double horadiurna25 = Double.Parse(txtHoraBonificacionNocturna.Text.ToString());
                double mindiurna25 = Double.Parse(txtMinBonificacionNocturna.Text.ToString());

                double dias_mes = (remuneracion + asignacion) / 30;
                double horas_mes = dias_mes / 8;
                double minutos_mes = horas_mes / 60;

                double recargo25minutos = minutos_mes * 0.35;

                double horaporsumarecargo = (recargo25minutos * mindiurna25);

                double horadiurna25_2 = (horadiurna25 * bonificacionNocturna) + horaporsumarecargo;
                txtTotalBoniNocturna.Text = horadiurna25_2.ToString("N2");

            }
        }

        private void txtMinBonificacionNocturna_TextChanged(object sender, EventArgs e)
        {
            if (txtHoraBonificacionNocturna.Text == "")
            {
                txtHoraBonificacionNocturna.Text = "0";
            }
            else if (txtMinBonificacionNocturna.Text == "")
            {
                txtMinBonificacionNocturna.Text = "0";
            }
            else
            {
                double remuneracion = Double.Parse(txtHaberBasico.Text.ToString());
                double asignacion = Double.Parse(txtAsigFamiliar.Text.ToString());

                double bonificacionNocturna = (((remuneracion + asignacion) / 30) / 8) * 0.35;
                txtPrecioHoraBoniNocturna.Text = bonificacionNocturna.ToString("N2");

                double horadiurna25 = Double.Parse(txtHoraBonificacionNocturna.Text.ToString());
                double mindiurna25 = Double.Parse(txtMinBonificacionNocturna.Text.ToString());

                double dias_mes = (remuneracion + asignacion) / 30;
                double horas_mes = dias_mes / 8;
                double minutos_mes = horas_mes / 60;

                double recargo25minutos = minutos_mes * 0.35;

                double horaporsumarecargo = (recargo25minutos * mindiurna25);

                double horadiurna25_2 = (horadiurna25 * bonificacionNocturna) + horaporsumarecargo;
                txtTotalBoniNocturna.Text = horadiurna25_2.ToString("N2");

            }
        }

        private void txtHorasTardanza_TextChanged(object sender, EventArgs e)
        {
            if (txtHorasTardanza.Text == "")
            {
                txtHorasTardanza.Text = "0";
            }
            else if (txtMinTardanzas.Text == "")
            {
                txtMinTardanzas.Text = "0";
            }
            else
            {
                double remuneracion = Double.Parse(txtHaberBasico.Text.ToString());

                double tardanzas = ((remuneracion / 8) / 60) * 2;
                txtPrecioHoraTardanza.Text = tardanzas.ToString("N2");

                double horadiurna25 = Double.Parse(txtHorasTardanza.Text.ToString());
                double mindiurna25 = Double.Parse(txtMinTardanzas.Text.ToString());

                double dias_mes = remuneracion / 30;
                double horas_mes = dias_mes / 8;
                double minutos_mes = horas_mes / 60;


                double horaporsumarecargo = (minutos_mes * mindiurna25);

                double horadiurna25_2 = (horadiurna25 * tardanzas) + horaporsumarecargo;
                txtTotalTardanza.Text = horadiurna25_2.ToString("N2");

            }
        }

        private void txtMinTardanzas_TextChanged(object sender, EventArgs e)
        {
            if (txtHorasTardanza.Text == "")
            {
                txtHorasTardanza.Text = "0";
            }
            else if (txtMinTardanzas.Text == "")
            {
                txtMinTardanzas.Text = "0";
            }
            else
            {
                double remuneracion = Double.Parse(txtHaberBasico.Text.ToString());

                double tardanzas = ((remuneracion / 8) / 60) * 2;
                txtPrecioHoraTardanza.Text = tardanzas.ToString("N2");

                double horadiurna25 = Double.Parse(txtHorasTardanza.Text.ToString());
                double mindiurna25 = Double.Parse(txtMinTardanzas.Text.ToString());

                double dias_mes = remuneracion / 30;
                double horas_mes = dias_mes / 8;
                double minutos_mes = horas_mes / 60;


                double horaporsumarecargo = (minutos_mes * mindiurna25);

                double horadiurna25_2 = (horadiurna25 * tardanzas) + horaporsumarecargo;
                txtTotalTardanza.Text = horadiurna25_2.ToString("N2");


            }
        }

        private void btnSubsidiados_Click(object sender, EventArgs e)
        {
            frmDiasSubsidiados fr = frmDiasSubsidiados.GetInstance();
            fr.StartPosition = FormStartPosition.CenterParent;
            fr.ShowDialog();
        }
    }
}
