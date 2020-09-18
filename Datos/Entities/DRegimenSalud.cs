using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entities
{
    public class DRegimenSalud
    {
        private int id_regimen_salud;
        private int cod_regi_salud ;
        private String regimen_salud;
        public String mensaje { get; set; }
        public DRegimenSalud(int id_regimen_salud, int cod_regi_salud, string regimen_salud)
        {
            this.Id_regimen_salud = id_regimen_salud;
            this.Cod_regi_salud = cod_regi_salud;
            this.Regimen_salud = regimen_salud;
        }

        public DRegimenSalud(){
       }

        public int Id_regimen_salud { get => id_regimen_salud; set => id_regimen_salud = value; }
        public int Cod_regi_salud { get => cod_regi_salud; set => cod_regi_salud = value; }
        public string Regimen_salud { get => regimen_salud; set => regimen_salud = value; }
    }
}
