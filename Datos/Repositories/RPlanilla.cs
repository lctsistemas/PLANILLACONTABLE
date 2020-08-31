﻿using Datos.Contract;
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
    public class RPlanilla: IPlanilla
    {
        Int32 result;
        SqlCommand cmd;
        public int Add(DPlanilla entiti)
        {
            result = 0;
            using (SqlConnection connect = RConexion.Getconectar())
            {
                connect.Open();
                using (cmd = new SqlCommand())
                {
                    cmd.Connection = connect;
                    cmd.CommandText = "SP_INSERT_PLANILLA";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@id_planilla", SqlDbType.Int).Value = entiti.Id_planilla;
                    cmd.Parameters.Add("@id_tipo_planilla", SqlDbType.Int).Value = entiti.Id_tipo_planilla;
                    cmd.Parameters.Add("@fecha_pago", SqlDbType.Date).Value = entiti.Fecha_pago;
                    cmd.Parameters.Add("@dias_mes", SqlDbType.Int).Value = entiti.Dias_mes;
                    cmd.Parameters.Add("@horas_mes", SqlDbType.Int).Value = entiti.Horas_mes;
                    cmd.Parameters.Add("@remu_basica", SqlDbType.Decimal).Value = entiti.Dias_mes;
                    cmd.Parameters.Add("@asig_familiar", SqlDbType.Decimal).Value = entiti.Asig_familiar;
                    cmd.Parameters.Add("@tope_horario_nocturno", SqlDbType.Int).Value = entiti.Tope_horario_nocturno;

                    

                    cmd.Parameters.Add("@mesage", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
                    result = cmd.ExecuteNonQuery();
                    entiti.mensaje = cmd.Parameters["@mesage"].Value.ToString();
                    cmd.Parameters.Clear();

                    return result;
                }
            }
        }

        public int Edit(DPlanilla entiti)
        {
            throw new NotImplementedException();
        }

        public int Delete(DPlanilla entiti)
        {
            throw new NotImplementedException();
        }

        public DataTable GetData(DPlanilla entiti)
        {
            throw new NotImplementedException();
        }
    }
}