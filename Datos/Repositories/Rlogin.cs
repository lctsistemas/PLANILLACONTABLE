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
        public bool Login(string user, string pass)
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
                        dr.Close();                                               
                        return true;
                    }
                    else
                        return false;
                }
            }
        }

        public bool Business(List<object> lista)
        {
            bool valor=false;
            using (SqlConnection cn = RConexion.Getconectar())
            {
                cn.Open();               
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "SP_EMPRESAS_USUARIO";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@codigo_user", UserCache.IdUser);                  
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        foreach (var item in reader)                    
                            lista.Add(item);
                        
                        valor = true;
                    }
                    else                 
                        valor = false;
                    
                    reader.Close();
                }
            }
            return valor;
        }

        //LLENAR PERIODO
        public List<int> Mostrar_periodo()
        {  
            List<int> lista_periodo = new List<int>();
            using (SqlConnection cn = RConexion.Getconectar())
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "SP_SHOW_PERIODO";
                    cmd.CommandType = CommandType.StoredProcedure;
                    
                    SqlDataReader reader = cmd.ExecuteReader();                    
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            lista_periodo.Add(reader.GetInt32(0));
                        }
                                       
                    }
                    reader.Close();
                }
            }
            return lista_periodo;
        }

    }
}
