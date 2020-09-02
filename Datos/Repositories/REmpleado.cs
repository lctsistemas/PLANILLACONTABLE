using Datos.Contract;
using Datos.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace Datos.Repositories
{
    public class REmpleado : IEmpleado,IContrato
    {
        Int32 result;
        SqlCommand cmd;

      
        public int Add(DEmpleado entiti)
        {
            result = 0;
            cmd = null;
            using (SqlConnection connect = RConexion.Getconectar())
            {
                connect.Open();
                using ( cmd = new SqlCommand())
                {
                    cmd.Connection = connect;
                    cmd.CommandText = "SP_AGR_EMPL";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@id_empleado", SqlDbType.Int).Value = entiti.Id_empleado;
                    cmd.Parameters.Add("@codigo", SqlDbType.VarChar,20).Value = entiti.Codigo;
                    cmd.Parameters.Add("@nom_emp", SqlDbType.VarChar, 50).Value = entiti.Nom_emp;
                    cmd.Parameters.Add("@ape_pat", SqlDbType.VarChar, 50).Value = entiti.Ape_pat;
                    cmd.Parameters.Add("@ape_mat", SqlDbType.VarChar, 50).Value = entiti.Ape_mat;               
                    cmd.Parameters.Add("@fec_nac", SqlDbType.Date).Value = entiti.Fec_nac;
                    cmd.Parameters.Add("@nacionalidad", SqlDbType.VarChar, 30).Value = entiti.Nacionalidad;
                    cmd.Parameters.Add("@tip_ge", SqlDbType.VarChar, 12).Value = entiti.Tipo_genero;
                    cmd.Parameters.Add("@direccion", SqlDbType.VarChar, 250).Value = entiti.Direccion;
                    cmd.Parameters.Add("@telefono", SqlDbType.VarChar, 15).Value = entiti.Telefono;
                    cmd.Parameters.Add("@num_doc", SqlDbType.VarChar, 20).Value = entiti.Num_doc;
                    cmd.Parameters.Add("@estado", SqlDbType.VarChar, 20).Value = entiti.Estado;
                    cmd.Parameters.Add("@codigo_regimen", SqlDbType.Int).Value = entiti.Codigo_regimen;
                    cmd.Parameters.Add("@id_documento", SqlDbType.Int).Value = entiti.Id_doc;
                    cmd.Parameters.Add("@id_cargo", SqlDbType.Int).Value = entiti.Id_cargo;
                    cmd.Parameters.Add("@id_empresa_maestra", SqlDbType.Int).Value = entiti.Id_emp_maestra;//aqui pudes llamar ese id que esta en cache o si no.
                    cmd.Parameters.Add("@mensaje", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
                    result = cmd.ExecuteNonQuery();
                    entiti.mensaje = cmd.Parameters["@mensaje"].Value.ToString();
                    return result;
                }
            }
        }

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

                    cmd.Parameters.Add("@id_contrato", SqlDbType.Int).Value = entiti.Id_contrato;                   
                    cmd.Parameters.Add("@id_banco", SqlDbType.Int).Value = entiti.Id_banco;
                    cmd.Parameters.Add("@id_tcontrato", SqlDbType.Int).Value = entiti.Id_tcontrato;
                    cmd.Parameters.Add("@fecha_inicio", SqlDbType.Date).Value = entiti.Fecha_inicio;
                    cmd.Parameters.Add("@fecha_fin", SqlDbType.Date).Value = entiti.Fecha_fin;
                    cmd.Parameters.AddWithValue("@num_cuenta", SqlDbType.VarChar).Value = entiti.Num_cuenta;
                    cmd.Parameters.Add("@remu_basica", SqlDbType.Money).Value = entiti.Remu_basica;
                    cmd.Parameters.Add("@asig_fami", SqlDbType.Money).Value = entiti.Asig_fami;
                    cmd.Parameters.Add("@regimen_salud", SqlDbType.VarChar,80).Value = entiti.Regimen_salud;
                    cmd.Parameters.Add("@tipo_pago", SqlDbType.VarChar,30).Value = entiti.Tipo_pago;
                    cmd.Parameters.Add("@periodicidad", SqlDbType.VarChar,70).Value = entiti.Periodicidad;
                    cmd.Parameters.Add("@tipo_modeda", SqlDbType.VarChar, 10).Value = entiti.Tipo_moneda;
                    cmd.Parameters.Add("@cuenta_cts", SqlDbType.NVarChar, 50).Value = entiti.Cts;
                    cmd.Parameters.Add("@cussp", SqlDbType.NVarChar, 70).Value = entiti.Cussp;

                    result = cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    return result;
                }
            }
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
                    cmd.CommandText = "SP_ELIM_EMPL";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@id_emp", SqlDbType.Int).Value = entiti.Id_empleado;
                    result = cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    return result;
                }
            }
        }

        public int Delete(Dcontrato entiti)
        {
            throw new NotImplementedException();
        }

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

                        cmd.Parameters.Add("@id_empleado", SqlDbType.Int).Value = entiti.Id_empleado;
                        cmd.Parameters.Add("@nom_emp", SqlDbType.VarChar, 50).Value = entiti.Nom_emp;
                        cmd.Parameters.Add("@ape_pat", SqlDbType.VarChar, 50).Value = entiti.Ape_pat;
                        cmd.Parameters.Add("@ape_mat", SqlDbType.VarChar, 50).Value = entiti.Ape_mat;
                       // cmd.Parameters.Add("@tipo_pension", SqlDbType.VarChar, 30).Value = entiti.Tip_pension;
                        cmd.Parameters.Add("@fec_nac", SqlDbType.Date).Value = entiti.Fec_nac;
                        cmd.Parameters.Add("@nacion", SqlDbType.VarChar, 30).Value = entiti.Nacionalidad;
                        cmd.Parameters.Add("@tip_ge", SqlDbType.VarChar, 12).Value = entiti.Tipo_genero;
                        cmd.Parameters.Add("@direccion", SqlDbType.VarChar, 250).Value = entiti.Direccion;
                        cmd.Parameters.Add("@telefono", SqlDbType.VarChar, 15).Value = entiti.Telefono;
                        cmd.Parameters.Add("@num_doc", SqlDbType.VarChar, 20).Value = entiti.Num_doc;
                        cmd.Parameters.Add("@estado", SqlDbType.VarChar, 20).Value = entiti.Estado;
                        //cmd.Parameters.Add("@id_afp", SqlDbType.Int).Value = entiti.Id_afp;
                        cmd.Parameters.Add("@id_documento", SqlDbType.Int).Value = entiti.Id_doc;
                        cmd.Parameters.Add("@id_cargo", SqlDbType.Int).Value = entiti.Id_cargo;
                        cmd.Parameters.Add("@id_empresa_maestra", SqlDbType.Int).Value = entiti.Id_emp_maestra;

                        result = cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();

                    }

                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
                return result;
            }

        }

        public int Edit(Dcontrato entiti)
        {
            throw new NotImplementedException();
        }

        public DataTable GetData(DEmpleado entiti)
        {
            using (SqlConnection cnn = RConexion.Getconectar())
            {
                cnn.Open();
                cmd = null;
                SqlDataAdapter da = new SqlDataAdapter();
                using (cmd = new SqlCommand())
                {
                    cmd.Connection = cnn;
                    cmd.CommandText = "SP_SHOW_EMP";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@codigo_empresa", SqlDbType.Int).Value = entiti.Id_emp_maestra;                               
                    da.SelectCommand = cmd;

                    using (DataTable dt = new DataTable())
                    {
                        da.Fill(dt);
                        cmd.Parameters.Clear();
                        da.Dispose();
                        return dt;
                    }
                }
            }
        }

        public DataTable GetData(Dcontrato entiti)
        {
            throw new NotImplementedException();
        }
    }
}
