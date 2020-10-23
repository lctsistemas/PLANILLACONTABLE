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
            throw new NotImplementedException();
        }

        //mostrar en combox subsidios
        public DataTable ShowSubsidio(DSubsidios Entity)
        {
            DataTable dt = null;
            using (SqlConnection cnn = RConexion.Getconectar())
            {
                cnn.Open();
                using (cmd = new SqlCommand())
                {
                    cmd.Connection = cnn;
                    cmd.CommandText = "SP_SHOW_SUBSIDIOS";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@tipo_subsidio", SqlDbType.VarChar, 30).Value = Entity.Tipo_subsidio;
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

    }
}
