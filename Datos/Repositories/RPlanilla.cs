using Datos.Contract;
using Datos.Entities;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Datos.Repositories
{
    public class RPlanilla : IPlanilla, IDisposable
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

                    // cmd.Parameters.Add("@idtipo_planilla", SqlDbType.Int).Value = entiti.Id_tipo_planilla;                  
                    cmd.Parameters.AddWithValue("@id_periodo", entiti.Id_periodo);
                    cmd.Parameters.AddWithValue("@id_empMaestra", entiti.Id_empresam);
                    cmd.Parameters.AddWithValue("@id_mes", entiti.Id_mes);
                    cmd.Parameters.AddWithValue("@fecha_inicial", entiti.Fecha_inicial);
                    cmd.Parameters.AddWithValue("@fecha_final",  entiti.Fecha_final);
                    cmd.Parameters.AddWithValue("@fecha_pago",  entiti.Fecha_pago);
                    cmd.Parameters.AddWithValue("@dias_mes",  entiti.Dias_mes);
                    cmd.Parameters.AddWithValue("@horas_mes", entiti.Horas_mes);                
                    cmd.Parameters.AddWithValue("@topehora_nocturno", entiti.Tope_horario_nocturno);
                    cmd.Parameters.Add("@mesage", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
                    result = cmd.ExecuteNonQuery();

                    entiti.mensaje = cmd.Parameters["@mesage"].Value.ToString();
                    cmd.Parameters.Clear();                    
                }
            }
            return result;
        }

        public int Edit(DPlanilla entiti) // modificar
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

                    cmd.Parameters.AddWithValue("@idplanilla", entiti.Id_planilla);
                    cmd.Parameters.Add("@mensaje", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
                    result = cmd.ExecuteNonQuery();
                    entiti.mensaje = cmd.Parameters["@mensaje"].Value.ToString();
                    cmd.Parameters.Clear();                    
                }
            }
            return result;
        }


        public DataTable GetData(DPlanilla entiti)
        {
            DataTable dt = null;
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
                    cmd.Parameters.AddWithValue("@codigo_empresam", entiti.Id_empresam);
                    cmd.Parameters.AddWithValue("@periodo", entiti.Id_periodo);
                    da.SelectCommand = cmd;

                    using (dt = new DataTable())
                    {
                        da.Fill(dt);
                        da.Dispose();                       
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
