using Datos.Contract;
using Datos.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Datos.Repositories
{
    public class RDiasSubsidiados : IDiasSubsidiados, IDisposable
    {
        
        Int32 result;
        SqlCommand cmd;

        //AGREGAR
        public int Add(DDiasSubsidiados entiti)
        {
            result = 0;
            cmd = null;
            using (SqlConnection connect = RConexion.Getconectar())
            {
                connect.Open();
                using (cmd = new SqlCommand())
                {
                    cmd.Connection = connect;
                    cmd.CommandText = "SP_INSERT_SUBSIDIOS";
                    cmd.CommandType = CommandType.StoredProcedure;
                                       
                    cmd.Parameters.Add("@id_subsidios", SqlDbType.Int).Value = entiti.Id_subsidios;
                    cmd.Parameters.Add("@id_empleado", SqlDbType.Int).Value = entiti.Id_empleado;
                    cmd.Parameters.Add("@id_mes", SqlDbType.Int).Value = entiti.Id_mes;
                    cmd.Parameters.Add("@id_periodo", SqlDbType.Int).Value = entiti.Id_periodo;
                    cmd.Parameters.Add("@dias", SqlDbType.Int).Value = entiti.Dias;                    
                    result = cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                }
            }
            return result;
        }

     //MODIFICAR
        public int Edit(DDiasSubsidiados entiti)
        {
            result = 0;
            cmd = null;
            using (SqlConnection connect = RConexion.Getconectar())
            {
                connect.Open();
                using (cmd = new SqlCommand())
                {
                    cmd.Connection = connect;
                    cmd.CommandText = "SP_UPDATE_SUBSIDIOS";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@dias", SqlDbType.Int).Value = entiti.Dias;
                    cmd.Parameters.Add("@id_detSubsidios", SqlDbType.Int).Value = entiti.Id_det_subsidios;                                      
                    result = cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                }
            }
            return result;
        }

        //ELIMINAR
        public int Delete(DDiasSubsidiados entiti)
        {
            result = 0;
            cmd = null;
            using (SqlConnection connect = RConexion.Getconectar())
            {
                connect.Open();
                using (cmd = new SqlCommand())
                {
                    cmd.Connection = connect;
                    cmd.CommandText = "SP_DELETE_SUBSIDIOS";
                    cmd.CommandType = CommandType.StoredProcedure;
                    
                    cmd.Parameters.Add("@id_detSubsidios", SqlDbType.Int).Value = entiti.Id_det_subsidios;
                    result = cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                }
            }
            return result;
        }

        public DataTable GetData(DDiasSubsidiados entiti)
        {
            DataTable dt = null;
            cmd = null;
            using (var conn= RConexion.Getconectar())
            {
                conn.Open();
                using (cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SP_SHOW_DETSUBSIDIOS";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@idmes", SqlDbType.Int).Value = entiti.Id_mes;
                    cmd.Parameters.Add("@idperiodo", SqlDbType.Int).Value = entiti.Id_periodo;
                    cmd.Parameters.Add("@idempleado", SqlDbType.Int).Value = entiti.Id_empleado;
                    cmd.Parameters.Add("@tipoSubsidio", SqlDbType.VarChar,30).Value = entiti.ValTipSubsidio;
                    SqlDataReader reader = cmd.ExecuteReader();

                    using (dt =new DataTable())
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

        public void Dispose()
        {
            //throw new NotImplementedException();
        }


    }
}
