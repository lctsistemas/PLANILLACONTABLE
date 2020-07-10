using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Datos.Repositories;
using System.Windows.Forms;

namespace Datos.KeyAutomatic
{
    public class Kusuario
    {
       
        public int Getcodigo() {
            Int32 codigo=0;
            using (SqlConnection cnn=RConexion.Getconectar())
            {
                cnn.Open();
                using (SqlCommand cmd=new SqlCommand())
                {          
                        cmd.Connection = cnn;
                        cmd.CommandText = "SP_GENERAR_USUARIO";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@usuario", SqlDbType.Int).Direction = ParameterDirection.Output;
                        cmd.ExecuteNonQuery();
                        
                        codigo = Convert.ToInt32(cmd.Parameters["@usuario"].Value);
                        cmd.Parameters.Clear();
                 }                                       
                 
                return codigo;
            }
           
        }

    }

}
