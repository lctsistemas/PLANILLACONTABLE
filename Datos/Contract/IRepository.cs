using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Datos.Entities;

namespace Datos.Contract
{
    public interface IRepository:IGenerict<Dcargo> 
    {
    }

    
    public interface IDocumento:IGenerict<DtipoDocumento>
    {
    }

    public interface IEmpresa_maestra:IGenerict<DempresaMaestra> 
    { 
    }


    public interface IUsuario : IGenerict<Dusuario> 
    {
    }

    public interface IRol : IGenerict<Drol> 
    {
    }

    public interface IEmpleado : IGenerict<DEmpleado>
    {

    }
}
