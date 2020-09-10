using Datos.Contract;
using Datos.Entities;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Datos.Repositories
{
    public class Rusuario : IUsuario
    {
        Int32 resul;
        SqlCommand cmd;
        public int Add(Dusuario entiti)
        {
            resul = 0;
            using (SqlConnection cnn = RConexion.Getconectar())
            {
                cnn.Open();
                cmd = null;
                using (cmd = new SqlCommand())
                {
                    cmd.Connection = cnn;
                    cmd.CommandText = "SP_INSERT_USUARIO";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@idusu", SqlDbType.Int).Value = entiti.Idusuario;
                    cmd.Parameters.Add("@codigo_usu", SqlDbType.VarChar, 20).Value = entiti.Codigo_usu;
                    cmd.Parameters.Add("@referencia", SqlDbType.VarChar, 50).Value = entiti.Nombre_refe;
                    cmd.Parameters.Add("@passwor", SqlDbType.VarChar, 10).Value = entiti.Password;
                    cmd.Parameters.Add("@id_rol", SqlDbType.Int).Value = entiti.Idrol;
                    cmd.Parameters.Add("@mesage", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
                    resul = cmd.ExecuteNonQuery();
                    entiti.mesage = cmd.Parameters["@mesage"].Value.ToString();
                    cmd.Parameters.Clear();
                    return resul;

                }
            }

        }
        //EDIT
        public int Edit(Dusuario entiti)
        {
            resul = 0;
            using (SqlConnection cnn = RConexion.Getconectar())
            {
                cnn.Open();
                cmd = null;
                using (cmd = new SqlCommand())
                {
                    cmd.Connection = cnn;
                    cmd.CommandText = "SP_UPDATE_USUARIO";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@codigo_usu", SqlDbType.VarChar, 20).Value = entiti.Codigo_usu;
                    cmd.Parameters.Add("@referencia", SqlDbType.VarChar, 50).Value = entiti.Nombre_refe;
                    cmd.Parameters.Add("@passwor", SqlDbType.VarChar, 10).Value = entiti.Password;
                    cmd.Parameters.Add("@id_rol", SqlDbType.Int).Value = entiti.Idrol;
                    cmd.Parameters.Add("@idusu", SqlDbType.Int).Value = entiti.Idusuario;
                    resul = cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    return resul;

                }
            }
        }
        //DELETE
        public int Delete(Dusuario entiti)
        {
            resul = 0;
            using (SqlConnection cnn = RConexion.Getconectar())
            {
                cnn.Open();
                cmd = null;
                using (cmd = new SqlCommand())
                {
                    cmd.Connection = cnn;
                    cmd.CommandText = "SP_REMOVE_USUARIO";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@idusu", SqlDbType.Int).Value = entiti.Idusuario;
                    cmd.Parameters.Add("@mesage", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
                    resul = cmd.ExecuteNonQuery();
                    entiti.mesage = cmd.Parameters["@mesage"].Value.ToString();
                    cmd.Parameters.Clear();
                    return resul;
                }
            }
        }
        //SHOW DATA
        public DataTable GetData(Dusuario entiti)
        {
            using (SqlConnection cnn = RConexion.Getconectar())
            {
                cnn.Open();
                cmd = null;
                SqlDataAdapter da = new SqlDataAdapter();
                using (cmd = new SqlCommand())
                {
                    cmd.Connection = cnn;
                    cmd.CommandText = "SP_SHOW_USER";
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


        // MOSTRAR DATOS

        //...
    }
}
