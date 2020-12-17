using Datos.Contract;
using Datos.Entities;
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
        public int Id_planilla { get; set; }
        /*public int Idtipo_planilla { get; set; }*/
        public int Id_periodo { get; set; }
        public int Id_mes { get; set; }
        public int Id_empresam { get; set; }        
        public string Nombre_mes { get; set; }
        public DateTime Fecha_inicial { get; set; }
        public DateTime Fecha_final { get; set; }
        public DateTime Fecha_pago { get; set; }
        public int Dias_mes { get; set; }
        public int Horas_mes { get; set; }
        public decimal Tope_horario_nocturno { get; set; }
        public EntityState state { get; set; }

        public IPlanilla rplanilla;
        private List<NPlanilla> list_planilla;

        public NPlanilla()
        {
            rplanilla = new RPlanilla();
        }

        public String GuardarCambios()
        {
            mensaje = "";
            try
            {
                DPlanilla pla = new DPlanilla();
                //pla.Id_tipo_planilla = Id_tipo_planilla;
                pla.Id_planilla = Id_planilla;
                pla.Id_periodo = Id_periodo;
                pla.Id_empresam = Id_empresam;
                pla.Id_mes = Id_mes;
                pla.Fecha_inicial = Fecha_inicial;
                pla.Fecha_final = Fecha_final;
                pla.Fecha_pago = Fecha_pago;
                pla.Dias_mes = Dias_mes;
                pla.Horas_mes = Horas_mes;
                pla.Tope_horario_nocturno = Tope_horario_nocturno;

                switch (state)
                {
                    case EntityState.Guardar:
                        rplanilla.Add(pla);
                        mensaje = pla.mensaje;
                        break;
                    case EntityState.Modificar:
                        rplanilla.Edit(pla);
                        mensaje = "¡Modificado!";
                        break;
                    case EntityState.Remover:
                        rplanilla.Delete(pla);
                        mensaje = pla.mensaje;
                        break;
                    default:
                        mensaje = "Error";
                        break;

                }
            }
            catch (Exception ex)
            {
                //System.Windows.Forms.MessageBox.Show(ex.Message);
                mensaje = ex.ToString();
            }

            return mensaje;
        }


        //VALIDACION SI EXISTE EL CODIGO.
        public bool Existe(int id)
        {
            //System.Windows.Forms.MessageBox.Show("canti "+ list_planilla.Count);
            foreach (NPlanilla item in list_planilla)
            {
                if (item.Id_mes == id)
                {
                    return true;
                }
            }
            return false;
        }

        public IEnumerable<NPlanilla> Getall()
        {
            DPlanilla dp = new DPlanilla();
            dp.Id_empresam = Id_empresam;
            dp.Id_periodo = Id_periodo;
            using (DataTable dt = rplanilla.GetData(dp))
            {
                list_planilla = new List<NPlanilla>();
                foreach (DataRow item in dt.Rows)
                {
                    list_planilla.Add(new NPlanilla() // modificar.
                    {
                        Id_planilla = Convert.ToInt32(item[0]),
                        Id_periodo = Convert.ToInt32(item[1]),                       
                        Id_mes = Convert.ToInt32(item[2]),
                        Id_empresam=Convert.ToInt32(item[3]),
                        Nombre_mes = item[4].ToString(),
                        Fecha_inicial = Convert.ToDateTime(item[5]),
                        Fecha_final = Convert.ToDateTime(item[6]),
                        Fecha_pago = Convert.ToDateTime(item[7]),
                        Dias_mes = Convert.ToInt32(item[8]),
                        Horas_mes = Convert.ToInt32(item[9]),                       
                        Tope_horario_nocturno = Convert.ToInt32(item[10])
                    });
                }
                
            }
            return list_planilla;
        }



        public void Dispose()
        {
            //throw new NotImplementedException();
        }
       

    }
}
