using Datos.Repositories;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Datos.KeyAutomatic
{
    public class KRegimen
    {
        public int Getcodigo()
        {
            Int32 codigo = 0;
            using (SqlConnection cnn = RConexion.Getconectar())
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cnn;
                    cmd.CommandText = "SP_GENERAR_REGIMEN";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@regimen", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.ExecuteNonQuery();

                    codigo = Convert.ToInt32(cmd.Parameters["@regimen"].Value);
                    cmd.Parameters.Clear();
                }

                return codigo;
            }

        }
    }
}
