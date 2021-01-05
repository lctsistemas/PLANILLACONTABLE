using Datos.Contract;
using Datos.Entities;
using Datos.Repositories;
using Negocio.ValueObjects;
using System;
using System.Collections.Generic;
using System.Data;

namespace Negocio.Models
{
    public class Ncargo : IDisposable
    {
        private List<Ncargo> listacargo;
        public int idcargo { get; set; }        
        public string nombre_cargo { get; set; }      
        public string descripcion { get; set; }

        public EntityState state { private get; set; }//esto me muestra en datagridview->then ponemos private
        private IRepository cargo_repository;

        //PODEMOS VALIDAR DATOS CON: System.ComponentModel.DataAnnotations;
        public Ncargo()
        {
            cargo_repository = new Rcargo();
        }
        
        //METODO ADD,EDIT, DELETE
        public string SaveChanges()
        {
            string message;
            try
            {
                Dcargo dc = new Dcargo();
                dc.Idcargo = idcargo;
                dc.Nombre_cargo = nombre_cargo;
                dc.Descripcion = descripcion;

                switch (state)
                {
                    case EntityState.Guardar:
                        cargo_repository.Add(dc);
                        message = "¡Registrado!";
                        break;
                    case EntityState.Modificar:
                        cargo_repository.Edit(dc);
                        message = "¡Modificado!";
                        break;
                    case EntityState.Remover:
                        cargo_repository.Delete(dc);
                        message = dc.Message;
                        break;
                    default:
                        message = "Error in Transaction!";
                        break;
                }

            }
            catch (Exception ex)
            {
                message = ex.ToString();
            }
            finally { }

            return message;

        }
        //METODO MOSTRAR

        public IEnumerable<Ncargo> Getall()
        {
            using (var dt = cargo_repository.GetData(null))
            {
                listacargo = new List<Ncargo>();
                foreach (DataRow item in dt.Rows)
                {
                    listacargo.Add(new Ncargo()
                    {
                        idcargo = Convert.ToInt32(item[0]),//IDCARGO
                        nombre_cargo = Convert.ToString(item[1]),//NOMBRE CARGO
                        descripcion = Convert.ToString(item[2])//DESCRIPCION
                    });
                }
            }
            return listacargo;
        }

        public IEnumerable<Ncargo> Search(string filter)
        {

            return listacargo.FindAll(e => e.nombre_cargo.IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0);
        }



        public void Dispose()
        {
            //throw new NotImplementedException();
        }

    }
}
