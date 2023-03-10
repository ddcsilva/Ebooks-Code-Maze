// <auto-generated />
using System;
using FuncionariosEmpresa.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FuncionariosEmpresa.API.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20230309001406_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FuncionariosEmpresa.Entities.Models.Empresa", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("EmpresaId");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("Pais")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Empresas");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                            Endereco = "583 Wall Dr. Gwynn Oak, MD 21207",
                            Nome = "IT_Solutions Ltd",
                            Pais = "USA"
                        },
                        new
                        {
                            Id = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"),
                            Endereco = "312 Forest Avenue, BF 923",
                            Nome = "Admin_Solutions Ltd",
                            Pais = "USA"
                        });
                });

            modelBuilder.Entity("FuncionariosEmpresa.Entities.Models.Funcionario", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("FuncionarioId");

                    b.Property<string>("Cargo")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<Guid>("EmpresaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Idade")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.HasIndex("EmpresaId");

                    b.ToTable("Funcionarios");

                    b.HasData(
                        new
                        {
                            Id = new Guid("80abbca8-664d-4b20-b5de-024705497d4a"),
                            Cargo = "Software developer",
                            EmpresaId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                            Idade = 26,
                            Nome = "Sam Raiden"
                        },
                        new
                        {
                            Id = new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"),
                            Cargo = "Software developer",
                            EmpresaId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                            Idade = 30,
                            Nome = "Jana McLeaf"
                        },
                        new
                        {
                            Id = new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                            Cargo = "Administrator",
                            EmpresaId = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"),
                            Idade = 35,
                            Nome = "Kane Miller"
                        });
                });

            modelBuilder.Entity("FuncionariosEmpresa.Entities.Models.Funcionario", b =>
                {
                    b.HasOne("FuncionariosEmpresa.Entities.Models.Empresa", "Empresa")
                        .WithMany("Funcionarios")
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Empresa");
                });

            modelBuilder.Entity("FuncionariosEmpresa.Entities.Models.Empresa", b =>
                {
                    b.Navigation("Funcionarios");
                });
#pragma warning restore 612, 618
        }
    }
}
