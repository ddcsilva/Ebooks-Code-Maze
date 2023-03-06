using FuncionariosCompanhia.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace FuncionariosCompanhia.Repository;

public class RepositoryContext : DbContext
{
    public RepositoryContext(DbContextOptions options) : base(options) { }

    public DbSet<Companhia>? Companhias { get; set; }
    public DbSet<Funcionario>? Funcionarios { get; set; }
}
