using System.Collections.Generic;
using System.Linq;
using Agenda_WPF.Model;
using Microsoft.EntityFrameworkCore;

namespace Agenda_WPF.DAL
{
    class UsuarioDAO
    {
        private static Context ctx = SingletonContext.GetInstance();
        public static List<Usuario> ListarUsuarios() => ctx.Usuarios.ToList();
        public static Usuario BuscarUsuarioPorCpf(Usuario cpf) => ctx.Usuarios.FirstOrDefault(x => x.Cpf.Equals(cpf.Cpf));
        public static Usuario BuscarUsuarioPorNome(Usuario nome) => ctx.Usuarios.FirstOrDefault(x => x.Nome.Equals(nome.Nome));

        public static bool CadastrarUsuario(Usuario usr)
        {
            if (BuscarUsuarioPorCpf(usr) == null)
            {
                ctx.Usuarios.Add(usr);
                ctx.SaveChanges();
                return true;
            }
            return false;
        }

        public static void AlterarUsuario(Usuario usr)
        {
            ctx.Entry(usr).State = EntityState.Modified;
            ctx.SaveChanges();
        }

        public static void RemoverUsuario(Usuario usr)
        {
            ctx.Usuarios.Remove(usr);
            ctx.SaveChanges();
        }

        public static Usuario ValidaLogin(string login) => ctx.Usuarios.FirstOrDefault
                                                            (x => x.Email.Equals(login));

    }
}
