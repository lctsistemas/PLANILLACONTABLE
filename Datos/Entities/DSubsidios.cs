using System;

namespace Datos.Entities
{
    public class DSubsidios
    {
        private Int32 id_subsidios;
        private string cod_subsidios;
        private string tipo_supension;
        private string descrip_corta;
        private String descripcion_subsidio;
        private String tipo_subsidio;
        private bool descuento;

       
        public int Id_subsidios { get => id_subsidios; set => id_subsidios = value; }
        public string Cod_subsidios { get => cod_subsidios; set => cod_subsidios = value; }
        public string Tipo_supension { get => tipo_supension; set => tipo_supension = value; }
        public string Descrip_corta { get => descrip_corta; set => descrip_corta = value; }
        public string Descripcion_subsidio { get => descripcion_subsidio; set => descripcion_subsidio = value; }
        public string Tipo_subsidio { get => tipo_subsidio; set => tipo_subsidio = value; }
        public bool Descuento { get => descuento; set => descuento = value; }
       

        public DSubsidios(int id_subsidios, string cod_subsidios, string descripcion_subsidio, string tipo_subsidio, bool descuento)
        {
            this.Id_subsidios = id_subsidios;
            this.Cod_subsidios = cod_subsidios;
            this.Descripcion_subsidio = descripcion_subsidio;
            this.Tipo_subsidio = tipo_subsidio;
            this.Descuento = descuento;
        }
        public DSubsidios()
        {
        }

    }
}
