using FuncionariosCompanhia.Contracts;
using FuncionariosCompanhia.Services.Contracts;

namespace FuncionariosCompanhia.Services;

internal sealed class FuncionarioService : IFuncionarioService
{
    private readonly IRepositoryManager _repository;
    private readonly ILoggerManager _logger;

    public FuncionarioService(IRepositoryManager repository, ILoggerManager logger)
    {
        _repository = repository;
        _logger = logger;
    }
}
