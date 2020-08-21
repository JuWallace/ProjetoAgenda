using Agenda_WPF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Agenda_WPF.View
{
    /// <summary>
    /// Interaction logic for frmListarPaciente.xaml
    /// </summary>
    public partial class frmListarPaciente : Window
    {
        private string operacao;
        public frmListarPaciente()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, RoutedEventArgs e)
        {
            Paciente p = new Paciente();
            p.Nome = txtNome.Text;
            p.Cpf = txtCpf.Text;
            p.Telefone = txtTelefone.Text;
            p.Email = txtEmail.Text;
            using (Context ctx = new Context())
            {
              
                if (operacao == "inserir")
                {
                   
                    {
                        ctx.Pacientes.Add(p);
                        ctx.SaveChanges();
                    }
                }
                if (operacao == "alterar")
                {
                    
                    {
                        ctx.Pacientes.Add(p);
                        ctx.SaveChanges();
                    }
                }

                this.ListarDados();
                this.AlteraBotoes(1);
                this.LimpaCampos();

            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.ListarDados();
        }

        private void ListarDados()
        {
            Context ctx = new Context();
            {
                var consulta = ctx.Pacientes;
                dgDados.ItemsSource = consulta.ToList();
            }
        }
        private void AlteraBotoes(int op)
        {
            btnAlterar.IsEnabled = false;
            btnInserir.IsEnabled = false;
            btnExcluir.IsEnabled = false;
            btnCancelar.IsEnabled = false;
            btnLocalizar.IsEnabled = false;
            btnSalvar.IsEnabled = false;

            if (op == 1)
            {
                //ativar as opções iniciais
                btnInserir.IsEnabled = true;
                btnLocalizar.IsEnabled = true;
            }
            if (op == 2)
            {
                //inserir um valor
                btnCancelar.IsEnabled = true;
                btnSalvar.IsEnabled = true;
            }
            if (op == 3)
            {
                btnAlterar.IsEnabled = true;
                btnExcluir.IsEnabled = true;
            }
        }
        private void LimpaCampos()
        {

            txtNome.IsEnabled = true;
            txtCpf.IsEnabled = true;
            txtTelefone.IsEnabled = true;
            txtEmail.IsEnabled = true;
           
            txtNome.Clear();
            txtCpf.Clear();
            txtTelefone.Clear();
            txtEmail.Clear();

            
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.operacao = "cancelar";
        }
    }
}
