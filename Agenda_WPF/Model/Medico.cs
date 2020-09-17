using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Agenda_WPF.Model
{
    [Table("Medicos")]
    public class Medico : Pessoa
    {
        public Medico() => CriadoEm = DateTime.Now;

        [Key]
        public int IdMedico { get; set; }
        //public string NomeMedico { get; set; }
        //public string Cpf { get; set; }
        public string Crm { get; set; }
        public string Especialidade { get; set; }
        //public string Telefone { get; set; }
        //public string Email { get; set; }
        public DateTime CriadoEm { get; set; }

        //public override string ToString()
        //{
        //    return "Medico: " + _NomeMedico + "\t| CPF: " + _CpfMedico + "\t| CRM: " + Crm + "\t|" +
        //            "Telefone: " + _Telefone + "\t| Email: " + _Email + "\t| Especialidade: " + Especialidade + "\t|" +
        //            "Criado em: " + CriadoEm;
        //}
        public override string ToString()
        {
            return "Medico: " + Nome + "\t| CPF: " + Cpf + "\t| CRM: " + Crm + "\t|" +
                    "Telefone: " + Telefone + "\t| Email: " + Email + "\t| Especialidade: " + Especialidade + "\t|" +
                    "Criado em: " + CriadoEm;
        }
    }
}
