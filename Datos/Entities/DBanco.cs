using System;

namespace Datos.Entities
{
    public class DBanco
    {
        private int idBanco;
        private string nom_banco;
        public string mensaje { get; set; } 

        public DBanco()
        {
        }

        public DBanco(int idBanco, string nom_banco)
        {
            this.IdBanco = idBanco;
            this.Nom_banco = nom_banco;

        }

        public int IdBanco
        {
            get {return idBanco;}

            set{idBanco = value;}
        }

        public string Nom_banco
        {
            get
            {
                return nom_banco;
            }

            set
            {
                nom_banco = value;
            }
        }
    }
}
