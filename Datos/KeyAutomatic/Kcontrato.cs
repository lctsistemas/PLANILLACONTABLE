using Datos.Repositories;
using System.Data;
using System.Data.SqlClient;

namespace Datos.KeyAutomatic
{
    public class Kcontrato
    {
        SqlCommand cmd;

        public DataTable MostrarBanco()
        {
            cmd = null;
            using (SqlConnection conn = RConexion.Getconectar())
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                using (cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SP_LLENAR_BANCO";
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
