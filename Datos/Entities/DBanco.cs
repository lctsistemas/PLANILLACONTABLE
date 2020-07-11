using System;

namespace Datos.Entities
{
    public class DBanco
    {
        private int idBanco;
        private string nom_banco;

        public DBanco()
        {
        }

        public DBanco(int idBanco, string nom_banco)
        {
            this.idBanco = idBanco;
            this.nom_banco = nom_banco;
        }

        public int IdBanco { get; set; }
        public string Nom_banco { get; set; }

        public String mensaje { get; set; }



    }
}
