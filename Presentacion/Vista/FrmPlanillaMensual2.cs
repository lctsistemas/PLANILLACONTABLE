﻿using Comun.Cache;
using Negocio.Models;
using Presentacion.Helps;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using Presentacion.Subvista;
using System.Diagnostics;

namespace Presentacion.Vista
{
    public partial class FrmPlanillaMensual2 : Form
    {
        private const string Subsidiado = "SUBSIDIADOS";
        private const string NoSubsidiado = "NO SUBSIDIADOS";        
        public int xdia_subposi = 0; // el valor es enviado desde el formulario susbidios.
        private static FrmPlanillaMensual2 _intancia;
        string result;
        bool ValorColor = false;
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
            Dgvplanilla1.Columns["ape_nom"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            Dgvplanilla2.Columns["valor1"].Frozen = true;
            
            Dgvplanilla1.Columns["id_contrato"].Visible = false;//se registrara este id
            Dgvplanilla1.Columns["id_planilla_manto"].Visible = false;//sera para poder actualizar
            Dgvplanilla1.Columns["jornada_labo"].Visible = false;
            Dgvplanilla1.Columns["valor_comision"].Visible = false;
            Dgvplanilla1.Columns["valor_seguro"].Visible = false;
            Dgvplanilla1.Columns["valor_aporte"].Visible = false;
            Dgvplanilla1.Columns["cod_document"].Visible = false;
            Dgvplanilla1.Columns["codigo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Dgvplanilla1.Columns["f_ini"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            Dgvplanilla1.Columns["f_ini"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            Dgvplanilla1.Columns["ape_nom"].ReadOnly = true;
            Dgvplanilla1.Columns["regi_pen"].ReadOnly = true;
            Dgvplanilla1.Columns["regi_pen"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            Dgvplanilla1.Columns["codigo"].ReadOnly = true;
            Dgvplanilla1.Columns["cargo"].ReadOnly = true;
            Dgvplanilla1.Columns["cargo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            Dgvplanilla1.Columns["f_ini"].ReadOnly = true;
            Dgvplanilla1.Columns["remu"].ReadOnly = true;

            Dgvplanilla1.Columns["remu"].DefaultCellStyle.Format = "N2";
           
            Dgvplanilla1.Columns["dgv_dias"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Dgvplanilla1.Columns["dia_dominical"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            Dgvplanilla1.Columns["hxd25"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Dgvplanilla1.Columns["minud25"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Dgvplanilla1.Columns["hxd35"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Dgvplanilla1.Columns["minud35"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Dgvplanilla1.Columns["hxn25"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Dgvplanilla1.Columns["minun25"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Dgvplanilla1.Columns["hxn35"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Dgvplanilla1.Columns["minun35"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Dgvplanilla1.Columns["hrferiado"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Dgvplanilla1.Columns["minuferiado"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Dgvplanilla1.Columns["hrboninocturna"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Dgvplanilla1.Columns["htarde"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Dgvplanilla1.Columns["mtarde"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;            
            
            Dgvplanilla1.Columns["montod25"].ReadOnly = true;           
            Dgvplanilla1.Columns["montod35"].ReadOnly = true;         
            Dgvplanilla1.Columns["monton25"].ReadOnly = true;           
            Dgvplanilla1.Columns["monton35"].ReadOnly = true;

            Dgvplanilla1.Columns["montod25"].DefaultCellStyle.ForeColor = Color.Blue;  //FromArgb(27, 79, 144); //es color del azul de form principal
            Dgvplanilla1.Columns["montod35"].DefaultCellStyle.ForeColor = Color.Blue;
            Dgvplanilla1.Columns["monton25"].DefaultCellStyle.ForeColor = Color.Blue;
            Dgvplanilla1.Columns["monton35"].DefaultCellStyle.ForeColor = Color.Blue;
            Dgvplanilla1.Columns["totaremu"].DefaultCellStyle.ForeColor = Color.Blue;
            Dgvplanilla1.Columns["topagar"].DefaultCellStyle.ForeColor = Color.Blue;

            Dgvplanilla1.Columns["montoferiado"].ReadOnly = true;           
            Dgvplanilla1.Columns["montoboninocturno"].ReadOnly = true;           
            Dgvplanilla1.Columns["montotarde"].ReadOnly = true;
            Dgvplanilla1.Columns["hora_trabajada"].ReadOnly = true;
            Dgvplanilla1.Columns["sueldo"].ReadOnly = true;
            Dgvplanilla1.Columns["a_familiar"].ReadOnly = true;
            //subsidios
            Dgvplanilla1.Columns["ndias"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Dgvplanilla1.Columns["ndias"].ReadOnly = true;           
            Dgvplanilla1.Columns["montosub"].ReadOnly = true;
            Dgvplanilla1.Columns["ndiasnega"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Dgvplanilla1.Columns["ndiasnega"].ReadOnly = true;       
            Dgvplanilla1.Columns["montonega"].ReadOnly = true;
            Dgvplanilla1.Columns["ndiasposi"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Dgvplanilla1.Columns["ndiasposi"].ReadOnly = true;          
            Dgvplanilla1.Columns["montoposi"].ReadOnly = true;

            Dgvplanilla1.Columns["onp"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Dgvplanilla1.Columns["comision"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Dgvplanilla1.Columns["seguro"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Dgvplanilla1.Columns["spp"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            Dgvplanilla1.Columns["onp"].ReadOnly = true;
            Dgvplanilla1.Columns["comision"].ReadOnly = true;
            Dgvplanilla1.Columns["seguro"].ReadOnly = true;
            Dgvplanilla1.Columns["spp"].ReadOnly = true;

            Dgvplanilla1.Columns["thoras"].ReadOnly = true;      
            Dgvplanilla1.Columns["totaremu"].ReadOnly = true;
            Dgvplanilla1.Columns["totades"].ReadOnly = true;
            Dgvplanilla1.Columns["topagar"].ReadOnly = true;
            Dgvplanilla1.Columns["aportsalud"].ReadOnly = true;
            Dgvplanilla1.Columns["dgvdia_vaca"].Visible = false;
           
        }

       /* private void OcultarSoloPrueba()
        {
            Dgvplanilla1.Columns["btnnosubsidio"].Visible = false;
            Dgvplanilla1.Columns["ndiasnega"].Visible = false;
            Dgvplanilla1.Columns["montonega"].Visible = false;
            Dgvplanilla1.Columns["ndiasposi"].Visible = false;
            Dgvplanilla1.Columns["montoposi"].Visible = false;
            Dgvplanilla1.Columns["reintegro"].Visible = false;
            Dgvplanilla2.Columns["dreintegro"].Visible = false;
            Dgvplanilla2.Columns["nosubsi"].Visible = false;
        }*/

        //CARGAR DATAGRI        
        private void FillTabla()
        {
            using (nplam = new NplanillaM())
            {
                nplam.PId_mes = PlanillaCache.p_idmes;
                nplam.Pid_planilla = PlanillaCache.p_idplanilla;
                nplam.PId_empreMaestra = UserCache.Codigo_empresa;
                //nplam.PFecha_inicio = Convert.ToDateTime(TxtfechaInicio.Text);
                nplam.PFecha_fin = Convert.ToDateTime(TxtfechaFin.Text);

                Dgvplanilla1.DataSource = nplam.Show_planillaM();
            }
        }

        //TOTAL REMUNERACION
        private void TotalRemuneracion(DataGridViewRow dar)
        {             
            try
            {
                int diaMes = txtdiasMes.Text.Trim() == string.Empty ? 0 : Convert.ToInt32(txtdiasMes.Text.Trim()); //OBTENEMOS DIAS PARA NO PODER SUMAR LA ASIG FAM. CUANDO TIENE SUBSIDIO MES COMPLETO
                int pdiasubsi = SubsidiosMayorVeinte(dar);

                double suel = 0, asigfami = 0, monto_sub = 0, montonegasub = 0, montoposisub = 0, totalHorasEx = 0;
                double tardanzasub = 0, p_unomayo = 0, reintegr = 0, p_otroreintegro = 0, vacacion = 0, vaca_trun = 0, grati_tru = 0, boni_tru = 0, cts_tru = 0;
                double subtotal1 = 0, p_prest_alimen = 0, p_grati = 0, p_boni = 0, subtotal2 = 0, totalsub = 0;

                suel = dar.Cells["sueldo"].Value == null ? 0 : Convert.ToDouble(dar.Cells["sueldo"].Value);

                if (!((diaMes == 31 && pdiasubsi == 31) || (diaMes == 31 && pdiasubsi == 30) || (diaMes == 30 && pdiasubsi == 30)
                    || (diaMes == 29 && pdiasubsi == 29) || (diaMes == 28 && pdiasubsi == 28)))
                    asigfami = dar.Cells["a_familiar"].Value == null ? 0 : Convert.ToDouble(dar.Cells["a_familiar"].Value);

                monto_sub = dar.Cells["montosub"].Value == null ? 0 : Convert.ToDouble(dar.Cells["montosub"].Value);
                montonegasub = dar.Cells["montonega"].Value == null ? 0 : Convert.ToDouble(dar.Cells["montonega"].Value);
                montoposisub = dar.Cells["montoposi"].Value == null ? 0 : Convert.ToDouble(dar.Cells["montoposi"].Value);               
                tardanzasub = dar.Cells["montotarde"].Value == null ? 0 : Convert.ToDouble(dar.Cells["montotarde"].Value);
                p_unomayo = dar.Cells["unomayo"].Value == null ? 0 : Convert.ToDouble(dar.Cells["unomayo"].Value);
                totalHorasEx = dar.Cells["thoras"].Value == null ? 0 : Convert.ToDouble(dar.Cells["thoras"].Value);
                reintegr = dar.Cells["reintegro"].Value == null ? 0 : Convert.ToDouble(dar.Cells["reintegro"].Value);
                p_otroreintegro = dar.Cells["otros_reintegros"].Value == null ? 0 : Convert.ToDouble(dar.Cells["otros_reintegros"].Value);
                p_prest_alimen = dar.Cells["prestacion_alimenta"].Value == null ? 0 : Convert.ToDouble(dar.Cells["prestacion_alimenta"].Value);
                p_grati = dar.Cells["grati"].Value == null ? 0 : Convert.ToDouble(dar.Cells["grati"].Value);
                p_boni = dar.Cells["boni"].Value == null ? 0 : Convert.ToDouble(dar.Cells["boni"].Value);
                vacacion = dar.Cells["vacacione"].Value == null ? 0 : Convert.ToDouble(dar.Cells["vacacione"].Value);
                vaca_trun = dar.Cells["tvaca"].Value == null ? 0 : Convert.ToDouble(dar.Cells["tvaca"].Value);
                grati_tru = dar.Cells["tgrati"].Value == null ? 0 : Convert.ToDouble(dar.Cells["tgrati"].Value);
                boni_tru = dar.Cells["tboni"].Value == null ? 0 : Convert.ToDouble(dar.Cells["tboni"].Value);
                cts_tru = dar.Cells["tcts"].Value == null ? 0 : Convert.ToDouble(dar.Cells["tcts"].Value);

                subtotal1 = (suel + asigfami + monto_sub + montoposisub + totalHorasEx + p_unomayo + p_otroreintegro + p_prest_alimen);
                subtotal2 = (reintegr + p_grati + p_boni + vacacion + vaca_trun + grati_tru + boni_tru + cts_tru);
                totalsub = (subtotal1 + subtotal2) - (montonegasub + tardanzasub);

                dar.Cells["totaremu"].Value = totalsub.ToString("N2");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //TOTAL A PAGAR
        private void TotalAPagar(DataGridViewRow dar)
        {
            try
            {
                double p_totaremu = 0, p_transporte = 0, p_recarconsumo = 0, p_regrati = 0, p_reboni = 0;               
                double p_totadescuen = 0, p_subto;

                p_totaremu = dar.Cells["totaremu"].Value == null ? 0 : Convert.ToDouble(dar.Cells["totaremu"].Value);       
                p_transporte = dar.Cells["transporte"].Value == null ? 0 : Convert.ToDouble(dar.Cells["transporte"].Value);
                p_recarconsumo = dar.Cells["recargo_consumo"].Value == null ? 0 : Convert.ToDouble(dar.Cells["recargo_consumo"].Value);
                p_regrati = dar.Cells["reintegro_grati"].Value == null ? 0 : Convert.ToDouble(dar.Cells["reintegro_grati"].Value);
                p_reboni = dar.Cells["reintegro_boni"].Value == null ? 0 : Convert.ToDouble(dar.Cells["reintegro_boni"].Value);
                p_totadescuen = dar.Cells["totades"].Value == null ? 0 : Convert.ToDouble(dar.Cells["totades"].Value);

                p_subto = ((p_totaremu + p_transporte + p_recarconsumo + p_regrati + p_reboni) - p_totadescuen);
                dar.Cells["topagar"].Value = p_subto.ToString("N2");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        //TOTAL DESCUENTO
        private void TotalDescuento(DataGridViewRow dar)
        {
            double p_comision = 0, p_seguro = 0, p_spp = 0, p_onp = 0, totaAportes = 0;
            double p_saludvida = 0, p_adela = 0, p_presta = 0, p_renta = 0, p_rentencion = 0;
            double p_otrodes = 0, p_totaldes = 0;

            p_onp = dar.Cells["onp"].Value == null ? 0 : Convert.ToDouble(dar.Cells["onp"].Value);
            p_comision = dar.Cells["comision"].Value == null ? 0 : Convert.ToDouble(dar.Cells["comision"].Value);
            p_seguro = dar.Cells["seguro"].Value == null ? 0 : Convert.ToDouble(dar.Cells["seguro"].Value);
            p_spp = dar.Cells["spp"].Value == null ? 0 : Convert.ToDouble(dar.Cells["spp"].Value);
          
            p_saludvida = dar.Cells["essalud_vida"].Value == null ? 0 : Convert.ToDouble(dar.Cells["essalud_vida"].Value);
            p_adela = dar.Cells["adelant"].Value == null ? 0 : Convert.ToDouble(dar.Cells["adelant"].Value);
            p_presta = dar.Cells["prestam"].Value == null ? 0 : Convert.ToDouble(dar.Cells["prestam"].Value);
            p_renta = dar.Cells["renta5cate"].Value == null ? 0 : Convert.ToDouble(dar.Cells["renta5cate"].Value);
            p_rentencion = dar.Cells["retencionj"].Value == null ? 0 : Convert.ToDouble(dar.Cells["retencionj"].Value);
            p_otrodes = dar.Cells["otrodes"].Value == null ? 0 : Convert.ToDouble(dar.Cells["otrodes"].Value);

            totaAportes = (p_onp + p_comision + p_seguro + p_spp);
            p_totaldes = ((p_saludvida + p_adela + p_presta + p_renta + p_rentencion + p_otrodes) + totaAportes);
            dar.Cells["totades"].Value = p_totaldes.ToString("N2");

        }

        // DESCUENTO O.N.P  Y A.F.P y LOS CONCEPTOS QUE NO ESTAN AFECTOS A ESSALUD
        private double ConceptoNoAfectos(DataGridViewRow dgr)
        {
            double conceptostotal = 0;

            double p_gratifi = 0, p_bonifi = 0, p_tgratifi = 0, p_tbonifi = 0, p_tcts = 0;
            p_gratifi = dgr.Cells["grati"].Value == null ? 0 : Convert.ToDouble(dgr.Cells["grati"].Value);
            p_bonifi = dgr.Cells["boni"].Value == null ? 0 : Convert.ToDouble(dgr.Cells["boni"].Value);
            p_tgratifi = dgr.Cells["tgrati"].Value == null ? 0 : Convert.ToDouble(dgr.Cells["tgrati"].Value);
            p_tbonifi = dgr.Cells["tboni"].Value == null ? 0 : Convert.ToDouble(dgr.Cells["tboni"].Value);
            p_tcts = dgr.Cells["tcts"].Value == null ? 0 : Convert.ToDouble(dgr.Cells["tcts"].Value);

            conceptostotal = (p_gratifi + p_bonifi + p_tgratifi + p_tbonifi + p_tcts);

            return conceptostotal;
        }

        private void Descuento_aportes(DataGridViewRow dgr )
        {            
            double comi = 0, segu = 0, apor = 0, tremu = 0;
            double xcomi = 0, xsegu = 0, xapor = 0, xonp = 0;
            double noafectos = 0, p_subsidio = 0;

            comi = (Convert.ToDouble(dgr.Cells["valor_comision"].Value) / 100);
            segu = (Convert.ToDouble(dgr.Cells["valor_seguro"].Value) / 100);
            apor = (Convert.ToDouble(dgr.Cells["valor_aporte"].Value) / 100);

            //MessageBox.Show("comi: " + comi + "\n segu: " + segu + "\n apor: " + apor);
            tremu = dgr.Cells["totaremu"].Value == null ? 0 : Convert.ToDouble(dgr.Cells["totaremu"].Value);

            if (dgr.Cells["regi_pen"].Value.ToString() == "O.N.P")
            {
                p_subsidio = dgr.Cells["montosub"].Value == null ? 0 : Convert.ToDouble(dgr.Cells["montosub"].Value);
                noafectos = (ConceptoNoAfectos(dgr) + p_subsidio);
                xonp = ((tremu - noafectos) *comi);
                dgr.Cells["onp"].Value = xonp.ToString("N2");
            }
            else
            {
                noafectos = ConceptoNoAfectos(dgr);
                xcomi = ((tremu - noafectos) * comi);
                xsegu = ((tremu - noafectos) * segu);
                xapor = ((tremu - noafectos) * apor);
                dgr.Cells["comision"].Value = xcomi.ToString("N2");
                dgr.Cells["seguro"].Value = xsegu.ToString("N2");
                dgr.Cells["spp"].Value = xapor.ToString("N2");
            }
        }

        //CALCULO ESSALUD
        private void MontoEssalud(DataGridViewRow dar)
        {
            double p_montosalud = 0, p_montoSubsidio = 0, p_totaremu = 0;
            p_totaremu = dar.Cells["totaremu"].Value == null ? 0 : Convert.ToDouble(dar.Cells["totaremu"].Value);
            p_montoSubsidio = dar.Cells["montosub"].Value == null ? 0 : Convert.ToDouble(dar.Cells["montosub"].Value);
            p_montosalud = Calculo.EssaludMonto(ConceptoNoAfectos(dar), p_montoSubsidio, p_totaremu, 930, 9);

            dar.Cells["aportsalud"].Value = p_montosalud.ToString("N2");
        }

        //METODOS PARA LOS SUBSIDIOS, SUB NEGA, POSI Y BONI NOCTURNA, PARA DETERMINAR HORAS DIARIAS 
        private int BonificacionNocturna(DataGridViewRow d)
        {
            int p_boniNoct = 0;
            p_boniNoct = d.Cells["hrboninocturna"].Value == null ? 0 : Convert.ToInt32(d.Cells["hrboninocturna"].Value);
            return p_boniNoct;
        }

        private int SubsidiosMayorVeinte(DataGridViewRow dar)
        {
            int subMv = 0;
            subMv = dar.Cells["ndias"].Value == null ? 0 : Convert.ToInt32(dar.Cells["ndias"].Value);
            return subMv;           
        }

        private int SusidiosNegativo(DataGridViewCellEventArgs e)
        {
            int subNega = 0;
            subNega=Dgvplanilla1.Rows[e.RowIndex].Cells["ndiasnega"].Value == null ?  0 : Convert.ToInt32(Dgvplanilla1.Rows[e.RowIndex].Cells["ndiasnega"].Value);
            return subNega;
        }

        private int SusidiosPositivo(DataGridViewCellEventArgs e)
        {
            int subPosi = 0;
            subPosi = Dgvplanilla1.Rows[e.RowIndex].Cells["ndiasposi"].Value == null ? 0: Convert.ToInt32(Dgvplanilla1.Rows[e.RowIndex].Cells["ndiasposi"].Value);
            return subPosi;
        }

        //METODO HORAS DIARIAS.
        private double HorasDiarias(DataGridViewRow dgr, int hrboninoc, int p_diasubnega, int p_diasubposi, int p_diaSubsidio)
        {
            int pdias = 0, pdiaDominical = 0, tdias_subsidio = 0;//total dias subsidiado
            double horaTrabajada = 0;       
                      
            pdias = dgr.Cells["dgv_dias"].Value == null ? 0 : Convert.ToInt32(dgr.Cells["dgv_dias"].Value);

            pdiaDominical = dgr.Cells["dia_dominical"].Value == null ? 0 : Convert.ToInt32(dgr.Cells["dia_dominical"].Value);

            tdias_subsidio = (p_diasubnega + p_diasubposi + p_diaSubsidio);//suma de sub negativo y positivo para restar a dias trabajados

            if (dgr.Cells["jornada_labo"].Value.ToString() == "PART-TIME")
                horaTrabajada = ((((pdias - pdiaDominical) - tdias_subsidio) * 3.5) - hrboninoc);
            else
                horaTrabajada = ((((pdias - pdiaDominical) - tdias_subsidio) * 8) - hrboninoc);

            return horaTrabajada;
        }

        private void ValorHorasDiarias(DataGridViewRow dar, double hr_trabajada)
        {
            if (hr_trabajada.ToString().Contains(".") || hr_trabajada.ToString().Contains(","))
                dar.Cells["hora_trabajada"].Value = hr_trabajada.ToString("N2");
            else
                dar.Cells["hora_trabajada"].Value = hr_trabajada.ToString();
        }

        //DE ACUERDO A LOS DIAS QUE TIENES EL MES, SE CALCULA SU SUELDO
        private double SueldoPorMes(DataGridViewRow dar)
        {
            double p_sueldo = 0, p_basico = 0, p_subsidiado = 0, p_subsidioposi = 0, p_valasigFami = 0, p_totasubsidi = 0;
            int p_dias = 0, p_diasub = 0;

            int diasMes = Convert.ToInt32(txtdiasMes.Text);
            p_basico = Convert.ToDouble(dar.Cells["remu"].Value);
            p_dias = dar.Cells["dgv_dias"].Value == null ? 0 : Convert.ToInt32(dar.Cells["dgv_dias"].Value);
            p_subsidioposi = dar.Cells["montoposi"].Value == null ? 0 : Convert.ToDouble(dar.Cells["montoposi"].Value);

            p_diasub = dar.Cells["ndias"].Value == null ? 0 : Convert.ToInt32(dar.Cells["ndias"].Value);
            p_subsidiado = dar.Cells["montosub"].Value == null ? 0 : Convert.ToDouble(dar.Cells["montosub"].Value);
            p_valasigFami = dar.Cells["a_familiar"].Value == null ? 0 : Convert.ToDouble(dar.Cells["a_familiar"].Value);


            if (diasMes == 30)
            {
                if(p_dias <=30)
                    p_sueldo = ((p_basico / diasMes) * p_dias);
            }
            else if (diasMes == 31)
            {
                if (p_dias == 31)
                    p_sueldo = ((p_basico / diasMes) * p_dias);
                else if (p_dias < 31 && p_dias > 0)
                    p_sueldo = ((p_basico / 30) * p_dias);
            }
            else if (diasMes == 28)
            {
                if (p_dias == 28)
                    p_sueldo = ((p_basico / diasMes) * p_dias);
                else if (p_dias < 28 && p_dias > 0)
                    p_sueldo = ((p_basico / 30) * p_dias);
            }
            else if (diasMes == 29)
            {
                if (p_dias == 29)
                    p_sueldo = ((p_basico / diasMes) * p_dias);
                else if (p_dias < 29 && p_dias > 0)
                    p_sueldo = ((p_basico / 30) * p_dias);
            }

            if (diasMes == p_diasub)
                p_subsidiado = (p_subsidiado - p_valasigFami);
            if (diasMes == 31)
            {
                if (p_diasub == 30)
                    p_subsidiado = (p_subsidiado - p_valasigFami);
            }

            p_totasubsidi = (p_subsidiado + p_subsidioposi);

            return (p_sueldo - p_totasubsidi);
        }

        //SOBRE CARGA DE METODO
        private double SueldoPorMes(DataGridViewRow dar, int dia_vacacione)
        {
            double p_sueldo = 0, p_basico = 0, p_subsidiado = 0, p_subsidioposi = 0, p_valasigFami = 0, p_totasubsidi = 0;
            int p_dias = 0, p_diasub = 0;

            int diasMes = Convert.ToInt32(txtdiasMes.Text);
            p_basico = Convert.ToDouble(dar.Cells["remu"].Value);
            p_dias = dar.Cells["dgv_dias"].Value == null ? 0 : Convert.ToInt32(dar.Cells["dgv_dias"].Value);
            p_subsidioposi = dar.Cells["montoposi"].Value == null ? 0 : Convert.ToDouble(dar.Cells["montoposi"].Value);

            p_diasub = dar.Cells["ndias"].Value == null ? 0 : Convert.ToInt32(dar.Cells["ndias"].Value);
            p_subsidiado = dar.Cells["montosub"].Value == null ? 0 : Convert.ToDouble(dar.Cells["montosub"].Value);
            p_valasigFami = dar.Cells["a_familiar"].Value == null ? 0 : Convert.ToDouble(dar.Cells["a_familiar"].Value);

            if (diasMes == 30)
            {
                if (p_dias <= 30)
                    p_sueldo = ((p_basico / diasMes) * (p_dias - dia_vacacione));
            }
            else if (diasMes == 31)
            {
                if (p_dias == 31)
                {
                    if (dia_vacacione > 0)
                        p_sueldo = ((p_basico / 30) * (p_dias - dia_vacacione));
                    else
                        p_sueldo = ((p_basico / 30) * 30);
                }                    
                else if (p_dias < 31 && p_dias > 0)
                    p_sueldo = ((p_basico / 30) * (p_dias - dia_vacacione));
            }
            else if (diasMes == 28)
            {
                if (p_dias == 28)
                {
                    if (dia_vacacione > 0)
                        p_sueldo = ((p_basico / 30) * (p_dias - dia_vacacione));
                    else
                        p_sueldo = ((p_basico / 30) * 30);
                }                    
                else if (p_dias < 28 && p_dias > 0)
                    p_sueldo = ((p_basico / 30) * (p_dias - dia_vacacione));
            }
            else if (diasMes == 29)
            {
                if (p_dias == 29)
                {
                    if (dia_vacacione > 0)
                        p_sueldo = ((p_basico / 30) * (p_dias - dia_vacacione));
                    else
                        p_sueldo = ((p_basico / 30) * 30);
                }                    
                else if (p_dias < 29 && p_dias > 0)
                    p_sueldo = ((p_basico / 30) * (p_dias - dia_vacacione));
            }            

            if (diasMes == p_diasub)
                p_subsidiado = (p_subsidiado - p_valasigFami);
            if (diasMes == 31)
            {
                if (p_diasub == 30)
                    p_subsidiado = (p_subsidiado - p_valasigFami);
            }

            p_totasubsidi = (p_subsidiado + p_subsidioposi);
            return (p_sueldo - p_totasubsidi);
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

        //INICIO DEL CALCULO
        private void Dgvplanilla1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {                          
            DataGridViewRow dar = Dgvplanilla1.CurrentRow;
            double valor_sueldo = 0, valor_asigFami = 0;
            string jornadaLaboral = "";

            if (e.ColumnIndex >= 18 && e.ColumnIndex < Dgvplanilla1.ColumnCount)
            {                
                //VAMOS A OBTENER LOS VALORES DEL SUELDO Y ASIG. FAMILIAR PARA EL CALCULO RESPECTIVO.
                valor_sueldo = dar.Cells["remu"].Value == null ? 0 : Convert.ToDouble(dar.Cells["remu"].Value);
                valor_asigFami = dar.Cells["a_familiar"].Value == null ? 0 : Convert.ToDouble(dar.Cells["a_familiar"].Value);

            }

            //VAMOS A CALCULAR LOS DIAS Y SUELDO 
            switch (e.ColumnIndex)
            {
                case 13://dias que laboro
                    double p_sueldo = 0;
                    
                    if (dar.Cells["dgvdia_vaca"].Value != null) 
                    {
                        int x = dar.Cells["dgvdia_vaca"].Value == null ? 0 : Convert.ToInt32(dar.Cells["dgvdia_vaca"].Value);
                        p_sueldo = SueldoPorMes(dar, x);                   
                    }else
                        p_sueldo = SueldoPorMes(dar);

                    dar.Cells["sueldo"].Value = p_sueldo.ToString("N2");
                  
                    break;
                default:
                    break;
            }

            //Calculo para Horas Extras y descuentos
            switch (e.ColumnIndex)
            {               
                case 18:
                case 19:
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

                    horxd25 = Calculo.HoraExDiurna(valor_sueldo, valor_asigFami, 0.25, hora25, minu25);
                    dar.Cells["montod25"].Value = horxd25.ToString("N2");
                    break;
                
                case 21:
                case 22:
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

                    horxd35 = Calculo.HoraExDiurna(valor_sueldo, valor_asigFami, 0.35, hora35, minu35);
                    dar.Cells["montod35"].Value = horxd35.ToString("N2");
                    break;
                case 24:
                case 25:
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

                    horxn25 = Calculo.HoraExNocturnas(valor_sueldo, valor_asigFami, 0.25, nhora25, nminu25);
                    dar.Cells["monton25"].Value = horxn25.ToString("N2");
                    break;

                case 27:
                case 28:
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

                    horxn35 = Calculo.HoraExNocturnas(valor_sueldo, valor_asigFami, 0.35, nhora35, nminu35);
                    dar.Cells["monton35"].Value = horxn35.ToString("N2");
                    break;

                case 30:
                case 31:
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

                    jornadaLaboral = dar.Cells["jornada_labo"].Value.ToString();//OBTENEMOS EL PART-TIME PARA EL CALCULO

                    hferi = Calculo.FeriadoDom(valor_sueldo, valor_asigFami, horaferiado, minutoferi, jornadaLaboral);
                    dar.Cells["montoferiado"].Value = hferi.ToString("N2");
                    break;

                case 33:
                    double boninoc = 0, h_trabajada = 0;
                    int horanoc = 0;
                   
                    horanoc = BonificacionNocturna(dar);
                    jornadaLaboral = dar.Cells["jornada_labo"].Value.ToString();//OBTENEMOS EL PART-TIME PARA EL CALCULO

                    boninoc = Calculo.BoniNocturno(valor_sueldo, valor_asigFami, horanoc, jornadaLaboral);
                    h_trabajada = HorasDiarias(dar, horanoc, SusidiosNegativo(e), SusidiosPositivo(e), SubsidiosMayorVeinte(dar));
                    
                    dar.Cells["montoboninocturno"].Value = boninoc.ToString("N2");
                    ValorHorasDiarias(dar,h_trabajada);
                    //dar.Cells["hora_trabajada"].Value = h_trabajada.ToString("#.#0");
                    break;

                case 36:
                case 37:
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

                    importe_tarde = Calculo.Tardanza(valor_sueldo, horatarde, minutarde);
                    dar.Cells["montotarde"].Value = importe_tarde.ToString("N2");
                    break;

                default:
                    break;
            }


            // TOTAL HORAS EXTRAS.
            switch (e.ColumnIndex)
            {
                case 18:
                case 19:
                case 21:
                case 22:
                case 24:
                case 25:
                case 27:
                case 28:
                case 30:
                case 31:
                case 33:

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

                case 13:
                case 14:
                    int pboniNocturno = 0;
                    double hr_trabajada = 0;

                    pboniNocturno = BonificacionNocturna(dar);

                    hr_trabajada = HorasDiarias(dar, pboniNocturno, SusidiosNegativo(e), SusidiosPositivo(e), SubsidiosMayorVeinte(dar));
                    ValorHorasDiarias(dar, hr_trabajada);
                    break;

                default:
                    break;
            }

            switch (e.ColumnIndex)
            {
                case 51://grati diciem y julio
                    double p_bonidegrati = 0;
                    p_bonidegrati = dar.Cells["grati"].Value == null ? 0 : Convert.ToDouble(dar.Cells["grati"].Value);

                    p_bonidegrati = Calculo.BonificacionGrati(p_bonidegrati);
                    dar.Cells["boni"].Value = p_bonidegrati.ToString("N2");

                    break;
                case 55://grati trunca
                    double p_bonitrunca = 0;
                    p_bonitrunca = dar.Cells["tgrati"].Value == null ? 0 : Convert.ToDouble(dar.Cells["tgrati"].Value);

                    p_bonitrunca = Calculo.BonificacionGrati(p_bonitrunca);
                    dar.Cells["tboni"].Value = p_bonitrunca.ToString("N2");
                    break;
                default:
                    break;
            }
            TotalRemuneracion(dar);
            Descuento_aportes(dar);
            TotalDescuento(dar);
            TotalAPagar(dar);
            MontoEssalud(dar);
        }
             
        //AQUI ESTAMOS USANDO TIPO DATO DOUBLE
        private void Dgvplanilla1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                int diames = txtdiasMes.Text.Trim() == string.Empty ? 0 : Convert.ToInt32(txtdiasMes.Text.Trim());
                DataGridViewRow dar= Dgvplanilla1.CurrentRow;
                int dias = 0, diapo = 0, boniNoc = 0, p_diavaca = 0;
                double hro_trabajada = 0;
                double monto = 0, monto_posi = 0, monto_sueldo = 0;            
                double p_remu = 0, p_asigF = 0, suel_porMes = 0;

                void ValoresInicial()
                {
                    p_remu = Convert.ToDouble(Dgvplanilla1.Rows[e.RowIndex].Cells["remu"].Value);
                    p_asigF = Dgvplanilla1.Rows[e.RowIndex].Cells["a_familiar"].Value == null ? 0 : Convert.ToDouble(Dgvplanilla1.Rows[e.RowIndex].Cells["a_familiar"].Value);                    
                }
                
                if (Dgvplanilla1.Rows[e.RowIndex].Cells["btnsubsidio"].Selected)
                {
                    ValoresInicial();
                    PlanillaCache.Subsidiado = Subsidiado;
                    PlanillaCache.p_idempleado = Convert.ToInt32(Dgvplanilla1.Rows[e.RowIndex].Cells["id_contrato"].Value);
                    FrmDiasSubsidiados2 fr2 = FrmDiasSubsidiados2.Getinstance();
                    this.AddOwnedForm(fr2);
                    fr2.lblcodigo_empledo.Text = Dgvplanilla1.Rows[e.RowIndex].Cells["cod_document"].Value.ToString() +" - "+ Dgvplanilla1.Rows[e.RowIndex].Cells["codigo"].Value.ToString();
                    fr2.lblnombre_empleado.Text = Dgvplanilla1.Rows[e.RowIndex].Cells["ape_nom"].Value.ToString();
                    fr2.ShowDialog();

                    //TOMAMOS EL VALOR DEL DIA Y CALCULAMOS
                    dias = SubsidiosMayorVeinte(dar);
                    monto = Calculo.MontoSubsidios(dias, p_remu, p_asigF, diames);
                    Dgvplanilla1.Rows[e.RowIndex].Cells["montosub"].Value = monto.ToString("N2");

                    boniNoc = BonificacionNocturna(dar); //OBTENEMOS VALOR BONI NOCTUR.
                    hro_trabajada = HorasDiarias(dar, boniNoc, SusidiosNegativo(e), SusidiosPositivo(e), dias);// Y LO RESTAMOS EN HORA. TRABAJADAS.
                    ValorHorasDiarias(dar,hro_trabajada); // MOSTRAMOS VALOR DE HORAS DIARIAS.

                    p_diavaca = dar.Cells["dgvdia_vaca"].Value == null ? 0 : Convert.ToInt32(dar.Cells["dgvdia_vaca"].Value);

                    monto_sueldo = SueldoPorMes(dar, p_diavaca);
                                       
                    dar.Cells["sueldo"].Value = monto_sueldo.ToString("N2");

                    TotalRemuneracion(dar);
                    Descuento_aportes(dar);
                    TotalDescuento(dar);
                    TotalAPagar(dar);
                    MontoEssalud(dar);
                }

                if (Dgvplanilla1.Rows[e.RowIndex].Cells["btnnosubsidio"].Selected)
                {
                    ValoresInicial();
                    PlanillaCache.Subsidiado = NoSubsidiado;
                    PlanillaCache.p_idempleado = Convert.ToInt32(Dgvplanilla1.Rows[e.RowIndex].Cells["id_contrato"].Value);
                    FrmDiasSubsidiados2 fr2 = FrmDiasSubsidiados2.Getinstance();
                    this.AddOwnedForm(fr2);
                    fr2.lblcodigo_empledo.Text = Dgvplanilla1.Rows[e.RowIndex].Cells["cod_document"].Value.ToString() + " - " + Dgvplanilla1.Rows[e.RowIndex].Cells["codigo"].Value.ToString();
                    fr2.lblnombre_empleado.Text = Dgvplanilla1.Rows[e.RowIndex].Cells["ape_nom"].Value.ToString();
                    fr2.ShowDialog();

                    //MONTO NEGATIVO.
                    dias = SusidiosNegativo(e);
                    monto = Calculo.MontoSubsidios(dias, p_remu, diames);
                    Dgvplanilla1.Rows[e.RowIndex].Cells["montonega"].Value = monto.ToString("N2");

                    //MONTO POSITIVO
                    diapo = SusidiosPositivo(e);                  
                    if(xdia_subposi > 0)
                        monto_posi = Calculo.MontoSubsidios(xdia_subposi, p_remu, diames);

                    boniNoc = BonificacionNocturna(dar); //OBTENEMOS VALOR BONI NOCTUR.
                    hro_trabajada = HorasDiarias(dar, boniNoc, dias, diapo, SubsidiosMayorVeinte(dar)); // Y LO RESTAMOS EN HORA. TRABAJADAS.
                    if(xdia_subposi > 0)
                        Dgvplanilla1.Rows[e.RowIndex].Cells["montoposi"].Value = monto_posi.ToString("N2");

                    ValorHorasDiarias(dar, hro_trabajada);

                    //OBTENGO EL DIA DE VACACIONES PARA PODER RESTAR A LOS DIAS LABORADOS.
                    p_diavaca = dar.Cells["dgvdia_vaca"].Value == null ? 0 : Convert.ToInt32(dar.Cells["dgvdia_vaca"].Value);
                    suel_porMes = SueldoPorMes(dar, p_diavaca);//EL VALOR DEL SUBSIDIO POSITIVO LO VA RESTAR AL SUELDO.

                    dar.Cells["sueldo"].Value = suel_porMes.ToString("N2");
                    TotalRemuneracion(dar);
                    Descuento_aportes(dar);
                    TotalDescuento(dar);
                    TotalAPagar(dar);
                    MontoEssalud(dar);
                    xdia_subposi = 0;
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
            if (e.RowIndex != -1)
            {
                if(!ValorColor)
                    Dgvplanilla1.Rows[e.RowIndex].Cells["ape_nom"].Style.ForeColor = Color.Crimson;
                
                ValorColor = true;
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
            //if(Dgvplanilla1.RowCount > 0)
            //    Dgvplanilla1.CurrentRow.Cells["ape_nom"].Style.ForeColor = Color.Crimson;
            //MessageBox.Show("cell state changed");

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

        //MOVER VENTANA
        private void menuarchivos_MouseDown(object sender, MouseEventArgs e)
        {
            //WindowsMove.ReleaseCapture();
            //WindowsMove.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        
        private void tbtnlistaconceptos_Click(object sender, EventArgs e)
        {
            grobconceptos.Visible = tbtnlistaconceptos.Checked;
        }

        private void tbtnbarraerramientas_Click(object sender, EventArgs e)
        {
            toolbotones.Visible = tbtnbarraerramientas.Checked;
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

                nconcepto.Id_mes = PlanillaCache.p_idmes;
                nconcepto.Id_planilla = PlanillaCache.p_idplanilla;
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
                nconcepto.Id_mes = PlanillaCache.p_idmes; ;
                nconcepto.Id_planilla = PlanillaCache.p_idplanilla;
                li = nconcepto.Getall();

                if(li.Count <= 0)
                {                   
                    li.Clear();
                }
                else
                {
                   
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
            Dgvplanilla2.Columns["dotro_reintegro"].Visible = v;
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


        //FORMATO DE COLOR A LA TABLA
        private void Dgvplanilla1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                //Dgvplanilla1.Rows[e.RowIndex].Cells["ape_nom"].Style.ForeColor = Color.DarkRed;
            }
           
        }             
      
        private void Dgvplanilla1_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
                Dgvplanilla1.Rows[e.RowIndex].Cells["ape_nom"].Style.ForeColor = Color.Empty;

            Dgvplanilla1[e.ColumnIndex, e.RowIndex].Style.SelectionBackColor = Color.Empty;
        }

        // VISTA DE LISTA DE COMISIONES AFP.
        private void tbtncomi_pri_spp_Click(object sender, EventArgs e)
        {
            using (FrmVista_comisionesAfp fv_apf = new FrmVista_comisionesAfp())
            {
                fv_apf.StartPosition = FormStartPosition.CenterParent;
                fv_apf.ShowDialog();
            }
        }

        //ENLACES A PAGINAS WEB
        private void Tbtsbs_Click(object sender, EventArgs e)
        {            
            Process.Start("https://www.sbs.gob.pe/app/spp/empleadores/comisiones_spp/paginas/comision_prima.aspx");
        }

        private void Tbtspp_Click(object sender, EventArgs e)
        {
            Process.Start("https://reportedeudas.sbs.gob.pe/ReporteSituacionPrevisional/Afil_Consulta.aspx");
        }

        //VALIDACION
        private void Dgvplanilla1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (Dgvplanilla1.Columns[e.ColumnIndex].Name == "codigo")
                {
                    if (e.Value != null)
                    {
                        if (e.Value.GetType() != typeof(object))
                        {
                            //condicion
                            if (Dgvplanilla1.Rows[e.RowIndex].Cells["jornada_labo"].Value.ToString()  == "PART-TIME" )
                            {
                                Dgvplanilla1.Rows[e.RowIndex].Cells["codigo"].Style.BackColor = Color.SkyBlue;
                                //Dgvplanilla1.RowHeadersDefaultCellStyle.BackColor = Color.Red;
                            }
                            
                        }

                    }
                }
            }
        }

       
        //Coloca Numeracion en HeaderCell.
        private void Dgvplanilla1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(Dgvplanilla1.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 8, e.RowBounds.Location.Y + 4);
            }
        }

        //PARA REGISTRAR LA PLANILLA CALCULO
        private void TbtnguardarPlanilla_Click(object sender, EventArgs e)
        {
            result = "";
            using (nplam = new NplanillaM())
            {
                if (nplam.ListNpm == null)
                    nplam.ListNpm = new List<NplanillaM>();

                foreach (DataGridViewRow item in Dgvplanilla1.Rows)
                {
                    nplam.ListNpm.Add(new NplanillaM()
                    {
                        PId_contrato = Convert.ToInt32(item.Cells["id_contrato"].Value),
                        Pid_planilla = PlanillaCache.p_idplanilla,
                        Pm_id_tipoplanilla = Convert.ToInt32(txtid_tipoplanilla.Text),
                        PJornada_laboral = item.Cells["jornada_labo"].Value.ToString(),
                        PDescrip_regipension = item.Cells["regi_pen"].Value.ToString(),
                        PVcomision = Convert.ToDecimal(item.Cells["valor_comision"].Value),
                        PVseguro = Convert.ToDecimal(item.Cells["valor_seguro"].Value),
                        PVaporte = Convert.ToDecimal(item.Cells["valor_aporte"].Value),
                        PCargop = item.Cells["cargo"].Value.ToString(),
                        Pm_basico = Convert.ToDecimal(item.Cells["remu"].Value),
                        Pm_dias = Convert.ToInt32(item.Cells["dgv_dias"].Value),
                        Pm_diadominical = Convert.ToInt32(item.Cells["dia_dominical"].Value),
                        Pm_horasdiarias = Convert.ToDecimal(item.Cells["hora_trabajada"].Value),

                        Premune_basica = item.Cells["sueldo"].Value == null ? null : item.Cells["sueldo"].Value.ToString(),
                        PAsig_familiar = item.Cells["a_familiar"].Value == null ? null : item.Cells["a_familiar"].Value.ToString(),
                        Pm_hora_dvc = item.Cells["hxd25"].Value == null ? null : item.Cells["hxd25"].Value.ToString(),
                        Pm_minuto_dvc = item.Cells["minud25"].Value == null ? null : item.Cells["minud25"].Value.ToString(),
                        Pm_monto_dvc = item.Cells["montod25"].Value == null ? null : item.Cells["montod25"].Value.ToString(),
                        Pm_hora_dtc = item.Cells["hxd35"].Value == null ? null : item.Cells["hxd35"].Value.ToString(),
                        Pm_minuto_dtc = item.Cells["minud35"].Value == null ? null : item.Cells["minud35"].Value.ToString(),
                        Pm_monto_dtc = item.Cells["montod35"].Value == null ? null : item.Cells["montod35"].Value.ToString(),
                        Pm_hora_nvc = item.Cells["hxn25"].Value == null ? null : item.Cells["hxn25"].Value.ToString(),
                        Pm_minuto_nvc = item.Cells["minun25"].Value == null ? null : item.Cells["minun25"].Value.ToString(),
                        Pm_monto_nvc = item.Cells["monton25"].Value == null ? null : item.Cells["monton25"].Value.ToString(),
                        Pm_hora_ntc = item.Cells["hxn35"].Value == null ? null : item.Cells["hxn35"].Value.ToString(),
                        Pm_minuto_ntc = item.Cells["minun35"].Value == null ? null : item.Cells["minun35"].Value.ToString(),
                        Pm_monto_ntc = item.Cells["monton35"].Value == null ? null : item.Cells["monton35"].Value.ToString(),
                        Pm_hora_feriado = item.Cells["hrferiado"].Value == null ? null : item.Cells["hrferiado"].Value.ToString(),
                        Pm_minuto_feriado = item.Cells["minuferiado"].Value == null ? null : item.Cells["minuferiado"].Value.ToString(),
                        Pm_monto_feriado = item.Cells["montoferiado"].Value == null ? null : item.Cells["montoferiado"].Value.ToString(),
                        Pm_hora_boni = item.Cells["hrboninocturna"].Value == null ? null : item.Cells["hrboninocturna"].Value.ToString(),
                        Pm_monto_boni = item.Cells["montoboninocturno"].Value == null ? null : item.Cells["montoboninocturno"].Value.ToString(),
                        Pm_uno_mayo = item.Cells["unomayo"].Value == null ? null : item.Cells["unomayo"].Value.ToString(),
                        Pm_hora_tarde = item.Cells["htarde"].Value == null ? null : item.Cells["htarde"].Value.ToString(),
                        Pm_minuto_tarde = item.Cells["mtarde"].Value == null ? null : item.Cells["mtarde"].Value.ToString(),
                        Pm_monto_tarde = item.Cells["montotarde"].Value == null ? null : item.Cells["montotarde"].Value.ToString(),
                        Pm_dia_sub = item.Cells["ndias"].Value == null ? null : item.Cells["ndias"].Value.ToString(),
                        Pm_monto_sub = item.Cells["montosub"].Value == null ? null : item.Cells["montosub"].Value.ToString(),
                        Pm_dia_subnegativo = item.Cells["ndiasnega"].Value == null ? null : item.Cells["ndiasnega"].Value.ToString(),
                        Pm_monto_subnegativo = item.Cells["montonega"].Value == null ? null : item.Cells["montonega"].Value.ToString(),
                        Pm_dia_subpositivo = item.Cells["ndiasposi"].Value == null ? null : item.Cells["ndiasposi"].Value.ToString(),
                        Pm_monto_subpositivo = item.Cells["montoposi"].Value == null ? null : item.Cells["montoposi"].Value.ToString(),
                        Pm_total_horaex = item.Cells["thoras"].Value == null ? null : item.Cells["thoras"].Value.ToString(),
                        Pm_reintegro = item.Cells["reintegro"].Value == null ? null : item.Cells["reintegro"].Value.ToString(),
                        Pm_otro_reintegro = item.Cells["otros_reintegros"].Value == null ? null : item.Cells["otros_reintegros"].Value.ToString(),
                        Pm_pre_alimentaria = item.Cells["prestacion_alimenta"].Value == null ? null : item.Cells["prestacion_alimenta"].Value.ToString(),
                        Pm_gratiex = item.Cells["grati"].Value == null ? null : item.Cells["grati"].Value.ToString(),
                        Pm_boniex = item.Cells["boni"].Value == null ? null : item.Cells["boni"].Value.ToString(),
                        Pm_vacaciones = item.Cells["vacacione"].Value == null ? null : item.Cells["vacacione"].Value.ToString(),
                        Pm_vaca_trunca = item.Cells["tvaca"].Value == null ? null : item.Cells["tvaca"].Value.ToString(),
                        Pm_grati_trunca = item.Cells["tgrati"].Value == null ? null : item.Cells["tgrati"].Value.ToString(),
                        Pm_boni_trunca = item.Cells["tboni"].Value == null ? null : item.Cells["tboni"].Value.ToString(),
                        Pm_cts_trunca = item.Cells["tcts"].Value == null ? null : item.Cells["tcts"].Value.ToString(),
                        Pm_total_remuneracion = item.Cells["totaremu"].Value == null ? null : item.Cells["totaremu"].Value.ToString(),
                        Pm_descuento_onp = item.Cells["onp"].Value == null ? null : item.Cells["onp"].Value.ToString(),
                        Pm_des_comision = item.Cells["comision"].Value == null ? null : item.Cells["comision"].Value.ToString(),
                        Pm_des_seguro = item.Cells["seguro"].Value == null ? null : item.Cells["seguro"].Value.ToString(),
                        Pm_des_spp = item.Cells["spp"].Value == null ? null : item.Cells["spp"].Value.ToString(),
                        Pm_essalud_vida = item.Cells["essalud_vida"].Value == null ? null : item.Cells["essalud_vida"].Value.ToString(),
                        Pm_adelanto = item.Cells["adelant"].Value == null ? null : item.Cells["adelant"].Value.ToString(),
                        Pm_prestamo = item.Cells["prestam"].Value == null ? null : item.Cells["prestam"].Value.ToString(),
                        Pm_renta_quinta = item.Cells["renta5cate"].Value == null ? null : item.Cells["renta5cate"].Value.ToString(),
                        Pm_retencion_judicial = item.Cells["retencionj"].Value == null ? null : item.Cells["retencionj"].Value.ToString(),
                        Pm_otro_des = item.Cells["otrodes"].Value == null ? null : item.Cells["otrodes"].Value.ToString(),
                        Pm_total_desc = item.Cells["totades"].Value == null ? null : item.Cells["totades"].Value.ToString(),
                        Pm_total_pagar = item.Cells["topagar"].Value == null ? null : item.Cells["topagar"].Value.ToString(),
                        Pm_aporte_essalud = item.Cells["aportsalud"].Value == null ? null : item.Cells["aportsalud"].Value.ToString(),
                        Pm_transporte = item.Cells["transporte"].Value == null ? null : item.Cells["transporte"].Value.ToString(),
                        Pm_recargo_consumo = item.Cells["recargo_consumo"].Value == null ? null : item.Cells["recargo_consumo"].Value.ToString(),
                        Pm_reintegro_grati = item.Cells["reintegro_grati"].Value == null ? null : item.Cells["reintegro_grati"].Value.ToString(),
                        Pm_reintegro_boni = item.Cells["reintegro_boni"].Value == null ? null : item.Cells["reintegro_boni"].Value.ToString(),
                        Pm_dia_vacaciones = item.Cells["dgvdia_vaca"].Value == null ? null : item.Cells["dgvdia_vaca"].Value.ToString()

                    });
                }
                result = nplam.SavePlanilaManto();
                //if (result.Contains("¡Registrado!"))
                    Messages.M_info(result);
                //else
                //    Messages.M_warning(result);

                nplam.ListNpm.Clear();

            }
        }

        private void TbtneditarPlanilla_Click(object sender, EventArgs e)
        {
            MessageBox.Show("id planilla es:  " + PlanillaCache.p_idplanilla);
        }

        private void tbtvista_prueba_Click(object sender, EventArgs e)
        {
            using (FrmVistaPruebaPlanilla plaprueba = new FrmVistaPruebaPlanilla())
            {
                plaprueba.ShowDialog(this);
            }
        }

        private void Dgvplanilla1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (ValorColor)
                    Dgvplanilla1.Rows[e.RowIndex].Cells["ape_nom"].Style.ForeColor = Color.Crimson;

                Dgvplanilla1[e.ColumnIndex, e.RowIndex].Style.SelectionBackColor = Color.FromArgb(212, 230, 241);               
            }
        }
    }
}
