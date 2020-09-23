﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Entities;
using System.Data;
using System.Data.SqlClient;


namespace Datos.Repositories
{
    public class Rafp:IDisposable
    {       
        #region Metodo insertar masivo
        public void InsertarMassiveData(IEnumerable<Dafp> afplist)
        {
            //create table, tiene que estar en el mismo orden de tu tabla de sql
            using (DataTable tabla = new DataTable())
            {
                tabla.Columns.Add("idcomision", typeof(int));
                tabla.Columns.Add("codigo_regimen", typeof(int));
                tabla.Columns.Add("comision", typeof(decimal));
                tabla.Columns.Add("saldo", typeof(decimal));
                tabla.Columns.Add("seguro", typeof(decimal));
                tabla.Columns.Add("aporte", typeof(decimal));
                tabla.Columns.Add("tope", typeof(decimal));
                tabla.Columns.Add("idmes", typeof(int));
                tabla.Columns.Add("idperiodo", typeof(int));

                //ahora agregamos datos por un ciclo
                foreach (var item in afplist)
                {
                    tabla.Rows.Add(new object[]{
                    item.Id_comision,
                    item.Codigo_regimen,
                    item.Comision,
                    item.Saldo,
                    item.Seguro,
                    item.Aporte,
                    item.Tope,
                    item.Idmes,
                    item.Idperiodo
                });

                }

                //insert to DB
                using (SqlConnection conect = RConexion.Getconectar())
                {
                    conect.Open();
                    using (SqlTransaction transaction = conect.BeginTransaction())
                    {
                        using (SqlBulkCopy bulkcopy = new SqlBulkCopy(conect, SqlBulkCopyOptions.Default, transaction))
                        {
                            try
                            {
                                bulkcopy.DestinationTableName = "ComisionesPension";//nombre de tabla
                                bulkcopy.WriteToServer(tabla);
                                transaction.Commit();
                            }
                            catch (Exception ex)
                            {
                                transaction.Rollback();
                                conect.Close();
                                System.Windows.Forms.MessageBox.Show(ex.Message);
                            }
                        }
                    }
                }
            }

        }
        #endregion

        public DataTable Mostrar_mes()
        {
            List<Dafp> lista_mes =new List<Dafp>();
            DataTable dt=null;
           // Dafp dafp = new Dafp();
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
                        using ( dt = new DataTable())
                        {
                            dt.Load(reader);
                            reader.Close();                          
                        }
                    }
                        //while (reader.Read())
                        //{
                        //    dafp.Idmes=(reader.GetInt32(0));
                        //    dafp.Mes=(reader.GetString(1));
                        //    lista_mes.Add(dafp);
                        //} 
                }
            }
            return dt;

        }

        #region Mostrar regimen pensionario ssp
        public DataTable Mostrar_regimenPensionario(string tipo_regimen)
        {
            DataTable dt = null;
            using (SqlConnection cnn = RConexion.Getconectar())
            {
                cnn.Open();                                
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cnn;
                    cmd.CommandText = "SP_SHOWREGIMENparaCOMISIONES";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@tipo_regimen", tipo_regimen);
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        using (dt = new DataTable())
                        {
                            dt.Load(dr);
                            dr.Close();
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