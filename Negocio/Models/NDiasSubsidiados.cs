using Datos.Contract;
using Datos.Entities;
using Datos.Repositories;
using Negocio.ValueObjects;
using System;
using System.Collections.Generic;

using System.Data;

namespace Negocio.Models
{
    public class NDiasSubsidiados : IDisposable
    {
        String mensaje;
        public int Id_det_subsidios { get; set; }
        public int Id_subsidios { get; set; }
        public string Codigo_subsidio { get; set; }
        public string Descrip_corta { get; set; }
        public int Id_empleado { get; set; }       
        public int Id_mes { get; set; }
        public int Id_periodo { get; set; }
        public int Dias { get; set; }
        public string ValTipSubsidio {private get; set; }

        public EntityState state { get; set; }
        private IDiasSubsidiados rdiassubsidiados;
        private List<NDiasSubsidiados> ListDiasub;
       
        public NDiasSubsidiados()
        {
            rdiassubsidiados = new RDiasSubsidiados();
        }       

        //METODO SAVECHANGES
        public String GuardarCambios()
        {
            mensaje = "";

            try
            {
                DDiasSubsidiados ds = null;
                if (ds == null)
                    ds = new DDiasSubsidiados();

                ds.Id_det_subsidios = Id_det_subsidios;
                ds.Id_subsidios = Id_subsidios;
                ds.Id_empleado = Id_empleado;
                ds.Id_mes = Id_mes;
                ds.Id_periodo = Id_periodo;
                ds.Dias = Dias;

                switch (state)
                {
                    case EntityState.Guardar:
                        rdiassubsidiados.Add(ds);
                        mensaje = "¡Registrado!";
                        break;
                    case EntityState.Modificar:
                        rdiassubsidiados.Edit(ds);
                        mensaje = "¡Modificado!";
                        break;
                    case EntityState.Remover:
                        rdiassubsidiados.Delete(ds);
                        mensaje = "¡Eliminado!";
                        break;
                    default:
                        mensaje = "Error in Transaction";
                        break;
                }
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }

            return mensaje;
        }

        //MOSTRAR DET SUBSIDIO
        public IEnumerable<NDiasSubsidiados> GetData()
        {
            DDiasSubsidiados ds = null;
            if (ds == null)
                ds = new DDiasSubsidiados();
            ds.Id_mes = Id_mes;
            ds.Id_periodo = Id_periodo;
            ds.Id_empleado = Id_empleado;
            ds.ValTipSubsidio = ValTipSubsidio;
            
            if (ListDiasub == null)
                ListDiasub = new List<NDiasSubsidiados>();

            using (DataTable dt = rdiassubsidiados.GetData(ds))
            {
                foreach (DataRow item in dt.Rows)
                {
                    ListDiasub.Add(new NDiasSubsidiados()
                    {
                       Id_det_subsidios=Convert.ToInt32(item[0]),
                       Codigo_subsidio = item[1].ToString(),
                       Descrip_corta =item[2].ToString(),
                       Dias=Convert.ToInt32(item[3])

                    });
                }
            }
            return ListDiasub;
        }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }
    }
}
