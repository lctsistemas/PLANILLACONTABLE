using Datos.Contract;
using Datos.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Repositories
{
    public class RDiasSubsidiados : IDiasSubsidiados
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

        public int Edit(DDiasSubsidiados entiti)
        {
            throw new NotImplementedException();
        }

        public DataTable GetData(DDiasSubsidiados entiti)
        {
            throw new NotImplementedException();
        }
    }
}
