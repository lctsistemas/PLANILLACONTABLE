﻿using Datos.Contract;
using Datos.Entities;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Datos.Repositories
{
    public class RRegimen : IRegimen
    {
        Int32 result;
        SqlCommand cmd;
        public int Add(DRegimen entiti)
        {
            result = 0;
            using (SqlConnection conn = RConexion.Getconectar())
            {
                conn.Open();
                cmd = null;
                using (cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SP_ADD_REGIMEN";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@descripcion_corta", entiti.Descripcion_corta);
                    cmd.Parameters.AddWithValue("@descripcion", entiti.Descripcion);
                    cmd.Parameters.AddWithValue("@tipo_regimen", entiti.Tipo_regimen);
                    cmd.Parameters.Add("@mensaje", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;

                    result = cmd.ExecuteNonQuery();
                    entiti.mensaje = cmd.Parameters["@mensaje"].Value.ToString();
                    cmd.Parameters.Clear();
                }
            }
            return result;
        }

        public int Edit(DRegimen entiti)
        {
            result = 0;
            using (SqlConnection conect = RConexion.Getconectar())
            {
                conect.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conect;
                    cmd.CommandText = "SP_UPDATE_REGIMEN";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@descripcion_corta", entiti.Descripcion_corta);
                    cmd.Parameters.AddWithValue("@descripcion", entiti.Descripcion);
                    cmd.Parameters.AddWithValue("@tipo_regimen", entiti.Tipo_regimen);
                    cmd.Parameters.AddWithValue("@codigo_regimen", entiti.Codigo_regimen);
                    result = cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                }
            }
            return result;
        }

        public int Delete(DRegimen entiti)
        {
            result = 0;
            using (SqlConnection conn = RConexion.Getconectar())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SP_DELETE_REGIMEN";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@codigo_regimen", entiti.Codigo_regimen);
                    cmd.Parameters.Add("@mensaje", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
                    result = cmd.ExecuteNonQuery();
                    entiti.mensaje = cmd.Parameters["@mensaje"].Value.ToString();
                    cmd.Parameters.Clear();                   
                }
            }
            return result;
        }

     

        public DataTable GetData(DRegimen entiti)
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
                    cmd.CommandText = "SP_SHOW_REGIMENPENSIONARIO";
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
