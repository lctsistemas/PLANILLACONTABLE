using Datos.Contract;
using Datos.Entities;
using Datos.KeyAutomatic;
using Datos.Repositories;
using Negocio.ValueObjects;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Security.Cryptography;
using System.ComponentModel.DataAnnotations;

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
        private Int32 idrol;
        

        private IUsuario usu_repository;

        public int Idusuario { get { return idusuario; }  set { idusuario = value; } }             

        [Required(ErrorMessage = "El campo Codigo Acceso es obligatorio.")]
        [StringLength(maximumLength:10,MinimumLength=4, ErrorMessage = "Campo Codigo Acceso debe ser 10 digitos maximo y 4 minimo.")]
        public string Codigo_usu { get { return codigo_usu; } set { codigo_usu = value; } }

        [Required(ErrorMessage = "El campo Nombre Usuario es obligatorio.")]
        [RegularExpression("^[a-zA-Z ]+$",ErrorMessage = "El campo Nombre Usuario se permite solo letras.")]
        public string Nombre_refe { get { return nombre_refe; } set { nombre_refe = value; } }

        [Required(ErrorMessage = "El campo Contraseña es obligatorio.")]
        public string Password { get { return password; } set { password = value; } }

        [Required(ErrorMessage = "Seleccione Rol para el Usuario obligatorio.")]
        public int Idrol { get { return idrol; } set { idrol = value; } }

      
        public String name_rol { get; set; }        
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
            using (var dt = usu_repository.GetData(null))
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
                        name_rol = item[5].ToString()
                    });
                }
                return list_usu;
            }
        }

        //public static bool Contains(this string target, string value, StringComparison comparison)
        //{
        //    return target.IndexOf(value, comparison) >= 0;
        //}

        //METODO PARA FILTRAR
        public IEnumerable<Nusuario> Search(string filter)
        {
         //return list_usu.FindAll(e => e.codigo_usu.Contains(filter) || e.nombre_refe.Contains(filter));
          //return list_usu.FindAll(e => e.nombre_refe.Contains(filter, StringComparer.CurrentCultureIgnoreCase);
          //PARA FILTRAR IGNORANDO LAS MAYUSCULAS.
          return  list_usu.FindAll(e => e.nombre_refe.IndexOf(filter, StringComparison.OrdinalIgnoreCase) >=0  || e.codigo_usu.IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0);
           // return list_usu.FindAll(e => e.Contains(filter, StringComparison.OrdinalIgnoreCase));
        }



        //GENERAR CODIGO USUARIO
        public int Getcodigo()
        {
            return new Kusuario().Getcodigo();
        }


        
        public void Dispose()
        {
            //throw new NotImplementedException();
        }
    }
}
