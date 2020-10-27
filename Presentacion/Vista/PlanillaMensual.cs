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

        private Double calculos_Remuneracion()
        {
            Double total_remuneracion=0.00;

            Double totalhorasdiurnas = Convert.ToDouble(txtTotalDiurna.Text);
            Double totalhorasnoct = Convert.ToDouble(txtTotalNocturna.Text);

            Double feriado_importe = Convert.ToDouble(txtTotalFeriado.Text);

            Double reintegro = Convert.ToDouble(txtReintegro.Text);
            Double tardanza_total = Convert.ToDouble(txtTotalTardanza.Text);
            Double bonificacion_nocturna = Convert.ToDouble(txtTotalBoniNocturna.Text);

            total_remuneracion = totalhorasdiurnas + totalhorasnoct + feriado_importe + reintegro + tardanza_total + bonificacion_nocturna;

            return total_remuneracion;
           // Messages.M_info(""+totalremuneracion);
        }

        private void txtDiurna25_TextChanged(object sender, EventArgs e)
        {
            if (nudDiurna25.Text == "")
            {
                nudDiurna25.Text = "0";
            }
            else if (nudMinDiurna25.Text == "")
            {
                nudMinDiurna25.Text = "0";
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

                double horadiurna25 = Double.Parse(nudDiurna25.Text.ToString());
                double mindiurna25 = Double.Parse(nudMinDiurna25.Text.ToString());

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
            if (nudDiurna25.Text == "")
            {
                nudDiurna25.Text = "0";
            }
            else if (nudMinDiurna25.Text == "")
            {
                nudMinDiurna25.Text = "0";
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

                double horadiurna25 = Double.Parse(nudDiurna25.Text.ToString());
                double mindiurna25 = Double.Parse(nudMinDiurna25.Text.ToString());

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
            if (nudDiurna35.Text == "")
            {
                nudDiurna35.Text = "0";
            }
            else if (nudMinDiurna25.Text == "")
            {
                nudMinDiurna25.Text = "0";
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

                double horadiurna35 = Double.Parse(nudDiurna35.Text.ToString());
                double mindiurna35 = Double.Parse(nudMinDiurna25.Text.ToString());

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
            if (nudDiurna35.Text == "")
            {
                nudDiurna35.Text = "0";
            }
            else if (nudMinDiurna25.Text == "")
            {
                nudMinDiurna25.Text = "0";
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

                double horadiurna35 = Double.Parse(nudDiurna35.Text.ToString());
                double mindiurna35 = Double.Parse(nudMinDiurna25.Text.ToString());

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
            if (nudNocturna25.Text == "")
            {
                nudNocturna25.Text = "0";
            }
            else if (nudMinNocturna25.Text == "")
            {
                nudMinNocturna25.Text = "0";
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

                double horadiurna25 = Double.Parse(nudNocturna25.Text.ToString());
                double mindiurna25 = Double.Parse(nudMinNocturna25.Text.ToString());

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
            if (nudNocturna35.Text == "")
            {
                nudNocturna35.Text = "0";
            }
            else if (nudMinNocturna25.Text == "")
            {
                nudMinNocturna25.Text = "0";
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

                double horadiurna25 = Double.Parse(nudNocturna35.Text.ToString());
                double mindiurna25 = Double.Parse(nudMinNocturna25.Text.ToString());

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
            if (nudNocturna35.Text == "")
            {
                nudNocturna35.Text = "0";
            }
            else if (nudMinNocturna25.Text == "")
            {
                nudMinNocturna25.Text = "0";
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

                double horadiurna25 = Double.Parse(nudNocturna35.Text.ToString());
                double mindiurna25 = Double.Parse(nudMinNocturna25.Text.ToString());

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


        private void txtHoraBonificacionNocturna_TextChanged(object sender, EventArgs e)
        {
            if (nudHoraBonificacionNocturna.Text == "")
            {
                nudHoraBonificacionNocturna.Text = "0";
            }
            else if (nudMinBonificacionNocturna.Text == "")
            {
                nudMinBonificacionNocturna.Text = "0";
            }
            else
            {
                double remuneracion = Double.Parse(txtHaberBasico.Text.ToString());
                double asignacion = Double.Parse(txtAsigFamiliar.Text.ToString());

                double bonificacionNocturna = (((remuneracion + asignacion) / 30) / 8) * 0.35;
                txtPrecioHoraBoniNocturna.Text = bonificacionNocturna.ToString("N2");

                double horadiurna25 = Double.Parse(nudHoraBonificacionNocturna.Text.ToString());
                double mindiurna25 = Double.Parse(nudMinBonificacionNocturna.Text.ToString());

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
            if (nudHoraBonificacionNocturna.Text == "")
            {
                nudHoraBonificacionNocturna.Text = "0";
            }
            else if (nudMinBonificacionNocturna.Text == "")
            {
                nudMinBonificacionNocturna.Text = "0";
            }
            else
            {
                double remuneracion = Double.Parse(txtHaberBasico.Text.ToString());
                double asignacion = Double.Parse(txtAsigFamiliar.Text.ToString());

                double bonificacionNocturna = (((remuneracion + asignacion) / 30) / 8) * 0.35;
                txtPrecioHoraBoniNocturna.Text = bonificacionNocturna.ToString("N2");

                double horadiurna25 = Double.Parse(nudHoraBonificacionNocturna.Text.ToString());
                double mindiurna25 = Double.Parse(nudMinBonificacionNocturna.Text.ToString());

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
            tardanzas();
        }

        private void txtMinTardanzas_TextChanged(object sender, EventArgs e)
        {
            tardanzas();
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

        private void Hora25()
        {
            double remuneracion = Double.Parse(txtHaberBasico.Text.ToString());
            double asignacion = Double.Parse(txtAsigFamiliar.Text.ToString());

            double precioPorHoraDiurna = ((remuneracion + asignacion) / 30) / 8;
            double recargo25 = precioPorHoraDiurna * 0.25;
            double total_recargo = precioPorHoraDiurna + recargo25;
            txtPrecioHoraDiurna25.Text = total_recargo.ToString("N2");

            /*double recargo35 = precioPorHoraDiurna * 0.35;
            double total_recargo35 = precioPorHoraDiurna + recargo35;
            txtPrecioHoraDiurna35.Text = total_recargo35.ToString("N2");*/

            double horadiurna25 = Double.Parse(nudDiurna25.Value.ToString());
            double mindiurna25 = Double.Parse(nudMinDiurna25.Value.ToString());

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

        private void Hora35()
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


            double horadiurna35 = Double.Parse(nudDiurna35.Value.ToString());
            double mindiurna35 = Double.Parse(nudMinDiurna35.Value.ToString());

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

        private void Hora25Nocturna()
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

            double horadiurna25 = Double.Parse(nudNocturna25.Value.ToString());
            double mindiurna25 = Double.Parse(nudMinNocturna25.Value.ToString());

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

        private void Hora35Nocturna()
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

            double horadiurna25 = Double.Parse(nudNocturna35.Value.ToString());
            double mindiurna25 = Double.Parse(nudMinNocturna35.Value.ToString());

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

        private void tardanzas()
        {
            /*if (nudHorasTardanza.Text == "") //aca tambien le cambio?
            {
                nudHorasTardanza.Text = "0";
            }
            else if (nudMinTardanza.Text == "")
            {
                nudMinTardanza.Text = "0";
            }
            else
            {*/
            double remuneracion = 930;//Double.Parse(txtHaberBasico.Text.ToString());

                double tardanzasH = ((remuneracion /30)/ 8);
                double tardanzasM = (tardanzasH / 60);
                txtPrecioHoraTardanza.Text = tardanzasH.ToString("N2");

                double horadiurna25 = Double.Parse(nudHorasTardanza.Value.ToString());
                double mindiurna25 = Double.Parse(nudMinTardanza.Value.ToString()); 

                //double dias_mes = remuneracion / 30;
                //double horas_mes = dias_mes / 8;
                //double minutos_mes = horas_mes / 60;


                double horaporsumarecargo = (tardanzasH * horadiurna25);

                double horadiurna25_2 = (tardanzasM * mindiurna25);
                
                double subtoTar = (horaporsumarecargo + horadiurna25_2);

                txtTotalTardanza.Text = subtoTar.ToString("N2");


            //}

            //return txtTotalTardanza.Text;
        }

        private void feriados()
        {
            double remuneracion = Double.Parse(txtHaberBasico.Text.ToString());
            double asignacion = Double.Parse(txtAsigFamiliar.Text.ToString());

            double feriadoH= (((remuneracion + asignacion) / 30) / 8);
            double feriadoM = ((feriadoH) / 60);
            double feriado = feriadoH * 2;
            
            txtPrecioHoraFeriado.Text = feriado.ToString("N2");

            double horadiurna25 = Double.Parse(nudHoraFeriado.Value.ToString());
            double mindiurna25 = Double.Parse(nudMinferiado.Value.ToString());

            /*double dias_mes = (remuneracion + asignacion) / 30;
            double horas_mes = dias_mes / 8;
            double minutos_mes = horas_mes / 60;*/

            double horaporsumarecargo = (feriadoH*2) * horadiurna25;
            double horamindiurna25 = (feriadoM * 2) * mindiurna25;

            double sumarecargo25minutos = horaporsumarecargo + horamindiurna25;


            /*double recargo25minutos = feriadoM * 2;
            double sumarecargo25minutos = feriadoM + recargo25minutos;

            double horaporsumarecargo = (sumarecargo25minutos * mindiurna25);

            double horadiurna25_2 = (horadiurna25 * feriado) + horaporsumarecargo;*/


            txtTotalFeriado.Text = sumarecargo25minutos.ToString("N2");
        }

        private void BonificacionNoct()
        {
            double remuneracion = Double.Parse(txtHaberBasico.Text.ToString());
            double asignacion = Double.Parse(txtAsigFamiliar.Text.ToString());

            double bonificacionNocturna = (((remuneracion + asignacion) / 30) / 8) * 0.35;
            txtPrecioHoraBoniNocturna.Text = bonificacionNocturna.ToString("N2");

            double horadiurna25 = Double.Parse(nudHoraBonificacionNocturna.Value.ToString());
            double mindiurna25 = Double.Parse(nudMinBonificacionNocturna.Value.ToString());

            double dias_mes = (remuneracion + asignacion) / 30;
            double horas_mes = dias_mes / 8;
            double minutos_mes = horas_mes / 60;

            double recargo25minutos = minutos_mes * 0.35;

            double horaporsumarecargo = (recargo25minutos * mindiurna25);

            double horadiurna25_2 = (horadiurna25 * bonificacionNocturna) + horaporsumarecargo;
            txtTotalBoniNocturna.Text = horadiurna25_2.ToString("N2");
        }

        

        private void btnFaltas_Click(object sender, EventArgs e)
        {
            frmSubsiyNoSubsi fr = frmSubsiyNoSubsi.GetInstance();
            fr.Text = "NO LABORADOS / NO SUBSIDIADOS";
            fr.StartPosition = FormStartPosition.CenterParent;
            tipoform = "NO SUBSIDIADOS";
            fr.ShowDialog();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Double total_remu = calculos_Remuneracion();
            MessageBox.Show(total_remu.ToString());
            
        }

        

        private void nudHorasTardanza_ValueChanged(object sender, EventArgs e)
        {
            tardanzas();
        }

        private void nudMinTardanza_ValueChanged(object sender, EventArgs e)
        {
            tardanzas();
        }

        private void nudHoraFeriado_ValueChanged(object sender, EventArgs e)
        {
            feriados();
        }

        private void nudMinferiado_ValueChanged(object sender, EventArgs e)
        {
            feriados();
        }

        private void nudDiurna25_ValueChanged(object sender, EventArgs e)
        {
            Hora25();
        }

        private void nudMinDiurna25_ValueChanged(object sender, EventArgs e)
        {
            Hora25();
        }

        private void nudDiurna35_ValueChanged(object sender, EventArgs e)
        {
            Hora35();
        }

        private void nudMinDiurna35_ValueChanged(object sender, EventArgs e)
        {
            Hora35();
        }

        private void nudNocturna25_ValueChanged(object sender, EventArgs e)
        {
            Hora25Nocturna();
        }

        private void nudMinNocturna25_ValueChanged(object sender, EventArgs e)
        {
            Hora25Nocturna();
        }

        private void nudNocturna35_ValueChanged(object sender, EventArgs e)
        {
            Hora35Nocturna();
        }

        private void nudMinNocturna35_ValueChanged(object sender, EventArgs e)
        {
            Hora35Nocturna();
        }

        private void nudHoraBonificacionNocturna_ValueChanged(object sender, EventArgs e)
        {
            BonificacionNoct();
        }

        private void nudMinBonificacionNocturna_ValueChanged(object sender, EventArgs e)
        {
            BonificacionNoct();
        }
    }
}
