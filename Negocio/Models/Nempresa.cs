using Datos.Contract;
using Datos.Entities;
using Datos.Repositories;
using Negocio.ValueObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.Remoting.Messaging;

namespace Negocio.Models
{
    public class Nempresa : IDisposable
    {
        String mensaje;
        List<Nempresa> list_emp;
        public int idempresa_maestra { get; set; }
        public String estado { get; set; }
        public Int32 eidusuario { get; set; }
        public Int32 eidemp_maestra { get; set; }//campo de tabla empresa
        public Int32 eidempresa { get; set; }
        public String ecodigo_empresa { get; set; }
        public String razon_social { get; set; }
        public String localidad { get; set; }
        public String direccion { get; set; }
        public String domicilio { get; set; }
        public String ruc { get; set; }
        public String regimen { get; set; }
        public String usuario { get; set; }
        public String search { get; set; }//para buscar los datos       


        public EntityState state { private get; set; }
        private IEmpresa_maestra empre_reposi;

        public Nempresa()
        {
            empre_reposi = new Rempresa();
        }

        //MEDOTO GUARDAR CAMBIOS
        public string SaveChanges()
        {
            mensaje = "";
            try
            {
                DempresaMaestra de = new DempresaMaestra();

                de.Razon_social = razon_social;
                de.Direccion = direccion;
                de.Domicilio = domicilio;
                de.Ruc = ruc;
                de.Regimen = regimen;
                de.Localidad = localidad;

                de.Ecodigo_empresa = ecodigo_empresa;
                de.Eidusuario = eidusuario;
                de.Eidemp_maestra = eidemp_maestra;

                switch (state)
                {
                    case EntityState.Guardar:
                        empre_reposi.Add(de);
                        mensaje = de.mesages;
                        break;
                    case EntityState.Modificar:
                        empre_reposi.Edit(de);
                        mensaje = "Successfully Edited!";
                        break;
                    case EntityState.Remover:
                        empre_reposi.Delete(de);
                        mensaje = de.mesages;
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

        //METODO SHOW EMPRESA
        public List<Nempresa> Getall()
        {
            DempresaMaestra dem = new DempresaMaestra();
            dem.search = search;
            using (DataTable dt = empre_reposi.GetData(dem))
            {
                list_emp = new List<Nempresa>();
                foreach (DataRow item in dt.Rows)
                {
                    list_emp.Add(new Nempresa()
                    {
                        idempresa_maestra = Convert.ToInt32(item[0]),//idempresa maestra
                        estado = item[1].ToString(),//estado
                        eidusuario = Convert.ToInt32(item[2]),//id usuario
                        eidemp_maestra = Convert.ToInt32(item[3]),//id empresa maestra
                        eidempresa = Convert.ToInt32(item[4]),
                        ecodigo_empresa = item[5].ToString(),
                        razon_social = item[6].ToString(),
                        localidad = item[7].ToString(),
                        direccion = item[8].ToString(),
                        domicilio = item[9].ToString(),
                        ruc = item[10].ToString(),
                        regimen = item[11].ToString(),
                        usuario = item[12].ToString()
                    });
                }
                return list_emp;
            }
        }

        public void Dispose()
        {
            // throw new NotImplementedException();
        }
    }
}
