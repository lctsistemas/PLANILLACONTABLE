using Datos.Repositories;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Datos.KeyAutomatic
{
    public class Kcontrato
    {
        //CODIGO GENERAR DE CONTRATO
        public int Getcodigo()
        {
            Int32 codigo = 0;
            using (SqlConnection cnn = RConexion.Getconectar())
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cnn;
                    cmd.CommandText = "SP_GENERAR_CONTRATO";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@contrato", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.ExecuteNonQuery();

                    codigo = Convert.ToInt32(cmd.Parameters["@contrato"].Value);
                    cmd.Parameters.Clear();
                }
                return codigo;
            }
        }

    }
}
