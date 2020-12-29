using Datos.Contract;
using Datos.Entities;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Datos.Repositories
{
    public class REmpleado : IEmpleado
    {
        Int32 result;
        SqlCommand cmd;

        //AGREGAR EMPLEADO Y CONTRATO
        public int Add(DEmpleadoContrato entiti)
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

                    // INSERSION DE CONTRATO
                    cmd.Parameters.AddWithValue("@id_banco", entiti.Cid_banco);
                    cmd.Parameters.AddWithValue("@id_tcontrato", entiti.Cid_tcontrato);
                    cmd.Parameters.AddWithValue("@fecha_inicio", entiti.Cfecha_inicio);
                    cmd.Parameters.AddWithValue("@fecha_fin", entiti.Cfecha_fin);
                    cmd.Parameters.AddWithValue("@num_cuenta", entiti.Cnum_cuenta);
                    cmd.Parameters.AddWithValue("@remu_basica", entiti.Cremu_basica);
                    cmd.Parameters.AddWithValue("@asig_fami", entiti.Casig_fami);
                    cmd.Parameters.AddWithValue("@tipo_pago", entiti.Ctipo_pago);
                    cmd.Parameters.AddWithValue("@periodicidad", entiti.Cperiodicidad);
                    cmd.Parameters.AddWithValue("@tipo_modeda", entiti.Ctipo_moneda);
                    cmd.Parameters.AddWithValue("@cuenta_cts", entiti.Ccts);
                    cmd.Parameters.AddWithValue("@cussp", entiti.Ccussp);
                    cmd.Parameters.AddWithValue("@id_salud", entiti.Cid_regimenSalud);

                    cmd.Parameters.Add("@mensaje", SqlDbType.VarChar, 200).Direction = ParameterDirection.Output;
                    result = cmd.ExecuteNonQuery();
                    entiti.mensaje = cmd.Parameters["@mensaje"].Value.ToString();
                    cmd.Parameters.Clear();
                }
            }
            return result;
        }
        
        //EDITAR EMPLEADO Y CONTRATO
        public int Edit(DEmpleadoContrato entiti)
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
                        cmd.Parameters.AddWithValue("@id_empleado", entiti.Id_empleado);

                        //UPDATE CONTRATO
                        cmd.Parameters.AddWithValue("@id_banco", entiti.Cid_banco);
                        cmd.Parameters.AddWithValue("@id_tcontrato", entiti.Cid_tcontrato);
                        cmd.Parameters.AddWithValue("@fecha_inicio", entiti.Cfecha_inicio);
                        cmd.Parameters.AddWithValue("@fecha_fin", entiti.Cfecha_fin);
                        cmd.Parameters.AddWithValue("@num_cuenta", entiti.Cnum_cuenta);
                        cmd.Parameters.AddWithValue("@remu_basica", entiti.Cremu_basica);
                        cmd.Parameters.AddWithValue("@asig_fami", entiti.Casig_fami);
                        cmd.Parameters.AddWithValue("@tipo_pago", entiti.Ctipo_pago);
                        cmd.Parameters.AddWithValue("@periodicidad", entiti.Cperiodicidad);
                        cmd.Parameters.AddWithValue("@tipo_modeda", entiti.Ctipo_moneda);
                        cmd.Parameters.AddWithValue("@cuenta_cts", entiti.Ccts);
                        cmd.Parameters.AddWithValue("@cussp", entiti.Ccussp);
                        cmd.Parameters.AddWithValue("@id_salud", entiti.Cid_regimenSalud);                    
                        result = cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.ToString());
                }
            }
            return result;
        }              

        //ELIMINAR O ANULAR
        public int Delete(DEmpleadoContrato entiti)
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

        public DataTable GetData(DEmpleadoContrato entiti)
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

        //RECUPERA DATOS DE EMPLEDO Y CONTRATO
        public DataTable GetDataEC(DEmpleadoContrato entiti)
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
