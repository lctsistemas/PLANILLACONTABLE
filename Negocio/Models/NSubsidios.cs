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
        String mensaje;
        public int Id_subsidios { get; set; }
        public string Cod_subsidios { get; set; }
        public string Tipo_suspension { get; set; }

        public string Descripcion_corta { get; set; }

        public string Descripcion_subsidio { get; set; }
        public string Tipo_subsidio { get; set; }
        public bool Descuento { get; set; }

        public EntityState state { get; set; }
        private ISubsidios rsubsidios;
        private List<NSubsidios> listasubsidios;
        public NSubsidios()
        {
            rsubsidios = new RSubsidios();
        }

        public string SaveChanges()
        {
            mensaje = "";
            try
            {
                DSubsidios ds = new DSubsidios();

                ds.Cod_subsidios = Cod_subsidios;
                ds.Descripcion_subsidio = Descripcion_subsidio;
                ds.Tipo_subsidio = Tipo_subsidio;
                ds.Descuento = Descuento;
               

                switch (state)
                {
                    case EntityState.Guardar:
                        rsubsidios.Add(ds);
                        mensaje = ds.mensaje;
                        break;
                    case EntityState.Modificar:
                        rsubsidios.Edit(ds);
                        mensaje = "Successfully Edited!";
                        break;
                    case EntityState.Remover:
                        rsubsidios.Delete(ds);
                        mensaje = ds.mensaje;
                        break;

                    default:
                        mensaje = "Error in Transaction!";
                        break;
                }
            }
            catch (Exception ex)
            {
                mensaje = ex.ToString();
            }
            finally { }
            return mensaje;
        }


        public List<NSubsidios> Getall()
        {
            using (DataTable dt = rsubsidios.GetData(null))
            {
                listasubsidios = new List<NSubsidios>();
                foreach (DataRow item in dt.Rows)
                {
                    listasubsidios.Add(new NSubsidios()
                    {
                        Id_subsidios = Convert.ToInt32(item[0]),
                        Cod_subsidios = Convert.ToString(item[1]),
                        Tipo_suspension = Convert.ToString(item[2]),
                        Descripcion_corta = Convert.ToString(item[3]),
                        Descripcion_subsidio = Convert.ToString(item[4]),
                        Tipo_subsidio = Convert.ToString(item[5]),
                        Descuento = Convert.ToBoolean(item[6]),
                    });

                }
                return listasubsidios;
            }
        }

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
