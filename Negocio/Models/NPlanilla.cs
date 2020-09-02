using Datos.Contract;
using Datos.Entities;
using Datos.Repositories;
using Negocio.ValueObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Models
{
    public class NPlanilla:IDisposable
    {
        String mensaje;
        public int Id_planilla
        {
            get; set;
            
        }

        public int Id_tipo_planilla
        {
            get; set;
        }

        public int Id_periodo
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
            pla.Id_periodo = Id_periodo;
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

                
            }

            return mensaje;
        }
        /*
        public List<NPlanilla> Getall()
        {
            using (DataTable dt = rplanilla.GetData(null))
            {
                list_planilla = new List<NPlanilla>();
                foreach (DataRow item in dt.Rows)
                {
                    list_planilla.Add(new NPlanilla()
                    {
                        Id_periodo = Convert.ToInt32(item[0]),
                        Descripcion = item[1].ToString(),
                        Descripcion_corta = item[2].ToString(),
                        Tipo_regimen = item[3].ToString()
                    });
                }
                return list_regimen;
            }
        }*/

        public void Dispose()
        {
            //throw new NotImplementedException();
        }
    }
}
