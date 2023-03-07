using FuncionariosCompanhia.Contracts;
using FuncionariosCompanhia.Entities.Models;

namespace FuncionariosCompanhia.Repository;

public class CompanhiaRepository : RepositoryBase<Companhia>, ICompanhiaRepository
{
    public CompanhiaRepository(RepositoryContext context) : base(context)
    {
    }
}
