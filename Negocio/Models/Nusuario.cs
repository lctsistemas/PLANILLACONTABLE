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
    public class Nusuario : IDisposable
    {
        private List<Nusuario> list_usu;
        String mesage;

        private Int32 idusuario;
        private String codigo_usu;
        private String nombre_refe;
        private String password;
        private String genero;
        private Int32 idrol;

        private IUsuario usu_repository;
        public int Idusuario { get { return idusuario; } set { idusuario = value; } }
        public string Codigo_usu { get { return codigo_usu; } set { codigo_usu = value; } }
        public string Nombre_refe { get { return nombre_refe; } set { nombre_refe = value; } }
        public string Password { get { return password; } set { password = value; } }       
        public int Idrol { get { return idrol; } set { idrol = value; } }       
        public String name_rol { get; set; }
        public string Genero { get { return genero; } set { genero = value; } }
        public EntityState state { get; set; }

        public Nusuario()
        {
            usu_repository = new Rusuario();
        }
        //METODO GUARDAR CAMBIOS
        public string SaveChanges()
        {
            mesage = "";
            try
            {
                Dusuario du = new Dusuario();
                du.Idusuario = Idusuario;
                du.Codigo_usu = Codigo_usu;
                du.Nombre_refe = Nombre_refe;
                du.Password = Password;
                du.Genero = Genero;
                du.Idrol = Idrol;

                switch (state)
                {
                    case EntityState.Guardar:
                        usu_repository.Add(du);
                        mesage = du.mesage;
                        break;
                    case EntityState.Modificar:
                        usu_repository.Edit(du);
                        mesage = "¡Editado Correctamente!";
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
        public List<Nusuario> Getall()
        {
            using (DataTable dt = usu_repository.GetData(null))
            {
                list_usu = new List<Nusuario>();
                foreach (DataRow item in dt.Rows)
                {
                    list_usu.Add(new Nusuario()
                    {
                        idusuario = Convert.ToInt32(item[0]),
                        codigo_usu = item[1].ToString(),
                        nombre_refe = item[2].ToString(),
                        password = item[3].ToString(),
                        idrol = Convert.ToInt32(item[4]),
                        name_rol = item[5].ToString(),
                        genero = item[6].ToString()
                    });
                }              
            }
            return list_usu;
        }



        /*public static bool Contains(this string target, string value, StringComparison comparison)
        {
            return target.IndexOf(value, comparison) >= 0;
        }*/

        //METODO PARA FILTRAR
        public IEnumerable<Nusuario> Search(string filter)
        {
            //return list_usu.FindAll(e => e.codigo_usu.Contains(filter) || e.nombre_refe.Contains(filter));
            //return list_usu.FindAll(e => e.nombre_refe.Contains(filter, StringComparer.CurrentCultureIgnoreCase);
            //PARA FILTRAR IGNORANDO LAS MAYUSCULAS.
            return list_usu.FindAll(e => e.nombre_refe.IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0 || e.codigo_usu.IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0);
            //return list_usu.FindAll(e => e.Contains(filter, StringComparison.OrdinalIgnoreCase));
        }
       

        public void Dispose()
        {
            //throw new NotImplementedException();
        }
    }
}
