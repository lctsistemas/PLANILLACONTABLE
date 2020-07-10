using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Negocio.ValueObjects;
using Datos.Contract;
using Datos.Entities;
using Datos.Repositories;
using System.Data;

namespace Negocio.Models
{
    public class Ndocumento:IDisposable
    {
        private string mensaje;
        public int iddocumento { get; set; }
        public string nombre_documento { get; set; }
        public string descripcion { get; set; }
        public EntityState state { private get; set; }
        private IDocumento docu_repsository;

        private List<Ndocumento> listadocu;

        public Ndocumento() {
            docu_repsository = new Rdocumento();
        }

        //MEDOTO GUARDAR CAMBIOS
        public string SaveChanges() {
            mensaje = "";
            try
            {
                DtipoDocumento rt = new DtipoDocumento();
                rt.Iddocumento = iddocumento;
                rt.Nombre_documento = nombre_documento;
                rt.Descripcion = descripcion;

                switch (state)
                {
                    case EntityState.Guardar:
                        docu_repsository.Add(rt);
                        mensaje = "Successfully Recod!";
                        break;

                    case EntityState.Modificar:
                        docu_repsository.Edit(rt);
                        mensaje = "Successfully Edited!";
                        break;
                    case EntityState.Remover:
                        docu_repsository.Delete(rt);
                        mensaje = rt.message;
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
            finally {}
            return mensaje;
        
        }
        //METODO MOSTRAR
        public List<Ndocumento> Getall() {
            DtipoDocumento rt = new DtipoDocumento();
            rt.Nombre_documento = nombre_documento;
            using (var dt=docu_repsository.GetData(rt))
            {
                listadocu = new List<Ndocumento>();
                foreach (DataRow item in dt.Rows)
                {
                    listadocu.Add(new Ndocumento()
                    {
                        iddocumento=Convert.ToInt32(item[0]),
                        nombre_documento=item[1].ToString(),
                        descripcion=item[2].ToString()

                    });
                }
                return listadocu;   
            }
        }
        //...

        public void Dispose()
        {
           
        }

       
    }
}
