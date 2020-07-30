using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Datos.Entities
{
    public class Dtipocontrato
    {
        private Int32 id_tcontrato;
        private string tipo_contrato;
        private string mensaje;

        public Dtipocontrato(int id_tcontrato, string tipo_contrato,string mensaje)
        {
            this.id_tcontrato = id_tcontrato;
            this.tipo_contrato = tipo_contrato;
            this.mensaje = mensaje;
        }

        public Dtipocontrato()
        {

        }

        public int Id_tcontrato { get; set ; }
        public string Tipo_contrato { get ; set ; }
        
        public string Mensaje { get ; set ; }
        

    }
}
