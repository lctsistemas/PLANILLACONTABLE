using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Comun.Cache;
using System.Collections;// PARA EL ARRAYLIST

namespace Datos.Repositories
{
    public class Rlogin
    {
        public bool Login(string user, string pass, DataTable dt)
        {
            using (SqlConnection cn=RConexion.Getconectar())
            {
                cn.Open();
                using (SqlCommand cmd=new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "SP_LOGIN_USUARIO";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@user",user);
                    cmd.Parameters.AddWithValue("@pass",pass);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            UserCache.IdUser = dr.GetInt32(0);
                            UserCache.CodigoUser = dr.GetString(1);
                            UserCache.NombreUser = dr.GetString(2);
                            UserCache.RolUser = dr.GetString(3);     
                        }


                        //SI TIENES FILAS, ENTONCES LISTAR EMPRESA
                        dr.Close();
                        
                        using (SqlCommand cmd1 = new SqlCommand())
                        {
                            cmd1.Connection = cn;
                            cmd1.CommandText = "SP_EMPRESAS_USUARIO";
                            cmd1.Parameters.AddWithValue("@codigo_user", UserCache.IdUser);
                            cmd1.CommandType = CommandType.StoredProcedure;
                            //SqlDataReader reader = cmd1.ExecuteReader();
                            //if (reader.HasRows)
                            //{
                            //    foreach (var item in reader)
                            //    {
                            //        dt.Add(item);
                            //    }
                            //}
                            //reader.Close();

                            using (SqlDataAdapter da = new SqlDataAdapter())
                            {
                                da.SelectCommand = cmd1;
                                da.Fill(dt);
                            }
                        }
                        return true;
                    }
                    else
                        return false;
                }
            }
        }
    }
}
