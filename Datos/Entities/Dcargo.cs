namespace Datos.Entities
{
    public class Dcargo
    {
        private int _idcargo;
        private string _nombre_cargo;
        private string _descripcion;
        public string Message { get; set; }



        //METODOS GET AND SET
        public int Idcargo
        {
            get { return _idcargo; }
            set { _idcargo = value; }
        }

        public string Nombre_cargo
        {
            get { return _nombre_cargo; }
            set { _nombre_cargo = value; }
        }

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        //CONSTRUCTORES
        public Dcargo() { }

        public Dcargo(string car, string des)
        {
            this.Nombre_cargo = car;
            this.Descripcion = des;
        }

    }
}
