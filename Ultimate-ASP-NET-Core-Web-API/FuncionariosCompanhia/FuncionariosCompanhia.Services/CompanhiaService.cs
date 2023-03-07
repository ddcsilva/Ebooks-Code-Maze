using FuncionariosCompanhia.Contracts;
using FuncionariosCompanhia.Services.Contracts;

namespace FuncionariosCompanhia.Services;

internal sealed class CompanhiaService : ICompanhiaService
{
    private readonly IRepositoryManager _repository;
    private readonly ILoggerManager _logger;

    public CompanhiaService(IRepositoryManager repository, ILoggerManager logger)
    {
        _repository = repository;
        _logger = logger;
    }
}
