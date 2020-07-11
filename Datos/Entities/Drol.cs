using System;

namespace Datos.Entities
{
    public class Drol
    {
        private Int32 idrol;
        private String nombre_rol;
        public String mesage { get; set; }

        //METODOS SET AND GET
        public Int32 Idrol
        {
            get { return idrol; }
            set { idrol = value; }
        }

        public String Nombre_rol
        {
            get { return nombre_rol; }
            set { nombre_rol = value; }
        }

    }
}
