using Datos.Contract;
using Datos.Entities;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Datos.Repositories
{
    public class Rrol : IRol
    {
        Int32 resul;
        SqlCommand cmd;
        public int Add(Drol entiti)
        {
            resul = 0;
            using (SqlConnection cnn = RConexion.Getconectar())
            {
                cnn.Open();
                cmd = null;
                using (cmd = new SqlCommand())
                {
                    cmd.Connection = cnn;
                    cmd.CommandText = "SP_INSERT_ROL";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@rol", SqlDbType.VarChar, 30).Value = entiti.Nombre_rol;
                    resul = cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    return resul;
                }

            }
        }
        //EDIT
        public int Edit(Drol entiti)
        {
            resul = 0;
            using (SqlConnection cnn = RConexion.Getconectar())
            {
                cnn.Open();
                cmd = null;
                using (cmd = new SqlCommand())
                {
                    cmd.Connection = cnn;
                    cmd.CommandText = "SP_UPDATE_ROL";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@rol", SqlDbType.VarChar, 30).Value = entiti.Nombre_rol;
                    cmd.Parameters.Add("@idrol", SqlDbType.Int).Value = entiti.Idrol;
                    resul = cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    return resul;
                }

            }
        }
        //REMOVE
        public int Delete(Drol entiti)
        {
            resul = 0;
            using (SqlConnection cnn = RConexion.Getconectar())
            {
                cnn.Open();
                cmd = null;
                using (cmd = new SqlCommand())
                {
                    cmd.Connection = cnn;
                    cmd.CommandText = "SP_REMOVE_ROL";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@idrol", SqlDbType.Int).Value = entiti.Idrol;
                    cmd.Parameters.Add("@mesage", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
                    resul = cmd.ExecuteNonQuery();
                    entiti.mesage = cmd.Parameters["@mesage"].Value.ToString();
                    cmd.Parameters.Clear();
                    return resul;
                }

            }
        }
        //SHOW DATA
        public DataTable GetData(Drol entiti)
        {
            using (SqlConnection cnn = RConexion.Getconectar())
            {
                cnn.Open();
                cmd = null;
                SqlDataAdapter da = new SqlDataAdapter();
                using (cmd = new SqlCommand())
                {
                    cmd.Connection = cnn;
                    cmd.CommandText = "SP_SHOW_ROL";
                    cmd.CommandType = CommandType.StoredProcedure;
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
        //...
    }
}
