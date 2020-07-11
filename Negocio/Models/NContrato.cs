using Datos.KeyAutomatic;
using System;
using System.Data;

namespace Negocio.Models
{
    public class NContrato : IDisposable

    {


        public DataTable MostrarBanco()
        {
            return new Kcontrato().MostrarBanco();
        }

        public void Dispose()
        {
            //  throw new NotImplementedException();
        }
    }
}
