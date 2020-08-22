﻿using Microsoft.EntityFrameworkCore;

namespace Agenda_WPF.Model
{
    class Context : DbContext
    {
        public Context() : base("DbAgendamento")
        {

        }

        //Definir as classes que vão virar tabelas no banco
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Agenda> Agendas { get; set; }
        public DbSet<Medico> Medicos { get; set; }
    }
}
