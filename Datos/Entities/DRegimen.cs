using System;

namespace Datos.Entities
{
    public class DRegimen
    {
        private int codigo_regimen;
        private String descripcion_corta;
        private String descripcion;
        private String tipo_regimen;
        public String mensaje { get; set; }
        public int Codigo_regimen
        {
            get
            {
                return codigo_regimen;
            }

            set
            {
                codigo_regimen = value;
            }
        }

        public string Descripcion_corta
        {
            get
            {
                return descripcion_corta;
            }

            set
            {
                descripcion_corta = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return descripcion;
            }

            set
            {
                descripcion = value;
            }
        }

        public String Tipo_regimen
        {
            get
            {
                return tipo_regimen;
            }

            set
            {
                tipo_regimen = value;
            }
        }

        public DRegimen(int codigo_regimen, string descripcion_corta, string descripcion, String tipo_regimen)
        {
            this.Codigo_regimen = codigo_regimen;
            this.Descripcion_corta = descripcion_corta;
            this.Descripcion = descripcion;
            this.Tipo_regimen = tipo_regimen;
        }

        public DRegimen()
        {

        }


    }
}
