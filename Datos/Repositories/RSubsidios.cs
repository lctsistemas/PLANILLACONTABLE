﻿using Datos.Contract;
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
                    cmd.Parameters.Add("@descripcion_subsidio", SqlDbType.Int).Value = entiti.Descripcion_subsidio;
                    cmd.Parameters.Add("@tipo_subsidio", SqlDbType.Int).Value = entiti.Tipo_subsidio;
                    cmd.Parameters.Add("@descuento", SqlDbType.Int).Value = entiti.Descuento;
                    result = cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                }
            }
            return result;
        }

        public int Delete(DSubsidios entiti)
        {
            throw new NotImplementedException();
        }

        public int Edit(DSubsidios entiti)
        {
            throw new NotImplementedException();
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
