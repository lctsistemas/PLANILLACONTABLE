namespace Datos.Entities
{
    public class DtipoDocumento
    {
        private int _iddocumento;
        private string _nombre_documento;
        private string _descripcion;
        private string cod_doc;
        public string message { get; set; }

        //METODOS GET AND SET
        public int Iddocumento
        {
            get { return _iddocumento; }
            set { _iddocumento = value; }
        }

        public string Nombre_documento
        {
            get { return _nombre_documento; }
            set { _nombre_documento = value; }
        }

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        public string Cod_doc { get => cod_doc; set => cod_doc = value; }



        //CONSTRUCTORES
        public DtipoDocumento() { }

        public DtipoDocumento(string docu, string des,string cod_doc)
        {
            this.Nombre_documento = docu;
            this.Descripcion = des;
            this.Cod_doc = cod_doc;
        }
    }
}
