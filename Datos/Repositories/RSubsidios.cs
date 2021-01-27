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

                    cmd.Parameters.AddWithValue("@cod_subsidio", entiti.Cod_subsidios); 
                    cmd.Parameters.AddWithValue("@tipo_suspension", entiti.Tipo_supension);
                    cmd.Parameters.AddWithValue("@descripcion_corta", entiti.Descrip_corta);
                    cmd.Parameters.AddWithValue("@descripcion_subsidio", entiti.Descripcion_subsidio);
                    cmd.Parameters.AddWithValue("@tipo_subsidio", entiti.Tipo_subsidio);
                    cmd.Parameters.AddWithValue("@descuento", entiti.Descuento);
                    cmd.Parameters.Add("@mensaje", SqlDbType.VarChar, 25).Direction = ParameterDirection.Output;
                    result = cmd.ExecuteNonQuery();
                    entiti.mensaje = cmd.Parameters["@mensaje"].Value.ToString();
                    cmd.Parameters.Clear();
                }
            }
            return result;
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

                    cmd.Parameters.AddWithValue("@cod_subsidio", entiti.Cod_subsidios);
                    cmd.Parameters.AddWithValue("@tipo_suspension", entiti.Tipo_supension);
                    cmd.Parameters.AddWithValue("@descripcion_corta", entiti.Descrip_corta);
                    cmd.Parameters.AddWithValue("@descrip_subsidio", entiti.Descripcion_subsidio);
                    cmd.Parameters.AddWithValue("@tipo_subsidio", entiti.Tipo_subsidio);
                    cmd.Parameters.AddWithValue("@descuento", entiti.Descuento);
                    cmd.Parameters.AddWithValue("@id_subsidios", entiti.Id_subsidios);

                    result = cmd.ExecuteNonQuery();
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

                    cmd.Parameters.AddWithValue("@id_subsidios", entiti.Id_subsidios);
                    cmd.Parameters.Add("@mensaje", SqlDbType.VarChar, 60).Direction = ParameterDirection.Output;
                    result = cmd.ExecuteNonQuery();
                    entiti.mensaje = cmd.Parameters["@mensaje"].Value.ToString();
                    cmd.Parameters.Clear();                    
                }
            }
            return result;
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

                    cmd.Parameters.AddWithValue("@tip_subsidio", entiti.Tipo_subsidio);
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

                    cmd.Parameters.AddWithValue("@tipo_subsidio", Entity.Tipo_subsidio);
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
