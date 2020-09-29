using Datos.Contract;
using Datos.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Models
{
    public class NSubsidios:IDisposable
    {
        private IRepository rsubsidios;

        private List<NSubsidios> listasubsidios;

        public int Id_subsidios { get; set; }
        public int Cod_subsidios { get ; set ; }
        public string Descripcion_subsidio { get ; set ; }
        public string Tipo_subsidio { get ; set ; }
        public string Descuento { get ; set ; }

        public NSubsidios()
        {
            rsubsidios = new RSubsidios();
        }


        public void Dispose()
        {
            //throw new NotImplementedException();
        }

        public List<NSubsidios> Getall()
        {
            using (var dt = rsubsidios.GetData(null))
            {

                listasubsidios = new List<NSubsidios>();

                foreach (DataRow item in dt.Rows)
                {
                    listasubsidios.Add(new NSubsidios()
                    {
                        Id_subsidios = Convert.ToInt32(item[0]),
                        Cod_subsidios = Convert.ToInt32(item[1]),
                        Descripcion_subsidio = Convert.ToString(item[2]),
                        Tipo_subsidio = Convert.ToString(item[3]),
                        Descuento = Convert.ToString(item[4]),
                    });

                }
                return listasubsidios;
            }
        }
    }
}
