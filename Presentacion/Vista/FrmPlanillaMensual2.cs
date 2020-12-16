﻿using Comun.Cache;
using Negocio.Models;
using Presentacion.Helps;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Presentacion.Vista
{
    public partial class FrmPlanillaMensual2 : Form
    {
        private const string Subsidiado = "SUBSIDIADOS";
        private const string NoSubsidiado = "NO SUBSIDIADOS";
        public int xdia_vacaciones = 0; // el valor es enviado desde el formulario susbidios.
        private static FrmPlanillaMensual2 _intancia;

        NplanillaM nplam;
        NConceptos nconcepto;
        public FrmPlanillaMensual2()
        {
            InitializeComponent();            
            Dgvplanilla1.AutoGenerateColumns = false;
            this.Dgvplanilla2.DoubleBuffered(true);
            this.Dgvplanilla1.DoubleBuffered(true);

        }

        //METODO LLAMAR FORMULARIO EN OTRO SIN CARGAR MUCHAS INSTANCIAS.
        public static FrmPlanillaMensual2 Getinstancia()
        {
            if (_intancia == null)
                _intancia = new FrmPlanillaMensual2();

            return _intancia;
        }

        //TABLA
        private void TablaPlanilla()
        {
            Dgvplanilla1.Columns["ape_nom"].Frozen = true;
            Dgvplanilla2.Columns["valor1"].Frozen = true;

            Dgvplanilla1.Columns["id_contrato"].Visible = false;//se registrara este id
            Dgvplanilla1.Columns["id_planilla_manto"].Visible = false;//sera para poder actualizar
            Dgvplanilla1.Columns["jornada_labo"].Visible = false;
            Dgvplanilla1.Columns["valor_comision"].Visible = false;
            Dgvplanilla1.Columns["valor_seguro"].Visible = false;
            Dgvplanilla1.Columns["valor_aporte"].Visible = false;
            Dgvplanilla1.Columns["cod_document"].Visible = false;

            Dgvplanilla1.Columns["remu"].DefaultCellStyle.Format = "N2";
            Dgvplanilla1.Columns["remu"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            Dgvplanilla1.Columns["a_familiar"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            Dgvplanilla1.Columns["dias"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Dgvplanilla1.Columns["dia_dominical"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Dgvplanilla1.Columns["hora_trabajada"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            Dgvplanilla1.Columns["montod25"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            Dgvplanilla1.Columns["montod25"].ReadOnly = true;
            Dgvplanilla1.Columns["montod35"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            Dgvplanilla1.Columns["montod35"].ReadOnly = true;

            Dgvplanilla1.Columns["monton25"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            Dgvplanilla1.Columns["monton25"].ReadOnly = true;
            Dgvplanilla1.Columns["monton35"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            Dgvplanilla1.Columns["monton35"].ReadOnly = true;

            Dgvplanilla1.Columns["montoferiado"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            Dgvplanilla1.Columns["montoferiado"].ReadOnly = true;

            Dgvplanilla1.Columns["montoboninocturno"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            Dgvplanilla1.Columns["montoboninocturno"].ReadOnly = true;

            Dgvplanilla1.Columns["montotarde"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            Dgvplanilla1.Columns["montotarde"].ReadOnly = true;

            //subsidios
            Dgvplanilla1.Columns["ndias"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Dgvplanilla1.Columns["ndias"].ReadOnly = true;
            Dgvplanilla1.Columns["montosub"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            Dgvplanilla1.Columns["montosub"].ReadOnly = true;
            Dgvplanilla1.Columns["ndiasnega"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Dgvplanilla1.Columns["ndiasnega"].ReadOnly = true;
            Dgvplanilla1.Columns["montonega"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            Dgvplanilla1.Columns["montonega"].ReadOnly = true;
            Dgvplanilla1.Columns["ndiasposi"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Dgvplanilla1.Columns["ndiasposi"].ReadOnly = true;
            Dgvplanilla1.Columns["montoposi"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            Dgvplanilla1.Columns["montoposi"].ReadOnly = true;

            Dgvplanilla1.Columns["thoras"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            Dgvplanilla1.Columns["thoras"].ReadOnly = true;

            Dgvplanilla1.Columns["totaremu"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            Dgvplanilla1.Columns["totaremu"].ReadOnly = true;

            //Dgvplanilla1.Columns["reintegro"].DefaultCellStyle.Format = "##.##"; //NO FUN
            // dgvplanilla1.Columns["hxdiurnas"].Background
        }

        //CARGAR DATAGRI        
        private void FillTabla()
        {
            using (nplam = new NplanillaM())
            {             
                nplam.PId_mes = PlanillaCache.p_idmes;
                nplam.PId_empreMaestra = UserCache.Codigo_empresa;
                nplam.PFecha_inicio = Convert.ToDateTime(TxtfechaInicio.Text);
                nplam.PFecha_fin = Convert.ToDateTime(TxtfechaFin.Text);
                Dgvplanilla1.DataSource = nplam.Show_planillaM(PlanillaCache.p_idplanilla);
            }

        }

        //TOTAL REMUNERACION
        private void TotalRemuneracion()
        {
            DataGridViewRow dar = Dgvplanilla1.CurrentRow;
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


                if (dar.Cells["vacacione"].Value == null)
                    vacacion = 0;
                else
                    vacacion = Convert.ToDouble(dar.Cells["vacacione"].Value);


                if (dar.Cells["tvaca"].Value == null)
                    vaca_trun = 0;
                else
                    vaca_trun = Convert.ToDouble(dar.Cells["tvaca"].Value);


                if (dar.Cells["tgrati"].Value == null)
                    grati_tru = 0;
                else
                    grati_tru = Convert.ToDouble(dar.Cells["tgrati"].Value);


                if (dar.Cells["tboni"].Value == null)
                    boni_tru = 0;
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
                MessageBox.Show(ex.ToString());
            }
        }

        // DESCUENTO O.N.P  Y A.F.P
        private void Descuento_aportes()
        {
            DataGridViewRow dgr = Dgvplanilla1.CurrentRow;

            double comi = 0, segu = 0, apor = 0, tremu = 0;
            double xcomi = 0, xsegu = 0, xapor = 0, xonp = 0;
            comi = (Convert.ToDouble(dgr.Cells["valor_comision"].Value) / 100);
            segu = (Convert.ToDouble(dgr.Cells["valor_seguro"].Value) / 100);
            apor = (Convert.ToDouble(dgr.Cells["valor_aporte"].Value) / 100);

            //MessageBox.Show("comi: " + comi + "\n segu: " + segu + "\n apor: " + apor);

            if (dgr.Cells["totaremu"].Value == null)
                tremu = 0;
            else
                tremu = Convert.ToDouble(dgr.Cells["totaremu"].Value);

            if (dgr.Cells["regi_pen"].Value.ToString() == "O.N.P")
            {
                xonp = (tremu * comi);
                dgr.Cells["onp"].Value = xonp.ToString("N2");
            }
            else
            {
                xcomi = (tremu * comi);
                xsegu = (tremu * segu);
                xapor = (tremu * apor);
                dgr.Cells["comision"].Value = xcomi.ToString("N2");
                dgr.Cells["seguro"].Value = xsegu.ToString("N2");
                dgr.Cells["spp"].Value = xapor.ToString("N2");
            }
        }

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

        private void button1_Click(object sender, EventArgs e)
        {
            Dgvplanilla1.Rows.Add();
            //dgvplanilla1.BeginEdit(true);
        }

      
        private void FrmPlanillaMensual_Load(object sender, EventArgs e)
        {
            CheckConceptos();
            FillTabla();
            TablaPlanilla();
            Tooltip.Title(Picsave_conceptos, "Guardar cambios", false);
            TxtfechaInicio.ReadOnly = true;
            TxtfechaFin.ReadOnly = true;
            Txtpago.ReadOnly = true;
        }

        // INICIO DE ENVENTOS DATAGRIDVIEW.
        private void Dgvplanilla1_Scroll(object sender, ScrollEventArgs e)
        {
            Dgvplanilla2.HorizontalScrollingOffset = Dgvplanilla1.HorizontalScrollingOffset;
        }

        private void Dgvplanilla1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
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

            DataGridViewRow dar = Dgvplanilla1.CurrentRow;
            //Calculo para Horas Extras y descuentos
            switch (e.ColumnIndex)
            {
                case 17:
                case 18:
                    double horxd25 = 0;
                    Int32 hora25 = 0, minu25 = 0;
                    if (dar.Cells["hxd25"].Value == null)
                        hora25 = 0;
                    else
                        hora25 = Convert.ToInt32(dar.Cells["hxd25"].Value);


                    if (dar.Cells["minud25"].Value == null)
                        minu25 = 0;
                    else
                        minu25 = Convert.ToInt32(dar.Cells["minud25"].Value);

                    horxd25 = Calculo.HoraExDiurna(930, 0, 0.25, hora25, minu25);
                    dar.Cells["montod25"].Value = horxd25.ToString("N2");
                    break;
                case 20:
                case 21:
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

                    horxd35 = Calculo.HoraExDiurna(930, 0, 0.35, hora35, minu35);
                    dar.Cells["montod35"].Value = horxd35.ToString("N2");
                    break;
                case 23:
                case 24:
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

                case 26:
                case 27:
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

                case 29:
                case 30:
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
                    dar.Cells["montoferiado"].Value = hferi.ToString("N2");
                    break;

                case 32:
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

                case 35:
                case 36:
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
                case 17:
                case 18:
                case 20:
                case 21:
                case 23:
                case 24:
                case 26:
                case 27:
                case 29:
                case 30:
                case 32:

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

                case 12:
                case 13:
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
            Descuento_aportes();
        }

        private void Dgvplanilla1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                int dias = 0;
                double monto = 0, monto_v = 0;
                double xvacaciones = 0; //prueba

                //MessageBox.Show(""+e.RowIndex);
                if (Dgvplanilla1.Rows[e.RowIndex].Cells["btnsubsidio"].Selected)
                {
                    //Messages.M_info("seleccione el boton susbidio");
                    PlanillaCache.Subsidiado = Subsidiado;
                    PlanillaCache.p_idempleado = Convert.ToInt32(Dgvplanilla1.Rows[e.RowIndex].Cells["id_contrato"].Value);
                    FrmDiasSubsidiados2 fr2 = FrmDiasSubsidiados2.Getinstance();
                    this.AddOwnedForm(fr2);
                    fr2.lblcodigo_empledo.Text = Dgvplanilla1.Rows[e.RowIndex].Cells["cod_document"].Value.ToString() +" - "+ Dgvplanilla1.Rows[e.RowIndex].Cells["codigo"].Value.ToString();
                    fr2.lblnombre_empleado.Text = Dgvplanilla1.Rows[e.RowIndex].Cells["ape_nom"].Value.ToString();
                    fr2.ShowDialog();

                    if (Dgvplanilla1.Rows[e.RowIndex].Cells["ndias"].Value == null)
                        dias = 0;
                    else
                        dias = Convert.ToInt32(Dgvplanilla1.Rows[e.RowIndex].Cells["ndias"].Value);

                    monto = Calculo.MontoSubsidios(dias, 930, 93);
                    Dgvplanilla1.Rows[e.RowIndex].Cells["montosub"].Value = monto.ToString("N2");
                    TotalRemuneracion();
                }

                if (Dgvplanilla1.Rows[e.RowIndex].Cells["btnnosubsidio"].Selected)
                {
                    PlanillaCache.Subsidiado = NoSubsidiado;
                    PlanillaCache.p_idempleado = Convert.ToInt32(Dgvplanilla1.Rows[e.RowIndex].Cells["id_contrato"].Value);
                    FrmDiasSubsidiados2 fr2 = FrmDiasSubsidiados2.Getinstance();
                    this.AddOwnedForm(fr2);
                    fr2.lblcodigo_empledo.Text = Dgvplanilla1.Rows[e.RowIndex].Cells["cod_document"].Value.ToString() + " - " + Dgvplanilla1.Rows[e.RowIndex].Cells["codigo"].Value.ToString();
                    fr2.lblnombre_empleado.Text = Dgvplanilla1.Rows[e.RowIndex].Cells["ape_nom"].Value.ToString();
                    fr2.ShowDialog();

                    //MONTO NEGATIVO.
                    if (Dgvplanilla1.Rows[e.RowIndex].Cells["ndiasnega"].Value == null)
                        dias = 0;
                    else
                        dias = Convert.ToInt32(Dgvplanilla1.Rows[e.RowIndex].Cells["ndiasnega"].Value);

                    monto = Calculo.MontoSubsidios(dias, 930);
                    Dgvplanilla1.Rows[e.RowIndex].Cells["montonega"].Value = monto.ToString("N2");

                    //MONTO POSITIVO
                    if (Dgvplanilla1.Rows[e.RowIndex].Cells["ndiasposi"].Value == null)
                        dias = 0;
                    else
                        dias = Convert.ToInt32(Dgvplanilla1.Rows[e.RowIndex].Cells["ndiasposi"].Value);

                    xvacaciones = Calculo.MontoSubsidios(xdia_vacaciones, 930);
                    monto = Calculo.MontoSubsidios(dias, 930);

                    monto_v = (monto - xvacaciones);
                    Dgvplanilla1.Rows[e.RowIndex].Cells["montoposi"].Value = monto_v.ToString("N2");
                    TotalRemuneracion();
                }
            }
        }        
        //.........

        private void tbtnsalir_Click(object sender, EventArgs e)
        {
            FrmPlanillaEmpleados plaem = (FrmPlanillaEmpleados)Owner;

            plaem.btncerrar.Enabled = true;
            plaem.toolmenu.Visible = true;
            this.Close();
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


        private void menuarchivos_MouseDown(object sender, MouseEventArgs e)
        {
            WindowsMove.ReleaseCapture();
            WindowsMove.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void tollistaconceptos_Click(object sender, EventArgs e)
        {
            grobconceptos.Visible = tollistaconceptos.Checked;

        }

        private void tolbarraerramientas_Click(object sender, EventArgs e)
        {
            toolbotones.Visible = tolbarraerramientas.Checked;
        }

        private void btnver_Click(object sender, EventArgs e)
        {

            //if (dgvplanilla1.CurrentRow.Cells["a_familiar"].Value == null)
            //{
            //    MessageBox.Show("del data es null");

            //}else if(dgvplanilla1.CurrentRow.Cells["a_familiar"].Value.ToString() == string.Empty)
            //{
            //    MessageBox.Show("el valor no es null esta vacio.");
            //}
            //else
            //{

            //    MessageBox.Show("el valor no es null");
            //}

            Descuento_aportes();
        }


        #region METODOS PARA CONCEPTOS ADD AND SHOW.

        private void Picsave_conceptos_Click(object sender, EventArgs e)
        {
            //DataGridViewCellContextMenuStripNeededEventArgs
            string mensaje = "";
            using (nconcepto = new NConceptos())
            {
                if (Txtidconcepto.Text.Trim() != string.Empty)
                    nconcepto.Id_conceptos = Convert.ToInt32(Txtidconcepto.Text);

                nconcepto.Id_mes = 2;
                nconcepto.Id_planilla = 2;
                nconcepto.HextraDiurna = Chkhdiurnas.Checked;
                nconcepto.HextraNocturna = Chkhnocturna.Checked;
                nconcepto.FeriadoDomi = Chkferiado.Checked;
                nconcepto.BoniNoctur = Chkboni_nocturna.Checked;
                nconcepto.PrimeroMayo = Chkprimeromayo.Checked;
                nconcepto.Tarda = Chktardanza.Checked;
                nconcepto.Subsidi = Chksubsidio.Checked;
                nconcepto.Thoraex = Chktotal_extras.Checked;
                nconcepto.Otroreinte = Chkotro_reintegro.Checked;
                nconcepto.Prest_aliment = Chkpres_alime.Checked;
                nconcepto.Gratif = Chkgrati.Checked;
                nconcepto.Vaca = Chkvaca.Checked;
                nconcepto.Trunca = Chktrunca.Checked;
                nconcepto.Reinte_gratiboni = Chkrgrati.Checked;
                nconcepto.Essa_vida = Chkessavida.Checked;
                nconcepto.Adela = Chkadelanto.Checked;
                nconcepto.Presta = Chkprestamo.Checked;
                nconcepto.Rentquinta = Chkrentaquinta.Checked;
                nconcepto.Reten_judici = Chkretencion_judi.Checked;
                nconcepto.Otrodescu = Chkotro_descuento.Checked;
                nconcepto.Recarg_consu = Chkrecar_consumo.Checked;
                mensaje = nconcepto.SaveChanges();
                Lblsave_estado.Text = mensaje;

            }
        }


        private void CheckConceptos()
        {
            List<NConceptos> li;
            using (nconcepto = new NConceptos())
            {
                nconcepto.Id_mes = 2;
                nconcepto.Id_planilla = 2;
                li = nconcepto.Getall();
                this.Txtidconcepto.Text = li[0].Id_conceptos.ToString();
                this.Chkhdiurnas.Checked = Convert.ToBoolean(li[0].HextraDiurna);
                this.Chkhnocturna.Checked = Convert.ToBoolean(li[0].HextraNocturna);
                this.Chkferiado.Checked = Convert.ToBoolean(li[0].FeriadoDomi);
                this.Chkboni_nocturna.Checked = Convert.ToBoolean(li[0].BoniNoctur);
                this.Chkprimeromayo.Checked = Convert.ToBoolean(li[0].PrimeroMayo);
                this.Chktardanza.Checked = Convert.ToBoolean(li[0].Tarda);
                this.Chksubsidio.Checked = Convert.ToBoolean(li[0].Subsidi);
                this.Chktotal_extras.Checked = Convert.ToBoolean(li[0].Thoraex);
                this.Chkotro_reintegro.Checked = Convert.ToBoolean(li[0].Otroreinte);
                this.Chkpres_alime.Checked = Convert.ToBoolean(li[0].Prest_aliment);
                this.Chkgrati.Checked = Convert.ToBoolean(li[0].Gratif);
                this.Chkvaca.Checked = Convert.ToBoolean(li[0].Vaca);
                this.Chktrunca.Checked = Convert.ToBoolean(li[0].Trunca);
                this.Chkrgrati.Checked = Convert.ToBoolean(li[0].Reinte_gratiboni);
                this.Chkessavida.Checked = Convert.ToBoolean(li[0].Essa_vida);
                this.Chkadelanto.Checked = Convert.ToBoolean(li[0].Adela);
                this.Chkprestamo.Checked = Convert.ToBoolean(li[0].Presta);
                this.Chkrentaquinta.Checked = Convert.ToBoolean(li[0].Rentquinta);
                this.Chkretencion_judi.Checked = Convert.ToBoolean(li[0].Reten_judici);
                this.Chkotro_descuento.Checked = Convert.ToBoolean(li[0].Otrodescu);
                this.Chkrecar_consumo.Checked = Convert.ToBoolean(li[0].Recarg_consu);

            }
        }


        private void Picsave_conceptos_MouseLeave(object sender, EventArgs e)
        {
            Lblsave_estado.Text = string.Empty;
        }
        #endregion



        #region CHECKED CONCEPTOS PARA LOS CAMPOS DE LA PLANILLA
        private void Chkhdiurnas_CheckedChanged(object sender, EventArgs e)
        {
            if (Chkhdiurnas.Checked == true)
                HorasDirunas(false);
            else
                HorasDirunas(true);
            Dgvplanilla2.HorizontalScrollingOffset = Dgvplanilla1.HorizontalScrollingOffset;
        }

        private void Chkhnocturna_CheckedChanged(object sender, EventArgs e)
        {
            if (Chkhnocturna.Checked == true)
                HorasNocturnas(false);
            else
                HorasNocturnas(true);
            Dgvplanilla2.HorizontalScrollingOffset = Dgvplanilla1.HorizontalScrollingOffset;
        }

        private void Chkferiado_CheckedChanged(object sender, EventArgs e)
        {
            if (Chkferiado.Checked == true)
                FeriadoDominical(false);
            else
                FeriadoDominical(true);
            Dgvplanilla2.HorizontalScrollingOffset = Dgvplanilla1.HorizontalScrollingOffset;
        }

        private void Chkboni_nocturna_CheckedChanged(object sender, EventArgs e)
        {
            if (Chkboni_nocturna.Checked == true)
                BoniNocturna(false);
            else
                BoniNocturna(true);
            Dgvplanilla2.HorizontalScrollingOffset = Dgvplanilla1.HorizontalScrollingOffset;
        }

        private void Chkprimeromayo_CheckedChanged(object sender, EventArgs e)
        {
            if (Chkprimeromayo.Checked == true)
                PrimeroMayo(false);
            else
                PrimeroMayo(true);
            Dgvplanilla2.HorizontalScrollingOffset = Dgvplanilla1.HorizontalScrollingOffset;
        }

        private void Chktardanza_CheckedChanged(object sender, EventArgs e)
        {
            if (Chktardanza.Checked == true)
                Tardanza(false);
            else
                Tardanza(true);
            Dgvplanilla2.HorizontalScrollingOffset = Dgvplanilla1.HorizontalScrollingOffset;

        }

        private void Chksubsidio_CheckedChanged(object sender, EventArgs e)
        {
            if (Chksubsidio.Checked == true)
                Subsidios(false);
            else
                Subsidios(true);
            Dgvplanilla2.HorizontalScrollingOffset = Dgvplanilla1.HorizontalScrollingOffset;
        }

        private void Chktotal_extras_CheckedChanged(object sender, EventArgs e)
        {
            if (Chktotal_extras.Checked == true)
                TotalHorasExtras(false);
            else
                TotalHorasExtras(true);
            Dgvplanilla2.HorizontalScrollingOffset = Dgvplanilla1.HorizontalScrollingOffset;
        }

        private void Chkotro_reintegro_CheckedChanged(object sender, EventArgs e)
        {
            if (Chkotro_reintegro.Checked == true)
                OtroReintegro(false);
            else
                OtroReintegro(true);
            Dgvplanilla2.HorizontalScrollingOffset = Dgvplanilla1.HorizontalScrollingOffset;
        }

        private void Chkpres_alime_CheckedChanged(object sender, EventArgs e)
        {
            if (Chkpres_alime.Checked == true)
                PrestacionAlimentaria(false);
            else
                PrestacionAlimentaria(true);
            Dgvplanilla2.HorizontalScrollingOffset = Dgvplanilla1.HorizontalScrollingOffset;
        }

        private void Chkgrati_CheckedChanged(object sender, EventArgs e)
        {
            if (Chkgrati.Checked == true)
                Gratificacion(false);
            else
                Gratificacion(true);
            Dgvplanilla2.HorizontalScrollingOffset = Dgvplanilla1.HorizontalScrollingOffset;
        }

        private void Chkvaca_CheckedChanged(object sender, EventArgs e)
        {
            if (Chkvaca.Checked == true)
                Vacaciones(false);
            else
                Vacaciones(true);
            Dgvplanilla2.HorizontalScrollingOffset = Dgvplanilla1.HorizontalScrollingOffset;
        }

        private void Chktrunca_CheckedChanged(object sender, EventArgs e)
        {
            if (Chktrunca.Checked == true)
                Truncas(false);
            else
                Truncas(true);
            Dgvplanilla2.HorizontalScrollingOffset = Dgvplanilla1.HorizontalScrollingOffset;
        }

        private void Chkrgrati_CheckedChanged(object sender, EventArgs e)
        {
            if (Chkrgrati.Checked == true)
                ReintegroGrati(false);
            else
                ReintegroGrati(true);
            Dgvplanilla2.HorizontalScrollingOffset = Dgvplanilla1.HorizontalScrollingOffset;
        }

        private void Chkessavida_CheckedChanged(object sender, EventArgs e)
        {
            if (Chkessavida.Checked == true)
                EssaludVida(false);
            else
                EssaludVida(true);
            Dgvplanilla2.HorizontalScrollingOffset = Dgvplanilla1.HorizontalScrollingOffset;
        }

        private void Chkadelanto_CheckedChanged(object sender, EventArgs e)
        {
            if (Chkadelanto.Checked == true)
                Adelanto(false);
            else
                Adelanto(true);
            Dgvplanilla2.HorizontalScrollingOffset = Dgvplanilla1.HorizontalScrollingOffset;
        }

        private void Chkprestamo_CheckedChanged(object sender, EventArgs e)
        {
            if (Chkprestamo.Checked == true)
                Prestamo(false);
            else
                Prestamo(true);
            Dgvplanilla2.HorizontalScrollingOffset = Dgvplanilla1.HorizontalScrollingOffset;
        }

        private void Chkrentaquinta_CheckedChanged(object sender, EventArgs e)
        {
            if (Chkrentaquinta.Checked == true)
                RentaQuinta(false);
            else
                RentaQuinta(true);
            Dgvplanilla2.HorizontalScrollingOffset = Dgvplanilla1.HorizontalScrollingOffset;
        }

        private void Chkretencion_judi_CheckedChanged(object sender, EventArgs e)
        {
            if (Chkretencion_judi.Checked == true)
                RetencionJudicial(false);
            else
                RetencionJudicial(true);
            Dgvplanilla2.HorizontalScrollingOffset = Dgvplanilla1.HorizontalScrollingOffset;
        }

        private void Chkotro_descuento_CheckedChanged(object sender, EventArgs e)
        {
            if (Chkotro_descuento.Checked == true)
                OtrosDescuentos(false);
            else
                OtrosDescuentos(true);
            Dgvplanilla2.HorizontalScrollingOffset = Dgvplanilla1.HorizontalScrollingOffset;
        }

        private void Chkrecar_consumo_CheckedChanged(object sender, EventArgs e)
        {
            if (Chkrecar_consumo.Checked == true)
                RecargoConsumo(false);
            else
                RecargoConsumo(true);
            Dgvplanilla2.HorizontalScrollingOffset = Dgvplanilla1.HorizontalScrollingOffset;
        }
        #endregion


        #region METODOS PARA OCULTAR COLUMNAS DE LA TABLA
        private void HorasDirunas(bool v)
        {
            Dgvplanilla2.Columns["hxdiurnas"].Visible = v;
            Dgvplanilla1.Columns["hxd25"].Visible = v;
            Dgvplanilla1.Columns["minud25"].Visible = v;
            Dgvplanilla1.Columns["montod25"].Visible = v;
            Dgvplanilla1.Columns["hxd35"].Visible = v;
            Dgvplanilla1.Columns["minud35"].Visible = v;
            Dgvplanilla1.Columns["montod35"].Visible = v;
        }

        private void HorasNocturnas(bool v)
        {
            Dgvplanilla2.Columns["hxnocturnas"].Visible = v;
            Dgvplanilla1.Columns["hxn25"].Visible = v;
            Dgvplanilla1.Columns["minun25"].Visible = v;
            Dgvplanilla1.Columns["monton25"].Visible = v;
            Dgvplanilla1.Columns["hxn35"].Visible = v;
            Dgvplanilla1.Columns["minun35"].Visible = v;
            Dgvplanilla1.Columns["monton35"].Visible = v;
        }

        private void FeriadoDominical(bool v)
        {
            Dgvplanilla2.Columns["feriado"].Visible = v;
            Dgvplanilla1.Columns["hrferiado"].Visible = v;
            Dgvplanilla1.Columns["minuferiado"].Visible = v;
            Dgvplanilla1.Columns["montoferiado"].Visible = v;
        }

        private void BoniNocturna(bool v)
        {
            Dgvplanilla2.Columns["boninocturno"].Visible = v;
            Dgvplanilla1.Columns["hrboninocturna"].Visible = v;
            Dgvplanilla1.Columns["montoboninocturno"].Visible = v;
        }

        private void PrimeroMayo(bool v)
        {
            Dgvplanilla2.Columns["primermayo"].Visible = v;
            Dgvplanilla1.Columns["unomayo"].Visible = v;
        }

        private void Tardanza(bool v)
        {
            Dgvplanilla2.Columns["tardanz"].Visible = v;
            Dgvplanilla1.Columns["htarde"].Visible = v;
            Dgvplanilla1.Columns["mtarde"].Visible = v;
            Dgvplanilla1.Columns["montotarde"].Visible = v;
        }

        private void Subsidios(bool v)
        {
            Dgvplanilla2.Columns["subsi"].Visible = v;
            Dgvplanilla1.Columns["btnsubsidio"].Visible = v;
            Dgvplanilla1.Columns["ndias"].Visible = v;
            Dgvplanilla1.Columns["montosub"].Visible = v;
        }

        private void TotalHorasExtras(bool v)
        {
            Dgvplanilla2.Columns["thorax"].Visible = v;
            Dgvplanilla1.Columns["thoras"].Visible = v;
        }

        private void OtroReintegro(bool v)
        {
            Dgvplanilla2.Columns["dreintegro"].Visible = v;
            Dgvplanilla1.Columns["otros_reintegros"].Visible = v;
        }

        private void PrestacionAlimentaria(bool v)
        {
            Dgvplanilla2.Columns["pres_alimen"].Visible = v;
            Dgvplanilla1.Columns["prestacion_alimenta"].Visible = v;
        }

        private void Gratificacion(bool v)
        {
            Dgvplanilla2.Columns["grati_boni"].Visible = v;
            Dgvplanilla1.Columns["grati"].Visible = v;
            Dgvplanilla1.Columns["boni"].Visible = v;
        }

        private void Vacaciones(bool v)
        {
            Dgvplanilla2.Columns["dvaca"].Visible = v;
            Dgvplanilla1.Columns["vacacione"].Visible = v;
        }


        private void Truncas(bool v)
        {
            Dgvplanilla2.Columns["dtrunca"].Visible = v;
            Dgvplanilla1.Columns["tvaca"].Visible = v;
            Dgvplanilla1.Columns["tgrati"].Visible = v;
            Dgvplanilla1.Columns["tboni"].Visible = v;
            Dgvplanilla1.Columns["tcts"].Visible = v;
        }

        private void ReintegroGrati(bool v)
        {
            Dgvplanilla2.Columns["r_grati_boni"].Visible = v;
            Dgvplanilla1.Columns["reintegro_grati"].Visible = v;
            Dgvplanilla1.Columns["reintegro_boni"].Visible = v;
        }

        private void EssaludVida(bool v)
        {
            Dgvplanilla2.Columns["dvida"].Visible = v;
            Dgvplanilla1.Columns["essalud_vida"].Visible = v;
        }

        private void Adelanto(bool v)
        {
            Dgvplanilla2.Columns["dadelanto"].Visible = v;
            Dgvplanilla1.Columns["adelant"].Visible = v;
        }

        private void Prestamo(bool v)
        {
            Dgvplanilla2.Columns["dprestamo"].Visible = v;
            Dgvplanilla1.Columns["prestam"].Visible = v;
        }

        private void RentaQuinta(bool v)
        {
            Dgvplanilla2.Columns["drenta"].Visible = v;
            Dgvplanilla1.Columns["renta5cate"].Visible = v;
        }

        private void RetencionJudicial(bool v)
        {
            Dgvplanilla2.Columns["dretencion"].Visible = v;
            Dgvplanilla1.Columns["retencionj"].Visible = v;
        }

        private void OtrosDescuentos(bool v)
        {
            Dgvplanilla2.Columns["dotrosdes"].Visible = v;
            Dgvplanilla1.Columns["otrodes"].Visible = v;
        }

        private void RecargoConsumo(bool v)
        {
            Dgvplanilla2.Columns["recargo_consu"].Visible = v;
            Dgvplanilla1.Columns["recargo_consumo"].Visible = v;
        }
        #endregion

        private void FrmPlanillaMensual2_FormClosing(object sender, FormClosingEventArgs e)
        {
            _intancia = null;
        }

      
    }
}
