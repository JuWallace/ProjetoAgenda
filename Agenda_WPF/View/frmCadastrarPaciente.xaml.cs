using Agenda_WPF.Model;
using Correios.Net;
using System;
using System.Windows;

namespace Agenda_WPF.View
{
    /// <summary>
    /// Interaction logic for frmCadastrarPaciente.xaml
    /// </summary>
    public partial class frmCadastrarPaciente : Window
    {
        private string operacao;
        public frmCadastrarPaciente()
        {
            InitializeComponent();
        }
        
        private void LimpaCampos()
        {
            txtNome.IsEnabled = true;
            txtCpf.IsEnabled = true;
            txtRg.IsEnabled = true;
            txtDtaNascimento.IsEnabled = true;
            txtTelefone.IsEnabled = true;
            txtEmail.IsEnabled = true;
            cboPlano.IsEnabled = true;
            txtNPlano.IsEnabled = true;
            txtRua.IsEnabled = true;
            txtNumero.IsEnabled = true;
            txtBairro.IsEnabled = true;
            txtCidade.IsEnabled = true;
            txtEstado.IsEnabled = true;
            txtCep_Leave.IsEnabled = true;

            txtNome.Clear();
            txtCpf.Clear();
            txtRg.Clear();
            txtDtaNascimento.Clear();
            txtTelefone.Clear();
            txtEmail.Clear();

            txtNPlano.Clear();
            txtRua.Clear();
            txtNumero.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtEstado.Clear();
            txtCep_Leave.Clear();
        }
        private void btnSalvar_Click(object sender, RoutedEventArgs e)
        {
            using (Context ctx = new Context())
            {
                Paciente p = new Paciente();
                p.Nome = txtNome.Text;
                p.Cpf = txtCpf.Text;
                p.Rg = txtRg.Text;
                p.Nascimento = txtDtaNascimento.Text;
                p.Telefone = txtTelefone.Text;
                p.Email = txtEmail.Text;
                p.NumPlano = txtNPlano.Text;
                p.Rua = txtRua.Text;
                p.Numero = txtNumero.Text;
                p.Bairro = txtBairro.Text;
                p.Cidade = txtCidade.Text;
                p.Estado = txtEstado.Text;
                p.Cep = txtCep_Leave.Text;

                if (operacao == "inserir")
                {
                    Context context = new Context();
                    {
                        context.Pacientes.Add(p);
                        context.SaveChanges();
                    }

                }
                if (operacao == "alterar")
                {
                    {
                        ctx.Pacientes.Add(p);
                        ctx.SaveChanges();
                    }
                }

                //this.ListarDados();
                this.AlteraBotoes(1);
                this.LimpaCampos();

            }


        }
        private void btnInserir_Click(object sender, RoutedEventArgs e)
        {
            this.operacao = "inserir";
            this.AlteraBotoes(2);

        }

        //private void ListarDados(int op)
        //{
        //    this.ListarDados();
        //}
        //private void ListarDados()
        //{
        //    Context ctx = new Context();
        //    {
        //        var consulta = ctx.Pacientes;
        //        dgDados.ItemsSource = consulta.ToList();
        //    }
        //}

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

        private void textCep_Leave(object sender, EventArgs e)
        {
            LocalizarCEP();
        }

        private void LocalizarCEP()
        {
            if (!string.IsNullOrWhiteSpace(txtCep_Leave.Text))
            {
                Address endereco = SearchZip.GetAddress(txtCep_Leave.Text);
                if (endereco.Zip != null)
                {
                    txtEstado.Text = endereco.State;
                    txtCidade.Text = endereco.City;
                    txtBairro.Text = endereco.District;
                    txtRua.Text = endereco.Street;
                }
                else
                {
                    MessageBox.Show("Cep não localizado...");
                }
            }
            else
            {
                MessageBox.Show("Informe um CEP válido");
            }
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.AlteraBotoes(1);
            this.LimpaCampos();
        }

        private void btnSair_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }

}
