using Datos.Contract;
using Datos.Entities;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Datos.Repositories
{
    public class RBanco : IBanco
    {

        Int32 result;
        SqlCommand cmd;
        public int Add(DBanco entiti)
        {
            result = 0;
            using (SqlConnection connect = RConexion.Getconectar())
            {
                connect.Open();
                using (cmd = new SqlCommand())
                {
                    cmd.Connection = connect;
                    cmd.CommandText = "SP_INSERT_BANCO";
                    cmd.CommandType = CommandType.StoredProcedure;
                 
                    cmd.Parameters.AddWithValue("@nombre_banco", entiti.Nom_banco);

                    cmd.Parameters.Add("@mensaje", SqlDbType.VarChar, 30).Direction = ParameterDirection.Output;
                    result = cmd.ExecuteNonQuery();
                    entiti.mensaje = cmd.Parameters["@mensaje"].Value.ToString();
                    cmd.Parameters.Clear();                    
                }
            }
            return result;
        }        

        public int Edit(DBanco entiti)
        {
            result = 0;
            using (SqlConnection cnn = RConexion.Getconectar())
            {
                cnn.Open();
                cmd = null;
                using (cmd = new SqlCommand())
                {
                    cmd.Connection = cnn;
                    cmd.CommandText = "SP_UPDATE_BANCO";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id_banco", entiti.IdBanco);
                    cmd.Parameters.AddWithValue("@nombre_banco", entiti.Nom_banco);

                    result = cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();                   
                }
            }
            return result;
        }

        public int Delete(DBanco entiti)
        {
            result = 0;
            using (SqlConnection conn = RConexion.Getconectar())
            {
                conn.Open();
                cmd = null;
                using (cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SP_DEL_BANCO";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id_banco", entiti.IdBanco);
                    cmd.Parameters.Add("@message", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
                    result = cmd.ExecuteNonQuery();
                    entiti.mensaje = cmd.Parameters["@message"].Value.ToString();
                    cmd.Parameters.Clear();

                }
            }
            return result;

        }

        public DataTable GetData(DBanco entiti)
        {
            DataTable dt;
            using (SqlConnection conn = RConexion.Getconectar())
            {
                conn.Open();
                cmd = null;
                SqlDataAdapter da = new SqlDataAdapter();

                using (cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SP_SHOW_BANCO";
                    cmd.CommandType = CommandType.StoredProcedure;

                    da.SelectCommand = cmd;

                    using (dt= new DataTable())
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
