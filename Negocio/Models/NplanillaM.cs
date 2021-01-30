using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Datos.Entities;
using System.Data;
using Datos.Repositories;

namespace Negocio.Models
{
    public class NplanillaM:IDisposable
    {
        public int PId_contrato { get; set;}//1
        public int Pid_planilla { get; set; }//2
        public int Pm_id_tipoplanilla { get; set; }//3
        public string PJornada_laboral { get; set; }//4
        public string PCod_documento { get; set; }
        public int PId_mes { get; set;}
        public int PId_empreMaestra { get; set;}
        public string PNumero_documento { get; set;}
        public string PNombres { get; set;}
        public string PDescrip_regipension { get; set;}//5
        public decimal PVcomision { get; set; }//6
        public decimal PVseguro { get; set; }//7
        public decimal PVaporte { get; set; }//8
        public string PCargop { get; set; }//9     
        public decimal Pm_basico { get; set; }//10
        public int Pm_dias { get; set; } //11
        public int Pm_diadominical { get; set; } //12
        public decimal Pm_horasdiarias { get; set; }//13
        public DateTime PFecha_inicio { get; set; }
        public DateTime PFecha_fin { get; set; }
        public string Premune_basica { get; set; }//14
        public string PAsig_familiar { get; set; }//15
        public string Pm_hora_dvc { get; set; }//16
        public string Pm_minuto_dvc { get; set; }//17
        public string Pm_monto_dvc { get; set; }//18
        public string Pm_hora_dtc { get; set; }//19
        public string Pm_minuto_dtc { get; set; }//20
        public string Pm_monto_dtc { get; set; }//21
        public string Pm_hora_nvc { get; set; }//22
        public string Pm_minuto_nvc { get; set; }//23
        public string Pm_monto_nvc { get; set; }//24
        public string Pm_hora_ntc { get; set; }//25
        public string Pm_minuto_ntc { get; set; }//26
        public string Pm_monto_ntc { get; set; }//27
        public string Pm_hora_feriado { get; set; }//28
        public string Pm_minuto_feriado { get; set; }//29
        public string Pm_monto_feriado { get; set; }//30
        public string Pm_hora_boni { get; set; }//31
        public string Pm_monto_boni { get; set; }//32
        public string Pm_uno_mayo { get; set; }//33
        public string Pm_hora_tarde { get; set; }//34
        public string Pm_minuto_tarde { get; set; }//35
        public string Pm_monto_tarde { get; set; }//36
        public string Pm_dia_sub { get; set; }//37
        public string Pm_monto_sub { get; set; }//38
        public string Pm_dia_subnegativo { get; set; }//39
        public string Pm_monto_subnegativo { get; set; }//40
        public string Pm_dia_subpositivo { get; set; }//41
        public string Pm_monto_subpositivo { get; set; }//42
        public string Pm_total_horaex { get; set; }//43
        public string Pm_reintegro { get; set; }//44
        public string Pm_otro_reintegro { get; set; }//45
        public string Pm_pre_alimentaria { get; set; }//46
        public string Pm_gratiex { get; set; }//47
        public string Pm_boniex { get; set; }//48
        public string Pm_vacaciones { get; set; }//49
        public string Pm_vaca_trunca { get; set; }//50
        public string Pm_grati_trunca { get; set; }//51
        public string Pm_boni_trunca { get; set; }//52
        public string Pm_cts_trunca { get; set; }//53
        public string Pm_total_remuneracion { get; set; }//54
        public string Pm_descuento_onp { get; set; }//55
        public string Pm_des_comision { get; set; }//56
        public string Pm_des_seguro { get; set; }//57
        public string Pm_des_spp { get; set; }//58
        public string Pm_essalud_vida { get; set; }//59
        public string Pm_adelanto { get; set; }//60
        public string Pm_prestamo { get; set; }//61
        public string Pm_renta_quinta { get; set; }//62
        public string Pm_retencion_judicial { get; set; }//63
        public string Pm_otro_des { get; set; }//64
        public string Pm_total_desc { get; set; }//65
        public string Pm_total_pagar { get; set; }//66
        public string Pm_aporte_essalud { get; set; }//67
        public string Pm_transporte { get; set; }//68
        public string Pm_recargo_consumo { get; set; }//69
        public string Pm_reintegro_grati { get; set; }//70
        public string Pm_reintegro_boni { get; set; }//71
        public string Pm_dia_vacaciones { get; set; }//72
        public List<NplanillaM> ListNpm { get; set; }

