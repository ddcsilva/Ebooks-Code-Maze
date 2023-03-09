using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FuncionariosEmpresa.API.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Empresas",
                columns: table => new
                {
                    EmpresaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Endereco = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Pais = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresas", x => x.EmpresaId);
                });

            migrationBuilder.CreateTable(
                name: "Funcionarios",
                columns: table => new
                {
                    FuncionarioId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Idade = table.Column<int>(type: "int", nullable: false),
                    Cargo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    EmpresaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionarios", x => x.FuncionarioId);
                    table.ForeignKey(
                        name: "FK_Funcionarios_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "EmpresaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Empresas",
                columns: new[] { "EmpresaId", "Endereco", "Nome", "Pais" },
                values: new object[] { new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"), "312 Forest Avenue, BF 923", "Admin_Solutions Ltd", "USA" });

            migrationBuilder.InsertData(
                table: "Empresas",
                columns: new[] { "EmpresaId", "Endereco", "Nome", "Pais" },
                values: new object[] { new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"), "583 Wall Dr. Gwynn Oak, MD 21207", "IT_Solutions Ltd", "USA" });

            migrationBuilder.InsertData(
                table: "Funcionarios",
                columns: new[] { "FuncionarioId", "Cargo", "EmpresaId", "Idade", "Nome" },
                values: new object[] { new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"), "Administrator", new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"), 35, "Kane Miller" });

            migrationBuilder.InsertData(
                table: "Funcionarios",
                columns: new[] { "FuncionarioId", "Cargo", "EmpresaId", "Idade", "Nome" },
                values: new object[] { new Guid("80abbca8-664d-4b20-b5de-024705497d4a"), "Software developer", new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"), 26, "Sam Raiden" });

            migrationBuilder.InsertData(
                table: "Funcionarios",
                columns: new[] { "FuncionarioId", "Cargo", "EmpresaId", "Idade", "Nome" },
                values: new object[] { new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"), "Software developer", new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"), 30, "Jana McLeaf" });

            migrationBuilder.CreateIndex(
                name: "IX_Funcionarios_EmpresaId",
                table: "Funcionarios",
                column: "EmpresaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Funcionarios");

            migrationBuilder.DropTable(
                name: "Empresas");
        }
    }
}
