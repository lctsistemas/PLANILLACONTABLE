using Datos.Contract;
using Datos.Entities;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Datos.Repositories
{
    public class REmpleado : IEmpleado, IContrato
    {
        Int32 result;
        SqlCommand cmd;

        //AGREGAR EMPLEADO
        public int Add(DEmpleado entiti)
        {
            result = 0;
            cmd = null;
            using (SqlConnection connect = RConexion.Getconectar())
            {
                connect.Open();
                using (cmd = new SqlCommand())
                {
                    cmd.Connection = connect;
                    cmd.CommandText = "SP_ADD_EMPLEADO";
                    cmd.CommandType = CommandType.StoredProcedure;
                    
                    cmd.Parameters.AddWithValue("@codigo", entiti.Codigo);
                    cmd.Parameters.AddWithValue("@nom_emp", entiti.Nom_emp);
                    cmd.Parameters.AddWithValue("@ape_pat", entiti.Ape_pat);
                    cmd.Parameters.AddWithValue("@ape_mat", entiti.Ape_mat);
                    cmd.Parameters.AddWithValue("@fec_nac", entiti.Fec_nac);
                    cmd.Parameters.AddWithValue("@nacionalidad", entiti.Nacionalidad);
                    cmd.Parameters.AddWithValue("@tip_ge", entiti.Tipo_genero);
                    cmd.Parameters.AddWithValue("@direccion", entiti.Direccion);
                    cmd.Parameters.AddWithValue("@telefono", entiti.Telefono);
                    cmd.Parameters.AddWithValue("@num_doc", entiti.Num_doc);
                    cmd.Parameters.AddWithValue("@estado", entiti.Estado);
                    cmd.Parameters.AddWithValue("@codigo_regimen", entiti.Codigo_regimen);
                    cmd.Parameters.AddWithValue("@id_documento", entiti.Id_doc);
                    cmd.Parameters.AddWithValue("@id_cargo", entiti.Id_cargo);
                    cmd.Parameters.AddWithValue("@id_empresa_maestra", entiti.Id_emp_maestra); //aqui pudes llamar ese id que esta en cache o si no.
                    cmd.Parameters.AddWithValue("@jornada_laboral", entiti.Jornada_laboral);
                    cmd.Parameters.Add("@mensaje", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
                    result = cmd.ExecuteNonQuery();
                    entiti.mensaje = cmd.Parameters["@mensaje"].Value.ToString();
                    cmd.Parameters.Clear();
                }
            }
            return result;
        }

        //AGREGAR CONTRATO
        public int Add(Dcontrato entiti)
        {
            result = 0;
            using (SqlConnection cnn = RConexion.Getconectar())
            {
                cnn.Open();
                cmd = null;
                using (cmd = new SqlCommand())
                {
                    cmd.Connection = cnn;
                    cmd.CommandText = "SP_INSERT_CONTRATO";
                    cmd.CommandType = CommandType.StoredProcedure;
                    
                    cmd.Parameters.Add("@id_banco", SqlDbType.Int).Value = entiti.Id_banco;
                    cmd.Parameters.Add("@id_tcontrato", SqlDbType.Int).Value = entiti.Id_tcontrato;
                    cmd.Parameters.Add("@fecha_inicio", SqlDbType.Date).Value = entiti.Fecha_inicio;
                    cmd.Parameters.Add("@fecha_fin", SqlDbType.Date).Value = entiti.Fecha_fin;
                    cmd.Parameters.Add("@num_cuenta", SqlDbType.VarChar, 30).Value = entiti.Num_cuenta;
                    cmd.Parameters.Add("@remu_basica", SqlDbType.Money).Value = entiti.Remu_basica;
                    cmd.Parameters.Add("@asig_fami", SqlDbType.Money).Value = entiti.Asig_fami;                    
                    cmd.Parameters.Add("@tipo_pago", SqlDbType.VarChar, 30).Value = entiti.Tipo_pago;
                    cmd.Parameters.Add("@periodicidad", SqlDbType.VarChar, 70).Value = entiti.Periodicidad;
                    cmd.Parameters.Add("@tipo_modeda", SqlDbType.VarChar, 10).Value = entiti.Tipo_moneda;
                    cmd.Parameters.Add("@cuenta_cts", SqlDbType.NVarChar, 50).Value = entiti.Cts;
                    cmd.Parameters.Add("@cussp", SqlDbType.NVarChar, 70).Value = entiti.Cussp;
                    cmd.Parameters.Add("@id_salud", SqlDbType.Int).Value = entiti.Id_regimenSalud;

                    result = cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                }
            }
            return result;
        }

        //EDITAR EMPLEADO
        public int Edit(DEmpleado entiti)
        {
            result = 0;
            using (SqlConnection conn = RConexion.Getconectar())
            {
                conn.Open();
                cmd = null;
                try
                {
                    using (cmd = new SqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "SP_UPDATE_EMPLEADO";
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@codigo", entiti.Codigo);
                        cmd.Parameters.AddWithValue("@nom_emp", entiti.Nom_emp);
                        cmd.Parameters.AddWithValue("@ape_pat", entiti.Ape_pat);
                        cmd.Parameters.AddWithValue("@ape_mat", entiti.Ape_mat);
                        cmd.Parameters.AddWithValue("@fec_nac", entiti.Fec_nac);
                        cmd.Parameters.AddWithValue("@nacionalidad", entiti.Nacionalidad);
                        cmd.Parameters.AddWithValue("@tip_ge", entiti.Tipo_genero);
                        cmd.Parameters.AddWithValue("@direccion", entiti.Direccion);
                        cmd.Parameters.AddWithValue("@telefono", entiti.Telefono);
                        cmd.Parameters.AddWithValue("@num_doc", entiti.Num_doc);
                        cmd.Parameters.AddWithValue("@estado", entiti.Estado);
                        cmd.Parameters.AddWithValue("@jornada_laboral", entiti.Jornada_laboral);
                        cmd.Parameters.AddWithValue("@codigo_regimen", entiti.Codigo_regimen);
                        cmd.Parameters.AddWithValue("@id_documento",  entiti.Id_doc);
                        cmd.Parameters.AddWithValue("@id_cargo", entiti.Id_cargo);
                        cmd.Parameters.Add("@id_empleado", SqlDbType.Int).Value = entiti.Id_empleado;
                        result = cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.ToString());
                }
            }
            return result;
        }

        //EDITAR CONTRATO
        public int Edit(Dcontrato entiti)
        {
            result = 0;
            using (SqlConnection cnn = RConexion.Getconectar())
            {
                cnn.Open();
                cmd = null;
                try
                {
                    using (cmd = new SqlCommand())
                    {
                        cmd.Connection = cnn;
                        cmd.CommandText = "SP_UPDATE_CONTRATO";
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@id_banco", SqlDbType.Int).Value = entiti.Id_banco;
                        cmd.Parameters.Add("@id_tcontrato", SqlDbType.Int).Value = entiti.Id_tcontrato;
                        cmd.Parameters.Add("@fecha_inicio", SqlDbType.Date).Value = entiti.Fecha_inicio;
                        cmd.Parameters.Add("@fecha_fin", SqlDbType.Date).Value = entiti.Fecha_fin;
                        cmd.Parameters.Add("@num_cuenta", SqlDbType.VarChar, 30).Value = entiti.Num_cuenta;
                        cmd.Parameters.Add("@remu_basica", SqlDbType.Money).Value = entiti.Remu_basica;
                        cmd.Parameters.Add("@asig_fami", SqlDbType.Money).Value = entiti.Asig_fami;                        
                        cmd.Parameters.Add("@tipo_pago", SqlDbType.VarChar, 30).Value = entiti.Tipo_pago;
                        cmd.Parameters.Add("@periodicidad", SqlDbType.VarChar, 70).Value = entiti.Periodicidad;
                        cmd.Parameters.Add("@tipo_modeda", SqlDbType.VarChar, 10).Value = entiti.Tipo_moneda;
                        cmd.Parameters.Add("@cuenta_cts", SqlDbType.NVarChar, 50).Value = entiti.Cts;
                        cmd.Parameters.Add("@cussp", SqlDbType.NVarChar, 70).Value = entiti.Cussp;
                        cmd.Parameters.Add("@id_salud", SqlDbType.Int).Value = entiti.Id_regimenSalud;
                        cmd.Parameters.Add("@id_empleado", SqlDbType.Int).Value = entiti.Id_empleado;
                        result = cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
            return result;
        }

        public int Delete(DEmpleado entiti)
        {
            result = 0;
            using (SqlConnection conn = RConexion.Getconectar())
            {
                conn.Open();
                cmd = null;
                using (cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SP_ANULAR_EMPLEADO";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id_emp", entiti.Id_empleado);
                    cmd.Parameters.Add("@mensaje", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
                    result = cmd.ExecuteNonQuery();
                    entiti.mensaje = cmd.Parameters["@mensaje"].Value.ToString();
                    cmd.Parameters.Clear();                    
                }
            }
            return result;
        }

        public int Delete(Dcontrato entiti)
        {
            throw new NotImplementedException();
        }

        public DataTable GetData(DEmpleado entiti)
        {
            DataTable dt;
            using (SqlConnection cnn = RConexion.Getconectar())
            {
                cnn.Open();
                cmd = null;
                SqlDataAdapter da = new SqlDataAdapter();
                using (cmd = new SqlCommand())
                {
                    cmd.Connection = cnn;
                    cmd.CommandText = "SP_SHOW_EMPLEADO";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@codigo_empresa", SqlDbType.Int).Value = entiti.Id_emp_maestra;
                    da.SelectCommand = cmd;

                    using (dt = new DataTable())
                    {
                        da.Fill(dt);
                        cmd.Parameters.Clear();
                        da.Dispose();                        
                    }
                }
            }
            return dt;
        }

        public DataTable GetData(Dcontrato entiti)
        {
            DataTable dt;
            using (SqlConnection cnn = RConexion.Getconectar())
            {
                cnn.Open();
                cmd = null;
                SqlDataAdapter da = new SqlDataAdapter();
                using (cmd = new SqlCommand())
                {
                    cmd.Connection = cnn;
                    cmd.CommandText = "SP_SHOW_EMPLEADO_CONTRATO";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@codigo_empleado", SqlDbType.Int).Value = entiti.Id_empleado;
                    da.SelectCommand = cmd;

                    using (dt = new DataTable())
                    {
                        da.Fill(dt);
                        cmd.Parameters.Clear();
                        da.Dispose();                        
                    }
                }
            }
            return dt;
        }


    }
}
