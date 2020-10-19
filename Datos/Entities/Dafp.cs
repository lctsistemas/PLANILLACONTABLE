using System.Collections.Generic;

namespace Datos.Entities
{

    public class Dafp
    {     

        #region Metodo Set and Get
        public int Id_comision { get; set; }
        public int Codigo_regimen { get; set; }
        public decimal Comision { get; set; }
        public decimal Saldo { get;set; }
        public decimal Seguro {get;set; }
        public decimal Aporte {get;set; }
        public decimal Tope { get;set; }
        public int Idmes { get;set; }       
        public int Idperiodo { get;set;}
        public string mensaje { get; set; }
        #endregion
        public List<Dafp> DlistAfp { get; set; }
    }
}
