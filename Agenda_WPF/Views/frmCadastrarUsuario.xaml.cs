using Agenda_WPF.DAL;
using Agenda_WPF.Model;
using Agenda_WPF.Utils;
using RestSharp;
using RestSharp.Serialization.Json;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows;


namespace Agenda_WPF.Views
{
    /// <summary>
    /// Interaction logic for frmCadastrarUsuario.xaml
    /// </summary>
    public partial class frmCadastrarUsuario : Window
    {
        Context ctx = SingletonContext.GetInstance();
        private Usuario usuario;

        public frmCadastrarUsuario()
        {
            InitializeComponent();
        }

        // ================ INÍCIO MÉTODOS ================
        private void ControleBotoes(int op)
        {
            if (op == 1) //default
            {
                btnBuscarCep.IsEnabled = false;
                btnCadastrar.IsEnabled = true;
                btnAlterar.IsEnabled = false;
                btnListar.IsEnabled = true;
                btnExcluir.IsEnabled = false;
                btnCancelar.IsEnabled = false;
            }
            if (op == 2) // Alterar
            {
                btnBuscarCep.IsEnabled = false;
                btnCadastrar.IsEnabled = false;
                btnAlterar.IsEnabled = true;
                btnAlterar.Focus();
                btnListar.IsEnabled = false;
                btnExcluir.IsEnabled = true;
                btnCancelar.IsEnabled = true;
            }
            if (op == 3) // Excluir
            {
                btnBuscarCep.IsEnabled = false;
                btnCadastrar.IsEnabled = false;
                btnAlterar.IsEnabled = false;
                btnListar.IsEnabled = true;
                btnExcluir.IsEnabled = true;
                btnExcluir.Focus();
                btnCancelar.IsEnabled = true;
            }
        }
        private void LimpaCampos()
        {
            txtId.Clear();
            mskCpf.Clear();
            txtNome.Clear();
            txtRg.Clear();
            mskdtaNascimento.Clear();
            mskTelefone.Clear();
            txtEmail.Clear();
            mskCep_Leave.Clear();
            txtRua.Clear();
            txtNumero.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtEstado.Clear();
            pwdSenhaUsuario.Clear();
            rdoAdministrador.IsChecked = false;
            rdoMedico.IsChecked = false;
            rdoAtendente.IsChecked = false;

            mskCpf.Focus();
        }
        private void FindCpf()
        {
            Usuario usuario = new Usuario();
            usuario.Cpf = mskCpf.Text;

            if (mskCpf.Text.Length == 11 || mskCpf.Text.Length == 14)
            {
                if (Valida.ValidarCPF(usuario.Cpf))
                {
                    var u = UsuarioDAO.BuscarUsuarioPorCpf(usuario);
                    if (u == null)
                    {
                        MessageBox.Show($"CPF: [ {usuario.Cpf} ] não encontrado!");
                        txtNome.Focus();
                    }
                    else
                    {
                        txtId.Text     = u.UsuarioID.ToString();
                        txtNome.Text   = u.Nome;
                        txtRg.Text     = u.Rg;
                        mskdtaNascimento.Text = u.Nascimento;
                        mskTelefone.Text   = u.Telefone;
                        txtEmail.Text      = u.Email;
                        mskCep_Leave.Text  = u.Cep;
                        txtRua.Text        = u.Rua;
                        txtNumero.Text     = u.Numero;
                        txtBairro.Text     = u.Bairro;
                        txtCidade.Text     = u.Cidade;
                        txtEstado.Text     = u.Estado;
                        pwdSenhaUsuario.Password = u.Senha;

                        if(rdoAdministrador.IsChecked.Value == false)
                        {
                            rdoAdministrador.IsChecked = u.Administrador;
                        }
                        if(rdoAtendente.IsChecked.Value == false)
                        {
                            rdoAtendente.IsChecked = u.Atendente;
                        }
                        if(rdoMedico.IsChecked.Value == false)
                        {
                            rdoMedico.IsChecked = u.Medico;
                        }

                        ControleBotoes(2);
                    }
                }
                else
                {
                    MessageBox.Show("CPF inválido.");
                }
            }
        }
        private void FindCep()
        {
            RestClient restClient = new RestClient(string.Format("https://viacep.com.br/ws/{0}/json/", mskCep_Leave.Text));
            RestRequest restRequest = new RestRequest(Method.GET);
            IRestResponse restResponse = restClient.Execute(restRequest);

            BuscaCep cepRetorno = new JsonDeserializer().Deserialize<BuscaCep>(restResponse);

            if (cepRetorno.cep is null)
            {
                MessageBox.Show("CEP não encontrado! ", "Atenção!", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                mskCep_Leave.Clear();
                mskCep_Leave.Focus();
                return;
            }
            txtRua.Text = cepRetorno.logradouro;
            txtBairro.Text = cepRetorno.bairro;
            txtCidade.Text = cepRetorno.localidade;
            txtEstado.Text = cepRetorno.uf;
        }
        private void HabbtnBuscarCep(object sender, RoutedEventArgs e)
        {
            btnBuscarCep.IsEnabled = true;
        }
        private void CadastrarUsuario()
        {
            if (!string.IsNullOrWhiteSpace(txtNome.Text))
            {
                usuario = new Usuario
                {
                    Cpf = mskCpf.Text,
                    Nome = txtNome.Text,
                    Rg = txtRg.Text,
                    Nascimento = mskdtaNascimento.Text,
                    Telefone = mskTelefone.Text,
                    Email = txtEmail.Text,
                    Cep = mskCep_Leave.Text,
                    Rua = txtRua.Text,
                    Numero = txtNumero.Text,
                    Bairro = txtBairro.Text,
                    Cidade = txtCidade.Text,
                    Estado = txtEstado.Text,
                    Senha  = Encrypta.GetMD5(pwdSenhaUsuario.Password),
                    Administrador = rdoAdministrador.IsChecked.Value,
                    Atendente  = rdoAtendente.IsChecked.Value,
                    Medico     = rdoMedico.IsChecked.Value
                };
                if (UsuarioDAO.CadastrarUsuario(usuario))
                {
                    MessageBox.Show("Usuário cadastrado!", "AGENDA MÉDICA WPF",
                        MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Esse Usuário já existe!", "AGENDA MÉDICA WPF",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Preencha o campo Nome!", "AGENDA MÉDICA WPF",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void AlterarUsuario()
        {
            Usuario u = new Usuario();
            u.Cpf = mskCpf.Text;
            var us = UsuarioDAO.BuscarUsuarioPorCpf(u);
            if (us != null)
            {
                us.Cpf      = mskCpf.Text;
                us.Nome     = txtNome.Text;
                us.Rg       = txtRg.Text;
                us.Nascimento = mskdtaNascimento.Text;
                us.Telefone = mskTelefone.Text;
                us.Email  = txtEmail.Text;
                us.Cep    = mskCep_Leave.Text;
                us.Rua    = txtRua.Text;
                us.Numero = txtNumero.Text;
                us.Bairro = txtBairro.Text;
                us.Cidade = txtCidade.Text;
                us.Estado = txtEstado.Text;
                us.Senha = Encrypta.GetMD5(pwdSenhaUsuario.Password);
                us.Administrador = rdoAdministrador.IsChecked.Value;
                us.Atendente = rdoAtendente.IsChecked.Value;
                us.Medico = rdoMedico.IsChecked.Value;

                UsuarioDAO.AlterarUsuario(us);
                MessageBox.Show("Cadastro do Usuário Atualizado!!", "AGENDA MÉDICA WPF - Atualiza Usuário",
                                 MessageBoxButton.OK, MessageBoxImage.Information);
            }   
        }
        private void ExcluirUsuario()
        {
            Usuario u = new Usuario();
            u.Cpf = mskCpf.Text;
            var us = UsuarioDAO.BuscarUsuarioPorCpf(u);
            if (us != null)
            {
                UsuarioDAO.RemoverUsuario(us);
                MessageBox.Show("Usuário removido!", "Vendas WPF - Cadastro de Usuário",
                                 MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Não foi possível remover o Usuário", "Vendas WPF - Cadastro de Usuário",
                                 MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        
        // ================ FIM MÉTODOS ================

        private void Windos_Loaded(object sender, RoutedEventArgs e)
        {
            ControleBotoes(1);
            LimpaCampos();
            //LoadCboPlano();
        }
        private void btnBuscarCpf_Click(object sender, RoutedEventArgs e)
        {
            FindCpf();
        }
        private void btnBuscaCep_Click(object sender, RoutedEventArgs e)
        {
            FindCep();
        }
        private void btnCadastrar_Click(object sender, RoutedEventArgs e)
        {
            CadastrarUsuario();
            LimpaCampos();
            ControleBotoes(1);
        }
        private void btnAlterar_Click(object sender, RoutedEventArgs e)
        {
            AlterarUsuario();
            LimpaCampos();
            ControleBotoes(1);
        }
        private void btnListar_Click(object sender, RoutedEventArgs e)
        {
            frmListarUsuario listarUsuario = new frmListarUsuario();
            listarUsuario.ShowDialog();
        }
        private void btnExcluir_Click(object sender, RoutedEventArgs e)
        {
            ExcluirUsuario();
            LimpaCampos();
            ControleBotoes(1);

        }
        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            LimpaCampos();
            ControleBotoes(1);
        }
        private void btnFechar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void btnListarUsuario_Click(object sender, RoutedEventArgs e)
        {
            LimpaCampos();
        }
        private void txtRua_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if(this.txtRua.Text != null)
            {
                txtNumero.Focus();
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }


    }
}
