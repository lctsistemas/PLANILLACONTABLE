using Comun.Cache;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Datos.Repositories
{
    public class Rlogin
    {
        public bool Login(string user, string roles, string pass)
        {
            using (SqlConnection cn = RConexion.Getconectar())
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "SP_LOGIN_USUARIO";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@user", user);
                    cmd.Parameters.AddWithValue("@descrip_rol", roles);
                    cmd.Parameters.AddWithValue("@pass", pass);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            UserCache.IdUser = dr.GetInt32(0);                            
                            UserCache.NombreUser = dr.GetString(1);//muestra el dato en el formulario principal
                            UserCache.Genero = dr.GetString(2);//para validar la imagen en el formulario principal. la foto.
                            UserCache.RolUser = dr.GetString(3);//muestra el dato en el formulario principal
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
            bool valor = false;
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
        public int Get_idperiodo(int periodo)
        {
            Int32 valor = 0;
            using (SqlConnection cn = RConexion.Getconectar())
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "SP_SHOW_PERIODO";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@periodo", SqlDbType.Int).Value = periodo;
                    cmd.Parameters.Add("@idperiodo", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.ExecuteNonQuery();//en este caso nos esta mostrando ExecuteNonQuery = -1 

                    //System.Windows.Forms.MessageBox.Show("executenonquery()=> "+ i);                   
                    valor = (int)cmd.Parameters["@idperiodo"].Value;
                }
            }
            return valor;
        }

    }
}
