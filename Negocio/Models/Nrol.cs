using Datos.Contract;
using Datos.Entities;
using Datos.Repositories;
using Negocio.ValueObjects;
using System;
using System.Collections.Generic;
using System.Data;

namespace Negocio.Models
{
    public class Nrol : IDisposable
    {
        private List<Nrol> list_rol;
        private String mesage;
        public Int32 idrol { get; set; }
        public String nombre_rol { get; set; }

        public EntityState state;
        private IRol rol_repository;

        public Nrol()
        {
            rol_repository = new Rrol();
        }

        //METODO SAVE CHANGES
        public String SaveChanges()
        {
            mesage = "";
            try
            {
                Drol dr = new Drol();
                dr.Idrol = idrol;
                dr.Nombre_rol = nombre_rol;

                switch (state)
                {
                    case EntityState.Guardar:
                        rol_repository.Add(dr);
                        mesage = "Successfully Record!";
                        break;
                    case EntityState.Modificar:
                        rol_repository.Edit(dr);
                        mesage = "Successfully Edited!";
                        break;
                    case EntityState.Remover:
                        rol_repository.Delete(dr);
                        mesage = dr.mesage;
                        break;
                    default:
                        mesage = "Error in transaction";
                        break;
                }
            }

            catch (Exception ex)
            {
                mesage = ex.ToString();
            }
            finally { }
            return mesage;

        }

        //METODO SHOW
        public List<Nrol> Getall()
        {
            using (var dt = rol_repository.GetData(null))
            {
                list_rol = new List<Nrol>();
                foreach (DataRow item in dt.Rows)
                {
                    list_rol.Add(new Nrol()
                    {
                        idrol = Convert.ToInt32(item[0]),//id_rol
                        nombre_rol = item[1].ToString()//rol
                    });
                }
                return list_rol;
            }
        }
        //...

        public void Dispose()
        {
            //throw new NotImplementedException();
        }
    }
}
