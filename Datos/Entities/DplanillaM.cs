using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entities
{
    public class DplanillaM
    {
        private int id_contrato;
        private int id_mes;
        private int id_empreMaestra;
        private string numero_documento;
        private string nombres;
        private string descrip_regipension;
        private decimal comision;
        private decimal seguro;
        private decimal aporte;
        private string cargop;
        private DateTime fecha_inicio;
        private decimal remune_basica;
        private string asig_familiar;

        public int Id_contrato { get => id_contrato; set => id_contrato = value; }
        public int Id_mes { get => id_mes; set => id_mes = value; }
        public int Id_empreMaestra { get => id_empreMaestra; set => id_empreMaestra = value; }
        public string Numero_documento { get => numero_documento; set => numero_documento = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Descrip_regipension { get => descrip_regipension; set => descrip_regipension = value; }
        public decimal Comision { get => comision; set => comision = value; }
        public decimal Seguro { get => seguro; set => seguro = value; }
        public decimal Aporte { get => aporte; set => aporte = value; }
        public string Cargop { get => cargop; set => cargop = value; }
        public DateTime Fecha_inicio { get => fecha_inicio; set => fecha_inicio = value; }
        public decimal Remune_basica { get => remune_basica; set => remune_basica = value; }
        public string Asig_familiar { get => asig_familiar; set => asig_familiar = value; }
       
    }
}
