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

using Negocio.Models;
using Comun.Cache;

namespace Presentacion.Vista
{
    public partial class FrmPlanillaMensual2 : Form
    {
        private const string Subsidiado = "SUBSIDIADOS";
        private const string NoSubsidiado = "NO SUBSIDIADOS";
        int suel { get; set; }
        public FrmPlanillaMensual2()
        {
            InitializeComponent();
            //dgvplanilla1.Rows.Add();
            dgvplanilla1.AutoGenerateColumns = false;
        }


        //METODO BORRR CEROS
        

        //TABLA
        private void TablaPlanilla() {
            dgvplanilla1.Columns["ape_nom"].Frozen = true;
            dgvplanilla2.Columns["valor1"].Frozen = true;

            dgvplanilla1.Columns["id_contrato"].Visible = false;
            dgvplanilla1.Columns["id_planilla_manto"].Visible = false;

            dgvplanilla1.Columns["dias"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvplanilla1.Columns["dia_dominical"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvplanilla1.Columns["hora_trabajada"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvplanilla1.Columns["montod25"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvplanilla1.Columns["montod25"].ReadOnly = true;
            dgvplanilla1.Columns["montod35"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvplanilla1.Columns["montod35"].ReadOnly = true;

            dgvplanilla1.Columns["monton25"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvplanilla1.Columns["monton25"].ReadOnly = true;
            dgvplanilla1.Columns["monton35"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvplanilla1.Columns["monton35"].ReadOnly = true;

            dgvplanilla1.Columns["montoferiado"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvplanilla1.Columns["montoferiado"].ReadOnly = true;

            dgvplanilla1.Columns["montoboninocturno"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvplanilla1.Columns["montoboninocturno"].ReadOnly = true;

            dgvplanilla1.Columns["montotarde"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvplanilla1.Columns["montotarde"].ReadOnly = true;

            //subsidios
            dgvplanilla1.Columns["ndias"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvplanilla1.Columns["ndias"].ReadOnly = true;
            dgvplanilla1.Columns["montosub"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvplanilla1.Columns["montosub"].ReadOnly = true;
            dgvplanilla1.Columns["ndiasnega"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvplanilla1.Columns["ndiasnega"].ReadOnly = true;
            dgvplanilla1.Columns["montonega"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvplanilla1.Columns["montonega"].ReadOnly = true;
            dgvplanilla1.Columns["ndiasposi"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvplanilla1.Columns["ndiasposi"].ReadOnly = true;
            dgvplanilla1.Columns["montoposi"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvplanilla1.Columns["montoposi"].ReadOnly = true;

            dgvplanilla1.Columns["thoras"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvplanilla1.Columns["thoras"].ReadOnly = true;

            dgvplanilla1.Columns["totaremu"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvplanilla1.Columns["totaremu"].ReadOnly = true;

            dgvplanilla1.Columns["reintegro"].DefaultCellStyle.Format = "##.##"; //NO FUN
        }

        //CARGAR DATAGRI
        
        private void FillTabla()
        {
            Nrol n = new Nrol();
            dgvplanilla1.DataSource = n.Getall();
            
        }

        //TOTAL REMUNERACION
        private void TotalRemuneracion()
        {
            DataGridViewRow dar = dgvplanilla1.CurrentRow;
            try
            {
                double suel = 0, asigfami = 0, monto_sub = 0, montonegasub = 0, montoposisub = 0, totalHorasEx = 0;
                double tardanzasub = 0, reintegr = 0, vacacion = 0, vaca_trun = 0, grati_tru = 0, boni_tru = 0, cts_tru = 0;
                double subtotal1 = 0, subtotal2 = 0, totalsub = 0;

                if (dar.Cells["sueldo"].Value == null)
                    suel = 0;
                else
                    suel = Convert.ToDouble(dar.Cells["sueldo"].Value);


                if (dar.Cells["a_familiar"].Value == null)
                    asigfami = 0;
                else
                    asigfami = Convert.ToDouble(dar.Cells["a_familiar"].Value);


                if (dar.Cells["montosub"].Value == null)
                    monto_sub = 0;
                else
                    monto_sub = Convert.ToDouble(dar.Cells["montosub"].Value);


                if (dar.Cells["montonega"].Value == null)
                    montonegasub = 0;
                else
                    montonegasub = Convert.ToDouble(dar.Cells["montonega"].Value);


                if (dar.Cells["montoposi"].Value == null)
                    montoposisub = 0;
                else
                    montoposisub = Convert.ToDouble(dar.Cells["montoposi"].Value);


                if (dar.Cells["montoposi"].Value == null)
                    montoposisub = 0;
                else
                    montoposisub = Convert.ToDouble(dar.Cells["montoposi"].Value);


                if (dar.Cells["montotarde"].Value == null)
                    tardanzasub = 0;
                else
                    tardanzasub = Convert.ToDouble(dar.Cells["montotarde"].Value);


                if (dar.Cells["thoras"].Value == null)
                    totalHorasEx = 0;
                else
                    totalHorasEx = Convert.ToDouble(dar.Cells["thoras"].Value);


                if (dar.Cells["reintegro"].Value == null)
                    reintegr = 0;
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


                /*if (dar.Cells["tcts"].Value == null)
                    cts_tru = 0.00;
                else
                    cts_tru = Convert.ToDouble(dar.Cells["tcts"].Value);*/

                subtotal1 = (suel + asigfami + monto_sub + montoposisub + totalHorasEx);
                subtotal2 = (reintegr + vacacion + vaca_trun + grati_tru + boni_tru + cts_tru);
                totalsub = (subtotal1 + subtotal2) - (montonegasub + tardanzasub);

                dar.Cells["totaremu"].Value = totalsub.ToString("N2");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            //FillTabla();          
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
            //Calculo para Horas Extras y descuentos
            switch (e.ColumnIndex)
            {
                case 13:
                case 14:
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
                    dar.Cells["montod25"].Value = horxd25.ToString("N2");
                    break;
                case 16:
                case 17:
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
                    dar.Cells["montod35"].Value = horxd35.ToString("N2");
                    break;
                case 19:
                case 20:
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
                    dar.Cells["monton25"].Value = horxn25.ToString("N2");
                    break;

                case 22:
                case 23:
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
                    dar.Cells["monton35"].Value = horxn35.ToString("N2");
                    break;

                case 25:
                case 26:                
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
                    dar.Cells["montoferiado"].Value = hferi.ToString("N2");
                    break;

                case 28:
                    double boninoc = 0;
                    int horanoc = 0, h_trabajada = 0;
                    if (dar.Cells["hrboninocturna"].Value == null)
                        horanoc = 0;
                    else
                        horanoc = Convert.ToInt32(dar.Cells["hrboninocturna"].Value);
                    
                    boninoc = Calculo.BoniNocturno(930, 0, horanoc);
                    h_trabajada = HorasDiarias(dar, horanoc);

                    dar.Cells["montoboninocturno"].Value = boninoc.ToString("N2");
                    dar.Cells["hora_trabajada"].Value = h_trabajada.ToString();
                    break;

                case 30:
                case 31:
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
                    dar.Cells["montotarde"].Value = importe_tarde.ToString("N2");
                    break;

                default:
                    break;
            }


            // TOTAL HORAS EXTRAS.
            switch (e.ColumnIndex)
            {
                case 13:
                case 14:
                case 16:
                case 17:
                case 19:
                case 20:
                case 22:
                case 23:
                case 25:
                case 26:
                case 28:

                    double montoD25 = 0, montoD35 = 0, montoN25 = 0, montoN35 = 0, feriado = 0, boniNoct = 0;
                    double totalHorasExt = 0;

                    //diurna de 25%
                    if (dar.Cells["montod25"].Value == null)
                        montoD25 = 0;
                    else
                        montoD25 = Convert.ToDouble(dar.Cells["montod25"].Value);

                    //diurna de 35%
                    if (dar.Cells["montod35"].Value == null)
                        montoD35 = 0;
                    else
                        montoD35 = Convert.ToDouble(dar.Cells["montod35"].Value);

                    //nocturno de 25%
                    if (dar.Cells["monton25"].Value == null)
                        montoN25 = 0;
                    else
                        montoN25 = Convert.ToDouble(dar.Cells["monton25"].Value);

                    //nocturno de 35%
                    if (dar.Cells["monton35"].Value == null)
                        montoN35 = 0;
                    else
                        montoN35 = Convert.ToDouble(dar.Cells["monton35"].Value);

                    //feriado
                    if (dar.Cells["montoferiado"].Value == null)
                        feriado = 0;
                    else
                        feriado = Convert.ToDouble(dar.Cells["montoferiado"].Value);

                    //bonificacion nocturna
                    if (dar.Cells["montoboninocturno"].Value == null)
                        boniNoct = 0;
                    else
                        boniNoct = Convert.ToDouble(dar.Cells["montoboninocturno"].Value);

                    //total horas extras.
                    totalHorasExt = (montoD25 + montoD35 + montoN25 + montoN35 + feriado + boniNoct);
                    dar.Cells["thoras"].Value = totalHorasExt.ToString("N2");

                    break;

                case 8:
                case 9:
                    int pboniNocturno = 0, hr_trabajada = 0;

                    if (dar.Cells["hrboninocturna"].Value == null)
                        pboniNocturno = 0;
                    else
                        pboniNocturno = Convert.ToInt32(dar.Cells["hrboninocturna"].Value);

                    hr_trabajada = HorasDiarias(dar, pboniNocturno);
                    dar.Cells["hora_trabajada"].Value = hr_trabajada.ToString();

                    break;
                    
                default:
                    break;
            }
            TotalRemuneracion();
        }
        
        //.........


        //METODO HORAS DIARIAS.
        private int HorasDiarias(DataGridViewRow dgr, int hrboninoc)
        {
            int pdias = 0, pdiaDominical = 0, horaTrabajada = 0;            
            if (dgr.Cells["dias"].Value == null)
                pdias = 0;
            else
                pdias = Convert.ToInt32(dgr.Cells["dias"].Value);


            if (dgr.Cells["dia_dominical"].Value == null)
                pdiaDominical = 0;
            else
                pdiaDominical = Convert.ToInt32(dgr.Cells["dia_dominical"].Value);

            horaTrabajada = (((pdias - pdiaDominical) * 8) - hrboninoc);

            return horaTrabajada;
        }

        //-----
        private void tabplanilla_MouseDown(object sender, MouseEventArgs e)
        {
            WindowsMove.ReleaseCapture();
            WindowsMove.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void tbtnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvplanilla1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                int dias = 0;
                double monto = 0;
                //MessageBox.Show(""+e.RowIndex);
                if (dgvplanilla1.Rows[e.RowIndex].Cells["btnsubsidio"].Selected)
                {
                    //Messages.M_info("seleccione el boton susbidio");
                    PlanillaCache.Subsidiado = Subsidiado;
                    FrmDiasSubsidiados2 fr2 = FrmDiasSubsidiados2.Getinstance();
                    this.AddOwnedForm(fr2);
                    fr2.ShowDialog(dgvplanilla1);

                    if (dgvplanilla1.Rows[e.RowIndex].Cells["ndias"].Value == null)
                        dias = 0;
                    else
                        dias = Convert.ToInt32(dgvplanilla1.Rows[e.RowIndex].Cells["ndias"].Value);

                    monto = Calculo.MontoSubsidios(dias,930,93);
                    dgvplanilla1.Rows[e.RowIndex].Cells["montosub"].Value = monto.ToString("N2");
                    TotalRemuneracion();
                }

                if (dgvplanilla1.Rows[e.RowIndex].Cells["btnnosubsidio"].Selected)
                {                    
                    PlanillaCache.Subsidiado = NoSubsidiado;
                    FrmDiasSubsidiados2 fr2 = FrmDiasSubsidiados2.Getinstance();

                    this.AddOwnedForm(fr2);
                    fr2.ShowDialog(dgvplanilla1);

                   //MONTO NEGATIVO.
                    if (dgvplanilla1.Rows[e.RowIndex].Cells["ndiasnega"].Value == null)
                        dias = 0;
                    else
                        dias = Convert.ToInt32(dgvplanilla1.Rows[e.RowIndex].Cells["ndiasnega"].Value);

                    monto = Calculo.MontoSubsidios(dias, 930);
                    dgvplanilla1.Rows[e.RowIndex].Cells["montonega"].Value = monto.ToString("N2");
                    
                    //MONTO POSITIVO
                    if (dgvplanilla1.Rows[e.RowIndex].Cells["ndiasposi"].Value == null)
                        dias = 0;
                    else
                        dias = Convert.ToInt32(dgvplanilla1.Rows[e.RowIndex].Cells["ndiasposi"].Value);

                    monto = Calculo.MontoSubsidios(dias, 930);
                    dgvplanilla1.Rows[e.RowIndex].Cells["montoposi"].Value = monto.ToString("N2");
                    TotalRemuneracion();
                }
            }
        }

        private void dgvplanilla1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           /* if (e.RowIndex != -1)
            {
                DataGridViewRow dar = dgvplanilla1.CurrentRow;
                if (dgvplanilla1.Rows[e.RowIndex].Cells["btnnosubsidio"].Selected)
                {
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

                    hferi = Calculo.FeriadoDom(930, 0, horaferiado, minutoferi);
                    dar.Cells["montoferiado"].Value = hferi.ToString("0.##");
                }
            }*/
        }

        private void dgvplanilla1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                /*DataGridViewRow dar = dgvplanilla1.CurrentRow;
                if (dgvplanilla1.Rows[e.RowIndex].Cells["btnnosubsidio"].Selected)
                {
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

                    hferi = Calculo.FeriadoDom(930, 0, horaferiado, minutoferi);
                    dar.Cells["montoferiado"].Value = hferi.ToString("0.##");
                }*/
               // MessageBox.Show("holalalacell enter");
            }

        }

        private void dgvplanilla1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex != -1)
            //{
            //    DataGridViewRow dar = dgvplanilla1.CurrentRow;
            //    if (dgvplanilla1.Rows[e.RowIndex].Cells["btnnosubsidio"].Selected)
            //    {
            //        double hferi = 0;
            //        Int32 horaferiado = 0, minutoferi = 0;
            //        if (dar.Cells["hrferiado"].Value == null)
            //            horaferiado = 0;
            //        else
            //            horaferiado = Convert.ToInt32(dar.Cells["hrferiado"].Value);


            //        if (dar.Cells["minuferiado"].Value == null)
            //            minutoferi = 0;
            //        else
            //            minutoferi = Convert.ToInt32(dar.Cells["minuferiado"].Value);

            //        hferi = Calculo.FeriadoDom(930, 0, horaferiado, minutoferi);
            //        dar.Cells["montoferiado"].Value = hferi.ToString("0.##");
            //    }
            //}

        }

        private void dgvplanilla1_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {

           // MessageBox.Show("cell state changed");
            
                //DataGridViewRow dar = dgvplanilla1.CurrentRow;
                //if (dar.Cells["btnnosubsidio"].Selected)
                //{
                //    double hferi = 0;
                //    Int32 horaferiado = 0, minutoferi = 0;
                //    if (dar.Cells["hrferiado"].Value == null)
                //        horaferiado = 0;
                //    else
                //        horaferiado = Convert.ToInt32(dar.Cells["hrferiado"].Value);


                //    if (dar.Cells["minuferiado"].Value == null)
                //        minutoferi = 0;
                //    else
                //        minutoferi = Convert.ToInt32(dar.Cells["minuferiado"].Value);

                //    hferi = Calculo.FeriadoDom(930, 0, horaferiado, minutoferi);
                //    dar.Cells["montoferiado"].Value = hferi.ToString("0.##");
                //}                        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TotalRemuneracion();
        }

        private void dgvplanilla1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
            
        }
    }
}
