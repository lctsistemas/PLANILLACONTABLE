using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Datos.Entities
{
    public class Dtipocontrato
    {
        private Int32 id_tcontrato;
        private String tipo_contrato;
        private String mensaje;

        public Dtipocontrato(int id_tcontrato, string tipo_contrato)
        {
            this.id_tcontrato = id_tcontrato;
            this.tipo_contrato = tipo_contrato;
        }

        public Dtipocontrato()
        {

        }

        public int Id_tcontrato { get => id_tcontrato; set => id_tcontrato = value; }
        public string Tipo_contrato { get => tipo_contrato; set => tipo_contrato = value; }
        
        public String Mensaje { get => mensaje; set => mensaje = value; }

    }
}
