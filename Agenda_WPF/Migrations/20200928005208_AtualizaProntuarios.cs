using Microsoft.EntityFrameworkCore.Migrations;

namespace Agenda_WPF.Migrations
{
    public partial class AtualizaProntuarios : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prontuario_Medicos_NomeMedicoIdMedico",
                table: "Prontuario");

            migrationBuilder.DropForeignKey(
                name: "FK_Prontuario_Pacientes_NomePacienteIdPaciente",
                table: "Prontuario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Prontuario",
                table: "Prontuario");

            migrationBuilder.RenameTable(
                name: "Prontuario",
                newName: "Prontuarios");

            migrationBuilder.RenameIndex(
                name: "IX_Prontuario_NomePacienteIdPaciente",
                table: "Prontuarios",
                newName: "IX_Prontuarios_NomePacienteIdPaciente");

            migrationBuilder.RenameIndex(
                name: "IX_Prontuario_NomeMedicoIdMedico",
                table: "Prontuarios",
                newName: "IX_Prontuarios_NomeMedicoIdMedico");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Prontuarios",
                table: "Prontuarios",
                column: "IdProntuario");

            migrationBuilder.AddForeignKey(
                name: "FK_Prontuarios_Medicos_NomeMedicoIdMedico",
                table: "Prontuarios",
                column: "NomeMedicoIdMedico",
                principalTable: "Medicos",
                principalColumn: "IdMedico",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Prontuarios_Pacientes_NomePacienteIdPaciente",
                table: "Prontuarios",
                column: "NomePacienteIdPaciente",
                principalTable: "Pacientes",
                principalColumn: "IdPaciente",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prontuarios_Medicos_NomeMedicoIdMedico",
                table: "Prontuarios");

            migrationBuilder.DropForeignKey(
                name: "FK_Prontuarios_Pacientes_NomePacienteIdPaciente",
                table: "Prontuarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Prontuarios",
                table: "Prontuarios");

            migrationBuilder.RenameTable(
                name: "Prontuarios",
                newName: "Prontuario");

            migrationBuilder.RenameIndex(
                name: "IX_Prontuarios_NomePacienteIdPaciente",
                table: "Prontuario",
                newName: "IX_Prontuario_NomePacienteIdPaciente");

            migrationBuilder.RenameIndex(
                name: "IX_Prontuarios_NomeMedicoIdMedico",
                table: "Prontuario",
                newName: "IX_Prontuario_NomeMedicoIdMedico");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Prontuario",
                table: "Prontuario",
                column: "IdProntuario");

            migrationBuilder.AddForeignKey(
                name: "FK_Prontuario_Medicos_NomeMedicoIdMedico",
                table: "Prontuario",
                column: "NomeMedicoIdMedico",
                principalTable: "Medicos",
                principalColumn: "IdMedico",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Prontuario_Pacientes_NomePacienteIdPaciente",
                table: "Prontuario",
                column: "NomePacienteIdPaciente",
                principalTable: "Pacientes",
                principalColumn: "IdPaciente",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
