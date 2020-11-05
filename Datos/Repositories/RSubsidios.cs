using Datos.Contract;
using Datos.Entities;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Datos.Repositories
{
    public class RSubsidios : ISubsidios
    {
        Int32 result;
        SqlCommand cmd;
        public int Add(DSubsidios entiti)
        {
            result = 0;
            cmd = null;
            using (SqlConnection connect = RConexion.Getconectar())
            {
                connect.Open();
                using (cmd = new SqlCommand())
                {
                    cmd.Connection = connect;
                    cmd.CommandText = "SP_ADD_SUBSIDIOS";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@id_subsidios", SqlDbType.Int).Value = entiti.Id_subsidios;
                    cmd.Parameters.Add("@cod_subsidio", SqlDbType.Int).Value = entiti.Cod_subsidios;                  
                    cmd.Parameters.Add("@tipo_suspension", SqlDbType.VarChar,10).Value = entiti.Tipo_supension;
                    cmd.Parameters.Add("@descripcion_corta", SqlDbType.NVarChar,70).Value = entiti.Descrip_corta;
                    cmd.Parameters.Add("@descripcion_subsidio", SqlDbType.NVarChar,100).Value = entiti.Descripcion_subsidio;
                    cmd.Parameters.Add("@tipo_subsidio", SqlDbType.VarChar,30).Value = entiti.Tipo_subsidio;
                    cmd.Parameters.Add("@descuento", SqlDbType.Bit).Value = entiti.Descuento;
                    cmd.Parameters.Add("@mensaje", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;


                    result = cmd.ExecuteNonQuery();
                    entiti.mensaje = cmd.Parameters["@mensaje"].Value.ToString();

                    cmd.Parameters.Clear();
                }
            }
            return result;
        }

        public int Delete(DSubsidios entiti)
        {
            result = 0;
            using (SqlConnection conn = RConexion.Getconectar())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SP_BORRAR_SUBSIDIOS";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@id_subsidios", SqlDbType.Int).Value = entiti.Id_subsidios;
                    cmd.Parameters.Add("@mensaje", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
                    result = cmd.ExecuteNonQuery();
                    entiti.mensaje = cmd.Parameters["@mensaje"].Value.ToString();
                    cmd.Parameters.Clear();
                    return result;
                }
            }
        }

        public int Edit(DSubsidios entiti)
        {
            result = 0;
            using (SqlConnection cnn = RConexion.Getconectar())
            {
                cnn.Open();
                cmd = null;
                using (cmd = new SqlCommand())
                {
                    cmd.Connection = cnn;
                    cmd.CommandText = "SP_MODIFY_SUBSIDIOS";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@cod_subsidio", SqlDbType.Char,2).Value = entiti.Cod_subsidios;
                    cmd.Parameters.Add("@tipo_suspension", SqlDbType.VarChar, 10).Value = entiti.Tipo_supension;
                    cmd.Parameters.Add("@descripcion_corta", SqlDbType.NVarChar, 70).Value = entiti.Descrip_corta;
                    cmd.Parameters.Add("@descrip_subsidio", SqlDbType.NVarChar, 100).Value = entiti.Descripcion_subsidio;
                    cmd.Parameters.Add("@tipo_subsidio", SqlDbType.VarChar, 30).Value = entiti.Tipo_subsidio;
                    cmd.Parameters.Add("@descuento", SqlDbType.Bit).Value = entiti.Descuento;
                    cmd.Parameters.Add("@id_subsidios", SqlDbType.Int).Value = entiti.Id_subsidios;


                    result = cmd.ExecuteNonQuery();
                    System.Windows.Forms.MessageBox.Show("update:  " + result);
                    cmd.Parameters.Clear();
                    return result;
                }
            }
        }

        public DataTable GetData(DSubsidios entiti)
        {
            DataTable dt = null;
            using (SqlConnection cnn = RConexion.Getconectar())
            {
                cnn.Open();
                using (cmd = new SqlCommand())
                {
                    cmd.Connection = cnn;
                    cmd.CommandText = "SP_MOSTRAR_SUBSIDIOS";
                    cmd.CommandType = CommandType.StoredProcedure;

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

        //mostrar en combox subsidios
        public DataTable ShowSubsidio(DSubsidios Entity)
        {
            DataTable dt = null;
            using (SqlConnection cnn = RConexion.Getconectar())
            {
                cnn.Open();
                using (cmd = new SqlCommand())
                {
                    cmd.Connection = cnn;
                    cmd.CommandText = "SP_SHOW_SUBSIDIOS";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@tipo_subsidio", SqlDbType.VarChar, 30).Value = Entity.Tipo_subsidio;
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

    }
}
