using Datos.Repositories;
using System;
using System.Collections.Generic;

namespace Negocio.Models
{
    public class Nlogin : IDisposable
    {
        public bool Login(string user, string roles, string pass)
        {
            return new Rlogin().Login(user, roles, pass);
        }

        public bool Business(List<object> li)
        {
            return new Rlogin().Business(li);
        }

        //MOSTRANDO ID PERIODO
        public int Get_idperiodo(int periodo)
        {
            return new Rlogin().Get_idperiodo(periodo);
        }

        public void Dispose()
        {
            // throw new NotImplementedException();
        }
    }
}
