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
        public int PId_contrato { get; set;}
        public string PJornada_laboral { get; set; }
        public string PCod_documento { get; set; }
        public int PId_mes { get; set;}
        public int PId_empreMaestra { get; set;}
        public string PNumero_documento { get; set;}
        public string PNombres { get; set;}
        public string PDescrip_regipension { get; set;}
        public decimal PVcomision { get; set; }
        public decimal PVseguro { get; set; }
        public decimal PVaporte { get; set; }
        public string PCargop { get; set; }
        public DateTime PFecha_inicio { get; set; }
        public DateTime PFecha_fin { get; set; }
        public decimal PRemune_basica { get; set; }
        public string PAsig_familiar { get; set; }

        private List<NplanillaM> list_planillam;
        DplanillaM dplam;

        public NplanillaM()
        {
            dplam = new DplanillaM();
        }

        // MOSTRAR COMISION AFP
        public IEnumerable<NplanillaM> Show_planillaM(int Pid_planilla)
        {
            list_planillam = new List<NplanillaM>();
                        
            dplam.Pid_mes = PId_mes;
            dplam.Pid_empreMaestra= PId_empreMaestra;
            dplam.Pfecha_inicio = PFecha_inicio;
            dplam.Pfecha_fin = PFecha_fin;

            using (DataTable dt = new RplanillaM().Show_planillaM(dplam, Pid_planilla))
            {
                foreach (DataRow item in dt.Rows)
                {
                    list_planillam.Add(new NplanillaM()
                    {
                        PId_contrato = Convert.ToInt32(item[0]),
                        PJornada_laboral = item[1].ToString(),
                        PCod_documento = item[2].ToString(),
                        PNumero_documento = item[3].ToString(),
                        PNombres = item[4].ToString(),
                        PDescrip_regipension = item[5].ToString(),
                        PVcomision = Convert.ToDecimal(item[6]),
                        PVseguro = Convert.ToDecimal(item[7]),
                        PVaporte = Convert.ToDecimal(item[8]),
                        PCargop = item[9].ToString(),
<<<<<<< HEAD
                        PFecha_inicio = Convert.ToDateTime(item[10]),
                        //PFecha_fin = Convert.ToDateTime(item[11]),                      
                        PRemune_basica = Convert.ToDecimal(item[12]),

                        //if (item[13].ToString().Replace(",",".") == "0,00" || item[13].ToString() == "0,00")

                        //PAsig_familiar = item[13].ToString() == "0,00" || item[13].ToString() == "0.00" ? null : item[13].ToString(),

                        PAsig_familiar = item[13].ToString().Replace(",", ".") == "0.00" ? null : item[13].ToString()

                    }) ;
                    //System.Windows.Forms.MessageBox.Show("af: " + item[13].ToString());

=======
                        PFecha_inicio = Convert.ToDateTime(item[10]),                      
                        //PFecha_fin = Convert.ToDateTime(item[11]),                   
                        PRemune_basica = Convert.ToDecimal(item[12]),
                        //PAsig_familiar = item[13].ToString() == "0.00" || item[13].ToString() == "0,00" ? null : item[13].ToString()
                        PAsig_familiar = item[13].ToString() == "0" ? null : item[13].ToString()
                        //PAsig_familiar = item[13].ToString().Replace(",",".") == "0.00" ? null : item[13].ToString()
                       
                    });
>>>>>>> Carlos2
                }
            }
            return list_planillam;
        }

        public void Dispose()
        {

        }
    }
}
