﻿using Datos.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Entities;
using System.Data;
using System.Data.SqlClient;

namespace Datos.Repositories
{
    public class RRegimen : IRegimen
    {
        Int32 result;
        SqlCommand cmd; 
        public int Add(DRegimen entiti)
        {
            result = 0;
            using (SqlConnection conn = RConexion.Getconectar())
            {
                conn.Open();
                cmd = null;
                using (cmd=new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SP_ADD_REGIMEN";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@codigo_regimen", SqlDbType.Int).Value = entiti.Codigo_regimen;
                    cmd.Parameters.Add("@descripcion_corta", SqlDbType.VarChar, 30).Value = entiti.Descripcion_corta;
                    cmd.Parameters.Add("@descripcion", SqlDbType.VarChar, 100).Value = entiti.Descripcion;
                    cmd.Parameters.Add("@tipo_regimen", SqlDbType.VarChar, 30).Value = entiti.Tipo_regimen;
                    cmd.Parameters.Add("@mensaje", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;

                    result = cmd.ExecuteNonQuery();
                    entiti.mensaje = cmd.Parameters["@mensaje"].Value.ToString();
                    cmd.Parameters.Clear();
                    return result;
                }
            }
        }

        public int Delete(DRegimen entiti)
        {
            throw new NotImplementedException();
        }

        public int Edit(DRegimen entiti)
        {
            throw new NotImplementedException();
        }

        public DataTable GetData(DRegimen entiti)
        {
            throw new NotImplementedException();
        }
    }
}
