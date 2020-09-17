using Microsoft.EntityFrameworkCore.Migrations;

namespace Agenda_WPF.Migrations
{
    public partial class AplicadoConceitoHeranca : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NomeMedico",
                table: "Medicos");

            migrationBuilder.AddColumn<string>(
                name: "Bairro",
                table: "Usuarios",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cep",
                table: "Usuarios",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cidade",
                table: "Usuarios",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Estado",
                table: "Usuarios",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Numero",
                table: "Usuarios",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Rua",
                table: "Usuarios",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Telefone",
                table: "Usuarios",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Bairro",
                table: "Medicos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cep",
                table: "Medicos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cidade",
                table: "Medicos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Estado",
                table: "Medicos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "Medicos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Numero",
                table: "Medicos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Rua",
                table: "Medicos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bairro",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "Cep",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "Cidade",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "Estado",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "Numero",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "Rua",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "Telefone",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "Bairro",
                table: "Medicos");

            migrationBuilder.DropColumn(
                name: "Cep",
                table: "Medicos");

            migrationBuilder.DropColumn(
                name: "Cidade",
                table: "Medicos");

            migrationBuilder.DropColumn(
                name: "Estado",
                table: "Medicos");

            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Medicos");

            migrationBuilder.DropColumn(
                name: "Numero",
                table: "Medicos");

            migrationBuilder.DropColumn(
                name: "Rua",
                table: "Medicos");

            migrationBuilder.AddColumn<string>(
                name: "NomeMedico",
                table: "Medicos",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
