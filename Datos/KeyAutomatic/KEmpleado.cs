using Datos.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

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
    }
}
