using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using Datos.Entities;

namespace Datos.Repositories
{
    public class RplanillaM:IDisposable
    {
        

        public DataTable Show_planillaM(DplanillaM entity, int pid_planilla)
        {
            DataTable dt = null;
            using (SqlConnection conect = RConexion.Getconectar())
            {
                conect.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conect;
                    cmd.CommandText = "SP_ShowPlanillaManto";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@idplanilla", pid_planilla);
                    cmd.Parameters.AddWithValue("@idmes", entity.Pid_mes);
                    cmd.Parameters.AddWithValue("@id_empresaMaestra", entity.Pid_empreMaestra);
                    cmd.Parameters.AddWithValue("@fechaini", entity.Pfecha_inicio);
                    cmd.Parameters.AddWithValue("@fechafin", entity.Pfecha_fin);
                    SqlDataReader reader = cmd.ExecuteReader();
                    using (dt = new DataTable())
                    {
                        if (reader.HasRows)
                        {
                            dt.Load(reader);
                            reader.Close();
                        }
                    }
                }
            }
            return dt;
        }


        public void Dispose()
        {
            //throw new NotImplementedException();
           
        }
    }
}
