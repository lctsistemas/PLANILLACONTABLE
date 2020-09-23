using Datos.Contract;
using Datos.Entities;
using Datos.KeyAutomatic;
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
    public class NRegimenSalud : IDisposable
    {
        String mensaje;

        private List<NRegimenSalud> list_reg_salud;

        private IRegimenSalud Rregsalud;

        public NRegimenSalud()
        {
            Rregsalud = new RRegimenSalud();
        }

        public int Id_regimen_salud { get ; set ; }
        public int Cod_regi_salud { get ; set ; }
        public string Regimen_salud { get ; set ; }

        public EntityState state { get; set; }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }

        public String GuardarCambios()
        {
            DRegimenSalud dregsalud = new DRegimenSalud();
            //pla.Id_tipo_planilla = Id_tipo_planilla;
            dregsalud.Id_regimen_salud = Id_regimen_salud;
            dregsalud.Cod_regi_salud = Cod_regi_salud;
            dregsalud.Regimen_salud = Regimen_salud;
          

            switch (state)
            {
                case EntityState.Guardar:
                    Rregsalud.Add(dregsalud);
                    mensaje = dregsalud.mensaje;
                    break;
                case EntityState.Modificar:
                    Rregsalud.Edit(dregsalud);
                    mensaje = "Editado correctamente";
                    break;
                case EntityState.Remover:
                    Rregsalud.Delete(dregsalud);
                    mensaje = dregsalud.mensaje;
                    break;

            }

            return mensaje;
        }

        public List<NRegimenSalud> Getall()
        {
            using (DataTable dt = Rregsalud.GetData(null))
            {
                list_reg_salud = new List<NRegimenSalud>();
                foreach (DataRow item in dt.Rows)
                {
                    list_reg_salud.Add(new NRegimenSalud()
                    {
                        Id_regimen_salud=Convert.ToInt32(item[0]),
                        Cod_regi_salud=Convert.ToInt32(item[1]),
                        Regimen_salud= item[2].ToString()                
                    });
                }
                return list_reg_salud;
            }
        }

        public int GetCodigo()
        {
            return new KregimenSalud().GetCodigo();
        }
    }
}
