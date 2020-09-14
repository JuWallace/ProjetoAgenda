using Agenda_WPF.DAL;
using Agenda_WPF.Model;
using Agenda_WPF.Utils;
using System.Windows;


namespace Agenda_WPF.View
{
    /// <summary>
    /// Interaction logic for frmCadastrarUsuario.xaml
    /// </summary>
    public partial class frmCadastrarUsuario : Window
    {
        public frmCadastrarUsuario()
        {
            InitializeComponent();
            txtNomeUsuario.Focus();
            LimpaCampos();
        }

        private void LimpaCampos()
        {
            btnCadastrar.IsEnabled = true;
            btnBuscarUsuario.IsEnabled = true;
            btnEditar.IsEnabled = false;
            btnExcluir.IsEnabled = false;
            btnSairUsuario.IsEnabled = true;

            txtNomeUsuario.Clear();
            txtCpfUsuario.Clear();
            txtEmailUsuario.Clear();
            pwdSenhaUsuario.Clear();
            chkAdministrador.IsChecked = false;
            chkMedico.IsChecked = false;
            chkAtendente.IsChecked = false;

        }

        private void btnCadastrar_Click(object sender, RoutedEventArgs e)
        {
            Context ctx = SingletonContext.GetInstance();
            Usuario usr = new Usuario();
            usr.Nome = txtNomeUsuario.Text;
            usr.Cpf = txtCpfUsuario.Text;
            usr.Email = txtEmailUsuario.Text;
            usr.Senha = pwdSenhaUsuario.Password;

            if (chkAdministrador.IsChecked == true)
            {
                usr.Administrador = chkAdministrador.IsChecked.Value;
            }

            if (chkMedico.IsChecked == true)
            {
                usr.Medico = chkMedico.IsChecked.Value;
            }

            if (chkAtendente.IsChecked == true)
            {
                usr.Atendente = chkAtendente.IsChecked.Value;
            }

            if (Valida.ValidarCPF(usr.Cpf))
            {
                if (UsuarioDAO.CadastrarUsuario(usr))
                {
                    MessageBox.Show("Usuário cadastrado!");
                    LimpaCampos();
                    txtNomeUsuario.Focus();
                }
                else
                {
                    MessageBox.Show("Usuário já existe.");
                    txtNomeUsuario.Focus();
                }
            }
            else
            {
                MessageBox.Show("CPF inválido.");
            }
        }

        private void btnSairUsuario_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnBuscarUsuario_Click(object sender, RoutedEventArgs e)
        {
            frmListarUsuario listarUsuarios = new frmListarUsuario();
            listarUsuarios.Show();
        }
    }
}
