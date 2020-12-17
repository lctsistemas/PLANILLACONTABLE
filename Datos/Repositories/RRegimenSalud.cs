﻿using Datos.Contract;
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
                    
                    cmd.Parameters.AddWithValue("@cod_regi_salud", entiti.Cod_regi_salud);
                    cmd.Parameters.AddWithValue("@descripcion_rsalud", entiti.Descripcion);
                    cmd.Parameters.Add("@mensaje", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;

                    result = cmd.ExecuteNonQuery();                   
                    entiti.mensaje = cmd.Parameters["@mensaje"].Value.ToString();
                    cmd.Parameters.Clear();                    
                }
            }
            return result;
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
<<<<<<< HEAD
                    cmd.Connection = cnn;
                    cmd.CommandText = "SP_UPDATE_REG_SALUD";
=======
                    cmd.Connection = conn;
                    cmd.CommandText = "SP_DELETE_REGSALUD";
>>>>>>> 9ecc0a3925277b6f0d6e3a348e63b93b44d2521a
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id_regimen_salud", entiti.Id_regimen_salud);
                    cmd.Parameters.AddWithValue("@cod_regimen_salud", entiti.Cod_regi_salud);
                    cmd.Parameters.AddWithValue("@descripcion_rsalud", entiti.Descripcion);

                    result = cmd.ExecuteNonQuery();
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