        private List<NplanillaM> list_planillam;
        DplanillaM dplam;
        RplanillaM rplam;

        public NplanillaM()
        {
            dplam = new DplanillaM();
            rplam = new RplanillaM();
        }

        //METODO SAVE PLANILLA MANTO.
        public string SavePlanilaManto()
        {
            int i = 0;
            string message;

            if (dplam.ListDpm == null)
                dplam.ListDpm = new List<DplanillaM>();
           
            foreach (NplanillaM item in ListNpm)
            {
                dplam.ListDpm.Add(new DplanillaM()
                {
                    Pid_contrato = item.PId_contrato,
                    Pm_id_planilla = item.Pid_planilla,
                    Pm_id_tipoplanilla = item.Pm_id_tipoplanilla,
                    Pm_jornada_laboral = item.PJornada_laboral,
                    Pdescrip_regipension = item.PDescrip_regipension,
                    Pcomision = item.PVcomision,
                    Pseguro = item.PVseguro,
                    Paporte = item.PVaporte,
                    Pcargop = item.PCargop,
                    Pm_basico = item.Pm_basico,
                    Pm_dias = item.Pm_dias,
                    Pm_diadominical = item.Pm_diadominical,
                    Pm_horasdiarias = item.Pm_horasdiarias,
                    Premune_basica = item.Premune_basica,
                    Pasig_familiar = item.PAsig_familiar,
                    Pm_hora_dvc = item.Pm_hora_dvc,
                    Pm_minuto_dvc = item.Pm_minuto_dvc,
                    Pm_monto_dvc = item.Pm_monto_dvc,
                    Pm_hora_dtc = item.Pm_hora_dtc,
                    Pm_minuto_dtc = item.Pm_minuto_dtc,
                    Pm_monto_dtc = item.Pm_monto_dtc,
                    Pm_hora_nvc = item.Pm_hora_nvc,
                    Pm_minuto_nvc = item.Pm_minuto_nvc,
                    Pm_monto_nvc = item.Pm_monto_nvc,
                    Pm_hora_ntc = item.Pm_hora_ntc,
                    Pm_minuto_ntc = item.Pm_minuto_ntc,
                    Pm_monto_ntc = item.Pm_monto_ntc,
                    Pm_hora_feriado = item.Pm_hora_feriado,
                    Pm_minuto_feriado = item.Pm_minuto_feriado,
                    Pm_monto_feriado = item.Pm_monto_feriado,
                    Pm_hora_boni = item.Pm_hora_boni,
                    Pm_monto_boni = item.Pm_monto_boni,
                    Pm_uno_mayo = item.Pm_uno_mayo,
                    Pm_hora_tarde = item.Pm_hora_tarde,
                    Pm_minuto_tarde = item.Pm_minuto_tarde,
                    Pm_monto_tarde = item.Pm_monto_tarde,
                    Pm_dia_sub = item.Pm_dia_sub,
                    Pm_monto_sub = item.Pm_monto_sub,
                    Pm_dia_subnegativo = item.Pm_dia_subnegativo,
                    Pm_monto_subnegativo = item.Pm_monto_subnegativo,
                    Pm_dia_subpositivo = item.Pm_dia_subpositivo,
                    Pm_monto_subpositivo = item.Pm_monto_subpositivo,
                    Pm_total_horaex = item.Pm_total_horaex,
                    Pm_reintegro = item.Pm_reintegro,
                    Pm_otro_reintegro = item.Pm_otro_reintegro,
                    Pm_pre_alimentaria = item.Pm_pre_alimentaria,
                    Pm_gratiex = item.Pm_gratiex,
                    Pm_boniex = item.Pm_boniex,
                    Pm_vacaciones = item.Pm_vacaciones,
                    Pm_vaca_trunca = item.Pm_vaca_trunca,
                    Pm_grati_trunca = item.Pm_grati_trunca,
                    Pm_boni_trunca = item.Pm_boni_trunca,
                    Pm_cts_trunca = item.Pm_cts_trunca,
                    Pm_total_remuneracion = item.Pm_total_remuneracion,
                    Pm_descuento_onp = item.Pm_descuento_onp,
                    Pm_des_comision = item.Pm_des_comision,
                    Pm_des_seguro = item.Pm_des_seguro,
                    Pm_des_spp = item.Pm_des_spp,
                    Pm_essalud_vida = item.Pm_essalud_vida,
                    Pm_adelanto = item.Pm_adelanto,
                    Pm_prestamo = item.Pm_prestamo,
                    Pm_renta_quinta = item.Pm_renta_quinta,
                    Pm_retencion_judicial = item.Pm_retencion_judicial,
                    Pm_otro_des = item.Pm_otro_des,
                    Pm_total_desc = item.Pm_total_desc,
                    Pm_total_pagar = item.Pm_total_pagar,
                    Pm_aporte_essalud = item.Pm_aporte_essalud,
                    Pm_transporte = item.Pm_transporte,
                    Pm_recargo_consumo = item.Pm_recargo_consumo,
                    Pm_reintegro_grati = item.Pm_reintegro_grati,
                    Pm_reintegro_boni = item.Pm_reintegro_boni,
                    Pm_dia_vacaciones = item.Pm_dia_vacaciones

                });
            }
            i = rplam.SavePlanillaM(dplam);
            dplam.ListDpm.Clear();

            if (i > 0)
                message = "¡Registrado correctamente!";
            else
                message = "Error";

            return message;
        }


