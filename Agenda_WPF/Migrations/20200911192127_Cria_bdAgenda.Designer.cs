﻿// <auto-generated />
using System;
using Agenda_WPF.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Agenda_WPF.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20200911192127_Cria_bdAgenda")]
    partial class Cria_bdAgenda
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Agenda_WPF.Model.Agenda", b =>
                {
                    b.Property<int>("IdAgenda")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CpfIdPaciente")
                        .HasColumnType("int");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataAgendada")
                        .HasColumnType("datetime2");

                    b.Property<int?>("EspecialidadeIdMedico")
                        .HasColumnType("int");

                    b.Property<int?>("NomeIdPaciente")
                        .HasColumnType("int");

                    b.Property<int?>("NomeMedicoIdMedico")
                        .HasColumnType("int");

                    b.Property<int?>("PlanoIdPaciente")
                        .HasColumnType("int");

                    b.HasKey("IdAgenda");

                    b.HasIndex("CpfIdPaciente");

                    b.HasIndex("EspecialidadeIdMedico");

                    b.HasIndex("NomeIdPaciente");

                    b.HasIndex("NomeMedicoIdMedico");

                    b.HasIndex("PlanoIdPaciente");

                    b.ToTable("Agendas");
                });

            modelBuilder.Entity("Agenda_WPF.Model.Medico", b =>
                {
                    b.Property<int>("IdMedico")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cpf")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("datetime2");

                    b.Property<string>("Crm")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Especialidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeMedico")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdMedico");

                    b.ToTable("Medicos");
                });

            modelBuilder.Entity("Agenda_WPF.Model.Paciente", b =>
                {
                    b.Property<int>("IdPaciente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cep")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cpf")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nascimento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumPlano")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Numero")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rua")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdPaciente");

                    b.ToTable("Pacientes");
                });

            modelBuilder.Entity("Agenda_WPF.Model.Usuario", b =>
                {
                    b.Property<int>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("datetime2");

                    b.Property<string>("TipoUsuario")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdUsuario");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Agenda_WPF.Model.Agenda", b =>
                {
                    b.HasOne("Agenda_WPF.Model.Paciente", "Cpf")
                        .WithMany()
                        .HasForeignKey("CpfIdPaciente");

                    b.HasOne("Agenda_WPF.Model.Medico", "Especialidade")
                        .WithMany()
                        .HasForeignKey("EspecialidadeIdMedico");

                    b.HasOne("Agenda_WPF.Model.Paciente", "Nome")
                        .WithMany()
                        .HasForeignKey("NomeIdPaciente");

                    b.HasOne("Agenda_WPF.Model.Medico", "NomeMedico")
                        .WithMany()
                        .HasForeignKey("NomeMedicoIdMedico");

                    b.HasOne("Agenda_WPF.Model.Paciente", "Plano")
                        .WithMany()
                        .HasForeignKey("PlanoIdPaciente");
                });
#pragma warning restore 612, 618
        }
    }
}
