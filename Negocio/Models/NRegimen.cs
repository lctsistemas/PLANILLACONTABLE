﻿using Datos.Contract;
using Datos.Entities;
using Datos.KeyAutomatic;
using Datos.Repositories;
using Negocio.ValueObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Models
{
    public class NRegimen:IDisposable
    {
        String mensaje;

        public int Codigo_Regimen { get; set; }

        [Required(ErrorMessage = "El campo Descripcion corta es obligatorio.")]
        [RegularExpression("^[a-zA-Z ]+$", ErrorMessage = "El campo Descripcion corta solo permite letras.")]
        public String Descripcion_corta { get; set; }

        [Required(ErrorMessage = "El campo Descripcion es obligatorio.")]
        [RegularExpression("^[a-zA-Z ]+$", ErrorMessage = "El campo Descripcion solo permite letras.")]
        public String Descripcion { get; set; }

        [Required(ErrorMessage = "El campo Tipo de regimen es obligatorio.")]
        public String Tipo_regimen { get; set; }

        public EntityState state { get; set; }

        private IRegimen regimen;

        private List<NRegimen> list_regimen;

        public NRegimen()
        {
            regimen = new RRegimen();
        }

        public String GuardarCambios()
        {
            mensaje = "";
            try
            {
                DRegimen dr = new DRegimen();
                dr.Codigo_regimen = Codigo_Regimen;
                dr.Descripcion_corta = Descripcion_corta;
                dr.Descripcion = Descripcion;
                dr.Tipo_regimen = Tipo_regimen;

                switch (state)
                {
                    case EntityState.Guardar:
                        regimen.Add(dr);
                        mensaje = dr.mensaje;
                        break;
                }
            }
            catch(Exception ex)
            {
                mensaje = ex.ToString();
            }

            return mensaje;
        }

        public List<NRegimen> Getall()
        {
            using (var dt= regimen.GetData(null))
            {
                list_regimen = new List<NRegimen>();
                foreach (DataRow item in dt.Rows)
                {
                    list_regimen.Add(new NRegimen()
                    {
                        Descripcion = item[1].ToString(),
                        Descripcion_corta = item[2].ToString(),
                        Tipo_regimen = item[3].ToString()
                    });
                }
                return list_regimen;
            }
        }
        public void Dispose()
        {
           // throw new NotImplementedException();
        }

        public int Getcodigo()
        {
            return new KRegimen().Getcodigo(); 
        }
    }
}
