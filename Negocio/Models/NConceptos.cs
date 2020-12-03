using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Negocio.ValueObjects;
using Datos.Repositories;
using Datos.Entities;
using System.Data;

namespace Negocio.Models
{
    public class NConceptos:IDisposable
    {
        public int Id_conceptos { get; set; }
        public int Id_mes { get; set; }
        public int Id_planilla { get; set; }
        public bool HextraDiurna { get; set; }
        public bool HextraNocturna { get; set; }
        public bool FeriadoDomi { get; set; }
        public bool BoniNocturna { get; set; }
        public bool PrimeroMayo { get; set; }
        public bool Tarda { get; set; }
        public bool Subsi { get; set; }
        public bool Thoraex { get; set; }
        public bool Otroreinte { get; set; }
        public bool Prest_aliment { get; set; }
        public bool Gratif { get; set; }
        public bool Vaca { get; set; }
        public bool Truncas { get; set; }
        public bool Reinte_gratiboni { get; set; }
        public bool Essa_vida { get; set; }
        public bool Adela { get; set; }
        public bool Presta { get; set; }
        public bool Rentquinta { get; set; }
        public bool Reten_judici { get; set; }
        public bool Otrodescu { get; set; }
        public bool Recarg_consu { get; set; }

        public EntityState State { get; set; }
        private readonly RConceptos rconcep;
        List<NConceptos> lista_concepto;

        public NConceptos()
        {
            rconcep = new RConceptos();
        }

        //METODO PARA ADD, UPDATE
        public string SaveChanges()
        {
           
            string message;
            using (DConceptos dcon = new DConceptos())
            {
                try
                {

                    dcon.Id_conceptos = Id_conceptos;
                    dcon.Id_mes = Id_mes;
                    dcon.Id_planilla = Id_planilla;
                    dcon.HextraDiurna = HextraDiurna;
                    dcon.HextraNocturna = HextraNocturna;
                    dcon.FeriadoDomi = FeriadoDomi;
                    dcon.BoniNocturna = BoniNocturna;
                    dcon.PrimeroMayo = PrimeroMayo;
                    dcon.Tarda = Tarda;
                    dcon.Subsi = Subsi;
                    dcon.Thoraex = Thoraex;
                    dcon.Otroreinte = Otroreinte;
                    dcon.Prest_aliment = Prest_aliment;
                    dcon.Gratif = Gratif;
                    dcon.Vaca = Vaca;
                    dcon.Truncas = Truncas;
                    dcon.Reinte_gratiboni = Reinte_gratiboni;
                    dcon.Essa_vida = Essa_vida;
                    dcon.Adela = Adela;
                    dcon.Presta = Presta;
                    dcon.Rentquinta = Rentquinta;
                    dcon.Reten_judici = Reten_judici;
                    dcon.Otrodescu = Otrodescu;
                    dcon.Recarg_consu = Recarg_consu;

                    switch (State)
                    {
                        case EntityState.Guardar:
                            rconcep.SaveAddUpdate(dcon);
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


        //METODO MOSTRAR
        public List<NConceptos> Getall()
        {
            DConceptos d = new DConceptos();
            d.Id_mes = Id_mes;
            d.Id_planilla = Id_planilla;
            using (DataTable dt = rconcep.GetData(d))
            {
                lista_concepto = new List<NConceptos>();
                foreach (DataRow item in dt.Rows)
                {
                    lista_concepto.Add(new NConceptos()
                    {
                        HextraDiurna = Convert.ToBoolean(item[1])
                        
                    });

                }
            }
            return lista_concepto;
        }


        public void Dispose()
        {
            //throw new NotImplementedException();
        }

    }
}
