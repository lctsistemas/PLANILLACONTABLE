using Datos.Repositories;
using System.Data;
using System.Data.SqlClient;

namespace Datos.KeyAutomatic
{
    public class KAFP
    {
        SqlCommand cmd;

        public DataTable Mostrar_Afp()
        {
            cmd = null;
            using (SqlConnection conn = RConexion.Getconectar())
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                using (cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SP_LLEN_AFP";
                    cmd.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand = cmd;

                    using (DataTable dt = new DataTable())
                    {
                        da.Fill(dt);
                        da.Dispose();
                        return dt;
                    }
                }
            }

        }
    }
}
