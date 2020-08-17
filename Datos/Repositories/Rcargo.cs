using Datos.Contract;
using Datos.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
namespace Datos.Repositories
{
    public class Rcargo : IRepository
    {
        Int32 result = 0;

        public int Add(Dcargo entiti)
        {
            result = 0;
            using (SqlConnection conect = RConexion.Getconectar())
            {
                conect.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conect;
                    cmd.CommandText = "SP_REGISTRAR_CARGO";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@nom", SqlDbType.VarChar, 40).Value = entiti.Nombre_cargo;
                    cmd.Parameters.Add("@descripcion", SqlDbType.NVarChar, 100).Value = entiti.Descripcion;
                    result = cmd.ExecuteNonQuery();

                    cmd.Parameters.Clear();
                    return result;
                }
            }

        }

        public int Edit(Dcargo entiti)
        {
            result = 0;
            using (SqlConnection conect = RConexion.Getconectar())
            {
                conect.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conect;
                    cmd.CommandText = "SP_UPDATE_CARGO";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@nom", SqlDbType.VarChar, 40).Value = entiti.Nombre_cargo;
                    cmd.Parameters.Add("@descripcion", SqlDbType.NVarChar, 100).Value = entiti.Descripcion;
                    cmd.Parameters.Add("@idcargo", SqlDbType.Int).Value = entiti.Idcargo;
                    result = cmd.ExecuteNonQuery();

                    cmd.Parameters.Clear();
                    return result;
                }
            }
        }

        public int Delete(Dcargo entiti)
        {
            result = 0;
            using (SqlConnection conect = RConexion.Getconectar())
            {
                conect.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conect;
                    cmd.CommandText = "SP_DELETE_CARGO";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@idcargo", SqlDbType.Int).Value = entiti.Idcargo;
                    cmd.Parameters.Add("@message", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
                    result = cmd.ExecuteNonQuery();
                    entiti.Message = cmd.Parameters["@message"].Value.ToString();
                    cmd.Parameters.Clear();
                    return result;
                }
            }
        }

        //MOSTRAR
        public DataTable GetData(Dcargo entiti)
        {
            using (var conect = RConexion.Getconectar())
            {
                conect.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conect;
                    cmd.CommandText = "SP_SELECT_CARGO";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@nom", SqlDbType.VarChar, 40).Value = entiti.Nombre_cargo;
                    da.SelectCommand = cmd;

                    using (var dt = new DataTable())
                    {
                        da.Fill(dt);
                        da.Dispose();
                        cmd.Parameters.Clear();
                        return dt;
                    }
                }
            }
        }
    }
}
