using Datos.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.KeyAutomatic
{
    public class KDiasSubsidiados
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
                    cmd.CommandText = "SP_GENERAR_SUBSIDIO";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@subsidio", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.ExecuteNonQuery();

                    codigo = Convert.ToInt32(cmd.Parameters["@subsidio"].Value);
                    cmd.Parameters.Clear();
                }
                return codigo;
            }
        }
    }
}
