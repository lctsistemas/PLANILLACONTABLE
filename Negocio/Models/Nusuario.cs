using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Datos.Contract;
using Datos.Entities;
using Datos.Repositories;
using Datos.KeyAutomatic;
using Negocio.ValueObjects;
using System.Data;

namespace Negocio.Models
{
    public class Nusuario:IDisposable
    {
        private List<Nusuario> list_usu;
        String mesage;
        public Int32 idusuario { get; set; }
        public String codigo_usu { get; set; }
        public String nombre_refe { get; set; }
        public String password { get; set; }
        public Int32 idrol { get; set; }
        public String name_rol {  get; set; }
        public EntityState state { get; set;}
        private IUsuario usu_repository;

        public Nusuario() {
            usu_repository = new Rusuario();
        }
        //METODO GUARDAR CAMBIOS
        public string SaveChanges() {
            mesage = "";
            try
            {
                Dusuario du = new Dusuario();
                du.Idusuario = idusuario;
                du.Codigo_usu = codigo_usu;
                du.Nombre_refe = nombre_refe;
                du.Password = password;
                du.Idrol = idrol;

                switch (state)
                {
                    case EntityState.Guardar:
                        usu_repository.Add(du);
                        mesage = du.mesage;
                        break;
                    case EntityState.Modificar:
                        usu_repository.Edit(du);
                        mesage = "Successfully Edited!";
                        break;
                    case EntityState.Remover:
                        usu_repository.Delete(du);
                        mesage = du.mesage;
                        break;
                    default:
                        mesage = "Error in Transtaction";
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
        public List<Nusuario> Getall() {
            Dusuario du = new Dusuario();
            du.Nombre_refe = nombre_refe;
            using (var dt=usu_repository.GetData(du))
            {   
             list_usu=new List<Nusuario>();
             foreach (DataRow item in dt.Rows)
             {
                 list_usu.Add(new Nusuario()
                 {
                     idusuario=Convert.ToInt32(item[0]),
                     codigo_usu=item[1].ToString(),
                     nombre_refe=item[2].ToString(),
                     password=item[3].ToString(),
                     idrol=Convert.ToInt32(item[4]),
                     name_rol=item[5].ToString()
                 });
             }
             return list_usu;
            }
        }
        //GENERAR CODIGO USUARIO
        public int Getcodigo() {
            return new Kusuario().Getcodigo();
        } 


        public void Dispose()
        {
            //throw new NotImplementedException();
        }
    }
}
