namespace FuncionariosEmpresa.Services.Contracts;

public interface IServiceManager
{
    IEmpresaService EmpresaService { get; }
    IFuncionarioService FuncionarioService { get; }
}
