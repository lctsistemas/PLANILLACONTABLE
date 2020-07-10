using Datos.Repositories;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;

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

                    codigo = Convert.ToInt32(cmd.Parameters["Banco"].Value);
                    cmd.Parameters.Clear();






                    return codigo;

>>>>>>> f04750b705c61975c9d91c1f6d8c7ed4e2334d05
                }
                return codigo;
            }
        }


    }
}
