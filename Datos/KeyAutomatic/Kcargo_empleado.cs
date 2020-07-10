using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Datos.Repositories;

namespace Datos.KeyAutomatic
{
    public class Kcargo_empleado
    {
        SqlCommand cmd;

        public DataTable Mostrar_car_empleado()
        {
            cmd = null;
            using (SqlConnection conect = RConexion.Getconectar())
            {
                conect.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                using (cmd = new SqlCommand())
                {
                    cmd.Connection = conect;
                    cmd.CommandText = "SP_LLENAR_CARGO_EMPLEADO";
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
