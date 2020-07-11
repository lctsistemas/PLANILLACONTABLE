using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Datos.Entities
{
    public class Dcontrato
    {
        private Int32 id_contrato;
        private Int32 id_empleado;
        private Int32 id_banco;
        private Int32 id_tcontrato;
        private DateTime fecha_inicio;
        private DateTime fecha_fin;
        private String num_cuenta;
        private Decimal remu_basica;
        private Decimal asig_fami;
        private String tipo_moneda;
        private String cts;

        public int Id_contrato { get { return id_contrato; } set{ id_contrato = value; } }
        public int Id_empleado { get { return id_empleado; } set { id_empleado = value; } }
        public int Id_banco { get {return id_banco; } set { id_banco = value; }}
        public int Id_tcontrato { get {return id_tcontrato; } set { id_tcontrato = value; }}
        public DateTime Fecha_inicio { get {return fecha_inicio; } set { fecha_inicio = value; }}
        public DateTime Fecha_fin { get{return  fecha_fin; } set { fecha_fin = value; }}
        public string Num_cuenta { get {return num_cuenta; } set { num_cuenta = value; }}
        public decimal Remu_basica { get {return remu_basica; } set { remu_basica = value; }}
        public decimal Asig_fami { get{return  asig_fami; } set { asig_fami = value; }}
        public string Tipo_moneda { get {return tipo_moneda; } set { tipo_moneda = value; }}
        public string Cts { get { return cts; } set { cts = value; }}
        public String mensaje { get; set; }

        public Dcontrato() { }
    }
}
