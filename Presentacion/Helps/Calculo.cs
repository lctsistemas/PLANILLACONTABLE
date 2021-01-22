using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion.Helps
{
    public  class Calculo
    {
        //TODO CODIGO AQUI SE PUEDE SIMPLIFICAR CREANDO METODOS ESPECIFICOS. PARA SISTEMA 1.1

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
        
        public static double FeriadoDom(double basico, double asig_fami, int hora, int minuto, string jornadaLabo)
        {
            
            double sub_hora = 0;
            double sub_minuto = 0;
            if (jornadaLabo.Equals("PART-TIME"))
            {
                sub_hora = (((basico + asig_fami) / 30) / 3.5);
                sub_minuto = (sub_hora / 60);
            }
            else
            {
                sub_hora = (((basico + asig_fami) / 30) / 8);
                sub_minuto = (sub_hora / 60);
            }
            

            double importe_hora = (sub_hora * 2) * hora;
            double importe_minuto = (sub_minuto * 2) * minuto;

            double importe_feriado = (importe_hora + importe_minuto);
            return importe_feriado;
        }

        public static double BoniNocturno(double basico, double asig_fami, int hora, string jornadaLabo)
        {
            double sub_hora = 0;
            if (jornadaLabo.Equals("PART-TIME"))
                sub_hora = (((basico + asig_fami) / 30) / 3.5);
            else
                sub_hora = (((basico + asig_fami) / 30) / 8);
            
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

        public static decimal MontoSubsidios(int dia, decimal basico, decimal asig_fami, int diames)
        {
            decimal monto_Sub = 0;
            decimal diario = (basico / 30);

            if (diames == 30)
            {
                if (dia == 30)
                    monto_Sub = ((diario * dia) + asig_fami);
                else if (dia < 30 && dia > 0)
                    monto_Sub = (diario * dia);
            }
            else if (diames == 31)
            {
                if (dia == 31)
                    monto_Sub = ((diario * (dia - 1)) + asig_fami);
                else if (dia == 30)
                    monto_Sub = ((diario * dia) + asig_fami);
                else if (dia < 30 && dia > 0)
                    monto_Sub = (diario * dia);
            }
            else if (diames == 28)
            {
                if (dia == 28)
                    monto_Sub = ((diario * (dia + 2)) + asig_fami);
                else if (dia < 28 && dia > 0)
                    monto_Sub = (diario * dia);
            }
            else if (diames == 29)
            {
                if (dia == 29)
                    monto_Sub = ((diario * (dia + 1)) + asig_fami);
                else if (dia < 29 && dia > 0)
                    monto_Sub = (diario * dia);
            }
            return monto_Sub;

        }
                    
        //SOBRECARGA.
        public static decimal MontoSubsidios(int dia, decimal basico, int diames)
        {
            decimal monto_Sub = 0;
            decimal diario = (basico / 30);

            if (diames == 30)
            {
                if (dia == 30)
                    monto_Sub = ((diario * dia));
                else if (dia < 30 && dia > 0)
                    monto_Sub = (diario * dia);
            }
            else if (diames == 31)
            {
                if (dia == 31)
                    monto_Sub = (diario * (dia - 1));               
                else if (dia < 31 && dia > 0)
                    monto_Sub = (diario * dia);
            }
            else if (diames == 28)
            {
                if (dia == 28)
                    monto_Sub = (diario * (dia + 2));
                else if (dia < 28 && dia > 0)
                    monto_Sub = (diario * dia);
            }
            else if (diames == 29)
            {
                if (dia == 29)
                    monto_Sub = (diario * (dia + 1));
                else if (dia < 29 && dia > 0)
                    monto_Sub = (diario * dia);
            }
            return monto_Sub;
            
        }

        //EL 9% DE LA GRATIFICACION PARA LA BONIFICACION
        public static double BonificacionGrati(double gratifi)
        {
            return (gratifi * 0.09);
        }


        //CALCULO DE ESSALUD
        public static double EssaludMonto(double noafect, double e_subsidio, double totaremune, double rmv, double porcentaje )
        {
            double monto_essalud = 0;
            double porciento = (porcentaje / 100);
            double descuento = (noafect + e_subsidio);

            if (e_subsidio > 0)
                monto_essalud = ((totaremune - descuento) * porciento);
            else
            {
                if (totaremune < rmv)
                    monto_essalud = (rmv * porciento);
                else
                    monto_essalud = ((totaremune - descuento) * porciento);
            }
            return monto_essalud;
        }


    }
}


