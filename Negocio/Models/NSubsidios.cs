using Datos.Contract;
using Datos.Entities;
using Datos.Repositories;
using Negocio.ValueObjects;
using System;
using System.Collections.Generic;
using System.Data;

namespace Negocio.Models
{
    public class NSubsidios : IDisposable
    {        
        public int Id_subsidios { get; set; }
        public string Cod_subsidios { get; set; }
        public string Descripcion_subsidio { get; set; }
        public string Tipo_subsidio { get; set; }
        public string Descuento { get; set; }

        public EntityState state { get; set; }
        private ISubsidios rsubsidios;
        private List<NSubsidios> listasubsidios;
        public NSubsidios()
        {
            rsubsidios = new RSubsidios();
        }
       

        //public List<NSubsidios> Getall()
        //{
        //    DSubsidios ds = new DSubsidios();
        //    ds.Tipo_subsidio = Tipo_subsidio;
        //    using (DataTable dt = rsubsidios.GetData(ds))
        //    {
        //        listasubsidios = new List<NSubsidios>();
        //        foreach (DataRow item in dt.Rows)
        //        {
        //            listasubsidios.Add(new NSubsidios()
        //            {
        //                Id_subsidios = Convert.ToInt32(item[0]),
        //                Cod_subsidios = Convert.ToInt32(item[1]),
        //                Descripcion_subsidio = Convert.ToString(item[2]),
        //                Tipo_subsidio = Convert.ToString(item[3]),
        //                Descuento = Convert.ToString(item[4]),
        //            });

        //        }
        //        return listasubsidios;
        //    }
        //}

        //MOSTRAR SUBSIDIO EN COMBOBOX
        public IEnumerable<NSubsidios> ShowSubsidio()
        {
            DSubsidios ds = new DSubsidios();
            ds.Tipo_subsidio = Tipo_subsidio;
            if (listasubsidios == null)
                listasubsidios = new List<NSubsidios>();

            using (DataTable dt = rsubsidios.ShowSubsidio(ds))
            {
                foreach (DataRow item in dt.Rows)
                {
                    listasubsidios.Add(new NSubsidios()
                    {
                        Id_subsidios=Convert.ToInt32(item[0]),
                        Cod_subsidios=item[1]+ " - " + item[2] +" "+ item[3]
                    });
                }               
            }
            return listasubsidios;
        }


        public void Dispose()
        {
            //throw new NotImplementedException();
        }
    }
}
