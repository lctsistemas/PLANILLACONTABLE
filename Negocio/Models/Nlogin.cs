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
    public class Nlogin
    {
        public bool Login(string user, string pass, ArrayList dt)
        {
            return new Rlogin().Login(user,pass, dt);
        }

    }
}
