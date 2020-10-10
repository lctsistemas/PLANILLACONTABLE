using Datos.Contract;
using Datos.Entities;
using Datos.KeyAutomatic;
using Datos.Repositories;
using Negocio.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Models
{
    public class NDiasSubsidiados : IDisposable
    {
        String mensaje;
        public int Id_det_subsidios { get; set; }
        public int Id_subsidios { get; set; }
        public int Id_empleado { get; set ; }
        public int Id_periodo { get ; set ; }

        public int Id_mes { get; set; }
        public int Dias { get; set; }

        public EntityState state { get; set; }

        public IDiasSubsidiados rdiassubsidiados;

        private List<NDiasSubsidiados> list_diasSubsidiados;
        public NDiasSubsidiados()
        {
            rdiassubsidiados = new RDiasSubsidiados();
        }
        public void Dispose()
        {
            //throw new NotImplementedException();
        }

        public String GuardarCambios()
        {
            DDiasSubsidiados ds = new DDiasSubsidiados();
            ds.Id_det_subsidios = Id_det_subsidios;
            ds.Id_subsidios = Id_subsidios;
            ds.Id_empleado = Id_empleado;
            ds.Id_periodo = Id_periodo;
            ds.Id_mes = Id_mes;
            ds.Dias = Dias;


            switch (state)
            {
                case EntityState.Guardar:
                    rdiassubsidiados.Add(ds);
                    mensaje = ds.mensaje;
                    break;
                case EntityState.Modificar:
                    rdiassubsidiados.Edit(ds);
                    mensaje = "Editado correctamente";
                    break;
                case EntityState.Remover:
                    rdiassubsidiados.Delete(ds);
                    mensaje = ds.mensaje;
                    break;

            }

            return mensaje;
        }

        public void InsertarMassiveData(IEnumerable<NDiasSubsidiados> list)
        {
            List<DDiasSubsidiados> listadias = new List<DDiasSubsidiados>();
            using (RDiasSubsidiados rdias = new RDiasSubsidiados())
            {
                foreach (var item in list)
                {
                    listadias.Add(new DDiasSubsidiados()
                    {
                        Id_subsidios = item.Id_subsidios,
                        Id_empleado = item.Id_empleado,
                        Dias = item.Dias,
                        Id_mes = item.Id_mes,
                        Id_periodo = item.Id_periodo

                    });
                }
                rdias.InsertarMassiveData(listadias);
            }
        }
        public int GetCodigo()
        {
            return new KDiasSubsidiados().GetCodigo();
        }
    }
}
