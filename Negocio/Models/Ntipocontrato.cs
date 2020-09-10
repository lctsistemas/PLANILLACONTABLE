using Datos.Contract;
using Datos.Entities;
using Datos.KeyAutomatic;
using Datos.Repositories;
using Negocio.ValueObjects;
using System;
using System.Collections.Generic;
using System.Data;


namespace Negocio.Models
{
    public class Ntipocontrato : IDisposable
    {
        String mensaje;

        private List<Ntipocontrato> list_tcontrato;
        //private String mesage;
        public Int32 id_tcontrato { get; set; }
        public string tiem_contrato { get; set; }

        public EntityState state { get; set; }
        public ITipo_contrato tcontrato_repository;

        public Ntipocontrato()
        {
            tcontrato_repository = new Rtipocontrato();
        }

        public String GuardarCambios()
        {
            Dtipocontrato dtipocontrato = new Dtipocontrato();

            dtipocontrato.Id_tcontrato = id_tcontrato;
            dtipocontrato.Tipo_contrato = tiem_contrato;

            switch (state)
            {
                case EntityState.Guardar:

                    tcontrato_repository.Add(dtipocontrato);
                    mensaje = dtipocontrato.Mensaje;

                    break;

                case EntityState.Modificar:

                    tcontrato_repository.Edit(dtipocontrato);
                    mensaje = "Successfully Edited!";

                    break;
            }

            return mensaje;

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

        public int Getcodigo()
        {
            return new Ktipocontrato().GetCodigo();
        }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }
    }
}
