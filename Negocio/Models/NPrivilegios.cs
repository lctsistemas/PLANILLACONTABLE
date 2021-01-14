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
        
        List<NPrivilegios> listpriv;

        public NPrivilegios()
        {
            rpriv = new RPrivilegios();

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


        public List<NPrivilegios> Getall()
        {
            Dprivilegios dp = new Dprivilegios();
            dp.Id_rol=Id_rol;
            using (DataTable dt = rpriv.GetData(dp))
            {
                listpriv = new List<NPrivilegios>();
                foreach (DataRow item in dt.Rows)
                {
                    listpriv.Add(new NPrivilegios()
                    {
                        Id_privilegios = Convert.ToInt32(item[0]),
                        Btipopla=Convert.ToBoolean(item[1]),
                        Btipocont = Convert.ToBoolean(item[2]),
                        Bregimensalud = Convert.ToBoolean(item[3]),
                        Bsubsinosub = Convert.ToBoolean(item[4]),
                        Bcargo = Convert.ToBoolean(item[5]),
                        Btipodoc = Convert.ToBoolean(item[6]),
                        Bbanco = Convert.ToBoolean(item[7]),
                        Broles = Convert.ToBoolean(item[8]),
                        Bregimenpen = Convert.ToBoolean(item[9]),
                        Bcomisiones = Convert.ToBoolean(item[10]),
                        Bempleado = Convert.ToBoolean(item[11]),
                        Bempresa = Convert.ToBoolean(item[12]),
                        Bsucursal = Convert.ToBoolean(item[13]),
                        Busuario = Convert.ToBoolean(item[14]),
                        Bplanilla = Convert.ToBoolean(item[15])

                    });
                }
            }
            return listpriv;
        }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }
    }
}
