using Datos.Contract;
using Datos.Entities;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Datos.Repositories
{

    public class RRegimenSalud : IRegimenSalud
    {
        Int32 result;
        SqlCommand cmd;

        public int Add(DRegimenSalud entiti)
        {
            result = 0;
            using (SqlConnection conn = RConexion.Getconectar())
            {
                conn.Open();
                cmd = null;
                using (cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SP_ADD_REG_SAL";
                    cmd.CommandType = CommandType.StoredProcedure;

                    //cmd.Parameters.Add("@id_regimen_salud", SqlDbType.Int).Value = entiti.Id_regimen_salud;
                    cmd.Parameters.Add("@cod_regi_salud", SqlDbType.Int).Value = entiti.Cod_regi_salud;
                    cmd.Parameters.Add("@regimen_salud", SqlDbType.VarChar, 80).Value = entiti.Descripcion;
                    cmd.Parameters.Add("@mensaje", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;

                    result = cmd.ExecuteNonQuery();
                    System.Windows.Forms.MessageBox.Show(""+result);
                    entiti.mensaje = cmd.Parameters["@mensaje"].Value.ToString();
                    cmd.Parameters.Clear();
                    return result;
                }
            }
        }

        public int Delete(DRegimenSalud entiti)
        {
            result = 0;
            using (SqlConnection conn = RConexion.Getconectar())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SP_DELETE_REG_SALUD";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@id_regimen_salud", SqlDbType.Int).Value = entiti.Id_regimen_salud;
                    cmd.Parameters.Add("@mensaje", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
                    result = cmd.ExecuteNonQuery();
                    entiti.mensaje = cmd.Parameters["@mensaje"].Value.ToString();
                    cmd.Parameters.Clear();
                    return result;
                }
            }
        }

        public int Edit(DRegimenSalud entiti)
        {
            result = 0;
            using (SqlConnection cnn = RConexion.Getconectar())
            {
                cnn.Open();
                cmd = null;
                using (cmd = new SqlCommand())
                {
                    cmd.Connection = cnn;
                    cmd.CommandText = "SP_UPDATE_REG_SALUD";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@id_regimen_salud", SqlDbType.Int).Value = entiti.Id_regimen_salud;
                    cmd.Parameters.Add("@cod_regimen_salud", SqlDbType.Int).Value = entiti.Cod_regi_salud;
                    cmd.Parameters.Add("@regimen_salud", SqlDbType.VarChar, 80).Value = entiti.Descripcion;

                    result = cmd.ExecuteNonQuery();
                    System.Windows.Forms.MessageBox.Show("update:  " + result);
                    cmd.Parameters.Clear();
                    return result;
                }
            }
        }

        public DataTable GetData(DRegimenSalud entiti)
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
                    cmd.CommandText = "SP_SHOW_REG_SALUD";
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
