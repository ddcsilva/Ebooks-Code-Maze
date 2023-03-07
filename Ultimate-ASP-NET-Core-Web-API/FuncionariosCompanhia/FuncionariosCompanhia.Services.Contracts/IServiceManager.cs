namespace FuncionariosCompanhia.Services.Contracts;

public interface IServiceManager
{
    ICompanhiaService CompanhiaService { get; }
    IFuncionarioService FuncionarioService { get; }
}
