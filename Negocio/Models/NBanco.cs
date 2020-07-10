using Datos.Contract;
using Datos.Entities;
using Datos.KeyAutomatic;
using Datos.Repositories;
using Negocio.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocio.Models
{
    public class NBanco:IDisposable
    {
        String mensaje;

        public int IdBanco { get; set ; }
        public string Nom_banco { get ; set ; }

        public EntityState state { get; set; }

        public IBanco RBanco;

        public NBanco()
        {
            RBanco =new RBanco();
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
    }
}
