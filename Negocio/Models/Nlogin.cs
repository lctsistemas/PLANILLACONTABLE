using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Datos.Entities;
using Datos.Repositories;
using System.Data;

namespace Negocio.Models
{
    public class Nlogin:IDisposable
    {
        public bool Login(string user, string pass)
        {
            return new Rlogin().Login(user,pass);
        }

        public bool Business(List<object> li)
        {
            return new Rlogin().Business(li);
        }

        public void Dispose()
        {
           // throw new NotImplementedException();
        }
    }
}
