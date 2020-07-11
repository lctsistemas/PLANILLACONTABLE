using Datos.Contract;
using Datos.Entities;
using Datos.KeyAutomatic;
using Datos.Repositories;
using Negocio.ValueObjects;
using System;
using System.Collections.Generic;
using System.Data;

namespace Negocio.Models
{
    public class NBanco : IDisposable
    {
        String mensaje;

        public int IdBanco { get; set; }
        public string Nom_banco { get; set; }

        public EntityState state { get; set; }

        public IBanco RBanco;

        private List<NBanco> list_banco;

        public NBanco()
        {
            RBanco = new RBanco();
        }

        public String GuardarCambios()
        {
            DBanco ban = new DBanco();
            ban.IdBanco = IdBanco;
            ban.Nom_banco = Nom_banco;

            switch (state)
            {
                case EntityState.Guardar:
                    RBanco.Add(ban);
                    mensaje = ban.mensaje;
                    break;

                case EntityState.Remover:
                    RBanco.Delete(ban);
                    mensaje = ban.mensaje;
                    break;
            }

            return mensaje;
        }

        public int GetCodigo()
        {
            return new KBanco().GetCodigo();
        }
        public void Dispose()
        {
            // throw new NotImplementedException();
        }


        public List<NBanco> Listar()
        {
            DBanco dbanco = new DBanco();
            dbanco.Nom_banco = Nom_banco;

            using (DataTable dt = RBanco.GetData(dbanco))
            {
                list_banco = new List<NBanco>();
                foreach (DataRow item in dt.Rows)
                {
                    list_banco.Add(new NBanco()
                    {
                        IdBanco = Convert.ToInt32(item[0]),
                        Nom_banco = item[1].ToString()
                    });
                }

                return list_banco;

            }

        }
    }
}
