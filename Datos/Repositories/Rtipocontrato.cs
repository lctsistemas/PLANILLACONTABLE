﻿using Datos.Contract;
using Datos.Entities;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Datos.Repositories
{
    public class Rtipocontrato : ITipo_contrato
    {
        Int32 result;
        SqlCommand cmd;
        public int Add(Dtipocontrato entiti)
        {
            int result = 0;
            using (SqlConnection conn = RConexion.Getconectar())
            {
                conn.Open();
                using (cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SP_INSERT_TIP_CONT";
                    cmd.CommandType = CommandType.StoredProcedure;
                  
                    cmd.Parameters.AddWithValue("@tiempo_contrato", entiti.Tipo_contrato);
                    cmd.Parameters.Add("@mensaje", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;

                    result = cmd.ExecuteNonQuery();
                    entiti.Mensaje = cmd.Parameters["@mensaje"].Value.ToString();
                    cmd.Parameters.Clear();                   
                }
            }
            return result;
        }

       

        public int Edit(Dtipocontrato entiti)
        {
            result = 0;
            using (SqlConnection cnn = RConexion.Getconectar())
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cnn;
                    cmd.CommandText = "SP_UPDATE_TIP_CONT";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id_tip_cont", entiti.Id_tcontrato);
                    cmd.Parameters.AddWithValue("@tipo_contrato", entiti.Tipo_contrato);

                    result = cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();                   
                }
            }
            return result;
        }
        public int Delete(Dtipocontrato entiti)
        {
            result = 0;

            using (SqlConnection conn = RConexion.Getconectar())
            {
                conn.Open();
                cmd = null;
                using (cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SP_DELETE_TIPCONTRATO";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id_tcontrato", entiti.Id_tcontrato);
                    cmd.Parameters.Add("@message", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
                    result = cmd.ExecuteNonQuery();

                    entiti.Mensaje = cmd.Parameters["@message"].Value.ToString();
                    cmd.Parameters.Clear();                    
                }
            }
            return result;
        }

        public DataTable GetData(Dtipocontrato entiti)
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
                    cmd.CommandText = "SP_SHOW_TIP_CONT";
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
