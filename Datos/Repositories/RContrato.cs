using Datos.Contract;
using Datos.Entities;
using System;
using System.Data;
using System.Data.SqlClient;


namespace Datos.Repositories
{
    public class RContrato : IContrato
    {
        SqlCommand cmd;
        Int32 resul;
        public int Add(Dcontrato entiti)
        {
            resul = 0;
            using (SqlConnection cnn = RConexion.Getconectar())
            {
                cnn.Open();
                cmd = null;
                using (cmd = new SqlCommand())
                {
                    cmd.Connection = cnn;
                    cmd.CommandText = "SP_INSERT_CONTRATO";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@id_contrato", SqlDbType.Int).Value = entiti.Id_contrato;
                    cmd.Parameters.Add("@id_empleado", SqlDbType.Int).Value = entiti.Id_empleado;
                    cmd.Parameters.Add("@id_banco", SqlDbType.Int).Value = entiti.Id_banco;
                    cmd.Parameters.Add("@id_tcontrato", SqlDbType.Int).Value = entiti.Id_tcontrato;
                    cmd.Parameters.Add("@fecha_inicio", SqlDbType.Date).Value = entiti.Fecha_inicio;
                    cmd.Parameters.Add("@fecha_fin", SqlDbType.Date).Value = entiti.Fecha_fin;
                    cmd.Parameters.Add("@num_cuenta", SqlDbType.VarChar, 30).Value = entiti.Num_cuenta;
                    cmd.Parameters.Add("@remu_basica", SqlDbType.Money).Value = entiti.Remu_basica;
                    cmd.Parameters.Add("@asig_fami", SqlDbType.Money).Value = entiti.Asig_fami;
                    cmd.Parameters.Add("@descuento", SqlDbType.Money).Value = entiti.Descuento;
                    cmd.Parameters.Add("@tipo_modeda", SqlDbType.VarChar, 10).Value = entiti.Tipo_moneda;
                    cmd.Parameters.Add("@cts", SqlDbType.NVarChar, 50).Value = entiti.Cts;

                    resul = cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    return resul;
                }
            }
        }

        public int Edit(Dcontrato entiti)
        {
            resul = 0;
            using (SqlConnection cnn = RConexion.Getconectar())
            {
                cnn.Open();
                cmd = null;
                using (cmd = new SqlCommand())
                {
                    cmd.Connection = cnn;
                    cmd.CommandText = "SP_UPDATE_CONTRATO";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@id_empleado", SqlDbType.Int).Value = entiti.Id_empleado;
                    cmd.Parameters.Add("@id_banco", SqlDbType.Int).Value = entiti.Id_banco;
                    cmd.Parameters.Add("@id_tcontrato", SqlDbType.Int).Value = entiti.Id_tcontrato;
                    cmd.Parameters.Add("@fecha_inicio", SqlDbType.Date).Value = entiti.Fecha_inicio;
                    cmd.Parameters.Add("@fecha_fin", SqlDbType.Date).Value = entiti.Fecha_fin;
                    cmd.Parameters.Add("@num_cuenta", SqlDbType.VarChar, 30).Value = entiti.Num_cuenta;
                    cmd.Parameters.Add("@remu_basica", SqlDbType.Money).Value = entiti.Remu_basica;
                    cmd.Parameters.Add("@asig_fami", SqlDbType.Money).Value = entiti.Asig_fami;
                    cmd.Parameters.Add("@descuento", SqlDbType.Money).Value = entiti.Descuento;
                    cmd.Parameters.Add("@tipo_modeda", SqlDbType.VarChar, 10).Value = entiti.Tipo_moneda;
                    cmd.Parameters.Add("@cts", SqlDbType.NVarChar, 50).Value = entiti.Cts;
                    cmd.Parameters.Add("@id_contrato", SqlDbType.Int).Value = entiti.Id_contrato;

                    resul = cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    return resul;
                }
            }
        }

        public int Delete(Dcontrato entiti)
        {
            resul = 0;
            using (SqlConnection cnn = RConexion.Getconectar())
            {
                cnn.Open();
                cmd = null;
                using (cmd = new SqlCommand())
                {
                    cmd.Connection = cnn;
                    cmd.CommandText = "SP_DELETE_CONTRATO";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@id_contrato", SqlDbType.Int).Value = entiti.Id_contrato;
                    resul = cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    return resul;
                }
            }
        }

        public DataTable GetData(Dcontrato entiti)
        {
            throw new NotImplementedException();
        }
    }
}