        //MOSTRAR PLANILLA MANTO
        public IEnumerable<NplanillaM> Show_planillaM()
        {
            list_planillam = new List<NplanillaM>();
                        
            dplam.Pid_mes = PId_mes;
            dplam.Pm_id_planilla = Pid_planilla;
            dplam.Pid_empreMaestra= PId_empreMaestra;
            dplam.Pfecha_inicio = PFecha_inicio;
            dplam.Pfecha_fin = PFecha_fin;

            using (DataTable dt = new RplanillaM().Show_planillaM(dplam))
            {
                foreach (DataRow item in dt.Rows)
                {
                    list_planillam.Add(new NplanillaM()
                    {
                        PId_contrato = Convert.ToInt32(item[0]),
                        PJornada_laboral = item[1].ToString(),
                        PCod_documento = item[2].ToString(),
                        PNumero_documento = item[3].ToString(),
                        PNombres = item[4].ToString(),
                        PDescrip_regipension = item[5].ToString(),
                        PVcomision = Convert.ToDecimal(item[6]),        
                        PVseguro = Convert.ToDecimal(item[7]),             
                        PVaporte = Convert.ToDecimal(item[8]),
                        PCargop = item[9].ToString(),
                        PFecha_inicio = Convert.ToDateTime(item[10]),
                        //PFecha_fin = Convert.ToDateTime(item[11]),                   
                        Pm_basico = Convert.ToDecimal(item[12]),
                        //PAsig_familiar = item[13].ToString() == "0.00" || item[13].ToString() == "0,00" ? null : item[13].ToString()
                        PAsig_familiar = item[13].ToString() == "0.00" ? null : item[13].ToString()
                        //PAsig_familiar = item[13].ToString().Replace(",",".") == "0.00" ? null : item[13].ToString()
                       
                    });
                }
            }
            return list_planillam;
        }


        //MUESTRA LA PRUEBA
        public DataTable Show_planillaPrueba(NplanillaM entity)
        {
            dplam.Pm_id_planilla = entity.Pid_planilla;
            dplam.Pid_mes = entity.PId_mes;
            return new RplanillaM().Show_planillaPrueba(dplam);

        }

        public void Dispose()
        {

        }

    }
}
