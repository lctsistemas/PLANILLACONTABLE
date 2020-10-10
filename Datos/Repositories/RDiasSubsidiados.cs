using Datos.Contract;
using Datos.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Datos.Repositories
{
    public class RDiasSubsidiados : IDiasSubsidiados, IDisposable
    {
        Int32 result;
        SqlCommand cmd;
        public int Add(DDiasSubsidiados entiti)
        {
            result = 0;
            using (SqlConnection connect = RConexion.Getconectar())
            {
                connect.Open();
                using (cmd = new SqlCommand())
                {
                    cmd.Connection = connect;
                    cmd.CommandText = "SP_INSERT_SUBSIDIOS";
                    cmd.CommandType = CommandType.StoredProcedure;

                    // cmd.Parameters.Add("@id_tipo_planilla", SqlDbType.Int).Value = entiti.Id_tipo_planilla;
                    cmd.Parameters.Add("@id_det_subsidios", SqlDbType.Int).Value = entiti.Id_det_subsidios;
                    cmd.Parameters.Add("@id_subsidios", SqlDbType.Int).Value = entiti.Id_subsidios;
                    cmd.Parameters.Add("@id_empleado", SqlDbType.Int).Value = entiti.Id_empleado;
                    cmd.Parameters.Add("@id_mes", SqlDbType.Int).Value = entiti.Id_mes;
                    cmd.Parameters.Add("@id_periodo", SqlDbType.Int).Value = entiti.Id_periodo;
                    cmd.Parameters.Add("@dias", SqlDbType.Int).Value = entiti.Dias;


                    cmd.Parameters.Add("@mensaje", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
                    result = cmd.ExecuteNonQuery();
                    entiti.mensaje = cmd.Parameters["@mensaje"].Value.ToString();
                    cmd.Parameters.Clear();

                    return result;
                }
            }
        }

        public int Delete(DDiasSubsidiados entiti)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }

        public int Edit(DDiasSubsidiados entiti)
        {
            throw new NotImplementedException();
        }

        public DataTable GetData(DDiasSubsidiados entiti)
        {
            throw new NotImplementedException();
        }

        public void InsertarMassiveData(IEnumerable<DDiasSubsidiados> listdiassubs)
        {
            //create table, tiene que estar en el mismo orden de tu tabla de sql
            using (DataTable tabla = new DataTable())
            {
                tabla.Columns.Add("id_det_subsidios", typeof(int));
                tabla.Columns.Add("id_subsidios", typeof(int));
                tabla.Columns.Add("id_empleado", typeof(int));
                tabla.Columns.Add("idmes", typeof(int));
                tabla.Columns.Add("idperiodo", typeof(int));
                tabla.Columns.Add("dias", typeof(int));


                //ahora agregamos datos por un ciclo
                foreach (var item in listdiassubs)
                {
                    tabla.Rows.Add(new object[]{
                    item.Id_det_subsidios,
                    item.Id_subsidios,
                    item.Id_empleado,
                    item.Id_mes,
                    item.Id_periodo,
                    item.Dias

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
    }
}
