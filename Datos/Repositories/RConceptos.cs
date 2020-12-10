using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using Datos.Entities;


namespace Datos.Repositories
{
    public class RConceptos
    {
        int result;
        public int SaveAddUpdate(DConceptos entiti)
        {
            result = 0;
            using (SqlConnection conect = RConexion.Getconectar())
            {
                conect.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conect;
                    cmd.CommandText = "SP_RegistroConceptos";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id_conceptos", entiti.Id_conceptos);
                    cmd.Parameters.AddWithValue("@id_mes", entiti.Id_mes);
                    cmd.Parameters.AddWithValue("@id_planilla", entiti.Id_planilla);
                    cmd.Parameters.AddWithValue("@hextraDiurna", entiti.HextraDiurna);
                    cmd.Parameters.AddWithValue("@hextraNocturna", entiti.HextraNocturna);
                    cmd.Parameters.AddWithValue("@feriadoDomi", entiti.FeriadoDomi);
                    cmd.Parameters.AddWithValue("@boniNocturna", entiti.BoniNoctur);
                    cmd.Parameters.AddWithValue("@primeromayo", entiti.PrimeroMayo);
                    cmd.Parameters.AddWithValue("@tarda", entiti.Tarda);
                    cmd.Parameters.AddWithValue("@subsi", entiti.Subsidi);
                    cmd.Parameters.AddWithValue("@thoraex", entiti.Thoraex);
                    cmd.Parameters.AddWithValue("@otroreinte", entiti.Otroreinte);
                    cmd.Parameters.AddWithValue("@prest_aliment", entiti.Prest_aliment);
                    cmd.Parameters.AddWithValue("@gratif", entiti.Gratif);
                    cmd.Parameters.AddWithValue("@vaca", entiti.Vaca);
                    cmd.Parameters.AddWithValue("@truncas", entiti.Trunca);
                    cmd.Parameters.AddWithValue("@reinte_gratiboni", entiti.Reinte_gratiboni);
                    cmd.Parameters.AddWithValue("@essa_vida", entiti.Essa_vida);
                    cmd.Parameters.AddWithValue("@adela", entiti.Adela);
                    cmd.Parameters.AddWithValue("@presta", entiti.Presta);
                    cmd.Parameters.AddWithValue("@rentquinta", entiti.Rentquinta);
                    cmd.Parameters.AddWithValue("@reten_judici", entiti.Reten_judici);
                    cmd.Parameters.AddWithValue("@otrodescu", entiti.Otrodescu);
                    cmd.Parameters.AddWithValue("@recarg_consu", entiti.Recarg_consu);
                    result = cmd.ExecuteNonQuery();

                    cmd.Parameters.Clear();
                }
            }
            return result;
        }

        public DataTable GetData(DConceptos entiti)
        {
            DataTable dt=null;
            using (SqlConnection conect = RConexion.Getconectar())
            {
                conect.Open();                
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conect;
                    cmd.CommandText = "SP_SHOW_CONCEPTOS";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@idmes", entiti.Id_mes);
                    cmd.Parameters.AddWithValue("@idplanilla", entiti.Id_planilla);
                    
                    SqlDataReader reader = cmd.ExecuteReader();
                    using (dt = new DataTable())
                    {
                        dt.Load(reader);
                        reader.Close();
                    }
                }
            }
            return dt;
        }


    }
}
