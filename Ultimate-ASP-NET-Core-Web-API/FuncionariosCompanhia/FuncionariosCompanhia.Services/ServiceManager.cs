using FuncionariosCompanhia.Contracts;
using FuncionariosCompanhia.Services.Contracts;

namespace FuncionariosCompanhia.Services;

public sealed class ServiceManager : IServiceManager
{
    private readonly Lazy<ICompanhiaService> _companhiaService;
    private readonly Lazy<IFuncionarioService> _funcionarioService;

    public ServiceManager(IRepositoryManager repositoryManager, ILoggerManager
    logger)
    {
        _companhiaService = new Lazy<ICompanhiaService>(() => new CompanhiaService(repositoryManager, logger));
        _funcionarioService = new Lazy<IFuncionarioService>(() => new FuncionarioService(repositoryManager, logger));
    }

    public ICompanhiaService CompanhiaService => _companhiaService.Value;
    public IFuncionarioService FuncionarioService => _funcionarioService.Value;
}
