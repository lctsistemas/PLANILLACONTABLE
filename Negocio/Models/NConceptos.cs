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
        public bool BoniNoctur { get; set; }
        public bool PrimeroMayo { get; set; }
        public bool Tarda { get; set; }
        public bool Subsidi { get; set; }
        public bool Thoraex { get; set; }
        public bool Otroreinte { get; set; }
        public bool Prest_aliment { get; set; }
        public bool Gratif { get; set; }
        public bool Vaca { get; set; }
        public bool Trunca { get; set; }
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
                    dcon.BoniNoctur = BoniNoctur;
                    dcon.PrimeroMayo = PrimeroMayo;
                    dcon.Tarda = Tarda;
                    dcon.Subsidi = Subsidi;
                    dcon.Thoraex = Thoraex;
                    dcon.Otroreinte = Otroreinte;
                    dcon.Prest_aliment = Prest_aliment;
                    dcon.Gratif = Gratif;
                    dcon.Vaca = Vaca;
                    dcon.Trunca = Trunca;
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
                        Id_conceptos=Convert.ToInt32(item[0]),
                        HextraDiurna = Convert.ToBoolean(item[1]),
                        HextraNocturna=Convert.ToBoolean(item[2]),
                        FeriadoDomi=Convert.ToBoolean(item[3]),
                        BoniNoctur=Convert.ToBoolean(item[4]),
                        PrimeroMayo=Convert.ToBoolean(item[5]),
                        Tarda=Convert.ToBoolean(item[6]),
                        Subsidi=Convert.ToBoolean(item[7]),
                        Thoraex=Convert.ToBoolean(item[8]),
                        Otroreinte=Convert.ToBoolean(item[9]),
                        Prest_aliment=Convert.ToBoolean(item[10]),
                        Gratif=Convert.ToBoolean(item[11]),
                        Vaca=Convert.ToBoolean(item[12]),
                        Trunca=Convert.ToBoolean(item[13]),
                        Reinte_gratiboni=Convert.ToBoolean(item[14]),
                        Essa_vida=Convert.ToBoolean(item[15]),
                        Adela=Convert.ToBoolean(item[16]),
                        Presta=Convert.ToBoolean(item[17]),
                        Rentquinta=Convert.ToBoolean(item[18]),
                        Reten_judici=Convert.ToBoolean(item[19]),
                        Otrodescu=Convert.ToBoolean(item[20]),
                        Recarg_consu=Convert.ToBoolean(item[21])
                        
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
