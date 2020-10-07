﻿using Agenda_WPF.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Agenda_WPF.DAL
{
    class ProntuarioDAO
    {
        private static Context ctx = SingletonContext.GetInstance();

        public static string Cadastrar(Prontuario p)
        {
            try
            {
                ctx.Prontuarios.Add(p);
                ctx.SaveChanges();
                return null;
            }
            catch (Exception err)
            {
                return "Erro ao salvar prontuário";
            }
        }
    }
}
