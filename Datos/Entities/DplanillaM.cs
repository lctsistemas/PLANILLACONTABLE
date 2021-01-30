using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entities
{
    public class DplanillaM
    {
        private int pid_contrato; //1
        private int pm_id_planilla;//2
        private int pm_id_tipoplanilla;//3
        private string pm_jornada_laboral;//4
        private int pid_mes;
        private int pid_empreMaestra;
        private string pnumero_documento;
        private string pnombres;
        private string pdescrip_regipension;//5
        private decimal pcomision;//6
        private decimal pseguro;//7
        private decimal paporte;//8
        private string pcargop;//9
        private decimal pm_basico;//10
        private int pm_dias;//11
        private int pm_diadominical;//12
        private decimal pm_horasdiarias;//13
        private DateTime pfecha_inicio;
        private DateTime pfecha_fin;
        private string premune_basica;//14
        private string pasig_familiar;//15
        private string pm_hora_dvc;//16
        private string pm_minuto_dvc;//17
        private string pm_monto_dvc;//18
        private string pm_hora_dtc;//19
        private string pm_minuto_dtc;//20
        private string pm_monto_dtc;//21
        private string pm_hora_nvc;//22
        private string pm_minuto_nvc;//23
        private string pm_monto_nvc;//24
        private string pm_hora_ntc;//25
        private string pm_minuto_ntc;//26
        private string pm_monto_ntc;//27
        private string pm_hora_feriado;//28
        private string pm_minuto_feriado;//29
        private string pm_monto_feriado;//30
        private string pm_hora_boni;//31
        private string pm_monto_boni;//32
        private string pm_uno_mayo;//33
        private string pm_hora_tarde;//34
        private string pm_minuto_tarde;//35
        private string pm_monto_tarde;//36
        private string pm_dia_sub;//37
        private string pm_monto_sub;//38
        private string pm_dia_subnegativo;//39
        private string pm_monto_subnegativo;//40
        private string pm_dia_subpositivo;//41
        private string pm_monto_subpositivo;//42
        private string pm_total_horaex;//43
        private string pm_reintegro;//44
        private string pm_otro_reintegro;//45
        private string pm_pre_alimentaria;//46
        private string pm_gratiex;//47
        private string pm_boniex;//48
        private string pm_vacaciones;//49
        private string pm_vaca_trunca;//50
        private string pm_grati_trunca;//51
        private string pm_boni_trunca;//52
        private string pm_cts_trunca;//53
        private string pm_total_remuneracion;//54
        private string pm_descuento_onp;//55
        private string pm_des_comision;//56
        private string pm_des_seguro;//57
        private string pm_des_spp;//58
        private string pm_essalud_vida;//59
        private string pm_adelanto;//60
        private string pm_prestamo;//61
        private string pm_renta_quinta;//62
        private string pm_retencion_judicial;//63
        private string pm_otro_des;//64
        private string pm_total_desc;//65
        private string pm_total_pagar;//66
        private string pm_aporte_essalud;//67
        private string pm_transporte;//68
        private string pm_recargo_consumo;//69
        private string pm_reintegro_grati;//70
        private string pm_reintegro_boni;//71
        private string pm_dia_vacaciones;//72
        public string mensaje { get; set; }
        public List<DplanillaM> ListDpm { get; set; }
        public int Pid_contrato { get => pid_contrato; set => pid_contrato = value; }
        public int Pm_id_planilla { get => pm_id_planilla; set => pm_id_planilla = value; }
        public int Pm_id_tipoplanilla { get => pm_id_tipoplanilla; set => pm_id_tipoplanilla = value; }
        public string Pm_jornada_laboral { get => pm_jornada_laboral; set => pm_jornada_laboral = value; }
        public int Pid_mes { get => pid_mes; set => pid_mes = value; }
        public int Pid_empreMaestra { get => pid_empreMaestra; set => pid_empreMaestra = value; }
        public string Pnumero_documento { get => pnumero_documento; set => pnumero_documento = value; }
        public string Pnombres { get => pnombres; set => pnombres = value; }
        public string Pdescrip_regipension { get => pdescrip_regipension; set => pdescrip_regipension = value; }
        public decimal Pcomision { get => pcomision; set => pcomision = value; }
        public decimal Pseguro { get => pseguro; set => pseguro = value; }
        public decimal Paporte { get => paporte; set => paporte = value; }
        public string Pcargop { get => pcargop; set => pcargop = value; }
        public decimal Pm_basico { get => pm_basico; set => pm_basico = value; }
        public int Pm_dias { get => pm_dias; set => pm_dias = value; }
        public int Pm_diadominical { get => pm_diadominical; set => pm_diadominical = value; }
        public decimal Pm_horasdiarias { get => pm_horasdiarias; set => pm_horasdiarias = value; }
        public DateTime Pfecha_inicio { get => pfecha_inicio; set => pfecha_inicio = value; }
        public DateTime Pfecha_fin { get => pfecha_fin; set => pfecha_fin = value; }
        public string Premune_basica { get => premune_basica; set => premune_basica = value; }
        public string Pasig_familiar { get => pasig_familiar; set => pasig_familiar = value; }
        public string Pm_hora_dvc { get => pm_hora_dvc; set => pm_hora_dvc = value; }
        public string Pm_minuto_dvc { get => pm_minuto_dvc; set => pm_minuto_dvc = value; }
        public string Pm_monto_dvc { get => pm_monto_dvc; set => pm_monto_dvc = value; }
        public string Pm_hora_dtc { get => pm_hora_dtc; set => pm_hora_dtc = value; }
        public string Pm_minuto_dtc { get => pm_minuto_dtc; set => pm_minuto_dtc = value; }
        public string Pm_monto_dtc { get => pm_monto_dtc; set => pm_monto_dtc = value; }
        public string Pm_hora_nvc { get => pm_hora_nvc; set => pm_hora_nvc = value; }
        public string Pm_minuto_nvc { get => pm_minuto_nvc; set => pm_minuto_nvc = value; }
        public string Pm_monto_nvc { get => pm_monto_nvc; set => pm_monto_nvc = value; }
        public string Pm_hora_ntc { get => pm_hora_ntc; set => pm_hora_ntc = value; }
        public string Pm_minuto_ntc { get => pm_minuto_ntc; set => pm_minuto_ntc = value; }
        public string Pm_monto_ntc { get => pm_monto_ntc; set => pm_monto_ntc = value; }
        public string Pm_hora_feriado { get => pm_hora_feriado; set => pm_hora_feriado = value; }
        public string Pm_minuto_feriado { get => pm_minuto_feriado; set => pm_minuto_feriado = value; }
        public string Pm_monto_feriado { get => pm_monto_feriado; set => pm_monto_feriado = value; }
        public string Pm_hora_boni { get => pm_hora_boni; set => pm_hora_boni = value; }
        public string Pm_monto_boni { get => pm_monto_boni; set => pm_monto_boni = value; }
        public string Pm_uno_mayo { get => pm_uno_mayo; set => pm_uno_mayo = value; }
        public string Pm_hora_tarde { get => pm_hora_tarde; set => pm_hora_tarde = value; }
        public string Pm_minuto_tarde { get => pm_minuto_tarde; set => pm_minuto_tarde = value; }
        public string Pm_monto_tarde { get => pm_monto_tarde; set => pm_monto_tarde = value; }
        public string Pm_dia_sub { get => pm_dia_sub; set => pm_dia_sub = value; }
        public string Pm_monto_sub { get => pm_monto_sub; set => pm_monto_sub = value; }
        public string Pm_dia_subnegativo { get => pm_dia_subnegativo; set => pm_dia_subnegativo = value; }
        public string Pm_monto_subnegativo { get => pm_monto_subnegativo; set => pm_monto_subnegativo = value; }
        public string Pm_dia_subpositivo { get => pm_dia_subpositivo; set => pm_dia_subpositivo = value; }
        public string Pm_monto_subpositivo { get => pm_monto_subpositivo; set => pm_monto_subpositivo = value; }
        public string Pm_total_horaex { get => pm_total_horaex; set => pm_total_horaex = value; }
        public string Pm_reintegro { get => pm_reintegro; set => pm_reintegro = value; }
        public string Pm_otro_reintegro { get => pm_otro_reintegro; set => pm_otro_reintegro = value; }
        public string Pm_pre_alimentaria { get => pm_pre_alimentaria; set => pm_pre_alimentaria = value; }
        public string Pm_gratiex { get => pm_gratiex; set => pm_gratiex = value; }
        public string Pm_boniex { get => pm_boniex; set => pm_boniex = value; }
        public string Pm_vacaciones { get => pm_vacaciones; set => pm_vacaciones = value; }
        public string Pm_vaca_trunca { get => pm_vaca_trunca; set => pm_vaca_trunca = value; }
        public string Pm_grati_trunca { get => pm_grati_trunca; set => pm_grati_trunca = value; }
        public string Pm_boni_trunca { get => pm_boni_trunca; set => pm_boni_trunca = value; }
        public string Pm_cts_trunca { get => pm_cts_trunca; set => pm_cts_trunca = value; }
        public string Pm_total_remuneracion { get => pm_total_remuneracion; set => pm_total_remuneracion = value; }
        public string Pm_descuento_onp { get => pm_descuento_onp; set => pm_descuento_onp = value; }
        public string Pm_des_comision { get => pm_des_comision; set => pm_des_comision = value; }
        public string Pm_des_seguro { get => pm_des_seguro; set => pm_des_seguro = value; }
        public string Pm_des_spp { get => pm_des_spp; set => pm_des_spp = value; }
        public string Pm_essalud_vida { get => pm_essalud_vida; set => pm_essalud_vida = value; }
        public string Pm_adelanto { get => pm_adelanto; set => pm_adelanto = value; }
        public string Pm_prestamo { get => pm_prestamo; set => pm_prestamo = value; }
        public string Pm_renta_quinta { get => pm_renta_quinta; set => pm_renta_quinta = value; }
        public string Pm_retencion_judicial { get => pm_retencion_judicial; set => pm_retencion_judicial = value; }
        public string Pm_otro_des { get => pm_otro_des; set => pm_otro_des = value; }
        public string Pm_total_desc { get => pm_total_desc; set => pm_total_desc = value; }
        public string Pm_total_pagar { get => pm_total_pagar; set => pm_total_pagar = value; }
        public string Pm_aporte_essalud { get => pm_aporte_essalud; set => pm_aporte_essalud = value; }
        public string Pm_transporte { get => pm_transporte; set => pm_transporte = value; }
        public string Pm_recargo_consumo { get => pm_recargo_consumo; set => pm_recargo_consumo = value; }
        public string Pm_reintegro_grati { get => pm_reintegro_grati; set => pm_reintegro_grati = value; }
        public string Pm_reintegro_boni { get => pm_reintegro_boni; set => pm_reintegro_boni = value; }
        public string Pm_dia_vacaciones { get => pm_dia_vacaciones; set => pm_dia_vacaciones = value; }
    }
}
