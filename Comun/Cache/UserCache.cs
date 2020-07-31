using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comun.Cache
{
    public static class UserCache
    {
        public static int IdUser { get; set; }
        public static string CodigoUser { get; set; }
        public static string NombreUser { get; set; }
        public static string RolUser { get; set; }

        //DATOS DE EMPRESA
        public static int Codigo_sucursal { get; set; }//ES EL ID EMPRESA MAESTRA / PARA PODER REGISTRAR EMPLEADO
        public static string Sucursal { get; set; }//LA RAZON SOCIAL.
        public static string Localidad_sucursal { get; set; }
        public static int Codigo_empresa { get; set; }//ES EL ID EMPRESA MAESTRA/PARA PODER REGISTRAR EMPLEADO
        public static string Empresa { get; set; }//RAZON SOCIAL.
        public static string Localidad_empresa { get; set; }



    }
}
