using FuncionariosCompanhia.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FuncionariosCompanhia.Repository.Configuration;

public class CompanhiaConfiguration : IEntityTypeConfiguration<Companhia>
{
    public void Configure(EntityTypeBuilder<Companhia> builder)
    {
        builder.HasData
        (
            new Companhia
            {
                Id = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                Nome = "IT_Solutions Ltd",
                Endereco = "583 Wall Dr. Gwynn Oak, MD 21207",
                Pais = "USA"
            },
            new Companhia
            {
                Id = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"),
                Nome = "Admin_Solutions Ltd",
                Endereco = "312 Forest Avenue, BF 923",
                Pais = "USA"
            }
        );
    }
}
