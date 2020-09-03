using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Agenda_WPF.Model
{

    class Context : System.Data.Entity.DbContext
    {
        public Context() : base("DbAgenda_WPF") { }
        
        public System.Data.Entity.DbSet<Paciente> Pacientes { get; set; }
        public System.Data.Entity.DbSet<Agenda> Agendas { get; set; }
        public System.Data.Entity.DbSet<Medico> Medicos { get; set; }
        public System.Data.Entity.DbSet<Usuario> Usuarios { get; set; }
    }
    }
  





     


    

