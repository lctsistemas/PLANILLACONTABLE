﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Datos.Contract;
using Datos.Entities;
using Datos.Repositories;
using Negocio.ValueObjects;


namespace Negocio.Models
{
    public class Ntipocontrato : IDisposable
    {
        String mensaje;

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

        public String GuardarCambios()
        {
            Dtipocontrato dtipocontrato = new Dtipocontrato();

            dtipocontrato.Id_tcontrato = id_tcontrato;
            dtipocontrato.Tipo_contrato = tiem_contrato;

            switch (state){
                case EntityState.Guardar:

                    tcontrato_repository.Add(dtipocontrato);
                    mensaje = dtipocontrato.Mensaje;

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
            return new 
        }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }
    }
}
