﻿using Datos.Contract;
using Datos.Entities;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Datos.Repositories
{
    public class Rsucursal : IEmpresa_maestra
    {
        Int32 result;
        public int Add(DempresaMaestra entiti)
        {
            result = 0;
            using (SqlConnection conn = RConexion.Getconectar())
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    conn.Open();

                    cmd.Connection = conn;
                    cmd.CommandText = "SP_INSERT_EMPRESA_MAESTRA";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@razon_social", SqlDbType.VarChar, 50).Value = entiti.Razon_social;
                    cmd.Parameters.Add("@direccion", SqlDbType.NVarChar, 250).Value = entiti.Direccion;
                    cmd.Parameters.Add("@domicilio", SqlDbType.NVarChar, 250).Value = entiti.Domicilio;
                    cmd.Parameters.Add("@ruc", SqlDbType.Char, 11).Value = entiti.Ruc;
                    cmd.Parameters.Add("@regimen", SqlDbType.VarChar, 50).Value = entiti.Regimen;
                    cmd.Parameters.Add("@localidad", SqlDbType.VarChar, 50).Value = entiti.Localidad;
                    cmd.Parameters.Add("@cod_empresa_validar", SqlDbType.VarChar, 50).Value = entiti.Scodigo_sucursal;
                    cmd.Parameters.Add("@mesage", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;

                    using (SqlCommand cmd1 = new SqlCommand())
                    {
                        cmd1.Connection = conn;
                        cmd1.CommandText = "SP_INSERT_SUCURSAL";
                        cmd1.CommandType = CommandType.StoredProcedure;

                        cmd1.Parameters.Add("@cod_sucursal", SqlDbType.VarChar, 8).Value = entiti.Scodigo_sucursal;
                        cmd1.Parameters.Add("@id_empresa", SqlDbType.Int).Value = entiti.Sid_empresa;
                        result = cmd.ExecuteNonQuery();
                        entiti.mesages = cmd.Parameters["@mesage"].Value.ToString();

                        if (result > 0)
                        {
                            result = cmd1.ExecuteNonQuery();
                        }
                        cmd.Parameters.Clear();
                        cmd1.Parameters.Clear();
                    }
                }
                return result;
            }
        }

        public int Edit(DempresaMaestra entiti)
        {
            result = 0;
            using (SqlConnection conn = RConexion.Getconectar())
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    conn.Open();

                    cmd.Connection = conn;
                    cmd.CommandText = "SP_UPDATE_EMPRESAMAESTRA";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@razon_social", SqlDbType.VarChar, 50).Value = entiti.Razon_social;
                    cmd.Parameters.Add("@direccion", SqlDbType.NVarChar, 250).Value = entiti.Direccion;
                    cmd.Parameters.Add("@domicilio", SqlDbType.NVarChar, 250).Value = entiti.Domicilio;
                    cmd.Parameters.Add("@ruc", SqlDbType.Char, 11).Value = entiti.Ruc;
                    cmd.Parameters.Add("@regimen", SqlDbType.VarChar, 50).Value = entiti.Regimen;
                    cmd.Parameters.Add("@localidad", SqlDbType.VarChar, 50).Value = entiti.Localidad;
                    cmd.Parameters.Add("@id_emmaestra", SqlDbType.Int).Value = entiti.Eidemp_maestra;

                    using (SqlCommand cmd1 = new SqlCommand())
                    {
                        cmd1.Connection = conn;
                        cmd1.CommandText = "SP_UPDATE_SUCURSAL";
                        cmd1.CommandType = CommandType.StoredProcedure;

                        cmd1.Parameters.Add("@cod_sucursal", SqlDbType.VarChar, 8).Value = entiti.Scodigo_sucursal;
                        cmd1.Parameters.Add("@id_empresa", SqlDbType.Int).Value = entiti.Sid_empresa;
                        cmd1.Parameters.Add("@id_emmaestra", SqlDbType.Int).Value = entiti.Eidemp_maestra;
                        result = cmd.ExecuteNonQuery();

                        if (result > 0)
                            result = cmd1.ExecuteNonQuery();

                        cmd.Parameters.Clear();
                        cmd1.Parameters.Clear();
                    }
                }
                return result;
            }
        }
        public int Delete(DempresaMaestra entiti)
        {
            result = 0;
            using (SqlConnection cnn = RConexion.Getconectar())
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cnn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "SP_REMOVE_SUCURSAL";

                    cmd.Parameters.AddWithValue("@id_maestra", entiti.Sidem_maestra);
                    cmd.Parameters.Add("@mesage", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;
                    result = cmd.ExecuteNonQuery();
                    entiti.mesages = cmd.Parameters["@mesage"].Value.ToString();
                    cmd.Parameters.Clear();
                   
                }
            }
            return result;
        }
        public DataTable GetData(DempresaMaestra entiti)
        {
            DataTable dt=null;
            using (SqlConnection cnn = RConexion.Getconectar())
            {
                cnn.Open();

                SqlDataAdapter da = new SqlDataAdapter();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cnn;
                    cmd.CommandText = "SP_SHOW_SUCURSAL";
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
