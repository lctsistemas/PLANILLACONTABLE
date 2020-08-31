using Datos.Repositories;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Datos.KeyAutomatic
{
    public class KBanco
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
                    cmd.CommandText = "SP_GENERAR_BANCO";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Banco", SqlDbType.Int).Direction = ParameterDirection.Output;                    
                    cmd.ExecuteNonQuery();                    
                    
                    codigo = Convert.ToInt32(cmd.Parameters["@Banco"].Value);
                    cmd.Parameters.Clear();

                }
                return codigo;
            }
        }


    }
}
