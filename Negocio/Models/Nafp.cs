using Datos.Entities;
using Datos.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
namespace Negocio.Models
{
    public class Nafp : IDisposable
    {
        List<Nafp> list_comisionAfp;
        Dafp daf;
        public int Id_comision { get; set; }
        public int Codigo_regimen { get; set; }
        public string descripcion { get; set; }//nombre afp
        public decimal Comision { get; set; }
        public decimal Saldo { get; set; }
        public decimal Seguro { get; set; }
        public decimal Aporte { get; set; }
        public decimal Tope { get; set; }
        public int Idmes { get; set; }
        public string Mes { get; set; }
        public int Idperiodo { private get; set; }
        public List<Nafp> ListNafp { get; set; }
    
        public Nafp()
        {
            daf = new Dafp();
        }

        //METODO SAVE COMISION.
        public string SaveComision()
        {
            int i = 0;
            string message;

            if (daf.DlistAfp == null)
                daf.DlistAfp = new List<Dafp>();

            Rafp raf = new Rafp();
            foreach (Nafp item in ListNafp)
            {
                daf.DlistAfp.Add(new Dafp()
                {
                    Codigo_regimen=item.Codigo_regimen,
                    Comision=item.Comision,
                    Saldo=item.Saldo,
                    Seguro=item.Seguro,
                    Aporte=item.Aporte,
                    Tope=item.Tope,
                    Idmes=item.Idmes,
                    Idperiodo=item.Idperiodo,
                });
            }
            i = raf.SaveComision(daf);
            daf.DlistAfp.Clear();

            if (i > 0)
                message = "Ok";
            else
                message = "Error Al Insertar";

            return message;
        }

        //EDIT COMISION
        public string EditComision()
        {
            int i = 0;
            string message;

            if (daf.DlistAfp == null)
                daf.DlistAfp = new List<Dafp>();

            Rafp raf = new Rafp();
            foreach (Nafp item in ListNafp)
            {
                daf.DlistAfp.Add(new Dafp()
                {                    
                    Comision = item.Comision,
                    Saldo = item.Saldo,
                    Seguro = item.Seguro,
                    Aporte = item.Aporte,
                    Tope = item.Tope,
                    Id_comision=item.Id_comision
                });
            }
            i = raf.EditComision(daf);
            daf.DlistAfp.Clear();

            if (i > 0)
                message = "Ok Edit";
            else
                message = "Error Al Edit";

            return message;
        }

        //MOSTRAR MES PARA AFP
        public IEnumerable<Nafp> Mostrar_mes()
        {
            List<Nafp> list_rol = null;
            using (Rafp r = new Rafp())
            {
                using (DataTable dt = r.Mostrar_mes())
                {
                    list_rol = new List<Nafp>();
                    foreach (DataRow item in dt.Rows)
                    {
                        list_rol.Add(new Nafp()
                        {
                            Idmes = Convert.ToInt32(item[0]),
                            Mes = item[1].ToString()
                        });
                    }
                }
            }
            return list_rol;
        }        


        // MOSTRAR COMISION AFP
        public IEnumerable<Nafp> Show_comisionafp()
        {
            list_comisionAfp = new List<Nafp>();
            Dafp daf = new Dafp();
            daf.Idmes = Idmes;
            daf.Idperiodo = Idperiodo;

            using (DataTable dt = new Rafp().Show_comisionafp(daf))
            {
                foreach (DataRow item in dt.Rows)
                {
                    list_comisionAfp.Add(new Nafp()
                    {
                        Codigo_regimen = Convert.ToInt32(item[0]),
                        descripcion = item[1].ToString(),
                        Id_comision = Convert.ToInt32(item[2]),
                        Comision = Convert.ToDecimal(item[3]),
                        Saldo = Convert.ToDecimal(item[4]),
                        Seguro = Convert.ToDecimal(item[5]),
                        Aporte = Convert.ToDecimal(item[6]),
                        Tope = Convert.ToDecimal(item[7])
                        //Idmes = Convert.ToInt32(item[]),
                        //Idperiodo=Convert.ToInt32(item[])
                    });
                }
            }
            return list_comisionAfp;
        }
        

        //FILTRAR DATOS POR MES Y PERIODO
        public IEnumerable<Nusuario> Search(int idmes)
        {
            //filtrar lista con datos numericos, averiguar.
            // return list_comisionAfp.FindAll(e => e.Idmes=);
            return null;
        }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }
    }
}
