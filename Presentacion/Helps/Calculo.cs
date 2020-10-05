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

        public static double HoraExNocturnas(double basico, double asig_fami, double taza, int hora, int minuto)
        {
            double hora_diario = (((basico + asig_fami) / 30) / 8);
            double hora_minuto = (hora_diario / 60);
            double taza_mashoradiario = (hora_diario * taza) + hora_diario;
            double taza_mashoraminuto = (hora_minuto * taza) + hora_minuto;

            double taza_nocturnamashora = ((taza_mashoradiario * 0.35) + taza_mashoradiario);
            double taza_nocturnamasminuto = ((taza_mashoraminuto * 0.35) + taza_mashoraminuto);
            
            double montohora = (taza_nocturnamashora * hora);
            double montominuto = (taza_nocturnamasminuto * minuto);
            return (montohora + montominuto);
        }
    }
}
