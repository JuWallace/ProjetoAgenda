using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Agenda_WPF.Model;

namespace Agenda_WPF.DAL
{
    class Usuario
    {
        private static Context ctx = new Context();

        public static bool CadastrarUsuario(Usuario u)
        {
            if (BuscarUsuario(u) == null)
            {
                ctx.Usuarios.Add(u);
                ctx.SaveChanges();
                return true;
            }
            return false;


        }

        public static Usuario BuscarUsuario(Usuario u)
        {
            return ctx.Usuarios.FirstOrDefault(x => x.TipoUsuario.Equals(u.Us));
        }


        public static Usuario BuscarUsuarioPorId(int IdUsuario)
        {
            return ctx.Usuarios.Find(IdUsuario);
        }

     

        public static List<Paciente> ListarPacientes()
        {
            //return ctx.Produtos.FirstOrDefault( x => x.ProdutoId == id);    
            return ctx.Pacientes.ToList();
        }


    }
}
