﻿using Datos.Contract;
using Datos.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Datos.Repositories
{
    public class REmpleado : IEmpleado
    {
        Int32 result;
        SqlCommand cmd;
        public int Add(DEmpleado entiti)
        {
            result = 0;
            using (SqlConnection connect = RConexion.Getconectar())
            {
                connect.Open();
                using (SqlCommand cmd =new SqlCommand())
                {
                    cmd.Connection=connect;
                    cmd.CommandText = "SP_AGR_EMPL";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@id_empleado", SqlDbType.Int).Value = entiti.Id_empleado;
                    cmd.Parameters.Add("@nom_emp", SqlDbType.VarChar,50).Value = entiti.Nom_emp;
                    cmd.Parameters.Add("@ape_pat", SqlDbType.VarChar,50).Value = entiti.Ape_pat;
                    cmd.Parameters.Add("@ape_mat", SqlDbType.VarChar,50).Value = entiti.Ape_mat;
                    cmd.Parameters.Add("@tipo_pension", SqlDbType.VarChar,30).Value = entiti.Tip_pension;
                    cmd.Parameters.Add("@fec_nac", SqlDbType.Date).Value = entiti.Fec_nac;
                    cmd.Parameters.Add("@nacion", SqlDbType.VarChar,30).Value = entiti.Nacionalidad;
                    cmd.Parameters.Add("@tip_ge", SqlDbType.VarChar,12).Value = entiti.Tipo_genero;
                    cmd.Parameters.Add("@direccion", SqlDbType.VarChar,250).Value = entiti.Direccion;
                    cmd.Parameters.Add("@telefono", SqlDbType.VarChar,15).Value = entiti.Telefono;
                    cmd.Parameters.Add("@num_doc", SqlDbType.VarChar,20).Value = entiti.Num_doc;
                    cmd.Parameters.Add("@estado", SqlDbType.VarChar,20).Value = entiti.Estado;
                    cmd.Parameters.Add("@id_afp", SqlDbType.Int).Value = entiti.Id_afp;
                    cmd.Parameters.Add("@id_documento", SqlDbType.Int).Value = entiti.Id_doc;
                    cmd.Parameters.Add("@id_cargo", SqlDbType.Int).Value = entiti.Id_cargo;
                    cmd.Parameters.Add("@id_empresa_maestra", SqlDbType.Int).Value = entiti.Id_emp_maestra;
                    cmd.Parameters.Add("@mensaje", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
                    result = cmd.ExecuteNonQuery();
                    entiti.mensaje = cmd.Parameters["@mensaje"].Value.ToString();
                   
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
                using (cmd= new SqlCommand())
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
                    cmd.Parameters.Add("@tipo_pension", SqlDbType.VarChar, 30).Value = entiti.Tip_pension;
                    cmd.Parameters.Add("@fec_nac", SqlDbType.Date).Value = entiti.Fec_nac;
                    cmd.Parameters.Add("@nacion", SqlDbType.VarChar, 30).Value = entiti.Nacionalidad;
                    cmd.Parameters.Add("@tip_ge", SqlDbType.VarChar, 12).Value = entiti.Tipo_genero;
                    cmd.Parameters.Add("@direccion", SqlDbType.VarChar, 250).Value = entiti.Direccion;
                    cmd.Parameters.Add("@telefono", SqlDbType.VarChar, 15).Value = entiti.Telefono;
                    cmd.Parameters.Add("@num_doc", SqlDbType.VarChar,20).Value = entiti.Num_doc;
                    cmd.Parameters.Add("@estado", SqlDbType.VarChar, 20).Value = entiti.Estado;
                    cmd.Parameters.Add("@id_afp", SqlDbType.Int).Value = entiti.Id_afp;
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

        public DataTable GetData(DEmpleado entiti)
        {
            using (SqlConnection cnn = RConexion.Getconectar())
            {
                cnn.Open();
                cmd = null;
                SqlDataAdapter da = new SqlDataAdapter();
                using (cmd= new SqlCommand())
                {
                    cmd.Connection = cnn;
                    cmd.CommandText = "SP_SHOW_EMP";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@search", SqlDbType.VarChar, 50).Value = entiti.Nom_emp;

                    da.SelectCommand = cmd;

                    using (DataTable dt=new DataTable())
                    {
                        da.Fill(dt);
                        cmd.Parameters.Clear();
                        da.Dispose();
                        return dt;
                    }
                }
            }
        }
    }
}
