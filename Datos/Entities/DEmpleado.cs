using System;

namespace Datos.Entities
{
    public class DEmpleado
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

        public DEmpleado()
        {

        }


    }
}
