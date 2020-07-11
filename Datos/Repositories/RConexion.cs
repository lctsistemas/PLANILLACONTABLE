using System.Configuration;
using System.Data.SqlClient;

namespace Datos.Repositories
{
    public class RConexion
    {
        private static string conexion;

        public static SqlConnection Getconectar()
        {
            conexion = ConfigurationManager.ConnectionStrings["Dbplanilla"].ToString();
            return new SqlConnection(conexion);
        }

    }
}
