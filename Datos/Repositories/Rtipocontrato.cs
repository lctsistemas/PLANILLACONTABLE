using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Datos.Contract;
using Datos.Entities;

namespace Datos.Repositories
{
    public class Rtipocontrato : ITipo_contrato
    {
        SqlCommand cmd;
        public int Add(Dtipocontrato entiti)
        {
            throw new NotImplementedException();
        }     
        public int Edit(Dtipocontrato entiti)
        {
            throw new NotImplementedException();
        }
        public int Delete(Dtipocontrato entiti)
        {
            throw new NotImplementedException();
        }

        public DataTable GetData(Dtipocontrato entiti)
        {
            using (SqlConnection cnn = RConexion.Getconectar())
            {
                cnn.Open();
                cmd = null;          
                SqlDataAdapter da = new SqlDataAdapter();
                using (cmd = new SqlCommand())
                {
                    cmd.Connection = cnn;
                    cmd.CommandText = "SP_SHOW_TIP_CONT";
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
