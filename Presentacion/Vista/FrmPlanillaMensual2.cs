using Comun.Cache;
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
        public int xdia_vacaciones = 0; // el valor es enviado desde el formulario susbidios.
        public int xdia_subposi = 0; // el valor es enviado desde el formulario susbidios.
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
            Dgvplanilla1.Columns["codigo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Dgvplanilla1.Columns["f_ini"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            Dgvplanilla1.Columns["ape_nom"].ReadOnly = true;
            Dgvplanilla1.Columns["regi_pen"].ReadOnly = true;
            Dgvplanilla1.Columns["codigo"].ReadOnly = true;
            Dgvplanilla1.Columns["cargo"].ReadOnly = true;
            Dgvplanilla1.Columns["f_ini"].ReadOnly = true;
            Dgvplanilla1.Columns["remu"].ReadOnly = true;

            Dgvplanilla1.Columns["remu"].DefaultCellStyle.Format = "N2";
            Dgvplanilla1.Columns["remu"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            Dgvplanilla1.Columns["a_familiar"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            Dgvplanilla1.Columns["sueldo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            Dgvplanilla1.Columns["dgv_dias"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
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
            Dgvplanilla1.Columns["ndias"].ReadOnly = false;
            Dgvplanilla1.Columns["montosub"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            Dgvplanilla1.Columns["montosub"].ReadOnly = false;
            Dgvplanilla1.Columns["ndiasnega"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Dgvplanilla1.Columns["ndiasnega"].ReadOnly = false;
            Dgvplanilla1.Columns["montonega"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            Dgvplanilla1.Columns["montonega"].ReadOnly = false;
            Dgvplanilla1.Columns["ndiasposi"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Dgvplanilla1.Columns["ndiasposi"].ReadOnly = false;
            Dgvplanilla1.Columns["montoposi"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            Dgvplanilla1.Columns["montoposi"].ReadOnly = false;

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
                nplam.PId_mes = 9; //PlanillaCache.p_idmes;
                nplam.PId_empreMaestra = 1; // UserCache.Codigo_empresa;
                //nplam.PFecha_inicio = Convert.ToDateTime(TxtfechaInicio.Text);
                //nplam.PFecha_fin = Convert.ToDateTime(TxtfechaFin.Text);
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
                double tardanzasub = 0, p_unomayo = 0, reintegr = 0, p_otroreintegro = 0, vacacion = 0, vaca_trun = 0, grati_tru = 0, boni_tru = 0, cts_tru = 0;
                double subtotal1 = 0, p_prest_alimen = 0, p_grati = 0, p_boni = 0, subtotal2 = 0, totalsub = 0;

                suel = dar.Cells["sueldo"].Value == null ? 0 : Convert.ToDouble(dar.Cells["sueldo"].Value);
                asigfami = dar.Cells["a_familiar"].Value == null ? 0 : Convert.ToDouble(dar.Cells["a_familiar"].Value);
                monto_sub = dar.Cells["montosub"].Value == null ? 0 : Convert.ToDouble(dar.Cells["montosub"].Value);
                montonegasub = dar.Cells["montonega"].Value == null ? 0 : Convert.ToDouble(dar.Cells["montonega"].Value);
                montoposisub = dar.Cells["montoposi"].Value == null ? 0 : Convert.ToDouble(dar.Cells["montoposi"].Value);               
                tardanzasub = dar.Cells["montotarde"].Value == null ? 0 : Convert.ToDouble(dar.Cells["montotarde"].Value);
                p_unomayo = dar.Cells["unomayo"].Value == null ? 0 : Convert.ToDouble(dar.Cells["unomayo"].Value);//variable
                totalHorasEx = dar.Cells["thoras"].Value == null ? 0 : Convert.ToDouble(dar.Cells["thoras"].Value);
                reintegr = dar.Cells["reintegro"].Value == null ? 0 : Convert.ToDouble(dar.Cells["reintegro"].Value);
                p_otroreintegro = dar.Cells["otros_reintegros"].Value == null ? 0 : Convert.ToDouble(dar.Cells["otros_reintegros"].Value);//variable
                p_prest_alimen = dar.Cells["prestacion_alimenta"].Value == null ? 0 : Convert.ToDouble(dar.Cells["prestacion_alimenta"].Value);//variable
                p_grati = dar.Cells["grati"].Value == null ? 0 : Convert.ToDouble(dar.Cells["grati"].Value);//variable
                p_boni = dar.Cells["boni"].Value == null ? 0 : Convert.ToDouble(dar.Cells["boni"].Value);//variable
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
                decimal p_totaremu = 0, p_transporte = 0, p_recarconsumo = 0, p_regrati = 0, p_reboni = 0;
                decimal p_totadescuen = 0, p_subto;

                p_totaremu = dar.Cells["totaremu"].Value == null ? 0 : Convert.ToDecimal(dar.Cells["totaremu"].Value);
                p_transporte = dar.Cells["transporte"].Value == null ? 0 : Convert.ToDecimal(dar.Cells["transporte"].Value);
                p_recarconsumo = dar.Cells["recargo_consumo"].Value == null ? 0 : Convert.ToDecimal(dar.Cells["recargo_consumo"].Value);
                p_regrati = dar.Cells["reintegro_grati"].Value == null ? 0 : Convert.ToDecimal(dar.Cells["reintegro_grati"].Value);
                p_reboni = dar.Cells["reintegro_boni"].Value == null ? 0 : Convert.ToDecimal(dar.Cells["reintegro_boni"].Value);
                p_totadescuen = dar.Cells["totades"].Value == null ? 0 : Convert.ToDecimal(dar.Cells["totades"].Value);

                p_subto = ((p_totaremu + p_transporte + p_recarconsumo + p_regrati + p_reboni) - p_totadescuen);
                dar.Cells["topagar"].Value = p_subto.ToString("N2");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        // DESCUENTO O.N.P  Y A.F.P y LOS CONCEPTOS QUE NO ESTAN AFECTOS
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

        //METODOS PARA LOS SUBSIDIOS NEGA, POSI Y BONI NOCTURNA, PARA DETERMINAR HORAS DIARIAS 
        private int BonificacionNocturna(DataGridViewRow d)
        {
            int p_boniNoct = 0;
            p_boniNoct = d.Cells["hrboninocturna"].Value == null ? 0 : Convert.ToInt32(d.Cells["hrboninocturna"].Value);
            return p_boniNoct;
        }

        private int SubsidiosMayorVeinte(DataGridViewCellEventArgs e)
        {
            int subMv = 0;
            subMv = Dgvplanilla1.Rows[e.RowIndex].Cells["ndias"].Value == null ? 0 : Convert.ToInt32(Dgvplanilla1.Rows[e.RowIndex].Cells["ndias"].Value);
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
        private double HorasDiarias(DataGridViewRow dgr, int hrboninoc, int p_diasubnega, int p_diasubposi)
        {
            int pdias = 0, pdiaDominical = 0, tdias_subsidio = 0;//total dias subsidiado
            double horaTrabajada = 0;       
                      
            pdias = dgr.Cells["dgv_dias"].Value == null ? 0 : Convert.ToInt32(dgr.Cells["dgv_dias"].Value);

            pdiaDominical = dgr.Cells["dia_dominical"].Value == null ? 0 : Convert.ToInt32(dgr.Cells["dia_dominical"].Value);

            tdias_subsidio = (p_diasubnega + p_diasubposi);//suma de sub negativo y positivo para restar a dias trabajados

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
        private decimal SueldoPorMes(DataGridViewRow dar)
        {
            decimal p_sueldo = 0, p_basico = 0, p_subsidioposi = 0;
            int p_dias = 0;

            int diasMes = Convert.ToInt32(txtdiasMes.Text);
            p_basico = Convert.ToDecimal(dar.Cells["remu"].Value);
            p_dias = dar.Cells["dgv_dias"].Value == null ? 0 : Convert.ToInt32(dar.Cells["dgv_dias"].Value);
            p_subsidioposi = dar.Cells["montoposi"].Value == null ? 0 : Convert.ToDecimal(dar.Cells["montoposi"].Value);

            if (diasMes == 30)
            {
                if(diasMes <=30)
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

            return (p_sueldo - p_subsidioposi);
        }

        //SOBRE CARGA DE METODO
        private decimal SueldoPorMes(DataGridViewRow dar, int dia_vacacione)
        {
            decimal p_sueldo = 0, p_basico = 0, p_subsidioposi = 0;
            int p_dias = 0;

            int diasMes = Convert.ToInt32(txtdiasMes.Text);
            p_basico = Convert.ToDecimal(dar.Cells["remu"].Value);
            p_dias = dar.Cells["dgv_dias"].Value == null ? 0 : Convert.ToInt32(dar.Cells["dgv_dias"].Value);
            p_subsidioposi = dar.Cells["montoposi"].Value == null ? 0 : Convert.ToDecimal(dar.Cells["montoposi"].Value);

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

            return (p_sueldo - p_subsidioposi);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Dgvplanilla1.Rows.Add();
            //dgvplanilla1.BeginEdit(true);           
        }

      
        private void FrmPlanillaMensual_Load(object sender, EventArgs e)
        {
            //CheckConceptos();
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
                    decimal p_sueldo=0;
                    
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
                    h_trabajada = HorasDiarias(dar, horanoc, SusidiosNegativo(e), SusidiosPositivo(e));
                    
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

                    hr_trabajada = HorasDiarias(dar, pboniNocturno, SusidiosNegativo(e), SusidiosPositivo(e));
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
            TotalRemuneracion();
            Descuento_aportes(dar);

            //DESCUENTOS
            switch (e.ColumnIndex)
            {
                case 63:
                case 64:
                case 65:
                case 66:
                case 67:
                case 68:
                    decimal p_saludvida = 0, p_adela = 0, p_presta = 0, p_renta = 0, p_rentencion = 0;
                    decimal p_otrodes = 0, p_totaldes = 0;

                    p_saludvida = dar.Cells["essalud_vida"].Value == null ? 0 : Convert.ToDecimal(dar.Cells["essalud_vida"].Value);
                    p_adela = dar.Cells["adelant"].Value == null ? 0 : Convert.ToDecimal(dar.Cells["adelant"].Value);
                    p_presta = dar.Cells["prestam"].Value == null ? 0 : Convert.ToDecimal(dar.Cells["prestam"].Value);
                    p_renta = dar.Cells["renta5cate"].Value == null ? 0 : Convert.ToDecimal(dar.Cells["renta5cate"].Value);
                    p_rentencion = dar.Cells["retencionj"].Value == null ? 0 : Convert.ToDecimal(dar.Cells["retencionj"].Value);
                    p_otrodes = dar.Cells["otrodes"].Value == null ? 0 : Convert.ToDecimal(dar.Cells["otrodes"].Value);

                    p_totaldes = (p_saludvida + p_adela + p_presta + p_renta + p_rentencion + p_otrodes);
                    dar.Cells["totades"].Value = p_totaldes.ToString("N2");

                    break;
                default:
                    break;
            }
            TotalAPagar(dar);

        }
             
        //AQUI ESTAMOS USANDO TIPO DATO DECIMAL
        private void Dgvplanilla1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                int diames = txtdiasMes.Text.Trim() == string.Empty ? 0 : Convert.ToInt32(txtdiasMes.Text.Trim());
                DataGridViewRow dar= Dgvplanilla1.CurrentRow;
                int dias = 0, diapo = 0, boniNoc = 0, p_diavaca = 0;
                double hro_trabajada = 0;
                decimal monto = 0, monto_posi = 0, monto_sueldo = 0;
                //decimal xvacaciones = 0; 
                decimal p_remu = 0, p_asigF = 0, suel_porMes = 0;


                void ValoresInicial()
                {
                    p_remu = Convert.ToDecimal(Dgvplanilla1.Rows[e.RowIndex].Cells["remu"].Value);
                    p_asigF = Dgvplanilla1.Rows[e.RowIndex].Cells["a_familiar"].Value == null ? 0 : Convert.ToDecimal(Dgvplanilla1.Rows[e.RowIndex].Cells["a_familiar"].Value);                    
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
                    dias = SubsidiosMayorVeinte(e);
                    monto = Calculo.MontoSubsidios(dias, p_remu, p_asigF, diames);
                    Dgvplanilla1.Rows[e.RowIndex].Cells["montosub"].Value = monto.ToString("N2");

                    if (diames == dias)
                        monto = (monto - p_asigF);
                    if (diames == 31)
                    {
                        if (dias == 30)
                            monto = (monto - p_asigF);
                    }

                    p_diavaca = dar.Cells["dgvdia_vaca"].Value == null ? 0 : Convert.ToInt32(dar.Cells["dgvdia_vaca"].Value);
                    monto_sueldo = SueldoPorMes(dar, p_diavaca);
                    //monto_sueldo = dar.Cells["sueldo"].Value == null ? 0 : Convert.ToDecimal(dar.Cells["sueldo"].Value);
                    monto_sueldo = (monto_sueldo - monto);
                    dar.Cells["sueldo"].Value = monto_sueldo.ToString("N2");

                    TotalRemuneracion();
                    Descuento_aportes(dar);
                    TotalAPagar(dar);
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
                    //xvacaciones = Calculo.MontoSubsidios(xdia_vacaciones, p_remu, diames); --borro
                    if(xdia_subposi > 0)
                        monto_posi = Calculo.MontoSubsidios(xdia_subposi, p_remu, diames);

                    //monto_v = (monto_posi); -- borro
                    boniNoc = BonificacionNocturna(dar); //OBTENEMOS VALOR BONI NOCTUR.
                    hro_trabajada = HorasDiarias(dar, boniNoc, dias, diapo); // Y LO RESTAMOS EN HORA. TRABAJADAS.
                    if(xdia_subposi > 0)
                        Dgvplanilla1.Rows[e.RowIndex].Cells["montoposi"].Value = monto_posi.ToString("N2");

                    ValorHorasDiarias(dar, hro_trabajada);

                    //OBTENGO EL DIA DE VACACIONES PARA PODER RESTAR A LOS DIAS LABORADOS.
                    p_diavaca = dar.Cells["dgvdia_vaca"].Value == null ? 0 : Convert.ToInt32(dar.Cells["dgvdia_vaca"].Value);
                    suel_porMes = SueldoPorMes(dar, p_diavaca);//EL VALOR DEL SUBSIDIO POSITIVO LO VA RESTAR AL SUELDO.
                    dar.Cells["sueldo"].Value = suel_porMes.ToString("N2");
                    TotalRemuneracion();
                    Descuento_aportes(dar);
                    TotalAPagar(dar);
                    xdia_subposi = 0;
                }
            }
        }
        //.........

        private void tbtnsalir_Click(object sender, EventArgs e)
        {
            FrmPlanillaEmpleados plaem = (FrmPlanillaEmpleados)Owner;

            //plaem.btncerrar.Enabled = true;
            //plaem.toolmenu.Visible = true;
            this.Close();
        }       

        private void dgvplanilla1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
             {

                Dgvplanilla1.Rows[e.RowIndex].Cells["ape_nom"].Style.ForeColor = Color.Crimson;
                //DataGridViewRow dar = dgvplanilla1.CurrentRow;
                //if (dgvplanilla1.Rows[e.RowIndex].Cells["btnnosubsidio"].Selected)
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
            WindowsMove.ReleaseCapture();
            WindowsMove.SendMessage(this.Handle, 0x112, 0xf012, 0);
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
                Dgvplanilla1.Rows[e.RowIndex].Cells["ape_nom"].Style.ForeColor = SystemColors.WindowText;
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

        //coloca numeracion en header cell, pero tienes que hacer click para que se coloque.
        //private void Dgvplanilla1_RowEnter(object sender, DataGridViewCellEventArgs e)
        //{

        //    this.Dgvplanilla1.Rows[e.RowIndex].HeaderCell.Value = (e.RowIndex + 1).ToString();

        //}


       //this.Dgvplanilla1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.Dgvplanilla1_RowPostPaint);
        
        //Coloca Numeracion en HeaderCell.
        private void Dgvplanilla1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(Dgvplanilla1.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 8, e.RowBounds.Location.Y + 4);
            }
        }
    
    }
}
