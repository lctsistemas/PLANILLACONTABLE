﻿using Datos.Contract;
using Datos.Entities;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Datos.Repositories
{
    public class Rdocumento : IDocumento
    {
        Int32 result = 0;
        //AGREGAR
        public int Add(DtipoDocumento entiti)
        {
            result = 0;
            using (SqlConnection conn = RConexion.Getconectar())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SP_REGISTRAR_DOCUMENTO";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@nom", entiti.Nombre_documento);
                    cmd.Parameters.AddWithValue("@descripcion", entiti.Descripcion);
                    cmd.Parameters.AddWithValue("@cod_doc", entiti.Cod_doc);
                    cmd.Parameters.Add("@mensaje", SqlDbType.VarChar, 25).Direction = ParameterDirection.Output;
                    result = cmd.ExecuteNonQuery();
                    entiti.message = cmd.Parameters["@mensaje"].Value.ToString();
                    cmd.Parameters.Clear();                    
                }
            }
            return result;
        }
        //EDITAR
        public int Edit(DtipoDocumento entiti)
        {
            result = 0;
            using (SqlConnection conn = RConexion.Getconectar())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SP_UPDATE_DOCUMENTO";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@nom", SqlDbType.VarChar, 50).Value = entiti.Nombre_documento;
                    cmd.Parameters.Add("@descripcion", SqlDbType.NVarChar, 100).Value = entiti.Descripcion;
                    cmd.Parameters.Add("@iddocumento", SqlDbType.Int).Value = entiti.Iddocumento;
                    cmd.Parameters.Add("@cod_doc", SqlDbType.Char,2).Value = entiti.Cod_doc;
                    result = cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();               
                }
            }
            return result;
        }

        //ELIMINAR
        public int Delete(DtipoDocumento entiti)
        {
            result = 0;
            using (SqlConnection conn = RConexion.Getconectar())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SP_DELETE_DOCUMENTO";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@iddocumento", SqlDbType.Int).Value = entiti.Iddocumento;
                    cmd.Parameters.Add("@message", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
                    result = cmd.ExecuteNonQuery();
                    entiti.message = cmd.Parameters["@message"].Value.ToString();
                    cmd.Parameters.Clear();
                    return result;
                }
            }
        }

        //SHOW DATA
        public DataTable GetData(DtipoDocumento entiti)
        {
            DataTable dt;
            using (var conect = RConexion.Getconectar())
            {
                conect.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conect;
                    cmd.CommandText = "SP_SELECT_DOCUMENTO";

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
