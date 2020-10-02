using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion.Helps
{
    public class Calculo
    {

        public static double HoraExDiurna(double basico, double asig_fami, double taza, int hora, int minuto)
        {
            double hora_diario =(((basico + asig_fami) / 30 )/ 8);
            double hora_minuto = (hora_diario / 60);
            double taza_mashoradiario = (hora_diario * taza) + hora_diario;
            double taza_mashoraminuto = (hora_minuto * taza) + hora_minuto;
            double montohora = (taza_mashoradiario * hora);
            double montominuto = (taza_mashoraminuto * minuto);
            return (montohora + montominuto);
        }
      
    }
}
