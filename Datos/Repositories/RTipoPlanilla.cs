using Datos.Contract;
using Datos.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Repositories
{
    public class RTipoPlanilla : ITipoPlanilla
    {
        Int32 result;
        SqlCommand cmd;
        public int Add(DTipoPlanilla entiti)
        {
            result = 0;
            using (SqlConnection connect = RConexion.Getconectar())
            {
                connect.Open();
                using (cmd = new SqlCommand())
                {
                    cmd.Connection = connect;
                    cmd.CommandText = "SP_INS_TIP_PLANILLA";
                    cmd.CommandType = CommandType.StoredProcedure;

                    //cmd.Parameters.Add("@id_banco", SqlDbType.Int).Value = entiti.IdBanco;
                    cmd.Parameters.Add("@tipoplanilla", SqlDbType.VarChar, 25).Value = entiti.TipoPlanilla;

                    cmd.Parameters.Add("@mensaje", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
                    result = cmd.ExecuteNonQuery();
                    entiti.mensaje = cmd.Parameters["@mensaje"].Value.ToString();
                    cmd.Parameters.Clear();

                    return result;
                }
            }
        }

        public int Delete(DTipoPlanilla entiti)
        {
            result = 0;
            using (SqlConnection conn = RConexion.Getconectar())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SP_DELETE_TIP_PLAN";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@id_tipo_planilla", SqlDbType.Int).Value = entiti.Idtipoplanilla;
                    cmd.Parameters.Add("@mensaje", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
                    result = cmd.ExecuteNonQuery();
                    entiti.mensaje = cmd.Parameters["@mensaje"].Value.ToString();
                    cmd.Parameters.Clear();
                    return result;
                }
            }
        }

        public int Edit(DTipoPlanilla entiti)
        {
            throw new NotImplementedException();
        }

        public DataTable GetData(DTipoPlanilla entiti)
        {
            DataTable dt;
            using (SqlConnection cnn = RConexion.Getconectar())
            {
                cnn.Open();
                cmd = null;
                SqlDataAdapter da = new SqlDataAdapter();
                using (cmd = new SqlCommand())
                {
                    cmd.Connection = cnn;
                    cmd.CommandText = "SP_SHOW_TIPO_PLAN";
                    cmd.CommandType = CommandType.StoredProcedure;
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
    }
}
