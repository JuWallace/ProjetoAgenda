using Agenda_WPF.DAL;
using Agenda_WPF.Model;
using Agenda_WPF.Utils;
using System.Windows;


namespace Agenda_WPF.Views
{
    /// <summary>
    /// Interaction logic for frmLogin.xaml
    /// </summary>
    public partial class frmLogin : Window
    {
        public frmLogin()
        {
            InitializeComponent();
            txtEmailLogin.Focus();
        }

        //Context ctx = SingletonContext.GetInstance();
        Usuario u = new Usuario();
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            u.Email = txtEmailLogin.Text;

            var usr = UsuarioDAO.ValidaLogin(u.Email);
            if (usr == null)
            {
                MessageBox.Show($"Informe um LOGIN válido!");
            }
            else if (usr.Email == txtEmailLogin.Text && usr.Senha == Encrypta.GetMD5(pwdSenhaLogin.Password))
            {
                if (usr.Administrador == true)
                {
                    MainWindow principal = new MainWindow(usr.Nome);
                    principal.Show();
                    this.Close();
                }
                else if (usr.Medico == true)
                {
                    frmTelaPrincipalMedico viewMedico = new frmTelaPrincipalMedico(usr.Nome);
                    viewMedico.Show();
                    this.Close();
                }
                else
                {
                    frmTelaPrincipalRecepcionista viewAtendente = new frmTelaPrincipalRecepcionista(usr.Nome);
                    viewAtendente.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show($"Usuário e ou Senha Inválido(a)!!");
            }
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void txtEmailLogin_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            string adm = "admin1";
            string atd = "atendente1";
            string med = "medico1";
            if (txtEmailLogin.Text == adm)
            {
                txtEmailLogin.Text = ($"{adm}@agenda.com.br");
                pwdSenhaLogin.Focus();
            }
            if (txtEmailLogin.Text == atd)
            {
                txtEmailLogin.Text = ($"{atd}@agenda.com.br");
                pwdSenhaLogin.Focus();
            }
            if (txtEmailLogin.Text == med)
            {
                txtEmailLogin.Text = ($"{med}@agenda.com.br");
                pwdSenhaLogin.Focus();
            }
        }
    }
}
