using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoVSC.Migrations
{
    public partial class CpfFuncionarioMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Funcionario",
                newName: "Cpf");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Cpf",
                table: "Funcionario",
                newName: "Nome");
        }
    }
}
