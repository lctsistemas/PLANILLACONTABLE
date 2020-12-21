using System;

namespace Datos.Entities
{
    public class DPlanilla
    {
        private Int32 id_planilla;
        private Int32 idtipo_planilla;
        private Int32 id_periodo;
        private Int32 id_empresam;
        private Int32 id_mes;      
        private DateTime fecha_inicial;
        private DateTime fecha_final;
        private DateTime fecha_pago;
        private Int32 dias_mes;
        private Int32 horas_mes;     
        private decimal tope_horario_nocturno;

       /* public DPlanilla(int id_planilla, int id_periodo, int id_empresam, int id_mes, DateTime fecha_inicial,
            DateTime fecha_final, DateTime fecha_pago, int dias_mes, int horas_mes, decimal tope_horario_nocturno)
        {
            this.id_planilla = id_planilla;
            this.id_periodo = id_periodo;
            this.id_empresam = id_empresam;
            this.id_mes = id_mes;         
            this.fecha_inicial = fecha_inicial;
            this.fecha_final = fecha_final;
            this.fecha_pago = fecha_pago;
            this.dias_mes = dias_mes;
            this.horas_mes = horas_mes;         
            this.tope_horario_nocturno = tope_horario_nocturno;
        }*/

       // public DPlanilla() { }

        public String mensaje { get; set; }
        public int Id_planilla { get => id_planilla; set => id_planilla = value; }
        public int Idtipo_planilla { get => idtipo_planilla; set => idtipo_planilla = value; }
        public int Id_periodo { get => id_periodo; set => id_periodo = value; }
        public int Id_empresam { get => id_empresam; set => id_empresam = value; }
        public int Id_mes { get => id_mes; set => id_mes = value; }      
        public DateTime Fecha_inicial { get => fecha_inicial; set => fecha_inicial = value; }
        public DateTime Fecha_final { get => fecha_final; set => fecha_final = value; }
        public DateTime Fecha_pago { get => fecha_pago; set => fecha_pago = value; }
        public int Dias_mes { get => dias_mes; set => dias_mes = value; }
        public int Horas_mes { get => horas_mes; set => horas_mes = value; }  
        public decimal Tope_horario_nocturno { get => tope_horario_nocturno; set => tope_horario_nocturno = value; }


    }
}
