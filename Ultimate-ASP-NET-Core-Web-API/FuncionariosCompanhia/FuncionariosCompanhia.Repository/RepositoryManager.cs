using FuncionariosCompanhia.Contracts;

namespace FuncionariosCompanhia.Repository;

public class RepositoryManager : IRepositoryManager
{
    private readonly RepositoryContext _context;
    private readonly Lazy<ICompanhiaRepository> _companhiaRepository;
    private readonly Lazy<IFuncionarioRepository> _funcionarioRepository;

    public RepositoryManager(RepositoryContext context)
    {
        _context = context;
        _companhiaRepository = new Lazy<ICompanhiaRepository>(() => new CompanhiaRepository(context));
        _funcionarioRepository = new Lazy<IFuncionarioRepository>(() => new FuncionarioRepository(context));
    }

    public ICompanhiaRepository Companhia => _companhiaRepository.Value;
    public IFuncionarioRepository Funcionario => _funcionarioRepository.Value;

    public void Salvar()
    {
        _context.SaveChanges();
    }
}
