using Agenda_WPF.DAL;
using Agenda_WPF.Model;
using Agenda_WPF.Utils;
using RestSharp;
using RestSharp.Serialization.Json;
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
            LoadCboPlano();
            txtNome.Focus();
        }
        private void LoadCboPlano()
        {
            cboPlano.Items.Add("AMIL");
            cboPlano.Items.Add("BRADESCO SAÚDE");
            cboPlano.Items.Add("BRADESCO SEGUROS");
            cboPlano.Items.Add("SINAN");
            cboPlano.Items.Add("UNIMED");
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
            cboPlano.SelectedIndex = -1;
            txtNPlano.Clear();
            txtRua.Clear();
            txtNumero.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtEstado.Clear();
            txtCep_Leave.Clear();
        }

        private void btnInserir_Click(object sender, RoutedEventArgs e)
        {
            //this.operacao = "inserir";
            //this.AlteraBotoes(2);
            Context ctx = SingletonContext.GetInstance();
            Paciente pac = new Paciente();
            pac.Nome = txtNome.Text;
            pac.Cpf = txtCpf.Text;
            pac.Rg = txtRg.Text;
            pac.Nascimento = txtDtaNascimento.Text;
            pac.Telefone = txtTelefone.Text;
            pac.Email = txtEmail.Text;
            pac.NomePlano = cboPlano.Text;
            pac.NumPlano = txtNPlano.Text;
            pac.Rua = txtRua.Text;
            pac.Numero = txtNumero.Text;
            pac.Bairro = txtBairro.Text;
            pac.Cidade = txtCidade.Text;
            pac.Estado = txtEstado.Text;
            pac.Cep = txtCep_Leave.Text;

            //if (operacao == "inserir")
            //{
            //    Context context = new Context();
            //    {
            //        context.Pacientes.Add(p);
            //        context.SaveChanges();
            //    }

            //}
            //if (operacao == "alterar")
            //{
            //    {
            //        ctx.Pacientes.Add(p);
            //        ctx.SaveChanges();
            //    }
            //}

            ////this.ListarDados();
            //this.AlteraBotoes(1);
            //this.LimpaCampos();

            if (Valida.ValidarCPF(pac.Cpf))
            {
                if (PacienteDAO.CadastrarPaciente(pac))
                {
                    MessageBox.Show("Paciente cadastrado!");
                    LimpaCampos();
                    txtNome.Focus();
                }
                else
                {
                    MessageBox.Show("Paciente já existe.");
                    txtNome.Focus();
                }
            }
            else
            {
                MessageBox.Show("CPF inválido.");
            }

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

        //private void AlteraBotoes(int op)
        //{
        //    btnAlterar.IsEnabled = false;
        //    btnCadastrar.IsEnabled = false;
        //    btnExcluir.IsEnabled = false;
        //    btnCancelar.IsEnabled = false;
        //    btnLocalizar.IsEnabled = false;
        //    btnSalvar.IsEnabled = false;

        //    if (op == 1)
        //    {
        //        //ativar as opções iniciais
        //        btnCadastrar.IsEnabled = true;
        //        btnLocalizar.IsEnabled = true;
        //    }
        //    if (op == 2)
        //    {
        //        //inserir um valor
        //        btnCancelar.IsEnabled = true;
        //        btnSalvar.IsEnabled = true;
        //    }
        //    if (op == 3)
        //    {
        //        btnAlterar.IsEnabled = true;
        //        btnExcluir.IsEnabled = true;
        //    }
        //}

        //private void textCep_Leave(object sender, EventArgs e)
        //{
        //    LocalizarCEP();
        //}
        private void btnBuscaCep_Click(object sender, RoutedEventArgs e)
        {
            LocalizarCEP();
        }

        private void LocalizarCEP()
        {
            RestClient restClient = new RestClient(string.Format("https://viacep.com.br/ws/{0}/json/", txtCep_Leave.Text));
            RestRequest restRequest = new RestRequest(Method.GET);
            IRestResponse restResponse = restClient.Execute(restRequest);

            BuscaCep cepRetorno = new JsonDeserializer().Deserialize<BuscaCep>(restResponse);

            if (cepRetorno.cep is null)
            {
                MessageBox.Show("CEP não encontrado! ", "Atenção!", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                txtCep_Leave.Clear();
                txtCep_Leave.Focus();
                return;
            }
            txtRua.Text = cepRetorno.logradouro;
            txtBairro.Text = cepRetorno.bairro;
            txtCidade.Text = cepRetorno.localidade;
            txtEstado.Text = cepRetorno.uf;
        }

 
        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            //this.AlteraBotoes(1);
            this.LimpaCampos();
        }


        private void btn_Fechar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }

}
