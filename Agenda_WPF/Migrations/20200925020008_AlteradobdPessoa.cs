using Microsoft.EntityFrameworkCore.Migrations;

namespace Agenda_WPF.Migrations
{
    public partial class AlteradobdPessoa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Nascimento",
                table: "Usuarios",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Rg",
                table: "Usuarios",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nascimento",
                table: "Medicos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Rg",
                table: "Medicos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nascimento",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "Rg",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "Nascimento",
                table: "Medicos");

            migrationBuilder.DropColumn(
                name: "Rg",
                table: "Medicos");
        }
    }
}
