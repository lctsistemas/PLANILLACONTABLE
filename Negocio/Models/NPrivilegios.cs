using Datos.Entities;
using Datos.Repositories;
using Negocio.ValueObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Models
{
    public class NPrivilegios : IDisposable
    {
        public int Id_privilegios { get ; set; }
        public int Id_rol { get; set; }
        public bool Btipopla { get ; set ; }
        public bool Btipocont { get ; set ; }
        public bool Bregimensalud { get ; set ; }
        public bool Bsubsinosub { get ; set; }
        public bool Bcargo { get; set ; }
        public bool Btipodoc { get; set ; }
        public bool Bbanco { get ; set ; }
        public bool Broles { get ; set ; }
        public bool Bregimenpen { get; set ; }
        public bool Bcomisiones { get ; set ; }
        public bool Bempleado { get ; set ; }
        public bool Bempresa { get ; set ; }
        public bool Bsucursal { get ; set; }
        public bool Busuario { get; set ; }
        public bool Bplanilla { get; set; }

        public EntityState State { get; set; }
        private readonly RPrivilegios rpriv;
        private readonly Rcargo rcargo;
        //List<NPrivilegios> listpriv;
        List<Nrol> listacargo;

        public NPrivilegios()
        {
            rpriv = new RPrivilegios();
            rcargo = new Rcargo();

        }

        public string SaveChanges()
        {

            string message;
            using (Dprivilegios dp = new Dprivilegios())
            {
                try
                {

                    dp.Id_privilegios = Id_privilegios;
                    dp.Id_rol = Id_rol;
                    dp.Btipopla = Btipopla;
                    dp.Btipocont = Btipocont;
                    dp.Bregimensalud = Bregimensalud;
                    dp.Bsubsinosub = Bsubsinosub;
                    dp.Bcargo = Bcargo;
                    dp.Btipodoc = Btipodoc;
                    dp.Bbanco = Bbanco;
                    dp.Broles = Broles;
                    dp.Bregimenpen = Bregimenpen;
                    dp.Bcomisiones = Bcomisiones;
                    dp.Bempleado = Bempleado;
                    dp.Bempresa = Bempresa;
                    dp.Bsucursal = Bsucursal;
                    dp.Busuario = Busuario;
                    dp.Bplanilla = Bplanilla;
                   

                    switch (State)
                    {
                        case EntityState.Guardar:
                            rpriv.SaveAddUpdate(dp);
                            message = "¡Guardado!";
                            break;

                        default:
                            message = "Error in Transaction!";
                            break;
                    }

                }
                catch (Exception ex)
                {
                    message = ex.Message;
                }
                finally { }
            }
            return message;
        }


        public IEnumerable<Nrol> Getall()
        {
            using (var dt = rcargo.GetData(null))
            {
                listacargo = new List<Nrol>();
                foreach (DataRow item in dt.Rows)
                {
                    listacargo.Add(new Nrol()
                    {
                        idrol = Convert.ToInt32(item[0]),
                        nombre_rol = Convert.ToString(item[1]),
                    });
                }
            }
            return listacargo;
        }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }
    }
}
