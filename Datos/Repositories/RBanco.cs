using Datos.Contract;
using Datos.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Datos.Repositories
{
    public class RBanco : IBanco
    {

        Int32 result;
        SqlCommand cmd;
        public int Add(DBanco entiti)
        {
            result = 0;
            using (SqlConnection connect = RConexion.Getconectar())
            {
                connect.Open();
                using ( cmd = new SqlCommand())
                {
                    cmd.Connection = connect;
                    cmd.CommandText = "SP_INSERT_BANCO";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@id_banco", SqlDbType.Int).Value = entiti.IdBanco;
                    cmd.Parameters.Add("@nombre_banco", SqlDbType.VarChar, 25).Value = entiti.Nom_banco;
                   
                    cmd.Parameters.Add("@mensaje", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
                    result = cmd.ExecuteNonQuery();
                    entiti.mensaje = cmd.Parameters["@mensaje"].Value.ToString();

                    return result;
                }
            }
        }

        public int Delete(DBanco entiti)
        {
            throw new NotImplementedException();
        }

        public int Edit(DBanco entiti)
        {
            throw new NotImplementedException();
        }

        public DataTable GetData(DBanco entiti)
        {
            throw new NotImplementedException();
        }
    }
}
