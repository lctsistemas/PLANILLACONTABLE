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
    public class NTipoPlanilla:IDisposable
    {
        String mensaje;
        public Int32 IdTipoPlanilla { get; set; }

        public String Tipo_Planilla { get; set; }
        public EntityState state { get; set; }
        private ITipoPlanilla Rtipoplanilla;
        private List<NTipoPlanilla> list_tipo_plan;

        public NTipoPlanilla()
        {
            Rtipoplanilla = new RTipoPlanilla();
        }

        public String GuardarCambios()
        {
            DTipoPlanilla tipoPlanilla = new DTipoPlanilla();
            tipoPlanilla.Idtipoplanilla = IdTipoPlanilla;
            tipoPlanilla.TipoPlanilla = Tipo_Planilla;

            switch (state)
            {
                case EntityState.Guardar:
                    Rtipoplanilla.Add(tipoPlanilla);
                    mensaje = tipoPlanilla.mensaje;
                    break;

                case EntityState.Modificar:
                    Rtipoplanilla.Edit(tipoPlanilla);
                    mensaje = "Successfully Edited!";
                    break;

                case EntityState.Remover:
                    Rtipoplanilla.Delete(tipoPlanilla);
                    mensaje = tipoPlanilla.mensaje;
                    break;
            }
            return mensaje;
        }

        public List<NTipoPlanilla> Getall()
        {
            using (DataTable dt = Rtipoplanilla.GetData(null))
            {
                list_tipo_plan = new List<NTipoPlanilla>();
                foreach (DataRow item in dt.Rows)
                {
                    list_tipo_plan.Add(new NTipoPlanilla()
                    {
                        IdTipoPlanilla = Convert.ToInt32(item[0]),
                        Tipo_Planilla = Convert.ToString(item[1])
                    });
                }
            }
            return list_tipo_plan;
        }
        public void Dispose()
        {
            //throw new NotImplementedException();
        }
    }
}
