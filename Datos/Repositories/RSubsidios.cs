using Datos.Contract;
using Datos.Entities;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Datos.Repositories
{
    public class RSubsidios : ISubsidios
    {
        SqlCommand cmd;
        public int Add(DSubsidios entiti)
        {
            throw new NotImplementedException();
        }

        public int Delete(DSubsidios entiti)
        {
            throw new NotImplementedException();
        }

        public int Edit(DSubsidios entiti)
        {
            throw new NotImplementedException();
        }

        public DataTable GetData(DSubsidios entiti)
        {
            using (var conect = RConexion.Getconectar())
            {
                conect.Open();
                cmd = null;
                SqlDataAdapter da = new SqlDataAdapter();
                using (cmd = new SqlCommand())
                {
                    cmd.Connection = conect;
                    cmd.CommandText = "SP_SELECT_SUBSIDIOS";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@tipo_subsidio", SqlDbType.VarChar, 30).Value = entiti.Tipo_subsidio;

                    da.SelectCommand = cmd;

                    using (DataTable dt = new DataTable())
                    {
                        da.Fill(dt);
                        cmd.Parameters.Clear();
                        da.Dispose();
                        return dt;
                    }
                }
            }
        }


    }
}
