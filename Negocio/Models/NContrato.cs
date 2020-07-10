using Datos.KeyAutomatic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Negocio.Models
{
    public class NContrato : IDisposable
    
    {
        public void Dispose()
        {
          //  throw new NotImplementedException();
        }

        public DataTable MostrarBanco()
        {
            return new Kcontrato().MostrarBanco();
        }
    }
}
