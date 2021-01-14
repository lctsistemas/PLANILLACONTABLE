using Datos.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Repositories
{
    public class RPrivilegios
    {
        int result;
        public int SaveAddUpdate(Dprivilegios entiti)
        {
            result = 0;
            using (SqlConnection conect = RConexion.Getconectar())
            {
                conect.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conect;
                    cmd.CommandText = "SP_RegistroPrivilegios";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@idprivilegios", entiti.Id_privilegios);
                    cmd.Parameters.AddWithValue("@idrol", entiti.Id_rol);
                    cmd.Parameters.AddWithValue("@btipopla", entiti.Btipopla);
                    cmd.Parameters.AddWithValue("@btipocont", entiti.Btipocont);
                    cmd.Parameters.AddWithValue("@bregimensalud ", entiti.Bregimensalud);
                    cmd.Parameters.AddWithValue("@bsubsinosub", entiti.Bsubsinosub);
                    cmd.Parameters.AddWithValue("@bcargo", entiti.Bcargo);
                    cmd.Parameters.AddWithValue("@btipodoc", entiti.Btipodoc);
                    cmd.Parameters.AddWithValue("@bbanco", entiti.Bbanco);
                    cmd.Parameters.AddWithValue("@broles", entiti.Broles);
                    cmd.Parameters.AddWithValue("@bregimenpen", entiti.Bregimenpen);
                    cmd.Parameters.AddWithValue("@bcomisiones", entiti.Bcomisiones);
                    cmd.Parameters.AddWithValue("@bempleado", entiti.Bempleado);
                    cmd.Parameters.AddWithValue("@bempresa", entiti.Bempresa);
                    cmd.Parameters.AddWithValue("@bsucursal", entiti.Bsucursal);
                    cmd.Parameters.AddWithValue("@busuario", entiti.Busuario);
                    cmd.Parameters.AddWithValue("@bplanilla", entiti.Bplanilla);
                   
                    result = cmd.ExecuteNonQuery();

                    cmd.Parameters.Clear();
                }
            }
            return result;
        }

        public DataTable GetData(Dprivilegios entiti)
        {
            DataTable dt = null;
            using (SqlConnection conect = RConexion.Getconectar())
            {
                conect.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conect;
                    cmd.CommandText = "SP_SHOW_PRIVILEGIOS";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id_rol", entiti.Id_rol);

                    SqlDataReader reader = cmd.ExecuteReader();
                    using (dt = new DataTable())
                    {
                        dt.Load(reader);
                        reader.Close();
                    }
                }
            }
            return dt;
        }
    }
}
