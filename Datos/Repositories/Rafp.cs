using Datos.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace Datos.Repositories
{
    public class Rafp : IDisposable
    {
        int result;
        #region Metodo insertar masivo
        public int Add(Dafp daf)
        {
            result = 0;
            using (SqlConnection conect = RConexion.Getconectar())
            {
                conect.Open();
              
                using (SqlTransaction sqltra = conect.BeginTransaction())
                {
                    try
                    {
                        using (SqlCommand cmd = new SqlCommand())
                        {
                            cmd.CommandText = "SP_INSERT_COMISIONES";
                            cmd.Connection = conect;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Transaction = sqltra;

                            cmd.Parameters.Add("@codigo_regimen", SqlDbType.Int).Value = daf.Codigo_regimen;
                            cmd.Parameters.Add("@comision", SqlDbType.Decimal).Value = daf.Comision;
                            cmd.Parameters.Add("@saldo", SqlDbType.Decimal).Value = daf.Saldo;
                            cmd.Parameters.Add("@seguro", SqlDbType.Decimal).Value = daf.Seguro;
                            cmd.Parameters.Add("@aporte", SqlDbType.Decimal).Value = daf.Aporte;
                            cmd.Parameters.Add("@tope", SqlDbType.Decimal).Value = daf.Tope;
                            cmd.Parameters.Add("@idmes", SqlDbType.Int).Value = daf.Idmes;
                            cmd.Parameters.Add("@idperiodo", SqlDbType.Int).Value = daf.Idperiodo;                            
                            result = cmd.ExecuteNonQuery();
                            //System.Windows.Forms.MessageBox.Show("EXECUTE: " + result);                            

                        }

                        sqltra.Commit();
                    }
                    catch (Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message);
                        sqltra.Rollback();
                    }
                        
                }    

            }
            return result;
        }
        #endregion

        //Guardar Comision
        public int SaveComision(Dafp lisaf)
        {
            int i = 0;
            foreach (Dafp item in lisaf.DlistAfp)
            {
              i = Add(item);
            }

            return i;
        }

        //EDITAR COMISIONES
        public int Edit(Dafp daf)
        {
            result = 0;
            using (SqlConnection conect = RConexion.Getconectar())
            {
                conect.Open();
                using (SqlTransaction sqltra = conect.BeginTransaction())
                {
                    try
                    {
                        using (SqlCommand cmd = new SqlCommand())
                        {
                            cmd.CommandText = "SP_UPDATE_COMISIONES";
                            cmd.Connection = conect;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Transaction = sqltra;
                           
                            cmd.Parameters.Add("@comision", SqlDbType.Decimal).Value = daf.Comision;
                            cmd.Parameters.Add("@saldo", SqlDbType.Decimal).Value = daf.Saldo;
                            cmd.Parameters.Add("@seguro", SqlDbType.Decimal).Value = daf.Seguro;
                            cmd.Parameters.Add("@aporte", SqlDbType.Decimal).Value = daf.Aporte;
                            cmd.Parameters.Add("@tope", SqlDbType.Decimal).Value = daf.Tope;                                                        
                            cmd.Parameters.Add("@idcomision", SqlDbType.Int).Value = daf.Id_comision;                                                        
                            result = cmd.ExecuteNonQuery();                            
                        }

                        sqltra.Commit();
                    }
                    catch (Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message);
                        sqltra.Rollback();
                    }
                }
            }
            return result;
        }


        //EDIT COMISION
        public int EditComision(Dafp lisaf)
        {
            int i = 0;
            foreach (Dafp item in lisaf.DlistAfp)
            {
                i = Edit(item);
            }
            return i;
        }

        //MOSTRAR MES.
        public DataTable Mostrar_mes()
        {
            List<Dafp> lista_mes = new List<Dafp>();
            DataTable dt = null;            
            using (SqlConnection cn = RConexion.Getconectar())
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "SP_SHOW_MES";
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        using (dt = new DataTable())
                        {
                            dt.Load(reader);
                            reader.Close();
                        }
                    }                    
                }
            }
            return dt;
        }

        #region Mostrar comisiones AFP
        public DataTable Show_comisionafp(Dafp entity)
        {
            DataTable dt = null;
            using (SqlConnection conect = RConexion.Getconectar())
            {
                conect.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conect;
                    cmd.CommandText = "SP_SHOW_COMISIONPENSIONES";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@idmes", entity.Idmes);
                    cmd.Parameters.AddWithValue("@idperiodo", entity.Idperiodo);
                    SqlDataReader reader = cmd.ExecuteReader();
                    using (dt = new DataTable())
                    {
                        if (reader.HasRows)
                        {
                            dt.Load(reader);
                            reader.Close();
                        }
                    }
                }
            }
            return dt;
        }
        #endregion

        public void Dispose()
        {
            //throw new NotImplementedException();
        }

    }
}
