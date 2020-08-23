using Datos.Contract;
using Negocio.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Models
{
    class NRegimen:IDisposable
    {
        //String mensaje;

        public int Codigo_Regimen { get; set; }
        public String Descripcion_corta { get; set; }

        public String Descripcion { get; set; }

        public String Tipo_regimen { get; set; }

        public EntityState state { get; set; }

        //public IBanco RBanco;

        //private List<NRegimen> list_regimen;

        public NRegimen()
        {
           // NRegimen = new R();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
