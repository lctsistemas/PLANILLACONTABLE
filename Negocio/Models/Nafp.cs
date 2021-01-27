using Datos.Entities;
using Datos.Repositories;
using System;
using System.Collections.Generic;
using System.Data;

using Negocio.ValueObjects;

namespace Negocio.Models
{
    public class Nafp : IDisposable
    {
        List<Nafp> list_comisionAfp;
        List<Nafp> list_comisionOnp;
        Dafp daf;
        Rafp raf;
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
        public EntityState State { get; set; }
    
        public Nafp()
        {
            daf = new Dafp();
            raf = new Rafp();
        }

        //METODO SAVE COMISION.
        public string SaveComision()
        {
            int i = 0;
            string message;

            if (daf.DlistAfp == null)
                daf.DlistAfp = new List<Dafp>();

//            Rafp raf = new Rafp();
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
                message = "¡Guardado!";
            else
                message = "Error Al Insertar";

            return message;
        }

        public string SaveOnp()
        {
            string resul;
            daf.Codigo_regimen = Codigo_regimen;
            daf.Id_comision = Id_comision;
            daf.Comision = Comision;
            daf.Idmes = Idmes;
            daf.Idperiodo = Idperiodo;

            switch (State)
            {
                case EntityState.Guardar:
                    raf.SaveOnp(daf);
                    resul = "ok";
                    break;

                case EntityState.Modificar:
                    raf.EditOnp(daf);
                    resul = "ok";
                    break;
                default:
                    resul = "Error en onp";
                    break;
            }
            return resul;
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
                message = "¡Modificado!";
            else
                message = "Error Al Editar";

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
        public IEnumerable<Nafp> Show_comisionafp(string tipo_regimen)
        {
            
            Dafp daf = new Dafp();
            daf.Idmes = Idmes;
            daf.Idperiodo = Idperiodo;

            using (DataTable dt = new Rafp().Show_comisionafp(daf, tipo_regimen))
            {
                list_comisionAfp = new List<Nafp>();
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

        public IEnumerable<Nafp> Show_comisionOnp(string tipo_regimen)
        {
            list_comisionOnp = new List<Nafp>();
            Dafp daf = new Dafp();
            daf.Idmes = Idmes;
            daf.Idperiodo = Idperiodo;

            using (DataTable dt = new Rafp().Show_comisionafp(daf, tipo_regimen))
            {
                foreach (DataRow item in dt.Rows)
                {
                    list_comisionOnp.Add(new Nafp()
                    {
                        Codigo_regimen = Convert.ToInt32(item[0]),
                        descripcion = item[1].ToString(),
                        Id_comision = Convert.ToInt32(item[2]),
                        Comision = Convert.ToDecimal(item[3])                   
                    });
                }
            }
            return list_comisionOnp;
        }


        //FILTRAR DATOS POR MES Y PERIODO
        public IEnumerable<Nusuario> Search(int idmes)
        {
            //filtrar lista con datos numericos, averiguar.
             //return list_comisionAfp.FindAll(e => e.Idmes=);
            return null;
        }

        public void Dispose()
        {
            //throw new NotImplementedException();
           


        }
    }
}
