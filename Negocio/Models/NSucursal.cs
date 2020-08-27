using Datos.Contract;
using Datos.Entities;
using Datos.Repositories;
using Negocio.ValueObjects;
using System;
using System.Collections.Generic;
using System.Data;

namespace Negocio
{
    public class NSucursal : IDisposable
    {

        String mensaje;
        List<NSucursal> list_sucursal;
        //public int idempresa_maestra { get; set; }
        public String estado { get; set; }
        public Int32 eidemp_maestra { get; set; }
        //public Int32 sidsucursal { get; set; }
        public Int32 sidempresa { get; set; }
        public String scodigo_sucursal { get; set; }
        public String razon_social { get; set; }
        public String localidad { get; set; }
        public String direccion { get; set; }
        public String domicilio { get; set; }
        public String ruc { get; set; }
        public String regimen { get; set; }
        public String usuario { get; set; }
        public String empresa { get; set; }
        public String search { get; set; }//para buscar los datos   

        public EntityState state { private get; set; }
        private IEmpresa_maestra sucursal_reposi;

        public NSucursal()
        {
            sucursal_reposi = new Rsucursal();
        }

        //METODO GUARDAR CAMBIOS
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

                de.Scodigo_sucursal = scodigo_sucursal;
                de.Eidemp_maestra = eidemp_maestra;
                de.Sid_empresa = sidempresa;

                switch (state)
                {
                    case EntityState.Guardar:
                        sucursal_reposi.Add(de);
                        mensaje = de.mesages;
                        break;
                    case EntityState.Modificar:
                        sucursal_reposi.Edit(de);
                        mensaje = "Successfully Edited!";
                        break;
                    case EntityState.Remover:
                        sucursal_reposi.Delete(de);
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

        //DATOS DE TABLA SUCURSAL
        public List<NSucursal> Getall()
        {       
            using (DataTable dt = sucursal_reposi.GetData(null))
            {
                list_sucursal = new List<NSucursal>();
                foreach (DataRow item in dt.Rows)
                {
                    list_sucursal.Add(new NSucursal
                    {
                        estado = item[0].ToString(),
                        eidemp_maestra = Convert.ToInt32(item[1]),
                        sidempresa = Convert.ToInt32(item[2]),
                        scodigo_sucursal = item[3].ToString(),
                        razon_social = item[4].ToString(),
                        localidad = item[5].ToString(),
                        direccion = item[6].ToString(),
                        domicilio = item[7].ToString(),
                        ruc = item[8].ToString(),
                        regimen = item[9].ToString(),
                        usuario = item[10].ToString(),
                        empresa = item[11].ToString()
                    });
                }
                return list_sucursal;
            }
        }

        //METODO PARA FILTRAR REGISTRO
        public IEnumerable<NSucursal> Search(string filter)
        {
            return list_sucursal.FindAll(e => e.razon_social.IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0);            
        }



        public void Dispose()
        {
           
        }
    }
}
