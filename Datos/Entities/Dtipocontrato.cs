using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Datos.Entities
{
    public class Dtipocontrato
    {
        private Int32 id_tcontrato;
        private String tiempo_contrato;

        public int Id_tcontrato { get { return id_tcontrato; } set { id_tcontrato = value; } }
        public string Tiempo_contrato { get { return tiempo_contrato; } set { tiempo_contrato = value; } }

        public Dtipocontrato() { }
    }
}
