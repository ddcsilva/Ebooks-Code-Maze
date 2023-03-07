using FuncionariosCompanhia.Contracts;
using FuncionariosCompanhia.Entities.Models;

namespace FuncionariosCompanhia.Repository;

public class FuncionarioRepository : RepositoryBase<Funcionario>, IFuncionarioRepository
{
    public FuncionarioRepository(RepositoryContext context) : base(context)
    {
    }
}
