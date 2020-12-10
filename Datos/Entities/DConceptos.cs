using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entities
{
    public class DConceptos:IDisposable
    {
        private int id_conceptos;
        private int id_mes;
        private int id_planilla;
        private bool hextraDiurna;
        private bool hextraNocturna;
        private bool feriadoDomi;
        private bool boniNoctur;
        private bool primeroMayo;
        private bool tarda;
        private bool subsidi;
        private bool thoraex;
        private bool otroreinte;
        private bool prest_aliment;
        private bool gratif;
        private bool vaca;
        private bool trunca;
        private bool reinte_gratiboni;
        private bool essa_vida;
        private bool adela;
        private bool presta;
        private bool rentquinta;
        private bool reten_judici;
        private bool otrodescu;
        private bool recarg_consu;

        public int Id_conceptos { get => id_conceptos; set => id_conceptos = value; }
        public int Id_mes { get => id_mes; set => id_mes = value; }
        public int Id_planilla { get => id_planilla; set => id_planilla = value; }
        public bool HextraDiurna { get => hextraDiurna; set => hextraDiurna = value; }
        public bool HextraNocturna { get => hextraNocturna; set => hextraNocturna = value; }
        public bool FeriadoDomi { get => feriadoDomi; set => feriadoDomi = value; }
        public bool BoniNoctur { get => boniNoctur; set => boniNoctur = value; }
        public bool PrimeroMayo { get => primeroMayo; set => primeroMayo = value; }
        public bool Tarda { get => tarda; set => tarda = value; }
        public bool Subsidi { get => subsidi; set => subsidi = value; }
        public bool Thoraex { get => thoraex; set => thoraex = value; }
        public bool Otroreinte { get => otroreinte; set => otroreinte = value; }
        public bool Prest_aliment { get => prest_aliment; set => prest_aliment = value; }
        public bool Gratif { get => gratif; set => gratif = value; }
        public bool Vaca { get => vaca; set => vaca = value; }
        public bool Trunca { get => trunca; set => trunca = value; }
        public bool Reinte_gratiboni { get => reinte_gratiboni; set => reinte_gratiboni = value; }
        public bool Essa_vida { get => essa_vida; set => essa_vida = value; }
        public bool Adela { get => adela; set => adela = value; }
        public bool Presta { get => presta; set => presta = value; }
        public bool Rentquinta { get => rentquinta; set => rentquinta = value; }
        public bool Reten_judici { get => reten_judici; set => reten_judici = value; }
        public bool Otrodescu { get => otrodescu; set => otrodescu = value; }
        public bool Recarg_consu { get => recarg_consu; set => recarg_consu = value; }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }
    }

}
