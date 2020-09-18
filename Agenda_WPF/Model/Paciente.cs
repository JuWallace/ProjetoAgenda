﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Agenda_WPF.Model
{
    [Table("Pacientes")]
    class Paciente : Pessoa
    {
        public Paciente() => CriadoEm = DateTime.Now;

        [Key]
        public int IdPaciente { get; set; }
        //public string Nome { get; set; }
        //public string Cpf { get; set; }
        public string Rg { get; set; }
        public string Nascimento { get; set; }
        //public string Telefone { get; set; }
        //public string Email { get; set; }
        public string NomePlano { get; set; }
        public string NumPlano { get; set; }
        //public string Rua { get; set; }
        //public string Numero { get; set; }
        //public string Bairro { get; set; }
        //public string Cidade { get; set; }
        //public string Estado { get; set; }
        //public string Cep { get; set; }
        public DateTime CriadoEm { get; set; }

        public override string ToString()
        {
            return $"Nome: {Nome} | CPF: {Cpf} | RG: {Rg} | Nascimento: {Nascimento} | Telefone: {Telefone} | " +
                   $"E-Mail: {Email} | Plano: {NomePlano} | Nº Plano: {NumPlano} | ";
        }
    }
}
