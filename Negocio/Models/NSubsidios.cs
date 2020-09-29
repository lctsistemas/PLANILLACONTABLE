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

        private List<NSubsidios> listacargo;
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

                listacargo = new List<NSubsidios>();

                foreach (DataRow item in dt.Rows)
                {
                    //listacargo.Add(new Ncargo()
                    //{
                    //    idcargo = Convert.ToInt32(item[0]),//IDCARGO
                    //    nombre_cargo = Convert.ToString(item[1]),//NOMBRE CARGO
                    //    descripcion = Convert.ToString(item[2])//DESCRIPCION
                    //});

                }
                return listacargo;
            }
        }
    }
}
