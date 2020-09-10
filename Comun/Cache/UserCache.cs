namespace Comun.Cache
{
    public static class UserCache
    {
        public static int IdUser { get; set; }
        public static string CodigoUser { get; set; }
        public static string NombreUser { get; set; }
        public static string RolUser { get; set; }


        public static int Codigo_empresa { get; set; }//ES EL ID EMPRESA MAESTRA/PARA PODER REGISTRAR EMPLEADO
        public static string Empresa { get; set; }//RAZON SOCIAL.
        public static string Localidad_empresa { get; set; }
        public static string Empresa_Sucursal { get; set; }

        //PERIODO
        public static string Periodo { get; set; }
        public static int Idperiodo { get; set; }
    }
}
