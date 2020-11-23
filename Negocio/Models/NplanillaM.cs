using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Datos.Entities;
using System.Data;
using Datos.Repositories;

namespace Negocio.Models
{
    public class NplanillaM:IDisposable
    {
        public int Id_contrato { get; set; }
        public int Id_mes { get; set; }
        public int Id_empreMaestra { get; set; }
        public string Numero_documento { get; set; }
        public string Nombres { get; set; }
        public string Descrip_regipension { get; set; }
        public decimal VComision { get; set; }
        public decimal VSeguro { get; set; }
        public decimal VAporte { get; set; }
        public string Cargop { get; set; }
        public DateTime Fecha_inicio { get; set; }
        public decimal Remune_basica { get; set; }
        public string Asig_familiar { get; set; }

        private List<NplanillaM> list_planillam;
        DplanillaM dplam;

        public NplanillaM()
        {
            dplam = new DplanillaM();
        }

        // MOSTRAR COMISION AFP
        public IEnumerable<NplanillaM> Show_planillaM()
        {
            list_planillam = new List<NplanillaM>();
            
            dplam.Id_mes = Id_mes;
            dplam.Id_empreMaestra= Id_empreMaestra;

            using (DataTable dt = new RplanillaM().Show_planillaM(dplam))
            {
                foreach (DataRow item in dt.Rows)
                {
                    list_planillam.Add(new NplanillaM()
                    {
                        Id_contrato = Convert.ToInt32(item[0]),
                        Numero_documento = item[1].ToString(),
                        Nombres = item[2].ToString(),
                        Descrip_regipension = item[3].ToString(),
                        VComision = Convert.ToDecimal(item[4]),
                        VSeguro = Convert.ToDecimal(item[5]),
                        VAporte = Convert.ToDecimal(item[6]),
                        Cargop = item[7].ToString(),
                        Fecha_inicio = Convert.ToDateTime(item[8]),
                        Remune_basica =Convert.ToDecimal(item[9]),
                        Asig_familiar=item[10].ToString() == "0.00" ? null : item[10].ToString()

                    });
                }
            }
            return list_planillam;
        }

        public void Dispose()
        {

        }
    }
}
