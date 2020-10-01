using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Agenda_WPF.Migrations
{
    public partial class inclusaoProntuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Prontuario",
                columns: table => new
                {
                    IdProntuario = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomePacienteIdPaciente = table.Column<int>(nullable: true),
                    NomeMedicoIdMedico = table.Column<int>(nullable: true),
                    Sintomas = table.Column<string>(nullable: true),
                    Avaliacao = table.Column<string>(nullable: true),
                    Medicamento = table.Column<string>(nullable: true),
                    PlanoSaude = table.Column<string>(nullable: true),
                    DataConsulta = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prontuario", x => x.IdProntuario);
                    table.ForeignKey(
                        name: "FK_Prontuario_Medicos_NomeMedicoIdMedico",
                        column: x => x.NomeMedicoIdMedico,
                        principalTable: "Medicos",
                        principalColumn: "IdMedico",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Prontuario_Pacientes_NomePacienteIdPaciente",
                        column: x => x.NomePacienteIdPaciente,
                        principalTable: "Pacientes",
                        principalColumn: "IdPaciente",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Prontuario_NomeMedicoIdMedico",
                table: "Prontuario",
                column: "NomeMedicoIdMedico");

            migrationBuilder.CreateIndex(
                name: "IX_Prontuario_NomePacienteIdPaciente",
                table: "Prontuario",
                column: "NomePacienteIdPaciente");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Prontuario");
        }
    }
}
