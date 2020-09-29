using Datos.Contract;
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
    public class RSubsidios : IRepository
    {
        public int Add(Dcargo entiti)
        {
            throw new NotImplementedException();
        }

        public int Delete(Dcargo entiti)
        {
            throw new NotImplementedException();
        }

        public int Edit(Dcargo entiti)
        {
            throw new NotImplementedException();
        }

        public DataTable GetData(Dcargo entiti)
        {
            using (var conect = RConexion.Getconectar())
            {
                conect.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conect;
                    cmd.CommandText = "SP_SELECT_SUBSIDIOS";
                    cmd.CommandType = CommandType.StoredProcedure;

                    da.SelectCommand = cmd;

                    using (var dt = new DataTable())
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
