using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion.Helps
{
    public  class Calculo
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

        public static double FeriadoDom(double basico, double asig_fami, int hora, int minuto)
        {
            double sub_hora = (((basico + asig_fami) / 30) / 8);
            double sub_minuto = (sub_hora / 60);

            double importe_hora = (sub_hora * 2) * hora;
            double importe_minuto = (sub_minuto * 2) * minuto;

            double importe_feriado = (importe_hora + importe_minuto);
            return importe_feriado;
        }

        public static double BoniNocturno(double basico, double asig_fami, int hora)
        {
            double sub_hora = (((basico + asig_fami) / 30) / 8);
            double hora_mastasa = (sub_hora * 0.35);
            double boninocturno = (hora_mastasa * hora);
            return boninocturno;
        }

        public static double Tardanza(double basico, int hor, int minu)
        {
            double hora = ((basico / 30) / 8);
            double minuto = (hora / 60);

            double imp_hora = (hora * hor);
            double imp_minu = (minuto * minu);
            double imp_tarde = (imp_hora + imp_minu);
            return imp_tarde;
        }


        public static decimal MontoSubsidios(int dia, decimal basico, decimal asig_fami)
        {
            decimal monto_Sub = 0;
            decimal diario = (basico / 30);

            //le falta.
            if (dia >= 30 && dia <=31 )
            {
                monto_Sub = ((diario * dia) + asig_fami);
            }else if( dia < 30)
            {
                monto_Sub = (diario * dia);
            }            
            return monto_Sub;
        }

        //SOBRECARGA.
        public static decimal MontoSubsidios(int dia, decimal basico)
        {
            decimal monto_Sub = 0;
            decimal diario = (basico / 30);

            monto_Sub = (diario * dia);
            return monto_Sub;
        }

    }
}
