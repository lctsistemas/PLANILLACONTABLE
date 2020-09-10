namespace Comun.Comunicacion
{
    public class Dapi
    {
        public string dni { get; set; }//tiene que ser igual al Json que Enviamos que es igual al que nos trae la consulta al api. por post        
    }

    public static class RecuperarData
    {
        public static string nombres { get; set; }
        public static string paterno { get; set; }
        public static string materno { get; set; }
        public static string mensaje { get; set; }
    }
}
