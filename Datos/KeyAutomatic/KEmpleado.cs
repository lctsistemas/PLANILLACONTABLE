using Datos.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Datos.KeyAutomatic
{
    public class KEmpleado
    {
        public int GetCodigo()
        {
            Int32 codigo = 0;
            using (SqlConnection cnn = RConexion.Getconectar())
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cnn;
                    cmd.CommandText = "SP_GENERAR_EMP";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@empleado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.ExecuteNonQuery();

                    codigo = Convert.ToInt32(cmd.Parameters["@empleado"].Value);
                    cmd.Parameters.Clear();
                }
                return codigo;
            }
        }

        //
        public List<object> Lista_total(Int32 idempleado)
        {
            List<object> lista = new List<object>();
            using (SqlConnection cn = RConexion.Getconectar())
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "SP_SHOW_EMPLEADO_CONTRATO";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@codigo_empleado", SqlDbType.Int).Value = idempleado;                   
                    SqlDataReader reader = cmd.ExecuteReader();
                    
                    if (reader.HasRows)
                    {
                        foreach (var item in reader)
                            lista.Add(item);                        
                    }                                            
                    reader.Close();
                }
            }
            return lista;
        }


    }
}
