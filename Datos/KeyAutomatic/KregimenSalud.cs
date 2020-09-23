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
    public class KregimenSalud
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
                    cmd.CommandText = "SP_GEN_REG_SALUD";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@reg_salud", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.ExecuteNonQuery();

                    codigo = Convert.ToInt32(cmd.Parameters["@reg_salud"].Value);
                    cmd.Parameters.Clear();
                }
                return codigo;
            }
        }
    }
}
