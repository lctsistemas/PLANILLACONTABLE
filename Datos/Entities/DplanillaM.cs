using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entities
{
    public class DplanillaM
    {

        private int pid_contrato;
        private int pid_mes;
        private int pid_empreMaestra;
        private string pnumero_documento;
        private string pnombres;
        private string pdescrip_regipension;
        private decimal pcomision;
        private decimal pseguro;
        private decimal paporte;
        private string pcargop;
        private DateTime pfecha_inicio;
        private DateTime pfecha_fin;
        private decimal premune_basica;
        private string pasig_familiar;

        public int Pid_contrato { get => pid_contrato; set => pid_contrato = value; }
        public int Pid_mes { get => pid_mes; set => pid_mes = value; }
        public int Pid_empreMaestra { get => pid_empreMaestra; set => pid_empreMaestra = value; }
        public string Pnumero_documento { get => pnumero_documento; set => pnumero_documento = value; }
        public string Pnombres { get => pnombres; set => pnombres = value; }
        public string Pdescrip_regipension { get => pdescrip_regipension; set => pdescrip_regipension = value; }
        public decimal Pcomision { get => pcomision; set => pcomision = value; }
        public decimal Pseguro { get => pseguro; set => pseguro = value; }
        public decimal Paporte { get => paporte; set => paporte = value; }
        public string Pcargop { get => pcargop; set => pcargop = value; }
        public DateTime Pfecha_inicio { get => pfecha_inicio; set => pfecha_inicio = value; }
        public DateTime Pfecha_fin { get => pfecha_fin; set => pfecha_fin = value; }
        public decimal Premune_basica { get => premune_basica; set => premune_basica = value; }
        public string Pasig_familiar { get => pasig_familiar; set => pasig_familiar = value; }
    }
}
