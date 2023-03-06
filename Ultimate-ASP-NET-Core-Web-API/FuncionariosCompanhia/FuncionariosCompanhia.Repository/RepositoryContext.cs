using FuncionariosCompanhia.Entities.Models;
using FuncionariosCompanhia.Repository.Configuration;
using Microsoft.EntityFrameworkCore;

namespace FuncionariosCompanhia.Repository;

public class RepositoryContext : DbContext
{
    public RepositoryContext(DbContextOptions options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new CompanhiaConfiguration());
        modelBuilder.ApplyConfiguration(new FuncionarioConfiguration());
    }

    public DbSet<Companhia>? Companhias { get; set; }
    public DbSet<Funcionario>? Funcionarios { get; set; }
}
