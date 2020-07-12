using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Datos.Contract;
using Datos.Repositories;
using Negocio.ValueObjects;


namespace Negocio.Models
{
    public class Ntipocontrato : IDisposable
    {
        private List<Ntipocontrato> list_tcontrato;
        //private String mesage;
        public Int32 id_tcontrato { get; set; }
        public String tiem_contrato { get; set; }

        public EntityState state;
        private ITipo_contrato tcontrato_repository;

        public Ntipocontrato()
        {
            tcontrato_repository = new Rtipocontrato();
        }







        //MOSTRAR TIPO CONTRATO
        public List<Ntipocontrato> MostrarTcontrato()
        {
            using (DataTable dt = tcontrato_repository.GetData(null))
            {
                list_tcontrato = new List<Ntipocontrato>();
                foreach (DataRow item in dt.Rows)
                {
                    list_tcontrato.Add(new Ntipocontrato()
                    {
                        id_tcontrato = Convert.ToInt32(item[0]),
                        tiem_contrato = item[1].ToString()
                    });
                }
                return list_tcontrato;
            }
        }


        public void Dispose()
        {
            //throw new NotImplementedException();
        }
    }
}
