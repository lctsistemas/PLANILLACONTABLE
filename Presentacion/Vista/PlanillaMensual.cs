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
<<<<<<< HEAD
    public partial class PlanillaMensual : Form
    {
        public static String tipoform = "";
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
            txtAsigFamiliar.Text = "93";
            txtHaberBasico.Text = "930";
        }

        private void calculos_Remuneracion()
        {
            Double totalhorasdiurnas = Convert.ToDouble(txtTotalDiurna.Text);
            Double totalhorasnoct = Convert.ToDouble(txtTotalNocturna.Text);

            Double feriado_importe = Convert.ToDouble(txtTotalFeriado.Text);

            Double reintegro = Convert.ToDouble(txtReintegro.Text);
            Double tardanza_total = Convert.ToDouble(txtTotalTardanza.Text);
            Messages.M_info(""+totalremuneracion);
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
                calculos_Remuneracion();
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
            frmSubsiyNoSubsi fr = frmSubsiyNoSubsi.GetInstance();
            fr.txtmes.Text = this.txtmes.Text;
            fr.Text = "SUBSIDIADOS";
            fr.StartPosition = FormStartPosition.CenterParent;
            tipoform = "SUBSIDIADOS";
            fr.ShowDialog();
        }

        

        private void btnFaltas_Click(object sender, EventArgs e)
        {
            frmSubsiyNoSubsi fr = frmSubsiyNoSubsi.GetInstance();
            fr.Text = "NO LABORADOS / NO SUBSIDIADOS";
            fr.StartPosition = FormStartPosition.CenterParent;
            tipoform = "NO SUBSIDIADOS";
            fr.ShowDialog();
=======
    public partial class FrmPlanillaMensual : Form
    {
        
        public FrmPlanillaMensual()
        {
            InitializeComponent();
        }


        //TABLA
        private void TablaPlanilla() {
            dgvplanilla1.Columns["ape_nom"].Frozen = true;
            dgvplanilla2.Columns["valor1"].Frozen = true;
        
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dgvplanilla1.Rows.Add();
            //dgvplanilla1.BeginEdit(true);
        }

        private void dgvplanilla1_Scroll(object sender, ScrollEventArgs e)
        {
            dgvplanilla2.HorizontalScrollingOffset = dgvplanilla1.HorizontalScrollingOffset;
        }

        private void FrmPlanillaMensual_Load(object sender, EventArgs e)
        {
            TablaPlanilla();
            
        }

        //envento cuando una fila esta validando.
        private void dgvplanilla1_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (dgvplanilla1.CurrentRow != null)
            {
                if (dgvplanilla1.CurrentRow.Index < dgvplanilla1.Rows.Count -1 )
                {
                    if (dgvplanilla1.CurrentRow.Cells[6].Value != null)
                    {
                        if (dgvplanilla1.CurrentRow.Cells[6].Value.ToString() == "")
                        {
                            MessageBox.Show("El campo no puede estar vacío");
                            e.Cancel = true;
                            return;
                        }
                    }

                }
            }
        }

        private void dgvplanilla1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //decimal sueldo = 0, asig_fami = 0, Hdiurna25 = 0;
            //decimal subtotal = 0;

            //if (dgvplanilla1.Columns[e.ColumnIndex].Name=="sueldo")
            //{
            //    sueldo = decimal.Parse(dgvplanilla1.Rows[e.RowIndex].Cells["sueldo"].Value.ToString());
            //    asig_fami = decimal.Parse(dgvplanilla1.Rows[e.RowIndex].Cells["a_familiar"].Value.ToString());
            //    Hdiurna25 = decimal.Parse(dgvplanilla1.Rows[e.RowIndex].Cells[10].Value.ToString());
            //    subtotal = (sueldo + asig_fami + Hdiurna25);
            //    dgvplanilla1.Rows[e.RowIndex].Cells[35].Value = subtotal.ToString("#.##");//total remu.
            //}
            DataGridViewRow dar = dgvplanilla1.CurrentRow;

            switch (e.ColumnIndex)
             {
                case 7: //sueldo
                case 8: //asig fami      
                case 28: //monto subsidio
                case 31: //monto nega de subsi.
                case 33: //monto positi de subsi.
                case 34: //total horas extr.
                case 35: //reintegro
                case 36: // vacaciones
                case 37: // vaca trunca.
                case 38: // grati trunca.
                case 39: // boni trunca.
                case 40: // cts trunca.
                    try
                    {
                        double suel = 0, asigfami = 0, monto_sub = 0, montonegasub = 0, montoposisub = 0, totalHorasEx = 0;
                        double reintegr = 0, vacacion = 0, vaca_trun = 0, grati_tru = 0, boni_tru = 0, cts_tru = 0;
                        double subtotal1 = 0.00, subtotal2 = 0.00, totalsub = 0.00;                        

                        if (dar.Cells["sueldo"].Value == null)
                            suel = 0.00;
                        else
                            suel = Convert.ToDouble(dar.Cells["sueldo"].Value);


                        if (dar.Cells["a_familiar"].Value == null)
                            asigfami = 0.00;
                        else
                            asigfami = Convert.ToDouble(dar.Cells["a_familiar"].Value);


                        if (dar.Cells["montosub"].Value == null)
                            monto_sub = 0.00;
                        else
                            monto_sub = Convert.ToDouble(dar.Cells["montosub"].Value);


                        if (dar.Cells["montonega"].Value == null)
                            montonegasub = 0.00;
                        else
                            montonegasub = Convert.ToDouble(dar.Cells["montonega"].Value);


                        if (dar.Cells["montoposi"].Value == null)
                            montoposisub = 0.00;
                        else
                            montoposisub = Convert.ToDouble(dar.Cells["montoposi"].Value);


                        if (dar.Cells["montoposi"].Value == null)
                            montoposisub = 0.00;
                        else
                            montoposisub = Convert.ToDouble(dar.Cells["montoposi"].Value);


                        if (dar.Cells["thoras"].Value == null)
                            totalHorasEx = 0.00;
                        else
                            totalHorasEx = Convert.ToDouble(dar.Cells["thoras"].Value);


                        if (dar.Cells["reintegro"].Value == null)
                            reintegr = 0.00;
                        else
                            reintegr = Convert.ToDouble(dar.Cells["reintegro"].Value);


                        if (dar.Cells["vacaciones"].Value == null)
                            vacacion = 0.00;
                        else
                            vacacion = Convert.ToDouble(dar.Cells["vacaciones"].Value);


                        if (dar.Cells["tvaca"].Value == null)
                            vaca_trun = 0.00;
                        else
                            vaca_trun = Convert.ToDouble(dar.Cells["tvaca"].Value);


                        if (dar.Cells["tgrati"].Value == null)
                            grati_tru = 0.00;
                        else
                            grati_tru = Convert.ToDouble(dar.Cells["tgrati"].Value);


                        if (dar.Cells["tboni"].Value == null)
                            boni_tru = 0.00;
                        else
                            boni_tru = Convert.ToDouble(dar.Cells["tboni"].Value);


                        if (dar.Cells["tcts"].Value == null)
                            cts_tru = 0.00;
                        else
                            cts_tru = Convert.ToDouble(dar.Cells["tcts"].Value);

                        subtotal1 = (suel + asigfami + monto_sub + montoposisub + totalHorasEx);
                        subtotal2 = (reintegr + vacacion + vaca_trun + grati_tru + boni_tru + cts_tru);
                        totalsub = (subtotal1 + subtotal2 ) - montonegasub;

                        dar.Cells["totaremu"].Value = totalsub;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;

                default:
                    //dar.Cells["totaremu"].Value = 0.00;
                    break;
            }


            //TOTAL HORAS EXTRAS.
            switch (e.ColumnIndex)
            {
                case 11:
                case 14:
                case 17:
                case 20:
                case 23:
                case 25:                    
                    double montoD25 = 0, montoD35 = 0, montoN25 = 0, montoN35 = 0, feriado = 0, boniNoct = 0;
                    double totalHorasExt = 0;

                    //diurna de 25%
                    if (dar.Cells["montod25"].Value == null)
                        montoD25 = 0.00;
                    else
                        montoD25 = Convert.ToDouble(dar.Cells["montod25"].Value);

                    //diurna de 35%
                    if (dar.Cells["montod35"].Value == null)
                        montoD35 = 0.00;
                    else
                        montoD35 = Convert.ToDouble(dar.Cells["montod35"].Value);

                    //nocturno de 25%
                    if (dar.Cells["monton25"].Value == null)
                        montoN25 = 0.00;
                    else
                        montoN25 = Convert.ToDouble(dar.Cells["monton25"].Value);

                    //nocturno de 35%
                    if (dar.Cells["monton35"].Value == null)
                        montoN35 = 0.00;
                    else
                        montoN35 = Convert.ToDouble(dar.Cells["monton35"].Value);

                    //feriado
                    if (dar.Cells["montoferiado"].Value == null)
                        feriado = 0.00;
                    else
                        feriado = Convert.ToDouble(dar.Cells["montoferiado"].Value);

                    //bonificacion nocturna
                    if (dar.Cells["montoboninocturno"].Value == null)
                        boniNoct = 0.00;
                    else
                        boniNoct = Convert.ToDouble(dar.Cells["montoboninocturno"].Value);

                    //total horas extras.
                    totalHorasExt = (montoD25 + montoD35 + montoN25 + montoN35 + feriado + boniNoct);
                    dar.Cells["thoras"].Value = totalHorasExt.ToString();

                    break;
                default:
                    break;
            }

            //Calculo para Horas Extras y descuentos
            switch (e.ColumnIndex)
            {
                case 9:
                case 10:
                    double horxd25 = 0;
                    Int32 hora25=0, minu25 = 0;
                    if (dar.Cells["hxd25"].Value == null)
                        hora25 = 0;
                    else
                        hora25 = Convert.ToInt32(dar.Cells["hxd25"].Value);


                    if(dar.Cells["minud25"].Value == null)
                        minu25 = 0;
                    else
                        minu25 = Convert.ToInt32(dar.Cells["minud25"].Value);
                 
                    horxd25 = Calculo.HoraExDiurna(930, 0, 0.25, hora25, minu25);
                    dar.Cells["montod25"].Value = horxd25.ToString("0.##");
                    break;
                case 12:
                case 13:
                    double horxd35 = 0;
                    Int32 hora35 = 0, minu35 = 0;
                    if (dar.Cells["hxd35"].Value == null)
                        hora35 = 0;
                    else
                        hora35 = Convert.ToInt32(dar.Cells["hxd35"].Value);


                    if (dar.Cells["minud35"].Value == null)
                        minu35 = 0;
                    else
                        minu35 = Convert.ToInt32(dar.Cells["minud35"].Value);

                    horxd35 = Calculo.HoraExDiurna(930, 0, 0.35, hora35,minu35);
                    dar.Cells["montod35"].Value = horxd35.ToString("0.##");
                    break;
                case 15:
                case 16:
                    double horxn25 = 0;
                    Int32 nhora25 = 0, nminu25 = 0;
                    if (dar.Cells["hxn25"].Value == null)
                        nhora25 = 0;
                    else
                        nhora25 = Convert.ToInt32(dar.Cells["hxn25"].Value);


                    if (dar.Cells["minun25"].Value == null)
                        nminu25 = 0;
                    else
                        nminu25 = Convert.ToInt32(dar.Cells["minun25"].Value);

                    horxn25 = Calculo.HoraExNocturnas(930, 0, 0.25, nhora25, nminu25);
                    dar.Cells["monton25"].Value = horxn25.ToString("0.##");
                    break;

                case 18:
                case 19:
                    double horxn35 = 0;
                    Int32 nhora35 = 0, nminu35 = 0;
                    if (dar.Cells["hxn35"].Value == null)
                        nhora35 = 0;
                    else
                        nhora35 = Convert.ToInt32(dar.Cells["hxn35"].Value);


                    if (dar.Cells["minun35"].Value == null)
                        nminu35 = 0;
                    else
                        nminu35 = Convert.ToInt32(dar.Cells["minun35"].Value);

                    horxn35 = Calculo.HoraExNocturnas(930, 0, 0.35, nhora35, nminu35);
                    dar.Cells["monton35"].Value = horxn35.ToString("0.##");
                    break;

                case 21:
                case 22:
                    double hferi = 0;
                    Int32 horaferiado = 0, minutoferi = 0;
                    if (dar.Cells["hrferiado"].Value == null)
                        horaferiado = 0;
                    else
                        horaferiado = Convert.ToInt32(dar.Cells["hrferiado"].Value);


                    if (dar.Cells["minuferiado"].Value == null)
                        minutoferi = 0;
                    else
                        minutoferi = Convert.ToInt32(dar.Cells["minuferiado"].Value);

                    hferi = Calculo.FeriadoDom(930,0, horaferiado, minutoferi);
                    dar.Cells["montoferiado"].Value = hferi.ToString("0.##");
                    break;

                case 24:
                    double boninoc = 0;
                    int horanoc = 0;
                    if (dar.Cells["hrboninocturna"].Value == null)
                        horanoc = 0;
                    else
                        horanoc = Convert.ToInt32(dar.Cells["hrboninocturna"].Value);

                    boninoc = Calculo.BoniNocturno(930, 0, horanoc);
                    dar.Cells["montoboninocturno"].Value = boninoc.ToString("0.##");
                    break;

                case 26:
                case 27:
                    double importe_tarde = 0;
                    Int32 horatarde = 0, minutarde = 0;
                    if (dar.Cells["htarde"].Value == null)
                        horatarde = 0;
                    else
                        horatarde = Convert.ToInt32(dar.Cells["htarde"].Value);


                    if (dar.Cells["mtarde"].Value == null)
                        minutarde = 0;
                    else
                        minutarde = Convert.ToInt32(dar.Cells["mtarde"].Value);

                    importe_tarde = Calculo.Tardanza(930, horatarde, minutarde);
                    dar.Cells["montotarde"].Value = importe_tarde.ToString("0.##");
                    break;

                default:
                    break;
            }

        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
      
        private void tabplanilla_MouseDown(object sender, MouseEventArgs e)
        {
            WindowsMove.ReleaseCapture();
            WindowsMove.SendMessage(this.Handle, 0x112, 0xf012, 0);
>>>>>>> Carlos
        }
    }
}
