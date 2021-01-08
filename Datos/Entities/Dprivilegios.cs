using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entities
{
    public class Dprivilegios : IDisposable
    {
        private Int32 id_privilegios;
        private Int32 id_rol;
        private bool btipopla;
        private bool btipocont;
        private bool bregimensalud;
        private bool bsubsinosub;
        private bool bcargo;
        private bool btipodoc;
        private bool bbanco;
        private bool broles;
        private bool bregimenpen;
        private bool bcomisiones;
        private bool bempleado;
        private bool bempresa;
        private bool bsucursal;
        private bool busuario;
        private bool bplanilla;

        public Dprivilegios()
        {
        }

        public Dprivilegios(int id_privilegios, int id_rol, bool btipopla, bool btipocont, bool bregimensalud, bool bsubsinosub, bool bcargo, bool btipodoc, bool bbanco, bool broles, bool bregimenpen, bool bcomisiones, bool bempleado, bool bempresa, bool bsucursal, bool busuario, bool bplanilla)
        {
            this.id_privilegios = id_privilegios;
            this.id_rol = id_rol;
            this.btipopla = btipopla;
            this.btipocont = btipocont;
            this.bregimensalud = bregimensalud;
            this.bsubsinosub = bsubsinosub;
            this.bcargo = bcargo;
            this.btipodoc = btipodoc;
            this.bbanco = bbanco;
            this.broles = broles;
            this.bregimenpen = bregimenpen;
            this.bcomisiones = bcomisiones;
            this.bempleado = bempleado;
            this.bempresa = bempresa;
            this.bsucursal = bsucursal;
            this.busuario = busuario;
            this.bplanilla = bplanilla;
        }

        public int Id_privilegios { get => id_privilegios; set => id_privilegios = value; }
        public int Id_rol { get => id_rol; set => id_rol = value; }
        public bool Btipopla { get => btipopla; set => btipopla = value; }
        public bool Btipocont { get => btipocont; set => btipocont = value; }
        public bool Bregimensalud { get => bregimensalud; set => bregimensalud = value; }
        public bool Bsubsinosub { get => bsubsinosub; set => bsubsinosub = value; }
        public bool Bcargo { get => bcargo; set => bcargo = value; }
        public bool Btipodoc { get => btipodoc; set => btipodoc = value; }
        public bool Bbanco { get => bbanco; set => bbanco = value; }
        public bool Broles { get => broles; set => broles = value; }
        public bool Bregimenpen { get => bregimenpen; set => bregimenpen = value; }
        public bool Bcomisiones { get => bcomisiones; set => bcomisiones = value; }
        public bool Bempleado { get => bempleado; set => bempleado = value; }
        public bool Bempresa { get => bempresa; set => bempresa = value; }
        public bool Bsucursal { get => bsucursal; set => bsucursal = value; }
        public bool Busuario { get => busuario; set => busuario = value; }
        public bool Bplanilla { get => bplanilla; set => bplanilla = value; }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }
    }
}
