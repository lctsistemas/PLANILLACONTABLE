using System;

namespace Datos.Entities
{
    public class DPlanilla
    {
        Int32 id_planilla;
        //Int32 id_tipo_planilla;
        Int32 id_periodo;
        String mes;
        DateTime fecha_inicial;
        DateTime fecha_final;
        DateTime fecha_pago;
        Int32 dias_mes;
        Int32 horas_mes;
        Decimal remu_basica;
        Decimal asig_familiar;
        Int32 tope_horario_nocturno;
        public String mensaje { get; set; }
        public DPlanilla(int id_planilla, String mes, int id_periodo, DateTime fecha_inicial, DateTime fecha_final, DateTime fecha_pago, int dias_mes, int horas_mes, decimal remu_basica, decimal asig_familiar, int tope_horario_nocturno)
        {
            this.id_planilla = id_planilla;
            this.id_periodo = id_periodo;
            this.mes = mes;
            this.fecha_inicial = fecha_inicial;
            this.fecha_final = fecha_final;
            this.fecha_pago = fecha_pago;
            this.dias_mes = dias_mes;
            this.horas_mes = horas_mes;
            this.remu_basica = remu_basica;
            this.asig_familiar = asig_familiar;
            this.tope_horario_nocturno = tope_horario_nocturno;
        }

        public DPlanilla()
        {

        }
        public int Id_planilla { get => id_planilla; set => id_planilla = value; }
        //public int Id_tipo_planilla { get => id_tipo_planilla; set => id_tipo_planilla = value; }

        public int Id_periodo { get => id_periodo; set => id_periodo = value; }
        public String Mes { get => mes; set => mes = value; }

        public DateTime Fecha_inicial { get => fecha_inicial; set => fecha_inicial = value; }
        public DateTime Fecha_final { get => fecha_final; set => fecha_final = value; }
        public DateTime Fecha_pago { get => fecha_pago; set => fecha_pago = value; }
        public int Dias_mes { get => dias_mes; set => dias_mes = value; }
        public int Horas_mes { get => horas_mes; set => horas_mes = value; }
        public decimal Remu_basica { get => remu_basica; set => remu_basica = value; }
        public decimal Asig_familiar { get => asig_familiar; set => asig_familiar = value; }
        public int Tope_horario_nocturno { get => tope_horario_nocturno; set => tope_horario_nocturno = value; }
    }
}
