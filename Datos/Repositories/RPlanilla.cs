using Datos.Contract;
using Datos.Entities;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Datos.Repositories
{
    public class RPlanilla : IPlanilla
    {
        Int32 result;
        SqlCommand cmd;
        public int Add(DPlanilla entiti)
        {
            result = 0;
            using (SqlConnection connect = RConexion.Getconectar())
            {
                connect.Open();
                using (cmd = new SqlCommand())
                {
                    cmd.Connection = connect;
                    cmd.CommandText = "SP_INSERT_PLANILLA";
                    cmd.CommandType = CommandType.StoredProcedure;

                    // cmd.Parameters.Add("@id_tipo_planilla", SqlDbType.Int).Value = entiti.Id_tipo_planilla;
                    cmd.Parameters.Add("@id_planilla", SqlDbType.Int).Value = entiti.Id_planilla;
                    cmd.Parameters.Add("@id_periodo", SqlDbType.Int).Value = entiti.Id_periodo;
                    cmd.Parameters.Add("@id_empresa", SqlDbType.Int).Value = entiti.Id_empresa;
                    cmd.Parameters.Add("@mes", SqlDbType.VarChar, 20).Value = entiti.Mes;
                    cmd.Parameters.Add("@fecha_inicial", SqlDbType.Date).Value = entiti.Fecha_inicial;
                    cmd.Parameters.Add("@fecha_final", SqlDbType.Date).Value = entiti.Fecha_final;
                    cmd.Parameters.Add("@fecha_pago", SqlDbType.Date).Value = entiti.Fecha_pago;
                    cmd.Parameters.Add("@dias_mes", SqlDbType.Int).Value = entiti.Dias_mes;
                    cmd.Parameters.Add("@horas_mes", SqlDbType.Int).Value = entiti.Horas_mes;
                    cmd.Parameters.Add("@remu_basica", SqlDbType.Decimal).Value = entiti.Remu_basica;
                    cmd.Parameters.Add("@asig_familiar", SqlDbType.Decimal).Value = entiti.Asig_familiar;
                    cmd.Parameters.Add("@tope_horario_nocturno", SqlDbType.Int).Value = entiti.Tope_horario_nocturno;



                    cmd.Parameters.Add("@mesage", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
                    result = cmd.ExecuteNonQuery();
                    entiti.mensaje = cmd.Parameters["@mesage"].Value.ToString();
                    cmd.Parameters.Clear();

                    return result;
                }
            }
        }

        public int Edit(DPlanilla entiti)
        {
            result = 0;
            using (SqlConnection cnn = RConexion.Getconectar())
            {
                cnn.Open();
                cmd = null;
                using (cmd = new SqlCommand())
                {
                    cmd.Connection = cnn;
                    cmd.CommandText = "SP_UPDATE_PLANILLA";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@id_planilla", SqlDbType.Int).Value = entiti.Id_planilla;
                    cmd.Parameters.Add("@fecha_pago", SqlDbType.Date).Value = entiti.Fecha_pago;

                    result = cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    return result;
                }
            }
        }

        public int Delete(DPlanilla entiti)
        {
            result = 0;
            using (SqlConnection conn = RConexion.Getconectar())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SP_DELETE_PLANILLA";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@idplanilla", SqlDbType.Int).Value = entiti.Id_planilla;
                    cmd.Parameters.Add("@mensaje", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
                    result = cmd.ExecuteNonQuery();
                    entiti.mensaje = cmd.Parameters["@mensaje"].Value.ToString();
                    cmd.Parameters.Clear();
                    return result;
                }
            }
        }

        public DataTable GetData(DPlanilla entiti)
        {
            using (SqlConnection cnn = RConexion.Getconectar())
            {
                cnn.Open();
                cmd = null;
                SqlDataAdapter da = new SqlDataAdapter();
                using (cmd = new SqlCommand())
                {
                    cmd.Connection = cnn;
                    cmd.CommandText = "SP_SHOW_PLANILLA";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@codigo_empresa", SqlDbType.Int).Value = entiti.Id_empresa;

                    da.SelectCommand = cmd;

                    using (DataTable dt = new DataTable())
                    {
                        da.Fill(dt);
                        da.Dispose();
                        return dt;
                    }
                }
            }
        }
    }
}
