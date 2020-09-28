using Datos.Contract;
using Datos.Entities;
using Datos.KeyAutomatic;
using Datos.Repositories;
using Negocio.ValueObjects;
using System;
using System.Collections.Generic;
using System.Data;

namespace Negocio.Models
{
    public class NPlanilla : IDisposable
    {
        String mensaje;
        public int Id_planilla
        {
            get; set;

        }

        /*public int Id_tipo_planilla
        {
            get; set;
        }*/



        public int Id_periodo
        {
            get; set;
        }

        public int Id_empresa
        {
            get; set;
        }

        public String Mes
        {
            get; set;
        }

        public DateTime Fecha_inicial
        {
            get; set;
        }

        public DateTime Fecha_final
        {
            get; set;
        }

        public DateTime Fecha_pago
        {
            get; set;
        }

        public int Dias_mes
        {
            get; set;
        }

        public int Horas_mes
        {
            get; set;
        }

        public Decimal Remu_basica
        {
            get; set;
        }

        public Decimal Asig_familiar
        {
            get; set;
        }

        public int Tope_horario_nocturno
        {
            get; set;
        }

        public EntityState state { get; set; }


        public IPlanilla rplanilla;
        private List<NPlanilla> list_planilla;

        //private List<NBanco> list_banco;

        public NPlanilla()
        {
            rplanilla = new RPlanilla();
        }

        public String GuardarCambios()
        {
            DPlanilla pla = new DPlanilla();
            //pla.Id_tipo_planilla = Id_tipo_planilla;
            pla.Id_planilla = Id_planilla;
            pla.Id_periodo = Id_periodo;
            pla.Id_empresa = Id_empresa;
            pla.Mes = Mes;
            pla.Fecha_inicial = Fecha_inicial;
            pla.Fecha_final = Fecha_final;
            pla.Fecha_pago = Fecha_pago;
            pla.Dias_mes = Dias_mes;
            pla.Horas_mes = Horas_mes;
            pla.Remu_basica = Remu_basica;
            pla.Asig_familiar = Asig_familiar;
            pla.Tope_horario_nocturno = Tope_horario_nocturno;

            switch (state) 
            {
                case EntityState.Guardar:
                    rplanilla.Add(pla);
                    mensaje = pla.mensaje;
                    break;
                case EntityState.Modificar:
                    rplanilla.Edit(pla);
                    mensaje = "Editado correctamente";
                    break;
                case EntityState.Remover:
                    rplanilla.Delete(pla);
                    mensaje = pla.mensaje;
                    break;

            }

            return mensaje;
        }

        public List<NPlanilla> Getall()
        {
            DPlanilla dp = new DPlanilla();

            dp.Id_empresa = Id_empresa;
            dp.Id_periodo = Id_periodo;
            using (DataTable dt = rplanilla.GetData(dp))
            {
                list_planilla = new List<NPlanilla>();
                foreach (DataRow item in dt.Rows)
                {
                    list_planilla.Add(new NPlanilla()
                    {
                        Id_planilla = Convert.ToInt32(item[0]),
                        Id_periodo = Convert.ToInt32(item[1]),
                        Id_empresa = Convert.ToInt32(item[2]),
                        Mes = (item[3].ToString()),
                        Fecha_inicial = Convert.ToDateTime(item[4]),
                        Fecha_final = Convert.ToDateTime(item[5]),
                        Fecha_pago = Convert.ToDateTime(item[6]),
                        Dias_mes = Convert.ToInt32(item[7]),
                        Horas_mes = Convert.ToInt32(item[8]),
                        Remu_basica = Convert.ToDecimal(item[9]),
                        Asig_familiar = Convert.ToDecimal(item[10]),
                        Tope_horario_nocturno = Convert.ToInt32(item[11])
                    });
                }
                return list_planilla;
            }
        }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }
        public int GetCodigo()
        {
            return new KPlanilla().GetCodigo();
        }

    }
}
