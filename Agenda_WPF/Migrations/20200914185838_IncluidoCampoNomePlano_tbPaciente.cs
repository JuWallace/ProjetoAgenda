using Microsoft.EntityFrameworkCore.Migrations;

namespace Agenda_WPF.Migrations
{
    public partial class IncluidoCampoNomePlano_tbPaciente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NomePlano",
                table: "Pacientes",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NomePlano",
                table: "Pacientes");
        }
    }
}
