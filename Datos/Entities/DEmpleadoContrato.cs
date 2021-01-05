using System;

namespace Datos.Entities
{
    public class DEmpleadoContrato
    {
        private Int32 id_empleado;
        private String codigo;
        private String nom_emp;
        private String ape_pat;
        private String ape_mat;
        private DateTime fec_nac;
        private String nacionalidad;
        private String tipo_genero;
        private String direccion;
        private String telefono;
        private String num_doc;
        private String estado;
        private Int32 codigo_regimen;
        private Int32 id_doc;
        private Int32 id_cargo;
        private Int32 id_em_maestra;
        private String jornada_laboral;

        //ATRIBUTOS DE CONTRATO
        private Int32 cid_contrato;
        private Int32 cid_empleado;
        private Int32 cid_banco;
        private Int32 cid_tcontrato;
        private DateTime cfecha_inicio;
        private DateTime cfecha_fin;
        private String cnum_cuenta;
        private Decimal cremu_basica;
        private Decimal casig_fami;
        private Int32 cid_regimenSalud;
        private String ctipo_pago;
        private String cperiodicidad;
        private String ctipo_moneda;
        private String ccts;
        private String ccussp;
        public String mensaje { get; set; }

        //METODOS GET AND SET
        public int Id_empleado { get { return id_empleado; } set { id_empleado = value; } }
        public string Codigo { get { return codigo; } set { codigo = value; } }
        public string Nom_emp { get { return nom_emp; } set { nom_emp = value; } }
        public string Ape_pat { get { return ape_pat; } set { ape_pat = value; } }
        public string Ape_mat { get { return ape_mat; } set { ape_mat = value; } }
        public DateTime Fec_nac { get { return fec_nac; } set { fec_nac = value; } }
        public string Nacionalidad { get { return nacionalidad; } set { nacionalidad = value; } }
        public string Tipo_genero { get { return tipo_genero; } set { tipo_genero = value; } }
        public string Direccion { get { return direccion; } set { direccion = value; } }
        public string Telefono { get { return telefono; } set { telefono = value; } }
        public string Num_doc { get { return num_doc; } set { num_doc = value; } }
        public string Estado { get { return estado; } set { estado = value; } }
        public int Codigo_regimen { get { return codigo_regimen; } set { codigo_regimen = value; } }
        public int Id_doc { get { return id_doc; } set { id_doc = value; } }
        public int Id_cargo { get { return id_cargo; } set { id_cargo = value; } }
        public int Id_emp_maestra { get { return id_em_maestra; } set { id_em_maestra = value; } }
        public string Jornada_laboral{ get { return jornada_laboral; } set { jornada_laboral = value; } }

        // METODOS SET AND GET DE CONTRATO
        public int Cid_contrato { get { return cid_contrato; } set { cid_contrato = value; } }
        public int Cid_empleado { get { return cid_empleado; } set { cid_empleado = value; } }
        public int Cid_banco { get { return cid_banco; } set { cid_banco = value; } }
        public int Cid_tcontrato { get { return cid_tcontrato; } set {cid_tcontrato = value; } }
        public DateTime Cfecha_inicio { get { return cfecha_inicio; } set { cfecha_inicio = value; } }
        public DateTime Cfecha_fin { get { return cfecha_fin; } set { cfecha_fin = value; } }
        public string Cnum_cuenta { get { return cnum_cuenta; } set { cnum_cuenta = value; } }
        public decimal Cremu_basica { get { return cremu_basica; } set { cremu_basica = value; } }
        public decimal Casig_fami { get { return casig_fami; } set { casig_fami = value; } }
        public int Cid_regimenSalud { get { return cid_regimenSalud; } set { cid_regimenSalud = value; } }
        public string Ctipo_pago { get { return ctipo_pago; } set { ctipo_pago = value; } }
        public string Cperiodicidad { get { return cperiodicidad; } set { cperiodicidad = value; } }
        public string Ctipo_moneda { get { return ctipo_moneda; } set { ctipo_moneda = value; } }
        public string Ccts { get { return ccts; } set { ccts = value; } }
        public string Ccussp { get { return ccussp; } set { ccussp = value; } }      

        public DEmpleadoContrato()
        {

        }


    }
}
