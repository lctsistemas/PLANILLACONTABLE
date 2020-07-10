using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

        public int IdBanco { get => idBanco; set => idBanco = value; }
        public string Nom_banco { get => nom_banco; set => nom_banco = value; }


    }
}
