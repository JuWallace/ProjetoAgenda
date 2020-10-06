using Microsoft.EntityFrameworkCore.Migrations;

namespace Agenda_WPF.Migrations
{
    public partial class AtualizaTabelas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agenda_Pacientes_NomeIdPaciente",
                table: "Agenda");

            migrationBuilder.DropForeignKey(
                name: "FK_Agenda_Medicos_NomeMedicoIdMedico",
                table: "Agenda");

            migrationBuilder.DropForeignKey(
                name: "FK_Agenda_Pacientes_PlanoIdPaciente",
                table: "Agenda");

            migrationBuilder.DropIndex(
                name: "IX_Agenda_NomeIdPaciente",
                table: "Agenda");

            migrationBuilder.DropIndex(
                name: "IX_Agenda_NomeMedicoIdMedico",
                table: "Agenda");

            migrationBuilder.DropIndex(
                name: "IX_Agenda_PlanoIdPaciente",
                table: "Agenda");

            migrationBuilder.DropColumn(
                name: "NomeIdPaciente",
                table: "Agenda");

            migrationBuilder.DropColumn(
                name: "NomeMedicoIdMedico",
                table: "Agenda");

            migrationBuilder.DropColumn(
                name: "PlanoIdPaciente",
                table: "Agenda");

            migrationBuilder.AddColumn<int>(
                name: "MedicoIdMedico",
                table: "Agenda",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PacienteIdPaciente",
                table: "Agenda",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Plano",
                table: "Agenda",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "tbPlanoSaude",
                columns: table => new
                {
                    PlanoSaudeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Plano = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbPlanoSaude", x => x.PlanoSaudeId);
                });

            migrationBuilder.CreateTable(
                name: "tbProcedimentos",
                columns: table => new
                {
                    ProcedimentoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeProcedimento = table.Column<string>(nullable: true),
                    Valor = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbProcedimentos", x => x.ProcedimentoId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Agenda_MedicoIdMedico",
                table: "Agenda",
                column: "MedicoIdMedico");

            migrationBuilder.CreateIndex(
                name: "IX_Agenda_PacienteIdPaciente",
                table: "Agenda",
                column: "PacienteIdPaciente");

            migrationBuilder.AddForeignKey(
                name: "FK_Agenda_Medicos_MedicoIdMedico",
                table: "Agenda",
                column: "MedicoIdMedico",
                principalTable: "Medicos",
                principalColumn: "IdMedico",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Agenda_Pacientes_PacienteIdPaciente",
                table: "Agenda",
                column: "PacienteIdPaciente",
                principalTable: "Pacientes",
                principalColumn: "IdPaciente",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agenda_Medicos_MedicoIdMedico",
                table: "Agenda");

            migrationBuilder.DropForeignKey(
                name: "FK_Agenda_Pacientes_PacienteIdPaciente",
                table: "Agenda");

            migrationBuilder.DropTable(
                name: "tbPlanoSaude");

            migrationBuilder.DropTable(
                name: "tbProcedimentos");

            migrationBuilder.DropIndex(
                name: "IX_Agenda_MedicoIdMedico",
                table: "Agenda");

            migrationBuilder.DropIndex(
                name: "IX_Agenda_PacienteIdPaciente",
                table: "Agenda");

            migrationBuilder.DropColumn(
                name: "MedicoIdMedico",
                table: "Agenda");

            migrationBuilder.DropColumn(
                name: "PacienteIdPaciente",
                table: "Agenda");

            migrationBuilder.DropColumn(
                name: "Plano",
                table: "Agenda");

            migrationBuilder.AddColumn<int>(
                name: "NomeIdPaciente",
                table: "Agenda",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NomeMedicoIdMedico",
                table: "Agenda",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PlanoIdPaciente",
                table: "Agenda",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Agenda_NomeIdPaciente",
                table: "Agenda",
                column: "NomeIdPaciente");

            migrationBuilder.CreateIndex(
                name: "IX_Agenda_NomeMedicoIdMedico",
                table: "Agenda",
                column: "NomeMedicoIdMedico");

            migrationBuilder.CreateIndex(
                name: "IX_Agenda_PlanoIdPaciente",
                table: "Agenda",
                column: "PlanoIdPaciente");

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
    }
}
