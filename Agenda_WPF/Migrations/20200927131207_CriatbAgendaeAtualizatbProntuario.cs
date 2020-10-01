using Microsoft.EntityFrameworkCore.Migrations;

namespace Agenda_WPF.Migrations
{
    public partial class CriatbAgendaeAtualizatbProntuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agendas_Pacientes_CpfIdPaciente",
                table: "Agendas");

            migrationBuilder.DropForeignKey(
                name: "FK_Agendas_Medicos_EspecialidadeIdMedico",
                table: "Agendas");

            migrationBuilder.DropForeignKey(
                name: "FK_Agendas_Pacientes_NomeIdPaciente",
                table: "Agendas");

            migrationBuilder.DropForeignKey(
                name: "FK_Agendas_Medicos_NomeMedicoIdMedico",
                table: "Agendas");

            migrationBuilder.DropForeignKey(
                name: "FK_Agendas_Pacientes_PlanoIdPaciente",
                table: "Agendas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Agendas",
                table: "Agendas");

            migrationBuilder.RenameTable(
                name: "Agendas",
                newName: "Agenda");

            migrationBuilder.RenameIndex(
                name: "IX_Agendas_PlanoIdPaciente",
                table: "Agenda",
                newName: "IX_Agenda_PlanoIdPaciente");

            migrationBuilder.RenameIndex(
                name: "IX_Agendas_NomeMedicoIdMedico",
                table: "Agenda",
                newName: "IX_Agenda_NomeMedicoIdMedico");

            migrationBuilder.RenameIndex(
                name: "IX_Agendas_NomeIdPaciente",
                table: "Agenda",
                newName: "IX_Agenda_NomeIdPaciente");

            migrationBuilder.RenameIndex(
                name: "IX_Agendas_EspecialidadeIdMedico",
                table: "Agenda",
                newName: "IX_Agenda_EspecialidadeIdMedico");

            migrationBuilder.RenameIndex(
                name: "IX_Agendas_CpfIdPaciente",
                table: "Agenda",
                newName: "IX_Agenda_CpfIdPaciente");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Agenda",
                table: "Agenda",
                column: "IdAgenda");

            migrationBuilder.AddForeignKey(
                name: "FK_Agenda_Pacientes_CpfIdPaciente",
                table: "Agenda",
                column: "CpfIdPaciente",
                principalTable: "Pacientes",
                principalColumn: "IdPaciente",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Agenda_Medicos_EspecialidadeIdMedico",
                table: "Agenda",
                column: "EspecialidadeIdMedico",
                principalTable: "Medicos",
                principalColumn: "IdMedico",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Agenda_Pacientes_NomeIdPaciente",
                table: "Agenda",
                column: "NomeIdPaciente",
                principalTable: "Pacientes",
                principalColumn: "IdPaciente",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Agenda_Medicos_NomeMedicoIdMedico",
                table: "Agenda",
                column: "NomeMedicoIdMedico",
                principalTable: "Medicos",
                principalColumn: "IdMedico",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Agenda_Pacientes_PlanoIdPaciente",
                table: "Agenda",
                column: "PlanoIdPaciente",
                principalTable: "Pacientes",
                principalColumn: "IdPaciente",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agenda_Pacientes_CpfIdPaciente",
                table: "Agenda");

            migrationBuilder.DropForeignKey(
                name: "FK_Agenda_Medicos_EspecialidadeIdMedico",
                table: "Agenda");

            migrationBuilder.DropForeignKey(
                name: "FK_Agenda_Pacientes_NomeIdPaciente",
                table: "Agenda");

            migrationBuilder.DropForeignKey(
                name: "FK_Agenda_Medicos_NomeMedicoIdMedico",
                table: "Agenda");

            migrationBuilder.DropForeignKey(
                name: "FK_Agenda_Pacientes_PlanoIdPaciente",
                table: "Agenda");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Agenda",
                table: "Agenda");

            migrationBuilder.RenameTable(
                name: "Agenda",
                newName: "Agendas");

            migrationBuilder.RenameIndex(
                name: "IX_Agenda_PlanoIdPaciente",
                table: "Agendas",
                newName: "IX_Agendas_PlanoIdPaciente");

            migrationBuilder.RenameIndex(
                name: "IX_Agenda_NomeMedicoIdMedico",
                table: "Agendas",
                newName: "IX_Agendas_NomeMedicoIdMedico");

            migrationBuilder.RenameIndex(
                name: "IX_Agenda_NomeIdPaciente",
                table: "Agendas",
                newName: "IX_Agendas_NomeIdPaciente");

            migrationBuilder.RenameIndex(
                name: "IX_Agenda_EspecialidadeIdMedico",
                table: "Agendas",
                newName: "IX_Agendas_EspecialidadeIdMedico");

            migrationBuilder.RenameIndex(
                name: "IX_Agenda_CpfIdPaciente",
                table: "Agendas",
                newName: "IX_Agendas_CpfIdPaciente");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Agendas",
                table: "Agendas",
                column: "IdAgenda");

            migrationBuilder.AddForeignKey(
                name: "FK_Agendas_Pacientes_CpfIdPaciente",
                table: "Agendas",
                column: "CpfIdPaciente",
                principalTable: "Pacientes",
                principalColumn: "IdPaciente",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Agendas_Medicos_EspecialidadeIdMedico",
                table: "Agendas",
                column: "EspecialidadeIdMedico",
                principalTable: "Medicos",
                principalColumn: "IdMedico",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Agendas_Pacientes_NomeIdPaciente",
                table: "Agendas",
                column: "NomeIdPaciente",
                principalTable: "Pacientes",
                principalColumn: "IdPaciente",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Agendas_Medicos_NomeMedicoIdMedico",
                table: "Agendas",
                column: "NomeMedicoIdMedico",
                principalTable: "Medicos",
                principalColumn: "IdMedico",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Agendas_Pacientes_PlanoIdPaciente",
                table: "Agendas",
                column: "PlanoIdPaciente",
                principalTable: "Pacientes",
                principalColumn: "IdPaciente",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
