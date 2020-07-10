using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Datos.Entities
{
    public class Dusuario
    {
        private Int32 idusuario;
        private String codigo_usu;
        private String nombre_refe;
        private String password;
        private Int32 idrol;
        public String mesage { get; set; }

        //METOOS SET AND GET
        public Int32 Idusuario
        {
            get { return idusuario; }
            set { idusuario = value; }
        }
        public String Codigo_usu
        {
            get { return codigo_usu; }
            set { codigo_usu = value; }
        }
        public String Nombre_refe
        {
            get { return nombre_refe; }
            set { nombre_refe = value; }
        }
        public String Password
        {
            get { return password; }
            set { password = value; }
        }
        public Int32 Idrol
        {
            get { return idrol; }
            set { idrol = value; }
        }
    }
}
