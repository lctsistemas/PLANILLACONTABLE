﻿using Datos.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Datos.KeyAutomatic
{
    public class KEmpresa
    {
        SqlCommand cmd;

        public DataTable MostrarEmpresa()
        {
            cmd = null;
            using (SqlConnection conn = RConexion.Getconectar())
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter();

                using (cmd=new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SP_EMPR";
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
