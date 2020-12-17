
namespace Datos.Entities
{
    public class DRegimenSalud
    {
        private int id_regimen_salud;
        private string cod_regi_salud;
        private string descripcion;
        public string mensaje { get; set; }      

        public int Id_regimen_salud { get => id_regimen_salud; set => id_regimen_salud = value; }
        public string Cod_regi_salud { get => cod_regi_salud; set => cod_regi_salud = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        public DRegimenSalud()
        {
        }

        public DRegimenSalud(int id_regimen_salud, string cod_regi_salud, string descrip)
        {
            this.Id_regimen_salud = id_regimen_salud;
            this.Cod_regi_salud = cod_regi_salud;
            this.Descripcion = descrip;
        }
       
    }
}
