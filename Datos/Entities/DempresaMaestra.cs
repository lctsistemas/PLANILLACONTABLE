using System;


namespace Datos.Entities
{
    public class DempresaMaestra
    {
        private int idempresa_maestra;
        private String razon_social;
        private String localidad;
        private String direccion;
        private String domicilio;
        private String ruc;
        private String regimen;
        private String estado;
        public String mesages { get; set; }
        public String search { get; set; }

        //EMPRESA
        private Int32 eidempresa;
        private String ecodigo_empresa;
        private Int32 eidemp_maestra;
        private Int32 eidusuario;
        //SUCURSAL
        private Int32 sidsucursal;
        private String scodigo_sucursal;
        private Int32 sidem_maestra;
        private Int32 sid_empresa;

        //METODOS GET AND SET EMPRESA MAESTRA
        public Int32 Idempresa_maestra
        {
            get { return idempresa_maestra; }
            set { idempresa_maestra = value; }
        }

        public String Razon_social
        {
            get { return razon_social; }
            set { razon_social = value; }
        }

        public String Localidad
        {
            get { return localidad; }
            set { localidad = value; }
        }

        public String Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        public String Domicilio
        {
            get { return domicilio; }
            set { domicilio = value; }
        }
        public String Ruc
        {
            get { return ruc; }
            set { ruc = value; }
        }
        public String Regimen
        {
            get { return regimen; }
            set { regimen = value; }
        }
        public String Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        //METODO GET AND SET EMPRESA
        public Int32 Eidempresa
        {
            get { return eidempresa; }
            set { eidempresa = value; }
        }
        public String Ecodigo_empresa
        {
            get { return ecodigo_empresa; }
            set { ecodigo_empresa = value; }
        }
        public Int32 Eidemp_maestra
        {
            get { return eidemp_maestra; }
            set { eidemp_maestra = value; }
        }
        public Int32 Eidusuario
        {
            get { return eidusuario; }
            set { eidusuario = value; }
        }

        //METODO GET AND SET SUCURSAL
        public Int32 Sidsucursal
        {
            get { return sidsucursal; }
            set { sidsucursal = value; }
        }
        public String Scodigo_sucursal
        {
            get { return scodigo_sucursal; }
            set { scodigo_sucursal = value; }
        }
        public Int32 Sidem_maestra
        {
            get { return sidem_maestra; }
            set { sidem_maestra = value; }
        }
        public Int32 Sid_empresa
        {
            get { return sid_empresa; }
            set { sid_empresa = value; }
        }


    }
}
