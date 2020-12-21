using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entities
{
    public class DTipoPlanilla
    {
        private int idtipoplanilla;
        private string tipoplanilla;
        public string mensaje { get; set; }

        public int Idtipoplanilla { get => idtipoplanilla; set => idtipoplanilla = value; }
        public string TipoPlanilla { get => tipoplanilla; set => tipoplanilla = value; }

        public DTipoPlanilla(int idtipoplanilla, string tipoPlanilla)
        {
            this.idtipoplanilla = idtipoplanilla;
            TipoPlanilla = tipoPlanilla;
        }

        public DTipoPlanilla()
        {

        }


    }
}
