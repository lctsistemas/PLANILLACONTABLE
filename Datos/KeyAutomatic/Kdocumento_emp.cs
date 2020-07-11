using Datos.Repositories;
using System.Data;
using System.Data.SqlClient;

namespace Datos.KeyAutomatic
{
    public class Kdocumento_emp
    {
        SqlCommand cmd;

        public DataTable MostrarDocumentoEmp()
        {
            cmd = null;

            using (SqlConnection conect = RConexion.Getconectar())
            {
                conect.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                using (cmd = new SqlCommand())
                {
                    cmd.Connection = conect;
                    cmd.CommandText = "SP_LLENAR_DOCUMENTO_EMPLEADO";
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
