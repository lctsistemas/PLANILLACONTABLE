using Datos.Repositories;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Datos.KeyAutomatic
{
    public class Ktipocontrato
    {
        public int GetCodigo()
        {
            Int32 codigo = 0;
            using (SqlConnection conn = RConexion.Getconectar())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SP_GEN_TIPO_CONT";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Tipocont", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.ExecuteNonQuery();

                    codigo = Convert.ToInt32(cmd.Parameters["@Tipocont"].Value);
                    cmd.Parameters.Clear();
                }

                return codigo;

            }
        }
    }
}
