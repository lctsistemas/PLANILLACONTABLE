using Datos.Entities;

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

    public interface IRegimenSalud : IGenerict<DRegimenSalud> { }

    public interface ISubsidios : IGenerict<DSubsidios> { }

}
