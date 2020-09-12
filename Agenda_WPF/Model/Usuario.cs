using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Agenda_WPF.Model
{
    [Table("Usuarios")]
    class Usuario
    {
        public Usuario()
        {
            CriadoEm = DateTime.Now; 
        }
        [Key]
        public int IdUsuario { get; set; }
        public string TipoUsuario { get; set; }
        public DateTime CriadoEm { get; set; }

        public override string ToString()
        {
            return "Usuário: " + TipoUsuario;
        }
    }
}
