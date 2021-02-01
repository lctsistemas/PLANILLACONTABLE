using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using Datos.Entities;

namespace Datos.Repositories
{
    public class RplanillaM:IDisposable
    {
        int result;
        public int AddPlanillaManto(DplanillaM dpm)
        {
            result = 0;
            using (SqlConnection conect = RConexion.Getconectar())
            {
                conect.Open();
                try
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandText = "SP_REGISTRAR_PLANILLAMANTO";
                        cmd.Connection = conect;
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@id_contrato", dpm.Pid_contrato);
                        cmd.Parameters.AddWithValue("@id_planilla", dpm.Pm_id_planilla);
                        cmd.Parameters.AddWithValue("@id_tipo_planilla", dpm.Pm_id_tipoplanilla);
                        cmd.Parameters.AddWithValue("@jornadalaboral", dpm.Pm_jornada_laboral);
                        cmd.Parameters.AddWithValue("@pregimen_pension", dpm.Pdescrip_regipension);
                        cmd.Parameters.AddWithValue("@pvalor_comision", dpm.Pcomision);
                        cmd.Parameters.AddWithValue("@pvalor_seguro", dpm.Pseguro);
                        cmd.Parameters.AddWithValue("@pvalor_aporte", dpm.Paporte);
                        cmd.Parameters.AddWithValue("@pcargo", dpm.Pcargop);
                        cmd.Parameters.AddWithValue("@basico", dpm.Pm_basico);
                        cmd.Parameters.AddWithValue("@dias", dpm.Pm_dias);
                        cmd.Parameters.AddWithValue("@dia_dominical", dpm.Pm_diadominical);
                        cmd.Parameters.AddWithValue("@horas_diarias", dpm.Pm_horasdiarias);
                        cmd.Parameters.AddWithValue("@sueldo_basico", dpm.Premune_basica);
                        cmd.Parameters.AddWithValue("@asig_familiar", dpm.Pasig_familiar);
                        cmd.Parameters.AddWithValue("@hora_dvc", dpm.Pm_hora_dvc);
                        cmd.Parameters.AddWithValue("@minuto_dvc", dpm.Pm_minuto_dvc);
                        cmd.Parameters.AddWithValue("@monto_dvc", dpm.Pm_monto_dvc);
                        cmd.Parameters.AddWithValue("@hora_dtc", dpm.Pm_hora_dtc);
                        cmd.Parameters.AddWithValue("@minuto_dtc", dpm.Pm_minuto_dtc);
                        cmd.Parameters.AddWithValue("@monto_dtc", dpm.Pm_monto_dtc);
                        cmd.Parameters.AddWithValue("@hora_nvc", dpm.Pm_hora_nvc);
                        cmd.Parameters.AddWithValue("@minuto_nvc", dpm.Pm_minuto_nvc);
                        cmd.Parameters.AddWithValue("@monto_nvc", dpm.Pm_monto_nvc);
                        cmd.Parameters.AddWithValue("@hora_ntc", dpm.Pm_hora_ntc);
                        cmd.Parameters.AddWithValue("@minuto_ntc", dpm.Pm_minuto_ntc);
                        cmd.Parameters.AddWithValue("@monto_ntc", dpm.Pm_monto_ntc);
                        cmd.Parameters.AddWithValue("@hora_feriado", dpm.Pm_hora_feriado);
                        cmd.Parameters.AddWithValue("@minuto_feriado", dpm.Pm_minuto_feriado);
                        cmd.Parameters.AddWithValue("@monto_feriado", dpm.Pm_monto_feriado);
                        cmd.Parameters.AddWithValue("@hora_boni", dpm.Pm_hora_boni);
                        cmd.Parameters.AddWithValue("@monto_boni", dpm.Pm_monto_boni);
                        cmd.Parameters.AddWithValue("@uno_mayo", dpm.Pm_uno_mayo);
                        cmd.Parameters.AddWithValue("@hora_tarde", dpm.Pm_hora_tarde);
                        cmd.Parameters.AddWithValue("@minuto_tarde", dpm.Pm_minuto_tarde);
                        cmd.Parameters.AddWithValue("@monto_tarde", dpm.Pm_monto_tarde);
                        cmd.Parameters.AddWithValue("@dia_sub", dpm.Pm_dia_sub);
                        cmd.Parameters.AddWithValue("@monto_sub", dpm.Pm_monto_sub);
                        cmd.Parameters.AddWithValue("@dia_subnegativo", dpm.Pm_dia_subnegativo);
                        cmd.Parameters.AddWithValue("@monto_subnegativo", dpm.Pm_monto_subnegativo);
                        cmd.Parameters.AddWithValue("@dia_subpositivo", dpm.Pm_dia_subpositivo);
                        cmd.Parameters.AddWithValue("@monto_subpositivo", dpm.Pm_monto_subpositivo);
                        cmd.Parameters.AddWithValue("@total_horaex", dpm.Pm_total_horaex);
                        cmd.Parameters.AddWithValue("@reintegro", dpm.Pm_reintegro);
                        cmd.Parameters.AddWithValue("@otro_reintegro", dpm.Pm_otro_reintegro);
                        cmd.Parameters.AddWithValue("@pre_alimentaria", dpm.Pm_pre_alimentaria);
                        cmd.Parameters.AddWithValue("@gratiex", dpm.Pm_gratiex);
                        cmd.Parameters.AddWithValue("@boniex", dpm.Pm_boniex);
                        cmd.Parameters.AddWithValue("@vacaciones", dpm.Pm_vacaciones);
                        cmd.Parameters.AddWithValue("@vaca_trunca", dpm.Pm_vaca_trunca);
                        cmd.Parameters.AddWithValue("@grati_trunca", dpm.Pm_grati_trunca);
                        cmd.Parameters.AddWithValue("@boni_trunca", dpm.Pm_boni_trunca);
                        cmd.Parameters.AddWithValue("@cts_trunca", dpm.Pm_cts_trunca);
                        cmd.Parameters.AddWithValue("@total_remuneracion", dpm.Pm_total_remuneracion);
                        cmd.Parameters.AddWithValue("@descuento_onp", dpm.Pm_descuento_onp);
                        cmd.Parameters.AddWithValue("@des_comision", dpm.Pm_des_comision);
                        cmd.Parameters.AddWithValue("@des_seguro", dpm.Pm_des_seguro);
                        cmd.Parameters.AddWithValue("@des_spp", dpm.Pm_des_spp);
                        cmd.Parameters.AddWithValue("@essalud_vida", dpm.Pm_essalud_vida);
                        cmd.Parameters.AddWithValue("@adelanto", dpm.Pm_adelanto);
                        cmd.Parameters.AddWithValue("@prestamo", dpm.Pm_prestamo);
                        cmd.Parameters.AddWithValue("@renta_quinta", dpm.Pm_renta_quinta);
                        cmd.Parameters.AddWithValue("@retencion_judicial", dpm.Pm_retencion_judicial);
                        cmd.Parameters.AddWithValue("@otro_des", dpm.Pm_otro_des);
                        cmd.Parameters.AddWithValue("@total_desc", dpm.Pm_total_desc);
                        cmd.Parameters.AddWithValue("@total_pagar", dpm.Pm_total_pagar);
                        cmd.Parameters.AddWithValue("@aporte_essalud", dpm.Pm_aporte_essalud);
                        cmd.Parameters.AddWithValue("@transporte", dpm.Pm_transporte);
                        cmd.Parameters.AddWithValue("@recargo_consumo", dpm.Pm_recargo_consumo);
                        cmd.Parameters.AddWithValue("@reintegro_grati", dpm.Pm_reintegro_grati);
                        cmd.Parameters.AddWithValue("@reintegro_boni", dpm.Pm_reintegro_boni);
                        cmd.Parameters.AddWithValue("@dia_vacaciones", dpm.Pm_dia_vacaciones);                    
                        result = cmd.ExecuteNonQuery();
                                  
                    }

                }
                catch (Exception ex)
                {
                    dpm.mensaje = ex.Message;
                }
            }
            return result;
        }

        //GUARDAR PLANILLA MANTO
        public int SavePlanillaM(DplanillaM lispm)
        {
            int i = 0;
            foreach (DplanillaM item in lispm.ListDpm)
            {
                i = AddPlanillaManto(item);
            }
            return i;
        }


        public DataTable Show_planillaM(DplanillaM entity)
        {
            DataTable dt = null;
            using (SqlConnection conect = RConexion.Getconectar())
            {
                conect.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conect;
                    cmd.CommandText = "SP_ShowPlanillaManto";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@idplanilla", entity.Pm_id_planilla);
                    cmd.Parameters.AddWithValue("@idmes", entity.Pid_mes);
                    cmd.Parameters.AddWithValue("@id_empresaMaestra", entity.Pid_empreMaestra);
                    //cmd.Parameters.AddWithValue("@fechaini", entity.Pfecha_inicio);
                    cmd.Parameters.AddWithValue("@fechafin", entity.Pfecha_fin);
                    SqlDataReader reader = cmd.ExecuteReader();
                    using (dt = new DataTable())
                    {
                        if (reader.HasRows)
                        {
                            dt.Load(reader);
                            reader.Close();
                        }
                    }
                }
            }
            return dt;
        }


        public DataTable Show_planillaPrueba(DplanillaM entity)
        {
            DataTable dt = null;
            using (SqlConnection conect = RConexion.Getconectar())
            {
                conect.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conect;
                    cmd.CommandText = "SP_SHOW_PLANILLAMANTO_PRUEBA";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@idplanilla", entity.Pm_id_planilla);
                    cmd.Parameters.AddWithValue("@idmes", entity.Pid_mes);

                    SqlDataReader reader = cmd.ExecuteReader();
                    using (dt = new DataTable())
                    {
                        if (reader.HasRows)
                        {
                            dt.Load(reader);
                            reader.Close();
                        }
                    }
                }
            }
            return dt;
        }

        public void Dispose()
        {
            //throw new NotImplementedException();
           
        }
    }
}
