using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entities
{
    public class DSubsidios
    {
        Int32 id_subsidios;
        Int32 cod_subsidios;
        String descripcion_subsidio;
        String tipo_subsidio;
        String descuento;

        public DSubsidios(int id_subsidios, int cod_subsidios, string descripcion_subsidio, string tipo_subsidio, string descuento)
        {
            this.Id_subsidios = id_subsidios;
            this.Cod_subsidios = cod_subsidios;
            this.Descripcion_subsidio = descripcion_subsidio;
            this.Tipo_subsidio = tipo_subsidio;
            this.Descuento = descuento;
        }
        public DSubsidios(){

        }
    public int Id_subsidios { get => id_subsidios; set => id_subsidios = value; }
        public int Cod_subsidios { get => cod_subsidios; set => cod_subsidios = value; }
        public string Descripcion_subsidio { get => descripcion_subsidio; set => descripcion_subsidio = value; }
        public string Tipo_subsidio { get => tipo_subsidio; set => tipo_subsidio = value; }
        public string Descuento { get => descuento; set => descuento = value; }
    }
}
