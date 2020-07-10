using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Datos.Entities
{
    public class Dafp
    {
        private int _idafp;
        private string _nombre_afp;
        private float _comision_flujo;
        private float _comision_mixta;
        private float _comision_anual;
        private float _prima_seguros;
        private float _fonto_pensiones;
        private float _remu_maxima;

       
        //1
        public int Idafp
        {
            get { return _idafp; }
            set { _idafp = value; }
        }
        //2
        public string Nombre_afp
        {
            get { return _nombre_afp; }
            set { _nombre_afp = value; }
        }
        //3
        public float Comision_flujo
        {
            get { return _comision_flujo; }
            set { _comision_flujo = value; }
        }
        //4
        public float Comision_mixta
        {
            get { return _comision_mixta; }
            set { _comision_mixta = value; }
        }
        //5
        public float Comision_anual
        {
            get { return _comision_anual; }
            set { _comision_anual = value; }
        }
        //6
        public float Prima_seguros
        {
            get { return _prima_seguros; }
            set { _prima_seguros = value; }
        }
        //7
        public float Fonto_pensiones
        {
            get { return _fonto_pensiones; }
            set { _fonto_pensiones = value; }
        }
        //8
        public float Remu_maxima
        {
            get { return _remu_maxima; }
            set { _remu_maxima = value; }
        }
        //CONSTRUCTOR
        public Dafp() { }

        public Dafp(string nafp, float cf, float cm, float ca, float ps, float fp, float rm)
        {
            this.Nombre_afp = nafp;
            this.Comision_flujo = cf;
            this.Comision_mixta = cm;
            this.Comision_anual = ca;
            this.Prima_seguros = ps;
            this.Fonto_pensiones = fp;
            this.Remu_maxima = rm;
        }
    }
}
