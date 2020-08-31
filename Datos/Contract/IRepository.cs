using Datos.Entities;
using System.Collections;
using System.Collections.Generic;

namespace Datos.Contract
{
    public interface IRepository : IGenerict<Dcargo>
    {
    }

    public interface IDocumento : IGenerict<DtipoDocumento>
    {
    }

    public interface IEmpresa_maestra : IGenerict<DempresaMaestra>
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
        bool ListaEmpleado(List<object> list, DEmpleado entity);
    }

    public interface IBanco : IGenerict<DBanco>
    {
    }
    public interface IRegimen : IGenerict<DRegimen> { }

    public interface IContrato : IGenerict<Dcontrato>
    {
    }
    public interface ITipo_contrato : IGenerict<Dtipocontrato> { }

    public interface IPlanilla : IGenerict<DPlanilla> { }


}
